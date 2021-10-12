using System;
using System.ComponentModel;

namespace Blog.Enums
{
    public enum ModerationTypes
    {
        [Description("Political propaganda")]
        Political,
        [Description("Offensive language")]
        Language,
        [Description("Drug references")]
        Drugs,
        [Description("Threatening speech")]
        Threatening,
        [Description("Sexual content")]
        Sexual,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Targeted Speech")]
        Shaming,
        [Description("Other (use this sparingly)")]
        Other
    }
}
