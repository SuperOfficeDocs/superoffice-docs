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

# [RESTful REST API](#tab/create-rest)

1. First get the JSON structure that represents a user-defined field. **This is a POST request.**

    Yes, it is unconventional to use a POST request to get an entity structure, however, this is specific to user-defined fields.

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout?udefFieldType=Number HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

2. Update the relevant fields. Change FieldLabel, ShortLabel to update what text is shown in the client.

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

3. Save the user-defined field. **This is a PUT request**.

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

4. Publish the user-defined field.

    > [!WARNING]
    > A Publish request create a new version of all user-defined fields for the entity. Therefore, all user-defined fields will have updated UdefFieldId values.

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

# [RESTful Agent API](#tab/create-agent)


# [SuperOffice.WebApi](#tab/create-webapi)

***

<!-- Linked references -->
[1]: <xref:SuperOffice.WebApi.Data.UDefFieldType>

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