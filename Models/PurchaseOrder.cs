using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_system.Models
{
    public class PurchaseOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Document_Type { get; set; }
        public string No { get; set; }
        public string Buy_from_Vendor_No { get; set; }
        public string Buy_from_Vendor_Name { get; set; }
        public string Posting_Description { get; set; }
        public string Buy_from_Address { get; set; }
        public string Buy_from_Address_2 { get; set; }
        public string Buy_from_City { get; set; }
        public string Buy_from_County { get; set; }
        public string Buy_from_Post_Code { get; set; }
        public string Buy_from_Country_Region_Code { get; set; }
        public string Buy_from_Contact_No { get; set; }
        public string BuyFromContactPhoneNo { get; set; }
        public string BuyFromContactMobilePhoneNo { get; set; }
        public string BuyFromContactEmail { get; set; }
        public string Buy_from_Contact { get; set; }
        public DateTime Document_Date { get; set; }
        public DateTime Posting_Date { get; set; }
        public DateTime Due_Date { get; set; }
        public string Vendor_Invoice_No { get; set; }
        public string Purchaser_Code { get; set; }
        public int No_of_Archived_Versions { get; set; }
        public DateTime Order_Date { get; set; }
        public string Quote_No { get; set; }
        public string Vendor_Order_No { get; set; }
        public string Vendor_Shipment_No { get; set; }
        public string Order_Address_Code { get; set; }
        public string Responsibility_Center { get; set; }
        public string Assigned_User_ID { get; set; }
        public string Status { get; set; }
        public string Job_Queue_Status { get; set; }
        public string Currency_Code { get; set; }
        public DateTime Expected_Receipt_Date { get; set; }
        public bool Prices_Including_VAT { get; set; }
        public string VAT_Bus_Posting_Group { get; set; }
        public string Vendor_Posting_Group { get; set; }
        public string Payment_Terms_Code { get; set; }
        public string Payment_Method_Code { get; set; }
        public string Shortcut_Dimension_1_Code { get; set; }
        public string Shortcut_Dimension_2_Code { get; set; }
        public decimal Payment_Discount_Percent { get; set; }
        public DateTime Pmt_Discount_Date { get; set; }
        public string Journal_Templ_Name { get; set; }
        public bool Tax_Liable { get; set; }
        public string Tax_Area_Code { get; set; }
        public string Shipment_Method_Code { get; set; }
        public string Payment_Reference { get; set; }
        public string Creditor_No { get; set; }
        public string On_Hold { get; set; }
        public string Inbound_Whse_Handling_Time { get; set; }
        public string Lead_Time_Calculation { get; set; }
        public DateTime Requested_Receipt_Date { get; set; }
        public DateTime Promised_Receipt_Date { get; set; }
        public string ShippingOptionWithLocation { get; set; }
        public string Location_Code { get; set; }
        public string Sell_to_Customer_No { get; set; }
        public string Ship_to_Code { get; set; }
        public string Ship_to_Name { get; set; }
        public string Ship_to_Address { get; set; }
        public string Ship_to_Address_2 { get; set; }
        public string Ship_to_City { get; set; }
        public string Ship_to_County { get; set; }
        public string Ship_to_Post_Code { get; set; }
        public string Ship_to_Country_Region_Code { get; set; }
        public string Ship_to_Contact { get; set; }
        public string PayToOptions { get; set; }
        public string Pay_to_Name { get; set; }
        public string Pay_to_Address { get; set; }
        public string Pay_to_Address_2 { get; set; }
        public string Pay_to_City { get; set; }
        public string Pay_to_County { get; set; }
        public string Pay_to_Post_Code { get; set; }
        public string Pay_to_Country_Region_Code { get; set; }
        public string Pay_to_Contact_No { get; set; }
        public string Pay_to_Contact { get; set; }
        public string PayToContactPhoneNo { get; set; }
        public string PayToContactMobilePhoneNo { get; set; }
        public string PayToContactEmail { get; set; }
        public decimal Vendor_Exchange_Rate_ACY { get; set; }
        public string Transaction_Specification { get; set; }
        public string Transaction_Type { get; set; }
        public string Transport_Method { get; set; }
        public string Entry_Point { get; set; }
        public string Area { get; set; }
        public decimal Prepayment_Percent { get; set; }
        public bool Compress_Prepayment { get; set; }
        public string Prepmt_Payment_Terms_Code { get; set; }
        public DateTime Prepayment_Due_Date { get; set; }
        public decimal Prepmt_Payment_Discount_Percent { get; set; }
        public DateTime Prepmt_Pmt_Discount_Date { get; set; }
        public string Vendor_Cr_Memo_No { get; set; }
    }
}
