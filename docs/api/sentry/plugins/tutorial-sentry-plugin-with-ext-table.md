---
title: create_sentry_plugin
description: Sentry plugin with external table
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: guide
so.envir: onsite
---

# Sentry plugin with external table

In this tutorial, we will learn how to create a **custom table** that contains foreign keys to existing tables. We will also learn how to create a Sentry plug-in that enforces additional restrictions on the contact table.

The objective is to demonstrate how to control what the user is allowed to see. In this case, the user is only allowed to see contacts with a business type equal to that of the user’s company business type.

## Tables

The following diagram shows the relationship between the 3 tables namely contact, associate, and the custom table `superofficetrainingtable`.

![04][img1]

Let's begin!

## Create a custom table using Dictionary SDK

First, we focus on how to generate a table in the database using the Dictionary SDK.

To use the SODictionary SDK, *SODictionarySDK.dll* needs to be registered using regsvr32. The fil can be found in the SuperOffice installation directory.

> [!NOTE]
> It is important to make sure the correct values are set in the Admin client replication screen, because these values are used by the SODictionary whenever the manipulations are done in the database.

[!code-csharp[CS](includes/create-custom-table.cs)]

In the above code segment, we have created a `Dictionary` object, with the use of which a table is created in the database. Further, two foreign keys namely the associate ID and the business ID are created and the table names and the relationship multiplicity are specified.

## Generate user-defined table classes for use in NetServer

To access the new user-defined table (UDT) using NetServer, we are required to generate NetServer OSQL and Row types that define the UDT. These types are easily generated using the on-line code generator hosted on DevNet.

![05][img2]

When the code generation is complete, a Visual Studio solution with one project is created in the location specified by the user. This project contains 2 folders:

* A folder contains class files for supporting the data access layer
* A folder for supporting Rows

<!-- This utility application is available for download from DevNet. See <http://devnet.superoffice.com/Library/Articles/NetServer-SDK/Archived-Articles/Generate-User-Defined-Table-Classes-For-Use-in-NetServer/> for more information. -->

## Create the Sentry plugin

To begin creating a new Sentry plugin, you must create a class that inherits from and implements the `SuperOffice.CRM.Security.ISentryPlugin` interface.

In the plugin, it is required to access the generated NetServer classes for the UDT. To accomplish this, compile the code generation solution and add a reference to the DLL in the Plugin project.

[!code-csharp[CS](includes/custom-table-centry-plugin.cs)]

As we can see in the above code segment, we have created another class called `SentryPluginQueryTableUpdaterContact` which implements the `SuperOffice.CRM.Security.ISentryPluginQueryTableUpdater` interface. This interface has a single method called `ModifySelect` where we have implemented the sentry restriction to retrieve only the contact information where the Business-id of which is the same as the currently logged in user’s Business-id.

`TableInfo` objects are required for the tables of interest (the `Contact` table and `SuperOfficeTrainingTable`).

`ContactTableInfo` is retrieved by casting the `TableInfo` object passed to the `ModifySelect` method. Then the restriction is enforced to narrow the data selection to the current user’s business-id.

Finally, we have specified the join condition so that the custom table is joined in whenever the `Contact` table is queried upon.

We can see that we have marked this class as a `SentryPluginQueryTableUpdater` for the `Contact` table using attributes signaling NetServer that we have developed `SentryPluginQueryTableUpdater` for the `Contact` table. So whenever the `Contact` table is queried upon, this method will get fired.

## Using the Sentry plugin

To use the plugin, modifications are required in the config file signaling NetServer that we have our own plugin and mentioning where the DLL is located.

Below is the section that we have to modify in the *app.config* file.

```XML
<Factory>
  <DynamicLoad>
    <add key="SentryPlugin" value="C:\\AllBackups\\SuperOffice_Working_Files\\SentryForCustomTableDll\\SentryForCustomTableDll\\bin\\Debug\\SentryForCustomTableDll.dll"
/>
  </DynamicLoad>
</Factory>
```

The following code snippet is an example that uses the plugin. Here we attempt to retrieve the Contact information logging on with different users and outputting the list of contacts that each user can see.

[!code-csharp[CS](includes/use-custom-table-plugin.cs)]

We have first retrieved the `TableInfo` object for the Contact table.

Next, a `Select` object is created to retrieve data. The columns to be included in the selection and the order in which the results to be sorted are specified next. The select command is executed against the `Contact` table to retrieve the contact information. This is the point where our plugin comes into the picture: when we attempt to run a query against the `Contact` table, the NetServer sentry mechanism calls our sentry plugin and the plugin logic gets executed. With the restriction specified in the `ModifySelect` method of the plugin, any user can retrieve only the contact information where the BusinessId of which is the same as the currently logged in user’s BusinessId.

The next step is to convert the retrieved contact data into a format that can be displayed in a data grid. The approach taken in this example is to iterate over the retrieved `DataReader` and encapsulate those data into a custom object type called `ContactData`. These objects are stored in an `ArrayList`, which is set as the data source for the contact information data grid.

The following screenshots show the results of the same query run on the contact table for two users namely *SAL0* and *P*.

![06][img3]

![07][img4]

The sal0 user is restricted to a smaller subset of the contact table, due to the entries we put in the external table we have created.

<!-- ## Download

[Sentry Plugin With External Table Source Code (zip)](media/SentryPluginWithExternalTable.zip) -->

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/image004.gif
[img2]: media/image005.jpg
[img3]: media/image006.jpg
[img4]: media/image007.jpg
