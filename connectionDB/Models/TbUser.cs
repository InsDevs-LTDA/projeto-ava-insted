using System;
using System.Collections.Generic;

namespace connectionDB.Models;

public partial class TbUser
{
    public int IdUser { get; set; }

    public int IdAddress { get; set; }

    public string NmUser { get; set; } = null!;

    public long NrRegister { get; set; }

    public string NrCpf { get; set; } = null!;

    public int? NrRg { get; set; }

    public string? NmExpedition { get; set; }

    public DateTime DtBirthdate { get; set; }

    public string? NmSex { get; set; }

    public int NmPhone1 { get; set; }

    public int? NmPhone2 { get; set; }

    public string? NmEmail { get; set; }

    public string? NmPassword { get; set; }

    public byte[]? ImgFile { get; set; }

    public bool SnTeacher { get; set; }

    public virtual TbAddress IdAddressNavigation { get; set; } = null!;

    public virtual ICollection<TbClass> TbClasses { get; } = new List<TbClass>();
}
