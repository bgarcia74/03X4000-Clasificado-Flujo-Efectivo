'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
Option Explicit On
Option Strict Off
Friend Class Form1
	Inherits System.Windows.Forms.Form
	
	Protected m_IsInitializing As Boolean
	Protected ReadOnly Property IsInitializing() As Boolean
		Get
			Return m_IsInitializing
		End Get
	End Property

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        ' Load all the forms needed for this application
        'Call LoadForm(fSL01001)

        ' Initialize the application as a Microsoft Dynamics SL Application
        Call ApplInit()

        Call Init_Account(LEVEL0, True)
        Call Init_xClasifFlujoE(NOLEVEL, False)

        'Insertar aquellas cuentas que no existan en la extendida
        SQLStr = "INSERT INTO xClasifFlujoE (Acct, Crtd_Date, Crtd_Prog, Crtd_User, LUpd_Date, LUpd_Prog, LUpd_User)  "
        SQLStr = SQLStr + " SELECT A.Acct, GETDATE (), 'SQL', " + SParm(bpes.UserId) + ", GETDATE (), 'SQL', " + SParm(bpes.UserId)
        SQLStr = SQLStr + "FROM Account A	LEFT OUTER JOIN xClasifFlujoE B ON A.Acct = B.Acct WHERE B.Acct IS NULL"

        Dim Csr_AcctExt As Integer
        Call SqlCursor(Csr_AcctExt, NOLEVEL + SqlFastReadOnly)
        Call sql(Csr_AcctExt, SQLStr)
        Call SqlFree(Csr_AcctExt)


        ' Call Set Address for the tables that will have fields displayed on the scree,
        ' or that you would like customization manager to be able to use
        'Call SetAddr(LEVEL0, "bxSLSample", bxSLSample, nxSLSample)

        ' Define the cursors that are used by the application

        ' This is an example for a table in the System Database
        'Call SqlCursor(c1, LEVEL0 + SqlSystemDb)

        ' This is an example for a table in an Application Database
        'Call SqlCursor(c1, LEVEL0 )


        ' Call the screen init function
        Call ScreenInit()

        MH_Account = DetailSetup(Csr_Account, SafGrid1, PNULL, bAccount, bxClasifFlujoE, PNULL, PNULL)

        SetButton(TbInsertButton, LEVEL0, False)

        Call SetProps(Me, cL0Descr, cL0Descr, PROP_ENABLED, False)
    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub

    Private Sub Update1_UpdateEvent(Level As Short, InsertFlg As Short, LevelsDone As Short, LevelsLeft As Short, ByRef RetVal As Short) Handles Update1.UpdateEvent
        If (Level = 32000) Then

            Dim Serr_Grid As Integer

            Serr_Grid = MFirst(MH_Account, 0)

            While (Serr_Grid <> NOTFOUND)
                Dim Serr_Acct As Integer

                Call SqlCursor(CSR_xClasifFlujoE, NOLEVEL + SqlUpdate)
                SQLStr = "SELECT * FROM xClasifFlujoE WITH(NOLOCK) where Acct = " + SParm(bAccount.Acct)
                Serr_Acct = SqlFetch1(CSR_xClasifFlujoE, SQLStr, bxCE_AccountExtQ)
                If Serr_Acct = NOTFOUND Then
                    bxClasifFlujoE.Acct = bAccount.Acct.Trim()

                    Call TranBeg(True)
                    Call SInsert1(CSR_xClasifFlujoE, "xClasifFlujoE", bxClasifFlujoE)
                    Call TranEnd()
                Else
                    bxClasifFlujoE.Acct = bAccount.Acct.Trim()

                    Call TranBeg(True)
                    Call SUpdate1(CSR_xClasifFlujoE, "xClasifFlujoE", bxClasifFlujoE)
                    Call TranEnd()
                End If
                Call SqlFree(CSR_xClasifFlujoE)

                Serr_Grid = MNext(MH_Account, 0)
            End While
        End If
    End Sub

    Private Sub SafGrid1_LineChkEvent(ByRef Action As Short, ByRef MaintFlg As Short, ByRef RetVal As Short) Handles SafGrid1.LineChkEvent
        If (Action = DELETED) Then
            RetVal = ErrNoMess
            Call MessBox("No se pueden eliminar cuentas en esta pantalla.", MB_ICONEXCLAMATION, "Aviso")
        End If
    End Sub

End Class
