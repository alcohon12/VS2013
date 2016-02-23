Imports CGR.SERVICIOS.AUT
Imports CGR.SEGUR.DEMO01.srvSeguridad

Public Class sisValidaLogin
    Inherits System.Web.UI.Page
    Function ValidarLogin(ByVal usuario As String, ByVal CodigoAplicacion As String, ByRef respuesta As String) As Boolean

        Dim exito As Boolean = True
        Dim objUsu As UsuarioBE = Nothing


        Using srv As New srvSeguridad.SeguridadClient

            '3. Cargamos Objeto Usuario
            objUsu = srv.UsuarioSistemaObtener(usuario, Nothing, Nothing, CodigoAplicacion, usuario, WcfAutenticacion.GenerarToken)
            If objUsu Is Nothing Then
                Return Not exito
            End If

            '4. Cargamos la lista de Recursos
            Dim lstRecursos As New List(Of RecursoBE)
            Dim RolesUsuario As List(Of srvSeguridad.UsuarioRolBE) = objUsu.Roles

            Dim Token As String = WcfAutenticacion.GenerarToken

            Session("sisSesion.Roles") = objUsu.Roles
            Session("sisSesion.Usuario") = objUsu

            'En este ejemplo carga los Recursos de Acuerdo al Rol, podria darme que para algunos aplicativos
            'desea cargar todos los recurso, entonces no envie al serivicio el ROL, seria asi:
            Session("sisSesion.Recursos") = srv.UsuarioRecursoListar(objUsu.Codigo, CodigoAplicacion, "", "", "", "", "M", "", "", objUsu.Codigo, WcfAutenticacion.GenerarToken)

            'Obteniendo los menus por Rol
            Session("sisSesion.Menus") = srv.UsuarioRecursoListar(objUsu.Codigo, CodigoAplicacion, objUsu.Roles(0).RolCodigo, "", "", "", "M", "", "", objUsu.Codigo, WcfAutenticacion.GenerarToken)
            'Obtenemos los paginas por Rol
            Session("sisSesion.Forms") = srv.UsuarioRecursoListar(objUsu.Codigo, CodigoAplicacion, objUsu.Roles(0).RolCodigo, "", "", "", "P", "", "", objUsu.Codigo, WcfAutenticacion.GenerarToken)
            'Obtenemos los Botones por Rol
            Session("sisSesion.Botones") = srv.UsuarioRecursoListar(objUsu.Codigo, CodigoAplicacion, objUsu.Roles(0).RolCodigo, "", "", "", "B", "", "", objUsu.Codigo, WcfAutenticacion.GenerarToken)


            Dim obj As Object = Session("sisSesion.Recursos")

            obj = Session("sisSesion.Menus")

            obj = Session("sisSesion.Forms")

            obj = Session("sisSesion.Botones")

        End Using

        Return exito

    End Function
End Class
