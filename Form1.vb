Public Class Form1
    Dim animate As Integer


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        animate = 988
        If (animate = Label12.Left) Then
            Label12.Left = -494
        Else
            Label12.Left = Label12.Left + 2
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STUDENT_REGISTERATIONDataSet.STUDENT_DATA' table. You can move, or remove it, as needed.
        Me.STUDENT_DATATableAdapter.Fill(Me.STUDENT_REGISTERATIONDataSet.STUDENT_DATA)

        Me.WindowState = FormWindowState.Normal
        Timer1.Start()


    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pic As New OpenFileDialog
        pic.Filter = "Choose Image(*.jpg;*.png)|*.jpg;*.png"
        If pic.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(pic.FileName)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cls As Control
        For Each cls In Me.Controls
            If TypeOf cls Is TextBox Then
                cls.Text = ""
            End If
        Next
        MaskedTextBox1.Text = ""
        MaskedTextBox2.Text = ""
        MaskedTextBox3.Text = ""
        MaskedTextBox4.Text = ""
        ComboBox1.Text = "Select Gender "
        ComboBox2.Text = "Select Religion"
        ComboBox3.Text = "Select Nationality"
        DateTimePicker1.Text = ""
        DateTimePicker2.Text = ""
        RichTextBox1.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        STUDENTDATABindingSource.EndEdit()
        STUDENT_DATATableAdapter.Update(STUDENT_REGISTERATIONDataSet.STUDENT_DATA)

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
