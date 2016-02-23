Imports CGR.SEGUR.DEMO01.srvSeguridad
Public Class wfMenu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim objUsu As UsuarioBE = CType(Session("sisSesion.Usuario"), UsuarioBE)
        If Not Page.IsPostBack Then
            menuSalir_item1.NavigateUrl = SalirAccesosSistemaCGR( _
            ConfigurationManager.AppSettings("URL_PAG_INICIO").Replace("Index.aspx", "frmListaAplicaciones.aspx"), _
            ConfigurationManager.AppSettings("WcfUsuarioAUT"), _
             objUsu.Codigo, _
            ConfigurationManager.AppSettings("WcfTipoCLAVE"), _
            ConfigurationManager.AppSettings("WcfClaveAUT"))
        End If

    End Sub
    Private Function SalirAccesosSistemaCGR(ByVal Url As String, ByVal CodigoAplicacion As String, _
                                          ByVal CodigoUsuario As String, ByVal Tipo As String, _
                                          ByVal Clave As String) As String
        Dim token As String = CGR.SERVICIOS.AUT.WcfAutenticacion.GenerarToken(CodigoAplicacion, CodigoUsuario, Tipo, Clave)
        Url = Url + "?token=" + HttpUtility.UrlEncode(token)
        Return Url
    End Function
End Class