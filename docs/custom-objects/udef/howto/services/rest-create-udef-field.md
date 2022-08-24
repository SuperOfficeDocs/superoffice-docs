---
title: How to create a user-defined field
uid: ws-create-custom-field
description: Describes how to create a user-defined field using web services
author: AnthonyYates
so.date: 03.11.2022
keywords: udef, user-defined field, custom field
so.topic: howto
---

# How to create a user-defined field using the web services API

This guide describes how to create a user-defined field using the web services API.

> [!NOTE]
> To show a user-defined field in the client, it must first be published.

## Steps

[!include[ALT](includes/how-to-guide-steps-intro.md)]

All examples depend on the [udefFieldType][1] enum type to define what the data type of the user-defined field should be.

### Create user-defined field of type Number

These examples demonstrate how to create a Number user-defined field. First, a request is sent to obtain the default user-defined field structure, including calculated positioning in the client. Then field values are updated to reflect field text, tooltip, whether it should be indexed, or be mandatory.

<!-- markdownlint-disable MD051 -->
#### [RESTful REST API](#tab/create-rest)

1. First get the JSON structure that represents a user-defined field. **This is a POST request.**

    Yes, it is unconventional to use a POST request to get an entity structure, however, this is specific to user-defined fields.

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout?udefFieldType=Number HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

1. Update the relevant fields. Change FieldLabel, ShortLabel to update what text is shown in the client.

    ```json
    {
        ...,
        "FieldLabel": "My Number Udef",
        "IsMandatory": true,
        "ShortLabel": "NumUdef",
        "Tooltip": "Tooltip for this Number UD field"
        ...,
    }
    ```

1. Save the user-defined field. **This is a PUT request**.

    Yes, it is unconventional to use a PUT request to save, however, this is specific to user-defined fields.

    The PUT request accepts an array of user-defined fields, so more than one could be updated or saved at the same time. Existing user-defined fields not in the array will not be deleted.

    ```http
    PUT https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    Content-Type: application/json; charset=utf-8

    [{
    "UDefFieldId": 0,
    "ColumnId": 8971,
    "FieldDefault": "",
    "FieldHeight": 17,
    "FieldLabel": "My Number Udef",
    "FieldLeft": 102,
    "FieldTop": 170,
    "FieldType": "Number",
    "FieldWidth": 100,
    "FormatMask": "",
    "HideLabel": false,
    "IsIndexed": false,
    "LabelHeight": 17,
    "LabelLeft": 0,
    "LabelTop": 170,
    "LabelWidth": 100,
    "LastVersionId": 0,
    "ListTableId": 136,
    "IsMandatory": true,
    "Type": "Contact",
    "Page1LineNo": 0,
    "ProgId": "SuperOffice:12",
    "IsReadOnly": false,
    "ShortLabel": "NumUdef",
    "TabOrder": 11,
    "TextLength": 0,
    "Tooltip": "Tooltip for this Number UD field",
    "UdefIdentity": 11,
    "UDListDefinitionId": 0,
    "Justification": "Left",
    "Version": 11,
    "TemplateVariableName": "cl11",
    "HasBeenPublished": false,
    "MdoListName": null
    }]
    ```

    The response will contain all of the user-defined fields for this entity, but now the new user-defined field UDefFieldId property will contain a identity value.

1. Make sure the Contact user-defined fields are not currently being updated.

    ```http
    GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout/Publish HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

    Only if the response is False, proceed to publish and complete the delete operation.

1. Publish the user-defined field.

    > [!WARNING]
    > A Publish request creates a new version of all user-defined fields for the entity. Therefore, all user-defined fields will have updated UdefFieldId values.

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout/Publish HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

    Caching on the web application may prevent new user-defined fields from appearing in the client. If that is the case, send a GET request with the `flush` query string to flush all caches.

    ```http
    GET https://{{env}}.superoffice.com/{{tenant}}/default.aspx?flush HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

    Optionally, enter that URL into a browser and navigate to the page with the ´?flush´ query string parameter with an authenticated user.

#### [RESTful Agent API](#tab/create-agent)

1. First get the JSON structure that represents a user-defined field. **This is a POST request.**

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/UserDefinedFieldInfo/CreateUserDefinedFieldInfo
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    Content-Type: application/json; charset=utf-8

    {
        "OwnerType": "Contact",
        "FieldType": "Number",
    }
    ```

    The response:

    ```json
    {
        "UDefFieldId": 0,
        "ColumnId": 8972,
        "FieldDefault": "",
        "FieldHeight": 17,
        "FieldLabel": "",
        "FieldLeft": 102,
        "FieldTop": 187,
        "FieldType": "Number",
        "FieldWidth": 100,
        "FormatMask": "",
        "HideLabel": false,
        "IsIndexed": false,
        "LabelHeight": 17,
        "LabelLeft": 0,
        "LabelTop": 187,
        "LabelWidth": 100,
        "LastVersionId": 0,
        "ListTableId": 0,
        "IsMandatory": false,
        "Type": "Contact",
        "Page1LineNo": 0,
        "ProgId": "SuperOffice:12",
        "IsReadOnly": false,
        "ShortLabel": "",
        "TabOrder": 12,
        "TextLength": 0,
        "Tooltip": "",
        "UdefIdentity": 12,
        "UDListDefinitionId": 0,
        "Justification": "Left",
        "Version": 13,
        "TemplateVariableName": "cl12",
        "HasBeenPublished": false,
        "MdoListName": null,
        "TableRight": null,
        "FieldProperties": {
            "IsIndexed": {
            "FieldRight": {
                "Mask": "Update",
                "Reason": ""
            },
            "FieldType": "System.Boolean",
            "FieldLength": 0
            },
            "IsMandatory": {
            "FieldRight": {
                "Mask": "Update",
                "Reason": ""
            },
            "FieldType": "System.Boolean",
            "FieldLength": 0
            }
        }
    }
    ```

1. Update the relevant fields. Change FieldLabel, ShortLabel to update what text is shown in the client.

    ```json
    {
        ...,
        "FieldLabel": "My Number Udef",
        "IsMandatory": true,
        "ShortLabel": "NumUdef",
        "Tooltip": "Tooltip for this Number UD field"
        ...,
    }
    ```

1. Save the user-defined field. **This is a PUT request**.

    The save request accepts the user-defined field to save.

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfo
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    Content-Type: application/json; charset=utf-8

    [{
        "UDefFieldId": 0,
        "ColumnId": 8971,
        "FieldDefault": "",
        "FieldHeight": 17,
        "FieldLabel": "My Number Udef",
        "FieldLeft": 102,
        "FieldTop": 170,
        "FieldType": "Number",
        "FieldWidth": 100,
        "FormatMask": "",
        "HideLabel": false,
        "IsIndexed": false,
        "LabelHeight": 17,
        "LabelLeft": 0,
        "LabelTop": 170,
        "LabelWidth": 100,
        "LastVersionId": 0,
        "ListTableId": 136,
        "IsMandatory": true,
        "Type": "Contact",
        "Page1LineNo": 0,
        "ProgId": "SuperOffice:12",
        "IsReadOnly": false,
        "ShortLabel": "NumUdef",
        "TabOrder": 11,
        "TextLength": 0,
        "Tooltip": "Tooltip for this Number UD field",
        "UdefIdentity": 11,
        "UDListDefinitionId": 0,
        "Justification": "Left",
        "Version": 11,
        "TemplateVariableName": "cl11",
        "HasBeenPublished": false,
        "MdoListName": null
    }]
    ```

    The response will contain all of the user-defined fields for this entity, but now the new user-defined field UDefFieldId property will contain a identity value.

    The field is not yet viewable in the UI. It needs to first be published.

1. Publish the user-defined field.

    > [!WARNING]
    > A Publish request creates a new version of all user-defined fields for the entity. Therefore, all user-defined fields will have updated UdefFieldId values.

    Before published fields, make sure there is no active publish event happening at the same time. As long as the `IsAnyPublishEventActive` call returns false, it is safe to proceed.

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/UserDefinedFieldInfo/IsAnyPublishEventActive
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

    To prevent anyone from overwriting your field changes, set the publish event flag for the entity.

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/UserDefinedFieldInfo/SetPublishStartSystemEvent
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    Content-Type: application/json; charset=utf-8

    {
        "OwnerType": "Contact"
    }
    ```

    Finally issue the publish the request to activate the new field changes.

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/UserDefinedFieldInfo/Publish
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    Content-Type: application/json; charset=utf-8

    {
        "OwnerType": "Contact"
    }
    ```

    Caching on the web application may prevent new user-defined fields from appearing in the client. If that is the case, send a GET request with the `flush` query string to flush all caches.

    ```http
    GET https://{{env}}.superoffice.com/{{tenant}}/default.aspx?flush HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

    Optionally, enter that URL into a browser and navigate to the page with the ´?flush´ query string parameter with an authenticated user.

##### [SuperOffice.WebApi](#tab/create-webapi)

1. First create the UserDefinedFieldInfo instance that represents a user-defined field.

    ```csharp
    var config = new WebApiOptions(tenant.WebApiUrl);
    config.Authorization = new AuthorizationSystemUserTicket(sysUserInfo, sysUserTicket);

    var udefAgent = new UserDefinedFieldInfoAgent(config);
    var udef = await udefAgent.CreateUserDefinedFieldInfoAsync(
        UDefType.Contact, 
        UDefFieldType.Number
    );

    udef.FieldLabel = "My Number Def";
    udef.IsMandatory = true;
    udef.ShortLabel = "NumUdef";
    udef.Tooltip = "Tooltip for this Number UD field";

    udef = await udefAgent.SaveUserDefinedFieldInfoAsync(udef);
    ```

2. Publish the user-defined field to make it appear in the client user interface.

    Fields are published by entity type. When published, all user-defined fields for that entity receive a new UDefFieldId number.

    ```csharp
    // make sure no one else is trying to publish at the same time
    if(!await udefAgent.IsAnyPublishEventActiveAsync())
    {
        // state intention to start publishing new / updated fields.
        await udefAgent.SetPublishStartSystemEventAsync(UDefType.Contact);
        // publish user-defined field changes by entity type
        var result = await udefAgent.PublishAsync(UDefType.Contact);
    }
    ```

    If the fields are not immediately observable in the client user interface (UI), navigate to the application with the ´?flush´ query string parameter at the end of the URL as an authenticated user. The fields should then appear in the UI.

***
<!-- markdownlint-restore -->

## User-Defined Field Lists

To create a user-defined field based on a list, create it with `udefFieldType` **List**.

### User-defined lists

For user-defined lists, set the ListTableId and  UDListDefinitionId property values accordingly.

| Property | Description |
|---|---|
|ListTableId| User-defined lists are always **136**. |
|UDListDefinitionId| The `UDListDefinitionId` is the udlist id value. To get the udlist id, see the [Get All Lists][2] documentation, and view lists with Type `udlist`. |

### Built-in lists

For Build in Lists. for example the **Business list entity**, only set the `ListTableId` property. You can get the `ListTableId` property from the [MDOProviders documentation][3] page. Alternatively, you can query for all using the dynamic archive provider.

**Request:**

<!-- markdownlint-disable MD051 -->
#### [Restful REST](#tab/create-udef-list-rest)

```http
GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/archive/dynamic?$select=udlistdefinition.name,udlistdefinition.listTableId HTTP/1.1
Accept: application/json
Authorization: Bearer {{token}}
SO-Language: en-US
```

**Response:**

All except Business list removed here for brevity.

```json
{
      "PrimaryKey": "81",
      "EntityName": "UDListDefinition",
      "udlistdefinition.name": "Company - Business",
      "udlistdefinition.listTableId": 61
},
```

#### [Restful Agent](#tab/create-udef-list-agent)

```http
POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/Archive/GetArchiveListByColumns HTTP/1.1
Content-Type: application/json
Accept: application/json
Authorization: Bearer {{token}}
SO-Language: en-US

{
  "ProviderName": "Dynamic",
  "Columns": [
    "udlistdefinition.name",
    "udlistdefinition.listTableId"
  ],
  "SortOrder": [
    {
      "Name": "udlistdefinition.name",
      "Direction": "ASC"
    }
  ],
  "Restriction": [
    {
      "Name": "getAllRows",
      "Operator": "=",
      "Values": [ "true" ],
      "IsActive": true
    }
  ],
  "Entities": [
    ""
  ],
  "Page": 0,
  "PageSize": 1000000
}
```

#### [SuperOffice.WebApi](#tab/create-udef-list-webapi)

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationAccessToken(
    "8A:Cust12345.eylksjdf...321C", 
    OnlineEnvironment.SOD);

var archiveAgent = new ArchiveAgent(config);

// results contains the column fields and column data.
var results = await archiveAgent.GetArchiveListByColumnsAsync(
    "dynamic",
    new [] {"udlistdefinition.name", "udlistdefinition.listTableId"},
    new [] {
        new ArchiveOrderByInfo() 
        { 
            Name="udlistdefinition.name", 
            Direction=OrderBySortType.ASC
        }
    },
    new [] {
       new ArchiveRestrictionInfo() 
       { 
           Name="getAllRows", 
           Operator="=", 
           Values=new [] {"True"}
        
       }
    }, 
    null,
    0,
    int.MaxValue
   );
```

***
<!-- markdownlint-restore -->

Do not use the PrimaryKey value, use the `udlistdefinition.listTableId` value.

<!-- Linked references -->
[1]: <xref:SuperOffice.WebApi.Data.UDefFieldType>
[2]: ../../../../api/lists/services/how-to/get-all-lists.md
[3]: ../../../../api/mdo-providers/reference/index.md
<!-- 
How to write good how-to guides 

- Provide a series of steps​
- Focus on results​
- Solve a problem​
- Don’t explain concepts, link to them​
- Allow for some flexibility, point out more ways to do same thing​
- Leave things out – start and end where it seems appropriate​
- Bloated how-to guides don’t help the reader get speedy solution​
- Name them well
-->