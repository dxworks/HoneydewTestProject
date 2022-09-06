Imports HoneydewTestProjectVB.A

    Public Class ReferencesOnlyAUsingInsideOfNamespaceRedundantQualifier
        Public Sub Method(ByVal c1Params As A.C1)
            Dim x = c1Params.X
        End Sub
    End Class
