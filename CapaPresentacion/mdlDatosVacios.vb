
Module mdlDatosVacios

    Public Function isEmptyCadena(valor As String) As Boolean
        If Not String.IsNullOrWhiteSpace(valor) Then
            Return True
        Else
            Return False
        End If
    End Function


End Module
