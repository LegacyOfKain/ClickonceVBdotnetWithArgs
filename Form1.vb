Imports System.Security.Policy
Imports System.Web

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Get the ActivationArguments from the SetupInformation property of the domain.
        Dim activationData() As String = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData
        Dim uri As New Uri(activationData.First())
        Dim querystring As String = uri.Query   ' ?setting=layout&value=normal
        LabelQueryString.Text = querystring

        Dim parsed = HttpUtility.ParseQueryString(querystring)

        LabelValuePassed.Text = parsed("valuePassed")
        LabelUrlPassed.Text = parsed("urlPassed")


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
