Public Class Form1
    Private Sub Load_Control(ctrl As UserControl)
        Panel_Control.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        Panel_Control.Controls.Add(ctrl)

    End Sub
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

    Private Sub Panel_Cart_click(sender As Object, e As EventArgs) Handles Panel_Cart.Click
        MessageBox.Show("Clicked")
        Load_Control(New UserControlCart)
    End Sub

    Private Sub Panel_Profile_click(sender As Object, e As EventArgs) Handles Panel_Profile.Click
        MessageBox.Show("Clicked")
        Load_Control(New UserControlProfile)


    End Sub

    Private Sub Panel_Voucher_click(sender As Object, e As EventArgs) Handles Panel_Voucher.Click
        MessageBox.Show("Clicked")
        Load_Control(New UserControlVoucher)
    End Sub
End Class
