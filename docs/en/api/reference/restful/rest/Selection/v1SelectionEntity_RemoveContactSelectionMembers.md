---
title: POST Selection/{id}/Members/RemovePerson
uid: v1SelectionEntity_RemoveContactSelectionMembers
generated: true
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
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: contactPersonIds 

A collection of ContactPersonId to remove from the static selection. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer | A person id. |
| ContactId | Integer | A contact id. |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Selection/{selectionId}/Members/RemovePerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "PersonId": 974,
    "ContactId": 646
  },
  {
    "PersonId": 974,
    "ContactId": 646
  }
]
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```