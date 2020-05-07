Module globales
    Public SQLStr As String

    Public Csr_Account As Integer
    Public MH_Account As Integer
    Public MH_xCE_AccountExt As Integer

    Public bxCE_AccountExtQ As xClasifFlujoE.xClasifFlujoE = New xClasifFlujoE.xClasifFlujoE

    Sub Init_Account(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
        Call SetAddr(x_Level, "bAccount", bAccount, nAccount)
        If x_Cursor = True Then
            Call SqlCursorEx(Csr_Account, x_Level, "Csr_Account", "Account", "")
        End If
    End Sub


    'jsksfjhksdfjsd
    'jasfsjkfsdlkfsk
    'hhhhh
End Module
