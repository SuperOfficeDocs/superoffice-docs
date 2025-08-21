---
uid: ws-delete-custom-field
title: How to delete a user-defined field
description: Describes how to delete a user-defined field using web services
keywords: udef, user-defined field, custom field
author: AnthonyYates
date: 03.11.2022
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from:
  - /en/custom-objects/udef/howto/services/rest-delete-udef-field
  - /en/api/netserver/web-services/howto/custom-objects/rest-delete-udef-field
---

# How to delete a user-defined field using the web services API

This guide describes how to delete a user-defined field using the web services API.

## Steps

[!include[ALT](includes/how-to-guide-steps-intro.md)]

<!-- markdownlint-disable MD051 -->
### [RESTful REST API](#tab/delete-rest)

Describes how-to delete a Contact user-defined field details by prog-id or label. This deletes the admin version of the field. The layout needs to be published before the change is visible.

1. Delete the user-defined field:

    **Delete by ProgId**

    ```http
    DELETE https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout/SuperOffice:11
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

    **Delete by FieldLabel**

    ```http
    DELETE https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout/My New Number
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

1. Make sure the Contact user-defined fields are not currently being updated.

    ```http
    GET https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout/Publish HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

    Only if the response is False, proceed to publish and complete the delete operation.

1. Publish to finalize the delete changes.

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Contact/UdefLayout/Publish HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

### [HTTP RPC Agent API](#tab/delete-agent)

Get the current UDefFieldId value for the user-defined field to delete, then pass that into the following request as a query string parameter.

1. Deletes the user-defined field is 868.

    ```http
    POST https://{{env}}.superoffice.com/{{tenant}}/api/v1/Agents/UserDefinedFieldInfo/DeleteUserDefinedFieldInfo?UserDefinedFieldInfoId=868 HTTP/1.1
    Authorization: Bearer {{token}}
    Accept: application/json; charset=utf-8
    ```

1. Publish to complete the delete operation for this user-defined field.

    > [!WARNING]
    > A Publish request creates a new version of all user-defined fields for the entity. Therefore, all user-defined fields not deleted will have updated UdefFieldId values.
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

> [!NOTE]
> Depending on the user-case it might be a good idea to [flush caches][4].

### [SuperOffice.WebApi](#tab/delete-webapi)

***

<!-- Reference links -->
[4]: ../../../caching/flush-cache.md
