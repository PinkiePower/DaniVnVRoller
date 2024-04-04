Public Class VnVChar

    Public Property Name As String
    Public Property Race As Races
    Public Property Trait1 As Integer
    Public Property Trait2 As Integer
    Public Property BirthSign As String

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
End Class
