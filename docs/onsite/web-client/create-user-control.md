---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: create_user_control       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Create a user control # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite            # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Create a user control

In addition to customizing the existing pages in CRM web you can of course create new ones. The pages you create can contain any ASP.NET controls, but to be able to tap into the rest of CRM web you will need to inherit from the CRM web controls.

Here we will create a user control that will be put inside a new panel in the Sale dialog. The control will contain a datagrid that lists all foreign keys connected to a sale.

## Create a Project

We start by creating a new web application project in Visual Studio.

First, add the references to the CRM web framework. We recommend using the [SuperOffice.CRM.Web nuget package][1].

Add a new web user control to your project, and name the control *SaleForeignKeys.ascx*.

## Inherit from CRM web

Enter the code behind of your new user control, and have the class of your user control inherit

`SuperOffice.CRM.Web.UI.Controls.UserControlBase`. This will give you access to a few new methods that you can override.

The next thing we want to do is to override the `Initialize` method. This method takes in an XML node as an argument, and will contain the settings you have specified in the section of the configuration file for the page in which the user control resides.

```csharp
public override void Initialize(XmlNode config, string id)
{
    base.Initialize(config, id);
}
```

In the `Initialize` method, you can e.g. show or hide parts of your user control, or change the set of columns to be retrieved, or whatever you want. This lets you use the same user control for different purposes, when e.g. getting data from the same tables, but with slightly different restrictions.

Like in our case we will have two panels that use the same user control, but with different data to be shown. We will do this by sending in a different value for the config setting that we define from the two panels.

We will return to the Initialize event later on after we have set up the control in the configuration file of the page where we want to use it.

## Declare the user control

There are two ways to let CRM web know about your user controls. The first way to to add the control declaration to the SoObjectMapping.config page. The second way is to make the control known by the application by decorating the control with the SoWebObject attribute and inheriting the IWebObject interface.

When using the code-only approach, you do not need to make any modifications to config or merge files. The application will discover the control at runtime and use it when a page configuration refers to the control type.

When adding the control to the SoObjectMapping.config file, it is always a good idea to put your modifications at the end of this file, and also add a comment letting other developers know that this is not a part of the standard installation. Alternatively, use a [merge file to deploy][2] modifications.

```xml
<object type="UserControl" mappingname="DevNetSaleForeignKeys" assemblyname="CustomizingSIXwebPart2" objectname="~/DevNet/SaleForeignKeys.ascx"></object>

```

Another thing that is good practice is to always put your own controls (and other files) in separate folders instead of mixing them up with the installed files. This makes life a lot easier when upgrading CRM web down the road.

## Use the user control

After you have declared your user control in SoObjectMapping.config, or decorated the class with SoWebObject and inherited from IWebObject interface, you are ready to use it in a new or existing page.

We will be adding two new views to the Sales dialog, so let’s open the SoSalePage.config file. As you may remember from the last article, there is a pattern in how every page is built. You will need a page, one or more panels, one or more views, one or more control groups and one or more controls.

We want to place two new views after the existing ones, so let’s go to the last view, and just copy that whole definition and paste it once. We have to change the id of the view, as the id needs to be unique from within the page. Think of the ids as variable names. The soprotocol also needs to be unique, and this needs to be unique system wide. With that in mind, it is always a good idea to name the soprotocols for your own views, controls, etc with a specific prefix, so that they do not interfere with existing SIX.web soprotocols.

After you have added one view, you can just copy and paste that one, and simply replace the ids, soprotocol and finally the config setting for the user control.

The final configuration of the two new views will look like this:

```xml
<view id="DevNetDeviceOneView" type="SoDialogView" soprotocol="devnetdeviceone">
  <caption>Device One</caption>
  <tooltip></tooltip>
  <controlgroups>
    <controlgroup id="DevNetDeviceOneControlGroup" type="SoControlGroup" position="absolute" top="0px" bottom="0px" left="0px" right="0px" >
      <controls>
        <control id="DevNetDeviceOne" type="DevNetSaleForeignKeys" width="100%" top="0px" left="0px" height="100%" position="absolute">
          <config>
            <ForeignKeyDeviceId>DeviceOne</ForeignKeyDeviceId>
          </config>
        </control>
      </controls>
    </controlgroup>
  </controlgroups>
</view>
 
<view id="DevNetDeviceTwoView" type="SoDialogView" soprotocol="devnetdevicetwo">
  <caption>Device Twocaption</caption>
  <tooltip></tooltip>
  <controlgroups>
    <controlgroup id="DevNetDeviceTwoControlGroup" type="SoControlGroup" position="absolute" top="0px" bottom="0px" left="0px" right="0px">
      <controls>
        <control id="DevNetDeviceTwo" type="DevNetSaleForeignKeys" width="100%" top="0px" left="0px" height="100%" position="absolute">
          <config>
            <ForeignKeyDeviceId>DeviceTwo</ForeignKeyDeviceId>
          </config>
        </control>
      </controls>
    </controlgroup>
  </controlgroups>
</view>
```

The next thing you need to do is to add references to the new views in the <>config> section of the where you defined the views. The config section of a card has a section defining which views will be placed in separate tabs in a tab control; . Similarly, there is also a and a config section.

Here is the definition of the tabs in the sale page after we have added the two new views:

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

If you do not add references to your views in , or , they will simply not appear on the page.

Now you should be able to see two new tabs on the tab control of the sale page:

![x][img1]

## Add logic to the user control

Now let’s move back to the user control and add some logic to it. First, add a DataGrid control to the user control, and name it dgFkList. This will be the control that holds the list of foreign keys that we will be retrieving.

```xml
<DataGrid ID="dgFkList" AutoGenerateColumns="false" runat="server">
  <BoundColumn DataField="key" HeaderText="Key" />
  <BoundColumn DataField="value" HeaderText="Value" />
  <BoundColumn DataField="createddate" HeaderText="Created" />
</DataGrid>
```

As you may have noticed in the previous section, we added one element in the config section of the control:

```xml
<config>
  <ForeignKeyDeviceId>DeviceOne</ForeignKeyDeviceId>
</config>
```

Every element you add to the config section of a control is available to you in the overridden Initialize method of a UserControlBase object. It will be passed in as the config argument to the method, which is of type System.Xml.XmlNode.

What we want to do here is simply to read out the value of the key from the page configuration file and store it in a class variable:

```cpp
public override void Initialize(XmlNode config, string id)
{
    base.Initialize(config, id);

    System.Xml.XmlNode node = config.SelectSingleNode("ForeignKeyDeviceId");

    if (node != null && !String.IsNullOrEmpty(node.InnerText))
    {
        _fkDeviceId = node.InnerText;
    }
    else
    {
        throw new SystemException("Missing Foreign Key Device Id");
    }
}
```

The `Initialize` method is fired before `Page_Load`, which is the next event we will be looking at next. What we want to do here is to get the current Sale ID and populate the DataGrid. The `SuperStateManager` is a static object in web client that keeps track of all the “currents” in the system, like current contact, current person, current sale, etc.

Here it is:

```cpp
protected void Page_Load(object sender, EventArgs e)
{
    // Get current sale ID
    _saleId = SuperOffice.DCF.Web.SuperStateManager.GetCurrent("sale").Id;

    if (_saleId > 0)
    {
        // Get all foreign keys for current sale
        GetList();
    }
}
```

So the GetCurrent method of the SuperStateManager takes in a string saying what entity you want to get information from. The method returns a HistoryItem, which is transparent to what entity is actually returned, and has properties like Id and Name.

The sale id returned is stored in a class variable for later use. The sale id will be zero when opening the dialog for a new sale.

Finally, we populate the DataGrid when opening an existing sale from the GetList method;

```cpp
private void GetList()
{
    using (ForeignSystemAgent agent = new ForeignSystemAgent())
    {
        ForeignKey[] fks = agent.GetDeviceKeysOnDeviceIdentifierTableRecordId("DevNet", "Demo", _fkDeviceId, "sale", _saleId);
        dgFkList.DataSource = fks;
        dgFkList.DataBind();
    }

}
```

The GetDeviceKeysOnDeviceIdentifierTableRecordId method is new in NetServer 3, and will let you retrieve all Foreign Keys for an entity using the entity id along with the Foreign Application and Device names and ids.

You will have to create Foreign Key records for a sale to actually get anything showing up in the list. This is actually an exercise for the next article, but to give you a head-start, here are some lines of code that will insert records in the tables needed for something to show up in the control;

```cpp
using (ForeignSystemAgent agent = new ForeignSystemAgent())
{
    ForeignKey key = new ForeignKey();
    key.Key = "testKey1";
    key.Value = "testValue123";
    key.RecordId = _saleId;
    key.TableName = "sale";

    agent.SaveForeignKey(key, "DevNet", "Demo", _fkDeviceId);
}
```

Here is finally a screenshot of the sale page with a list of foreign keys showing in one of the tabbed views that we just added:

![x][img2]

## Conclusion

In this article we have taken a look at how to create a user control that inherits from SIX.web and thereby taps into the context of the SIX.web application directly, giving you access to everything that the standard SuperOffice user control has access to. We saw how to set up the user control in a new view in an existing page, and how you can easily configure your user control by using the configuration section for the control in the page configuration file.

In the next article we will take a look at how you can create your own data handlers, and we will be creating a new Sales data handler to be used in the Sales dialog to create new foreign keys when pressing the Save-button.

<!-- Referenced links -->
[1]: https://www.nuget.org/packages/SuperOffice.Crm.Web/
[2]: https://community.superoffice.com/en/content/content/webclient/customization-and-deployment/

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg