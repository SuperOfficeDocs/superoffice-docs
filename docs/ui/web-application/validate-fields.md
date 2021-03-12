---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: validate_fields_web       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Validation in SuperOffice WEB # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Henning Dahl
so.date: 09.28.2014
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Validation in SuperOffice WEB

Here is a guide on how you can validate fields in SuperOffice WEB and give the user a message if the validation rules kicks in. This stops the user for saving an entity.

In this example, I will create a validation rule that a sale must have a project. If the sale is missing a project, the user will not be able to save the sale and the user will get a message that the sale is missing project.

## Steps

1. Create a DLL file with the code for validation rules
2. Create a custom-path
3. Edit *web.config* file
4. Edit *SoSaleMainViewView.config*

## Create validation.dll

1. Create a new Visual Studio project and use **Class Library** template from Visual Basic Templates.
2. Add reference to *SuperOffice.Services.dll* located in your SuperOffice *web\\bin* folder.
3. Add two vb classes named `ValidationRules.vb` and `ValidationControl.vb`.

**Code for ValidationControl.vb:**

```vb
<SuperOffice.DCF.Web.Factory.SoWebObject("ValidationControl")>
Public Class ValidationControl
    Inherits SuperOffice.DCF.Web.UI.Controls.ControlBase
    Implements SuperOffice.DCF.Web.Factory.IWebObject

    Private validated As Boolean = False

    Protected Overrides Sub OnLoad(e As EventArgs)
        AddHandler Page.PreRender, AddressOf page\_PreRender2
    End Sub

    Protected Sub page\_PreRender2(sender As Object, e As System.EventArgs)
        If (validated And (Not IsValid)) Then
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "SOValidation", String.Format("Dialog.Information('Validation','{0}', 'Info');", Tooltip), True)
        End If
    End Sub

    Public Overrides ReadOnly Property IsValid As Boolean
        Get
            validated = True
            Return MyBase.IsValid
        End Get
    End Property
End Class
```

**Code for ValidationRules.vb:**

```vb
<SuperOffice.DCF.Web.Factory.SoWebObject("ValidationRules")>
    Public Class ValidationRules
    Inherits SuperOffice.DCF.Web.UI.Validations.ValidationBase
    Implements SuperOffice.DCF.Web.Factory.IWebObject

    Protected Overrides Function \_validate(value As Object, ByRef validationMessage As String) As Boolean
        validationMessage = ""
        Dim status As Boolean
        status = True
        Dim salent As SuperOffice.CRM.Services.SaleEntity
        salent = value

        If Not IsNothing(salent) Then
            If Not salent.Associate.AssociateId = SuperOffice.SoContext.CurrentPrincipal.AssociateId Then
                salent.Associate.AssociateId = SuperOffice.SoContext.CurrentPrincipal.AssociateId
            End If

            If salent.Project.ProjectId < 1 Then
                validationMessage = "Project can not be empty!"
                status = False
            Else
                status = True
            End If
        End If
        Return status
    End Function
End Class
```

Compile your project.

## Create Custom Path

In SuperOffice WEB we can use a Custom Path that will override settings in SuperOffice Web. In this case, we need to modify a file for the sale card in SuperOffice. If we do an upgrade this modification will be lost. This we can avoid with the use of a custom path. Custom path is simply a folder that we points to in web.config. I have created a folder called *SO\_WEB\_CUSTOMPATH\_VALIDATION*

Inside *SO\_WEB\_CuSTOMPATH\_VALIDATION* you need to create a folder called *WebClient* and *bin*.

Inside *WebClient* create a folder called *Web* and inside *Web* create a folder called *Sale*.

Copy the file *SoSaleMainViewView.config* from the *SuperOffice WEB\\App\_Data\\WebClient\\Web\\Sale* folder to *SO\_WEB\_CuSTOMPATH\_VALIDATION\\ WebClient\\Web\\Sale* folder.

Copy your compiled Validation.dll to the SO\_WEB\_CUSTOMPATH\_VALIDATION\\bin folder.

### Edit web.config

We need to tell SuperOffice WEB that we have a Custom Path and a new validation.dll to load. Add the following key in the `DynamicLoad` section in SuperOffice *web.config* file:

```xml
<add key="Validation" value="C:\\SuperOffice\\SuperOffice75\\SO\_WEB\_CUSTOMPATH\_VALIDATION\\bin\\Validation.dll" />
```

Add the following Key to `ClientConfigurationProviders` section:

```xml
<add key="CustomPath" value="C:\\SuperOffice\\SuperOffice75\\SO\_WEB\_CUSTOMPATH\_VALIDATION" />
```

### Edit SaleMainViewView.config

In your *SO\_WEB\_CUSTOMPATH\_VALIDATION\\WebClient\\Web\\Sale\\SaleMainViewView.config* add the following in the `<controlgroup id="SaleMainDetailsGroup" type="SoControlGroup">` section:

```xml
<!--VALIDATIONRULE-->
<control id="AlwaysShowErrorId" type="ValidationControl">
<datasource>EntityDataHandler.SaleEntity</datasource>
<validations>
<validation id="AlwaysShowError" type="ValidationRules"></validation>
</validations>
</control>
<!--END VALIDATIONRULE-->
```

If you log in, try to create a new sale, and do not select a project you will see that you cannot save the sale. You will get the following message:

![message][img1]

You can use this method on every entity in SuperOffice by editing the config files and add rules to your DLL file.

<!-- Referenced images -->
[img1]: media/7237_12447.jpg
