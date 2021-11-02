namespace StoreModels
{
    public class LineItem
    {   
        public int ProductId    { get; set; }
        public int LocationId   { get; set; }
        public string ItemName { get; set; }
        public int Inventory    { get; set; }
        public decimal Price    {  get; set; }
        
        public override string ToString()
        {
            return $"LocationId: {LocationId}\nItemName: {ItemName}\nInventory:{Inventory}\nPrice: {Price}";
        }    
    }    
}

