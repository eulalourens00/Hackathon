using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace client.forms.MainWindow
{
    public partial class InformationFormcs : Form
    {
        private readonly int _objectId;
        public InformationFormcs(int objectId)
        {

            InitializeComponent();
            _objectId = objectId;
            LoadObjectData();
        }

        private void LoadObjectData()
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelObject_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
