Public Class VnVChar

    Public Property Name As String
    Public Property Race As Races
    Public Property Trait1 As Integer
    Public Property Trait2 As Integer
    Public Property BirthSign As Birthsigns
    Public Property BirthSignBoon As String

    Public Property Smarts As Integer
    Public Property Brawn As Integer
    Public Property Moxie As Integer
    Public Property Hotness As Integer
    Public Property Life As Integer

    Public Property AdvSupplies As String
    Public Property Magic As Integer
    Public Property Spells As String
    Public Property Armor As String
    Public Property Weapon As String


    Public Enum Races
        Gobbo = 1
        Dragonkin = 2
        Elf = 3
        Human = 4
        Orc = 5
        Dwarf = 6
        Centaur = 7
        Satyr = 8
        Dweller = 9
        Relmer = 10
        Alloyan = 11
        Otherling = 12
    End Enum

    Public Enum Birthsigns
        Randi = 1
        Dudi = 2
        Triqi = 3
        Forai = 4
        Eidli = 5
        Saisi = 6
    End Enum

    Public Shared Function RollANewOne() As VnVChar
        RollANewOne = New VnVChar

        With RollANewOne
            .Brawn = GetRandom(1, 6)
            .Moxie = GetRandom(1, 6)
            .Smarts = GetRandom(1, 6)
            .Hotness = GetRandom(1, 6)

            .Race = GetRandom(1, 12)
            .Trait1 = GetRandom(1, 20)
            .Trait2 = GetRandom(1, 20)

            .AdvSupplies = "4 days food and water\n"
            .AdvSupplies = String.Concat(.AdvSupplies, (GetRandom(1, 10) * 10), " jade\n")

            For i = 1 To 6
                .AdvSupplies = String.Concat(.AdvSupplies, GetAdvSupply(), "\n")
            Next

            .BirthSign = GetRandom(1, 6)
            .BirthSignBoon = GetBirthSignBoon()

            .Life = 5 + GetRandom(1, 6) + .Moxie

        End With

    End Function
    Public Shared Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max + 1)
    End Function

    Friend Shared Function GetAdvSupply() As String
        Dim a As Integer = GetRandom(1, 100)

        Select Case (a)
            Case 1
                Return "A sapiavian feather"
            Case 2
                Return "30 ft of good rope"
            Case 3
                Return "A dusty bottle of rum"
            Case 4
                Return "The pelt of a Coxox"
            Case 5
                Return "A quill and ink"
            Case 6
                Return "A jar of Slugraptor slime"
            Case 7
                Return "A wyrmswurm bagpipe guitar"
            Case 8
                Return "A rusty Bullbear Trap"
            Case 9
                Return "A large tin of chopplate chip cookies"
            Case 10
                Return "Rumpled love letters"
            Case Else
                Return "Hopes and dreams"
        End Select

    End Function

    Friend Shared Function GetBirthSignBoon() As String
        GetBirthSignBoon = "Boons:\n"
        Const orbit As String = " - or -"

        Select Case BirthSign
            Case Birthsigns.Randi
                GetBirthSignBoon += "Sex is always considered Great or better.\n"
                GetBirthSignBoon += orbit
                GetBirthSignBoon += "You can roll for a Light Magic spell\n"
            Case Birthsigns.Dudi
                GetBirthSignBoon += "You are immune to poison"
                GetBirthSignBoon += orbit
                GetBirthSignBoon += "You can roll for a Death Magic spell"
            Case Birthsigns.Triqi
                GetBirthSignBoon += "You have +1 Exertion uses"
                GetBirthSignBoon += orbit
                GetBirthSignBoon += "You have a permanent +1 to Moxie"
                Moxie += 1
            Case Birthsigns.Forai
                GetBirthSignBoon += "+3 Life every level up"
                GetBirthSignBoon += orbit
                GetBirthSignBoon += "You have a permanent +1 to Brawn"
                Brawn += 1
            Case Birthsigns.Eidli
                GetBirthSignBoon += "You can roll for a Death Magic spell"
                GetBirthSignBoon += orbit
                GetBirthSignBoon += "You can roll for a Light Magic spell"
            Case Birthsigns.Saisi
                GetBirthSignBoon += "You can roll for two Light Magic spells"
                GetBirthSignBoon += orbit
                GetBirthSignBoon += "You have a permanent +2 to Hotness"
                Hotness += 2
            Case Else
                GetBirthSignBoon += ""
        End Select
    End Function

    Public Overrides Function ToString() As String
        ToString = ""

        ToString = String.Concat(ToString, Name, "\n")

    End Function
End Class
