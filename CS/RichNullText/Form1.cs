using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Layout;
using DevExpress.XtraRichEdit;


namespace RichNullText
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();

            richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            richEditControl.BeforePagePaint += richEditControl_BeforePagePaint;
            richEditControl.GotFocus += richEditControl_FocusChanged;
            richEditControl.LostFocus += richEditControl_FocusChanged;
        }

        void richEditControl_FocusChanged(object sender, EventArgs e)
        {
            richEditControl.Refresh();
        }

        void richEditControl_BeforePagePaint(object sender, DevExpress.XtraRichEdit.BeforePagePaintEventArgs e)
        {
            e.Painter = new CustomPagePainter(richEditControl);
        }
    }

    public class CustomPagePainter : PagePainter
    {
        private RichEditControl control;
        public CustomPagePainter(RichEditControl control)
        {
            this.control = control;
        }
        public override void DrawPage(LayoutPage page)
        {
            if (control.Document.IsEmpty && !control.Focused)
                this.Canvas.DrawString("NullText", new Font("Calibri", 11), new RichEditBrush(Color.Gray), page.Bounds.Location);
            base.DrawPage(page);
        }
    }
}