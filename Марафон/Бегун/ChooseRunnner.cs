﻿using System;

namespace Марафон.Бегун
{
    public partial class ChooseRunnner : MetroFramework.Forms.MetroForm
    {
        public ChooseRunnner()
        {
            InitializeComponent();
        }

        private void mbReg_Click(object sender, EventArgs e)
        {
            //Форма регистрации
            RunnerRegistration rg = new RunnerRegistration();
            rg.Show();
            this.Close();
        }

        private void mbLoginOne_Click(object sender, EventArgs e)
        {
            //Форма авторизации
            AuthicationLogin fl = new AuthicationLogin();
            fl.Show();
            fl.MdiParent = null;
            this.Close();
        }
    }
}
