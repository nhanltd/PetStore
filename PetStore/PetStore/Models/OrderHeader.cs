using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PetStore.Models;

[Table("OrderHeader")]
public partial class OrderHeader
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime Date { get; set; }

    [Column("customerId")]
    public int CustomerId { get; set; }

    [Column("status")]
    [StringLength(30)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [ForeignKey("CustomerId")]
    [InverseProperty("OrderHeaders")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("OrderHeader")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
