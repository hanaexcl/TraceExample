Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stacktrace As New StackTrace(True)
        Trace.WriteLine("目前行號: " + StackTrace.GetFrame(0).GetFileLineNumber().ToString())
        Trace.WriteLine("目前方法: " + StackTrace.GetFrame(0).GetMethod().Name)
        Trace.WriteLine("呼叫名稱: " + stacktrace.GetFrame(1).GetMethod().Name)

        Debug.WriteLine("Debug 紀錄")
        Trace.WriteLine("Trace 紀錄")
    End Sub
End Class
