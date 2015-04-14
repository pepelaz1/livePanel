<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnShowRect = New System.Windows.Forms.Button
        Me.panelRectangle = New RectangleApp.LivePanel
        Me.SuspendLayout()
        '
        'btnShowRect
        '
        Me.btnShowRect.Location = New System.Drawing.Point(242, 322)
        Me.btnShowRect.Name = "btnShowRect"
        Me.btnShowRect.Size = New System.Drawing.Size(111, 23)
        Me.btnShowRect.TabIndex = 1
        Me.btnShowRect.Text = "Show rectangle"
        Me.btnShowRect.UseVisualStyleBackColor = True
        '
        'panelRectangle
        '
        Me.panelRectangle.BackColor = System.Drawing.Color.Orange
        Me.panelRectangle.Location = New System.Drawing.Point(199, 122)
        Me.panelRectangle.Name = "panelRectangle"
        Me.panelRectangle.Size = New System.Drawing.Size(200, 100)
        Me.panelRectangle.TabIndex = 0
        Me.panelRectangle.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 435)
        Me.Controls.Add(Me.btnShowRect)
        Me.Controls.Add(Me.panelRectangle)
        Me.Name = "MainForm"
        Me.Text = "Main form"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelRectangle As RectangleApp.LivePanel
    Friend WithEvents btnShowRect As System.Windows.Forms.Button

End Class
