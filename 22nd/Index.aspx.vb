
Partial Class Index
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim getuser As New Users
        getuser = Account.UserProvider.GetProfilebyUsernamePwd(txtusername.Text, txtpwd.Text)

        If getuser.Username <> Nothing Then
            Session("Username") = txtusername.Text
            'lnklogout.Visible = True
            'lblwelcome.Text = "welcome" + "  " + Session("username") + ""
            'lblwelcome.ForeColor = Drawing.Color.YellowGreen

        End If
    End Sub
End Class
