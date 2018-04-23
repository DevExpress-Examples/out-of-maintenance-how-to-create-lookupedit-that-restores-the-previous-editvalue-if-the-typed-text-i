Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Registrator
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls

Namespace Sample
	<UserRepositoryItem("RegisterCustomLookUpEdit")> _
	Public Class RepositoryItemCustomLookUpEdit
		Inherits RepositoryItemLookUpEdit
		Shared Sub New()
			RegisterCustomLookUpEdit()
		End Sub
		Public Sub New()
		End Sub
		Public Const CustomLookUpEditName As String = "CustomLookUpEdit"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomLookUpEditName
			End Get
		End Property
		Public Shared Sub RegisterCustomLookUpEdit()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomLookUpEditName, GetType(CustomLookUpEdit), GetType(RepositoryItemCustomLookUpEdit), GetType(LookUpEditViewInfo), New ButtonEditPainter(), True))
		End Sub
	End Class


	Public Class CustomLookUpEdit
		Inherits LookUpEdit
		Shared Sub New()
			RepositoryItemCustomLookUpEdit.RegisterCustomLookUpEdit()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub
		Protected beforeSearchEditValue As Object
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomLookUpEdit.CustomLookUpEditName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomLookUpEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomLookUpEdit)
			End Get
		End Property

		Protected Overrides Sub ProcessFindItem(ByVal helper As KeyPressHelper, ByVal pressedKey As Char)
			If helper.PrevText = "" AndAlso helper.Text <> "" Then
				beforeSearchEditValue = EditValue
			End If
			MyBase.ProcessFindItem(helper, pressedKey)
			If helper.PrevText <> "" AndAlso helper.Text = "" Then
				EditValue = beforeSearchEditValue
			End If
		End Sub
	End Class

End Namespace
