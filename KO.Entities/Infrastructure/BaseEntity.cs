using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KO.Entities.Infrastructure
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
      
        //public DateTime CreatedAt { get; set; }    
        //public DateTime? UpdatedAt { get; set; }      
        //public DateTime? DeletedAt { get; set; }    
        //public bool IsActive { get; set; }
        //public bool Deleted { get; set; }

        public BaseEntity()
        {
           
            //CreatedAt = DateTime.Now;
            //UpdatedAt = null;          
            //DeletedAt = null;           
            //IsActive = true;
            //Deleted = false;
        }
    }
}
