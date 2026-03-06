Public Class Form1
    Private Sub Load_Control(ctrl As UserControl)
        Panel_Control.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        Panel_Control.Controls.Add(ctrl)

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
