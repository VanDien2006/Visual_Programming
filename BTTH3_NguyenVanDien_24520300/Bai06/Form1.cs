using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        double SoThuNhat = 0;
        double SoThuHai = 0;
        double KetQua = 0;
        string PhepToan = "";
        string CacPhepToan = "+-*/";
        public Form1()
        {
            InitializeComponent();
            add_Click();
        }
        List<Button> buttons;
        private void enableButton()
        {
            btnCong.Enabled = true;
            btnTru.Enabled = true;
            btnNhan.Enabled = true;
            btnChia.Enabled = true;
        }
        private void disableButton()
        {
            btnCong.Enabled = false;
            btnTru.Enabled = false;
            btnNhan.Enabled = false;
            btnChia.Enabled = false;
        }
        private void add_Click()
        {
            buttons = new List<Button> { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (var item in buttons)
            {
                item.Click += new EventHandler(button_Click);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            string textButton = ((Button)sender).Text;
            textBoxKetQua.Text += textButton;
        }
        private void TinhTong()
        {
            if (PhepToan == "+")
            {
                double s = SoThuNhat + SoThuHai;
                textBoxKetQua.Text = Convert.ToString(s);
            }
        }
        private void TinhHieu()
        {
            if (PhepToan == "-")
            {
                double s = SoThuNhat - SoThuHai;
                textBoxKetQua.Text = Convert.ToString(s);
            }
        }
        private void TinhTich()
        {
            if (PhepToan == "*")
            {
                double s = SoThuNhat * SoThuHai;
                textBoxKetQua.Text = Convert.ToString(s);
            }
        }
        private void TinhThuong()
        {
            if (PhepToan == "/")
            {
                if (SoThuHai == 0)
                {
                    MessageBox.Show("Lỗi: Không thể chia cho 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                double s = SoThuNhat / SoThuHai;
                textBoxKetQua.Text = Convert.ToString(s);
            }
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (textBoxKetQua.Text != "")
            {
                textBoxKetQua.Text += "+";
                PhepToan = "+";
                disableButton();
            }
            else
            {
                textBoxKetQua.Text = Convert.ToString(KetQua) + "+";
            }
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            if (textBoxKetQua.Text != "")
            {
                textBoxKetQua.Text += "-";
                PhepToan = "-";
                disableButton();
            }
            else
            {
                textBoxKetQua.Text = Convert.ToString(KetQua) + "-";
            }
        }
        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (textBoxKetQua.Text != "")
            {
                textBoxKetQua.Text += "*";
                PhepToan = "*";
                disableButton();
            }
            else
            {
                textBoxKetQua.Text = Convert.ToString(KetQua) + "*";
            }
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            if (textBoxKetQua.Text != "")
            {
                textBoxKetQua.Text += "/";
                PhepToan = "/";
                disableButton();
            }
            else
            {
                textBoxKetQua.Text = Convert.ToString(KetQua) + "/";
            }
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if (textBoxKetQua.Text != "")
            {
                //Truong hop 1: Tinh phan tram cho mot so
                if(textBoxKetQua.Text[textBoxKetQua.Text.Length-1] == '%' && !(textBoxKetQua.Text.Contains('+') || textBoxKetQua.Text.Contains('-') || textBoxKetQua.Text.Contains('*') || textBoxKetQua.Text.Contains('/') ))
                {
                    SoThuNhat = Convert.ToDouble(textBoxKetQua.Text.Substring(0, textBoxKetQua.Text.Length - 1));
                    SoThuNhat = SoThuNhat * 0.01;
                    textBoxKetQua.Text = Convert.ToString(SoThuNhat);
                    return;
                }
                //Truong hop 2: Tinh toan binh thuong
                //Tim so thu nhat trong textBoxKetQua
                int index = textBoxKetQua.Text.IndexOfAny(new char[] { '+', '-', '*', '/' });
                
                if (index >= 0 && index < textBoxKetQua.Text.Length - 1)
                {
                    string str_SoThuNhat = textBoxKetQua.Text.Substring(0, (index - 1) - 0 +1);
                    if(str_SoThuNhat[str_SoThuNhat.Length - 1] == '%')
                    {
                        str_SoThuNhat = str_SoThuNhat.Substring(0, str_SoThuNhat.Length - 1);
                        SoThuNhat = Convert.ToDouble(str_SoThuNhat);
                        SoThuNhat = SoThuNhat * 0.01;
                    }
                    else
                    {
                        SoThuNhat = Convert.ToDouble(str_SoThuNhat);
                    }
                }

                //Tim so thu hai trong textBoxKetQua
                if (index >= 0 && index < textBoxKetQua.Text.Length - 1)
                {
                    string str_SoThuHai = textBoxKetQua.Text.Substring(index + 1, (textBoxKetQua.Text.Length - 1) - (index + 1) + 1);
                    if (str_SoThuHai[str_SoThuHai.Length - 1] == '%')
                    {
                        str_SoThuHai = str_SoThuHai.Substring(0, str_SoThuHai.Length - 1);
                        SoThuHai = Convert.ToDouble(str_SoThuHai);
                        SoThuHai = SoThuHai * 0.01;
                    }
                    else
                    {
                        SoThuHai = Convert.ToDouble(str_SoThuHai);
                    }
                }

                textBoxKetQua.Text = "";

                switch (PhepToan)
                {
                    case "+":
                        TinhTong();
                        break;
                    case "-":
                        TinhHieu();
                        break;
                    case "*":
                        TinhTich();
                        break;
                    case "/":
                        TinhThuong();
                        break;
                    default:
                        break;
                }

                enableButton();
            }
        }

        private void btnXoaBoNho_Click(object sender, EventArgs e)
        {
            SoThuNhat = SoThuHai = 0;
            PhepToan = "";
            KetQua = 0;
            textBoxKetQua.Clear();
            enableButton();
        }

        private void btnXoaHienThi_Click(object sender, EventArgs e)
        {
            textBoxKetQua.Clear();
            enableButton();
        }

        private void btnXoaSoVuaNhapCuoi_Click(object sender, EventArgs e)
        {
            if (textBoxKetQua.Text.Contains("+") || textBoxKetQua.Text.Contains("-") || textBoxKetQua.Text.Contains("*") || textBoxKetQua.Text.Contains("/"))
            {
                int index = textBoxKetQua.Text.IndexOfAny(CacPhepToan.ToCharArray());
                textBoxKetQua.Text = textBoxKetQua.Text.Remove(index + 1);
            }
            else
            {
                textBoxKetQua.Clear();
            }
        }

        private void btnXoaTungKyTu_Click(object sender, EventArgs e)
        {
            if(textBoxKetQua.Text == "")
            {
                return;
            }
            else if (CacPhepToan.Contains(textBoxKetQua.Text[textBoxKetQua.Text.Length - 1]))
                enableButton();
            textBoxKetQua.Text = textBoxKetQua.Text.Remove(textBoxKetQua.Text.Length - 1);
        }

        private void btnGoiGiaTri_Click(object sender, EventArgs e)
        {
            textBoxKetQua.Text = Convert.ToString(KetQua);
        }

        private void btnLuuVaoBoNho_Click(object sender, EventArgs e)
        {
            string str_KetQua = textBoxKetQua.Text;
            KetQua = Convert.ToDouble(str_KetQua);
        }

        private void btnCongThemVaoBoNho_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBoxKetQua.Text) != 0)
            {
                KetQua += Convert.ToDouble(textBoxKetQua.Text);
            }
        }

        private void btnDoiDau_Click(object sender, EventArgs e)
        {
            if (textBoxKetQua.Text != "")
            {
                double giaTriHienTai = Convert.ToDouble(textBoxKetQua.Text);
                giaTriHienTai = -giaTriHienTai;
                textBoxKetQua.Text = Convert.ToString(giaTriHienTai);
            }
        }

        private void btnDauThapPhan_Click(object sender, EventArgs e)
        {
            if (textBoxKetQua.Text == "")
            {
                textBoxKetQua.Text = "0.";
            }
            else if (CacPhepToan.Contains(textBoxKetQua.Text[textBoxKetQua.Text.Length - 1]))
            {
                textBoxKetQua.Text += "0.";
            }
            else
            {
                textBoxKetQua.Text += ".";
            }
        }

        private void btnCanBacHai_Click(object sender, EventArgs e)
        {
            if (textBoxKetQua.Text.Contains("+") || textBoxKetQua.Text.Contains("-") || textBoxKetQua.Text.Contains("*") || textBoxKetQua.Text.Contains("/"))
            {
                return;
            }
            double BeforeNumber = Convert.ToDouble(textBoxKetQua.Text);
            double AfterNumber = Math.Sqrt(BeforeNumber);
            textBoxKetQua.Text = Convert.ToString(AfterNumber);
        }

        private void btnTinhPhanTram_Click(object sender, EventArgs e)
        {
            textBoxKetQua.Text += "%";
        }

        private void btnLayNghichDao_Click(object sender, EventArgs e)
        {
            if(textBoxKetQua.Text.Length > 0)
            {
                SoThuNhat = Convert.ToDouble(textBoxKetQua.Text);
                SoThuNhat = 1 / SoThuNhat;
                textBoxKetQua.Text=Convert.ToString(SoThuNhat);
            }
        }
    }
}
