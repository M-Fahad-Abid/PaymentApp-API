using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CardOwnerName { get; set; } = "";

        [Column(TypeName = "nvarchar(25)")]
        public string CardNumber { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string ExpirationDate { get; set; } = "";

        [Column(TypeName = "nvarchar(5)")]
        public string SecurityCode { get; set; } = "";

    }
}
