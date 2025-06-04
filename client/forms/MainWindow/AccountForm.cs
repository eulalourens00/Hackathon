using System;
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
        private readonly bool _isAdmin;

        public AccountForm(bool isAdmin = false)
        {
            MessageBox.Show($"isAdmin={isAdmin}", "Отладка",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            _isAdmin = isAdmin;
            InitializeComponent();
        }

        // что за фигня вообще. админ тру  крч. попытка зайти обратно на учетку - флс. не работает ептель

    }
}
