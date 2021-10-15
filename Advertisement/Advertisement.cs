namespace Advertisement
{
    public class Advertisement
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public string SellerName { get; set; }

        public int CompareTo(object obj)
        {
            Advertisement adToCompare = (Advertisement)obj;
            if (Cost > adToCompare.Cost)
            {
                    return 1;
            }
            else if (Cost < adToCompare.Cost)
            {
                    return 0;
            }
            else
            {
                    return -1;
            }
        }
        public override string ToString()
        {
            return $"{Name} {Cost} {SellerName}";
        }

        public static bool operator <(Advertisement ad1, Advertisement ad2)
        {
            return ad1.Cost < ad2.Cost;
        }
        public static bool operator >(Advertisement ad1, Advertisement ad2)
        {
            return ad1.Cost > ad2.Cost;
        }
        public Advertisement(string name, double cost, string sellername) 
        {
            Name = name;
            Cost = cost;
            SellerName = sellername;
        }
    }
}
