﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.forms.MainWindow
{
    public partial class AccountForm : Form
    {

        public AccountForm()
        {
            MessageBox.Show($"isAdmin={AdminSession.isAdmin}", "Отладка",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            InitializeComponent();
        }

        // что за фигня вообще. админ тру  крч. попытка зайти обратно на учетку - флс. не работает ептель

    }
}
