﻿using System;
using System.Collections.Generic;
using System.Text;

namespace product_manager.business {
    class Product {
        public String code { get; set; }
        public String description { get; set; }
        public double price { get; set; }

        public Product() {

        }
        public Product(string code, string description, double price) {
            this.code = code;
            this.description = description;
            this.price = price;
        }

        public override string ToString() {
            return "Product:  "+code+", "+description+", "+price;
        }
    }
}
