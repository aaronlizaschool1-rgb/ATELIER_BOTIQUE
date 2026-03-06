Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.AutoScroll = True

        Dim images() As Image = {
            My.Resources.dress1,
            My.Resources.dress2,
            My.Resources.dress3,
            My.Resources.dress4,
            My.Resources.dress5,
            My.Resources.dress6,
            My.Resources.dress7,
            My.Resources.dress8,
            My.Resources.dress9
        }

        For Each img As Image In images
            Dim pb As New PictureBox
            pb.Width = 120
            pb.Height = 120
            pb.SizeMode = PictureBoxSizeMode.Zoom
            pb.Image = img

            FlowLayoutPanel1.Controls.Add(pb)
        Next
    End Sub
End Class
