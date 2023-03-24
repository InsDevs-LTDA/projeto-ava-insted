using System;
using System.Collections.Generic;

namespace connectionDB.Models;

public partial class TbClassFile
{
    public int IdClassFiles { get; set; }

    public int IdClass { get; set; }

    public string NmFile { get; set; } = null!;

    public byte[] ImgFile { get; set; } = null!;
}
