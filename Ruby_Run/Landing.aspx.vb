Public Class Landing
    Inherits System.Web.UI.Page
    Dim gl As New JDLL.Main
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim qry = "SELECT *,DATE(NOW()) FROM zenbear_Ruby.NFLWeekSchedule where DATE(NOW()) >= DATE(startdate) and DATE(NOW()) <= DATE(enddate);"
        Dim ds As DataSet = gl.mysql_run(qry, "connstr")
        Dim wknumber = 0
        For Each a As DataRow In ds.Tables(0).Rows
            Label11.Text = a.Item(4) & " (" & a.Item(2) & " - " & a.Item(3) & ")"
            wknumber = a.Item(4)
        Next

        qry = "SELECT * FROM zenbear_Ruby.Games where week ='" & wknumber & "';"

        ds = gl.mysql_run(qry, "connstr")
        GridView2.DataSource = ds
        GridView2.DataBind()


    End Sub

End Class