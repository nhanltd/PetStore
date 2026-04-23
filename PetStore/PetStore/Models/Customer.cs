using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PetStore.Models;

[Table("Customer")]
public partial class Customer
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("address")]
    [StringLength(50)]
    [Unicode(false)]
    public string Address { get; set; } = null!;

    [Column("phone")]
    [StringLength(12)]
    [Unicode(false)]
    public string Phone { get; set; } = null!;

    [Column("email")]
    [StringLength(30)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("shipToAddress")]
    [StringLength(50)]
    [Unicode(false)]
    public string ShipToAddress { get; set; } = null!;

    [InverseProperty("Customer")]
    public virtual ICollection<OrderHeader> OrderHeaders { get; set; } = new List<OrderHeader>();
}
