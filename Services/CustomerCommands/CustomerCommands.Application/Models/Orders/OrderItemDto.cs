﻿namespace CustomerCommands.Application.Models.Orders
{
    public class OrderItemDto
    {
        public string? Name { get; set; }
        public int? Quantity { get; set; }
        public Guid? MembershipId { get; set; }
        public Guid? ProductId { get; set; }
    }
}
