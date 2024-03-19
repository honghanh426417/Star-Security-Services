//using System;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Project2_Sem3.Models
//{
//    public class ServiceOffered
//    {
//        [Key]
//        public int ServiceOfferedId { get; set; }

//        [ForeignKey("Service")]
//        public int ServiceID { get; set; }
//        public virtual Service? Service { get; set; }

//        public string? ServiceName { get; set; }

//        [ForeignKey("Client")]
//        public int ClientId { get; set; }
//        public virtual Client? Client { get; set; }

//        public DateTime CreatedAt { get; set; }
//    }
//}

