using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourceForDataBase.Helpers;

namespace SourceForDataBase
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            FormResizer.Register(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            FormResizer.Unregister(this);
            base.OnFormClosed(e);
        }
    }
}
