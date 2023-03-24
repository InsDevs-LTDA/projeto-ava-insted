using System;
using System.Collections.Generic;

namespace connectionDB.Models;

public partial class TbFrequency
{
    public int IdFrequency { get; set; }

    public int IdUserClass { get; set; }

    public int NrPresece { get; set; }

    public DateTime DtDate { get; set; }

    public virtual TbUserClass IdUserClassNavigation { get; set; } = null!;
}
