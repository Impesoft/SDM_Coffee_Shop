namespace SDM_Coffee_Shop
{
    public abstract class Beverage : IBeverage
    {
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Description { get; set; }

        public int ID { get; set; }
        private int PID = 1;

        public string Image { get; set; }

        public string Name { get; set; }

        protected Beverage()
        {
            ID = PID;
            PID++;
        }

        public override string ToString()
        {
            string result = $"{Price.ToString()}, {Description}, {ID}, {Image}, {Name}";
            return result;
        }
    }
}