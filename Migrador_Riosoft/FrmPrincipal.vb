Imports System
Imports System.Data
Imports System.IO
Imports System.ComponentModel
Imports System.Globalization
Imports System.Text
Imports System.Windows
Imports System.Text.RegularExpressions

Public Class FrmPrincipal

#Region "Funções delegadas"
    Private Delegate Sub pbar_callback(max As Double)
    Private Delegate Sub lbstatus_callback(txt As String)
#End Region

#Region "Funções auxiliares para as delegadas"
    Private Sub atualiza_pbar(max As Double)
        pbar.Maximum = max
        lbRegtotal.Text = CStr(CInt(max))
    End Sub

    Private Sub atualiza_status(txt As String)
        lbInfo.Text = txt
    End Sub

#End Region

#Region "Variavés Globais"
    Dim result As DataTable = Nothing
    Private produto As Boolean = False
#End Region


#Region "Funções Utilitárias"

    Private Function formata_str(ByVal dados As String, ByVal tamanho As Integer) As String
        Try
            Dim dados_tratados As String = String.Empty
            Dim tamanho_atual As Integer = 0


            dados_tratados = dados.Trim

            'Iniciando tratamento da String

            'Removendo caracteres especiais e inválidos para o SysPDV
            dados_tratados = dados_tratados.ToUpper().Replace("Á", "A").Replace("Â", "A").Replace("Ã", "A") _
                .Replace("À", "A").Replace("É", "E").Replace("Ê", "E").Replace("È", "E").Replace("Í", "I") _
                .Replace("Ì", "I").Replace("Ó", "O").Replace("Õ", "O").Replace("Ô", "O").Replace("Ò", "O") _
                .Replace("Ú", "U").Replace("Ü", "U").Replace("Ù", "U").Replace("Ç", "C")

            While dados_tratados.Contains(" X ")
                dados_tratados = dados_tratados.Replace(" X ", "x")
            End While
            While dados_tratados.Contains("(")
                dados_tratados = dados_tratados.Replace("(", " ")
            End While
            While dados_tratados.Contains(")")
                dados_tratados = dados_tratados.Replace(")", " ")
            End While
            While dados_tratados.Contains("[")
                dados_tratados = dados_tratados.Replace("[", " ")
            End While
            While dados_tratados.Contains("]")
                dados_tratados = dados_tratados.Replace("]", " ")
            End While
            While dados_tratados.Contains("/")
                dados_tratados = dados_tratados.Replace("/", " ")
            End While
            While dados_tratados.Contains("\")
                dados_tratados = dados_tratados.Replace("\", " ")
            End While
            While dados_tratados.Contains(".")
                dados_tratados = dados_tratados.Replace(".", " ")
            End While
            While dados_tratados.Contains("'") OrElse dados_tratados.Contains("´")
                dados_tratados = dados_tratados.Replace("'", " ")
                dados_tratados = dados_tratados.Replace("´", " ")
            End While
            While dados_tratados.Contains("$") OrElse dados_tratados.Contains("&") OrElse dados_tratados.Contains("§")
                dados_tratados = dados_tratados.Replace("$", " ")
                dados_tratados = dados_tratados.Replace("&", " ")
                dados_tratados = dados_tratados.Replace("§", " ")
            End While
            While dados_tratados.Contains("""")
                dados_tratados = dados_tratados.Replace("""", "P ")
            End While
            While dados_tratados.Contains("º") OrElse dados_tratados.Contains("ª")
                dados_tratados = dados_tratados.Replace("º", " ")
                dados_tratados = dados_tratados.Replace("ª", " ")
            End While
            While dados_tratados.Contains("€")
                dados_tratados = dados_tratados.Replace("€", " ")
            End While

            While dados_tratados.Contains("  ")
                dados_tratados = dados_tratados.Replace("  ", " ")
            End While

            dados_tratados = dados_tratados.Trim

            'Pegando somente o tamanho dos caracteres definido no escopo da função
            tamanho_atual = dados_tratados.Trim.Length
            If tamanho < tamanho_atual Then
                dados_tratados = dados_tratados.Substring(0, tamanho)
            Else
                dados_tratados = dados_tratados
            End If
            'Fim do tratamento da String

            'retornando a String formatada
            Return dados_tratados
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Migrador Riosoft - Error", MessageBoxButton.OK, MessageBoxImage.Error)
            geraLogerro(ex, Me)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Função que remove tudo o que não for número
    ''' </summary>
    ''' <param name="dados">Entrada que deverá ser tratada</param>
    ''' <returns>Retorna os dados somente com numeros</returns>
    ''' <remarks></remarks>
    Private Function remove_caracteres(ByRef dados As String) As String

        dados = dados.Trim
        Dim padraoRegex As String = "([^0-9])"
        Dim verifica As New Regex(padraoRegex)

        If Not IsNumeric(dados) Then
            dados = verifica.Replace(dados, verifica.IsMatch(dados, 0)).Replace("True", "")
        End If

        Return dados
    End Function

    ''' <summary>
    ''' Função que remove \n no final da linha
    ''' </summary>
    ''' <param name="dados">Entrada que deverá ser tratada</param>
    ''' <returns>Retorna os dados sem o \n</returns>
    ''' <remarks></remarks>
    Private Function remove_quebra_linha(ByRef dados As String) As String

        dados = dados.Trim
        Dim padraoRegex As String = "^(\n)$"
        Dim verifica As New Regex(padraoRegex)

        If Not String.IsNullOrEmpty(dados) Then
            dados = verifica.Replace(dados, verifica.IsMatch(dados, 0)).Replace("True", "")
        End If

        Return dados
    End Function

    Private Function limitar_dados(ByVal dados As String, ByRef tamanho As Integer) As String
        dados = dados.Trim

        If dados.Length > tamanho Then
            dados = dados.Substring(0, tamanho)
        End If

        Return dados
    End Function

#End Region

#Region "Eventos dos Botões"
    Private Sub btConfig_Click(sender As Object, e As EventArgs) Handles btConfig.Click
        Dim frm As frmConfigDB
        frm = New frmConfigDB()
        frm.ShowDialog()
    End Sub

    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        Me.Close()
    End Sub

    Private Sub btProcessar_Click(sender As Object, e As EventArgs) Handles btProcessar.Click
        produto = chProdutos.Checked

        If produto Then
            If Not workerThread.IsBusy = True Then
                btProcessar.Text = "cancelar"
                Dim sql As String = "select * from tbproduto"
                result = command(sql)
                pbar.Maximum = result.Rows.Count
                lbRegtotal.Text = "/ " & CStr(result.Rows.Count)

                workerThread.RunWorkerAsync()
            Else
                workerThread.CancelAsync()
                btProcessar.Text = "processar"
            End If
        Else
            MessageBox.Show("Selecione ao menos uma opção!", "Migrador Riosoft - Alerta", MessageBoxButton.OK, MessageBoxImage.Information)
        End If

    End Sub

#End Region

#Region "Eventos da workThread"

    Private Sub workerThread_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles workerThread.ProgressChanged
        Me.pbar.Value = e.ProgressPercentage
        Me.lbRegatual.Text = CStr(CInt(e.ProgressPercentage))
        Me.lbInfo.Text = e.UserState
    End Sub

    Private Sub workerThread_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles workerThread.RunWorkerCompleted
        btProcessar.Text = "Processar"
        lbRegtotal.Text = "/ 0"
        pbar.Maximum = 0
        pbar.Value = 0
        lbRegatual.Text = "0"
        If e.Cancelled = True Then
            lbInfo.Text = "Cancelado Pelo Usuário!"
        ElseIf e.Error IsNot Nothing Then
            lbInfo.Text = "Error: " & e.Error.Message
            geraLogerro(e.Error, Me)
            MessageBox.Show(e.Error.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lbInfo.Text = "Processo Finalizado!"
            MessageBox.Show("Processo finalizado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub workerThread_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles workerThread.DoWork
        Dim pasta As String = My.Computer.FileSystem.CurrentDirectory & "\arquivos"
        If Not My.Computer.FileSystem.DirectoryExists(pasta) Then
            My.Computer.FileSystem.CreateDirectory(pasta)
        End If

        Dim en_us As NumberFormatInfo = New CultureInfo("en-US", False).NumberFormat
        Dim atu_status As New lbstatus_callback(AddressOf atualiza_status)
        Dim atu_pbar As New pbar_callback(AddressOf atualiza_pbar)

        If produto Then
            Dim txt_prod As String = pasta & "\SYSPPRO.txt"

            If My.Computer.FileSystem.FileExists(txt_prod) Then
                My.Computer.FileSystem.DeleteFile(txt_prod)
            End If

            Dim arq_prod As New StreamWriter(txt_prod, True)

            Dim contador As Integer = 0

            For Each linha As DataRow In result.Rows

                Dim linha_formatada As String = String.Empty

                If workerThread.CancellationPending = True Then
                    e.Cancel = True
                    arq_prod.Close()
                    My.Computer.FileSystem.DeleteFile(txt_prod)
                    Exit For
                End If

                contador += 1
                workerThread.ReportProgress(contador, "Processando Produtos...")

            Next

        End If
    End Sub

#End Region

End Class
