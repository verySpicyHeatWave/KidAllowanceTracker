Public Class PasswordForm

    Property AccessGranted As Boolean

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Icon = My.Resources.Lock

        AccessGranted = False
    End Sub

    Public Sub PasswordEntryBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordEntryBox.KeyPress

        If e.KeyChar <> Chr(13) Then Exit Sub
        If PasswordEntryBox.Text <> AllowanceTracker.stats.Password Then
            MessageBox.Show("Password is incorrect. Please try again.", "Invalid Password")
            Exit Sub
        End If
        AccessGranted = True
        Me.Dispose()

    End Sub
End Class