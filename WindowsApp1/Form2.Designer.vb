<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.TitleListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(16, 23)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoryComboBox.TabIndex = 0
        '
        'TitleListBox
        '
        Me.TitleListBox.FormattingEnabled = True
        Me.TitleListBox.Location = New System.Drawing.Point(39, 92)
        Me.TitleListBox.Name = "TitleListBox"
        Me.TitleListBox.Size = New System.Drawing.Size(120, 95)
        Me.TitleListBox.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TitleListBox)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents TitleListBox As ListBox
End Class
