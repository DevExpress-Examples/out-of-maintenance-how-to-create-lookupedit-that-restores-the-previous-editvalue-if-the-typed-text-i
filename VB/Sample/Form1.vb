Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections

Namespace Sample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private myUsers As ArrayList
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			myUsers = New ArrayList()
			myUsers.Add(New User("Albert", 17))
			myUsers.Add(New User("Bill", 21))
			myUsers.Add(New User("Charli", 34))
			myUsers.Add(New User("Billy", 7))
			myUsers.Add(New User("Chen", 56))
			customLookUpEdit1.Properties.DataSource = myUsers
			customLookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete
			customLookUpEdit1.Properties.DisplayMember = "Name"
			customLookUpEdit1.Properties.ValueMember = "Name"
		End Sub
		Public Class User
			Private name_Renamed As String
			Private age_Renamed As Integer
			Public Sub New(ByVal name As String, ByVal age As Integer)
				Me.name_Renamed = name
				Me.age_Renamed = age
			End Sub
			Public ReadOnly Property Name() As String
				Get
					Return name_Renamed
				End Get
			End Property
			Public ReadOnly Property Age() As Integer
				Get
					Return age_Renamed
				End Get
			End Property
		End Class
	End Class
End Namespace