Imports System
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class Main
    Private TripleDes As New TripleDESCryptoServiceProvider
    Public Function EncryptData(ByRef plaintext As String) As String

        Dim passPhrase As String = "yourPassPhrase"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "MD5"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plaintext)


        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New RijndaelManaged()

        symmetricKey.Mode = CipherMode.CBC

        Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

        Dim memoryStream As New MemoryStream()
        Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        cryptoStream.FlushFinalBlock()
        Dim cipherTextBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
        Return cipherText
    End Function
    Public Function DecryptData(ByRef encryptedtext As String) As String
        Dim passPhrase As String = "yourPassPhrase"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "MD5"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256
        ' Convert strings defining encryption key characteristics into byte
        ' arrays. Let us assume that strings only contain ASCII codes.
        ' If strings include Unicode characters, use Unicode, UTF7, or UTF8
        ' encoding.
        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        ' Convert our ciphertext into a byte array.
        Dim cipherTextBytes As Byte() = Convert.FromBase64String(encryptedtext)

        ' First, we must create a password, from which the key will be 
        ' derived. This password will be generated from the specified 
        ' passphrase and salt value. The password will be created using
        ' the specified hash algorithm. Password creation can be done in
        ' several iterations.
        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        ' Use the password to generate pseudo-random bytes for the encryption
        ' key. Specify the size of the key in bytes (instead of bits).
        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)

        ' Create uninitialized Rijndael encryption object.
        Dim symmetricKey As New RijndaelManaged()

        ' It is reasonable to set encryption mode to Cipher Block Chaining
        ' (CBC). Use default options for other symmetric key parameters.
        symmetricKey.Mode = CipherMode.CBC

        ' Generate decryptor from the existing key bytes and initialization 
        ' vector. Key size will be defined based on the number of the key 
        ' bytes.
        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

        ' Define memory stream which will be used to hold encrypted data.
        Dim memoryStream As New MemoryStream(cipherTextBytes)

        ' Define cryptographic stream (always use Read mode for encryption).
        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)

        ' Since at this point we don't know what the size of decrypted data
        ' will be, allocate the buffer long enough to hold ciphertext;
        ' plaintext is never longer than ciphertext.
        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}

        ' Start decrypting.
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)

        ' Close both streams.
        memoryStream.Close()
        cryptoStream.Close()

        ' Convert decrypted data into a string. 
        ' Let us assume that the original plaintext string was UTF8-encoded.
        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)

        ' Return decrypted string.   
        Return plainText
    End Function
    Private Sub BtnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEnd.Click
        End
    End Sub

    Private Sub BtnClsConsole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClsConsole.Click
        ListConsole.Items.Clear()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Listemail.Items.Clear()
        ListPass.Items.Clear()
        Dim path As String
        path = Application.StartupPath() & "\data\email.txt"
        My.Computer.FileSystem.DeleteFile(path)
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If Textemail.Text <> "" And TextPass.Text <> "" Then
            Listemail.Items.Add(EncryptData(Textemail.Text & Typeemail.Text))
            ListPass.Items.Add(EncryptData(TextPass.Text))
            Dim Path As String
            'this area create log to password and email
            ' first email
            Path = Application.StartupPath() & "\data\email.txt"
            Using sw As StreamWriter = File.CreateText(Path)
                For Item = 0 To (Listemail.Items.Count) - 1
                    Listemail.SetSelected(Item, True)
                    sw.WriteLine(Listemail.SelectedItem())
                Next
                sw.Close()
            End Using
            ' Sceond Pass
            Path = Application.StartupPath() & "\data\pass.txt"
            Using sw As StreamWriter = File.CreateText(Path)
                For Item = 0 To (Listemail.Items.Count) - 1
                    ListPass.SetSelected(Item, True)
                    sw.WriteLine(ListPass.SelectedItem())
                Next
                sw.Close()
            End Using
        Else
            MsgBox("Write an email and password to add :)", MsgBoxStyle.Information, "Facebook Reporter 1.0")
        End If

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Facebook.Navigate("file:///C:/Users/mktad/Downloads/m.html")
        ' Insert Type e-mail
        Typeemail.Items.Add("@gmail.com")
        Typeemail.Items.Add("@mail.ru")
        Typeemail.Items.Add("@hotmail.com")
        Typeemail.Items.Add("@outlook.ru")
        ' Insert Type Speed Net
        SpeedNet.Items.Add("Hight")
        SpeedNet.Items.Add("Middle")
        SpeedNet.Items.Add("Low")
        ' Loading Lists Password and List e-mails

        Dim StringReader, Path As String
        Path = Application.StartupPath() & "\data\email.txt"
        If My.Computer.FileSystem.FileExists(Path) Then
            ' First Email
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(Path)
            For L = 0 To File.ReadAllLines(Path).Length
                Using sr As New System.IO.StreamReader(Path)
                    StringReader = fileReader.ReadLine()
                    Listemail.Items.Add(StringReader)
                    If L = (File.ReadAllLines(Path).Length) - 1 Then
                        fileReader.Close()
                        Exit For
                    End If
                End Using
            Next
            Path = Application.StartupPath() & "\data\pass.txt"
            ' Decond Pas
            fileReader = My.Computer.FileSystem.OpenTextFileReader(Path)
            For L = 0 To 1
                Using sr As New System.IO.StreamReader(Path)
                    StringReader = fileReader.ReadLine()
                    ListPass.Items.Add(StringReader)
                    If L = (File.ReadAllLines(Path).Length) - 1 Then
                        fileReader.Close()
                        Exit For
                    End If
                End Using
            Next
        Else
            Tolding("THERE Is No Any Passswords And E-mails In My DATA")
        End If

    End Sub

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        If TextID.Text <> "" Then
            Facebook.Navigate("https:\\m.facebook.com\")
            Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
            Tolding("GOTO : m.facebook.com ....[ Done ]")
            For L = 0 To (Listemail.Items.Count) - 1
                Dim sUser, sPass As String
                Listemail.SetSelected(L, True)
                sUser = DecryptData(Listemail.SelectedItem())
                Tolding("SET : e-mail AS " & sUser & "....[ Done ]")
                ListPass.SetSelected(L, True)
                sPass = DecryptData(ListPass.SelectedItem())
                Tolding("SET : Pass AS " & sPass & "....[ Done ]")
                LoginFacebook(sUser, sPass)

                Facebook.Navigate("https://m.facebook.com/mbasic/more/?owner_id=" & TextID.Text)
                Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
                Tolding("GOTO : m.facebook.com/profile.php?id=" & TextID.Text & "....[ Done ]")
                For ReportSelected = 0 To (Facebook.Document.GetElementsByTagName("a").Count) - 1
                    If Facebook.Document.GetElementsByTagName("a")(ReportSelected).InnerText = "Report this Profile" Then
                        Facebook.Document.GetElementsByTagName("a")(ReportSelected).InvokeMember("click")
                        Tolding("[ Done ] : Report this Profile [1]")
                        Exit For
                    End If
                Next
                Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
                Tolding(" ..... Start Watting ..... ")
                Waitting()
                Tolding("GOTO : Report this Profile [2]....[ Done ]")
                For ReportSelectedInner = 0 To (Facebook.Document.GetElementsByTagName("div").Count) - 1
                    Dim Check As String
                    Check = Facebook.Document.GetElementsByTagName("div")(ReportSelectedInner).InnerText
                    If Check = "Report this profile" Then
                        Facebook.Document.GetElementsByTagName("div")(ReportSelectedInner).InvokeMember("click")
                        Facebook.Document.GetElementsByTagName("div")(ReportSelectedInner).Parent().InvokeMember("click")
                        Tolding("[ Done ] : Report this Profile [2]")
                        Exit For
                    End If
                Next
                FacebookContinue("Continue")
                Tolding(" ..... Start Watting ..... ")
                Waitting()
                Tolding("GOTO : This is a fake account [3]....[ Done ]")
                For ReportSelectedInner = 0 To (Facebook.Document.GetElementsByTagName("div").Count) - 1
                    Dim Check As String
                    Check = Facebook.Document.GetElementsByTagName("div")(ReportSelectedInner).InnerText
                    If Check = "This is a fake account" Then
                        Facebook.Document.GetElementsByTagName("div")(ReportSelectedInner).InvokeMember("click")
                        Facebook.Document.GetElementsByTagName("div")(ReportSelectedInner).Parent().InvokeMember("click")
                        Tolding("GOTO : This is a fake account ....[ Done ]")
                        Exit For
                    End If
                Next
                FacebookContinue("Continue")
                Tolding(" ..... Start Watting ..... ")
                Waitting()
                Tolding("GOTO : Submit to Facebook for Review [4]....[ Done ]")
                For ReportSelectedInner = 0 To (Facebook.Document.GetElementsByTagName("span").Count) - 1
                    Dim Check As String
                    Check = Facebook.Document.GetElementsByTagName("span")(ReportSelectedInner).InnerText
                    If Check = "Submit to Facebook for Review" Then
                        Facebook.Document.GetElementsByTagName("span")(ReportSelectedInner).InvokeMember("click")
                        Facebook.Document.GetElementsByTagName("span")(ReportSelectedInner).Parent().InvokeMember("click")
                        Tolding("GOTO : Submit to Facebook for Review ....[ Done ]")
                        Exit For
                    End If
                Next
                FacebookContinue("Submit")
                Tolding(" ..... Start Watting ..... ")
                Waitting()
                ' Logout
                Facebook.Navigate("https://m.facebook.com/menu/bookmarks/?ref_component=mbasic_home_header&ref_page=%2Fwap%2Fhome.php&refid=8")
                Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
                Tolding("GOTO : Return Home and Logouting ....[ Done ]")
                Facebook.Document.GetElementById("mbasic_logout_button").InvokeMember("click")
                Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
                Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
                For ReportSelected = 0 To (Facebook.Document.GetElementsByTagName("a").Count) - 1
                    If Facebook.Document.GetElementsByTagName("a")(ReportSelected).GetAttribute("href").IndexOf("/login/device-based") > 0 Then
                        Facebook.Document.GetElementsByTagName("a")(ReportSelected).InvokeMember("click")
                        Facebook.Document.GetElementsByTagName("a")(ReportSelected).Parent().InvokeMember("click")
                    End If
                Next
                Tolding("GOTO : Remove account from device")
                Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
                Tolding(" ...... Watting ...... ")
                Waitting()
                For ReportSelected = 0 To (Facebook.Document.GetElementsByTagName("input").Count) - 1
                    MsgBox(Facebook.Document.GetElementsByTagName("input")(ReportSelected).GetAttribute("value"))
                    If Facebook.Document.GetElementsByTagName("input")(ReportSelected).GetAttribute("value") = "Remove account from device" Then
                        Facebook.Document.GetElementsByTagName("input")(ReportSelected).InvokeMember("click")
                        Facebook.Document.GetElementsByTagName("input")(ReportSelected).Parent().InvokeMember("click")
                    End If
                Next
                Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
            Next
        Else
            ListConsole.Items.Clear()
            Beep()
            Tolding("[ERR] There is not ID Victim OR Your insert ID is wrong")
        End If
    End Sub
    Public Function LoginFacebook(ByRef sUser, ByRef sPass) As Boolean
        Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
        Tolding(" ..... Start Watting ..... ")
        Waitting()
        Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
        Facebook.Document.GetElementById("email").InnerText = sUser
        Facebook.Document.GetElementById("pass").InnerText = sPass
        Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
        Facebook.Document.GetElementById("login").InvokeMember("click")
        Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
        Tolding(" ..... Start Watting ..... ")
        Waitting()
    End Function

    Public Function Waitting() As String
        Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
        Dim SpeedLimit As Integer
        If SpeedNet.Text = "Hight" Then
            SpeedLimit = 7
        ElseIf SpeedNet.Text = "Middle" Then
            SpeedLimit = 8
        Else
            SpeedLimit = 9
        End If
        For Loo = 0 To (10 ^ SpeedLimit)
            Application.DoEvents()
        Next
        ListConsole.Items.Add("Waitting ......... [ Done ] ")
    End Function
    Public Function FacebookContinue(ByRef Value As String)
        For ContinueReport = 0 To (Facebook.Document.GetElementsByTagName("input").Count) - 1
            If Facebook.Document.GetElementsByTagName("input")(ContinueReport).GetAttribute("value") = Value Then
                Facebook.Document.GetElementsByTagName("input")(ContinueReport).InvokeMember("click")
            End If
        Next
        Do While Facebook.ReadyState <> WebBrowserReadyState.Complete Or Facebook.IsBusy : Application.DoEvents() : Loop
    End Function
    Public Function Tolding(ByRef text As String)
        ListConsole.Items.Add(text)
    End Function
    Private Sub BtnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAbout.Click
        About.Show()
    End Sub
End Class
