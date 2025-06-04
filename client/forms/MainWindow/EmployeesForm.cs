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
    public partial class EmployeesForm : Form
    {
        private readonly bool _isAdmin;
        public EmployeesForm(bool isAdmin)
        {
            InitializeComponent();
            _isAdmin = isAdmin;
        }
    }
}
