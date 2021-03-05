---
title: datahandler_add
description: Adding a custom DataHandler
author: Tony Yates
so.date: 06.24.2016
keywords:
so.topic: howto
so.client: web
so.envir: onsite
---

# Adding a custom DataHandler

The DataHandler that we are going to add is called **MyDataHandler**, which is used to display the current date and time on the Company’s Interests view.

To create our own handler, we need to create a class library project. When creating the class library project, it is necessary to remember that we are required to add the necessary references that we plan to use.

## Create the DataHandler

The following code is an example of a custom data DataHandler.

[!code-csharp[CS](includes/mydatahandler.cs)]

Here we have created a custom DataHandler by using the `DataHandlerBase` class which is located in the *SuperOffice.CRM.Web.Data* namespace. Since we are inheriting from the base class, we can override all its virtual methods and create our own custom data handler with the overrides.

**Virtual methods to override:**

* new()
* new(String carrierId)
* Initialize()
* Clear()
* Delete()
* Load()
* Save()

> [!NOTE]
> It is not necessary to override *all* of these methods.

In the code above, we have overridden the `Initialize` method by calling the base class’s `initialize()` and then adding a data carrier to it. The carrier consists of a key (string) that is used to identify the carrier and a value (object).

## Add DLL to bin and config

Once this class project has been compiled, we are required to add the DLL (*MyDataHandler.dll*) to the *bin* directory of SuperOffice. The default path of the bin directory is `C:\Program Files\SuperOffice\SuperOffice CRM.web\SuperOffice\bin`.

The next step is to add the created DLL to the *SoObjectMapping.config* file. Simply add the following code inside the `objects` element.

```XML
<object type="IDataHandler" mappingname="MyDataHandler" assemblyname="MyDataHandler" objectname="MyTestDataHandler.MyDataHandler"></object>
```

[!include[ALT](../includes/object-parameters.md)]

Now our assembly can be used in any of the config files.

## Example use

We will use our created assembly to show the system date and time in the company’s **Interests** view.

Since we are using our created data handler in the *SoContactPanel.config* file, it should be first identified in the *SoContactPage.config* file in the `datahandlers` element:

```XML
<datahandler id="MyDiaryDataHandler" type="MyDiaryDataHandler"></datahandler>
```

Next, we move on to the *SoContactPanel.config* file’s **Interests** view and add a code segment that retrieves the system date and time using our data handler.

```XML
<controlgroup id="interestHeadergroup2" type="SoControlGroup" position="absolute" top="100px" left="15px" right="20px">
  <controls>
    <control id="newTextBox" type="SoTextBox" context-style="Heading" width="100%">
      <datasource>MyDataHandler.mySysDate</datasource>
    </control>
  </controls>
</controlgroup>
```

> [!NOTE]
> The `controlgroup` element must be placed inside the `controlgroups` element.

**Before:**

![before][img1]

**After:**

![after][img2]

See also: [PageBuilder config files][1]

<!-- Referenced links -->
[1]: ../config/index.md

<!-- Referenced images -->
[img1]: media/image002.jpg
[img2]: media/image003.jpg
