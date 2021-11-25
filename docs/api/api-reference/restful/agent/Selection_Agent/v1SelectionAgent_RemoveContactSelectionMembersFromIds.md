---
title: POST Agents/Selection/RemoveContactSelectionMembersFromIds
id: v1SelectionAgent_RemoveContactSelectionMembersFromIds
---

# POST Agents/Selection/RemoveContactSelectionMembersFromIds

```http
POST /api/v1/Agents/Selection/RemoveContactSelectionMembersFromIds
```

Removes members from the selection using a collection a selectionmember id's.

Members can only be removed from single selection.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/RemoveContactSelectionMembersFromIds?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request  

SelectionId, SelectionMembersIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | int32 |  |
| SelectionMembersIds | array |  |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |