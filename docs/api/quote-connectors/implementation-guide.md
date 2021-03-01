---
title: quote_connector_create
description: How to create a SuperOffice Quote Connector
author: {github-id}             # Your GitHub alias.
so.date:
keywords: quote
so.topic: howto
---
# How to create a SuperOffice Quote Connector

## Pre-requisites

* Install Visual Studio

* Install SuperOffice Sales & Marketing Windows version on the computer.

> [!NOTE]
> The example assumes that you have installed the windows client on "C:\Program Files (x86)\SuperOffice\SuperOffice 7 Windows\". Adjust your path accordingly.

## Basics

1. Open Visual Studio, but **Run as Administrator**. You will need this to be able to set the build output to a subfolder of *Program files*.

2. Select **Create new project** from the menu
    1. Select "Visual C#"
    2. Select "Class library" and give it a name, like "MyQuoteConnector" (or "SAP Connector")
    3. Select OK

3. Right-click on **References** in the Solution explorer and select "Add references…"

    1. Select "Browse", and "Browse" again.
    2. Navigate to where you installed SuperOffice and select *SOCore.dll* and *SuperOffice.Plugins.dll*

4. Right-Click on the project in solution explorer and select " **Properties**".

    1. Select **Build** tab
    2. Set "Output path" = C:\Program Files (x86)\SuperOffice\SuperOffice 7 Windows\
    3. Save and close the properties window.

5. Open "Class1.cs"

6. Insert `using SuperOffice.CRM;`

7. (If you are using the version that was made around Christmas 2012) Insert `using SuperOffice.Plugins.CRM.Sale;`

8. Insert `[QuoteConnector( Name )]` over the class def. This attribute is used to identify the class by SuperOffice as an ERPQuoteConnector.

9. Insert `public const string Name = "MyQuoteConnector";` inside the class. This name is used (via the attribute over) to identify the class by SuperOffice when it is dynamically loaded from the *SuperOffice.config* file. You shall have to insert this name and the name of the .DLL into the *SuperOffice.config* file’s `DynamicLoad` section later.

## If you just want to replace or extend part of an ERP connector

1. Right-click on **References** in the Solution explorer and select "Add references…"
    1. Select "Browse", and "Browse" again.
    2. Navigate to where you installed SuperOffice and select the connector you want to extend, for instance: *SuperOffice.QuoteConnector.dll*

2. Inherit "SuperOffice.CRM. **QuoteConnectorExtender**" in Class1

3. Create a constructor where you reference the ERP connector you want to extend, something like this:

    ```csharp
    public Class1(): base( new SuperOffice.QuoteConnector. SuperOfficeQuoteConnector()) { }
    ```

4. Override the function(-s) you want to override. (for instance "OnQuoteLineChanged")

5. Goto "When Done" J

## If you don’t want to extend an existing ERP connector

1. Inherit "SuperOffice.CRM. **QuoteConnectorBase**" in Class1. This class has a lot of what you want to do implemented already. it implements IQuoteConnector and IPlugin.
    Implement the abstract class `SuperOffice.CRM.QuoteConnectorBase`.

2. Implement **Quote Connector Setup functions**

3. Implement **Product Provider functions**

4. If you want to handle Orders, implement the Order Consumer functions

5. Goto "When Done" J

## When Done

1. Build your connector DLL

2. DynamicLoad. Either use the SOLOADER panel in Windows Admin client or change the config file as shown below.

    1. Open *SuperOffice.config* from the installation folder.
    2. Insert the following line under `<DynamicLoad>`:

    `<add key = " MyQuoteConnector " value = " MyQuoteConnector.dll " />`

3. Run admin

4. Click on the "Quote" element in the navigator on the left side.

5. Observe that you can see the Connector in the connector list

6. Add a connection to your connector.

7. Start SuperOffice win client

8. Create a new sale.

9. Create a quote with the new connector.

<!-- Referenced links -->
[1]:
