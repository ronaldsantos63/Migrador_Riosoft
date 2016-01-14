<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigDB
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigDB))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnTestar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logoStatus = New System.Windows.Forms.PictureBox()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.txtPorta = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DialogoLocalizaDB = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.logoStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 265)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnTestar)
        Me.Panel3.Controls.Add(Me.btnGravar)
        Me.Panel3.Controls.Add(Me.btnEditar)
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnSair)
        Me.Panel3.Location = New System.Drawing.Point(11, 188)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(431, 59)
        Me.Panel3.TabIndex = 1
        '
        'btnTestar
        '
        Me.btnTestar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTestar.Image = CType(resources.GetObject("btnTestar.Image"), System.Drawing.Image)
        Me.btnTestar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTestar.Location = New System.Drawing.Point(3, 3)
        Me.btnTestar.Name = "btnTestar"
        Me.btnTestar.Size = New System.Drawing.Size(75, 49)
        Me.btnTestar.TabIndex = 6
        Me.btnTestar.Text = "Testar - F10"
        Me.btnTestar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTestar.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGravar.Enabled = False
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGravar.Location = New System.Drawing.Point(112, 3)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(75, 49)
        Me.btnGravar.TabIndex = 7
        Me.btnGravar.Text = "Gravar - F9"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(193, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(74, 49)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar - F7"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(273, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(77, 49)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar - F6"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(356, 3)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(72, 49)
        Me.btnSair.TabIndex = 10
        Me.btnSair.Text = "Sair - Esc"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.logoStatus)
        Me.Panel2.Controls.Add(Me.btnLocalizar)
        Me.Panel2.Controls.Add(Me.txtBanco)
        Me.Panel2.Controls.Add(Me.txtPorta)
        Me.Panel2.Controls.Add(Me.txtSenha)
        Me.Panel2.Controls.Add(Me.txtUsuario)
        Me.Panel2.Controls.Add(Me.txtServidor)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(11, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(431, 171)
        Me.Panel2.TabIndex = 0
        '
        'logoStatus
        '
        Me.logoStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.logoStatus.ErrorImage = CType(resources.GetObject("logoStatus.ErrorImage"), System.Drawing.Image)
        Me.logoStatus.InitialImage = CType(resources.GetObject("logoStatus.InitialImage"), System.Drawing.Image)
        Me.logoStatus.Location = New System.Drawing.Point(308, 14)
        Me.logoStatus.Name = "logoStatus"
        Me.logoStatus.Size = New System.Drawing.Size(110, 95)
        Me.logoStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoStatus.TabIndex = 3
        Me.logoStatus.TabStop = False
        '
        'btnLocalizar
        '
        Me.btnLocalizar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLocalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLocalizar.Enabled = False
        Me.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocalizar.Image = CType(resources.GetObject("btnLocalizar.Image"), System.Drawing.Image)
        Me.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLocalizar.Location = New System.Drawing.Point(308, 115)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(110, 25)
        Me.btnLocalizar.TabIndex = 5
        Me.btnLocalizar.Text = "Localizar"
        Me.btnLocalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLocalizar.UseVisualStyleBackColor = False
        '
        'txtBanco
        '
        Me.txtBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem
        Me.txtBanco.Enabled = False
        Me.txtBanco.Location = New System.Drawing.Point(69, 120)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(233, 20)
        Me.txtBanco.TabIndex = 4
        '
        'txtPorta
        '
        Me.txtPorta.AutoCompleteCustomSource.AddRange(New String() {"3050"})
        Me.txtPorta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPorta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPorta.Enabled = False
        Me.txtPorta.Location = New System.Drawing.Point(69, 93)
        Me.txtPorta.Name = "txtPorta"
        Me.txtPorta.Size = New System.Drawing.Size(233, 20)
        Me.txtPorta.TabIndex = 3
        '
        'txtSenha
        '
        Me.txtSenha.Enabled = False
        Me.txtSenha.Location = New System.Drawing.Point(69, 66)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.txtSenha.Size = New System.Drawing.Size(233, 20)
        Me.txtSenha.TabIndex = 2
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoCompleteCustomSource.AddRange(New String() {"SYSDBA"})
        Me.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(69, 39)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(233, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtServidor
        '
        Me.txtServidor.AutoCompleteCustomSource.AddRange(New String() {"localhost", "127.0.0.1"})
        Me.txtServidor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtServidor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtServidor.Enabled = False
        Me.txtServidor.Location = New System.Drawing.Point(69, 11)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(233, 20)
        Me.txtServidor.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Banco: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Porta: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Senha: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Usuário: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Servidor:"
        '
        'DialogoLocalizaDB
        '
        Me.DialogoLocalizaDB.Filter = "Arquivos de Banco de Dados|*.gdb;*.fdb"
        Me.DialogoLocalizaDB.InitialDirectory = "C:\"
        Me.DialogoLocalizaDB.Title = "Localizar Banco de Dados"
        '
        'frmConfigDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(462, 265)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfigDB"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Banco de Dados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.logoStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnTestar As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents logoStatus As System.Windows.Forms.PictureBox
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtPorta As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtServidor As System.Windows.Forms.TextBox
    Friend WithEvents DialogoLocalizaDB As System.Windows.Forms.OpenFileDialog
End Class
