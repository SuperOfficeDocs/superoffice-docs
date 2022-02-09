---
title: POST Selection/{id}/Members/Remove
id: v1SelectionEntity_RemoveSelectionMembersById
---

# POST Selection/{id}/Members/Remove

```http
POST /api/v1/Selection/{selectionId}/Members/Remove
```

Removes members from the selection as specified in the collection of entity ids.

The ids can be a collection of sale ids, or other supported types.




| Path Part | Type | Description |
|-----------|------|-------------|
| selectionId | int32 | The id of the selection where to members will be removed. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: ids  

A collection of sale/project/contact ids to remove from the selection. The ids can be a collection of sale ids, or other supported types. 



## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |