﻿//-----------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
//-----------------------------------------------------------------------

namespace HR.TA.Common.Provisioning.Entities.FalconEntities.OfferRule
{
    using HR.TA.Common.DocumentDB.Contracts;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class JobOfferRuleAttributeData : DocDbEntity
    {
        [DataMember(Name = "RulesetId")]
        public string RulesetId { get; set; }

        [DataMember(Name = "RulesetVersionId")]
        public string RulesetVersionId { get; set; }

        [DataMember(Name = "PreviousTokenValues")]
        public IDictionary<string, string> PreviousTokenValues { get; set; }

        [DataMember(Name = "CurrentTokenId")]
        public string CurrentTokenId { get; set; }

        [DataMember(Name = "CurrentColumnValue")]
        public string CurrentTokenValue { get; set; }

        [DataMember(Name = "NextTokenId")]
        public string NextTokenId { get; set; }

        [DataMember(Name = "NextTokenValues")]
        public IList<string> NextTokenValues { get; set; }
    }
}