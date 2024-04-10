<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(358, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(104, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Acceder"
        '
        'TxtUser
        '
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.Location = New System.Drawing.Point(104, 301)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(174, 17)
        Me.TxtUser.TabIndex = 3
        Me.TxtUser.Text = "Usuario"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(106, 324)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 1)
        Me.Panel1.TabIndex = 4
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(104, 347)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(174, 17)
        Me.TxtPassword.TabIndex = 5
        Me.TxtPassword.Text = "Contraseña"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(106, 363)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(172, 1)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ingrese su contraseña"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(107, 412)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(170, 29)
        Me.BtnLogin.TabIndex = 8
        Me.BtnLogin.Text = "Iniciar Sesion"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(396, 490)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLogin As Button
End Class
