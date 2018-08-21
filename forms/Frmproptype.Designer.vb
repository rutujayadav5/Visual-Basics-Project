<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmproptype
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
        Me.Lbproptypeid = New System.Windows.Forms.Label
        Me.Lbproptype = New System.Windows.Forms.Label
        Me.Tbproptypeid = New System.Windows.Forms.TextBox
        Me.Tbproptype = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Btnexit = New System.Windows.Forms.Button
        Me.Btncancel = New System.Windows.Forms.Button
        Me.Btndelete = New System.Windows.Forms.Button
        Me.Btnupdate = New System.Windows.Forms.Button
        Me.Btnnew = New System.Windows.Forms.Button
        Me.DGVproptype = New System.Windows.Forms.DataGridView
        Me.Btndisplay = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVproptype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbproptypeid
        '
        Me.Lbproptypeid.AutoSize = True
        Me.Lbproptypeid.Location = New System.Drawing.Point(96, 12)
        Me.Lbproptypeid.Name = "Lbproptypeid"
        Me.Lbproptypeid.Size = New System.Drawing.Size(68, 13)
        Me.Lbproptypeid.TabIndex = 0
        Me.Lbproptypeid.Text = "Prop Type Id"
        '
        'Lbproptype
        '
        Me.Lbproptype.AutoSize = True
        Me.Lbproptype.Location = New System.Drawing.Point(96, 51)
        Me.Lbproptype.Name = "Lbproptype"
        Me.Lbproptype.Size = New System.Drawing.Size(56, 13)
        Me.Lbproptype.TabIndex = 1
        Me.Lbproptype.Text = "Prop Type"
        '
        'Tbproptypeid
        '
        Me.Tbproptypeid.Location = New System.Drawing.Point(227, 12)
        Me.Tbproptypeid.Name = "Tbproptypeid"
        Me.Tbproptypeid.Size = New System.Drawing.Size(100, 20)
        Me.Tbproptypeid.TabIndex = 2
        '
        'Tbproptype
        '
        Me.Tbproptype.Location = New System.Drawing.Point(227, 51)
        Me.Tbproptype.Name = "Tbproptype"
        Me.Tbproptype.Size = New System.Drawing.Size(100, 20)
        Me.Tbproptype.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btndisplay)
        Me.GroupBox1.Controls.Add(Me.Btnexit)
        Me.GroupBox1.Controls.Add(Me.Btncancel)
        Me.GroupBox1.Controls.Add(Me.Btndelete)
        Me.GroupBox1.Controls.Add(Me.Btnupdate)
        Me.GroupBox1.Controls.Add(Me.Btnnew)
        Me.GroupBox1.Location = New System.Drawing.Point(51, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 109)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
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
        'DGVproptype
        '
        Me.DGVproptype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVproptype.Location = New System.Drawing.Point(51, 192)
        Me.DGVproptype.Name = "DGVproptype"
        Me.DGVproptype.Size = New System.Drawing.Size(365, 80)
        Me.DGVproptype.TabIndex = 8
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
        'Frmproptype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 299)
        Me.Controls.Add(Me.DGVproptype)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Tbproptype)
        Me.Controls.Add(Me.Tbproptypeid)
        Me.Controls.Add(Me.Lbproptype)
        Me.Controls.Add(Me.Lbproptypeid)
        Me.Name = "Frmproptype"
        Me.Text = "Frmproptype"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVproptype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbproptypeid As System.Windows.Forms.Label
    Friend WithEvents Lbproptype As System.Windows.Forms.Label
    Friend WithEvents Tbproptypeid As System.Windows.Forms.TextBox
    Friend WithEvents Tbproptype As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btncancel As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents Btnupdate As System.Windows.Forms.Button
    Friend WithEvents Btnnew As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button
    Friend WithEvents DGVproptype As System.Windows.Forms.DataGridView
    Friend WithEvents Btndisplay As System.Windows.Forms.Button
End Class
