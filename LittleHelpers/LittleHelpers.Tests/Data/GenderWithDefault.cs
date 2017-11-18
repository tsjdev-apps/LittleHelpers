using System.ComponentModel;

namespace LittleHelpers.Tests.Data
{


    public enum GenderWithDefault
    {
        Female,
        [DefaultValue(Male)]
        Male
    }
}
