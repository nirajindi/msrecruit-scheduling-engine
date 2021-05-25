﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR.TA.ScheduleService.BusinessLibrary.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ScheduleServiceEmailStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ScheduleServiceEmailStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HR.TA.ScheduleService.BusinessLibrary.Strings.ScheduleServiceEmailStrings", typeof(ScheduleServiceEmailStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks,&lt;br /&gt;The {CompanyName} admin team.
        /// </summary>
        internal static string Closing {
            get {
                return ResourceManager.GetString("Closing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ResponsiveEmailTemplate.
        /// </summary>
        internal static string CompanyInfoFooter {
            get {
                return ResourceManager.GetString("CompanyInfoFooter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {Requester_Name} &lt;br /&gt;{Requester_Email}&lt;br /&gt;Microsoft Recruiting.
        /// </summary>
        internal static string FeedbackReminderToInterviewer_Closing {
            get {
                return ResourceManager.GetString("FeedbackReminderToInterviewer_Closing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  Microsoft respects your &lt;a href=&apos;&apos;&gt;privacy&lt;/a&gt;. See our &lt;a href=&apos;&apos;&gt;terms of use&lt;/a&gt;..
        /// </summary>
        internal static string FeedbackReminderToInterviewer_Footer {
            get {
                return ResourceManager.GetString("FeedbackReminderToInterviewer_Footer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dear {Interviewer_FirstName}‌,.
        /// </summary>
        internal static string FeedbackReminderToInterviewer_Greeting {
            get {
                return ResourceManager.GetString("FeedbackReminderToInterviewer_Greeting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is important that we receive your feedback from your recent interview with {Candidate_Name} for the {Job_Title} position. In order for {HiringManager_Name} to select the best candidate for this position they need your feedback. Please take a few moments and submit your feedback &lt;a href=&apos;{Feedback_Link}&apos;&gt;here&lt;/a&gt;..
        /// </summary>
        internal static string FeedbackReminderToInterviewer_Paragraph1 {
            get {
                return ResourceManager.GetString("FeedbackReminderToInterviewer_Paragraph1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {Candidate_Name}‌ - Feedback link - {Job_Title}‌ ({External_Job_Id}).
        /// </summary>
        internal static string FeedbackReminderToInterviewer_Subject {
            get {
                return ResourceManager.GetString("FeedbackReminderToInterviewer_Subject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi,.
        /// </summary>
        internal static string Greeting {
            get {
                return ResourceManager.GetString("Greeting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;tr&gt;
        /// &lt;td style=&apos;vertical-align:top; border-bottom-style: solid;border-width: 0 0 1px 0;border-color: #EAEAEA; padding: 27px 0px 28px 20px;&apos;&gt;{StartTime} - {EndTime} &lt;br&gt; {InterviewTitle}&lt;/td&gt;
        ///{InterviewColumns}
        ///        &lt;/tr&gt;.
        /// </summary>
        internal static string InterviewRowTemplate {
            get {
                return ResourceManager.GetString("InterviewRowTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;table style=&quot;BORDER-COLLAPSE: collapse&quot;&gt;
        ///    &lt;tbody&gt;
        ///&lt;tr&gt;
        ///&lt;td colspan=&quot;4&quot; style=&apos;border-width: 0px 0px 0 0; padding-bottom: 24px; text-align:left&apos;&gt;
        ///&lt;img height=&quot;16&quot; width=&quot;20&quot; src=&apos;{CalendarImage}&apos;/&gt;&amp;nbsp;&amp;nbsp;&amp;nbsp;
        ///&lt;span&gt;{InterviewDate} - {TimeZone}&lt;/span&gt;
        ///&lt;/td&gt;
        ///&lt;/tr&gt;
        ///&lt;tr style=&apos;BACKGROUND-COLOR: #f4f4f4&apos;&gt; 
        ///&lt;td style=&apos;border-bottom-style: solid;border-width: 0 0 1px 0;border-color: #EAEAEA; padding: 15px 10px 10px 20px;&apos;&gt;Interview time &amp; title&lt;/td&gt;
        ///{TableHeaders}
        ///&lt;/tr&gt;
        /// 	{InterviewRowTemplat [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InterviewTable {
            get {
                return ResourceManager.GetString("InterviewTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;td style=&apos;border-bottom-style: solid;border-width: 0 0 1px 0;border-color: #EAEAEA; padding: 15px 10px 10px 20px;&apos;&gt;Interviewers&lt;/td&gt;.
        /// </summary>
        internal static string InterviwersHeader {
            get {
                return ResourceManager.GetString("InterviwersHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;td style=&apos;vertical-align:top; border-bottom-style: solid;border-width: 0 0 1px 0;border-color: #EAEAEA;  padding: 27px 0px 28px 20px;&apos;&gt;{InterviewerName}&lt;/td&gt;.
        /// </summary>
        internal static string IsInterviewerNameRequiredTemplate {
            get {
                return ResourceManager.GetString("IsInterviewerNameRequiredTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;td style=&apos;border-bottom-style: solid;border-width: 0 0 1px 0;border-color: #EAEAEA; padding: 15px 10px 10px 20px;&apos;&gt;Location&lt;/td&gt;.
        /// </summary>
        internal static string LocationHeader {
            get {
                return ResourceManager.GetString("LocationHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;td style=&apos;vertical-align:top; border-bottom-style: solid;border-width: 0 0 1px 0;border-color: #EAEAEA; padding: 27px 0px 28px 20px;&apos;&gt;&lt;div style=&quot;display:inline-block;&quot;&gt;{Location}&lt;/div&gt;&lt;/td&gt;.
        /// </summary>
        internal static string LocationTemplate {
            get {
                return ResourceManager.GetString("LocationTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It looks like there are errors in {RulesetName} rule set file. It was unable to load on {UploadDate} at {UploadTime}. Try loading the file again or download error log for more details..
        /// </summary>
        internal static string UploadRulesetErrorNotification_Paragraph1 {
            get {
                return ResourceManager.GetString("UploadRulesetErrorNotification_Paragraph1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error in one of your rulesets.
        /// </summary>
        internal static string UploadRulesetErrorNotification_Subject {
            get {
                return ResourceManager.GetString("UploadRulesetErrorNotification_Subject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {RulesetName} rule set was successfully uploaded at {UploadTime} on {UploadDate}..
        /// </summary>
        internal static string UploadRulesetSuccessNotification_Paragraph {
            get {
                return ResourceManager.GetString("UploadRulesetSuccessNotification_Paragraph", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {RulesetName} rule set has been uploaded.
        /// </summary>
        internal static string UploadRulesetSuccessNotification_Subject {
            get {
                return ResourceManager.GetString("UploadRulesetSuccessNotification_Subject", resourceCulture);
            }
        }
    }
}