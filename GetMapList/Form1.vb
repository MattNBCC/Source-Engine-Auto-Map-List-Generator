Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Windows.Forms


Public Class Form1

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If MessageBox.Show("Would you like to browse in current dictionary for maps?", "Map Location", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            txtBrowse.Text = Directory.GetCurrentDirectory()
            Try
                If txtBrowse.Text = "" Then
                    MsgBox("Invalid Path.")
                Else
                    Dim directory = txtBrowse.Text
                    Dim files() As System.IO.FileInfo
                    Dim dirinfo As New System.IO.DirectoryInfo(directory)
                    files = dirinfo.GetFiles("*.bsp", IO.SearchOption.AllDirectories)
                    For Each file In files
                        txtPopulate.Text &= file.ToString & Environment.NewLine
                        'TextBox2.Text.Items.Add(file)
                    Next
                End If
                Dim text = txtPopulate.Text.Replace(".bsp".ToString(), String.Empty)
                txtPopulate.Text = text
            Catch ex As Exception
                MsgBox("An unknown error has occurred!", MsgBoxStyle.Critical)
            End Try
        Else
            FolderBrowserDialog1.ShowDialog()
            txtBrowse.Text = FolderBrowserDialog1.SelectedPath
            Try
                If txtBrowse.Text = "" Then
                    MsgBox("You must select a path.")
                Else
                    txtBrowse.Text = FolderBrowserDialog1.SelectedPath
                    Dim directory = FolderBrowserDialog1.SelectedPath
                    Dim files() As System.IO.FileInfo
                    Dim dirinfo As New System.IO.DirectoryInfo(directory)
                    files = dirinfo.GetFiles("*.bsp", IO.SearchOption.AllDirectories)
                    For Each file In files
                        txtPopulate.Text &= file.ToString & Environment.NewLine
                        'TextBox2.Text.Items.Add(file)
                    Next
                End If
                Dim text = txtPopulate.Text.Replace(".bsp".ToString(), String.Empty)
                txtPopulate.Text = text
            Catch ex As Exception
                MsgBox("An unknown error has occurred!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If MessageBox.Show("Would you like to export to current program dictionary?", "Export Location!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            txtSave.Text = Directory.GetCurrentDirectory()
            Try
                If txtSave.Text = "" Then
                    MsgBox("Invalid Path.")
                Else
                    If lbTypes.SelectedIndex < 0 Then
                        MsgBox("Please select a map cycle type!", MsgBoxStyle.Critical)
                    Else
                        'Converting List box selected item to sting so that
                        ' lb item = mapcycle.txt then slectecpath & "/" mapcycle.txt etc
                        TextBox1.Text = lbTypes.SelectedIndices.ToString

                        Dim mapFile As String = lbTypes.SelectedItem.ToString()
                        Dim objwriter As New System.IO.StreamWriter(txtSave.Text & "\" & mapFile)
                        'filename txt1
                        'body txt2
                        objwriter.Write(txtPopulate.Text)
                        objwriter.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox("An unknown error has occurred!", MsgBoxStyle.Critical)
            End Try
        Else
            fbdSaveLoc.ShowDialog()
            txtSave.Text = fbdSaveLoc.SelectedPath
            Try
                If txtSave.Text = "" Then
                    MsgBox("You must select a save path.")
                Else
                    'I'm fucking lazy so...
                    If lbTypes.SelectedIndex < 0 Then
                        MsgBox("Please select a map cycle type!", MsgBoxStyle.Critical)
                    Else
                        'Converting List box selected item to sting so that
                        ' lb item = mapcycle.txt then slectecpath & "/" mapcycle.txt etc
                        Dim mapFile As String = lbTypes.SelectedItem.ToString()
                        Dim objwriter As New System.IO.StreamWriter(txtSave.Text & "\" & mapFile)
                        'filename txt1
                        'body txt2
                        objwriter.Write(txtPopulate.Text)
                        objwriter.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox("An unknown error has occurred!", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub btnCustomAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomAdd.Click
        Dim newItemCycle As String
        newItemCycle = InputBox("Please enter a custom adding value", "Map List Custom File")
        lbTypes.Items.Add(newItemCycle)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
