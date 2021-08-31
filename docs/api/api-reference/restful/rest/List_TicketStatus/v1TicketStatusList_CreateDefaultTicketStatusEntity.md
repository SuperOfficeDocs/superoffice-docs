---
title: GET List/TicketStatus/Items/Default
id: v1TicketStatusList_CreateDefaultTicketStatusEntity
---

# GET List/TicketStatus/Items/Default

```http
GET /api/v1/List/TicketStatus/Items/Default
```

Gets a default TicketStatusEntity list item.








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


## Response: object

Entity for a ticket status. This entity describes the meta data for a ticket status, and provides special operations on it.



Carrier object for TicketStatusEntity.
Services for the TicketStatusEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketStatusId | int32 | The primary key (auto-incremented) |
| Name | string | Name of user defined ticket status |
| Status | string | The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted |
| TimeCounter | string | Which field in ticket we count time spent on (queue, internal, external) |
| NoEmailReopen | bool | Whether inbound emails can reopen requests with this status or not |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/List/TicketStatus/Items/Default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketStatusId": 641,
  "Name": "Thiel-Rohan",
  "Status": "Active",
  "TimeCounter": "Externally",
  "NoEmailReopen": true,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 346
    }
  }
}
```