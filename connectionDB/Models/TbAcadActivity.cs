using System;
using System.Collections.Generic;

namespace connectionDB.Models;

public partial class TbAcadActivity
{
    public int IdAcadActivity { get; set; }

    public int IdUserClass { get; set; }

    public string NmAcadActivity { get; set; } = null!;

    public DateTime DtDeadline { get; set; }

    public virtual TbUserClass IdUserClassNavigation { get; set; } = null!;
}
