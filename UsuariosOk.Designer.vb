<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsuariosOk
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosOk))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblTitleUsers = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.DataList = New System.Windows.Forms.DataGridView()
        Me.Eli = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblIdUsuario = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.LblTitleUsers)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 47)
        Me.Panel1.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(719, 10)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(28, 34)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "X"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblTitleUsers
        '
        Me.LblTitleUsers.AutoSize = True
        Me.LblTitleUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitleUsers.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblTitleUsers.Location = New System.Drawing.Point(12, 13)
        Me.LblTitleUsers.Name = "LblTitleUsers"
        Me.LblTitleUsers.Size = New System.Drawing.Size(95, 20)
        Me.LblTitleUsers.TabIndex = 0
        Me.LblTitleUsers.Text = "USUARIOS"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuStrip2)
        Me.Panel2.Controls.Add(Me.TxtSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 63)
        Me.Panel2.TabIndex = 1
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip2.Location = New System.Drawing.Point(40, 21)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(36, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "Eliminar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(28, 20)
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(78, 21)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(454, 20)
        Me.TxtSearch.TabIndex = 0
        '
        'DataList
        '
        Me.DataList.AllowUserToAddRows = False
        Me.DataList.AllowUserToDeleteRows = False
        Me.DataList.AllowUserToResizeRows = False
        Me.DataList.BackgroundColor = System.Drawing.Color.White
        Me.DataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eli})
        Me.DataList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataList.Location = New System.Drawing.Point(0, 110)
        Me.DataList.Name = "DataList"
        Me.DataList.RowHeadersVisible = False
        Me.DataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataList.Size = New System.Drawing.Size(587, 355)
        Me.DataList.TabIndex = 2
        '
        'Eli
        '
        Me.Eli.HeaderText = ""
        Me.Eli.Image = CType(resources.GetObject("Eli.Image"), System.Drawing.Image)
        Me.Eli.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Eli.Name = "Eli"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LblIdUsuario)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.TxtPassword)
        Me.Panel3.Controls.Add(Me.TxtUser)
        Me.Panel3.Controls.Add(Me.TxtNombre)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.MenuStrip1)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel3.Location = New System.Drawing.Point(22, 134)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(726, 250)
        Me.Panel3.TabIndex = 3
        '
        'LblIdUsuario
        '
        Me.LblIdUsuario.AutoSize = True
        Me.LblIdUsuario.Location = New System.Drawing.Point(135, 179)
        Me.LblIdUsuario.Name = "LblIdUsuario"
        Me.LblIdUsuario.Size = New System.Drawing.Size(10, 13)
        Me.LblIdUsuario.TabIndex = 9
        Me.LblIdUsuario.Text = " "
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel6.Controls.Add(Me.Button4)
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(724, 28)
        Me.Panel6.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(696, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 25)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1007, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 34)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1070, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 28)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(81, 151)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(268, 20)
        Me.TxtPassword.TabIndex = 5
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(81, 116)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(268, 20)
        Me.TxtUser.TabIndex = 4
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(81, 83)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(268, 20)
        Me.TxtNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CheckBox8)
        Me.Panel4.Controls.Add(Me.CheckBox7)
        Me.Panel4.Controls.Add(Me.CheckBox6)
        Me.Panel4.Controls.Add(Me.CheckBox5)
        Me.Panel4.Controls.Add(Me.CheckBox4)
        Me.Panel4.Controls.Add(Me.CheckBox3)
        Me.Panel4.Controls.Add(Me.CheckBox2)
        Me.Panel4.Controls.Add(Me.CheckBox1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(374, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(217, 199)
        Me.Panel4.TabIndex = 6
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(128, 165)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox8.TabIndex = 9
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(128, 133)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox7.TabIndex = 8
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(128, 94)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(69, 17)
        Me.CheckBox6.TabIndex = 7
        Me.CheckBox6.Text = "Reportes"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(128, 61)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(69, 17)
        Me.CheckBox5.TabIndex = 6
        Me.CheckBox5.Text = "Intereses"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(16, 165)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox4.TabIndex = 5
        Me.CheckBox4.Text = "Pagos"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(16, 94)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox3.TabIndex = 4
        Me.CheckBox3.Text = "Configuracion"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(16, 133)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Cobros"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(16, 61)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Matriculas"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(20, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Asignacion de permisos"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.GuardarCambiosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 219)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(724, 29)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GuardarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GuardarCambiosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(153, 25)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar Cambios"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(587, 110)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(173, 355)
        Me.Panel5.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(43, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'UsuariosOk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 465)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataList)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UsuariosOk"
        Me.Text = "UsuariosOk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTitleUsers As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DataList As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnClose As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LblIdUsuario As Label
    Friend WithEvents Eli As DataGridViewImageColumn
End Class
