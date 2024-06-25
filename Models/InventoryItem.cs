
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_system.Models
{
    public class InventoryItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string No { get; set; }
        public string Description { get; set; }
        public string Search_Description { get; set; }
        public string Type { get; set; }
        public int InventoryField { get; set; }
        public bool Created_From_Nonstock_Item { get; set; }
        public bool Substitutes_Exist { get; set; }
        public bool Stockkeeping_Unit_Exists { get; set; }
        public bool Assembly_BOM { get; set; }
        public string Production_BOM_No { get; set; }
        public string Routing_No { get; set; }
        public string Base_Unit_of_Measure { get; set; }
        public string Shelf_No { get; set; }
        public string Costing_Method { get; set; }
        public bool Cost_is_Adjusted { get; set; }
        public double Standard_Cost { get; set; }
        public double Unit_Cost { get; set; }
        public double Last_Direct_Cost { get; set; }
        public string Price_Profit_Calculation { get; set; }
        public double Profit_Percent { get; set; }
        public double Unit_Price { get; set; }
        public string Inventory_Posting_Group { get; set; }
        public string Gen_Prod_Posting_Group { get; set; }
        public string VAT_Prod_Posting_Group { get; set; }
        public string Item_Disc_Group { get; set; }
        public string Vendor_No { get; set; }
        public string Vendor_Item_No { get; set; }
        public string Tariff_No { get; set; }
        public double Overhead_Rate { get; set; }
        public double Indirect_Cost_Percent { get; set; }
        public string Item_Category_Code { get; set; }
        public bool Blocked { get; set; }
        public DateTime Last_Date_Modified { get; set; }
        public string Sales_Unit_of_Measure { get; set; }
        public string Replenishment_System { get; set; }
        public string Purch_Unit_of_Measure { get; set; }
        public string Lead_Time_Calculation { get; set; }
        public string Manufacturing_Policy { get; set; }
        public string Flushing_Method { get; set; }
        public string Assembly_Policy { get; set; }
        public string Item_Tracking_Code { get; set; }
        public string Default_Deferral_Template_Code { get; set; }
        public bool Coupled_to_CRM { get; set; }
    }
}
