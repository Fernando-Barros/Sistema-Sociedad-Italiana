Imports System.Security.Cryptography
Imports System.Text
Module Cifrado
    Dim ue As New System.Text.UTF8Encoding
    Dim sec As New RSACryptoServiceProvider
    Dim bytString(), bytCifrar(), bytDecifrado() As Byte
    Function Cifrado_clave(ByVal EncritString As String) As String
        Dim strEncriptar As String = ""
        If EncritString <> "" Then
            Try
                bytString = ue.GetBytes(EncritString)
                bytCifrar = sec.Encrypt(bytString, False)
                strEncriptar = Convert.ToBase64String(bytCifrar)
            Catch ex As Exception
                MessageBox.Show("es obligatorio rellenar este CAMPO")
            End Try
        End If
        Return strEncriptar
    End Function

    Function Decifrado_clave(ByVal EncritString As String) As String
        Dim strDesencriptar As String = ""
        If EncritString <> "" Then
            Try
                bytDecifrado = sec.Decrypt(Convert.FromBase64String(EncritString), False)
                strDesencriptar = ue.GetString(bytDecifrado)
            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message)
            End Try
        End If
        Return strDesencriptar
    End Function

    '------------------------HashMD5-------------------------------------
    Function CrearHashMD5(ByVal Input As String) As String

        Dim Dbytes As Byte()
        Dim sb As New StringBuilder()
        Dbytes = Encoding.Default.GetBytes(Input)
        Dbytes = MD5.Create().ComputeHash(Dbytes)
        ' convert byte data to hex string
        For n As Integer = 0 To Dbytes.Length - 1
            sb.Append(Dbytes(n).ToString("X2"))
        Next n
        Return sb.ToString()
    End Function

    '------------------------HashSHA1-------------------------------------
    Function CrearHashSHA1(ByVal Input As String) As String

        Dim Dbytes As Byte()
        Dim sb As New StringBuilder()
        Dbytes = Encoding.Default.GetBytes(Input)
        Dbytes = SHA1.Create().ComputeHash(Dbytes)
        ' convert byte data to hex string
        For n As Integer = 0 To Dbytes.Length - 1
            sb.Append(Dbytes(n).ToString("X2"))
        Next n
        Return sb.ToString()
    End Function
End Module
