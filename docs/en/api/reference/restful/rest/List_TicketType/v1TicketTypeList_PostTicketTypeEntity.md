---
title: POST List/TicketType/Items
uid: v1TicketTypeList_PostTicketTypeEntity
generated: true
---

# POST List/TicketType/Items

```http
POST /api/v1/List/TicketType/Items
```

Create a new TicketTypeEntity list item


Calls the List agent service SaveTicketTypeEntity.







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

## Request Body: newEntity 

The TicketTypeEntity to be created. 

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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TicketTypeEntity

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

## Sample request

```http!
POST /api/v1/List/TicketType/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 761,
  "Name": "Cremin, Runolfsdottir and Schaden",
  "Rank": 137,
  "Tooltip": "optio",
  "Icon": "dolorem",
  "DefaultTicketStatus": 668,
  "TicketStatuses": [
    940,
    479
  ],
  "DefaultTicketPriority": 86,
  "TicketPriorities": [
    562,
    847
  ],
  "ReplyTemplate": 140,
  "IsExternalVisible": false,
  "IsDefault": false,
  "ShowInNew": false,
  "ExcludeSignature": true,
  "ExcludeEmailRecipients": false,
  "ExternalAsDefault": false,
  "VisibleForGroups": [
    665,
    42
  ],
  "ReplyForwardNoSignature": false,
  "ReplyExternalAsDefault": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 483,
  "Name": "Keebler-Murphy",
  "Rank": 698,
  "Tooltip": "qui",
  "Icon": "quo",
  "DefaultTicketStatus": 508,
  "TicketStatuses": [
    699,
    780
  ],
  "DefaultTicketPriority": 46,
  "TicketPriorities": [
    289,
    187
  ],
  "ReplyTemplate": 199,
  "IsExternalVisible": false,
  "IsDefault": false,
  "ShowInNew": false,
  "ExcludeSignature": false,
  "ExcludeEmailRecipients": false,
  "ExternalAsDefault": true,
  "VisibleForGroups": [
    761,
    186
  ],
  "ReplyForwardNoSignature": false,
  "ReplyExternalAsDefault": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 799
    }
  }
}
```