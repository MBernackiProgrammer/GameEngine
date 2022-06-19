using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine.Errors.Critical
{
    public partial class CriticalError : Form
    {
        public string ErrorMessage;
        public CriticalError()
        {
            InitializeComponent();
        }

        private void CriticalError_Load(object sender, EventArgs e)
        {
            L_ErrorMessage.Text = ErrorMessage;
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
