Imports HoneydewTestProjectVB.A
Imports C1B = HoneydewTestProjectVB.B.C1

    Public Class ReferencesABViaUsingAlias
        Public Sub MethodC1A(ByVal c1Params As C1)
            Dim x = c1Params.X
        End Sub

        Public Sub MethodC1B(ByVal c1Params As C1B)
            Dim x = c1Params.X
        End Sub
    End Class
