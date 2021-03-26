---
title: POST Agents/EMail/Send
id: v1EMailAgent_Send
---

# POST Agents/EMail/Send

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
Accept-Language: sv
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
      "Subject": "eaque",
      "HTMLBody": "commodi",
      "From": {},
      "Sent": "1998-03-05T16:48:29.5118974+01:00",
      "Size": 816,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "velit",
      "PlainBody": "laudantium",
      "IsSent": false,
      "EMailSOInfo": {},
      "ServerId": 662,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Renner Inc and Sons",
      "EmailItemId": 77,
      "AccountId": 729,
      "ReceivedAt": "2007-11-22T16:48:29.5118974+01:00",
      "InReplyTo": {},
      "RepliedAt": "2007-06-24T16:48:29.5118974+02:00",
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
        "ContactId": 705,
        "ContactName": "Herzog-Stracke",
        "PersonId": 393,
        "PersonName": "Ryan-Leuschke",
        "AssociateId": 242,
        "Address": "delectus",
        "EmailId": 470,
        "DuplicatePersonIds": [
          283,
          924
        ],
        "Name": "Hansen Group",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 384
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 159,
        "ContactName": "Johnson, Nienow and King",
        "PersonId": 800,
        "PersonName": "Senger LLC",
        "AssociateId": 551,
        "Address": "optio",
        "EmailId": 380,
        "DuplicatePersonIds": [
          448,
          518
        ],
        "Name": "Runte-Carter",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 748
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 794,
        "ContactName": "Parker, Nitzsche and Weissnat",
        "PersonId": 442,
        "PersonName": "Johns, Keebler and Emard",
        "AssociateId": 405,
        "Address": "unde",
        "EmailId": 647,
        "DuplicatePersonIds": [
          941,
          227
        ],
        "Name": "O'Reilly, Olson and Ratke",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 773
          }
        }
      }
    ],
    "Subject": "voluptatum",
    "HTMLBody": "assumenda",
    "From": {
      "ContactId": 125,
      "ContactName": "Gleichner, Padberg and Heathcote",
      "PersonId": 412,
      "PersonName": "Kemmer Group",
      "AssociateId": 811,
      "Address": "tempore",
      "EmailId": 13,
      "DuplicatePersonIds": [
        949,
        119
      ],
      "Name": "Greenholt-Crist",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 546
        }
      }
    },
    "Sent": "2016-05-07T16:48:29.5139242+02:00",
    "Size": 667,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "id",
    "PlainBody": "voluptates",
    "IsSent": false,
    "EMailSOInfo": {
      "DocumentId": 467,
      "AppointmentId": 896,
      "ProjectId": 44,
      "SaleId": 298,
      "Archived": false,
      "ArchivedAt": "1995-04-16T16:48:29.5139242+02:00",
      "ArchivedBy": 729,
      "ArchivedDisplayName": "Collins, Klocko and Kutch",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engineer rich infomediaries"
          },
          "FieldType": "System.String",
          "FieldLength": 939
        }
      }
    },
    "ServerId": 922,
    "Attachments": [
      {
        "Description": "Multi-layered optimizing local area network",
        "Filename": "sequi",
        "Size": 581,
        "Type": "id",
        "Encoding": "voluptatem",
        "Id": "ducimus",
        "Disposition": "ipsa",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 971
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Kub-Kohler",
        "Values": [
          "minima",
          "velit"
        ],
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 858
          }
        }
      },
      {
        "Name": "Kub-Kohler",
        "Values": [
          "minima",
          "velit"
        ],
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 858
          }
        }
      }
    ],
    "FolderName": "Mraz Group",
    "EmailItemId": 803,
    "AccountId": 730,
    "ReceivedAt": "2009-05-03T16:48:29.5149243+02:00",
    "InReplyTo": {
      "ServerId": 991,
      "MessageId": "eius",
      "Subject": "porro",
      "From": {},
      "To": [
        {},
        {}
      ],
      "Sent": "2021-01-22T16:48:29.5149243+01:00",
      "Priority": "High",
      "Flags": "Answered",
      "Size": 857,
      "EMailSOInfo": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 228
        }
      }
    },
    "RepliedAt": "2019-08-07T16:48:29.5149243+02:00",
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
        "FieldLength": 813
      }
    }
  }
]
```