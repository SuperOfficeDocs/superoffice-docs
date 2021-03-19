---
title: pb_tutorial_sale_foreignkeys_3
description: Create custom MDO controls
author: Steffan Alte
so.date: 07.25.2007
keywords:
so.topic: tutorial
so.client: web
so.envir: onsite
---

# Create custom MDO controls

You can create your own MDOs containing anything, whether that would be static data, data from another system, or specific data from Superoffice.

This is step 3 of the SaleForeignKey tutorial and builds on the [sale data handler we created in part 2][2].

## Create an MDO provider plugin

The first thing we are going to start with is to create a class that will fill the MDO with data. Just add a new class to your project, add the `MDOProviderPlugin` attribute to it, and inherit `SuperOffice.CRM.Lists.LiteralsOnlyBase`

[!code-csharp[CS](includes/testprovider.cs?range=1-4,6)]

The name you pass into the attribute will be what you use to reference the class later from the MDO control itself.

To add items, override the protected `AddItems` method:

[!code-csharp[CS](includes/testprovider.cs?range=5-10)]

The `RawRootItems` collection contains `SoListItem` objects, which contain an ID, a name, a tooltip string, and so on.

## Create an MDO control

Create a new web user control, and make sure it inherits `SuperOffice.CRM.Web.UI.Controls.UserControlBase`. To be able to add an MDO control, we need to register the `SuperOffice.CRM.Web.UI.Controls` namespace in the markup:

```XML
<%@ Register Assembly="SuperOffice.CRMWeb" Namespace="SuperOffice.CRM.Web.UI.Controls" TagPrefix="six" %>
```

Then you will be able to add any of the CRM.web controls to your ASCX (or ASPX) by referring to them as `<six:` and then the name of the control you want to use.

Add an MDOControl, and use the name you provided for the `MDOProviderPlugin` attribute of the class you just built;

```XML
<six:MDOControl ID="mdoTest" ListName="DevNetTestList" EditMode="true" Width="100px" runat="server" />
```

Make sure that you set the `EditMode` attribute to "true", or you will not be able to access the control.

> [!NOTE]
> A useful feature of the MDO control is that you can use any of the list tables, such as the `business` table, as the source for an MDO control. So simply by saying `ListName="business"`, the control will be populated with the contents of the `business` table.

## Add the MDO control to a page

Now we are ready to add the user control to a page. You will need to define the user control in the *SoObjectMapping.config* file:

```XML
<object type="UserControl"
        mappingname="DevNetTestMDO"
        assemblyname="CustomizingSIXwebPart4"
        objectname="~/DevNet/testMDO.ascx">
</object>
```

Then add the control to a page:

```XML
<control id="DevNetMDOControl"
         type="DevNetTestMDO"
         width="100%" top="0px" left="0px" height="100%" position="absolute" >
</control>
```

Now you should be able to see the contents of your MDO control

![03][img1]

Searching works:

![04][img2]

## Add some logic

OK, so now we can show our MDO control, and it works like expected. But to have any use of such a control, you would want to grab the selected value of the control at some point and use it in some way.

This can be accomplished by [adding your data handler][1]. To recap:

1. Add a new class that inherits `SuperOffice.CRM.Web.Data.SaleDataHandler` (when working with sales).
2. Add a data carrier from the overridden `Initialize` method.
3. Declare the data handler in the *SoObjectMapping* file.
4. Add the new data handler to the page.

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
<object type="IDataHandler"
        mappingname="DevNetSaleDataHandler"
        assemblyname="CustomizingSIXwebPart4"
        objectname="CustomizingSIXwebPart4.AnotherSaleDataHandler">
</object>
```

```xml
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

When running the application, you will see that the value of the selected MDO item is passed from your user control to your data handler:

![05][img3]

Thanks to Arild Eik at Intero for providing useful input for this tutorial!

<!-- Referenced links -->
[1]: 2-create-sale-datahandler.md
[2]: ../../pagebuilder/config/object-mapping.md

<!-- Referenced images -->
[img1]: media/image003.jpg
[img2]: media/image004.jpg
[img3]: media/image005.jpg
