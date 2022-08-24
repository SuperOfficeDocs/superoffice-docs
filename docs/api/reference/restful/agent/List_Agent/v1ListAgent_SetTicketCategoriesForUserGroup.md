---
title: POST Agents/List/SetTicketCategoriesForUserGroup
id: v1ListAgent_SetTicketCategoriesForUserGroup
---

# POST Agents/List/SetTicketCategoriesForUserGroup

```http
POST /api/v1/Agents/List/SetTicketCategoriesForUserGroup
```

Set ticket categories for one user group

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SetTicketCategoriesForUserGroup?$select=name,department,category/id
```

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request

UserGroupId, CategoryIds

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserGroupId | int32 |  |
| CategoryIds | array |  |

## Response

| Response | Description |
|----------------|-------------|
| 204 | No Content |
