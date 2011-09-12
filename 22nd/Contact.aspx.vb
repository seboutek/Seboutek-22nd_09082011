Imports NCEmail.Email

Partial Class Contact
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        SendEmail("Robertswoodson@gmail.com", txtemail.Text, "CONTACT US - 22nd", txtemail.Text + "<br><br>" + txtfname.Text + " " + txtlname.Text + "<br><br>" + txtmsg.Text)

    End Sub
End Class
