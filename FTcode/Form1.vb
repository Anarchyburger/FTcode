

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim lookUp As Integer
        Dim lookUp2 As Integer
        Dim techCode() As Long = {8711, 7721, 6731, 5741, 4751, 3761, 2771, 1781, 0791, 9602, 8612, 7622, 6632, 5642, 4652, 3662,
            2672, 1682, 0692, 9503, 8513, 7523, 6533, 5543, 4553, 3563, 2573, 1583, 0593, 9404, 8414, 7424, 6434, 5444, 4454, 3464, 2474, 1484, 0494, 9305,
            8315, 7325, 6335, 5345, 4355, 3365, 2375, 1385, 0395, 9206, 8216, 7226, 6236, 5246, 4256}

        Dim thisday As String = Microsoft.VisualBasic.DateAndTime.Day(Now)
        Dim thisHour As String = Microsoft.VisualBasic.DateAndTime.Hour(Now)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'Label1.Visible = True
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        Button1.Visible = False


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'Label1.Visible = False
        Label1.Text = "000000"
        ComboBox1.Visible = True
        ComboBox2.Visible = True
        ComboBox3.Visible = True
        Button1.Visible = True

    End Sub
End Class
