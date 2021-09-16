﻿using System;

namespace Products.Service.EventHandlers.Exceptions
{
    public class ProductInStockUpdateStockCommandException : Exception
    {
        public ProductInStockUpdateStockCommandException(string message) : base(message) { }
    }
}
