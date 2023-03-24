using System;
using System.Collections.Generic;

namespace connectionDB.Models;

public partial class TbUserClass
{
    public int IdUserClass { get; set; }

    public int IdUser { get; set; }

    public int IdClass { get; set; }

    public virtual TbClass IdClassNavigation { get; set; } = null!;

    public virtual ICollection<TbAcadActivity> TbAcadActivities { get; } = new List<TbAcadActivity>();

    public virtual ICollection<TbFrequency> TbFrequencies { get; } = new List<TbFrequency>();

    public virtual ICollection<TbGrade> TbGrades { get; } = new List<TbGrade>();
}
