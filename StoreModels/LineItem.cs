namespace StoreModels
{
    public class LineItem
    {   
        public int ItemId    { get; set; }
        //public int LocationId   { get; set; }

        public int Inventory    { get; set; }
    
        
        public override string ToString()
        {
            return $"ItemId: {ItemId}\nInventory:{Inventory}";
        }    
    }    
}

