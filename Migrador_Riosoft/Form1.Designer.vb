﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpOpcoes = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btConfig = New System.Windows.Forms.Button()
        Me.btProcessar = New System.Windows.Forms.Button()
        Me.pbar = New System.Windows.Forms.ProgressBar()
        Me.lbRegatual = New System.Windows.Forms.Label()
        Me.lbRegtotal = New System.Windows.Forms.Label()
        Me.lbInfo = New System.Windows.Forms.Label()
        Me.chProdutos = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.grpOpcoes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbInfo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.grpOpcoes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 259)
        Me.Panel1.TabIndex = 0
        '
        'grpOpcoes
        '
        Me.grpOpcoes.Controls.Add(Me.chProdutos)
        Me.grpOpcoes.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.grpOpcoes.Name = "grpOpcoes"
        Me.grpOpcoes.Size = New System.Drawing.Size(478, 164)
        Me.grpOpcoes.TabIndex = 0
        Me.grpOpcoes.TabStop = False
        Me.grpOpcoes.Text = "Selecione as opções que deseja migrar"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbRegtotal)
        Me.Panel2.Controls.Add(Me.lbRegatual)
        Me.Panel2.Controls.Add(Me.pbar)
        Me.Panel2.Controls.Add(Me.btProcessar)
        Me.Panel2.Controls.Add(Me.btConfig)
        Me.Panel2.Controls.Add(Me.btSair)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 194)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(478, 63)
        Me.Panel2.TabIndex = 1
        '
        'btSair
        '
        Me.btSair.Location = New System.Drawing.Point(392, 32)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(75, 23)
        Me.btSair.TabIndex = 0
        Me.btSair.Text = "Sair"
        Me.btSair.UseVisualStyleBackColor = True
        '
        'btConfig
        '
        Me.btConfig.Location = New System.Drawing.Point(311, 32)
        Me.btConfig.Name = "btConfig"
        Me.btConfig.Size = New System.Drawing.Size(75, 23)
        Me.btConfig.TabIndex = 1
        Me.btConfig.Text = "Config"
        Me.btConfig.UseVisualStyleBackColor = True
        '
        'btProcessar
        '
        Me.btProcessar.Location = New System.Drawing.Point(230, 32)
        Me.btProcessar.Name = "btProcessar"
        Me.btProcessar.Size = New System.Drawing.Size(75, 23)
        Me.btProcessar.TabIndex = 2
        Me.btProcessar.Text = "Processar"
        Me.btProcessar.UseVisualStyleBackColor = True
        '
        'pbar
        '
        Me.pbar.Location = New System.Drawing.Point(11, 3)
        Me.pbar.Name = "pbar"
        Me.pbar.Size = New System.Drawing.Size(456, 23)
        Me.pbar.TabIndex = 3
        '
        'lbRegatual
        '
        Me.lbRegatual.Location = New System.Drawing.Point(11, 29)
        Me.lbRegatual.Name = "lbRegatual"
        Me.lbRegatual.Size = New System.Drawing.Size(107, 23)
        Me.lbRegatual.TabIndex = 4
        Me.lbRegatual.Text = "0"
        Me.lbRegatual.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbRegtotal
        '
        Me.lbRegtotal.Location = New System.Drawing.Point(117, 29)
        Me.lbRegtotal.Name = "lbRegtotal"
        Me.lbRegtotal.Size = New System.Drawing.Size(100, 23)
        Me.lbRegtotal.TabIndex = 5
        Me.lbRegtotal.Text = "/ 0"
        '
        'lbInfo
        '
        Me.lbInfo.AutoEllipsis = True
        Me.lbInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbInfo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInfo.Location = New System.Drawing.Point(0, 167)
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(478, 27)
        Me.lbInfo.TabIndex = 2
        Me.lbInfo.Text = "Aplicação Iniciada"
        Me.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbInfo.UseCompatibleTextRendering = True
        '
        'chProdutos
        '
        Me.chProdutos.AutoSize = True
        Me.chProdutos.Location = New System.Drawing.Point(14, 29)
        Me.chProdutos.Name = "chProdutos"
        Me.chProdutos.Size = New System.Drawing.Size(68, 17)
        Me.chProdutos.TabIndex = 0
        Me.chProdutos.Text = "Produtos"
        Me.chProdutos.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 259)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPrincipal"
        Me.Text = "Migrador Riosoft"
        Me.Panel1.ResumeLayout(False)
        Me.grpOpcoes.ResumeLayout(False)
        Me.grpOpcoes.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbInfo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbRegtotal As System.Windows.Forms.Label
    Friend WithEvents lbRegatual As System.Windows.Forms.Label
    Friend WithEvents pbar As System.Windows.Forms.ProgressBar
    Friend WithEvents btProcessar As System.Windows.Forms.Button
    Friend WithEvents btConfig As System.Windows.Forms.Button
    Friend WithEvents btSair As System.Windows.Forms.Button
    Friend WithEvents grpOpcoes As System.Windows.Forms.GroupBox
    Friend WithEvents chProdutos As System.Windows.Forms.CheckBox

End Class
