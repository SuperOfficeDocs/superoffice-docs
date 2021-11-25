---
title: POST Agents/List/DeleteAllHeadingsFromListDefinition
id: v1ListAgent_DeleteAllHeadingsFromListDefinition
---

# POST Agents/List/DeleteAllHeadingsFromListDefinition

```http
POST /api/v1/Agents/List/DeleteAllHeadingsFromListDefinition
```

Delete all headings for list resolved by the provided id.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/DeleteAllHeadingsFromListDefinition?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

Id 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |