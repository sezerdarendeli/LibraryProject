using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LibraryProject.Domain.Enums
{
    public enum BookStatusEnum
    {
        [Description("Check In")]
        CheckIn=1,
        [Description("Check Out")]
        CheckOut =2,
        [Description("Avaible")]
        Avaible =3
    }
}
