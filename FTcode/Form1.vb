

Public Class Form1

    Dim autoCode As Integer
    Dim lookUp1 As Integer
    Dim lookUp2 As Integer
    Dim techCode() As Long = {8711, 7721, 6731, 5741, 4751, 3761, 2771, 1781, 0791, 9602, 8612, 7622, 6632, 5642, 4652, 3662,
            2672, 1682, 0692, 9503, 8513, 7523, 6533, 5543, 4553, 3563, 2573, 1583, 0593, 9404, 8414, 7424, 6434, 5444, 4454, 3464, 2474, 1484, 0494, 9305,
            8315, 7325, 6335, 5345, 4355, 3365, 2375, 1385, 0395, 9206, 8216, 7226, 6236, 5246, 4256}

    Dim thisday As Integer = Microsoft.VisualBasic.DateAndTime.Day(Now)
    Dim thisHour As Integer = Microsoft.VisualBasic.DateAndTime.Hour(Now)

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Visible = True
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        Button1.Visible = False

        lookUp1 = thisday + thisHour
        lookUp2 = lookUp1 - 1
        autoCode = lookUp1 & techCode(lookUp2)

        If lookUp1 < 10 Then
            Label1.Text = "0" & autoCode
        Else
            Label1.Text = autoCode
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Visible = False
        'Label1.Text = "000000"
        ComboBox1.Visible = True
        ComboBox2.Visible = True
        ComboBox3.Visible = True
        Button1.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Text = "Reset" Then
            Button1.Text = "Calculate"
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            ComboBox3.SelectedIndex = -1
            ComboBox1.Text = "AM"
            ComboBox2.Text = "HOUR"
            ComboBox3.Text = "DAY"
            Button1.Enabled = False
            Label1.Text = "000000"

            GoTo enditnow
        End If

        Dim manHour As Integer = ComboBox2.SelectedItem
        Dim manDay As Integer = ComboBox3.SelectedItem
        Dim lookUp3 As Integer
        Dim lookup4 As Integer

        Label1.Visible = True

        If ComboBox1.SelectedItem = "PM" Then manHour = manHour + 12

        lookUp3 = manHour + manDay

        lookup4 = lookUp3 - 1

        If lookUp3 < 10 Then
            Label1.Text = "0" & lookUp3 & techCode(lookup4)
        Else
            Label1.Text = lookUp3 & techCode(lookup4)

        End If

        If Button1.Text = "Calculate" Then Button1.Text = "Reset"

Enditnow:
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        Button1.Visible = False

        lookUp1 = thisday + thisHour
        lookUp2 = lookUp1 - 1
        autoCode = lookUp1 & techCode(lookUp2)

        If lookUp1 < 10 Then
            Label1.Text = "0" & autoCode
        Else
            Label1.Text = autoCode
        End If

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

        If ComboBox2.SelectedIndex >= 0 And ComboBox3.SelectedIndex >= 0 Then Button1.Enabled = True

    End Sub
End Class
