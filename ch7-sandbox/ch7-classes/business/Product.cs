using System;
using System.Collections.Generic;
using System.Text;

namespace ch7_classes.business {
    class Product {
        String code { get; set; };
        String description { get; set; };
        double price { get; set; };

        public Product() {
        }

        public Product(string code, string description, double price) {
            this.code = code;
            this.description = description;
            this.price = price;
        }
 
   }
}
