---
title: POST Agents/List/SetListItemsForHeading
id: v1ListAgent_SetListItemsForHeading
---

# POST Agents/List/SetListItemsForHeading

```http
POST /api/v1/Agents/List/SetListItemsForHeading
```

Update listItems that will be visible for this usergroup







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SetListItemsForHeading?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

UdListDefinitionId, HeadingId, ListItemIds, Enable 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionId | int32 |  |
| HeadingId | int32 |  |
| ListItemIds | array |  |
| Enable | bool |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |