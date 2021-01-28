namespace SDM_Coffee_Shop
{
    internal abstract class Tea : Beverage
    {
        public int Theine { get; set; }

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        public Tea(int theine = 0, bool hasMilk = false, bool hasSugar = false)
        {
            Theine = theine;
            HasMilk = hasMilk;
            HasSugar = hasSugar;
        }
    }
}