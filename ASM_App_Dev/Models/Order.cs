﻿using ASM_App_Dev.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM_App_Dev.Models
{
	public class Order
	{
		[Key]
		public int Id { get; set; }
		public string UserId { get; set; }
		public ApplicationUser User { get; set; }
		public DateTime DateOrder { get; set; } = DateTime.Now;
		public int PriceOrder { get; set; }
		public OrderStatus StatusOrder { get; set; }
		public List<OrderDetail> OrderDetails { get; set; }
    }
}
