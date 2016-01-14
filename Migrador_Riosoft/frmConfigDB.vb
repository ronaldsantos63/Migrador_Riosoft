Imports FirebirdSql.Data.FirebirdClient
Public Class frmConfigDB

    Private Sub frmConfigDB_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            If btnEditar.Enabled = False Then
                If txtBanco.Modified Or txtPorta.Modified Or txtSenha.Modified Or
                txtServidor.Modified Or txtUsuario.Modified Then
                    If MessageBox.Show("Deseja cancelar as alterações?", "Migrador Riosoft - Alerta", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        cancelar()
                    Else
                        txtServidor.Focus()
                        txtServidor.SelectAll()
                    End If
                Else
                    cancelar()
                End If
            Else
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            cancelar()
        ElseIf e.KeyCode = Keys.F7 Then
            editar()
            txtServidor.Focus()
            txtServidor.SelectAll()
        ElseIf e.KeyCode = Keys.F9 Then
            gravar()
        ElseIf e.KeyCode = Keys.F10 Then
            testar()
        End If
    End Sub

    Private Sub frmConfigDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtServidor.Text = My.Settings.server
            txtUsuario.Text = My.Settings.user
            txtSenha.Text = My.Settings.pass
            txtPorta.Text = My.Settings.port
            txtBanco.Text = My.Settings.db
            Using connection As FbConnection = getConnection()
                Try
                    connection.Open()
                    logoStatus.Image = logoStatus.InitialImage
                    connection.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    logoStatus.Image = logoStatus.ErrorImage
                End Try
            End Using
            Me.ActiveControl = btnEditar
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro!" & vbCrLf & "Por favor contactar suporte.",
                            "Migrador Riosoft - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            geraLogerro(ex, Form.ActiveForm)
        End Try
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub editar()
        txtServidor.Enabled = True
        txtUsuario.Enabled = True
        txtSenha.Enabled = True
        txtPorta.Enabled = True
        txtBanco.Enabled = True
        btnLocalizar.Enabled = True
        btnEditar.Enabled = False
        btnCancelar.Enabled = True
        btnGravar.Enabled = True
        btnSair.Enabled = False
        btnTestar.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editar()
    End Sub

    Private Sub cancelar()
        txtServidor.Enabled = False
        txtUsuario.Enabled = False
        txtSenha.Enabled = False
        txtPorta.Enabled = False
        txtBanco.Enabled = False
        btnLocalizar.Enabled = False
        btnEditar.Enabled = True
        btnCancelar.Enabled = False
        btnGravar.Enabled = False
        btnSair.Enabled = True
        btnTestar.Enabled = True
        btnTestar.Focus()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cancelar()
    End Sub

    Private Sub testar()
        Using connection As FbConnection = getConnection()
            Try
                connection.Open()
                logoStatus.Image = logoStatus.InitialImage
                connection.Close()
                MessageBox.Show("Conectado com sucesso!", "Migrador Riosoft - Informa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Não foi possível conectar ao banco de dados!", "Migrador Riosoft - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                logoStatus.Image = logoStatus.ErrorImage
            End Try
        End Using
    End Sub

    Private Sub btnTestar_Click(sender As Object, e As EventArgs) Handles btnTestar.Click
        testar()
    End Sub

    Private Sub gravar()
        My.Settings.server = txtServidor.Text
        My.Settings.user = txtUsuario.Text
        My.Settings.pass = txtSenha.Text
        My.Settings.port = txtPorta.Text
        My.Settings.db = txtBanco.Text
        My.Settings.Save()

        MessageBox.Show("Configurações salvas com sucesso!", "Migrador Riosoft - Informa", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtServidor.Enabled = False
        txtUsuario.Enabled = False
        txtSenha.Enabled = False
        txtPorta.Enabled = False
        txtBanco.Enabled = False
        btnLocalizar.Enabled = False
        btnEditar.Enabled = True
        btnCancelar.Enabled = False
        btnGravar.Enabled = False
        btnSair.Enabled = True
        btnTestar.Enabled = True
        btnTestar.Focus()
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        gravar()
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        With DialogoLocalizaDB
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtBanco.Text = .FileName
            End If
        End With
    End Sub
End Class