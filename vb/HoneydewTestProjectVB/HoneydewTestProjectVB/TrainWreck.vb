    Friend Class TrainWreck
        Public Sub Method()
            Dim x = New Wagon4().Method4().Method3().Method2().X
        End Sub
    End Class

    Public Class Wagon2
        Public Function Method2() As Wagon1
            Return New Wagon1()
        End Function
    End Class

    Public Class Wagon3
        Public Function Method3() As Wagon2
            Return New Wagon2()
        End Function
    End Class

    Public Class Wagon4
        Public Function Method4() As Wagon3
            Return New Wagon3()
        End Function
    End Class

    Public Class Wagon1
        Public Property X As Integer
    End Class
