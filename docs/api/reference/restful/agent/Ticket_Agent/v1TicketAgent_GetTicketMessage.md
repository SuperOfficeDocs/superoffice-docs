---
title: POST Agents/Ticket/GetTicketMessage
id: v1TicketAgent_GetTicketMessage
---

# POST Agents/Ticket/GetTicketMessage

```http
POST /api/v1/Agents/Ticket/GetTicketMessage
```

Gets a TicketMessage object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ticketMessageId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Ticket/GetTicketMessage?ticketMessageId=50
POST /api/v1/Agents/Ticket/GetTicketMessage?$select=name,department,category/id
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


## Response: object

The TicketMessage carrier is used for representing a service ticket message



Carrier object for TicketMessage.
Services for the TicketMessage Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ITicketAgent">Ticket Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| TicketMessageId | int32 | The primary key (auto-incremented) |
| CreatedAt | date-time | When the message was posted. |
| Slevel | string | The securitylevel of the message. |
| Important | bool | If this message is important or not. |
| Author | string | A string representing the author of the message. Could be a user&amp;apos;s name, or a persons email address. |
| PersonId | int32 | Primary key |
| PersonFullName | string | Get the persons full name (internal name used in clients for employees). |
| ContactId | int32 | Primary key |
| ContactName | string | Contact name |
| ContactDepartment | string | Department |
| NumAttachments | int32 | Number of attachments in the message |
| EmailHeader | string | The email header is saved in this field as raw text |
| MessageHeaders | array | Contains the message headers, like To, Cc, Bcc information, or custom headers |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Ticket/GetTicketMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TicketMessageId": 545,
  "CreatedAt": "2018-03-14T18:28:50.3924156+01:00",
  "Slevel": "External",
  "Important": false,
  "Author": "rerum",
  "PersonId": 814,
  "PersonFullName": "Loyce Legros",
  "ContactId": 615,
  "ContactName": "Schowalter Group",
  "ContactDepartment": "",
  "NumAttachments": 768,
  "EmailHeader": "destiney@pacocha.ca",
  "MessageHeaders": [
    {
      "Name": "Abshire, Cronin and Monahan",
      "Value": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 714
        }
      }
    },
    {
      "Name": "Abshire, Cronin and Monahan",
      "Value": "sit",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 714
        }
      }
    }
  ],
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
      "FieldLength": 674
    }
  }
}
```