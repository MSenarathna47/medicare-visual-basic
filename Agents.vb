Imports System.Data.SqlClient
Public Class Agents
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anuradha\Documents\PharmacyDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        Dim back = New Home
        back.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Application.Exit()
    End Sub
    Public Sub DisplayItem() '-------------------------------------------DataGridview display
        Con.Open()
        Dim query = "select * from EmployeeTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        EmpGv.DataSource = ds.Tables(0)
        Con.Close()

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles BtnEmployeeAdd.Click
        If TxtEmpid.Text = "" Or TxtEmpname.Text = "" Or TxtEmpAge.Text = "" Or TxtEmpPhone.Text = "" Then
            MsgBox("Missing Information")
        Else

            Try
                Con.Open()
                Dim query As String
                query = "insert into EmployeeTbl values(" & TxtEmpid.Text & ",'" & TxtEmpname.Text & "' ,'" & TxtEmpAge.Text & "' , '" & TxtEmpPhone.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Successfully Added")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Agents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
    End Sub
    Private Sub Clear()
        TxtEmpid.Text = ""
        TxtEmpname.Text = ""
        TxtEmpAge.Text = ""
        TxtEmpPhone.Text = ""

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles BtnEmployeeEdit.Click
        If TxtEmpid.Text = "" Or TxtEmpname.Text = "" Or TxtEmpAge.Text = "" Or TxtEmpPhone.Text = "" Then
            MsgBox("Missing Information")
        Else

            Try
                Con.Open()
                Dim query As String
                query = "Update EmployeeTbl set Employee_Name = '" & TxtEmpname.Text & "' ,  Employee_Age= " & TxtEmpAge.Text & ", Employee_PhoneNumber = " & TxtEmpPhone.Text & " where Employee_Id= " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Data Updated Successfully")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnEmployeeDlt_Click(sender As Object, e As EventArgs) Handles BtnEmployeeDlt.Click
        If key = 0 Then
            MsgBox("Select Item To Delete")
        Else

            Try
                Con.Open()
                Dim query As String
                query = "delete from EmployeeTbl where Employee_Id= " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Delete Successfully")
                Con.Close()
                DisplayItem()
                Clear()
            Catch ex As Exception

            End Try
        End If
    End Sub
    '--------------------------DataView Data Grid & select Row -----------------------------------------------------------

    Dim key = 0
    Private Sub EmpGv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmpGv.CellMouseClick
        Try

            Dim row As DataGridViewRow = EmpGv.SelectedRows(0)
            TxtEmpid.Text = row.Cells(0).Value.ToString()
            TxtEmpname.Text = row.Cells(1).Value.ToString()
            TxtEmpAge.Text = row.Cells(2).Value.ToString()
            TxtEmpPhone.Text = row.Cells(3).Value.ToString()
            If TxtEmpid.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class