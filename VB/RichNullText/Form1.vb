Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit.API.Layout
Imports DevExpress.XtraRichEdit


Namespace RichNullText
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()

            richEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
            AddHandler richEditControl.BeforePagePaint, AddressOf richEditControl_BeforePagePaint
            AddHandler richEditControl.GotFocus, AddressOf richEditControl_FocusChanged
            AddHandler richEditControl.LostFocus, AddressOf richEditControl_FocusChanged
        End Sub

        Private Sub richEditControl_FocusChanged(ByVal sender As Object, ByVal e As EventArgs)
            richEditControl.Refresh()
        End Sub

        Private Sub richEditControl_BeforePagePaint(ByVal sender As Object, ByVal e As DevExpress.XtraRichEdit.BeforePagePaintEventArgs)
            e.Painter = New CustomPagePainter(richEditControl)
        End Sub
    End Class

    Public Class CustomPagePainter
        Inherits PagePainter

        Private control As RichEditControl
        Public Sub New(ByVal control As RichEditControl)
            Me.control = control
        End Sub
        Public Overrides Sub DrawPage(ByVal page As LayoutPage)
            If control.Document.IsEmpty AndAlso (Not control.Focused) Then
                Me.Canvas.DrawString("NullText", New Font("Calibri", 11), New RichEditBrush(Color.Gray), page.Bounds.Location)
            End If
            MyBase.DrawPage(page)
        End Sub
    End Class
End Namespace