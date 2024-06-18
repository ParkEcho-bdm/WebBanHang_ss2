using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebBanHang.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        [Required (ErrorMessage ="vui lòng nhập đủ")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "vui lòng nhập đủ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "vui lòng nhập đủ")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "vui lòng nhập đủ")]
        public double Total { set; get; }
        public string State { set; get; }



    }
}
