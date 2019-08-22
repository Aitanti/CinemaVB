Public Class Form1
    Public Function Adult_Before_5(quantity As Integer, person As String, day As Boolean, time As Integer) As Double
        Dim ticket_price = 14.5
        Dim total_price = ticket_price * quantity

        If day = False Then

            If quantity > 0 And quantity < 10 Then
                If person = "Adult" Then
                    If time < 5 Then
                        Return total_price
                    End If
                End If
            End If
        End If

    End Function
    Public Function Adult_After_5(quantity As Integer, person As String, day As String, time As Integer) As Double
        Dim ticket_price = 17.5
        Dim total_price = ticket_price * quantity

        If day = False Then

            If quantity > 0 And quantity < 10 Then
                If person = "Adult" Then
                    If time > 5 Then
                        Return total_price
                    End If
                End If
            End If
        End If

    End Function
    Public Function Adult_Tuesday(quantity As Integer, person As String, day As String) As Int32
        Dim ticket_price = 13
        Dim total_price = ticket_price * quantity

        If day = True Then ' true = tuesday'

            If quantity > 0 And quantity < 10 Then
                If person = "Adult" Then
                    Return total_price
                End If
            End If
            End If

    End Function

    Public Function Child_Under_16(quantity As Integer, person As String) As Int32
        Dim ticket_price = 12
        Dim total_price = ticket_price * quantity

        If quantity > 0 And quantity < 10 Then
            If person = "Child" Then
                Return total_price
            End If
        End If

    End Function

    Public Function Senior(quantity As Integer, person As String) As Double
        Dim ticket_price = 12.5
        Dim total_price = ticket_price * quantity

        If quantity > 0 And quantity < 10 Then
            If person = "Senior" Then
                Return total_price
            End If
        End If

    End Function
    Public Function Student(quantity As Integer, person As String, day As Boolean) As Int32
        Dim ticket_price = 14
        Dim total_price = ticket_price * quantity

        If day = False Then
            If quantity > 0 And quantity < 10 Then
                If person = "Student" Then
                    Return total_price
                End If
            End If
        End If

    End Function
    Public Function Chick_Flick_Thursday(quantity As Integer, person As String) As Double
        Dim ticket_price = 21.5
        Dim total_price = ticket_price * quantity

        If quantity > 0 And quantity < 10 Then
            If person = "Adult" Then
                Return total_price
            End If
        End If
    End Function
    Public Function Kids_Carers(quantity As Integer, day As Boolean, holiday As Boolean) As Integer
        Dim ticket_price = 12
        Dim total_price = ticket_price * quantity

        If day = True Then
            If quantity > 0 And quantity < 10 Then
                If holiday = True Then
                    Return total_price
                End If
            End If
        End If
    End Function
    Public Function Family_Pass(quantity As Integer) As Integer
        Dim ticket_price = 46
        Dim total_price = ticket_price * quantity

        If quantity > 0 And quantity < 10 Then

            Return total_price
        End If

    End Function


    Private Sub Cinemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
