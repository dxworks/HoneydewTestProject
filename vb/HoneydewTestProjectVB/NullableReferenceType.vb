Imports HoneydewTestProjectVB.A

    Friend Class NullableStructureType
        Public Sub MethoA(c1Params As SomeStruct?)
            Dim x = c1Params.GetValueOrDefault().X
        End Sub
    End Class