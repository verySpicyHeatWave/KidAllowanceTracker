Public Class GradesForm

    Enum ChildEnum
        Ruby
        Pepper
        Unspecified
    End Enum

    Dim Child As ChildEnum = ChildEnum.Unspecified
    Dim ChildStats As AllowanceTracker.PricesStructure

    Public Sub New(NameString As String)

        ' This call is required by the designer.
        InitializeComponent()

        If NameString.ToLower = "ruby" Then Child = ChildEnum.Ruby
        If NameString.ToLower = "pepper" Then Child = ChildEnum.Pepper

        If Child = ChildEnum.Ruby Then ChildStats = AllowanceTracker.Stats.Ruby
        If Child = ChildEnum.Pepper Then ChildStats = AllowanceTracker.Stats.Pepper
        If Child = ChildEnum.Unspecified Then
            MessageBox.Show("Child undefined. No data was loaded.", "No Child?")
            Me.Dispose()
        End If

        numbx_A.Value = ChildStats.AGrades
        numbx_B.Value = ChildStats.BGrades
        numbx_C.Value = ChildStats.CGrades
        numbx_D.Value = ChildStats.DGrades
        numbx_F.Value = ChildStats.FGrades


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub OkButtonClickEvent() Handles btn_OK.Click

        ChildStats.AGrades = numbx_A.Value
        ChildStats.BGrades = numbx_B.Value
        ChildStats.CGrades = numbx_C.Value
        ChildStats.DGrades = numbx_D.Value
        ChildStats.FGrades = numbx_F.Value
        If Child = ChildEnum.Ruby Then AllowanceTracker.Stats.Ruby = ChildStats
        If Child = ChildEnum.Pepper Then AllowanceTracker.Stats.Pepper = ChildStats
        Me.Close()

    End Sub

    Private Sub CancelButtonClickEvent() Handles btn_Cancel.Click
        Me.Close()
    End Sub


End Class