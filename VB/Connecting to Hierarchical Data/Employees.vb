Imports System
Imports System.Collections.Generic

Namespace Connecting_to_Hierarchical_Data

	Public Class Employee
		Public Property ID() As Integer
		Public Property ParentID() As Integer
		Public Property Name() As String
		Public Property Position() As String
		Public Property Department() As String
	End Class

	Public Module Staff
		Public Function GetStaff() As List(Of Employee)
			Dim CompanyStaff As New List(Of Employee)()
			CompanyStaff.Add(New Employee() With {
				.ID = 1,
				.ParentID = 0,
				.Name = "Gregory S. Price",
				.Department = "",
				.Position = "President"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 2,
				.ParentID = 1,
				.Name = "Irma R. Marshall",
				.Department = "Marketing",
				.Position = "Vice President"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 3,
				.ParentID = 1,
				.Name = "John C. Powell",
				.Department = "Operations",
				.Position = "Vice President"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 4,
				.ParentID = 1,
				.Name = "Christian P. Laclair",
				.Department = "Production",
				.Position = "Vice President"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 5,
				.ParentID = 1,
				.Name = "Karen J. Kelly",
				.Department = "Finance",
				.Position = "Vice President"
			})

			CompanyStaff.Add(New Employee() With {
				.ID = 6,
				.ParentID = 2,
				.Name = "Brian C. Cowling",
				.Department = "Marketing",
				.Position = "Manager"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 7,
				.ParentID = 2,
				.Name = "Thomas C. Dawson",
				.Department = "Marketing",
				.Position = "Manager"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 8,
				.ParentID = 2,
				.Name = "Angel M. Wilson",
				.Department = "Marketing",
				.Position = "Manager"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 9,
				.ParentID = 2,
				.Name = "Bryan R. Henderson",
				.Department = "Marketing",
				.Position = "Manager"
			})

			CompanyStaff.Add(New Employee() With {
				.ID = 10,
				.ParentID = 3,
				.Name = "Harold S. Brandes",
				.Department = "Operations",
				.Position = "Manager"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 11,
				.ParentID = 3,
				.Name = "Michael S. Blevins",
				.Department = "Operations",
				.Position = "Manager"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 12,
				.ParentID = 3,
				.Name = "Jan K. Sisk",
				.Department = "Operations",
				.Position = "Manager"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 13,
				.ParentID = 3,
				.Name = "Sidney L. Holder",
				.Department = "Operations",
				.Position = "Manager"
			})

			CompanyStaff.Add(New Employee() With {
				.ID = 14,
				.ParentID = 4,
				.Name = "James L. Kelsey",
				.Department = "Production",
				.Position = "Manager"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 15,
				.ParentID = 4,
				.Name = "Howard M. Carpenter",
				.Department = "Production",
				.Position = "Manager"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 16,
				.ParentID = 4,
				.Name = "Jennifer T. Tapia",
				.Department = "Production",
				.Position = "Manager"
			})

			CompanyStaff.Add(New Employee() With {
				.ID = 17,
				.ParentID = 5,
				.Name = "Judith P. Underhill",
				.Department = "Finance",
				.Position = "Manager"
			})
			CompanyStaff.Add(New Employee() With {
				.ID = 18,
				.ParentID = 5,
				.Name = "Russell E. Belton",
				.Department = "Finance",
				.Position = "Manager"
			})
			Return CompanyStaff
		End Function
	End Module
End Namespace
