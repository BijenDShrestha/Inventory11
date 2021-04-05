using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace InventoryManagement.Models{

public class Inventory{
    public int Id { get;set;}
    
    public string Name { get;set;}
    public string Supplier { get; set;}
    public DateTime ExpDate { get; set;}
    public float Price { get; set;}
    public int Quantity {get; set;}
    
     public static List<Inventory> GetInventory()
     {
            Inventory inventory1 = new Inventory()
            {

            };
            Inventory inventory2 = new Inventory()
            {

            };
            List<Inventory> inventories =new List<Inventory>(){inventory1,inventory2};
            return inventories;
     }
}
public class Users
{
       [Key]
       public int Id{get; set;}
       [Required]
       public string firstname{get; set;}
       [Required]
       public string lastname{get; set;}
       [Required]
       public string username {get; set;}
       [Required]
       public int mobile {get; set;}
       [Required]

       public string email {get; set;}
       [Required]
       public string role {get; set;}


}
}