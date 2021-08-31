---
title: Send
id: v1EMailAgent_Send
---

# Send

```http
POST /api/v1/Agents/EMail/Send
```

Send the provided e-mails



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/Send?$select=name,department,category/id
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

Emails 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Emails | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/EMail/Send
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Emails": [
    {
      "To": [
        {},
        {}
      ],
      "Cc": [
        {},
        {}
      ],
      "Bcc": [
        {},
        {}
      ],
      "Subject": "et",
      "HTMLBody": "doloremque",
      "From": {},
      "Sent": "2014-12-02T14:58:04.1574302+01:00",
      "Size": 676,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "fuga",
      "PlainBody": "aliquid",
      "IsSent": true,
      "EMailSOInfo": {},
      "ServerId": 126,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Howe Group",
      "EmailItemId": 767,
      "AccountId": 302,
      "ReceivedAt": "2006-06-12T14:58:04.1584305+02:00",
      "InReplyTo": {},
      "RepliedAt": "2005-09-18T14:58:04.1584305+02:00",
      "HasCalendarData": false,
      "CalMethod": "Add",
      "CalReplyStatus": "Accepted"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "To": [
      {
        "ContactId": 83,
        "ContactName": "Swaniawski-Hettinger",
        "PersonId": 160,
        "PersonName": "Auer Group",
        "AssociateId": 78,
        "Address": "voluptates",
        "EmailId": 911,
        "DuplicatePersonIds": [
          42,
          400
        ],
        "Name": "Wolff-Kreiger",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 623
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 475,
        "ContactName": "DuBuque, Rempel and Jerde",
        "PersonId": 173,
        "PersonName": "Brekke LLC",
        "AssociateId": 700,
        "Address": "qui",
        "EmailId": 342,
        "DuplicatePersonIds": [
          429,
          816
        ],
        "Name": "Ledner-Buckridge",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 776
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 550,
        "ContactName": "Zemlak Inc and Sons",
        "PersonId": 273,
        "PersonName": "Brekke-Leffler",
        "AssociateId": 571,
        "Address": "quia",
        "EmailId": 92,
        "DuplicatePersonIds": [
          610,
          574
        ],
        "Name": "Nicolas-Roberts",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 735
          }
        }
      }
    ],
    "Subject": "doloribus",
    "HTMLBody": "cumque",
    "From": {
      "ContactId": 973,
      "ContactName": "Little-Wilkinson",
      "PersonId": 679,
      "PersonName": "Dickinson, Jacobson and Price",
      "AssociateId": 337,
      "Address": "minus",
      "EmailId": 314,
      "DuplicatePersonIds": [
        901,
        602
      ],
      "Name": "Schulist, Christiansen and Doyle",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 244
        }
      }
    },
    "Sent": "2000-10-11T14:58:04.1624302+02:00",
    "Size": 892,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "rem",
    "PlainBody": "aut",
    "IsSent": true,
    "EMailSOInfo": {
      "DocumentId": 537,
      "AppointmentId": 405,
      "ProjectId": 302,
      "SaleId": 803,
      "Archived": false,
      "ArchivedAt": "2005-12-04T14:58:04.1624302+01:00",
      "ArchivedBy": 893,
      "ArchivedDisplayName": "Cole, Paucek and Upton",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 433
        }
      }
    },
    "ServerId": 136,
    "Attachments": [
      {
        "Description": "Horizontal optimizing synergy",
        "Filename": "repellendus",
        "Size": 333,
        "Type": "voluptatem",
        "Encoding": "repellendus",
        "Id": "nemo",
        "Disposition": "quis",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 84
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Upton LLC",
        "Values": [
          "iusto",
          "labore"
        ],
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 912
          }
        }
      },
      {
        "Name": "Upton LLC",
        "Values": [
          "iusto",
          "labore"
        ],
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 912
          }
        }
      }
    ],
    "FolderName": "Frami Group",
    "EmailItemId": 942,
    "AccountId": 707,
    "ReceivedAt": "2009-02-04T14:58:04.1624302+01:00",
    "InReplyTo": {
      "ServerId": 732,
      "MessageId": "animi",
      "Subject": "sed",
      "From": {},
      "To": [
        {},
        {}
      ],
      "Sent": "1995-07-15T14:58:04.1624302+02:00",
      "Priority": "High",
      "Flags": "Answered",
      "Size": 779,
      "EMailSOInfo": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 763
        }
      }
    },
    "RepliedAt": "2001-01-04T14:58:04.1624302+01:00",
    "HasCalendarData": true,
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
        "FieldLength": 683
      }
    }
  }
]
```