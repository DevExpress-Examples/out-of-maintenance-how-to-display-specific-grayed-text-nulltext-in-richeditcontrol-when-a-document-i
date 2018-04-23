Namespace RichNullText
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Dim optionsSpelling2 As New DevExpress.XtraSpellChecker.OptionsSpelling()
            Me.richEditControl = New DevExpress.XtraRichEdit.RichEditControl()
            Me.spellChecker = New DevExpress.XtraSpellChecker.SpellChecker(Me.components)
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' richEditControl
            ' 
            Me.richEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl.Location = New System.Drawing.Point(119, 32)
            Me.richEditControl.Name = "richEditControl"
            Me.richEditControl.Size = New System.Drawing.Size(418, 331)
            Me.richEditControl.SpellChecker = Me.spellChecker
            Me.spellChecker.SetSpellCheckerOptions(Me.richEditControl, optionsSpelling1)
            Me.richEditControl.TabIndex = 2
            ' 
            ' spellChecker
            ' 
            Me.spellChecker.Culture = New System.Globalization.CultureInfo("ru-RU")
            Me.spellChecker.ParentContainer = Nothing
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New System.Drawing.Point(13, 33)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
            Me.textEdit1.Properties.NullValuePrompt = "NullText"
            Me.textEdit1.Properties.NullValuePromptShowForEmptyValue = True
            Me.spellChecker.SetShowSpellCheckMenu(Me.textEdit1, True)
            Me.textEdit1.Size = New System.Drawing.Size(100, 20)
            Me.spellChecker.SetSpellCheckerOptions(Me.textEdit1, optionsSpelling2)
            Me.textEdit1.TabIndex = 1
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(13, 13)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(40, 13)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "TextEdit"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(124, 13)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(73, 13)
            Me.labelControl2.TabIndex = 4
            Me.labelControl2.Text = "RichEditControl"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(541, 373)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.textEdit1)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.richEditControl)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private richEditControl As DevExpress.XtraRichEdit.RichEditControl
        Private spellChecker As DevExpress.XtraSpellChecker.SpellChecker
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private textEdit1 As DevExpress.XtraEditors.TextEdit
        Private labelControl2 As DevExpress.XtraEditors.LabelControl

    End Class
End Namespace
