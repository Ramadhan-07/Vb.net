<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnMember = New System.Windows.Forms.Button()
        Me.BtnSewa = New System.Windows.Forms.Button()
        Me.BtnDvd = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(732, 350)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Ravie", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(86, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(540, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MADHONT DVD RENTAL"
        '
        'BtnMember
        '
        Me.BtnMember.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnMember.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMember.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnMember.Location = New System.Drawing.Point(209, 450)
        Me.BtnMember.Name = "BtnMember"
        Me.BtnMember.Size = New System.Drawing.Size(141, 80)
        Me.BtnMember.TabIndex = 2
        Me.BtnMember.Text = "Member"
        Me.BtnMember.UseVisualStyleBackColor = False
        '
        'BtnSewa
        '
        Me.BtnSewa.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnSewa.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSewa.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSewa.Location = New System.Drawing.Point(2, 450)
        Me.BtnSewa.Name = "BtnSewa"
        Me.BtnSewa.Size = New System.Drawing.Size(183, 80)
        Me.BtnSewa.TabIndex = 3
        Me.BtnSewa.Text = "Penyewaan"
        Me.BtnSewa.UseVisualStyleBackColor = False
        '
        'BtnDvd
        '
        Me.BtnDvd.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnDvd.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDvd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDvd.Location = New System.Drawing.Point(374, 450)
        Me.BtnDvd.Name = "BtnDvd"
        Me.BtnDvd.Size = New System.Drawing.Size(141, 80)
        Me.BtnDvd.TabIndex = 4
        Me.BtnDvd.Text = "DVD"
        Me.BtnDvd.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Sienna
        Me.BtnExit.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BtnExit.Location = New System.Drawing.Point(545, 450)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(141, 80)
        Me.BtnExit.TabIndex = 5
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(725, 542)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDvd)
        Me.Controls.Add(Me.BtnSewa)
        Me.Controls.Add(Me.BtnMember)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMenu"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnMember As System.Windows.Forms.Button
    Friend WithEvents BtnSewa As System.Windows.Forms.Button
    Friend WithEvents BtnDvd As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button

End Class
