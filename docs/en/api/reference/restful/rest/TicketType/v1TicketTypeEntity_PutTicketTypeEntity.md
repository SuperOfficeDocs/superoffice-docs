---
title: PUT TicketType/{id}
uid: v1TicketTypeEntity_PutTicketTypeEntity
generated: true
---

# PUT TicketType/{id}

```http
PUT /api/v1/TicketType/{id}
```

Updates the existing TicketTypeEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The TicketTypeEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/TicketType/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The TicketTypeEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketTypeId | Integer | Primary key |
| Name | String | The list item |
| Rank | Integer | Rank order |
| Tooltip | String | Tooltip or other description |
| Icon | String | Name of the icon |
| DefaultTicketStatus | Integer | Default ticket status for new tickets |
| TicketStatuses | Array | Relevant/available ticket statuses for this Request type. Empty field means all statuses are available. |
| DefaultTicketPriority | Integer | Default ticket priority for new tickets |
| TicketPriorities | Array | Relevant/available ticket priorities for this Request type. Empty field means all priorities are available. |
| ReplyTemplate | Integer | Reply template to use when replying to a ticket of this type |
| IsExternalVisible | Boolean | Is this request type visible to external people and they can submit requests of this type |
| IsDefault | Boolean | Is this Ticket Type marked as default |

## Response:

TicketTypeEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | TicketTypeEntity updated. |
| 400 | Bad request. Entity to save is not in request body. |

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
PUT /api/v1/TicketType/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 994,
  "Name": "Glover-Friesen",
  "Rank": 111,
  "Tooltip": "consequatur",
  "Icon": "quia",
  "DefaultTicketStatus": 610,
  "TicketStatuses": [
    899,
    477
  ],
  "DefaultTicketPriority": 345,
  "TicketPriorities": [
    256,
    79
  ],
  "ReplyTemplate": 384,
  "IsExternalVisible": false,
  "IsDefault": false
}
```

## Sample response

```http_
HTTP/1.1 200 TicketTypeEntity updated.
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 13,
  "Name": "Wolf, Swaniawski and Hammes",
  "Rank": 761,
  "Tooltip": "nihil",
  "Icon": "et",
  "DefaultTicketStatus": 179,
  "TicketStatuses": [
    153,
    202
  ],
  "DefaultTicketPriority": 656,
  "TicketPriorities": [
    545,
    912
  ],
  "ReplyTemplate": 289,
  "IsExternalVisible": true,
  "IsDefault": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 104
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```