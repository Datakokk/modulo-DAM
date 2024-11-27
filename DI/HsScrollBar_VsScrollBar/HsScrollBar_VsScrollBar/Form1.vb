Public Class Form1


    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        PictureBox1.Size = New Size(VScrollBar1.Value, 70)
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        PictureBox1.Size = New Size(HScrollBar1.Value, 127)
    End Sub
End Class
