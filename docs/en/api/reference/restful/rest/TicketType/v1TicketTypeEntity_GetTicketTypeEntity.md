---
title: GET TicketType/{id}
uid: v1TicketTypeEntity_GetTicketTypeEntity
generated: true
---

# GET TicketType/{id}

```http
GET /api/v1/TicketType/{id}
```

Gets a TicketTypeEntity object.


Calls the List agent service GetTicketTypeEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketTypeEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/TicketType/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

TicketTypeEntity found.

| Response | Description |
|----------------|-------------|
| 200 | TicketTypeEntity found. |
| 404 | Not Found. |

### Response body: TicketTypeEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketTypeId | int32 | Primary key |
| Name | string | The list item |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| Icon | string | Name of the icon |
| DefaultTicketStatus | int32 | Default ticket status for new tickets |
| TicketStatuses | array | Relevant/available ticket statuses for this Request type. Empty field means all statuses are available. |
| DefaultTicketPriority | int32 | Default ticket priority for new tickets |
| TicketPriorities | array | Relevant/available ticket priorities for this Request type. Empty field means all priorities are available. |
| ReplyTemplate | int32 | Reply template to use when replying to a ticket of this type |
| IsExternalVisible | bool | Is this request type visible to external people and they can submit requests of this type |
| IsDefault | bool | Is this Ticket Type marked as default |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/TicketType/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 TicketTypeEntity found.
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 403,
  "Name": "Becker, Pfeffer and Walsh",
  "Rank": 226,
  "Tooltip": "molestiae",
  "Icon": "perferendis",
  "DefaultTicketStatus": 407,
  "TicketStatuses": [
    124,
    361
  ],
  "DefaultTicketPriority": 608,
  "TicketPriorities": [
    782,
    94
  ],
  "ReplyTemplate": 968,
  "IsExternalVisible": false,
  "IsDefault": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 739
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```