using System;
using System.Collections.Generic;

namespace connectionDB.Models;

public partial class TbAddress
{
    public int IdAddress { get; set; }

    public string NmState { get; set; } = null!;

    public string NmCity { get; set; } = null!;

    public string NmStreet { get; set; } = null!;

    public string NmNeighborhood { get; set; } = null!;

    public int NrHouseNumber { get; set; }

    public string? NmComplement { get; set; }

    public int? NrZipCode { get; set; }

    public virtual ICollection<TbUser> TbUsers { get; } = new List<TbUser>();
}
