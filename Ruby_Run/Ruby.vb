Public Class RubyAccount
    Public idAccount, Firstname, LastName, address, city, state, zip, email, phone As String
    Public AllPicks As New List(Of Pick)
    Public ThisWeeksPicks As New List(Of Pick)


    Public Sub getUser(ByVal email As String)
        Dim gl As New JDLL.Main
        Dim qry = "select * from zenbear_Ruby.Account where email='" & email & "'"

        Dim ds As DataSet = gl.MySql_run(qry, "connstr")

        For Each a As DataRow In ds.Tables(0).Rows
            idAccount = a.Item(0)
            Firstname = a.Item(1)
            LastName = a.Item(2)
            address = a.Item(3)
            city = a.Item(4)
            state = a.Item(5)
            zip = a.Item(6)
            email = a.Item(7)
            phone = a.Item(8)
        Next

        qry = "select * from zenbear_Ruby.Picks where idAccount = '" & idAccount & "'"

        ds = gl.MySql_run(qry, "connstr")

        For Each a As DataRow In ds.Tables(0).Rows
            Dim p As New Pick
            p.PickID = a.Item(0)
            p.idAccount = a.Item(1)
            p.GameID = a.Item(2)
            p.Pick = a.Item(3)
            p.SelectDT = a.Item(4)
            p.UpdateDT = a.Item(5)
            AllPicks.Add(p)

        Next

        qry = "SELECT *,DATE(NOW()) FROM zenbear_Ruby.NFLWeekSchedule where DATE(NOW()) >= DATE(startdate) and DATE(NOW()) <= DATE(enddate);"
        ds = gl.MySql_run(qry, "connstr")
        Dim wknumber = 0
        For Each a As DataRow In ds.Tables(0).Rows
            wknumber = a.Item(4)
        Next

        qry = "select * from zenbear_Ruby.Games a
left join(select * from zenbear_Ruby.Picks where idAccount=" & idAccount & ") as b on b.gameid=a.gameid
where a.AwayTeam <> '*BYE WEEK*' and a.week=" & wknumber & " and b.pickid is not null"


        ds = gl.MySql_run(qry, "connstr")

        For Each a As DataRow In ds.Tables(0).Rows
            Dim p As New Pick
            p.PickID = a.Item(8)
            p.idAccount = a.Item(9)
            p.GameID = a.Item(10)
            p.Pick = a.Item(11)
            p.SelectDT = a.Item(12)
            p.UpdateDT = a.Item(13)
            ThisWeeksPicks.Add(p)

        Next


    End Sub








End Class
Public Class Games
    Public GameID, Sport, Year, HomeTeam, Week, HowAway, AwayTeam, Winner As String
End Class
Public Class Pick
    Public PickID, idAccount, GameID, Pick, SelectDT, UpdateDT As String
End Class
Public Class Reward
    Public idReward, idAccount, Datetime, ItemRewarded, Comment As String
End Class



