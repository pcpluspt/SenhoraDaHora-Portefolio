Imports System.IO
Public Class config
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub

    Private Sub btnPastaComum_Click(sender As Object, e As EventArgs) Handles btnPastaComum.Click
        If FolderBrowserDialog1.ShowDialog() Then
            txtPastaComum.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() Then
            txtFileAndre.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() Then
            txtFileAndrei.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If OpenFileDialog1.ShowDialog() Then
            txtFileDuarte.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog() Then
            txtFileFabricio.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If OpenFileDialog1.ShowDialog() Then
            txtFileFilipe.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If OpenFileDialog1.ShowDialog() Then
            txtFileFrancisco.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If OpenFileDialog1.ShowDialog() Then
            txtFileJoao.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If OpenFileDialog1.ShowDialog() Then
            txtFileLeandro.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If OpenFileDialog1.ShowDialog() Then
            txtFileRicardo.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If OpenFileDialog1.ShowDialog() Then
            txtFileTomas.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim configFile As String = ""
        configFile = Application.StartupPath + "config.txt"

        Dim ficheiro As String = ""
        Dim f As TextReader
        Dim linha As String = ""
        Dim configPath = ""
        Dim fileAndre = ""
        Dim fileAndrei = ""
        Dim fileDuarte = ""
        Dim fileFabricio = ""
        Dim fileFilipe = ""
        Dim fileFrancisco = ""
        Dim fileJoao = ""
        Dim fileLeonardo = ""
        Dim fileRicardo = ""
        Dim fileTomas = ""


        Try
            '--- ficheiro de configuração inicial ---
            f = New StreamReader(configFile)
            'Dim s As String = ""
            'While True
            '    linha = f.ReadLine()
            '    If linha Is Nothing Then
            '        Exit While
            '    Else
            '        s = s + linha + vbCrLf ' Chr(13) & Chr(10)
            '    End If
            'End While
            'f.Close()
            'f = Nothing
            configPath = f.ReadLine()
            fileAndre = f.ReadLine()
            fileAndrei = f.ReadLine()
            fileDuarte = f.ReadLine()
            fileFabricio = f.ReadLine()
            fileFilipe = f.ReadLine()
            fileFrancisco = f.ReadLine()
            fileJoao = f.ReadLine()
            fileLeonardo = f.ReadLine()
            fileRicardo = f.ReadLine()
            fileTomas = f.ReadLine()
            f.Close()
            f = Nothing

            txtPastaComum.Text = configPath
            txtFileAndre.Text = fileAndre
            txtFileAndrei.Text = fileAndrei
            txtFileDuarte.Text = fileDuarte
            txtFileFabricio.Text = fileFabricio
            txtFileFilipe.Text = fileFilipe
            txtFileFrancisco.Text = fileFrancisco
            txtFileJoao.Text = fileJoao
            txtFileLeandro.Text = fileLeonardo
            txtFileRicardo.Text = fileRicardo
            txtFileTomas.Text = fileTomas


        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim aux As String

        Dim configFile As String = ""
        configFile = Application.StartupPath + "config.txt"


        Try

            Dim f As TextWriter = New StreamWriter(configFile)
            aux = txtPastaComum.Text.Trim() + Chr(13) & Chr(10)
            aux = aux + txtFileAndre.Text.Trim() + Chr(13) & Chr(10)
            aux = aux + txtFileAndrei.Text.Trim() + Chr(13) & Chr(10)
            aux = aux + txtFileDuarte.Text.Trim() + Chr(13) & Chr(10)
            aux = aux + txtFileFabricio.Text.Trim() + Chr(13) & Chr(10)
            aux = aux + txtFileFilipe.Text.Trim() + Chr(13) & Chr(10)
            aux = aux + txtFileFrancisco.Text.Trim() + Chr(13) & Chr(10)
            aux = aux + txtFileJoao.Text.Trim() + Chr(13) & Chr(10)
            aux = aux + txtFileLeandro.Text.Trim() + Chr(13) & Chr(10)
            aux = aux + txtFileRicardo.Text.Trim() + Chr(13) & Chr(10)
            aux = aux + txtFileTomas.Text.Trim() + Chr(13) & Chr(10)

            f.WriteLine(aux)
            f.Flush()
            f.Close()
            f = Nothing

        Catch ex As IOException
            MsgBox(ex.ToString)

        End Try

    End Sub
End Class