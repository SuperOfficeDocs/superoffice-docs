---
title: POST Agents/EMail/GetMailFromMessageId
id: v1EMailAgent_GetMailFromMessageId
---

# POST Agents/EMail/GetMailFromMessageId

```http
POST /api/v1/Agents/EMail/GetMailFromMessageId
```

Get email from db based on Message Id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetMailFromMessageId?$select=name,department,category/id
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

MessageId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MessageId | string |  |


## Response: object

All information about an e-mail



Carrier object for EMailEntity.
Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| To | array | To recipients of e-mail |
| Cc | array | Cc recipients of e-mail |
| Bcc | array | Bcc recipient of e-mail |
| Subject | string | Subject of the e-mail |
| HTMLBody | string | Body formatted in HTML |
| From |  | Who did the e-mail originate from |
| Sent | date-time | When was the e-mail sent |
| Size | int32 | Total size of the e-mail |
| Priority | string | Importance of the e-mail |
| Flags | string | Flag status of this mail (unread, replied, deleted ) |
| MessageID | string | Unique id of e-mails |
| PlainBody | string | Body formatted in plain text |
| IsSent | bool | Is this a sent e-mail (not new) |
| EMailSOInfo |  | Glue between SuperOffice data and an e-mail. |
| ServerId | int32 | Unique id for the e-mail on the server |
| Attachments | array |  |
| CustomHeaderList | array | Non standard e-mail headers |
| FolderName | string | Name of folder the e-mail belongs in |
| EmailItemId | int32 | Primary key |
| AccountId | int32 | Account Id |
| ReceivedAt | date-time | Received date time |
| InReplyTo |  | The envelope of the email this email is a reply to, if it exists |
| RepliedAt | date-time | When this email was replied at |
| HasCalendarData | bool | If this email contains exactly one iCal appointment |
| CalMethod | string | Method stored in the associated iCal appointment. Indicates if the iCal data is a reply, counter proposal etc. |
| CalReplyStatus | string | Reply status stored in calendar data for the ical method is REPLY |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/GetMailFromMessageId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MessageId": "suscipit"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 117,
      "ContactName": "Little, DuBuque and Weber",
      "PersonId": 373,
      "PersonName": "Bartoletti, Langosh and Medhurst",
      "AssociateId": 620,
      "Address": "debitis",
      "EmailId": 162,
      "DuplicatePersonIds": [
        320,
        969
      ],
      "Name": "Ryan LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 429,
      "ContactName": "Ebert Group",
      "PersonId": 148,
      "PersonName": "Zemlak LLC",
      "AssociateId": 229,
      "Address": "molestiae",
      "EmailId": 499,
      "DuplicatePersonIds": [
        34,
        291
      ],
      "Name": "Douglas, Johnson and Klocko",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 674
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 79,
      "ContactName": "Stoltenberg-Weissnat",
      "PersonId": 29,
      "PersonName": "Hilpert LLC",
      "AssociateId": 757,
      "Address": "vel",
      "EmailId": 961,
      "DuplicatePersonIds": [
        122,
        29
      ],
      "Name": "Leuschke, Maggio and Schneider",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 54
        }
      }
    }
  ],
  "Subject": "nam",
  "HTMLBody": "cum",
  "From": {
    "ContactId": 218,
    "ContactName": "Ziemann-Goodwin",
    "PersonId": 649,
    "PersonName": "Padberg Group",
    "AssociateId": 101,
    "Address": "ut",
    "EmailId": 205,
    "DuplicatePersonIds": [
      201,
      742
    ],
    "Name": "Romaguera LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 171
      }
    }
  },
  "Sent": "1998-04-01T16:48:29.5269275+02:00",
  "Size": 477,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "facere",
  "PlainBody": "minima",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 713,
    "AppointmentId": 201,
    "ProjectId": 659,
    "SaleId": 351,
    "Archived": true,
    "ArchivedAt": "1999-05-18T16:48:29.5269275+02:00",
    "ArchivedBy": 480,
    "ArchivedDisplayName": "Davis-Schaefer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 176
      }
    }
  },
  "ServerId": 570,
  "Attachments": [
    {
      "Description": "Horizontal mission-critical productivity",
      "Filename": "quidem",
      "Size": 485,
      "Type": "voluptatibus",
      "Encoding": "molestias",
      "Id": "aspernatur",
      "Disposition": "eum",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 476
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Smitham Group",
      "Values": [
        "pariatur",
        "iure"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "cultivate customized users"
          },
          "FieldType": "System.String",
          "FieldLength": 913
        }
      }
    },
    {
      "Name": "Smitham Group",
      "Values": [
        "pariatur",
        "iure"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "cultivate customized users"
          },
          "FieldType": "System.String",
          "FieldLength": 913
        }
      }
    }
  ],
  "FolderName": "Hahn LLC",
  "EmailItemId": 883,
  "AccountId": 976,
  "ReceivedAt": "2011-09-19T16:48:29.5279245+02:00",
  "InReplyTo": {
    "ServerId": 644,
    "MessageId": "eos",
    "Subject": "dignissimos",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1998-03-08T16:48:29.5279245+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 365,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 803
      }
    }
  },
  "RepliedAt": "1996-11-03T16:48:29.5279245+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
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
      "FieldLength": 395
    }
  }
}
```