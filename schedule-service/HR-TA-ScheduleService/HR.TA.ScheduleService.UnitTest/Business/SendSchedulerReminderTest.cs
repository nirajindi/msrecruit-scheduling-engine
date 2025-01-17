//-----------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
//-----------------------------------------------------------------------
namespace HR.TA.ScheduleService.UnitTest.Business
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using HR.TA.Common.Common.Common.Email.Contracts;
    using HR.TA.Common.Provisioning.Entities.FalconEntities.Attract;
    using HR.TA.Common.TalentEntities.Common;
    using HR.TA.ScheduleService.BusinessLibrary.Configurations;
    using HR.TA.ScheduleService.BusinessLibrary.Interface;
    using HR.TA.ScheduleService.BusinessLibrary.Notification;
    using HR.TA.ScheduleService.Contracts.V1;
    using HR.TA.ScheduleService.Data.DataProviders;
    using HR.TA.ScheduleService.FalconData.Query;
    using HR.TA.ServicePlatform.Configuration;
    using HR.TA.ServicePlatform.Tracing;
    using HR.TA.Talent.FalconEntities.Attract;
    using BEM = BusinessLibrary.Business.V1;

    /// <summary>
    /// Tests for SendSchedulerReminder method
    /// </summary>
    [TestClass]
    public class SendSchedulerReminderTest
    {
        private Mock<IFalconQueryClient> falconQueryClient;
        private Mock<FalconQuery> falconQuery;
        private BEM.EmailManager manager;
        private Mock<INotificationClient> notificationClient;
        private Mock<IConfigurationManager> mockConfiguarationManager;
        private Mock<ITraceSource> mockTraceSource;
        private Mock<IScheduleQuery> mockScheduleQuery;
        private Mock<ILogger<BEM.EmailManager>> loggerMock;
        private Mock<IEmailHelper> emailHelperMock;
        private Mock<ILogger<FalconQuery>> loggerMockFalconQuery;
        private Mock<IInternalsProvider> internalsProviderMock;

        /// <summary>
        /// Test initialization.
        /// </summary>
        [TestInitialize]
        public void BeforeEach()
        {
            this.loggerMockFalconQuery = new Mock<ILogger<FalconQuery>>();
            this.falconQueryClient = new Mock<IFalconQueryClient>();
            this.falconQuery = new Mock<FalconQuery>(this.falconQueryClient.Object, this.loggerMockFalconQuery.Object);
            this.notificationClient = new Mock<INotificationClient>();
            this.mockConfiguarationManager = new Mock<IConfigurationManager>();
            this.mockTraceSource = new Mock<ITraceSource>();
            this.mockScheduleQuery = new Mock<IScheduleQuery>();
            this.loggerMock = new Mock<ILogger<BEM.EmailManager>>();
            this.internalsProviderMock = new Mock<IInternalsProvider>();
            this.emailHelperMock = new Mock<IEmailHelper>();
            this.manager = new BEM.EmailManager(this.notificationClient.Object, this.falconQuery.Object, this.mockConfiguarationManager.Object, this.mockTraceSource.Object, this.mockScheduleQuery.Object, this.emailHelperMock.Object, this.internalsProviderMock.Object, this.loggerMock.Object);
        }

        /// <summary>
        /// SendSchedulerReminder Test with valid input
        /// </summary>
        /// /// <returns><see cref="Task"/> for the asynchronous operation.</returns>
        [TestMethod]
        public async Task SendSchedulerReminderTestValidInput()
        {
            Worker worker1 = new Worker { OfficeGraphIdentifier = "123", Name = new PersonName { GivenName = "test", Surname = "1" }, FullName = "test 1", EmailPrimary = "test1@microsoft.com" };
            JobOpening job1 = new JobOpening { PositionTitle = "Title1" };
            JobApplicationParticipant participant = new JobApplicationParticipant { OID = "123", Role = TalentEntities.Enum.JobParticipantRole.Contributor };
            IList<JobApplicationParticipant> participants = new List<JobApplicationParticipant>();
            participants.Add(participant);
            JobApplication jobApplication1 = new JobApplication { JobApplicationID = "123", ExternalJobApplicationID = "456", JobOpening = job1, JobApplicationParticipants = participants };
            JobApplicationSchedule schedule1 = new JobApplicationSchedule { JobApplicationID = "123", ScheduleRequester = worker1, StartDateTime = DateTime.UtcNow, EndDateTime = DateTime.UtcNow };
            IList<JobApplicationSchedule> schedules = new List<JobApplicationSchedule>();
            List<Worker> workers = new List<Worker>();
            List<JobApplication> jobApplications = new List<JobApplication>();
            jobApplications.Add(jobApplication1);
            workers.Add(worker1);
            schedules.Add(schedule1);
            Common.Email.Contracts.EmailTemplate emailTemplate = new Common.Email.Contracts.EmailTemplate { Subject = "subject", Body = "body" };
            EmailTemplateConfiguaration emailTemplateConfiguaration = new EmailTemplateConfiguaration { };
            IVClientConfiguration clientConfiguration = new IVClientConfiguration { RecruitingHubClientUrl = "clienturl" };
            Timezone timeZoneInfo = new Timezone { TimezoneAbbr = "IST", UTCOffset = 120 };

            this.mockConfiguarationManager
                .Setup(c => c.Get<EmailTemplateConfiguaration>())
                .Returns(emailTemplateConfiguaration);
            this.mockConfiguarationManager
                .Setup(c => c.Get<IVClientConfiguration>())
                .Returns(clientConfiguration);
            this.mockScheduleQuery
                .Setup(c => c.GetTemplate(It.IsAny<string>()))
                .ReturnsAsync(emailTemplate);
            this.mockScheduleQuery
                .Setup(c => c.GetPendingSchedules(It.IsAny<bool>()))
                .ReturnsAsync(schedules);
            this.mockScheduleQuery
                .Setup(c => c.GetJobApplications(It.IsAny<List<string>>()))
                .ReturnsAsync(jobApplications);
            this.mockScheduleQuery
                .Setup(c => c.GetWorkers(It.IsAny<List<string>>()))
                .ReturnsAsync(workers);
            this.mockScheduleQuery
                .Setup(c => c.GetJobOpeningPositionTitle(It.IsAny<string>()))
                .ReturnsAsync("Title1");
            this.mockScheduleQuery
               .Setup(c => c.GetTimezoneForJobApplication(It.IsAny<string>()))
               .ReturnsAsync(timeZoneInfo);
            this.notificationClient
                .Setup(c => c.SendEmail(It.IsAny<List<NotificationItem>>(), It.IsAny<string>()))
                .ReturnsAsync(true);

            var result = await this.manager.SendSchedulerReminder();

            this.mockScheduleQuery
               .Verify(c => c.GetJobApplications(It.IsAny<List<string>>()), Times.Once, "Expected to get jobapplication once.");
            this.notificationClient
               .Verify(c => c.SendEmail(It.IsAny<List<NotificationItem>>(), It.IsAny<string>()), Times.Once, "Expected to send notification once.");
        }
    }
}
