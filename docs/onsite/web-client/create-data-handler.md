---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: create_data_handler_for_web       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description:                    # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite           # cloud or onsite
so.client: web              # online, web, win, pocket, or mobile
---

# Data handlers

To have control over what happens when data is retrieved and stored from a page in web client, you will need to create your own data handler.

What data handlers to be used on a page is defined in the page configuration files. In this article we will continue where we left off in the last article with looking at the Sale page, and how to create our own data handler for adding more functionality to the Save button of the Sale page.

## Create a data handler class

The first thing you need to do is to create a new class that inherits SuperOffice.CRM.Web.Data.SaleDataHandler. If you take a look at the public methods you can override, you will see that there are methods for all the basic operations available to a SIX.web page: New, Load, Save, Delete, etc.

![Image001][img1]

For this exercise we will be using the Initialize and Save methods.

## Declare the Data Handler

To let SIX.web know about any of your own objects, you will need to define them in the SoObjectMapping.config file. The same goes for the new data handler:

```xml
<object type="IDataHandler" mappingname="DevNetSaleDataHandler" assemblyname="CustomizingSIXwebPart3" objectname="CustomizingSIXwebPart3.DevNetSaleDataHandler"</object>
```

## Use the Data Handler

To use the new data handler from the Sale page, we need to define it in the section of the SoSalePage.config file. We will replace the existing data handler of type SaleDataHandler with our own:

```xml
<page id="SaleDialog" >
  <title binding="resources">[SR_SDLG_CAPTION]</title>
  <data>
    <datahandlers>
      <datahandler id="EntityDataHandler" type="DevNetSaleDataHandler">
        <config>
          <completed-panelid>SalePanel</completed-panelid>
          <completed-cardid>SaleCard</completed-cardid>
        </config>
      </datahandler>
    </datahandlers>
  </data>
</page>
```

## Add Data Carriers

We need to override the Initialize method in order to add more data carriers to the data handler. The data carriers are, what the name implies, objects that hold any type of data: that could be just a simple data type like a string or an int, or a more complex one, like an array, generic list, or an instance of any class. In other words, the data carriers can carry any type of data. This data will be available to any of the controls that you add to the page that uses this data handler (when specified correctly in the page configuration file, mind you).

So if we continue with the two views that we added to the page in the last article, we will need a data carrier for each of the controls in these views.

```cpp
public override void Initialize(System.Xml.XmlNode config, string id)
{
    _dataCarriers.Add("ForeignKeyDeviceOne", null);
    _dataCarriers.Add("ForeignKeyDeviceTwo", null);
    base.Initialize(config, id);
}
```

The data carriers of a data handler are stored in the generic dictionary \_dataCarriers, coming from the DataHandlerBase class.

## Add Data Sources

The data carriers will work as the data sources for one or several of the controls that you have defined on your page.

To have the two controls we added last time use these data carriers as their data sources, we need to specify that in the following way:

```xml
<control id="DevNetDeviceOne" type="DevNetSaleForeignKeys" width="100%" top="0px" left="0px" height="100%" position="absolute">
  <datasource>EntityDataHandler.ForeignKeyDeviceOne</datasource>
  <config>
    <ForeignKeyDeviceId>DeviceOne</ForeignKeyDeviceId>
  </config>
</control>
```

and

```xml
<control id="DevNetDeviceTwo" type="DevNetSaleForeignKeys" width="100%" top="0px" left="0px" height="100%" position="absolute">
  <datasource>EntityDataHandler.ForeignKeyDeviceTwo</datasource>
  <config>
    <ForeignKeyDeviceId>DeviceTwo</ForeignKeyDeviceId>
  </config>
</control>
```

The EntityDataHandler is an instance of the data handler that we defined in the section above, and the names of the data sources need to match the ones we used when adding the data carriers inside the Initialize method. Note that EntityDataHandler matches the ID of the data handler defined for the page.

## Populate the Data Sources

So far the data carriers of the new data handler (and thus the data sources of our two controls) do not contain anything. The next thing we want to do is to populate them with some data.

There is a sample project that you can download for this article. Within this project you will find a class: `DevNetForeignKey`, that holds properties for everything we need to create a new Foreign Key for the sale.

If you take a look at the code behind for the `SaleForeignKeys` user control, you see that there is a private property of type `DevNetForeignKey` defined, and that this property is populated in the `Page_Load` method of the user control:

```cpp
private DevNetForeignKey _fk = new DevNetForeignKey();

protected void Page_Load(object sender, EventArgs e)
{
    // Get current sale ID

    _saleId = SuperStateManager.GetCurrent("sale").Id;

    if (_saleId > 0 && !String.IsNullOrEmpty(_fkDeviceId))
    {
        _fk.DeviceId = _fkDeviceId;
        _fk.RecordId = _saleId;

        // Get all foreign keys for current sale

        GetList();
    }
}
```

In order to populate the data source of the user control, we need to override the UpdateDataSource method, and set the DataSource of the base object to whatever we want it to be. In this case we want to set it to the just mentioned instance of the DevNetForeignKey class:

```cpp
public override void UpdateDataSource()
{
    base.DataSource = _fk;
    base.UpdateDataSource();
}
```

The UpdateDataSource of the base class needs to be called after you set the DataSource.

The UpdateDataSource method is called after `Page_Load`, so the DataSource will contain the object with the properties set from the `Page_Load`.

In addition to the data source of the user control now having an object assigned to it, the data carrier of the data handler will have access to the same object.

## Use the Data Carriers when Saving

The final goal of this exercise was to add new Foreign Keys to the current Sale. To add functionality to what happens when pressing the Save button in the Sale page, we need to override the Save method in the data handler:

```cpp
public override object Save()
{
    // Save the sale

    base.Save();

    SaleEntity saleEntity = (SaleEntity)_dataCarriers["SaleEntity"];

    if (saleEntity.SaleId > 0)
    {
        // Save foreign keys

        DevNetForeignKey devNetFkOne = (DevNetForeignKey)_dataCarriers["ForeignKeyDeviceOne"];
        DevNetForeignKey devNetFkTwo = (DevNetForeignKey)_dataCarriers["ForeignKeyDeviceTwo"];
        SaveForeignKey(devNetFkOne, saleEntity);
        SaveForeignKey(devNetFkTwo, saleEntity);
    }
}
```

In the Save method, we let the Sale page do its thing first by calling the base Save method. The data handler will implicitly contain a data carrier holding whatever entity you are working on – in this case a SaleEntity. If you were creating a new sale, the SaleEntity would have a value for SaleId after the base Save had completed.

The next thing we do is to use the two data carriers that we added to create two new Foreign Keys to the Sale.

The Foreign Keys will simply contain a key consisting of the current date and time, and the value will be the title and amount of the sale (see the DevNetForeignKey class in the project). So basically, it would be a log of changes made to the title and amount of a Sale.

The actual saving of the Foreign Keys is done in the SaveForeignKey method of the data handler, which uses the Services layer to add a new Foreign Key.

Here is the result of what we have gone through in this article:

![Image002][img2]

## Conclusion

In this article we have seen how to set up our own data handler for a page and then data sources for the controls in a page.

We have seen how data is passed from a custom user control to the custom data handler, and how we can extend the Save functionality of a page.
|
<!-- Referenced images -->
[img1]: media/image003.jpg
[img2]: media/image004.jpg