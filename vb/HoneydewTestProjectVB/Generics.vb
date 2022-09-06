Imports HoneydewTestProjectVB.A

Friend Class Generics
    Public Sub Method(ByVal c1Params As List(Of C1))
        Dim x = c1Params.Single().X
    End Sub
End Class