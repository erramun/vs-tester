﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "New feature in newFeature branch."

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Another rockstar feature."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
