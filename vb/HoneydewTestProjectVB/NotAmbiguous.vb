Imports HoneydewTestProjectVB.A

Namespace HoneydewTestProjectVB
    Public Class NotAmbiguous
        Private d1Field As D1
        Public Property D1Prop As D1

        Public Sub UsingD1AsLocalVariable()
            Dim localVariable As D1 = New D1()
        End Sub

        Public Sub UsingD1AsLocalVariable2()
            Dim localVariable As D1 = New D1()
        End Sub

        Public Sub UsingD1AsParameter(ByVal param As D1)
            Dim x = param.X
        End Sub
    End Class
End Namespace
