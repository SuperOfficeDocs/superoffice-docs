---
# Mandatory fields.
title: erp_tutorial_company       # (Required) Very important for SEO.
description: ERP sync - tutorial company # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: guide              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Tutorial (company)

This tutorial walks you through connecting, working with, and disconnecting SuperOffice entities (company, person, project).

We'll use the following values throughout:

* **connectionID** = {3aef3af6-8642-4fc1-8dc9-4e08bd76a6bf}
* **actorType** = "Customer"

## Connecting

To connect a SuperOffice entity :

1. Click **EDIT** and then click the right **Actor Type** link.

    ![create company][img1]

    The list of Actor Type links is determined by the `GetSupportedActorTypes` call [made when the connection was set up][1].

2. This opens the **Connect to ERP** dialog, which calls the `GetSearchableFields` function to find out what columns to present in the results list.

    ```csharp
    StringArrayPluginResponse response = GetSearchableFields({3aef3af6-8642-4fc1-8dc9-4e08bd76a6bf}, "Customer");
    ```

    ![connect-search][img2]

3. The SuperOffice client calls the `SearchActors` method to find out if there are any customers in the ERP with the same name. The connector is free to implement the search as it wants. It would be nice if the results were filtered according to the parameters, but this is not required.

    ```csharp
    ActorArrayPluginResponse  SearchActors(Guid connectionID, string actorType, string searchText, string[] fieldKeys )
    ```

    Example input:

    * searchText = "Orkdal Eldresenter":
    * fieldKeys: { "NUMBER1", "NAME", "ADDRESS1" }

    Example result:

    ```csharp
    [0] = { ActorType = "Customer", ErpKey = "erp831",
            LastModified = "103423595",
            FieldValues = {
               ["NAME"] = "Orkdal Senter AS",
               ["NUMBER1"] = "4343321",
               ["ADDRESS1"] = "x2" }
    ```

4. The returned actors are displayed in the results grid in the dialog.

## Searching

* If the user enters a different name, `SearchActors` is called again and the results are updated.

* If the user clicks the **Advanced Search** button, the search dialog appears and `SearchActorsAdvanced` is called like [during Import][2].

* If the user selects one of the actors and clicks the **Connect** button, the full Actor is retrieved from the ERP system using `GetActors`.

  ```csharp
  ActorArrayPluginResponse GetActors( Guid connectionID, string actorType, string[] erpKeys, string[] fieldKeys )
  ```

  Example input:

  * erpKeys: [0] = "erp831"
  * fieldKeys: [0] = "NAME", [1] = "NUMBER1", [2] = "SUPPLIERLIMIT", [3] = "STDTERMS", [4] = "ADDRESS1"

  Example result:

  ```csharp
  [0] = { ActorType = "Customer", ErpKey = "erp831",
          LastModified = "103423595",
          FieldValues = {
            ["NAME"] = "Orkdal Senter AS",
            ["NUMBER1"] = "4343321",
            ["STDTERMS"] = "60",
            ["SUPPLIERLIMIT"] = "x2" }
            ["ADDRESS1"] = "Oveien 544" }
  ```

* If some of the ERP Actor values conflict with the SuperOffice entity, these are displayed in the dialog:

![select-field-values][img3]

The user can select the values that they want to use, and the SuperOffice database is updated with new values.

## Updating ERP

The ERP system is updated with the new values using a second call to `GetActors`, followed by a call to `SaveActors`.

Assuming we use the above call to `GetActors()`, we get back an Actor with ["ADDRESS1"] = "Oveien 543". Let's change that to "Oveien 544".

The SuperOffice client will update the Actor with new values depending on what the user selected in the dialog, and then call `SaveActors`.

```csharp
ActorArrayPluginResponse SaveActors( Guid connectionId, ErpActor[] actors )
```

The actor now looks like this:

```csharp
[0] = { ActorType = "Customer", ErpKey = "erp831",
        LastModified = "103423595",
        FieldValues = {
          ["NAME"] = "Orkdal Senter AS",
          ["NUMBER1"] = "4343321",
          ["STDTERMS"] = "60",
          ["SUPPLIERLIMIT"] = "x2" }
          ["ADDRESS1"] = "Oveien 544" }
```

The link between the SuperOffice entity and the actor is stored in the SuperOffice database.

If the user can't find a match in the ERP system, they can create a company in ERP based on the SuperOffice company.

## Creating

1. If the user can't find a match in the ERP system, they check the **Can't find match in ERP** checkbox.

    ![connect-create][img4]

2. The **Connect** button changes to **Create**.

3. The user is presented with a dialog where they can fill in the defaults. The list of fields to present and the suggested default values are stored in the SuperOffice database.

    ![connect-defaults.png][img5]

4. The SuperOffice client calls the connector's `CreateActor` to create the actor, and to get back the ERP ID for the new actor:

    ```csharp
    ActorPluginResponse CreateActor( Guid connectionID, ErpActor actor )
    ```

    Example input:

    ```csharp
    actor = { ActorType = "Customer", ErpKey = "",
      LastModified = "",
      FieldValues = {
        ["NAME"] = "Orkdal Eldresenter AS",
        ["NUMBER1"] = "4343321",
        ["ADDRESS1"] = "x2" }
    ```

    Example result:

    ```csharp
    actor = { ActorType = "Customer", ErpKey = "erp831",
      LastModified = "103423595",
      FieldValues = {
        ["NAME"] = "Orkdal Eldresenter AS",
        ["NUMBER1"] = "4343321",
        ["ADDRESS1"] = "x2" }
    ```

5. The returned actor's `ErpKey` and last-modified date are stored in the SuperOffice database, and the link is created.

## Viewing

![viewing][img6]

The connection links the SuperOffice ID with the ERP's actor type and ERP key. Once a connection has been created, the connection is called whenever the ERP card is viewed.

1. The SuperOffice client calls `GetActors` for the card being viewed, requesting the fields marked *show in ERP card*. Any list items that need to be shown are turned into text values by calling `GetListItems`.

    ```csharp
       ActorArrayPluginResponse GetActors(Guid connectionID, string actorType, string[] erpKeys, string[] fieldKeys )
    ```

    Example input:

    * erpKeys: [0] = "erp831"
    * fieldKeys: [0] = "CUSTGR", [1] = "NUMBER1", [2] = "DOUBLE", [3] = "DATE"

    Example result:

    ```csharp
    [0] = { ActorType = "Customer", ErpKey = "erp831",
      LastModified = "103423595",
      FieldValues = {
        ["CUSTGR"] = "G4",
        ["NUMBER1"] = "[I:0]",
        ["DOUBLE"] = "[D:0.0]",
        ["DATE"] = "" }
    ```

2. The returned actors are displayed in the ERP tab under the connection name heading.

## Disconnecting

To disconnect an active connection:

In edit mode, click the **Disconnect (ERP Type)** link to show a confirmation dialog.

![disconnect][img7]

Answering YES to disconnect from the ERP system does not call the ERP sync connection.

It removes the link record from the SuperOffice database, which stops the connection from being called for more information.

We do not delete information from the ERP system, just because we have stopped sync with SuperOffice.

<!-- Referenced links -->
[1]: set-up-connection.md
[2]: import-from-erp.md

<!-- Referenced images -->
[img1]: media/connecting.png
[img2]: media/connect-search.png
[img3]: media/select-field-values.png
[img4]: media/connect-create.png
[img5]: media/connect-defaults.png
[img6]: media/viewing.png
[img7]: media/disconnect.png
