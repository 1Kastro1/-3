using System;

namespace Марафон
{
    public partial class AdminPanel : MetroFramework.Forms.MetroForm
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void mbUser_Click(object sender, EventArgs e)
        {
            AdminUser frm = new AdminUser();
            frm.ShowDialog();
        }

        private void mbVolonter_Click(object sender, EventArgs e)
        {
            AdminVolonter frm = new AdminVolonter();
            frm.ShowDialog();
        }

        private void mbBlagoOrg_Click(object sender, EventArgs e)
        {
            AdminBlagoFond frm = new AdminBlagoFond();
            frm.ShowDialog();
        }

        private void mbInstrument_Click(object sender, EventArgs e)
        {
            Администрация.Inventory frm = new Администрация.Inventory();
            frm.ShowDialog();
        }


    }
}
