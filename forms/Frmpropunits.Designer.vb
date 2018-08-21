<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmpropunits
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
        Me.DGVpropunits = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Btndisplay = New System.Windows.Forms.Button
        Me.Btnexit = New System.Windows.Forms.Button
        Me.Btncancel = New System.Windows.Forms.Button
        Me.Btndelete = New System.Windows.Forms.Button
        Me.Btnupdate = New System.Windows.Forms.Button
        Me.Btnnew = New System.Windows.Forms.Button
        Me.Tbpropunits = New System.Windows.Forms.TextBox
        Me.Tbpropunitsid = New System.Windows.Forms.TextBox
        Me.Lbpropunits = New System.Windows.Forms.Label
        Me.Lbpropunitsid = New System.Windows.Forms.Label
        CType(Me.DGVpropunits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVpropunits
        '
        Me.DGVpropunits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVpropunits.Location = New System.Drawing.Point(122, 212)
        Me.DGVpropunits.Name = "DGVpropunits"
        Me.DGVpropunits.Size = New System.Drawing.Size(365, 80)
        Me.DGVpropunits.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btndisplay)
        Me.GroupBox1.Controls.Add(Me.Btnexit)
        Me.GroupBox1.Controls.Add(Me.Btncancel)
        Me.GroupBox1.Controls.Add(Me.Btndelete)
        Me.GroupBox1.Controls.Add(Me.Btnupdate)
        Me.GroupBox1.Controls.Add(Me.Btnnew)
        Me.GroupBox1.Location = New System.Drawing.Point(122, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 109)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Btndisplay
        '
        Me.Btndisplay.Location = New System.Drawing.Point(251, 59)
        Me.Btndisplay.Name = "Btndisplay"
        Me.Btndisplay.Size = New System.Drawing.Size(75, 23)
        Me.Btndisplay.TabIndex = 5
        Me.Btndisplay.Text = "display"
        Me.Btndisplay.UseVisualStyleBackColor = True
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(133, 59)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(75, 23)
        Me.Btnexit.TabIndex = 4
        Me.Btnexit.Text = "exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Btncancel
        '
        Me.Btncancel.Location = New System.Drawing.Point(19, 59)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(75, 23)
        Me.Btncancel.TabIndex = 3
        Me.Btncancel.Text = "cancel"
        Me.Btncancel.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Location = New System.Drawing.Point(251, 31)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(75, 23)
        Me.Btndelete.TabIndex = 2
        Me.Btndelete.Text = "delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'Btnupdate
        '
        Me.Btnupdate.Location = New System.Drawing.Point(133, 30)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.Btnupdate.TabIndex = 1
        Me.Btnupdate.Text = "update"
        Me.Btnupdate.UseVisualStyleBackColor = True
        '
        'Btnnew
        '
        Me.Btnnew.Location = New System.Drawing.Point(19, 30)
        Me.Btnnew.Name = "Btnnew"
        Me.Btnnew.Size = New System.Drawing.Size(75, 23)
        Me.Btnnew.TabIndex = 0
        Me.Btnnew.Text = "New"
        Me.Btnnew.UseVisualStyleBackColor = True
        '
        'Tbpropunits
        '
        Me.Tbpropunits.Location = New System.Drawing.Point(298, 71)
        Me.Tbpropunits.Name = "Tbpropunits"
        Me.Tbpropunits.Size = New System.Drawing.Size(100, 20)
        Me.Tbpropunits.TabIndex = 12
        '
        'Tbpropunitsid
        '
        Me.Tbpropunitsid.Location = New System.Drawing.Point(298, 32)
        Me.Tbpropunitsid.Name = "Tbpropunitsid"
        Me.Tbpropunitsid.Size = New System.Drawing.Size(100, 20)
        Me.Tbpropunitsid.TabIndex = 11
        '
        'Lbpropunits
        '
        Me.Lbpropunits.AutoSize = True
        Me.Lbpropunits.Location = New System.Drawing.Point(167, 71)
        Me.Lbpropunits.Name = "Lbpropunits"
        Me.Lbpropunits.Size = New System.Drawing.Size(56, 13)
        Me.Lbpropunits.TabIndex = 10
        Me.Lbpropunits.Text = "Prop Units"
        '
        'Lbpropunitsid
        '
        Me.Lbpropunitsid.AutoSize = True
        Me.Lbpropunitsid.Location = New System.Drawing.Point(167, 32)
        Me.Lbpropunitsid.Name = "Lbpropunitsid"
        Me.Lbpropunitsid.Size = New System.Drawing.Size(70, 13)
        Me.Lbpropunitsid.TabIndex = 9
        Me.Lbpropunitsid.Text = "Prop Units id "
        '
        'Frmpropunits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 324)
        Me.Controls.Add(Me.DGVpropunits)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Tbpropunits)
        Me.Controls.Add(Me.Tbpropunitsid)
        Me.Controls.Add(Me.Lbpropunits)
        Me.Controls.Add(Me.Lbpropunitsid)
        Me.Name = "Frmpropunits"
        Me.Text = "Frmpropunits"
        CType(Me.DGVpropunits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVpropunits As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btndisplay As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button
    Friend WithEvents Btncancel As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents Btnupdate As System.Windows.Forms.Button
    Friend WithEvents Btnnew As System.Windows.Forms.Button
    Friend WithEvents Tbpropunits As System.Windows.Forms.TextBox
    Friend WithEvents Tbpropunitsid As System.Windows.Forms.TextBox
    Friend WithEvents Lbpropunits As System.Windows.Forms.Label
    Friend WithEvents Lbpropunitsid As System.Windows.Forms.Label
End Class
