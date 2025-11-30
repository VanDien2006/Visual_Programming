using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Bai04
{
    public partial class Form1 : Form
    {
        string currentFilePath = "";
        bool isNewFile = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tạo dữ liệu cho ComboBox Font: chứa tất cả các Font chữ của hệ thống
            ComboBoxFont.Items.Clear();
            foreach(FontFamily font in FontFamily.Families)
            {
                ComboBoxFont.Items.Add(font.Name);
            }


            //Tạo dữ liệu cho ComboBox Size: chứa các giá trị từ 8 -> 72
            ComboBoxSize.Items.Clear();
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
            {
                ComboBoxSize.Items.Add(s);
            }

            //Tạo giá trị mặc định là Font Tahoma, Size 14
            ComboBoxFont.Text = "Tahoma";
            ComboBoxSize.Text = "14";
            RichTextBoxVanBan.Font = new Font("Tahoma", 14);
        }

        //Khi chọn Tạo văn bản mới(hoặc nhấn nút Tạo mới): Xóa nội dung hiện có trên
        //RichTextBox và khởi tạo các giá trị mặc định như Font, Size, …
        private void TaoVanBanMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBoxVanBan.Clear();
            ComboBoxFont.Text = "Tahoma";
            ComboBoxSize.Text = "14";
            RichTextBoxVanBan.Font = new Font("Tahoma", 14);

            currentFilePath = "";
            isNewFile = true;
        }

        //Khi chọn Mở tập tin(hoặc nhấn nút Mở) : Hiển thị hộp thoại mở tập tin
        //(OpenFileDialog) cho phép người dùng chọn tập tin văn bản(*.txt hoặc *.rtf) để mở.
        private void MoTapTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Mở tập tin văn bản";
            dlg.Filter = "Text/RTF Files (*.txt;*.rtf)|*.txt;*.rtf|All Files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {                
                string filePath = dlg.FileName;

                if (filePath.ToLower().EndsWith(".rtf"))
                {
                    RichTextBoxVanBan.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    if (filePath.ToLower().EndsWith(".rtf"))
                    {
                        RichTextBoxVanBan.LoadFile(filePath, RichTextBoxStreamType.RichText);
                        RichTextBoxVanBan.Text = File.ReadAllText(filePath, Encoding.UTF8);
                    }
                    else
                    {
                        RichTextBoxVanBan.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                        RichTextBoxVanBan.Text = File.ReadAllText(filePath, Encoding.UTF8);
                    }
                }

                currentFilePath = filePath;
                isNewFile = false;
            }
        }


        //Khi chọn Lưu nội dung văn bản(hoặc nhấn nút Lưu) : Lưu nội dung văn bản trên
        //RichTextBox xuống tập tin.Nếu là văn bản mới và trước đó chưa lưu lần nào thì hiển
        //thị hộp thoại lưu tập tin (SaveFileDialog) cho phép người dùng chọn thư mục cần lưu
        //tập tin với kiểu tập tin cần lưu là*.rtf.
        //Nếu là văn bản đã được mở trước đó thì thông báo cho người dùng lưu văn bản thành
        //công.
        private void LuuNoiDungVanBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isNewFile)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Lưu văn bản";
                sfd.Filter = "Rich Text Format (*.rtf)|*.rtf";
                sfd.DefaultExt = "rtf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Lưu nội dung RichTextBox xuống file RTF
                    RichTextBoxVanBan.SaveFile(sfd.FileName, RichTextBoxStreamType.RichText);

                    currentFilePath = sfd.FileName; // cập nhật đường dẫn hiện tại
                    isNewFile = false; // đã không còn là văn bản mới

                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (currentFilePath.ToLower().EndsWith(".rtf"))
                {
                    RichTextBoxVanBan.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    RichTextBoxVanBan.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);
                }
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxFont_Click(object sender, EventArgs e)
        {
            string NewFont = ComboBoxFont.Text;
            float NewSize = RichTextBoxVanBan.Font.Size;
            FontStyle NewStyle = RichTextBoxVanBan.Font.Style;
            RichTextBoxVanBan.Font = new Font(NewFont, NewSize, NewStyle);
        }

        private void ComboBoxSize_Click(object sender, EventArgs e)
        {
            string NewFont = RichTextBoxVanBan.Font.Name;
            float NewSize = float.Parse(ComboBoxSize.Text);
            FontStyle NewStyle = RichTextBoxVanBan.Font.Style;
            RichTextBoxVanBan.Font = new Font(NewFont, NewSize, NewStyle);
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            string NewFont = RichTextBoxVanBan.Font.Name;
            float NewSize = RichTextBoxVanBan.Font.Size;

            FontStyle CurrentStyle = RichTextBoxVanBan.Font.Style;
            FontStyle NewStyle;
            if (RichTextBoxVanBan.Font.Bold)
            {
                NewStyle = CurrentStyle & ~FontStyle.Bold;
            }
            else
            {
                NewStyle = CurrentStyle | FontStyle.Bold;
            }

            RichTextBoxVanBan.Font = new Font(NewFont, NewSize, NewStyle);
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            string NewFont = RichTextBoxVanBan.Font.Name;
            float NewSize = RichTextBoxVanBan.Font.Size;

            FontStyle CurrentStyle = RichTextBoxVanBan.Font.Style;
            FontStyle NewStyle;
            if (RichTextBoxVanBan.Font.Italic)
            {
                NewStyle = CurrentStyle & ~FontStyle.Italic;
            }
            else
            {
                NewStyle = CurrentStyle | FontStyle.Italic;
            }

            RichTextBoxVanBan.Font = new Font(NewFont, NewSize, NewStyle);
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            string NewFont = RichTextBoxVanBan.Font.Name;
            float NewSize = RichTextBoxVanBan.Font.Size;

            FontStyle CurrentStyle = RichTextBoxVanBan.Font.Style;
            FontStyle NewStyle;
            if (RichTextBoxVanBan.Font.Underline)
            {
                NewStyle = CurrentStyle & ~FontStyle.Underline;
            }
            else
            {
                NewStyle = CurrentStyle | FontStyle.Underline;
            }

            RichTextBoxVanBan.Font = new Font(NewFont, NewSize, NewStyle);
        }

        private void DinhDangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fdlg = new FontDialog();
            fdlg.ShowColor = false;
            fdlg.Font = RichTextBoxVanBan.Font;

            if(fdlg.ShowDialog()== DialogResult.OK)
            {
                ComboBoxFont.Text = fdlg.Font.Name;
                ComboBoxSize.Text = fdlg.Font.Size.ToString();

                Bold.Checked = fdlg.Font.Bold;
                Italic.Checked = fdlg.Font.Italic;
                Underline.Checked = fdlg.Font.Underline;

                RichTextBoxVanBan.Font = fdlg.Font;
            }
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Cảm ơn bạn đã dùng phần mềm!");
                this.Close();
            }
        }
    }
}
