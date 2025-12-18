using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Thêm font có sẵn trong hệ thống vào cho ComboBox Font
            foreach(FontFamily f in FontFamily.Families)
            {
                cmbFont.Items.Add(f.Name);
            }

            //Thêm size vào cho ComboBox Size
            cmbSize.Items.AddRange(new object[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 24, 28, 32 });

        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NewFont = cmbFont.Text;
            float NewSize = rtbVanBan.Font.Size;
            FontStyle NewStyle = rtbVanBan.Font.Style;

            rtbVanBan.SelectionFont = new Font(NewFont, NewSize, NewStyle);
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string NewFont = rtbVanBan.Font.Name;
            float NewSize = float.Parse(cmbSize.Text);
            FontStyle NewStyle = rtbVanBan.Font.Style;

            rtbVanBan.SelectionFont = new Font(NewFont, NewSize, NewStyle);
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            Font CurrentFont = rtbVanBan.SelectionFont ?? rtbVanBan.Font;

            FontStyle CurrentStyle;
            if (CurrentFont.Bold)
            {
                CurrentStyle = CurrentFont.Style & ~FontStyle.Bold;
            }
            else
            {
                CurrentStyle = CurrentFont.Style | FontStyle.Bold;
            }
            rtbVanBan.SelectionFont = new Font(CurrentFont.FontFamily, CurrentFont.Size, CurrentStyle);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            Font CurrentFont = rtbVanBan.SelectionFont ?? rtbVanBan.Font;

            FontStyle CurrentStyle;
            if (CurrentFont.Italic)
            {
                CurrentStyle = CurrentFont.Style & ~FontStyle.Italic;
            }
            else
            {
                CurrentStyle = CurrentFont.Style | FontStyle.Italic;
            }
            rtbVanBan.SelectionFont = new Font(CurrentFont.FontFamily, CurrentFont.Size, CurrentStyle);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            Font CurrentFont = rtbVanBan.SelectionFont ?? rtbVanBan.Font;

            FontStyle CurrentStyle;
            if (CurrentFont.Underline)
            {
                CurrentStyle = CurrentFont.Style & ~FontStyle.Underline;
            }
            else
            {
                CurrentStyle = CurrentFont.Style | FontStyle.Underline;
            }
            rtbVanBan.SelectionFont = new Font(CurrentFont.FontFamily, CurrentFont.Size, CurrentStyle);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();

            btnColor.BackColor = dlg.Color; //Thay màu của btnColor
            rtbVanBan.SelectionColor = dlg.Color; //Thay màu của phần văn bản được in đậm
        }

        private void radLeft_CheckedChanged(object sender, EventArgs e)
        {
            rtbVanBan.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void radCenter_CheckedChanged(object sender, EventArgs e)
        {
            rtbVanBan.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void radRight_CheckedChanged(object sender, EventArgs e)
        {
            rtbVanBan.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void rtbVanBan_TextChanged(object sender, EventArgs e)
        {
            Font CurrentFont = rtbVanBan.SelectionFont;

            if (CurrentFont != null) //Nếu selection có style thống nhất
            {
                chkBold.Checked = CurrentFont.Bold;
                chkItalic.Checked = CurrentFont.Italic;
                chkUnderline.Checked = CurrentFont.Underline;
            }
            else //Vùng chọn chứa nhiều font khác nhau
            {
                chkBold.Checked = false;
                chkItalic.Checked = false;
                chkUnderline.Checked = false;
            }
        }
    }
}
