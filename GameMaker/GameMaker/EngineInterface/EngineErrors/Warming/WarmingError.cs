using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine.Errors.Warming
{
    public partial class WarmingError : Form
    {
        public string ErrorMessage;
        public WarmingError()
        {
            InitializeComponent();
        }

        private void WarmingError_Load(object sender, EventArgs e)
        {
            L_ErrorMessage.Text = ErrorMessage;
        }

        private void B_Ok_Click(object sender, EventArgs e)
        {

        }
    }
}
