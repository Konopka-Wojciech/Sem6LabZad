﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMoqDual
{
    public class OrderProcessor
    {
        private IOrderService _orderService;

        public OrderProcessor(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void ProcessOrder(string product, int quantity)
        {
            // Przetwarzanie zamówienia
            _orderService.PlaceOrder(product, quantity);
        }


    }
}
