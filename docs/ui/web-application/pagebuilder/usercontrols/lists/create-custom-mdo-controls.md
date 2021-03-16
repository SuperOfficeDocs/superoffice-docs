---
title: create_custom_mdo_controls
description: Create custom MDO controls
author: Steffan Alte
so.date: 2007
keywords:
so.topic: tutorial
so.client: web
so.envir: onsite
---

# Create custom MDO controls

You can create your own MDOs containing anything, whether that would be static data, data from another system, or specific data from Superoffice.

## Create an MDO provider plugin

The first thing we are going to start with is to create a class that will fill the MDO with data. Just add a new class to your project, add the `MDOProviderPlugin` attribute to it, and inherit `SuperOffice.CRM.Lists.LiteralsOnlyBase`

```csharp
[MDOProviderPlugin("DevNetTestList")]
public class testProvider : SuperOffice.CRM.Lists.LiteralsOnlyBase
{

}
```

The name you pass into the attribute will be what you use to reference the class later from the MDO control itself.

To add items, override the protected `AddItems` method:

```csharp
protected override void AddItems()
{
  base.RawRootItems.Add(new SoListItem(1, "First item", "This is the first item", String.Empty));
  base.RawRootItems.Add(new SoListItem(2, "Second item", "This would be the second item", String.Empty));
  base.RawRootItems.Add(new SoListItem(3, "Third item", "This is the third and last item", String.Empty));
}
```

The `RawRootItems` collection contains `SoListItem` objects, which contain an id, a name, a tooltip string, and so on.

## Create an MDO control

Create a new web user control, and make sure it inherits `SuperOffice.CRM.Web.UI.Controls.UserControlBase`. To be able to add an MDOControl, we need to register the `SuperOffice.CRM.Web.UI.Controls` namespace in the markup:

```XML
<%@ Register Assembly="SuperOffice.CRMWeb" Namespace="SuperOffice.CRM.Web.UI.Controls" TagPrefix="six" %>
```

Then you will be able to add any of the CRM.web controls to your ASCX (or ASPX) by referring to them as <six: and then the name of the control you want to use.

Add an MDOControl, and use the name you provided for the `MDOProviderPlugin` attribute of the class you just built;

```XML
<six:MDOControl ID="mdoTest" ListName="DevNetTestList" EditMode="true" Width="100px" runat="server" />
```

Make sure that you set the `EditMode` attribute to "true", or you will not be able to access the control.

> [!NOTE]
> A useful feature of the MDOControl is that you can use any of the "list tables", such as the `business` table, as the source for an MDOControl. So simply by saying ListName="business", the control will be populated with the contents of the business table.

## Add the MDO control to a page

Now we are ready to add the user control to a page. You will need to define the user control in the *SoObjectMapping.config* file:

```XML
<object type="UserControl" mappingname="DevNetTestMDO" assemblyname="CustomizingSIXwebPart4" objectname="~/DevNet/testMDO.ascx"></object>
```

Then add the control to a page;

```XML
<control id="DevNetMDOControl" type="DevNetTestMDO" width="100%" top="0px" left="0px" height="100%" position="absolute" >
</control>
```

Now you should be able to see the contents of your own MDO control

![03][img1]

Searching works:

![04][img2]

## Add some logic

OK, so now we are able to show our own MDO control, and it works like expected. But to have any use of such a control, you would want to grab the selected value of the control at some point and use it in some way.

This can be accomplished by [adding your own data handler][1]. To recap:

1. Add a new class that inherits `SuperOffice.CRM.Web.Data.SaleDataHandler` (when working with sales)
2. Add a data carrier from the overridden `Initialize` method
3. Declare the data handler in the *SoObjectMapping* file
4. Add the new data handler to the page

```csharp
public class AnotherSaleDataHandler : SuperOffice.CRM.Web.Data.SaleDataHandler
{
  public override void Initialize(System.Xml.XmlNode config, string id)
  {
    _dataCarriers.Add("SelectedMDOItem", null);
    base.Initialize(config, id);
  }
}
```

```XML
<object type="IDataHandler" mappingname="DevNetSaleDataHandler" assemblyname="CustomizingSIXwebPart4" objectname="CustomizingSIXwebPart4.AnotherSaleDataHandler"></object>

<datahandler id="EntityDataHandler" type="DevNetSaleDataHandler">
```

Now your page uses the new data handler, you can update the data carrier with the value of the selected item from your MDO control. Do this by overriding the `UpdateDataSource` method from the user control where you have your MDO control:

```csharp
public override void UpdateDataSource()
{
  base.DataSource = mdoTest.SelectedId;
  base.UpdateDataSource();
}
```

Then you can add some logic to the `Save` method of your data handler:

```csharp
public override void Save()
{
  base.Save();

  int selectedMdoItem = (int)_dataCarriers["SelectedMDOItem"];
  // Do something useful with the value ;)
}
```

When running the application, you will see that the value of selected MDO item is passed from your user control to your data handler:

![05][img3]

## Conclusion

The main point to take away from this tutorial is that you can extend and use the controls that are available to you in the CRM.web framework along with NetServer to build functionality that suits your purpose.

<!-- In this article we got acquainted with providers, and the next article will take a closer look at ArchiveProviders.. -->

***

Thanks to Arild Eik at Intero for providing useful input for this tutorial!

<!-- Referenced links -->
[1]: ../../../tutorials/datahandlers.md

<!-- Referenced images -->
[img1]: media/image003.jpg
[img2]: media/image004.jpg
[img3]: media/image005.jpg
