using System;
using System.Collections.Generic;

namespace connectionDB.Models;

public partial class TbGrade
{
    public int IdGrades { get; set; }

    public int IdUserClass { get; set; }

    public decimal Prova1 { get; set; }

    public decimal Prova2 { get; set; }

    public decimal ExCp1 { get; set; }

    public decimal ExCp2 { get; set; }

    public decimal Portfolio { get; set; }

    public decimal Project { get; set; }

    public decimal? Exam { get; set; }

    public virtual TbUserClass IdUserClassNavigation { get; set; } = null!;
}
