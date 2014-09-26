using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomClassModelBinding
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // 傳回型別可以變更為 IEnumerable，然而，若要支援
        // 分頁和排序，必須加入下列參數:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IEnumerable<Models.Customer> GridView1_GetData()
        {
            return (new Models.CustomerRepository()).Select();
        }
    }
}