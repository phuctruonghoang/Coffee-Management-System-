using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
namespace QLCOFFEE
{
    public partial class frmMain : RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBookTable f = new frmBookTable();
            f.ShowDialog();
            this.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile();
            f.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRevenue f = new frmRevenue();
            f.ShowDialog();
        }

        private void barButtonItem6_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFood f = new frmFood();
            f.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFoodCategory f = new frmFoodCategory();
            f.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFoodTable f = new frmFoodTable();
            f.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAccount f = new frmAccount();
            f.ShowDialog();
        }

    }
}
