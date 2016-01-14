Imports FirebirdSql.Data.FirebirdClient
Imports System.Data
Imports System.IO
Imports Migrador_Riosoft.My.Resources

Module Conecta

    Public Function getConnection() As FbConnection
        Dim _conn As String
        _conn = "User=" & My.Settings.user & ";Password=" & My.Settings.pass
        _conn += ";DataBase=" & My.Settings.db & ";DataSource=" & My.Settings.server
        _conn += ";Port=" & My.Settings.port & ";Dialect=3;Charset=None;Role=;Connection lifetime=15;"
        _conn += "Connection timeout=7;Pooling=True;Packet Size=8192;ServerType=0"
        Return New FbConnection(_conn)
    End Function
    Public Function command(ByRef sql As String) As DataTable
        'Cria um tabela de dados
        Dim dt As DataTable = New DataTable
        Using connection As FbConnection = getConnection()
            Try
                'Abre a conexão com o banco de dados
                connection.Open()
                'Cria um adaptador de dados
                Dim da As FbDataAdapter
                Dim cmd As FbCommand = New FbCommand(sql, connection)
                da = New FbDataAdapter(cmd)
                da.Fill(dt)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Análise de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                geraLogerro(ex, Form.ActiveForm)
            End Try
        End Using
        Return dt
    End Function
    Public Sub geraLogerro(ByRef e As Exception, ByRef form As Form)
        Try
            Dim sw As New StreamWriter(Application.StartupPath & "\logerro.txt", True)
            With sw
                .WriteLine("#####################################################################################")
                .WriteLine("Data: " & DateTime.Now.ToShortDateString())
                .WriteLine("Hora: " & DateTime.Now.ToShortTimeString())
                .WriteLine("Descrição do erro: " & e.Message)
                .WriteLine("Formulário: " & form.Name)
                .WriteLine("Computador: " & My.Computer.Name)
                .WriteLine("Usuário: " & My.User.Name)
                .WriteLine("*******************( Detalhes do Erro )**********************************************")
                .WriteLine(e.ToString)
                .WriteLine("*************************************************************************************")
                .WriteLine("######################################################################################")
                .Flush()
                .Dispose()
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Function GetTotalRegistros(ByVal sql As String) As Integer
        Dim cmd As FbCommand
        Dim _TotalRegistros As Integer
        Try
            Using conn As FbConnection = getConnection()
                cmd = New FbCommand(sql, conn)
                conn.Open()
                _TotalRegistros = Integer.Parse(cmd.ExecuteScalar().ToString)
                conn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro!" & vbCrLf & "Por favor contactar suporte.",
                            "Análise de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            geraLogerro(ex, Form.ActiveForm)
        End Try
        Return _TotalRegistros
    End Function
End Module