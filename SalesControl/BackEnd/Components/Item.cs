﻿using System;

namespace SalesControl.BackEnd.Components {

    public class Item : Component {
        private readonly Product product;
        private double quantity;
        private double total_price;

        public Item(Product product, double quantity) : base(product.GetId()) {
            this.product = product ?? throw new ArgumentException("Объект продукт не может быть равен нулю.");
            SetQuantityPrice(quantity);
        }

        public Product GetProduct() {
            return product;
        }

        public double GetQuantity() {
            return quantity;
        }

        public double GetTotalPrice() {
            return total_price;
        }

        public void SetQuantityPrice(double quantity) {
            if (quantity < 0) {
                throw new System.ArgumentException("Количество товара должно быть положительным значением.");
            }
            this.quantity = quantity;
            this.total_price = quantity * product.GetPrice();
        }

        public Item Clone() {
            return (Item)this.MemberwiseClone();
        }

        public override string ToString() {
            return string.Format(
                "[{0}] {1}: {2:0.00} кг x ${3:0.00} = ${4:0.00}",
                id,
                product.GetName(),
                quantity,
                product.GetPrice(),
                total_price
            );
        }
    }
}