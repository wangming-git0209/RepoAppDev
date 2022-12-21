﻿using Microsoft.AspNetCore.Authorization;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ASM_App_Dev.Utils;

namespace ASM_App_Dev.Models
{
    [Authorize(Roles = Role.STORE_OWNER)]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name of Book can not be null")]
        [StringLength(255)]
        public string NameBook { get; set; }
        [Required(ErrorMessage = "Quantity can not be null")]
        public int QuantityBook { get; set; }
        [Required(ErrorMessage = "Price can not be null")]
        public int Price { get; set; }
        public string InformationBook { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public byte[] Image { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
