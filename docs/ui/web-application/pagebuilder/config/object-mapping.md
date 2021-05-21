---
title: Object mapping files
uid: pagebuilder_config_objectmapping
description: Object mapping config files SoObjectMapping.config
author: Tony Yates
so.date: 06.24.2016
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# Object mapping files

Since all the rendering and building of a page in SuperOffice Web depends on XML configuration files, we need a mechanism to map the objects of the pages to the actual objects of the system. For example, in which assembly a particular control is taken from.

SoObjectMapping maps element types used in page configuration files to actual implementation classes defined in assemblies, such as user controls and web controls.

Below is an excerpt of an object mapping config file. We have cut out some parts to keep it reasonably short.

[!code-xml[XML](includes/soobjectmapping.xml)]

[!include[ALT](../includes/object-parameters.md)]

For example, the following line tells us the object that is represented by this line is referred to as *SoPanel* in other config files, resides in the *SuperOffice.CRMWeb* assembly, and is called `SuperOffice.CRM.Web.UI.Controls.Panel`.

[!code-xml[XML](includes/soobjectmapping.xml?range=3)]

When you have the mapping like this in a config file, it is very easy for a class factory to come in and use these configurations to build the actual objects. By using this method we can gain another advantage: we can very easily extend the object library and we can add customization versions very easily as well. The logic behind this is if the name of the object does not change, we can alter the behavior of the object and the PageBuilder framework will not know the difference.

## Explicit object mapping

The excerpt below declares an `SoPanel` type in *SoObjectMapping.config*. It states that the class `Panel` in the *SuperOffice.CRM.Web.UI.Controls* namespace, located in the *SuperOffice.CRMWeb* assembly is referenced by `mappingname` **SoPanel**.

Next, the file declares an `SoNavigatorButton` type. It states that a class `SoNavigatorButton` in the *SuperOffice.CRM.Web.UI.Controls* namespace, located in the *SuperOffice.CRMWeb* assembly is referenced by `mappingname` **SoNavigatorButton**.

```xml
<!-- SoObjectMapping.config -->
<objects>
  <object
    type="IPanel"
    mappingname="SoPanel"
    assemblyname="SuperOffice.CRMWeb"
    objectname="SuperOffice.CRM.Web.UI.Controls.Panel" />
  <object
    type="Control"
    mappingname="SoNavigatorButton"
    assemblyname="SuperOffice.CRMWeb"
    objectname="SuperOffice.CRM.Web.UI.Controls.SoNavigatorButton" />
</objects>
```

Looking at the *SoNavigatorPanel.config* file, the contents of which define all the navigator controls on the left side of SuperOffice is where the panel type declares the object `mappingname`, **SoPanel**. Additionally, nested deep in a card, view, controlgroup, and controls element is where several SoNavigatorButton types that represent the buttons in the panel are declared.

```xml
<!-- SoNavigatorPanel.config -->
<panel id="Navigator" type="SoPanel" paneltype="Navigator" ...>
...
  <control id="dashboardButton" type="SoNavigatorButton" >
  ...
  </control>
  ...
</panel>
```

## Implicit object mapping

An alternative approach to adding a type in the *SoObjectMapping.config* file is to in code decorate the class with the `SoWebObject` attribute, and inherit the **IWebObject** interface. The `IWebObject` doesn't contain any methods that must be implemented, it's only for discoverability purposes by the plugin system. The `SoWebObject` parameter becomes the mapping name used to reference the control in configuration files.

``` csharp
[SoWebObject("SoDialogSimpleCard")]
public class DialogSimpleCard :Card, IWebObject
{
  ...
}
```

### Applicable implicit types

|Type | Description |
|-----|-------------|
|AjaxMethods| Server-side web methods invoked by AjaxMethodDispatcher.CallSync\|CallAsync.|
|Control| AspNet web controls. |
|IArchiveAction|Runs when an archive control is selected|
|IArchiveControlDataFetcher|Use by SoArchive Control to invoke archive providers and return formatted results.|
|ICard|A layout control inside a panel.|
|IControlGroup|A layout control inside a view.|
|IDataHandler|Acts as a controller that loads data, populates view models, and saves changes. |
|IFilter | User to remove items from display output. `Filterbase` and `CustomCheckFilter`. |
|IMDOControlDataFetcher|Used by MDO Control to invoke MDO providers and return formatted results.|
|IPanel|A layout control inside a page.|
|IValidation|Used to validate a controls' state. |
|IView|A layout control inside a card.|
|IViewStateProvider| Used to get and set currents. |
|UserControl| AspNet user controls.|
