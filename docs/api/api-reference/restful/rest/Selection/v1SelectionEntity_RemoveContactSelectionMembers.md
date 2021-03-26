---
title: POST Selection/{id}/Members/RemovePerson
id: v1SelectionEntity_RemoveContactSelectionMembers
---

# POST Selection/{id}/Members/RemovePerson

```http
POST /api/v1/Selection/{selectionId}/Members/RemovePerson
```

Removes members from the selection as  specified in the collection of ContactPersonId.






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

## Request Body: contactPersonIds  

A collection of ContactPersonId to remove from the static selection. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | A person id. |
| ContactId | int32 | A contact id. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |