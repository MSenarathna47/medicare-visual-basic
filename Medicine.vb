Imports System.Data.SqlClient
Public Class Medicine
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anuradha\Documents\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCombo()
        Displayitem()

    End Sub
    Private Sub FillCombo()
        Con.Open()
        Dim cmd As New SqlCommand("select * from CompanyTbl", Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        CompCb.DataSource = Tbl
        CompCb.DisplayMember = "Company_Name"
        CompCb.ValueMember = "Company_Name"
        Con.Close()
    End Sub
    Private Sub Displayitem()
        Con.Open()
        Dim query = "select * from MedicineTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        MedicineGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Clear()
        txtMedId.Text = ""
        txtMedicineName.Text = ""
        txtBprice.Text = ""
        txtSprice.Text = ""
        txtQty.Text = ""
        dateDate.Text = ""
        CompCb.SelectedIndex = 0

    End Sub
    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub



    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtMedId.Text = "" Or txtMedicineName.Text = "" Or txtBprice.Text = "" Or txtSprice.Text = "" Or txtQty.Text = "" Or dateDate.Text = "" Or CompCb.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "insert into MedicineTbl values(" & txtMedId.Text & ",'" & txtMedicineName.Text & " '," & txtBprice.Text & "," & txtSprice.Text & "," & txtQty.Text & ",'" & dateDate.Text & "','" & CompCb.SelectedValue.ToString() & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("medicine sucessfully added")
                Con.Close()
                Displayitem()
                Clear()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtMedId.Text = "" Or txtMedicineName.Text = "" Or txtBprice.Text = "" Or txtSprice.Text = "" Or txtQty.Text = "" Or dateDate.Text = "" Or CompCb.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else

            Try
                Con.Open()
                Dim query As String
                query = "Update MedicineTbl set Medicine_Name = '" & txtMedicineName.Text & "' , Buying_Price = '" & txtBprice.Text & "' , Selling_Price = '" & txtSprice.Text & "' , Medicine_Quantity = '" & txtQty.Text & "' , Expire_Date = '" & dateDate.Text & "'  , Company_Name = '" & CompCb.SelectedValue.ToString() & "' where Medicine_Id= " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Medicine Data Updated Successfully")
                Con.Close()
                Displayitem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnDlt_Click(sender As Object, e As EventArgs) Handles btnDlt.Click
        If key = 0 Then
            MsgBox("Select Item To Delete")
        Else

            Try
                Con.Open()
                Dim query As String
                query = "delete from MedicineTbl where Medicine_Id= " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Delete Successfully")
                Con.Close()
                Displayitem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Dim key = 0



    Private Sub MedicineGv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MedicineGV.CellMouseClick
        Try

            Dim row As DataGridViewRow = MedicineGV.SelectedRows(0)
            txtMedId.Text = row.Cells(0).Value.ToString()
            txtMedicineName.Text = row.Cells(1).Value.ToString()
            txtBprice.Text = row.Cells(2).Value.ToString()
            txtSprice.Text = row.Cells(3).Value.ToString()
            txtQty.Text = row.Cells(4).Value.ToString()
            dateDate.Text = row.Cells(5).Value.ToString()
            CompCb.SelectedItem = row.Cells(6).Value.ToString()
            If txtMedId.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class