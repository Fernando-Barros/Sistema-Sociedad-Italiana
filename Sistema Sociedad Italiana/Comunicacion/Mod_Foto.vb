Imports System.IO
Module Mod_Foto

    Function Bytes_foto(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Function Foto_Bite(ByVal Foto As PictureBox) As Byte()
        Dim Mstrean As New System.IO.MemoryStream
        Foto.Image.Save(Mstrean, Foto.Image.RawFormat)
        Return Mstrean.ToArray()
        Mstrean.Close()
    End Function

    'Function Bite_Foto(ByVal Foto As PictureBox) As Byte()
    '    Dim Mstrean As New System.IO.MemoryStream
    '    Foto.Image.Save(Mstrean, Foto.Image.RawFormat)
    '    Return Mstrean.ToArray()
    '    Mstrean.Close()
    'End Function


End Module
