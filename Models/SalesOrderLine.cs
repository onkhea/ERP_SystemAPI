using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_system.Models
{
    public class SalesOrderLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Document_Type { get; set; }
        public string Document_No { get; set; }
        public int Line_No { get; set; }
        public string Type { get; set; }
        public string No { get; set; }
        public string Description { get; set; }
        public string Description_2 { get; set; }
        public string Shipment_Date { get; set; }
        public string Sell_to_Customer_No { get; set; }
        public string Currency_Code { get; set; }
        public int Quantity { get; set; }
        public int Outstanding_Quantity { get; set; }
        public string Unit_of_Measure_Code { get; set; }
        public string Work_Type_Code { get; set; }
        public decimal Amount { get; set; }
        public decimal Unit_Price { get; set; }
        public double Line_Discount_Percent { get; set; }
    }
}
