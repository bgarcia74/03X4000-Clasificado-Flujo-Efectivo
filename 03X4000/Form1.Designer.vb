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
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		m_IsInitializing = true
		InitializeComponent()
		m_IsInitializing = False
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Update1 As Microsoft.Dynamics.SL.Controls.DSLUpdate
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Update1 = New Microsoft.Dynamics.SL.Controls.DSLUpdate()
        Me.SAFHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cCtaNoAprob = New Microsoft.Dynamics.SL.Controls.DSLCheck()
        Me.lNotas = New System.Windows.Forms.Label()
        Me.cNotas = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lflujoC = New System.Windows.Forms.Label()
        Me.cflujoC = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lSubGrupoBifrs = New System.Windows.Forms.Label()
        Me.cSubGrupoBifrs = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lSubGrupoAifrs = New System.Windows.Forms.Label()
        Me.cSubGrupoAifrs = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lGrupoBIfrs = New System.Windows.Forms.Label()
        Me.cGrupoBIfrs = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lGrupoID = New System.Windows.Forms.Label()
        Me.cGrupoID = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lGrupoAIfrs = New System.Windows.Forms.Label()
        Me.cGrupoAIfrs = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lArgRepCosto = New System.Windows.Forms.Label()
        Me.cArgRepCosto = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lRepCosto = New System.Windows.Forms.Label()
        Me.cRepCosto = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lClasGAV = New System.Windows.Forms.Label()
        Me.cClasGAV = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lSubGrupoID = New System.Windows.Forms.Label()
        Me.cSubGrupoID = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lClaseID = New System.Windows.Forms.Label()
        Me.cClaseID = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lGpoRazones = New System.Windows.Forms.Label()
        Me.cGpoRazones = New Microsoft.Dynamics.SL.Controls.DSLCombo()
        Me.lCuentaSII = New System.Windows.Forms.Label()
        Me.CuentaSII = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.lL0Descr = New System.Windows.Forms.Label()
        Me.cL0Descr = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cL1Acct = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.SafGrid1 = New Microsoft.Dynamics.SL.Controls.DSLGrid()
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SafGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Update1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Update1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update1.Image = CType(resources.GetObject("Update1.Image"), System.Drawing.Image)
        Me.Update1.Levels = "Detail;D"
        Me.Update1.Location = New System.Drawing.Point(1013, 12)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(25, 25)
        Me.Update1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Update1.TabIndex = 0
        Me.Update1.TabStop = False
        Me.Update1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cCtaNoAprob)
        Me.GroupBox1.Controls.Add(Me.lNotas)
        Me.GroupBox1.Controls.Add(Me.cNotas)
        Me.GroupBox1.Controls.Add(Me.lflujoC)
        Me.GroupBox1.Controls.Add(Me.cflujoC)
        Me.GroupBox1.Controls.Add(Me.lSubGrupoBifrs)
        Me.GroupBox1.Controls.Add(Me.cSubGrupoBifrs)
        Me.GroupBox1.Controls.Add(Me.lSubGrupoAifrs)
        Me.GroupBox1.Controls.Add(Me.cSubGrupoAifrs)
        Me.GroupBox1.Controls.Add(Me.lGrupoBIfrs)
        Me.GroupBox1.Controls.Add(Me.cGrupoBIfrs)
        Me.GroupBox1.Controls.Add(Me.lGrupoID)
        Me.GroupBox1.Controls.Add(Me.cGrupoID)
        Me.GroupBox1.Controls.Add(Me.lGrupoAIfrs)
        Me.GroupBox1.Controls.Add(Me.cGrupoAIfrs)
        Me.GroupBox1.Controls.Add(Me.lArgRepCosto)
        Me.GroupBox1.Controls.Add(Me.cArgRepCosto)
        Me.GroupBox1.Controls.Add(Me.lRepCosto)
        Me.GroupBox1.Controls.Add(Me.cRepCosto)
        Me.GroupBox1.Controls.Add(Me.lClasGAV)
        Me.GroupBox1.Controls.Add(Me.cClasGAV)
        Me.GroupBox1.Controls.Add(Me.lSubGrupoID)
        Me.GroupBox1.Controls.Add(Me.cSubGrupoID)
        Me.GroupBox1.Controls.Add(Me.lClaseID)
        Me.GroupBox1.Controls.Add(Me.cClaseID)
        Me.GroupBox1.Controls.Add(Me.lGpoRazones)
        Me.GroupBox1.Controls.Add(Me.cGpoRazones)
        Me.GroupBox1.Controls.Add(Me.lCuentaSII)
        Me.GroupBox1.Controls.Add(Me.CuentaSII)
        Me.GroupBox1.Controls.Add(Me.lL0Descr)
        Me.GroupBox1.Controls.Add(Me.cL0Descr)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cL1Acct)
        Me.GroupBox1.Controls.Add(Me.SafGrid1)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1009, 482)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "(F4 para tabla/forma)"
        '
        'cCtaNoAprob
        '
        Me.cCtaNoAprob.FieldName = """bxClasifFlujoE.User16""; 0; 0; 0"
        Me.cCtaNoAprob.Heading = "Cuenta no,requiere aprobación"
        Me.cCtaNoAprob.Location = New System.Drawing.Point(708, 315)
        Me.cCtaNoAprob.Name = "cCtaNoAprob"
        Me.cCtaNoAprob.Size = New System.Drawing.Size(206, 23)
        Me.cCtaNoAprob.TabIndex = 41
        Me.cCtaNoAprob.Text = "Cuenta no requiere aprobación"
        Me.cCtaNoAprob.UseVisualStyleBackColor = True
        '
        'lNotas
        '
        Me.lNotas.AutoSize = True
        Me.lNotas.Location = New System.Drawing.Point(690, 278)
        Me.lNotas.Name = "lNotas"
        Me.lNotas.Size = New System.Drawing.Size(39, 13)
        Me.lNotas.TabIndex = 40
        Me.lNotas.Text = "Notas:"
        '
        'cNotas
        '
        Me.cNotas.FieldName = """bxClasifFlujoE.User03""; 0; 0; 0"
        Me.cNotas.Heading = "Notas"
        Me.cNotas.Location = New System.Drawing.Point(804, 271)
        Me.cNotas.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.cNotas.Name = "cNotas"
        Me.cNotas.PV = """PJCODE_SALL"", ""03C2""; 0; 127; 0; 0, "
        Me.cNotas.Size = New System.Drawing.Size(75, 20)
        Me.cNotas.TabIndex = 15
        Me.cNotas.TextLength = 30
        '
        'lflujoC
        '
        Me.lflujoC.AutoSize = True
        Me.lflujoC.Location = New System.Drawing.Point(690, 237)
        Me.lflujoC.Name = "lflujoC"
        Me.lflujoC.Size = New System.Drawing.Size(44, 13)
        Me.lflujoC.TabIndex = 38
        Me.lflujoC.Text = "Flujo C:"
        '
        'cflujoC
        '
        Me.cflujoC.FieldName = """bxClasifFlujoE.User04""; 0; 0; 0"
        Me.cflujoC.Heading = "Flujo C"
        Me.cflujoC.Location = New System.Drawing.Point(804, 230)
        Me.cflujoC.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.cflujoC.Name = "cflujoC"
        Me.cflujoC.PV = """PJCODE_SALL"", ""03C6""; 0; 127; 0; 0, "
        Me.cflujoC.Size = New System.Drawing.Size(75, 20)
        Me.cflujoC.TabIndex = 14
        Me.cflujoC.TextLength = 30
        '
        'lSubGrupoBifrs
        '
        Me.lSubGrupoBifrs.AutoSize = True
        Me.lSubGrupoBifrs.Location = New System.Drawing.Point(690, 196)
        Me.lSubGrupoBifrs.Name = "lSubGrupoBifrs"
        Me.lSubGrupoBifrs.Size = New System.Drawing.Size(88, 13)
        Me.lSubGrupoBifrs.TabIndex = 36
        Me.lSubGrupoBifrs.Text = "Sub Grupo B ifrs:"
        '
        'cSubGrupoBifrs
        '
        Me.cSubGrupoBifrs.FieldName = """bxClasifFlujoE.User02""; 0; 0; 0"
        Me.cSubGrupoBifrs.Heading = "Sub Grupo B ifrs"
        Me.cSubGrupoBifrs.Location = New System.Drawing.Point(804, 189)
        Me.cSubGrupoBifrs.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.cSubGrupoBifrs.Name = "cSubGrupoBifrs"
        Me.cSubGrupoBifrs.PV = """PJCODE_SALL"", ""03G2""; 0; 127; 0; 0, "
        Me.cSubGrupoBifrs.Size = New System.Drawing.Size(75, 20)
        Me.cSubGrupoBifrs.TabIndex = 13
        Me.cSubGrupoBifrs.TextLength = 30
        '
        'lSubGrupoAifrs
        '
        Me.lSubGrupoAifrs.AutoSize = True
        Me.lSubGrupoAifrs.Location = New System.Drawing.Point(690, 158)
        Me.lSubGrupoAifrs.Name = "lSubGrupoAifrs"
        Me.lSubGrupoAifrs.Size = New System.Drawing.Size(89, 13)
        Me.lSubGrupoAifrs.TabIndex = 34
        Me.lSubGrupoAifrs.Text = "Sub Grupo A ifrs:"
        '
        'cSubGrupoAifrs
        '
        Me.cSubGrupoAifrs.FieldName = """bxClasifFlujoE.User01""; 0; 0; 0"
        Me.cSubGrupoAifrs.Heading = "Sub Grupo A ifrs"
        Me.cSubGrupoAifrs.Location = New System.Drawing.Point(804, 151)
        Me.cSubGrupoAifrs.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.cSubGrupoAifrs.Name = "cSubGrupoAifrs"
        Me.cSubGrupoAifrs.PV = """PJCODE_SALL"", ""03G1""; 0; 127; 0; 0, "
        Me.cSubGrupoAifrs.Size = New System.Drawing.Size(75, 20)
        Me.cSubGrupoAifrs.TabIndex = 12
        Me.cSubGrupoAifrs.TextLength = 30
        '
        'lGrupoBIfrs
        '
        Me.lGrupoBIfrs.AutoSize = True
        Me.lGrupoBIfrs.Location = New System.Drawing.Point(690, 122)
        Me.lGrupoBIfrs.Name = "lGrupoBIfrs"
        Me.lGrupoBIfrs.Size = New System.Drawing.Size(69, 13)
        Me.lGrupoBIfrs.TabIndex = 32
        Me.lGrupoBIfrs.Text = "Grupo B Ifrs:"
        '
        'cGrupoBIfrs
        '
        Me.cGrupoBIfrs.FieldName = """bxClasifFlujoE.User10""; 0; 0; 0"
        Me.cGrupoBIfrs.Heading = "Grupo B Ifrs:"
        Me.cGrupoBIfrs.Location = New System.Drawing.Point(804, 115)
        Me.cGrupoBIfrs.Mask = "XXXXXXXXXX"
        Me.cGrupoBIfrs.Name = "cGrupoBIfrs"
        Me.cGrupoBIfrs.PV = """PJCODE_SALL"", ""03G9""; 0; 127; 0; 0, "
        Me.cGrupoBIfrs.Size = New System.Drawing.Size(75, 20)
        Me.cGrupoBIfrs.TabIndex = 11
        Me.cGrupoBIfrs.TextLength = 10
        '
        'lGrupoID
        '
        Me.lGrupoID.AutoSize = True
        Me.lGrupoID.Location = New System.Drawing.Point(33, 241)
        Me.lGrupoID.Name = "lGrupoID"
        Me.lGrupoID.Size = New System.Drawing.Size(60, 13)
        Me.lGrupoID.TabIndex = 30
        Me.lGrupoID.Text = "No. Grupo:"
        '
        'cGrupoID
        '
        Me.cGrupoID.FieldName = """bxClasifFlujoE.GrupoID""; 0; 0; 0"
        Me.cGrupoID.Heading = "No. Grupo"
        Me.cGrupoID.Location = New System.Drawing.Point(147, 234)
        Me.cGrupoID.Mask = "UUUUUUUUUU"
        Me.cGrupoID.Name = "cGrupoID"
        Me.cGrupoID.PV = """PJCODE_SALL"", ""03X2""; 0; 127; 0; 0, "
        Me.cGrupoID.Size = New System.Drawing.Size(75, 20)
        Me.cGrupoID.TabIndex = 5
        Me.cGrupoID.TextLength = 10
        '
        'lGrupoAIfrs
        '
        Me.lGrupoAIfrs.AutoSize = True
        Me.lGrupoAIfrs.Location = New System.Drawing.Point(690, 79)
        Me.lGrupoAIfrs.Name = "lGrupoAIfrs"
        Me.lGrupoAIfrs.Size = New System.Drawing.Size(70, 13)
        Me.lGrupoAIfrs.TabIndex = 28
        Me.lGrupoAIfrs.Text = "Grupo A Ifrs:"
        '
        'cGrupoAIfrs
        '
        Me.cGrupoAIfrs.FieldName = """bxClasifFlujoE.User09""; 0; 0; 0"
        Me.cGrupoAIfrs.Heading = "Grupo A Ifrs"
        Me.cGrupoAIfrs.Location = New System.Drawing.Point(804, 72)
        Me.cGrupoAIfrs.Mask = "XXXXXXXXXX"
        Me.cGrupoAIfrs.Name = "cGrupoAIfrs"
        Me.cGrupoAIfrs.PV = """PJCODE_SALL"", ""03G8""; 0; 127; 0; 0, "
        Me.cGrupoAIfrs.Size = New System.Drawing.Size(75, 20)
        Me.cGrupoAIfrs.TabIndex = 10
        Me.cGrupoAIfrs.TextLength = 10
        '
        'lArgRepCosto
        '
        Me.lArgRepCosto.AutoSize = True
        Me.lArgRepCosto.Location = New System.Drawing.Point(33, 392)
        Me.lArgRepCosto.Name = "lArgRepCosto"
        Me.lArgRepCosto.Size = New System.Drawing.Size(78, 13)
        Me.lArgRepCosto.TabIndex = 26
        Me.lArgRepCosto.Text = "ArgRep Costo:"
        '
        'cArgRepCosto
        '
        Me.cArgRepCosto.FieldName = """bxClasifFlujoE.User08""; 0; 0; 0"
        Me.cArgRepCosto.Heading = "ArgRep Costo"
        Me.cArgRepCosto.Location = New System.Drawing.Point(147, 385)
        Me.cArgRepCosto.Mask = "XXXXXXXXXX"
        Me.cArgRepCosto.Name = "cArgRepCosto"
        Me.cArgRepCosto.PV = """PJCODE_SALL"", ""03G7""; 0; 127; 0; 0, "
        Me.cArgRepCosto.Size = New System.Drawing.Size(75, 20)
        Me.cArgRepCosto.TabIndex = 9
        Me.cArgRepCosto.TextLength = 10
        '
        'lRepCosto
        '
        Me.lRepCosto.AutoSize = True
        Me.lRepCosto.Location = New System.Drawing.Point(33, 354)
        Me.lRepCosto.Name = "lRepCosto"
        Me.lRepCosto.Size = New System.Drawing.Size(61, 13)
        Me.lRepCosto.TabIndex = 24
        Me.lRepCosto.Text = "Rep Costo:"
        '
        'cRepCosto
        '
        Me.cRepCosto.FieldName = """bxClasifFlujoE.User07""; 0; 0; 0"
        Me.cRepCosto.Heading = "Rep Costo"
        Me.cRepCosto.Location = New System.Drawing.Point(147, 347)
        Me.cRepCosto.Mask = "XXXXXXXXXX"
        Me.cRepCosto.Name = "cRepCosto"
        Me.cRepCosto.PV = """PJCODE_SALL"", ""03G6""; 0; 127; 0; 0, "
        Me.cRepCosto.Size = New System.Drawing.Size(75, 20)
        Me.cRepCosto.TabIndex = 8
        Me.cRepCosto.TextLength = 10
        '
        'lClasGAV
        '
        Me.lClasGAV.AutoSize = True
        Me.lClasGAV.Location = New System.Drawing.Point(33, 315)
        Me.lClasGAV.Name = "lClasGAV"
        Me.lClasGAV.Size = New System.Drawing.Size(54, 13)
        Me.lClasGAV.TabIndex = 22
        Me.lClasGAV.Text = "Clas GAV:"
        '
        'cClasGAV
        '
        Me.cClasGAV.FieldName = """bxclasifflujoe.user06""; 0; 0; 0"
        Me.cClasGAV.Heading = "Clas GAV"
        Me.cClasGAV.Location = New System.Drawing.Point(147, 308)
        Me.cClasGAV.Mask = "XXXXXXXXXX"
        Me.cClasGAV.Name = "cClasGAV"
        Me.cClasGAV.PV = """PJCODE_SALL"", ""03G5""; 0; 127; 0; 0, "
        Me.cClasGAV.Size = New System.Drawing.Size(75, 20)
        Me.cClasGAV.TabIndex = 7
        Me.cClasGAV.TextLength = 10
        '
        'lSubGrupoID
        '
        Me.lSubGrupoID.AutoSize = True
        Me.lSubGrupoID.Location = New System.Drawing.Point(33, 278)
        Me.lSubGrupoID.Name = "lSubGrupoID"
        Me.lSubGrupoID.Size = New System.Drawing.Size(61, 13)
        Me.lSubGrupoID.TabIndex = 20
        Me.lSubGrupoID.Text = "Sub Grupo:"
        '
        'cSubGrupoID
        '
        Me.cSubGrupoID.FieldName = """bxClasifFlujoE.SubGrupoID""; 0; 0; 0"
        Me.cSubGrupoID.Heading = "SubGrupo"
        Me.cSubGrupoID.Location = New System.Drawing.Point(147, 271)
        Me.cSubGrupoID.Mask = "UUUUUUUUUU"
        Me.cSubGrupoID.Name = "cSubGrupoID"
        Me.cSubGrupoID.PV = """PJCODE_SALL"", ""03X3""; 0; 127; 0; 0, "
        Me.cSubGrupoID.Size = New System.Drawing.Size(75, 20)
        Me.cSubGrupoID.TabIndex = 6
        Me.cSubGrupoID.TextLength = 10
        '
        'lClaseID
        '
        Me.lClaseID.AutoSize = True
        Me.lClaseID.Location = New System.Drawing.Point(33, 196)
        Me.lClaseID.Name = "lClaseID"
        Me.lClaseID.Size = New System.Drawing.Size(53, 13)
        Me.lClaseID.TabIndex = 18
        Me.lClaseID.Text = "No Clase:"
        '
        'cClaseID
        '
        Me.cClaseID.FieldName = """bxClasifFlujoE.ClaseID""; 0; 0; 0"
        Me.cClaseID.Heading = "No. Clase"
        Me.cClaseID.Location = New System.Drawing.Point(147, 189)
        Me.cClaseID.Mask = "UUUUUUUUUU"
        Me.cClaseID.Name = "cClaseID"
        Me.cClaseID.PV = """PJCODE_SALL"", ""03X1""; 0; 127; 0; 0, "
        Me.cClaseID.Size = New System.Drawing.Size(75, 20)
        Me.cClaseID.TabIndex = 4
        Me.cClaseID.TextLength = 10
        '
        'lGpoRazones
        '
        Me.lGpoRazones.AutoSize = True
        Me.lGpoRazones.Location = New System.Drawing.Point(33, 159)
        Me.lGpoRazones.Name = "lGpoRazones"
        Me.lGpoRazones.Size = New System.Drawing.Size(84, 13)
        Me.lGpoRazones.TabIndex = 16
        Me.lGpoRazones.Text = "Grupo Razones:"
        '
        'cGpoRazones
        '
        Me.cGpoRazones.FieldName = """bxClasifFlujoE.RatioGrp""; 0; 0; 0"
        Me.cGpoRazones.FormattingEnabled = True
        Me.cGpoRazones.Heading = "Grupo Razones"
        Me.cGpoRazones.List = resources.GetString("cGpoRazones.List")
        Me.cGpoRazones.Location = New System.Drawing.Point(147, 151)
        Me.cGpoRazones.Name = "cGpoRazones"
        Me.cGpoRazones.Size = New System.Drawing.Size(141, 21)
        Me.cGpoRazones.TabIndex = 3
        '
        'lCuentaSII
        '
        Me.lCuentaSII.AutoSize = True
        Me.lCuentaSII.Location = New System.Drawing.Point(54, 118)
        Me.lCuentaSII.Name = "lCuentaSII"
        Me.lCuentaSII.Size = New System.Drawing.Size(60, 13)
        Me.lCuentaSII.TabIndex = 14
        Me.lCuentaSII.Text = "CuentaSII:"
        '
        'CuentaSII
        '
        Me.CuentaSII.FieldName = "baccount.user2"
        Me.CuentaSII.Heading = "CuentaSII"
        Me.CuentaSII.Location = New System.Drawing.Point(148, 115)
        Me.CuentaSII.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.CuentaSII.Name = "CuentaSII"
        Me.CuentaSII.Size = New System.Drawing.Size(262, 19)
        Me.CuentaSII.TabIndex = 2
        Me.CuentaSII.TextLength = 30
        '
        'lL0Descr
        '
        Me.lL0Descr.AutoSize = True
        Me.lL0Descr.Location = New System.Drawing.Point(52, 79)
        Me.lL0Descr.Name = "lL0Descr"
        Me.lL0Descr.Size = New System.Drawing.Size(65, 13)
        Me.lL0Descr.TabIndex = 12
        Me.lL0Descr.Text = "Descripción:"
        '
        'cL0Descr
        '
        Me.cL0Descr.Blankerr = True
        Me.cL0Descr.Default = ""
        Me.cL0Descr.FieldName = """bAccount.Descr""; 0; 0; 0"
        Me.cL0Descr.Heading = "Descripción"
        Me.cL0Descr.Location = New System.Drawing.Point(148, 76)
        Me.cL0Descr.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.cL0Descr.Name = "cL0Descr"
        Me.cL0Descr.Size = New System.Drawing.Size(262, 19)
        Me.cL0Descr.TabIndex = 1
        Me.cL0Descr.TextLength = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cuenta:"
        '
        'cL1Acct
        '
        Me.cL1Acct.Blankerr = True
        Me.cL1Acct.Default = ""
        Me.cL1Acct.FieldName = """bAccount.Acct""; 0; 0; 0"
        Me.cL1Acct.Heading = "Cuenta"
        Me.cL1Acct.Level = "0,k"
        Me.cL1Acct.Location = New System.Drawing.Point(148, 39)
        Me.cL1Acct.Mask = "UUUUUUUUUUUUUUUUUUUUUUUUUUUUUU"
        Me.cL1Acct.Name = "cL1Acct"
        Me.cL1Acct.PV = """Account_All"","
        Me.cL1Acct.Size = New System.Drawing.Size(85, 19)
        Me.cL1Acct.TabIndex = 0
        Me.cL1Acct.TextLength = 30
        '
        'SafGrid1
        '
        Me.SafGrid1.Location = New System.Drawing.Point(908, 432)
        Me.SafGrid1.Name = "SafGrid1"
        Me.SafGrid1.OcxState = CType(resources.GetObject("SafGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SafGrid1.Size = New System.Drawing.Size(71, 34)
        Me.SafGrid1.SetSLDBNav(Me.SafGrid1, """xsp_xClasifFlujoE_All"", ""bAccount.Acct""; 0; 0; 0; 1, ")
        Me.SafGrid1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1050, 511)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Update1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Clasificado Flujo Efectivo (03.X40.00)"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SafGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SafGrid1 As Microsoft.Dynamics.SL.Controls.DSLGrid
    Friend WithEvents lL0Descr As Label
    Friend WithEvents cL0Descr As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents Label2 As Label
    Friend WithEvents cL1Acct As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lGpoRazones As Label
    Friend WithEvents cGpoRazones As Microsoft.Dynamics.SL.Controls.DSLCombo
    Friend WithEvents lCuentaSII As Label
    Friend WithEvents CuentaSII As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lNotas As Label
    Friend WithEvents cNotas As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lflujoC As Label
    Friend WithEvents cflujoC As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lSubGrupoBifrs As Label
    Friend WithEvents cSubGrupoBifrs As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lSubGrupoAifrs As Label
    Friend WithEvents cSubGrupoAifrs As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lGrupoBIfrs As Label
    Friend WithEvents cGrupoBIfrs As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lGrupoID As Label
    Friend WithEvents cGrupoID As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lGrupoAIfrs As Label
    Friend WithEvents cGrupoAIfrs As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lArgRepCosto As Label
    Friend WithEvents cArgRepCosto As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lRepCosto As Label
    Friend WithEvents cRepCosto As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lClasGAV As Label
    Friend WithEvents cClasGAV As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lSubGrupoID As Label
    Friend WithEvents cSubGrupoID As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents lClaseID As Label
    Friend WithEvents cClaseID As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cCtaNoAprob As Microsoft.Dynamics.SL.Controls.DSLCheck
#End Region
End Class
