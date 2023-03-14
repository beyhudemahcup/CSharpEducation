using System;

namespace Events
{
    //I added parameter to show us which product about to finish
    public delegate void StockControl();

    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        //I want to recieve notification when the stock has been decreased under than 10 by event
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (value < 10 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }

        }
        public int Price { get; set; }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{0} Stock Amount: {1}",ProductName, Stock);
        }
    }
}
