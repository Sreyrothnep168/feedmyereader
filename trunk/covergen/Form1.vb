Imports System.IO

Public Class Form1

    Dim Args() As String = Environment.GetCommandLineArgs()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Args.Length <> 8 Then
            MessageBox.Show("Command format is: covergen.exe ""InputFile"" ""OutputFile"" ""Text"" ""X"" ""Y"" ""Font"" ""FontSize""")
            Close()
            Exit Sub
        End If

        Dim Input As String = Args(1)
        Dim Output As String = Args(2)
        Dim Text As String = Args(3)
        Dim X As String = Args(4)
        Dim Y As String = Args(5)
        Dim Font As String = Args(6)
        Dim FontSize As String = Args(7)

        If System.IO.File.Exists(Input) = False Then
            MsgBox(Input & " not found.")
            Exit Sub
        End If

        DrawText(Input, Output, Text, X, Y, New System.Drawing.Font(Font, FontSize)).Dispose()
        End
    End Sub

    Private Function DrawText(ByVal Input As System.String, ByVal Output As System.String, ByVal Text As System.String, ByVal X As System.Single, ByVal Y As System.Single, ByVal Font As System.Drawing.Font) As System.Drawing.Image
        Dim Image As System.Drawing.Image = System.Drawing.Image.FromFile(Input)
        Dim Graphics As System.Drawing.Graphics = Graphics.FromImage(Image)
        Graphics.DrawString(Text, Font, Brushes.Black, X, Y)
        Graphics.Dispose()
        Image.Save(Output, Imaging.ImageFormat.Jpeg)
        Return Image
    End Function

End Class
