﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace srvAuditoriaES
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="EventoBE", [Namespace]:="http://schemas.datacontract.org/2004/07/CGR.SEGUR.BE"),  _
     System.SerializableAttribute()>  _
    Partial Public Class EventoBE
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CAPP_CODIGOField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CWEB_EXCEPCIONField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CWEB_IPField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CWEB_MENSAJEField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CWEB_REQUEST_URLField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CWEB_USUARIO_CODIGOField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private CWEB_VALORESField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private NWEB_CODIGOField As Integer
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private NWEB_TIPO_EVENTOField As Integer
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CAPP_CODIGO() As String
            Get
                Return Me.CAPP_CODIGOField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CAPP_CODIGOField, value) <> true) Then
                    Me.CAPP_CODIGOField = value
                    Me.RaisePropertyChanged("CAPP_CODIGO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CWEB_EXCEPCION() As String
            Get
                Return Me.CWEB_EXCEPCIONField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CWEB_EXCEPCIONField, value) <> true) Then
                    Me.CWEB_EXCEPCIONField = value
                    Me.RaisePropertyChanged("CWEB_EXCEPCION")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CWEB_IP() As String
            Get
                Return Me.CWEB_IPField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CWEB_IPField, value) <> true) Then
                    Me.CWEB_IPField = value
                    Me.RaisePropertyChanged("CWEB_IP")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CWEB_MENSAJE() As String
            Get
                Return Me.CWEB_MENSAJEField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CWEB_MENSAJEField, value) <> true) Then
                    Me.CWEB_MENSAJEField = value
                    Me.RaisePropertyChanged("CWEB_MENSAJE")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CWEB_REQUEST_URL() As String
            Get
                Return Me.CWEB_REQUEST_URLField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CWEB_REQUEST_URLField, value) <> true) Then
                    Me.CWEB_REQUEST_URLField = value
                    Me.RaisePropertyChanged("CWEB_REQUEST_URL")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CWEB_USUARIO_CODIGO() As String
            Get
                Return Me.CWEB_USUARIO_CODIGOField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CWEB_USUARIO_CODIGOField, value) <> true) Then
                    Me.CWEB_USUARIO_CODIGOField = value
                    Me.RaisePropertyChanged("CWEB_USUARIO_CODIGO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property CWEB_VALORES() As String
            Get
                Return Me.CWEB_VALORESField
            End Get
            Set
                If (Object.ReferenceEquals(Me.CWEB_VALORESField, value) <> true) Then
                    Me.CWEB_VALORESField = value
                    Me.RaisePropertyChanged("CWEB_VALORES")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property NWEB_CODIGO() As Integer
            Get
                Return Me.NWEB_CODIGOField
            End Get
            Set
                If (Me.NWEB_CODIGOField.Equals(value) <> true) Then
                    Me.NWEB_CODIGOField = value
                    Me.RaisePropertyChanged("NWEB_CODIGO")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property NWEB_TIPO_EVENTO() As Integer
            Get
                Return Me.NWEB_TIPO_EVENTOField
            End Get
            Set
                If (Me.NWEB_TIPO_EVENTOField.Equals(value) <> true) Then
                    Me.NWEB_TIPO_EVENTOField = value
                    Me.RaisePropertyChanged("NWEB_TIPO_EVENTO")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="RespuestaBE", [Namespace]:="http://schemas.datacontract.org/2004/07/CGR.SEGUR.BE"),  _
     System.SerializableAttribute()>  _
    Partial Public Class RespuestaBE
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ListaRetornoField As System.Collections.Generic.List(Of srvAuditoriaES.GenericoBE)
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private MensajeField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private RespuestaField As Boolean
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ValorRertonoField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ListaRetorno() As System.Collections.Generic.List(Of srvAuditoriaES.GenericoBE)
            Get
                Return Me.ListaRetornoField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ListaRetornoField, value) <> true) Then
                    Me.ListaRetornoField = value
                    Me.RaisePropertyChanged("ListaRetorno")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Mensaje() As String
            Get
                Return Me.MensajeField
            End Get
            Set
                If (Object.ReferenceEquals(Me.MensajeField, value) <> true) Then
                    Me.MensajeField = value
                    Me.RaisePropertyChanged("Mensaje")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Respuesta() As Boolean
            Get
                Return Me.RespuestaField
            End Get
            Set
                If (Me.RespuestaField.Equals(value) <> true) Then
                    Me.RespuestaField = value
                    Me.RaisePropertyChanged("Respuesta")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ValorRertono() As String
            Get
                Return Me.ValorRertonoField
            End Get
            Set
                If (Object.ReferenceEquals(Me.ValorRertonoField, value) <> true) Then
                    Me.ValorRertonoField = value
                    Me.RaisePropertyChanged("ValorRertono")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="GenericoBE", [Namespace]:="http://schemas.datacontract.org/2004/07/CGR.SEGUR.BE"),  _
     System.SerializableAttribute()>  _
    Partial Public Class GenericoBE
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private DatoField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Dato() As String
            Get
                Return Me.DatoField
            End Get
            Set
                If (Object.ReferenceEquals(Me.DatoField, value) <> true) Then
                    Me.DatoField = value
                    Me.RaisePropertyChanged("Dato")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="srvAuditoriaES.IAuditoriaES")>  _
    Public Interface IAuditoriaES
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IAuditoriaES/GuardarEvento", ReplyAction:="http://tempuri.org/IAuditoriaES/GuardarEventoResponse")>  _
        Function GuardarEvento(ByVal objEventoBE As srvAuditoriaES.EventoBE) As srvAuditoriaES.RespuestaBE
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IAuditoriaES/ValidarSistema", ReplyAction:="http://tempuri.org/IAuditoriaES/ValidarSistemaResponse")>  _
        Function ValidarSistema(ByVal Tipo As String, ByVal CodigoAplicacion As String, ByVal IP As String, ByVal Clave As String) As srvAuditoriaES.RespuestaBE
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IAuditoriaES/ValidarPermisoServicio", ReplyAction:="http://tempuri.org/IAuditoriaES/ValidarPermisoServicioResponse")>  _
        Function ValidarPermisoServicio(ByVal tipo As String, ByVal codigoAplicacion As String, ByVal clave As String, ByVal IP As String, ByVal nombreServicio As String, ByVal nombreMetodo As String) As srvAuditoriaES.RespuestaBE
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IAuditoriaESChannel
        Inherits srvAuditoriaES.IAuditoriaES, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class AuditoriaESClient
        Inherits System.ServiceModel.ClientBase(Of srvAuditoriaES.IAuditoriaES)
        Implements srvAuditoriaES.IAuditoriaES
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function GuardarEvento(ByVal objEventoBE As srvAuditoriaES.EventoBE) As srvAuditoriaES.RespuestaBE Implements srvAuditoriaES.IAuditoriaES.GuardarEvento
            Return MyBase.Channel.GuardarEvento(objEventoBE)
        End Function
        
        Public Function ValidarSistema(ByVal Tipo As String, ByVal CodigoAplicacion As String, ByVal IP As String, ByVal Clave As String) As srvAuditoriaES.RespuestaBE Implements srvAuditoriaES.IAuditoriaES.ValidarSistema
            Return MyBase.Channel.ValidarSistema(Tipo, CodigoAplicacion, IP, Clave)
        End Function
        
        Public Function ValidarPermisoServicio(ByVal tipo As String, ByVal codigoAplicacion As String, ByVal clave As String, ByVal IP As String, ByVal nombreServicio As String, ByVal nombreMetodo As String) As srvAuditoriaES.RespuestaBE Implements srvAuditoriaES.IAuditoriaES.ValidarPermisoServicio
            Return MyBase.Channel.ValidarPermisoServicio(tipo, codigoAplicacion, clave, IP, nombreServicio, nombreMetodo)
        End Function
    End Class
End Namespace
