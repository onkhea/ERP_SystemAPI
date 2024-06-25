using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_system.Migrations
{
    public partial class InitialCreate01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Search_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventoryField = table.Column<int>(type: "int", nullable: false),
                    Created_From_Nonstock_Item = table.Column<bool>(type: "bit", nullable: false),
                    Substitutes_Exist = table.Column<bool>(type: "bit", nullable: false),
                    Stockkeeping_Unit_Exists = table.Column<bool>(type: "bit", nullable: false),
                    Assembly_BOM = table.Column<bool>(type: "bit", nullable: false),
                    Production_BOM_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Routing_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Base_Unit_of_Measure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shelf_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Costing_Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost_is_Adjusted = table.Column<bool>(type: "bit", nullable: false),
                    Standard_Cost = table.Column<double>(type: "float", nullable: false),
                    Unit_Cost = table.Column<double>(type: "float", nullable: false),
                    Last_Direct_Cost = table.Column<double>(type: "float", nullable: false),
                    Price_Profit_Calculation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profit_Percent = table.Column<double>(type: "float", nullable: false),
                    Unit_Price = table.Column<double>(type: "float", nullable: false),
                    Inventory_Posting_Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gen_Prod_Posting_Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VAT_Prod_Posting_Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item_Disc_Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vendor_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vendor_Item_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tariff_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Overhead_Rate = table.Column<double>(type: "float", nullable: false),
                    Indirect_Cost_Percent = table.Column<double>(type: "float", nullable: false),
                    Item_Category_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Blocked = table.Column<bool>(type: "bit", nullable: false),
                    Last_Date_Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sales_Unit_of_Measure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Replenishment_System = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purch_Unit_of_Measure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lead_Time_Calculation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturing_Policy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flushing_Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assembly_Policy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Item_Tracking_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Default_Deferral_Template_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coupled_to_CRM = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Document_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line_No = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shipment_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sell_to_Customer_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Outstanding_Quantity = table.Column<int>(type: "int", nullable: false),
                    Unit_of_Measure_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Work_Type_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Unit_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Line_Discount_Percent = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Document_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buy_from_Vendor_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buy_from_Vendor_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Posting_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buy_from_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buy_from_Address_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buy_from_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buy_from_County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buy_from_Post_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buy_from_Country_Region_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buy_from_Contact_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyFromContactPhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyFromContactMobilePhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuyFromContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Buy_from_Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Document_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Posting_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Due_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vendor_Invoice_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Purchaser_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No_of_Archived_Versions = table.Column<int>(type: "int", nullable: false),
                    Order_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quote_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vendor_Order_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vendor_Shipment_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order_Address_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsibility_Center = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Assigned_User_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job_Queue_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expected_Receipt_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prices_Including_VAT = table.Column<bool>(type: "bit", nullable: false),
                    VAT_Bus_Posting_Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vendor_Posting_Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Terms_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Method_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shortcut_Dimension_1_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shortcut_Dimension_2_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Discount_Percent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pmt_Discount_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Journal_Templ_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tax_Liable = table.Column<bool>(type: "bit", nullable: false),
                    Tax_Area_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shipment_Method_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment_Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creditor_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    On_Hold = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inbound_Whse_Handling_Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lead_Time_Calculation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Requested_Receipt_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Promised_Receipt_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingOptionWithLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sell_to_Customer_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ship_to_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ship_to_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ship_to_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ship_to_Address_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ship_to_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ship_to_County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ship_to_Post_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ship_to_Country_Region_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ship_to_Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayToOptions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay_to_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay_to_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay_to_Address_2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay_to_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay_to_County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay_to_Post_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay_to_Country_Region_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay_to_Contact_No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pay_to_Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayToContactPhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayToContactMobilePhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayToContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vendor_Exchange_Rate_ACY = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Transaction_Specification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transaction_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transport_Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entry_Point = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prepayment_Percent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Compress_Prepayment = table.Column<bool>(type: "bit", nullable: false),
                    Prepmt_Payment_Terms_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prepayment_Due_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prepmt_Payment_Discount_Percent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prepmt_Pmt_Discount_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vendor_Cr_Memo_No = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryItems");

            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");
        }
    }
}
