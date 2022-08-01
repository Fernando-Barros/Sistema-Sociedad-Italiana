Imports MySql.Data.MySqlClient
Public Class Imprimir_Socio


    Private Sub Listar(ByVal Estado As String)
        Dim Condicion As String
        Try

            If Estado = "todos" Then
                Condicion = " "
            ElseIf Estado = "En_Aprovacion" Then
                Condicion = "where estado_socio='En_Aprovacion'"
            ElseIf Estado = "Activo" Then
                Condicion = "where estado_socio='Activo'"
            ElseIf Estado = "Vitalicio" Then
                Condicion = "where estado_socio='Vitalicio'"
            Else
                Condicion = "where estado_socio='Baja'"
            End If
            'Dim adapter As MySqlDataAdapter
            Dim tabla As New DataTable
            Call conectar()
            conexion.Open()
            Dim adapter As New MySqlDataAdapter("select * from socios " & Condicion & " ;", conexion)
            'Dim Comando As New MySqlCommand("select * from socios ;", conexion)
            'adapter = New MySqlDataAdapter(Comando)
            tabla.Rows.Clear()
            adapter.Fill(tabla)
            'If Not tabla Is Nothing Then
            'DataGridView1.Rows.Clear()
            'DataGridView1.DataSource = ""
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = tabla
            DataGridView1.Columns(0).DataPropertyName = "id_socio"
            DataGridView1.Columns(1).DataPropertyName = "apellido"
            DataGridView1.Columns(2).DataPropertyName = "nombre"
            DataGridView1.Columns(3).DataPropertyName = "estado_socio"
            'End If
            conexion.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Sub


    Private Sub Imprimir_nuevo_Socio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RB_Todos.Checked = True

        If RB_Todos.Checked = True Then
            Call Listar("todos")
        End If

    End Sub

    Private Sub RB_EAprovacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_EAprovacion.CheckedChanged
        Call Listar("En_Aprovacion")
    End Sub

    Private Sub RB_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Todos.CheckedChanged
        Call Listar("todos")
    End Sub

    Private Sub RB_Activo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Activo.CheckedChanged
        Call Listar("Activo")
    End Sub

    Private Sub RB_Vitalicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Vitalicio.CheckedChanged
        Call Listar("Vitalicio")
    End Sub

    Private Sub RB_Baja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Baja.CheckedChanged
        Call Listar("Baja")
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Font As New Font("times new roman", 11, FontStyle.Bold)
        Dim H As Integer = 0
        Dim V As Integer = 0
        Try
            e.Graphics.DrawString("Sociedad Italiana SOCORRO MUTUO", Font, Brushes.Black, H + 270, V + 100)
            H = 5
            V = 5
            e.Graphics.DrawRectangle(Pens.Black, H + 80, V + 145, 100, 30)
            e.Graphics.DrawString("ID Socio", Font, Brushes.Black, H + 100, V + 150)
            e.Graphics.DrawRectangle(Pens.Black, H + 180, V + 145, 200, 30)
            e.Graphics.DrawString("Apellido", Font, Brushes.Black, H + 250, V + 150)
            e.Graphics.DrawRectangle(Pens.Black, H + 380, V + 145, 200, 30)
            e.Graphics.DrawString("Nombre", Font, Brushes.Black, H + 450, V + 150)
            e.Graphics.DrawRectangle(Pens.Black, H + 580, V + 145, 200, 30)
            e.Graphics.DrawString("Estado del Socio", Font, Brushes.Black, H + 600, V + 150)
            Dim P1 As Integer = 185
            If DataGridView1.Rows.Count > 0 Then
                For i As Integer = 0 To DataGridView1.Rows.Count
                    If Not DataGridView1.Rows.Item(i) Is Nothing Then
                        e.Graphics.DrawString(DataGridView1.Rows.Item(i).Cells(0).Value, Font, Brushes.Black, H + 100, V + P1)
                        e.Graphics.DrawString(DataGridView1.Rows.Item(i).Cells(1).Value, Font, Brushes.Black, H + 210, V + P1)
                        e.Graphics.DrawString(DataGridView1.Rows.Item(i).Cells(2).Value, Font, Brushes.Black, H + 400, V + P1)
                        e.Graphics.DrawString(DataGridView1.Rows.Item(i).Cells(3).Value, Font, Brushes.Black, H + 595, V + P1)
                        P1 = P1 + 30
                    End If

                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bot_Imp_Listado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bot_Imp_Listado.Click
        PrintDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.Document = PrintDocument1
        ''tamaño de ventana
        'PrintPreviewDialog1.Width = 600
        'PrintPreviewDialog1.Height = 700
        ''vista previa
        'PrintPreviewDialog1.Show()
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
End Class