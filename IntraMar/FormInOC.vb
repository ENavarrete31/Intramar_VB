Imports System.Data
Imports System.Data.OleDb
Public Class FormInOC

    Private Function conectardb(sql As String) As DataSet
        Try
            Dim cn As New OleDbConnection("Provider=SQLNCLI11; Server=192.168.1.202;Database=DT_MDM;UID=sa;PWD=m1r3nt2r$;")
            cn.Open()
            Dim da As New OleDbDataAdapter(sql, cn)

            Dim ds As New DataSet

            da.Fill(ds)

            cn.Dispose()
            cn.Close()

            Return ds
        Catch ex As Exception
            MessageBox.Show("Error Critico no se logro conectar a la base de datos", "t02ALV")
            Return Nothing
        End Try

    End Function
    Private Sub FormInOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmBoxCadena.Items.Add("Chedraui")
        CmBoxCadena.Items.Add("City Fresko")
        CmBoxCadena.Items.Add("HEB")
        CmBoxCadena.Items.Add("Liverpool")
        CmBoxCadena.Items.Add("Palacio de Hierro")
        CmBoxCadena.Items.Add("Soriana")
        CmBoxCadena.Items.Add("Walmart")

        CmBoxCadErr.Items.Add("Chedraui")
        CmBoxCadErr.Items.Add("City Fresko")
        CmBoxCadErr.Items.Add("HEB")
        CmBoxCadErr.Items.Add("Liverpool")
        CmBoxCadErr.Items.Add("Palacio de Hierro")
        CmBoxCadErr.Items.Add("Soriana")
        CmBoxCadErr.Items.Add("Walmart")

        CmBoxCadena.Text = "Chedraui"
        CmBoxCadErr.Text = "Chedraui"
    End Sub

    Private Sub MostrarOCInf()
        Dim ds As New DataSet
        Dim ssql As String
        Dim cad As String

        Select Case CmBoxCadena.SelectedIndex
            Case 0
                cad = "CHE"
            Case 1
                cad = "CIF"
            Case 2
                cad = "HEB"
            Case 3
                cad = "LIV"
            Case 4
                cad = "PHI"
            Case 5
                cad = "SOR"
            Case 6
                cad = "WAL"

        End Select

        ssql = " select * from db_owner.f_logoc ('" + cad + "','" + DTPCorrect.Value.ToString + "','I')"
        ds = conectardb(ssql)

        DataGridView2.DataSource = ds.Tables(0)
    End Sub
    Private Sub MostrarOCErr()
        Dim ds As New DataSet
        Dim ssql As String
        Dim cad As String

        Select Case CmBoxCadErr.SelectedIndex
            Case 0
                cad = "CHE"
            Case 1
                cad = "CIF"
            Case 2
                cad = "HEB"
            Case 3
                cad = "LIV"
            Case 4
                cad = "PHI"
            Case 5
                cad = "SOR"
            Case 6
                cad = "WAL"

        End Select

        ssql = " select * from db_owner.f_logoc ('" + cad + "','" + DTPErr.Value.ToString + "','E')"
        ds = conectardb(ssql)

        DataGridView3.DataSource = ds.Tables(0)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        MostrarOCInf()
    End Sub

    Private Sub BtnBuscErr_Click(sender As Object, e As EventArgs) Handles BtnBuscErr.Click
        DataGridView3.Visible = True
        BtnRpcs.Visible = True
        BtnDelete.Visible = True
        MostrarOCErr()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ssql As String

        If MsgBox("Desea Eliminar el registro", MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes Then

            For Each Fila As DataGridViewRow In DataGridView3.Rows
                If Fila.Cells(0).Value Is Nothing Then
                    Continue For
                Else

                    ssql = "update proc_log set estatus='R' where cadena_origen =  '" + Fila.Cells(1).Value.ToString() + "' and orden_compra = '" + Fila.Cells(2).Value.ToString() + "' and posicion_oc='" + Fila.Cells(3).Value.ToString() + "' "
                    conectardb(ssql)

                End If
            Next
            MostrarOCErr()
        Else
            MostrarOCErr()
        End If


    End Sub


End Class