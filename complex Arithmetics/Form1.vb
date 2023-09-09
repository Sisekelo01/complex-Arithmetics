Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click
        Dim Price As Decimal
        Dim quantity As Integer
        Dim discount As Integer
        Dim vat As Decimal
        Dim Total As Decimal

        Price = 10
        quantity = 10
        discount = 2
        vat = 0.15
        Total = (Price - discount) * quantity

        MsgBox("the total cost before vat is " & "R" & Total)













    End Sub
End Class
