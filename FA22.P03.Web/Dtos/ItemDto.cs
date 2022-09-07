﻿using System.ComponentModel.DataAnnotations;

namespace FA22.P03.Web.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string? Condition { get; set; }
        public string? ProductName { get; set; }
        public int ProductId { get; set; }
    }
}
