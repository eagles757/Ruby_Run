Public Class Landing
    Inherits System.Web.UI.Page
    Dim gl As New JDLL.Main
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.load
        If Not IsCallback And Not IsPostBack Then
            load1()
        Else
            Try
                tw1 = Session("TW1")
            Catch ex As Exception
            End Try
        End If

    End Sub
    Sub load1()
        Dim qry = "SELECT *,DATE(NOW()) FROM zenbear_Ruby.NFLWeekSchedule where DATE(NOW()) >= DATE(startdate) and DATE(NOW()) <= DATE(enddate);"
        Dim ds As DataSet = gl.MySql_run(qry, "connstr")
        Dim wknumber = 0
        For Each a As DataRow In ds.Tables(0).Rows
            Label11.Text = a.Item(4) & " (" & a.Item(2) & " - " & a.Item(3) & ")"
            wknumber = a.Item(4)
        Next

        qry = "SELECT * FROM zenbear_Ruby.Games where week ='" & wknumber & "' and AwayTeam <> '*BYE WEEK*';"

        ds = gl.MySql_run(qry, "connstr")
        'GridView2.DataSource = ds
        'GridView2.DataBind()

        Dim dt As New DataTable
        dt.Columns.Add("GameID")
        dt.Columns.Add("Sport")
        dt.Columns.Add("Year")
        dt.Columns.Add("HomeTeam")
        dt.Columns.Add("Week")
        dt.Columns.Add("HowAway")
        dt.Columns.Add("AwayTeam")


        For Each a In ds.Tables(0).Rows
            Dim tr As New HtmlTableRow
            Dim td As New HtmlTableCell

            Dim cb As New CheckBoxList
            cb.RepeatDirection = RepeatDirection.Horizontal
            cb.ID = "cb_" & a.item(0)

            Dim add = False

            cb.Items.Add(New ListItem(a.item(3)))
            cb.Items.Add(New ListItem(a.item(6)))
            td.Controls.Add(cb)
            tr.Controls.Add(td)
            tw1.Controls.Add(tr)
        Next

        Session("TW1") = tw1


    End Sub

End Class