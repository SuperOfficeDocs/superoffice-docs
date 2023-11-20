---
title: POST Agents/Selection/GenerateFollowUps
uid: v1SelectionAgent_GenerateFollowUps
generated: true
---

# POST Agents/Selection/GenerateFollowUps

```http
POST /api/v1/Agents/Selection/GenerateFollowUps
```

Generate follow-ups for members in the selection.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Selection/GenerateFollowUps?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

SelectionId, AppointmentEntity, AssociateId, SaveOnContactOwner, UniqueContact 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SelectionId | Integer |  |
| AppointmentEntity | AppointmentEntity | Partial AppointmentEntity class associating the generated AppointmentEntity with an interface. |
| AssociateId | Integer |  |
| SaveOnContactOwner | Boolean |  |
| UniqueContact | Boolean |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Selection/GenerateFollowUps
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 974,
  "AppointmentEntity": null,
  "AssociateId": 631,
  "SaveOnContactOwner": true,
  "UniqueContact": false
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```