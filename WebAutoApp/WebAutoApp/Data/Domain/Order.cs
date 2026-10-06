using System.ComponentModel.DataAnnotations;

namespace WebAutoApp.Data.Domain
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        
public int Carld { get; set; }
       
public virtual Car Car { get; set; } = null!;
        [Required]
        
public int ClientId { get; set; }
        
public virtual Client Client { get; set; } = null!;
        [Required]
        
public DateTime OrderDate { get; set; }
    }
}