using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Service;

namespace Inventory
{
    public static class PopulateDropDownList
    {
        public static void FillCategory(DropDownList ddlCategory, long companyId)
        {
            var categoryService = new CategoryService();
            var listCategory = categoryService.GetCategoryListForDropdown(companyId);

            ddlCategory.DataSource = listCategory;
            ddlCategory.DataTextField = "value";
            ddlCategory.DataValueField = "key";
            ddlCategory.DataBind();
            ddlCategory.Items.Insert(0, "--Select--");
        }

        public static void FillSubCategory(DropDownList ddlSubCategory, long categoryId)
        {
            var subcategoryService = new SubCategoryService();
            var listSubCategory = subcategoryService.GetSubCategoryListForDropdown(categoryId);

            ddlSubCategory.DataSource = listSubCategory;
            ddlSubCategory.DataTextField = "value";
            ddlSubCategory.DataValueField = "key";
            ddlSubCategory.DataBind();
            ddlSubCategory.Items.Insert(0, "--Select--");
        }

        public static void FillWareHouse(DropDownList ddlWareHouse)
        {
            var wareHouseService = new WareHouseLocationService();
            var listWareHouse = wareHouseService.LocationListForDropDown();

            ddlWareHouse.DataSource = listWareHouse;
            ddlWareHouse.DataTextField = "value";
            ddlWareHouse.DataValueField = "key";
            ddlWareHouse.DataBind();
            ddlWareHouse.Items.Insert(0, "--Select--");
        }

        public static void FillSalesOrder(DropDownList ddlWareHouse)
        {
            var soService = new SalesOrderService();
            var soList = soService.GetSalesOrderForDropDownList();

            ddlWareHouse.DataSource = soList;
            ddlWareHouse.DataTextField = "PoNumber";
            ddlWareHouse.DataValueField = "SoNumber"; 
            ddlWareHouse.DataBind();
            ddlWareHouse.Items.Insert(0, "--Select--");
        }
    }
}