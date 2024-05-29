Imports System.Windows.Forms

Public Class frmMain
    Inherits Form

    Private WithEvents btnDisplay As Button
    Private txtInput As TextBox

    Public Sub New()
        Me.Text = "Hello World Program"
        Me.Size = New Size(300, 150)

        txtInput = New TextBox()
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(200, 20)
        txtInput.Location = New Point(50, 20)
        Me.Controls.Add(txtInput)

        btnDisplay = New Button()
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Text = "Display"
        btnDisplay.Size = New Size(80, 30)
        btnDisplay.Location = New Point(100, 60)
        Me.Controls.Add(btnDisplay)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim message As String = txtInput.Text
        MessageBox.Show(message, "Message")
    End Sub

    Public Shared Sub Main()
        Application.Run(New frmMain())
    End Sub

End Class
