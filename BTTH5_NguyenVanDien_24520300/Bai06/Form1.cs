using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            foreach (FontFamily font in fonts.Families)
            {
                ListBoxFontChu.Items.Add(font.Name);
            }

            ListBoxFontChu.DrawMode = DrawMode.OwnerDrawFixed;
            ListBoxFontChu.ItemHeight = 30;   
            ListBoxFontChu.DrawItem += ListBoxFontChu_DrawItem;
        }

        private void ListBoxFontChu_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string fontName = ListBoxFontChu.Items[e.Index].ToString();
            Font font = new Font(fontName, 16);

            e.DrawBackground();
            e.Graphics.DrawString(fontName, font, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }
    }
}
