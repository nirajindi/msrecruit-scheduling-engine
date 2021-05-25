//-----------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
//-----------------------------------------------------------------------
using System.Runtime.Serialization;

namespace HR.TA.TalentEntities.Enum
{
    [DataContract(Namespace = "HR.TA.TalentEngagement")]
    public enum AssessmentProvider
    {
        [EnumMember(Value = "default")]
        Default = 0,

        [EnumMember(Value = "koru")]
        Koru = 1 
    }
}