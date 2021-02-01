namespace SDM_Coffee_Shop
{
    internal class Cappuccino : Coffee
    {
        public Cappuccino()
        {
            HasMilk = false;
            Name = "Cappuccino";
            Price = 4.99;
            Image = "cappuccino";
            Description = "A cappuccino is an espresso-based coffee drink that originated in Italy, and is traditionally prepared with steamed milk foam. Variations of the drink involve the use of cream instead of milk, using non-dairy milks, and flavoring with cinnamon or chocolate powder.";
        }
    }

    //int caffeine = 0, bool hasMilk = false, bool hasSugar = false
    //: base(caffeine, hasMilk, hasSugar)
}