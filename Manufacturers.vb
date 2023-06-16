Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution

Public Class Manufacturers
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anuradha\Documents\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Manufacturers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()

    End Sub

    Public Sub DisplayItem() '-------------------------------------------DataGridview display
        Con.Open()
        Dim query = "select * from CompanyTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        companyGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Application.Exit()
    End Sub
    Private Sub Clear()
        txtCompanyId.Text = ""
        txtCompanyName.Text = ""
        txtCompTel.Text = ""
        txtComAddress.Text = ""
    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles btnManAdd.Click
        If txtCompanyId.Text = "" Or txtCompanyName.Text = "" Or txtCompTel.Text = "" Or txtComAddress.Text = "" Then
            MsgBox("Missing Information")
        Else

            Try
                Con.Open()
                Dim query As String
                query = "insert into CompanyTbl values(" & txtCompanyId.Text & ",'" & txtCompanyName.Text & "' , '" & txtCompTel.Text & "' , '" & txtComAddress.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Company Successfully Added")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub btnManEdit_Click(sender As Object, e As EventArgs) Handles btnManEdit.Click
        If txtCompanyId.Text = "" Or txtCompanyName.Text = "" Or txtCompTel.Text = "" Or txtComAddress.Text = "" Then
            MsgBox("Missing Information")
        Else

            Try
                Con.Open()
                Dim query As String
                query = "Update CompanyTbl set Company_Name = '" & txtCompanyName.Text & "' , Phone_Number = '" & txtCompTel.Text & "' , Company_Address = '" & txtComAddress.Text & "' where Company_Id= " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Company Data Updated Successfully")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnManDel_Click(sender As Object, e As EventArgs) Handles btnManDel.Click
        If key = 0 Then
            MsgBox("Select Item To Delete")
        Else

            Try
                Con.Open()
                Dim query As String
                query = "delete from CompanyTbl where Company_Id= " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Delete Successfully")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Dim key = 0
    Private Sub ItemDv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles companyGV.CellMouseClick
        Try

            Dim row As DataGridViewRow = companyGV.SelectedRows(0)
            txtCompanyId.Text = row.Cells(0).Value.ToString()
            txtCompanyName.Text = row.Cells(1).Value.ToString()
            txtCompTel.Text = row.Cells(2).Value.ToString()
            txtComAddress.Text = row.Cells(3).Value.ToString()
            If txtCompanyId.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class