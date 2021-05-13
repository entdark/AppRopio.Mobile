﻿using AppRopio.Payments.CloudPayments.API.Models;

namespace AppRopio.Payments.CloudPayments.API.Requests
{
    public class ChargeRequest
    {
        public string CardCryptogramPacket { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string Name { get; set; }

        public string InvoceId { get; set; }

        public string Email { get; set; }

        public Payer Payer { get; set; }
    }
}