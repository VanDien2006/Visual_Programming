using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        List<Button> DanhSachGhe;
        int TienGhe = 0;
        public Form1()
        {
            InitializeComponent();
            add_Click();
        }
        private void add_Click()
        {
            DanhSachGhe = new List<Button> { btn1, btn2, btn3, btn4, btn5 , btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15};
            foreach(var item in DanhSachGhe)
            {
                item.Click += new EventHandler(button_Click);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Vé đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            TienGhe = 0;
            foreach(Button btn in DanhSachGhe)
            {
                if(btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.Yellow;
                    int SoThuTu = Convert.ToInt32(btn.Text);
                    if (1 <= SoThuTu && SoThuTu <= 5) 
                    {
                        TienGhe += 5000;
                    }
                    else if (6 <= SoThuTu && SoThuTu <= 10) 
                    {
                        TienGhe += 6500;
                    }
                    else
                    {
                        TienGhe += 8000;
                    }
                }
            }
            textBoxThanhTien.Text = Convert.ToString(TienGhe) + " đồng";
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            foreach(Button btn in DanhSachGhe)
            {
                if(btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                }
            }
            textBoxThanhTien.Text = "0 đồng";
        }
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
