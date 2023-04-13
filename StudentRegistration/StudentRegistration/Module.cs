using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentRegistration;

public partial class Module
{
    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string ModuleCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Credits { get; set; }
}
