Public Class Landing
    Inherits System.Web.UI.Page
    Dim gl As New JDLL.Main
    Dim Ra As New RubyAccount

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Ra.getUser("eagles757@yahoo.com")

        ' If Not IsCallback And Not IsPostBack Then
        load1()
        'Else
        '    Try
        '        tw1 = Session("TW1")
        '    Catch ex As Exception
        '    End Try
        'End If

        If DateTime.Now.DayOfWeek = DayOfWeek.Tuesday Or DateTime.Now.DayOfWeek = DayOfWeek.Wednesday Or (DateTime.Now.DayOfWeek = DayOfWeek.Thursday And DateTime.Now.Hour < 17) Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
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


        Dim tr As New HtmlTableRow
        Dim td As New HtmlTableCell
        td.InnerText = "Game ID"
        tr.Controls.Add(td)

        td = New HtmlTableCell
        td.InnerText = "Game"
        tr.Controls.Add(td)

        td = New HtmlTableCell
        td.InnerText = "Pick Results"
        tr.Controls.Add(td)

        tw1.Controls.Add(tr)

        For Each a In ds.Tables(0).Rows
            tr = New HtmlTableRow
            td = New HtmlTableCell

            td.InnerText = a.item(0)
            tr.Controls.Add(td)
            td = New HtmlTableCell



            Dim cb As New RadioButtonList
            cb.RepeatDirection = RepeatDirection.Horizontal
            cb.ID = "cb_" & a.item(0)

            Dim add = False

            cb.Items.Add(New ListItem(a.item(3)))
            cb.Items.Add(New ListItem(a.item(6)))
            Dim correctorno As String = ""
            For Each ap As Pick In Ra.ThisWeeksPicks
                If ap.GameID = a.item(0) Then
                    cb.SelectedValue = ap.Pick
                    Try
                        If ap.Pick = a.item(7) Then
                            correctorno = "Y"
                        Else
                            If ap.Pick <> "" Then
                                correctorno = "N"
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If
            Next

            td.Controls.Add(cb)
            tr.Controls.Add(td)
            If correctorno <> "" Then
                td = New HtmlTableCell
                If correctorno = "Y" Then
                    td.InnerHtml = "<span>&#9989;</span> - Correct"
                Else
                    td.InnerHtml = "<span>&#10060;</span> - Wrong"
                End If
                tr.Controls.Add(td)
            End If



            tw1.Controls.Add(tr)
        Next


        'now check to see if user already checked and then check the boxes they picked for that game





        Session("TW1") = tw1


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Session("TW1") = tw1
        For Each a As HtmlTableRow In tw1.Rows
            Dim cb As RadioButtonList = a.FindControl("cb_" & a.Cells(0).InnerText)

            Dim gameid = a.Cells(0).InnerText

            Dim qry = "select * from zenbear_Ruby.Picks where idAccount = " & Ra.idAccount & " and gameid=" & gameid & ""
            Dim found = False
            Dim ds As DataSet = gl.MySql_run(qry, "connstr")
            Try
                For Each aa As DataRow In ds.Tables(0).Rows
                    found = True
                Next
            Catch ex As Exception
            End Try


            If found = True Then
                qry = "update zenbear_Ruby.Picks set pick = '" & cb.SelectedValue & "',updateDT='" & DateTime.Now & "' where idAccount = " & Ra.idAccount & " and gameid=" & gameid & ""
            Else
                qry = "insert into zenbear_Ruby.Picks values (0,'" & Ra.idAccount & "','" & gameid & "','" & cb.SelectedValue & "','" & DateTime.Now & "','" & DateTime.Now & "')"
            End If
            Dim dd As String = gl.mysql_update(qry, "connstr")

            Response.Write("DD: " & dd)

        Next





    End Sub
End Class