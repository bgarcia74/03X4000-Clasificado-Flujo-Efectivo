Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module xClasifFlujoE
	Public Class xClasifFlujoE
	Inherits SolomonDataObject
		< _
		DataBinding(PropertyIndex:= 0, StringSize:=10) _
		> _
		Public Property Acct() as String
			Get
				Return Me.GetPropertyValue("Acct")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("Acct", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 1, StringSize:=10) _
		> _
		Public Property ClaseID() as String
			Get
				Return Me.GetPropertyValue("ClaseID")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("ClaseID", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 2) _
		> _
		Public Property Crtd_Date() as Integer
			Get
				Return Me.GetPropertyValue("Crtd_Date")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("Crtd_Date", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 3, StringSize:=8) _
		> _
		Public Property Crtd_Prog() as String
			Get
				Return Me.GetPropertyValue("Crtd_Prog")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("Crtd_Prog", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 4, StringSize:=47) _
		> _
		Public Property Crtd_User() as String
			Get
				Return Me.GetPropertyValue("Crtd_User")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("Crtd_User", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 5, StringSize:=10) _
		> _
		Public Property GrupoID() as String
			Get
				Return Me.GetPropertyValue("GrupoID")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("GrupoID", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 6) _
		> _
		Public Property LUpd_Date() as Integer
			Get
				Return Me.GetPropertyValue("LUpd_Date")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("LUpd_Date", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 7, StringSize:=8) _
		> _
		Public Property LUpd_Prog() as String
			Get
				Return Me.GetPropertyValue("LUpd_Prog")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("LUpd_Prog", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 8, StringSize:=47) _
		> _
		Public Property LUpd_User() as String
			Get
				Return Me.GetPropertyValue("LUpd_User")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("LUpd_User", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 9) _
		> _
		Public Property NoteID() as Integer
			Get
				Return Me.GetPropertyValue("NoteID")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("NoteID", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 10, StringSize:=2) _
		> _
		Public Property RatioGrp() as String
			Get
				Return Me.GetPropertyValue("RatioGrp")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("RatioGrp", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 11, StringSize:=10) _
		> _
		Public Property SubGrupoID() as String
			Get
				Return Me.GetPropertyValue("SubGrupoID")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("SubGrupoID", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 12, StringSize:=30) _
		> _
		Public Property User01() as String
			Get
				Return Me.GetPropertyValue("User01")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User01", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 13, StringSize:=30) _
		> _
		Public Property User02() as String
			Get
				Return Me.GetPropertyValue("User02")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User02", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 14, StringSize:=30) _
		> _
		Public Property User03() as String
			Get
				Return Me.GetPropertyValue("User03")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User03", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 15, StringSize:=30) _
		> _
		Public Property User04() as String
			Get
				Return Me.GetPropertyValue("User04")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User04", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 16, StringSize:=30) _
		> _
		Public Property User05() as String
			Get
				Return Me.GetPropertyValue("User05")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User05", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 17, StringSize:=10) _
		> _
		Public Property User06() as String
			Get
				Return Me.GetPropertyValue("User06")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User06", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 18, StringSize:=10) _
		> _
		Public Property User07() as String
			Get
				Return Me.GetPropertyValue("User07")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User07", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 19, StringSize:=10) _
		> _
		Public Property User08() as String
			Get
				Return Me.GetPropertyValue("User08")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User08", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 20, StringSize:=10) _
		> _
		Public Property User09() as String
			Get
				Return Me.GetPropertyValue("User09")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User09", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 21, StringSize:=10) _
		> _
		Public Property User10() as String
			Get
				Return Me.GetPropertyValue("User10")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User10", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 22) _
		> _
		Public Property User11() as Double
			Get
				Return Me.GetPropertyValue("User11")
			End Get
			Set(ByVal setval AS Double)
				Me.SetPropertyValue("User11", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 23) _
		> _
		Public Property User12() as Double
			Get
				Return Me.GetPropertyValue("User12")
			End Get
			Set(ByVal setval AS Double)
				Me.SetPropertyValue("User12", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 24) _
		> _
		Public Property User13() as Double
			Get
				Return Me.GetPropertyValue("User13")
			End Get
			Set(ByVal setval AS Double)
				Me.SetPropertyValue("User13", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 25) _
		> _
		Public Property User14() as Double
			Get
				Return Me.GetPropertyValue("User14")
			End Get
			Set(ByVal setval AS Double)
				Me.SetPropertyValue("User14", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 26) _
		> _
		Public Property User15() as Double
			Get
				Return Me.GetPropertyValue("User15")
			End Get
			Set(ByVal setval AS Double)
				Me.SetPropertyValue("User15", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 27) _
		> _
		Public Property User16() as Integer
			Get
				Return Me.GetPropertyValue("User16")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("User16", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 28) _
		> _
		Public Property User17() as Integer
			Get
				Return Me.GetPropertyValue("User17")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("User17", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 29) _
		> _
		Public Property User18() as Integer
			Get
				Return Me.GetPropertyValue("User18")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("User18", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 30) _
		> _
		Public Property User19() as Integer
			Get
				Return Me.GetPropertyValue("User19")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("User19", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 31) _
		> _
		Public Property User20() as Integer
			Get
				Return Me.GetPropertyValue("User20")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("User20", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 32) _
		> _
		Public Property User21() as Integer
			Get
				Return Me.GetPropertyValue("User21")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("User21", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 33) _
		> _
		Public Property User22() as Integer
			Get
				Return Me.GetPropertyValue("User22")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("User22", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 34) _
		> _
		Public Property User23() as Integer
			Get
				Return Me.GetPropertyValue("User23")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("User23", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 35) _
		> _
		Public Property User24() as Integer
			Get
				Return Me.GetPropertyValue("User24")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("User24", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 36) _
		> _
		Public Property User25() as Integer
			Get
				Return Me.GetPropertyValue("User25")
			End Get
			Set(ByVal setval AS Integer)
				Me.SetPropertyValue("User25", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 37, StringSize:=60) _
		> _
		Public Property User26() as String
			Get
				Return Me.GetPropertyValue("User26")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User26", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 38, StringSize:=60) _
		> _
		Public Property User27() as String
			Get
				Return Me.GetPropertyValue("User27")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User27", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 39, StringSize:=60) _
		> _
		Public Property User28() as String
			Get
				Return Me.GetPropertyValue("User28")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User28", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 40, StringSize:=60) _
		> _
		Public Property User29() as String
			Get
				Return Me.GetPropertyValue("User29")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User29", setval)
			End Set
		End Property
		< _
		DataBinding(PropertyIndex:= 41, StringSize:=60) _
		> _
		Public Property User30() as String
			Get
				Return Me.GetPropertyValue("User30")
			End Get
			Set(ByVal setval AS String)
				Me.SetPropertyValue("User30", setval)
			End Set
		End Property
	End Class
	Public bxClasifFlujoE As xClasifFlujoE = New xClasifFlujoE, nxClasifFlujoE As xClasifFlujoE = New xClasifFlujoE, bxClasifFlujoE1 As xClasifFlujoE = New xClasifFlujoE
	Public CSR_xClasifFlujoE As Short
	Sub Init_xClasifFlujoE(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
		Call SetAddr(x_Level, "bxClasifFlujoE", bxClasifFlujoE, nxClasifFlujoE)
		If x_Cursor = True Then
			Call SqlCursorEx(CSR_xClasifFlujoE, x_Level,"CSR_xClasifFlujoE", "xClasifFlujoE","")
		End If
	End Sub
End Module
