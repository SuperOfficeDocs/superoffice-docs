---
title: GetEMailEnvelopes
id: v1EMailAgent_GetEMailEnvelopes
---

# GetEMailEnvelopes

```http
POST /api/v1/Agents/EMail/GetEMailEnvelopes
```

Retrieve a set of e-mail envelopes



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailEnvelopes?$select=name,department,category/id
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

## Request Body: request  

ConnectionInfo, MessageServerIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| MessageServerIds | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ServerId | int32 | Unique id for the e-mail on the server |
| MessageId | string | Unique id of e-mails |
| Subject | string | Subject of the e-mail |
| From |  | Who did the e-mail originate from |
| To | array | To recipients of e-mail |
| Sent | date-time | When was the e-mail sent |
| Priority | string | Importance of the e-mail |
| Flags | string | Flag status of this mail (unread, replied, deleted ) |
| Size | int32 | Total size of the e-mail |
| EMailSOInfo |  | Glue between SuperOffice data and an e-mail. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/GetEMailEnvelopes
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": {
    "ServerName": "Mertz, Beer and D'Amore",
    "UserName": "Langosh-Braun",
    "Password": "similique",
    "Folder": "eius",
    "UseSSL": false
  },
  "MessageServerIds": [
    812,
    267
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ServerId": 283,
    "MessageId": "aut",
    "Subject": "totam",
    "From": {
      "ContactId": 157,
      "ContactName": "Macejkovic-Emard",
      "PersonId": 841,
      "PersonName": "Armstrong LLC",
      "AssociateId": 9,
      "Address": "aut",
      "EmailId": 338,
      "DuplicatePersonIds": [
        381,
        663
      ],
      "Name": "Olson, Lebsack and Yost",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 265
        }
      }
    },
    "To": [
      {
        "ContactId": 381,
        "ContactName": "Kreiger-Trantow",
        "PersonId": 595,
        "PersonName": "Cummings LLC",
        "AssociateId": 46,
        "Address": "quia",
        "EmailId": 406,
        "DuplicatePersonIds": [
          433,
          382
        ],
        "Name": "Hermiston Group",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 723
          }
        }
      }
    ],
    "Sent": "2008-08-21T14:58:04.125432+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 956,
    "EMailSOInfo": {
      "DocumentId": 52,
      "AppointmentId": 161,
      "ProjectId": 261,
      "SaleId": 758,
      "Archived": false,
      "ArchivedAt": "2007-11-12T14:58:04.125432+01:00",
      "ArchivedBy": 878,
      "ArchivedDisplayName": "Toy, Windler and Casper",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 857
        }
      }
    },
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
        "FieldType": "System.Int32",
        "FieldLength": 976
      }
    }
  }
]
```