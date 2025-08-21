---
uid: ws-update-custom-field
title: How to update a user-defined field
description: Describes how to update a user-defined field using web services
keywords: udef, user-defined field, custom field
author: AnthonyYates
date: 03.11.2022
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/custom-objects/udef/howto/services/rest-update-udef-field
  - /en/api/netserver/web-services/howto/custom-objects/rest-update-udef-field
---

# How to update a user-defined field using the web services API

This guide describes how to update a user-defined field using the web services API.

## Steps

[!include[ALT](includes/how-to-guide-steps-intro.md)]

<!-- markdownlint-disable MD051 -->
### [RESTful REST API](#tab/update-rest)

1. Get the user-defined field by progId or label text (FieldLabel).

    ```http
    GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout/SuperOffice:1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

    **Response:**

    ```json
    {
        "UDefFieldId": 140,
        "ColumnId": 8972,
        "FieldDefault": "",
        "FieldHeight": 17,
        "FieldLabel": "My New Number",
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
        "LastVersionId": 128,
        "ListTableId": 0,
        "IsMandatory": false,
        "Type": "Contact",
        "Page1LineNo": 0,
        "ProgId": "SuperOffice:12",
        "IsReadOnly": false,
        "ShortLabel": "NewNumber",
        "TabOrder": 12,
        "TextLength": 0,
        "Tooltip": "",
        "UdefIdentity": 12,
        "UDListDefinitionId": 0,
        "Justification": "Left",
        "Version": 14,
        "TemplateVariableName": "cl12",
        "HasBeenPublished": true,
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

1. Make the desired property changes and save the user-defined field.

    ```http
    PUT https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    Content-Type: application/json; charset=utf-8
    
    {
        "UDefFieldId": 140,
        "ColumnId": 8972,
        "FieldDefault": "",
        "FieldHeight": 17,
        "FieldLabel": "My Newer Number",
        "FieldLeft": 102,
        "FieldTop": 187,
        "FieldType": "Number",
        "FieldWidth": 100,
        "FormatMask": "",
        "HideLabel": false,
        "IsIndexed": true,
        "LabelHeight": 17,
        "LabelLeft": 0,
        "LabelTop": 187,
        "LabelWidth": 100,
        "LastVersionId": 128,
        "ListTableId": 0,
        "IsMandatory": false,
        "Type": "Contact",
        "Page1LineNo": 0,
        "ProgId": "SuperOffice:12",
        "IsReadOnly": false,
        "ShortLabel": "NewerNumber",
        "TabOrder": 12,
        "TextLength": 0,
        "Tooltip": "",
        "UdefIdentity": 12,
        "UDListDefinitionId": 0,
        "Justification": "Left",
        "Version": 14,
        "TemplateVariableName": "cl12",
        "HasBeenPublished": true,
        "MdoListName": null,
    }
    ```

1. Prior to publishing, make sure the Contact user-defined fields are not currently being updated.

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

### [HTTP RPC Agent API](#tab/update-agent)

There are several options to get one or all user-defined field, published and non-published fields.

To get published fields, use one of the following endpoints.

* GetPublishedUserDefinedFieldFromFieldLabel
* GetPublishedUserDefinedFieldFromProgId

The get none published fields, use one of the following endpoints:

* GetUserDefinedFieldFromFieldLabel
* GetUserDefinedFieldFromProgId

1. Get a user-defined field by progId or label text (FieldLabel).

    **Get By ProgId:**

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/UserDefinedFieldInfo/GetUserDefinedFieldFromProgId
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    Content-Type: application/json; charset=utf-8

    {
        "ProgId": "SuperOffice:11",
        "OwnerType": "Contact"
    }
    ```

    **Get By FieldLabel:**

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/UserDefinedFieldInfo/GetUserDefinedFieldFromFieldLabel
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    Content-Type: application/json; charset=utf-8

    {
        "FieldLabel": "My New Number",
        "OwnerType": "Contact"
    }
    ```

1. Make the desired property changes and save the user-defined field.

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/UserDefinedFieldInfo/SaveUserDefinedFieldInfo
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    Content-Type: application/json; charset=utf-8
    
    {
        "UDefFieldId": 140,
        "ColumnId": 8972,
        "FieldDefault": "",
        "FieldHeight": 17,
        "FieldLabel": "My Newer Number",
        "FieldLeft": 102,
        "FieldTop": 187,
        "FieldType": "Number",
        "FieldWidth": 100,
        "FormatMask": "",
        "HideLabel": false,
        "IsIndexed": true,
        "LabelHeight": 17,
        "LabelLeft": 0,
        "LabelTop": 187,
        "LabelWidth": 100,
        "LastVersionId": 128,
        "ListTableId": 0,
        "IsMandatory": false,
        "Type": "Contact",
        "Page1LineNo": 0,
        "ProgId": "SuperOffice:12",
        "IsReadOnly": false,
        "ShortLabel": "NewerNumber",
        "TabOrder": 12,
        "TextLength": 0,
        "Tooltip": "",
        "UdefIdentity": 12,
        "UDListDefinitionId": 0,
        "Justification": "Left",
        "Version": 14,
        "TemplateVariableName": "cl12",
        "HasBeenPublished": true,
        "MdoListName": null,
    }
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

### [SuperOffice.WebApi](#tab/update-webapi)

There are several options to get one or all user-defined field, published and non-published fields.

To get published fields, use one of the following endpoints.

* GetPublishedUserDefinedFieldFromFieldLabel
* GetPublishedUserDefinedFieldFromProgId

The get none published fields, use one of the following endpoints:

* GetUserDefinedFieldFromFieldLabel
* GetUserDefinedFieldFromProgId

1. Get a user-defined field by progId or label text (FieldLabel).

    **Get By ProgId:**

    ```csharp
    var config = new WebApiOptions(tenant.WebApiUrl);
    config.Authorization = new AuthorizationAccessToken("8A:Cust12345.eylksjdf...321C", OnlineEnvironment.SOD);

    var udefAgent = new UserDefinedFieldInfoAgent(config);
    var udef = await udefAgent.GetUserDefinedFieldFromProgIdAsync(
                    "SuperOffice:11",
                    UDefType.Contact, 
                    );
    ```

    **Get By FieldLabel:**

    ```csharp
    var config = new WebApiOptions(tenant.WebApiUrl);
    config.Authorization = new AuthorizationAccessToken("8A:Cust12345.eylksjdf...321C", OnlineEnvironment.SOD);

    var udefAgent = new UserDefinedFieldInfoAgent(config);
    var udef = await udefAgent.GetUserDefinedFieldFromFieldLabelAsync(
                    "My New Number", 
                    UDefType.Contact
        );
    ```

1. Publish the user-defined field to make it appear in the client user interface.

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

> [!NOTE]
> Depending on the user-case it might be a good idea to [flush caches][4].

<!-- Reference links -->
[4]: ../../../caching/flush-cache.md
