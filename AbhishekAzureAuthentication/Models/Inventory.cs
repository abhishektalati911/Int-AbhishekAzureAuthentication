using System.ComponentModel.DataAnnotations;

namespace AzureAuthentication.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public string InventoryName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
