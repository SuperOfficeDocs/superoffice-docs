---
title: GET List/TicketType/Items/{id}
uid: v1TicketTypeList_GetTicketTypeEntity
generated: true
---

# GET List/TicketType/Items/{id}

```http
GET /api/v1/List/TicketType/Items/{id}
```

Gets a TicketTypeEntity list item.


Calls the List agent service GetTicketTypeEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the TicketTypeEntity to return. **Required** |



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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 404 | Not Found. |

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
GET /api/v1/List/TicketType/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketTypeId": 634,
  "Name": "Waelchi Inc and Sons",
  "Rank": 134,
  "Tooltip": "pariatur",
  "Icon": "ut",
  "DefaultTicketStatus": 580,
  "TicketStatuses": [
    291,
    459
  ],
  "DefaultTicketPriority": 468,
  "TicketPriorities": [
    337,
    742
  ],
  "ReplyTemplate": 579,
  "IsExternalVisible": false,
  "IsDefault": false,
  "ShowInNew": false,
  "ExcludeSignature": false,
  "ExcludeEmailRecipients": true,
  "ExternalAsDefault": false,
  "VisibleForGroups": [
    78,
    230
  ],
  "ReplyForwardNoSignature": false,
  "ReplyExternalAsDefault": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 233
    }
  }
}
```