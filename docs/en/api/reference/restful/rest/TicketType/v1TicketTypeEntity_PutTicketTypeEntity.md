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
| ShowInNew | Boolean | Enables this request type to be accessible in +New in top bar |
| ExcludeSignature | Boolean | Do not insert user signature automatically |
| ExcludeEmailRecipients | Boolean | Create request without initially having to send outbound e-mail |
| ExternalAsDefault | Boolean | Ability to set external access level for this request type |
| VisibleForGroups | Array | Array of references to the visible for groups |
| ReplyForwardNoSignature | Boolean | Do not insert user signature when replying or forwarding the message |
| ReplyExternalAsDefault | Boolean | Set external access level when replying the message |

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
| ShowInNew | bool | Enables this request type to be accessible in +New in top bar |
| ExcludeSignature | bool | Do not insert user signature automatically |
| ExcludeEmailRecipients | bool | Create request without initially having to send outbound e-mail |
| ExternalAsDefault | bool | Ability to set external access level for this request type |
| VisibleForGroups | array | Array of references to the visible for groups |
| ReplyForwardNoSignature | bool | Do not insert user signature when replying or forwarding the message |
| ReplyExternalAsDefault | bool | Set external access level when replying the message |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/TicketType/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 18,
  "Name": "Schneider, Toy and Murazik",
  "Rank": 963,
  "Tooltip": "quasi",
  "Icon": "labore",
  "DefaultTicketStatus": 263,
  "TicketStatuses": [
    136,
    960
  ],
  "DefaultTicketPriority": 209,
  "TicketPriorities": [
    171,
    504
  ],
  "ReplyTemplate": 357,
  "IsExternalVisible": true,
  "IsDefault": true,
  "ShowInNew": false,
  "ExcludeSignature": false,
  "ExcludeEmailRecipients": false,
  "ExternalAsDefault": false,
  "VisibleForGroups": [
    558,
    799
  ],
  "ReplyForwardNoSignature": false,
  "ReplyExternalAsDefault": false
}
```

## Sample response

```http_
HTTP/1.1 200 TicketTypeEntity updated.
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 589,
  "Name": "Grady, Ritchie and Wolff",
  "Rank": 996,
  "Tooltip": "harum",
  "Icon": "voluptate",
  "DefaultTicketStatus": 568,
  "TicketStatuses": [
    219,
    836
  ],
  "DefaultTicketPriority": 404,
  "TicketPriorities": [
    111,
    566
  ],
  "ReplyTemplate": 591,
  "IsExternalVisible": false,
  "IsDefault": true,
  "ShowInNew": false,
  "ExcludeSignature": false,
  "ExcludeEmailRecipients": false,
  "ExternalAsDefault": false,
  "VisibleForGroups": [
    640,
    686
  ],
  "ReplyForwardNoSignature": false,
  "ReplyExternalAsDefault": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 57
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```