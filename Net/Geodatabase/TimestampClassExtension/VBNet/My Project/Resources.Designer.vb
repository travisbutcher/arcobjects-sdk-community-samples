﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Timestamper.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to CREATED.
        '''</summary>
        Friend ReadOnly Property CreatedFieldKey() As String
            Get
                Return ResourceManager.GetString("CreatedFieldKey", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Created.
        '''</summary>
        Friend ReadOnly Property DefaultCreatedField() As String
            Get
                Return ResourceManager.GetString("DefaultCreatedField", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Modified.
        '''</summary>
        Friend ReadOnly Property DefaultModifiedField() As String
            Get
                Return ResourceManager.GetString("DefaultModifiedField", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to UserName.
        '''</summary>
        Friend ReadOnly Property DefaultUserField() As String
            Get
                Return ResourceManager.GetString("DefaultUserField", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Could not save extension properties. Failed to acquire an exclusive lock..
        '''</summary>
        Friend ReadOnly Property FailedToSavePropertiesMsg() As String
            Get
                Return ResourceManager.GetString("FailedToSavePropertiesMsg", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to MODIFIED.
        '''</summary>
        Friend ReadOnly Property ModifiedFieldKey() As String
            Get
                Return ResourceManager.GetString("ModifiedFieldKey", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to An error occurred while trying to modify the timestamp fields:.
        '''</summary>
        Friend ReadOnly Property PropertyPageApplyErrorMsg() As String
            Get
                Return ResourceManager.GetString("PropertyPageApplyErrorMsg", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Timestamp Settings.
        '''</summary>
        Friend ReadOnly Property PropertyPageTitle() As String
            Get
                Return ResourceManager.GetString("PropertyPageTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Timestamped Class.
        '''</summary>
        Friend ReadOnly Property TimestampedClassName() As String
            Get
                Return ResourceManager.GetString("TimestampedClassName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to USERNAME.
        '''</summary>
        Friend ReadOnly Property UserFieldKey() As String
            Get
                Return ResourceManager.GetString("UserFieldKey", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
