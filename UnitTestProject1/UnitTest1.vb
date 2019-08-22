Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CinemaVB

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub Adult_Before_5_Test()
        Dim form1 As Form1 = New Form1
        Dim adult_before_5 = form1.Adult_Before_5(1, "Adult", False, 4)
        Assert.AreEqual(14.5, adult_before_5)
    End Sub
End Class

<TestClass()> Public Class UnitTest2

    <TestMethod()> Public Sub Adult_After_5()
        Dim form1 As Form1 = New Form1
        Dim adult_after_5 = form1.Adult_After_5(1, "Adult", False, 6)
        Assert.AreEqual(17.5, adult_after_5)
    End Sub
End Class
<TestClass()> Public Class UnitTest3

    <TestMethod()> Public Sub Adult_Tuesday()

        Dim form1 As Form1 = New Form1
        Dim adult_tuesday = form1.Adult_Tuesday(1, "Adult", True)

        Assert.AreEqual(13, adult_tuesday)

    End Sub

End Class

<TestClass()> Public Class UnitTest4

    <TestMethod()> Public Sub Child_Under_16()

        Dim form1 As Form1 = New Form1
        Dim child_under_16 = form1.Child_Under_16(1, "Child")

        Assert.AreEqual(12, child_under_16)

    End Sub

End Class

<TestClass()> Public Class UnitTest5

    <TestMethod()> Public Sub Senior()

        Dim form1 As Form1 = New Form1
        Dim senior = form1.Senior(1, "Senior")
        Assert.AreEqual(12.5, senior)

    End Sub

End Class

<TestClass()> Public Class UnitTest6

    <TestMethod()> Public Sub Student()

        Dim form1 As Form1 = New Form1
        Dim student = form1.Student(1, "Student", False)
        Assert.AreEqual(14, student)

    End Sub

End Class
<TestClass()> Public Class UnitTest7

    <TestMethod()> Public Sub Chick_Flick_Thursday()

        Dim form1 As Form1 = New Form1
        Dim chick_flick_thursday = form1.Chick_Flick_Thursday(1, "Adult")
        Assert.AreEqual(21.5, chick_flick_thursday)

    End Sub

End Class

<TestClass()> Public Class UnitTest8

    <TestMethod()> Public Sub Kids_Carers()

        Dim form1 As Form1 = New Form1
        Dim kids_carers = form1.Kids_Carers(1, True, True)
        Assert.AreEqual(12, kids_carers)

    End Sub

End Class

<TestClass()> Public Class UnitTest9

    <TestMethod()> Public Sub Family_Pass()

        Dim form1 As Form1 = New Form1
        Dim family_pass = form1.Family_Pass(1)
        Assert.AreEqual(46, family_pass)

    End Sub

End Class
