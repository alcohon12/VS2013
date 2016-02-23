Imports System
Imports System.Configuration
Imports System.Web
Imports System.Net
Imports CGR.SEGUR.DEMO01.srvDataSensible

Public Class sisAuditoria


    Private Delegate Sub InsertarEvento(ByVal objEvento As srvDataSensible.EventoBE)

    ''' <summary>
    ''' Manejador de errores y/o excepciones de los Sistemas de la CGR
    ''' </summary>
    ''' <param name="tipoEvento">1:Login, 2:Error, 3:Informartion, 4:Warning</param>
    ''' <param name="pExcepcion">Mensaje ex</param>
    ''' <param name="pMsgError">Mensaje Personalizado</param>
    ''' <remarks></remarks>
    Public Shared Sub GuardarEvento(ByVal tipoEvento As Integer, ByVal pExcepcion As String, ByVal pMsgError As String, ByVal usuario As String)
        GuardarEventoAPP(tipoEvento, pExcepcion, pMsgError, usuario, "")
    End Sub

    ''' <summary>
    ''' Manejador de errores y/o excepciones de los Sistemas de la CGR
    ''' </summary>
    ''' <param name="tipoEvento">1:Login, 2:Error, 3:Informartion, 4:Warning</param>
    ''' <param name="pMsgError">Mensaje Personalizado</param>
    ''' <remarks></remarks>
    Public Shared Sub GuardarEvento(ByVal tipoEvento As Integer, ByVal pMsgError As String, ByVal usuario As String)
        GuardarEventoAPP(tipoEvento, "", pMsgError, usuario, "")
    End Sub

    ''' <summary>
    ''' Manejador de errores y/o excepciones de los Sistemas de la CGR
    ''' </summary>
    ''' <param name="tipoEvento">1:Login, 2:Error, 3:Informartion, 4:Warning</param>
    ''' <param name="pExcepcion">Error Execepción ex.ToString</param>
    ''' <param name="pMsgError">Mnesaje Personalizado</param>
    ''' <param name="usuario">Usuario session</param>
    ''' <param name="otrosValores">Estructura definidad para guardar los campos necesarios
    '''                            NOMBRECAMPO1:DATOS DEL CAMPO1|NOMBRECAMPO2: DATOS DEL CAMP2|NOMBRECAMPO3:DATOS DEL CAMPO3|...</param>
    ''' <remarks></remarks>
    Public Shared Sub GuardarEvento(ByVal tipoEvento As Integer, ByVal pExcepcion As String, ByVal pMsgError As String, ByVal usuario As String, ByVal otrosValores As String)
        GuardarEventoAPP(tipoEvento, "", pMsgError, usuario, otrosValores)
    End Sub

    Private Shared Sub GuardarEventoAPP(ByVal tipoEvento As Integer, ByVal pExcepcion As String, ByVal pMsgError As String, ByVal usuario As String, ByVal OtrosValores As String)

        Dim objEventoBE As New srvDataSensible.EventoBE
        Try
            objEventoBE.CAPP_CODIGO = ConfigurationManager.AppSettings("WcfUsuarioAUT")
            objEventoBE.NWEB_TIPO_EVENTO = tipoEvento
            objEventoBE.CWEB_EXCEPCION = If(pExcepcion IsNot Nothing, pExcepcion.Trim(), Nothing)

            If HttpContext.Current IsNot Nothing Then
                Dim ipAddress As String = HttpContext.Current.Request.Headers("X-Forwarded-For")
                If ipAddress = String.Empty Then ipAddress = HttpContext.Current.Request.UserHostAddress

                objEventoBE.CWEB_IP = ipAddress
                objEventoBE.CWEB_REQUEST_URL = HttpContext.Current.Request.Url.AbsoluteUri
            Else
                Try
                    objEventoBE.CWEB_IP = GetIpAddress()
                    objEventoBE.CWEB_REQUEST_URL = ""
                Catch generatedExceptionName As Exception
                    objEventoBE.CWEB_IP = "LOCAL"
                    objEventoBE.CWEB_REQUEST_URL = "LOCAL"
                End Try
            End If

            objEventoBE.CWEB_MENSAJE = pMsgError
            objEventoBE.CWEB_USUARIO_CODIGO = usuario
            objEventoBE.CWEB_VALORES = OtrosValores


            Dim ejecutar As New InsertarEvento(AddressOf Insertar_Eventos)
            ejecutar.BeginInvoke(objEventoBE, Nothing, Nothing)

        Catch ex As Exception
        Finally
            objEventoBE = Nothing
        End Try
    End Sub

    Protected Shared Sub Insertar_Eventos(ByVal objEvento As srvDataSensible.EventoBE)
        Dim srvAuditoria As New srvDataSensible.AuditoriaClient
        srvAuditoria.GuardarEvento(objEvento)
    End Sub

    Protected Shared Function GetIpAddress() As String
        Dim hostAddresses As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName())
        Const num1 As Integer = 0
        Dim num2 As Integer = hostAddresses.Length - 1
        Dim index As Integer = num1
        While index <= num2
            If hostAddresses(index).ToString().IndexOf(".", StringComparison.Ordinal) > 0 Then
                Return hostAddresses(index).ToString()
            End If
            index += 1

        End While
        Return "LOCAL"
    End Function

#Region "Auditoria Data Sensible"


    Private Delegate Sub InsertaAuditoriaDataSensible(ByVal objAuditoria As srvDataSensible.AuditoriaBE)

    Public Shared Function GuardarEventoDataRelevante(codigoSistema As String, codigoEvento As String, usuario As String, usuarioAccedido As String, estadoExito As String, mensaje As String, _
        excepcion As String) As RespuestaBE
        If codigoEvento.Contains("EVE") Then
            Return GuardarEventoAPP(EnumAuditoria.OUTSTANDING_DATA, excepcion, mensaje, usuario, String.Empty, codigoSistema, usuarioAccedido, codigoEvento, estadoExito)
        End If

        Return New RespuestaBE() With {.Mensaje = "Ingrese un código de evento correcto."}
    End Function

    Protected Shared Function GuardarEventoApp(tipoEvento As Integer, pExcepcion As String, ByRef pMensaje As String, usuario As String, otrosValores As String, codigoSistema As String, _
        usuarioAccedido As String, codigoEvento As String, estadoExito As String) As RespuestaBE
        Dim respuestaBe As New RespuestaBE()
        Dim objEventoBe As New AuditoriaBE()
        Try
            objEventoBe.CAPP_CODIGO = codigoSistema
            objEventoBe.NWEB_TIPO_EVENTO = tipoEvento
            objEventoBe.CWEB_EXCEPCION = If(pExcepcion IsNot Nothing, pExcepcion.Trim(), Nothing)
            If HttpContext.Current IsNot Nothing Then

                Dim ipAddress As String = HttpContext.Current.Request.Headers("X-Forwarded-For")
                If ipAddress = String.Empty Then
                    ipAddress = HttpContext.Current.Request.UserHostAddress
                End If

                objEventoBe.CWEB_IP = ipAddress
                objEventoBe.CWEB_REQUEST_URL = HttpContext.Current.Request.Url.AbsoluteUri
            Else
                Try
                    objEventoBe.CWEB_IP = GetIpAddress()
                    objEventoBe.CWEB_REQUEST_URL = ""
                Catch generatedExceptionName As Exception
                    objEventoBe.CWEB_IP = "LOCAL"
                    objEventoBe.CWEB_REQUEST_URL = "LOCAL"
                End Try
            End If
            objEventoBe.CWEB_MENSAJE = pMensaje
            objEventoBe.CWEB_USUARIO_CODIGO = usuario
            objEventoBe.CWEB_VALORES = otrosValores
            objEventoBe.CWEB_USUARIO_ACCEDIDO = usuarioAccedido
            objEventoBe.CEVE_CODIGO = codigoEvento
            objEventoBe.CAUDI_EST_EXITO = estadoExito
            Dim ejecutar As New InsertaAuditoriaDataSensible(AddressOf Insertar_AuditoriaDataSensible)
            ejecutar.BeginInvoke(objEventoBe, Nothing, Nothing)

        Catch ex As Exception
            respuestaBe.Mensaje = ex.Message
        End Try
        Return respuestaBe
    End Function

    Protected Shared Sub Insertar_AuditoriaDataSensible(ByVal objAuditoria As srvDataSensible.AuditoriaBE)
        Dim srvAuditoria As New srvDataSensible.AuditoriaClient
        srvAuditoria.GuardarAuditoria(objAuditoria)
    End Sub

    Public Shared Function EventosAplicacionListar(codigoSistema As String) As List(Of srvDataSensible.EventoAPP_BE)
        Dim srvAuditoria As New srvDataSensible.AuditoriaClient
        Return srvAuditoria.EventosAplicacionListar(codigoSistema)
    End Function



    Public Shared Function GuardarEventoLogin(codigoSistema As String, tipo As Integer, usuario As String, estadoExito As String, pExcepcion As String) As RespuestaBE
        Dim codigoEvento As String = String.Empty
        Dim pMensaje As String = String.Empty
        Select Case tipo
            Case EnumLogin.INGRESO
                codigoEvento = "EVE0000001"
                pMensaje = "INGRESO LOGIN."
                Exit Select
            Case EnumLogin.SALIDA
                codigoEvento = "EVE0000002"
                pMensaje = "SALIDA LOGIN."
                Exit Select
        End Select
        Return GuardarEventoApp(EnumAuditoria.LOGIN, pExcepcion, pMensaje, usuario, String.Empty, codigoSistema, String.Empty, codigoEvento, estadoExito)
    End Function

#End Region

    
End Class
Public Class EnumAuditoria
    Public Const LOGIN As Integer = 1
    Public Const FATAL_ERROR As Integer = 2
    Public Const INFORMATION As Integer = 3
    Public Const WARNING As Integer = 4
    Public Const OUTSTANDING_DATA As Integer = 5
End Class

Public Class EnumLogin
    Public Const INGRESO As Integer = 1
    Public Const SALIDA As Integer = 2
End Class