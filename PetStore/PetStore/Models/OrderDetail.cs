using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PetStore.Models;

[Table("OrderDetail")]
public partial class OrderDetail
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("orderHeaderId")]
    public int OrderHeaderId { get; set; }

    [Column("productId")]
    public int ProductId { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("price")]
    public double Price { get; set; }

    [Column("discount")]
    public double Discount { get; set; }

    [ForeignKey("OrderHeaderId")]
    [InverseProperty("OrderDetails")]
    public virtual OrderHeader OrderHeader { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("OrderDetails")]
    public virtual Product Product { get; set; } = null!;
}
