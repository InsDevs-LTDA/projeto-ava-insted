using System;
using System.Collections.Generic;

namespace connectionDB.Models;

public partial class TbClass
{
    public int IdClass { get; set; }

    public int IdUser { get; set; }

    public string NmClass { get; set; } = null!;

    public string NmWeekday { get; set; } = null!;

    public string? NmClassroom { get; set; }

    public int? NrTotal { get; set; }

    public string? NmUser { get; set; }

    public TimeSpan DtTime { get; set; }

    public virtual TbUser IdUserNavigation { get; set; } = null!;

    public virtual ICollection<TbUserClass> TbUserClasses { get; } = new List<TbUserClass>();
}
