---
title: pb_tutorial_sale_foreignkeys_1
description: How to create a user control
author: Steffan Alte
so.date: 07.25.2007
keywords:
so.topic: tutorial
so.client: web
so.envir: onsite
---

# How to create a user control

This is the first part of a 3-step tutorial. We will be taking a look at how to create a user control that is inherited from the SuperOffice SDK and then put it inside 2 new panels in the **Sale** dialog. The control will contain a datagrid that lists all foreign keys connected to a sale.

## Create a project

We start by creating a new web application project in Visual Studio.

1. Add the references to the SuperOffice framework. We will need references to:
    * SuperOffice.Core.dll
    * SuperOffice.CRMWeb.dll
    * SuperOffice.DCF.dll
    * SuperOffice.DCFWeb.dll
    * SuperOffice.Services.dll

2. Add a new web user control to your project, and name the control **SaleForeignKeys.ascx**.

## Inherit from UserControlBase

1. Enter the code of your new user control, and let the class of your user control inherit from **SuperOffice.CRM.Web.UI.Controls.UserControlBase**. This will give you access to a few new methods that you can override.

2. Override the `Initialize` method. It takes in an XML node as an argument and will contain the settings you have specified in the `config` section of the configuration file for the page in which the user control resides.

[!code-csharp[CS](includes/methods.cs?range=1-2,6,56)]

In the `Initialize` method, you can for example show or hide parts of your user control, or change the set of columns to be retrieved, or whatever you want. This lets you use the same user control for different purposes like to get data from the same tables, but with slightly different restrictions.

In our case, the 2 panels will use the same user control but show different data. We will do this by sending in a different value for the config setting that we define from the 2 panels.

We will return to the `Initialize` event later on after we have set up the control in the configuration file of the page where we want to use it.

## Declare the user control

The only way to let SuperOffice know about your user controls, and hence let you use them in existing or new pages, is by adding them to the [SoObjectMapping.config][1] file.

```xml
<object type="UserControl" 
        mappingname="DevNetSaleForeignKeys"
        assemblyname="CustomizingSIXwebPart2"
        objectname="~/DevNet/SaleForeignKeys.ascx">
</object>
```

## Use the controls

After you have declared your user control in *SoObjectMapping.config*, you are ready to use it on a new or existing page.

Remember, there is a pattern in how every page is built. You will need a page, one or more panels, one or more views, one or more controlgroups and one or more controls.

1. Open the *SoSalePage.config* file (since we will be adding 2 new views to the **Sales** dialog).
2. Go to the last view, copy that whole definition, and paste it once below.
3. Change the ID of the view so that it's unique within the page. Think of the IDs as variable names.
4. Change the soprotocol so that it's unique system-wide.
5. Now, copy your custom view, paste it below.
6. In your second view, replace the ID, soprotocol, and the config setting for the user control.

The final configuration of the 2 new views will look something like this:

[!code-xml[XML](includes/views.xml)]

The next thing you need to do is to add references to the new views in the `config` section **of the card where you defined the views**. This section has:

* **tabbedviews:** a section defining which views will be placed in separate tabs in a tab control
* **headerviews:**
* **footerviews:**

Here is the definition of the tabs in the **Sale** page after we have added the 2 new views:

```xml
<tabbedviews top="150px" bottom="60px">
  <viewref>SaleDetailsView</viewref>
  <viewref>SaleStatusView</viewref>
  <viewref>LinksArchive</viewref>
  <viewref>SaleMoreView</viewref>
  <viewref>WWWDialog</viewref>
  <viewref>DevNetDeviceOneView</viewref>
  <viewref>DevNetDeviceTwoView</viewref>
</tabbedviews>
```

If you do not add references to your views in one of the 3 sections listed above, they will simply not appear on the page.

Now you should be able to see 2 new tabs on the tab control of the **Sale** page:

![saledialog][img1]

## Add logic to the user control

Now let's move back to the user control and add some logic to it.

As you may have noticed in the previous section, we added one element in the config section of the control:

[!code-xml[XML](includes/views.xml?range=8-10)]

Every element you add to the config section of a control is available to you in the overridden `Initialize` method of a `UserControlBase` object. It will be passed in as the config argument to the method, which is of type **System.Xml.XmlNode**.

1. Add a **DataGrid** control to the user control, and name it *dgFkList*. This will be the control that holds the list of foreign keys that we will be retrieving.

    ```XML
    <asp:DataGrid ID="dgFkList" AutoGenerateColumns="false" runat="server">
      <Columns>
        <asp:BoundColumn DataField="key" HeaderText="Key" />
        <asp:BoundColumn DataField="value" HeaderText="Value" />
        <asp:BoundColumn DataField="createddate" HeaderText="Created" />
      </Columns>
    </asp:DataGrid>
    ```

2. Return to your override of the `Initialize` method and add the following logic to read the value of the key from the page configuration file and store it in a class variable:

    [!code-csharp[CS](includes/methods.cs?range=1-2,6-16)]

3. The `Initialize` method is fired **before** `Page_Load`, which is the event we will be looking at next. What we want to do here is to get the current Sale ID and populate the DataGrid. The [SuperStateManager][2] is a static object in CRM.web that keeps track of all the currents in the system, like current contact, current person, and current sale.

    [!code-csharp[CS](includes/methods.cs?range=18-27)]

    The `GetCurrent` method takes in a string saying what entity to get information from and returns a `HistoryItem`, which is transparent to what entity is returned and has properties like `Id` and `Name`.

    The returned sale ID is stored in a class variable for later use. It will be zero when opening the dialog for a new sale.

4. Finally, we populate the DataGrid when opening an existing sale from the `GetList` method:

    [!code-csharp[CS](includes/methods.cs?range=29-35)]

    The `GetDeviceKeysOnDeviceIdentifierTableRecordId` method lets you retrieve all foreign keys for an entity using the entity ID along with the Foreign Application and Device names and IDs.

> [!NOTE]
> You will have to create foreign key records for a sale before anything shows up in the list.

Here is finally a screenshot of the **Sale** page with a list of foreign keys showing in one of the tabbed views that we just added.

![Sale page][img2]

## Next step

In part 2 of this tutorial we will [create a data handler][3].

<!-- Referenced links -->
[1]: ../../pagebuilder/config/object-mapping.md
[2]: ../../pagebuilder/superstate/state-changes.md
[3]: 2-create-sale-datahandler.md

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
