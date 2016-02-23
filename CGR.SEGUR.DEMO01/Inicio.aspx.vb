Imports CGR.SERVICIOS.AUT
Imports Owasp.Esapi
Imports CGR.SEGUR.DEMO01.srvAuditoriaES

Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            IniciarSistema()


            'vicente




        End If
    End Sub
    Private Sub IniciarSistema()
        If AplicacionValidar() Then
            'Redireccionamos a la pagina que muestra el menu del sistema implementado
            Response.Redirect("wfMenu.aspx", True)
        Else
            'Redireccionamos a la pagina de Login Unico de SSNET
            Dim url As String = ConfigurationManager.AppSettings("URL_PAG_INICIO")
            Response.Redirect(url, True)
        End If
    End Sub

    Private Function AplicacionValidar() As Boolean

        Dim exito As Boolean = False
        Try
            Dim oAutenticacion As New WcfAutenticacion
            Dim oToken As New ObjetoToken
            Dim oRespuesta As New RespuestaBE
            Dim CodigoUsuario, CodigoAplicacion As String

            'Importante: Captura el token Enviado desde el Login unico de SSNET
            sisAuditoria.GuardarEvento(EnumAuditoria.FATAL_ERROR, "Error en la función AplicacionValidar", "", "Token")
            oToken.Token = Request.QueryString("token")
            If String.IsNullOrEmpty(oToken.Token) Then
                Return False
            End If

            Dim data As String() = oToken.Token.Split("|")

            'Valida Token enviado
            oRespuesta.Mensaje = WcfAutenticacion.ValidarTokenLogin(oToken)

            If Not String.IsNullOrEmpty(oRespuesta.Mensaje) Then
                exito = True
            End If
            CodigoUsuario = oRespuesta.Mensaje
            CodigoAplicacion = Mid(Esapi.Encryptor.Decrypt(data(0)), 2, 10)


            'Instanciamos una clase intermedia
            Dim oValidarAcceso As New sisValidaLogin
            Dim respuesta As String = ""

            If Not oValidarAcceso.ValidarLogin(CodigoUsuario, CodigoAplicacion, respuesta) Then
                Return exito
            End If
        Catch ex As Exception
            sisAuditoria.GuardarEvento(EnumAuditoria.FATAL_ERROR, "Error en la función AplicacionValidar", ex.Message.ToString, "Token")
            Return False
        End Try
        Return exito
    End Function


End Class