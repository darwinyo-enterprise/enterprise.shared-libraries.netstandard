using System;

namespace Enterprise.MockData.NetStandard
{
    public class IDMock
    {
        #region IntegratedApp ID
        public static Guid IA_ConfigurationServerID = new Guid("8D40BBC1-1053-42A5-B178-5D39D59E6C64");
        public static Guid IA_LoggingServerID = new Guid("C63B5D88-8EDE-44B9-B806-4FF205E3E70B");
        public static Guid IA_AuthorizationServerID = new Guid("5C788778-058F-4A3C-87D5-498BA6759BCA");
        public static Guid IA_ECommerce_ResourceServerID = new Guid("E63D48C4-065D-482E-BE33-1FE22BF6695C");

        public static Guid IA_ECommerce_WebClientID = new Guid("4C0C8BB0-C073-4913-A9B4-2353E0ADDC4C");
        #endregion

        #region Project ID
        public static Guid P_ConfigurationServerID = new Guid("DD98E9ED-6381-4992-BD5B-BC8790A4320C");
        public static Guid P_LoggingServerID = new Guid("67F07D8F-3D17-4B37-9FC3-CF18BD26FDF0");
        public static Guid P_AuthorizationServerID = new Guid("4A431706-59CF-4D36-9B40-42D66AA9FED7");
        public static Guid P_ECommerceID = new Guid("AC230062-D246-4AFA-986F-077FE47706E2");
        public static Guid P_EnterpriseID = new Guid("00000000-0000-0000-0000-000000000000");
        #endregion

        #region Menu ID
        public static Guid M_ECommerce_WebClient_HomeID = new Guid("E7863293-58D8-4584-9924-E5CC6B882E19");
        public static Guid M_ECommerce_WebClient_AboutUsID = new Guid("ED50ED3D-551F-4BE1-BEA9-574183823685");
        public static Guid M_ECommerce_WebClient_ContactUsID = new Guid("BC7E31CD-3668-42BF-B3F0-2346A9111F99");
        public static Guid M_ECommerce_WebClient_OurServicesID = new Guid("4C0C8BB0-C073-4913-A9B4-2353E0ADDC4C");
        public static Guid M_ECommerce_WebClient_CareersID = new Guid("A4A2AABD-5BC0-4FBB-BE1C-3B47D2FCF6E8");
        public static Guid M_ECommerce_WebClient_InvestorRelationsID = new Guid("420A7C55-2005-4CB3-97DB-BDDDDE9C4C3B");

        public static Guid M_ECommerce_WebClient_GetAssistance_ProductsID = new Guid("2E0BDEC1-FB7A-4EF4-8657-182D7BB7E219");
        public static Guid M_ECommerce_WebClient_GetAssistance_OrdersID = new Guid("A893AF68-9B5B-4E6A-A660-AFBAFCAE25CF");
        public static Guid M_ECommerce_WebClient_GetAssistance_ShippingsID = new Guid("B949BB87-506C-4BAC-A8AF-153ABCA00CDA");

        public static Guid M_ECommerce_WebClient_AdminAreaID = new Guid("35AC5F3B-2D18-4C8B-A52B-5D721EEC80AE");

        public static Guid M_ECommerce_WebClient_DashboardID = new Guid("317C86E1-82AF-4489-99C2-5D8C184A969A");

        public static Guid M_ECommerce_WebClient_ManageProducts_AddProductsID = new Guid("81401C48-6401-4C25-9603-05B8A0EB9FCA");
        public static Guid M_ECommerce_WebClient_ManageCategories_AddCategoriesID = new Guid("F8E4788F-541E-4EDA-B4AD-8B27B2FC5142");
        public static Guid M_ECommerce_WebClient_ManageInventory_AddInventoryID = new Guid("932E33FC-C56E-4EC4-AC3C-8E0A01D658CC");
        public static Guid M_ECommerce_WebClient_ManageManufacturer_AddManufacturerID = new Guid("0D227298-F176-437E-894D-8B191A866AF0");

        //public static Guid M_ECommerce_WebClient_ManageProducts_EditProductsID = new Guid("81401C48-6401-4C25-9603-05B8A0EB9FCA");
        //public static Guid M_ECommerce_WebClient_ManageCategories_EditCategoriesID = new Guid("F8E4788F-541E-4EDA-B4AD-8B27B2FC5142");
        //public static Guid M_ECommerce_WebClient_ManageInventory_EditInventoryID = new Guid("932E33FC-C56E-4EC4-AC3C-8E0A01D658CC");
        //public static Guid M_ECommerce_WebClient_ManageManufacturer_EditManufacturerID = new Guid("0D227298-F176-437E-894D-8B191A866AF0");

        public static Guid M_ECommerce_WebClient_ManageProducts_ListProductsID = new Guid("E7E10D33-95B4-471E-AAFE-1D71BF8C8637");
        public static Guid M_ECommerce_WebClient_ManageCategories_ListCategoriesID = new Guid("BA92DDA5-47BA-494E-899B-FA3109B0F6FE");
        public static Guid M_ECommerce_WebClient_ManageInventory_ListInventoryID = new Guid("6FF9F42B-5B35-4E1A-B3E2-D096760E990A");
        public static Guid M_ECommerce_WebClient_ManageManufacturer_ListManufacturerID = new Guid("F028C543-9689-4D0F-A170-21BA19C69A6A");
        #endregion

        #region Menu Category ID
        public static Guid MC_ECommerce_WebClient_GetAssistanceID = new Guid("D3482F80-6B35-4AA2-81BD-CA3C798F4E94");

        public static Guid MC_ECommerce_WebClient_ManageProductsID = new Guid("FBD791E4-6CFA-4A5D-9B1C-D4BC85B340AF");
        public static Guid MC_ECommerce_WebClient_ManageCategoriesID = new Guid("27F341AB-1403-4D39-BC71-633A8CA5A57A");
        public static Guid MC_ECommerce_WebClient_ManageInventoryID = new Guid("D2110E3D-C875-4949-B16C-81596909D484");
        public static Guid MC_ECommerce_WebClient_ManageManufacturerID = new Guid("825059FE-5D65-4D47-95AA-0D426F5D7B60");
        #endregion

        #region Menu Layouts
        public static Guid ML_ECommerce_WebClient_AdminLayoutID = new Guid("5109DD08-1249-4807-B93A-148202E27F27");
        #endregion

        #region Menu Permitted Role ID
        public static Guid MPR_ECommerce_WebClient_AdminArea_EnterpriseAdmin = new Guid("00994846-1950-414E-B69F-8245BAD09E25");
        public static Guid MPR_ECommerce_WebClient_AdminArea_ECommerceAdmin = new Guid("B5B8CB85-D660-41C8-B35E-F093942694B5");

        public static Guid MPR_ECommerce_WebClient_ManageProducts_EnterpriseAdmin = new Guid("14304FC6-FCAF-45A0-BF17-73343615C2A8");
        public static Guid MPR_ECommerce_WebClient_ManageProducts_ECommerceAdmin = new Guid("1A35FACF-6D28-446A-A488-A030AB303974");

        public static Guid MPR_ECommerce_WebClient_ManageCategories_EnterpriseAdmin = new Guid("ABD19EBB-D7AB-4C50-878A-1BDB9074B8C2");
        public static Guid MPR_ECommerce_WebClient_ManageCategories_ECommerceAdmin = new Guid("05F8B778-3181-4337-A6A3-9D91EBC2BB41");

        public static Guid MPR_ECommerce_WebClient_ManageInventory_EnterpriseAdmin = new Guid("04B0F691-4371-49A7-9BFA-C22D5A9B4EC3");
        public static Guid MPR_ECommerce_WebClient_ManageInventory_ECommerceAdmin = new Guid("64BFA1CB-4DBA-421C-A125-37A7181FD62B");

        public static Guid MPR_ECommerce_WebClient_ManageManufacturer_EnterpriseAdmin = new Guid("73F158D3-B49A-42B9-9E1B-08E4B7F58426");
        public static Guid MPR_ECommerce_WebClient_ManageManufacturer_ECommerceAdmin = new Guid("6A4F348D-5D7B-45EB-97EC-D62AF0EF6779");

        public static Guid MPR_ECommerce_WebClient_ManageProducts_AddProducts_EnterpriseAdmin = new Guid("CCBB77E1-500A-4083-8D27-A220EACEFBDC");
        public static Guid MPR_ECommerce_WebClient_ManageCategories_AddCategories_EnterpriseAdmin = new Guid("D07F5CE1-2D83-4499-8963-AD6EF37BE9E2");
        public static Guid MPR_ECommerce_WebClient_ManageInventory_AddInventory_EnterpriseAdmin = new Guid("F8E2EA2D-CCC1-4793-8DF5-9867BA16AF18");
        public static Guid MPR_ECommerce_WebClient_ManageManufacturer_AddManufacturer_EnterpriseAdmin = new Guid("BF607D66-B453-403C-8EE9-63245FBF0C57");

        public static Guid MPR_ECommerce_WebClient_ManageProducts_ListProducts_EnterpriseAdmin = new Guid("5ED73216-A688-4D18-A258-61749955F99D");
        public static Guid MPR_ECommerce_WebClient_ManageCategories_ListCategories_EnterpriseAdmin = new Guid("6ABF8FFA-0788-4541-8A28-7D43C8E04E6C");
        public static Guid MPR_ECommerce_WebClient_ManageInventory_ListInventory_EnterpriseAdmin = new Guid("B4E1FB91-8BDF-4D5B-AA77-F2DBA52B0D66");
        public static Guid MPR_ECommerce_WebClient_ManageManufacturer_ListManufacturer_EnterpriseAdmin = new Guid("42B4F2EE-1C35-4208-A62F-91133D7542EF");


        public static Guid MPR_ECommerce_WebClient_ManageProducts_AddProducts_ECommerceAdmin = new Guid("DC19336A-E6DE-4544-A7EF-FF971C80AE9F");
        public static Guid MPR_ECommerce_WebClient_ManageCategories_AddCategories_ECommerceAdmin = new Guid("9ED359B6-6712-44EA-821A-9DF8319B4C07");
        public static Guid MPR_ECommerce_WebClient_ManageInventory_AddInventory_ECommerceAdmin = new Guid("14819BE0-2ADF-4183-A5BD-FF672755C744");
        public static Guid MPR_ECommerce_WebClient_ManageManufacturer_AddManufacturer_ECommerceAdmin = new Guid("56283F25-B7DC-4244-912D-84A199D8E234");

        public static Guid MPR_ECommerce_WebClient_ManageProducts_ListProducts_ECommerceAdmin = new Guid("6CE9419B-E917-4623-8E05-328AECE10658 ");
        public static Guid MPR_ECommerce_WebClient_ManageCategories_ListCategories_ECommerceAdmin = new Guid("E98F3EF2-B7B8-4A8B-9670-B9DD26F1B29F");
        public static Guid MPR_ECommerce_WebClient_ManageInventory_ListInventory_ECommerceAdmin = new Guid("92A9D5E6-FAFD-4976-9166-3834C5DAB921");
        public static Guid MPR_ECommerce_WebClient_ManageManufacturer_ListManufacturer_ECommerceAdmin = new Guid("67CACB21-7F46-4727-BDC4-35CC202ABAB4");
        #endregion

        #region Roles

        #region Enterprise Level
        public static Guid R_Enterprise_SuperAdmin = new Guid("863C68BE-D3AD-4363-937E-52B19AEA0B82");
        public static Guid R_Enterprise_SecurityAdmin = new Guid("EA7A5EF6-F685-4538-BC51-D1FDE3EA6C9E");
        public static Guid R_Enterprise_Admin = new Guid("49D1FD02-4E60-456A-A85E-4DD924CAD615");
        #endregion

        #region AuthorizationServer
        public static Guid R_AuthorizationServer_SuperAdmin = new Guid("9D67CB23-CD62-4598-937C-F6456FE7FEEF");
        public static Guid R_AuthorizationServer_SecurityAdmin = new Guid("9AE97F74-FAE3-4A97-9469-6B4F7CC26774");
        public static Guid R_AuthorizationServer_UserAdmin = new Guid("9F4B04D8-19AD-470D-8787-84CD9FFE8DEC");
        public static Guid R_AuthorizationServer_Admin = new Guid("D9C87A38-D840-43F6-975B-9C445896C92F");
        #endregion

        #region LoggingServer
        public static Guid R_LoggingServer_SuperAdmin = new Guid("A7C6D47F-FF04-4DAA-A38B-FC0FB842858C");
        public static Guid R_LoggingServer_SecurityAdmin = new Guid("C701009E-F0BC-4077-B7DC-3E12B5453BC2");
        public static Guid R_LoggingServer_AuditAdmin = new Guid("3F0519FC-8618-4C1F-AFA7-07CD388E08FF");
        public static Guid R_LoggingServer_Admin = new Guid("EE4614CF-7C4E-46D8-8BAF-3E6758EE4E7E");
        #endregion

        #region ConfigurationServer
        public static Guid R_ConfigurationServer_SuperAdmin = new Guid("183F72D7-CB4E-41E4-9953-93B49C0FFC0A");
        public static Guid R_ConfigurationServer_SecurityAdmin = new Guid("1EFA0A04-A470-4B99-930C-BF183155ACE1");
        public static Guid R_ConfigurationServer_ConfigAdmin = new Guid("A7B12E61-0743-4641-A6CC-1AFFACC6FCAD");
        public static Guid R_ConfigurationServer_Admin = new Guid("C01A8F1F-85C1-4CC8-8F7E-F01F54199B3E");
        #endregion

        #region ECommerce
        public static Guid R_ECommerce_SuperAdmin = new Guid("A942F7E8-6F57-45AA-A3EE-03E52777761F");
        public static Guid R_ECommerce_SecurityAdmin = new Guid("9E4F54A2-9FD0-4968-B9DD-F71A669115D8");
        public static Guid R_ECommerce_Admin = new Guid("F6C731CE-7CCB-4D10-BCAA-132A20390CCD");
        #endregion

        #endregion
    }
}
