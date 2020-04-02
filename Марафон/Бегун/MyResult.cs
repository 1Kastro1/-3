using System;

namespace Марафон
{
    public partial class MyResult : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime();
        private int RegistrationId;
        private string Gen;
        private DateTime Date;
        public MyResult(int reg, string gen, DateTime date)
        {
            InitializeComponent();
            RegistrationId = reg;
            Gen = gen;
            Date = date;
        }

        private void MyResult_Load(object sender, EventArgs e)
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

            this.eventTypeTableAdapter.Fill(this.marathone.EventType);
            this.marathonTableAdapter.Fill(this.marathone.Marathon);
            this.resultRunnerTableAdapter.Fill(this.myDataSet.ResultRunner);
            this.registrationEventTableAdapter.Fill(this.marathone.RegistrationEvent);


            this.resultRunnerTableAdapter.Adapter.SelectCommand.CommandText = String.Format(@"SELECT RegistrationEvent.RaceTime, RegistrationEvent.BibNumber, RegistrationEvent.RegistrationID, Event.EventTypeId, Event.MarathonId, RegistrationEvent.Position " +
                                                                                " FROM Event INNER JOIN RegistrationEvent ON Event.EventId = RegistrationEvent.EventID WHERE(RegistrationEvent.RegistrationID = '{0}')", RegistrationId);
            this.resultRunnerTableAdapter.Fill(this.myDataSet.ResultRunner);


            metroLabel1.Text = "Пол: " + Gen;
            DateTime dt; TimeSpan dt2;
            dt = DateTime.Now;
            dt2 = dt - Date;
            if (dt2.Days / 365 < 18)
                metroLabel2.Text = "Возрастная категория: до 18";
            else if ((dt2.Days / 365) >= 18 && (dt2.Days / 365) <= 29)
                metroLabel2.Text = "Возрастная категория: от 18 до 29";
            else if ((dt2.Days / 365) >= 30 && (dt2.Days / 365) <= 39)
                metroLabel2.Text = "Возрастная категория: от 30 до 39";
            else if ((dt2.Days / 365) >= 40 && (dt2.Days / 365) <= 55)
                metroLabel2.Text = "Возрастная категория: от 40 до 55";
            else if ((dt2.Days / 365) >= 56 && (dt2.Days / 365) <= 70)
                metroLabel2.Text = "Возрастная категория: от 56 до 70";
            else if ((dt2.Days / 365) > 70)
                metroLabel2.Text = "Возрастная категория: более 70";
        }

        private void timerDay_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            mlTime.Text = "Осталось " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds;
        }
    }
}
