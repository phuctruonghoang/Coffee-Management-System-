using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCOFFEE.DAO;
namespace QLCOFFEE
{
    public partial class frmAccount : DevExpress.XtraEditors.XtraForm
    {
        public frmAccount()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadAccountList()
        {
            string query = "exec usp_GetAccountByUserName @username";

            DataProvider provider = new DataProvider();

            dtgvAccount.DataSource =  provider.ExcuteQuery(query,new object[]{"hoangphuc"});


        }
    }
}