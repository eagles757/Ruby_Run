Public Class RubyAccount
    Public Firstname, LastName, address, city, state, zip, email, phone As String
End Class
Public Class Games
    Public GameID, Sport, Year, HomeTeam, Week, HowAway, AwayTeam As String
End Class
Public Class Picks
    Public PickID, idAccount, GameID, Pick, SelectDT, UpdateDT As String
End Class
Public Class Reward
    Public idReward, idAccount, Datetime, ItemRewarded, Comment As String
End Class



