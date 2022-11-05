Imports System.Globalization

Public Class invoice
    Public idInvoice As String
    Public dateInvoice As Date
    Public customer As Customer
    Public listOfProducts As New List(Of ProductSelected)
    Public subtotal As Decimal
    Public totalPrice As Decimal
End Class
