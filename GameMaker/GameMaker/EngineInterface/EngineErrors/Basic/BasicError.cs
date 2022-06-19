using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine.Errors.Basic
{
    public partial class BasicError : Form
    {
        public string ErrorMessage;
        public BasicError()
        {
            InitializeComponent();
        }

        private void BasicError_Load(object sender, EventArgs e)
        {
            L_ErrorMessage.Text = ErrorMessage;
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
