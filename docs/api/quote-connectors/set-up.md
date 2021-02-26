---
title: quote_connectors_setup      
description: How to set up a quote connector
author: {github-id}             # Your GitHub alias.
so.date:
keywords: quote
so.topic: howto
---

# How to set up a quote connector

The SuperOffice Admin client will start by using the setup functions to set up the connection to the ERP system.

1. Admin calls **GetConfigurationFields** and uses the result to add fields to the configuration dialog.

    ![02][img1]

    For example: if `GetConfigFields()` returns the following list, the **Configure Quote Connection** dialog will look like below.

    ```json
    [{ "Web Service Key", Integer },
      { "User Name", String },
      { "Password", Password },
      { "Entity", integer },
      { "Web Service URL", String } ]
    ```

    ![03][img2]

2. The user clicks the **TEST** button in the dialog, and the `TestConnection` method is called with the values from the dialog.

3. When the user clicks **OK**, the values are saved to the SuperOffice database as a connection.

## Dictionary< string, FieldMetadataInfo > GetConfigurationFields ()

Used by the admin client.

This is a request for metadata needed to populate the **Configure Quote Connection** dialog that takes in the information needed to create a connection to an ERP system. The values entered in the dialog are stored in the SuperOffice database and used when `InitializeConnection` is called by the client.

The key in the Dictionary is the `FieldKey` and must match the key in the `FieldMetadataInfo`.

## PluginResponseInfo TestConnection ( Dictionary<string, string> connectionData connectionData )

Used by the admin client.

Testing if the connection data is sufficient to get a connection with the ERP system. The connector should try to do some operations to check if the connection has sufficient rights to run. The connection has not been created yet.

`TestConnection` is called without `InitializeConnection` being called first.

The key in the Dictionary is the `FieldKey`, and must match the key in the `FieldMetadataInfo`. The value is what the user entered. see the paragraph "Config Values" below for details.

## Pitfall

> [!NOTE]
> You cannot populate lists based on the partially filled out user-interface during first-time setup.

Dropdown lists are fetched when the GUI is constructed, so having a configuration GUI like shown below won’t work. The call to fetch the Dataset list will come before the WebServiceURL field is filled in.

![04][img3]

<!-- Referenced images -->
[img1]: media/image002.jpg
[img2]: media/image003.jpg
[img3]: media/image004.png
