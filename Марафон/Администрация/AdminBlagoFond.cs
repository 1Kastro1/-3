using System;

namespace Марафон
{
    public partial class AdminBlagoFond : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        public AdminBlagoFond()
        {
            InitializeComponent();
        }

        private void mbAdd_Click(object sender, EventArgs e)
        {
            AdminAddBlagoFond frm = new AdminAddBlagoFond();
            frm.ShowDialog();
        }

        private void AdminBlagoFond_Load(object sender, EventArgs e)
        {

            timerDay.Start();
            this.eventTableAdapter.Fill(this.marathone.Event);
            if (this.marathone.Event.Count > 0)
            {
                for (int i = 0; i < this.marathone.Event.Count; i++)
                {
                    if (this.marathone.Event[i].EventId == "16_6HM")
                        date = this.marathone.Event[i].StartDateTime;
                }
            }
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
