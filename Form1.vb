Imports iTextSharp.text
Imports iTextSharp.text.pdf

Imports System.IO
Imports System.Diagnostics

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim pdfReader As PdfReader = New PdfReader("template\mytemplate.pdf")


            Dim fileoutput As FileStream = New FileStream("template\test.pdf", FileMode.Create)

            Dim stamper As PdfStamper = New PdfStamper(pdfReader, fileoutput)
            stamper.FormFlattening = True

            stamper.AcroFields.SetField("name", "yoshio")
            stamper.AcroFields.SetField("age", "23")

            stamper.Close()
            pdfReader.Close()
            fileoutput.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.ToString)
        End Try

    End Sub
End Class
