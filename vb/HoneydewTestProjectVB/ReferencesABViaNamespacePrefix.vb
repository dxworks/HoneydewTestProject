Imports HoneydewTestProjectVB.A

Public Class ReferencesABViaNamespacePrefix
    Public Sub MethodC1A(ByVal c1Params As C1)
        Dim x = c1Params.X
    End Sub

    Public Sub MethodC1B(ByVal c1Params As B.C1)
        Dim x = c1Params.X
    End Sub
End Class
