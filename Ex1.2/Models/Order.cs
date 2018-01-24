using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ex1._2.Models
{
    [Table("Order")]
    public class Order
    {
        public DateTime DeliveredOn { get; set; }
        public int ID { get; set; }
        public DateTime OrderOn { get; set; }
        public double Value { get; set; }
        [Range(0,5)]
        public int FeedbackRating { get; set; }
    }
}