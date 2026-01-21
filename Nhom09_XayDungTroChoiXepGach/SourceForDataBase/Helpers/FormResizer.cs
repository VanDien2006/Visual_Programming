using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SourceForDataBase.Helpers
{
    /// <summary>
    /// Simple proportional resizer for WinForms.
    /// Call FormResizer.Register(this) in the form constructor (after InitializeComponent()).
    /// </summary>
    public static class FormResizer
    {
        private class LayoutInfo
        {
            public Size OriginalClientSize { get; set; }
            public List<ControlLayout> Controls { get; set; }
        }

        private class ControlLayout
        {
            public Control Control { get; set; }
            public Rectangle OriginalBounds { get; set; }
            public float OriginalFontSize { get; set; }
            public FontStyle OriginalFontStyle { get; set; }
            public string OriginalFontFamily { get; set; }
        }

        private static readonly Dictionary<Form, LayoutInfo> _layouts = new Dictionary<Form, LayoutInfo>();

        public static void Register(Form form)
        {
            if (form == null)
            {
                return;
            }

            if (_layouts.ContainsKey(form))
            {
                return;
            }

            var controlLayoutList = new List<ControlLayout>();
            foreach (Control control in GetAllControls(form))
            {
                float fontSize = 8f;
                FontStyle fontStyle = FontStyle.Regular;
                string fontFamily = SystemFonts.DefaultFont.FontFamily.Name;

                if (control.Font != null)
                {
                    fontSize = control.Font.Size;
                    fontStyle = control.Font.Style;
                    fontFamily = control.Font.FontFamily.Name;
                }

                controlLayoutList.Add(new ControlLayout
                {
                    Control = control,
                    OriginalBounds = control.Bounds,
                    OriginalFontSize = fontSize,
                    OriginalFontStyle = fontStyle,
                    OriginalFontFamily = fontFamily
                });
            }

            var info = new LayoutInfo
            {
                OriginalClientSize = form.ClientSize,
                Controls = controlLayoutList
            };

            _layouts[form] = info;

            form.Resize += Form_Resize;
            form.FormClosed += Form_FormClosed;
        }

        public static void Unregister(Form form)
        {
            if (form == null)
            {
                return;
            }

            if (!_layouts.ContainsKey(form))
            {
                return;
            }

            form.Resize -= Form_Resize;
            form.FormClosed -= Form_FormClosed;
            _layouts.Remove(form);
        }

        private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = sender as Form;
            if (form != null)
            {
                Unregister(form);
            }
        }

        private static void Form_Resize(object sender, EventArgs e)
        {
            Form form = sender as Form;
            if (form == null)
            {
                return;
            }

            LayoutInfo info;
            if (!_layouts.TryGetValue(form, out info))
            {
                return;
            }

            Size orig = info.OriginalClientSize;
            if (orig.Width <= 0 || orig.Height <= 0)
            {
                return;
            }

            float scaleX = (float)form.ClientSize.Width / orig.Width;
            float scaleY = (float)form.ClientSize.Height / orig.Height;
            float scaleForFont = Math.Min(scaleX, scaleY);

            foreach (ControlLayout cl in info.Controls)
            {
                // Compute scaled bounds relative to the form's client area
                Rectangle o = cl.OriginalBounds;
                int newX = (int)Math.Round(o.X * scaleX);
                int newY = (int)Math.Round(o.Y * scaleY);
                int newW = Math.Max(1, (int)Math.Round(o.Width * scaleX));
                int newH = Math.Max(1, (int)Math.Round(o.Height * scaleY));

                // Apply bounds to the control
                cl.Control.Bounds = new Rectangle(newX, newY, newW, newH);

                // Scale font (avoid creating tiny fonts)
                try
                {
                    float newFontSize = Math.Max(6f, cl.OriginalFontSize * scaleForFont);
                    cl.Control.Font = new Font(cl.OriginalFontFamily, newFontSize, cl.OriginalFontStyle);
                }
                catch
                {
                    // Ignore font creation failures (fallback to existing font)
                }
            }
        }

        private static IEnumerable<Control> GetAllControls(Control parent)
        {
            Stack<Control> stack = new Stack<Control>();
            stack.Push(parent);

            while (stack.Count > 0)
            {
                Control c = stack.Pop();
                
                // Skip the form itself; we want child controls
                if (c != parent)
                {
                    yield return c;
                }

                foreach (Control child in c.Controls)
                {
                    stack.Push(child);
                }
            }
        }
    }
}