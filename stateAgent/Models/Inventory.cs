namespace stateAgent.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public string ItemName { get; set; }
        public int CategoryID { get; set; }
        public int Category { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
