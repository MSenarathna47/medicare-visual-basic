Imports System.Data.SqlClient
Public Class Billing
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anuradha\Documents\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Application.Exit()
    End Sub
    Private Sub FillCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from MedicineTbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        MedCB.DataSource = Tbl
        MedCB.DisplayMember = "Medicine_Name"
        MedCB.ValueMember = "Medicine_Name"
        Con.Close()
    End Sub
    Dim stock, uprice
    Private Sub FetchQty()
        Con.Open()
        Dim query = "select * from MedicineTbl where Medicine_Name = '" & MedCB.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            ' MsgBox("" + reader(0).ToString())
            stock = reader(4)
            uprice = reader(3)
            lblQty.Text = "Available Stock :" + reader(4).ToString()
        End While
        Con.Close()
    End Sub
    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
    End Sub

    Private Sub MedCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MedCB.SelectionChangeCommitted
        FetchQty()
    End Sub
    Dim i = 0, totprice
    Dim subtotal = 0
    Private Sub btnAddbtn_Click(sender As Object, e As EventArgs) Handles btnAddbtn.Click
        If txtQt.Text > stock Then
            MsgBox("Not Enough Quantity in Stock")
        ElseIf txtQt.Text = "" Then
            MsgBox("Enter a quantity")
        Else
            Dim rnum As Integer = BillGV.Rows.Add()
            i = i + 1
            BillGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillGV.Rows.Item(rnum).Cells("Column2").Value = MedCB.SelectedValue.ToString()
            BillGV.Rows.Item(rnum).Cells("Column3").Value = txtQt.Text
            BillGV.Rows.Item(rnum).Cells("Column4").Value = uprice
            BillGV.Rows.Item(rnum).Cells("Column5").Value = txtQt.Text * uprice
            Dim totaladd = txtQt.Text * uprice
            subtotal = subtotal + totaladd
            lblSubtotal.Text = "Total Amount : Rs " + subtotal.ToString()
        End If
    End Sub
End Class