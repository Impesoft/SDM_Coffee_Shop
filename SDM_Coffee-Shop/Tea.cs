namespace SDM_Coffee_Shop
{
    class Tea : Beverages
    {
        public int Caffeine { get; set; }

        public bool IsInfusion { get; set; }

        public bool HasMilk  { get; set; }

        public bool HasSugar { get; set; }

        public double Price { get; set; }
    }
}
