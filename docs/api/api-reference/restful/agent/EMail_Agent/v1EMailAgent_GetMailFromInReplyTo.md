---
title: GetMailFromInReplyTo
id: v1EMailAgent_GetMailFromInReplyTo
---

# GetMailFromInReplyTo

```http
POST /api/v1/Agents/EMail/GetMailFromInReplyTo
```

Get email from db based on In-Reply-To Message Id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetMailFromInReplyTo?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetMailFromInReplyTo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "MessageId": "dignissimos"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 361,
      "ContactName": "Kautzer Group",
      "PersonId": 267,
      "PersonName": "Wisoky LLC",
      "AssociateId": 239,
      "Address": "et",
      "EmailId": 918,
      "DuplicatePersonIds": [
        144,
        35
      ],
      "Name": "Schneider-Lueilwitz",
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
    }
  ],
  "Cc": [
    {
      "ContactId": 533,
      "ContactName": "Wuckert Group",
      "PersonId": 83,
      "PersonName": "Hahn Group",
      "AssociateId": 639,
      "Address": "quae",
      "EmailId": 485,
      "DuplicatePersonIds": [
        917,
        302
      ],
      "Name": "Lind Group",
      "TableRight": {},
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
  ],
  "Bcc": [
    {
      "ContactId": 373,
      "ContactName": "Tillman, Parker and Leannon",
      "PersonId": 550,
      "PersonName": "Johnson, Prohaska and Paucek",
      "AssociateId": 548,
      "Address": "atque",
      "EmailId": 830,
      "DuplicatePersonIds": [
        38,
        449
      ],
      "Name": "Denesik, Corkery and O'Hara",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 457
        }
      }
    }
  ],
  "Subject": "tempora",
  "HTMLBody": "incidunt",
  "From": {
    "ContactId": 264,
    "ContactName": "Greenfelder, Koss and Nolan",
    "PersonId": 254,
    "PersonName": "Effertz Inc and Sons",
    "AssociateId": 226,
    "Address": "cupiditate",
    "EmailId": 376,
    "DuplicatePersonIds": [
      261,
      938
    ],
    "Name": "Kunze LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 95
      }
    }
  },
  "Sent": "1997-07-20T14:58:04.0764653+02:00",
  "Size": 671,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "est",
  "PlainBody": "molestiae",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 297,
    "AppointmentId": 817,
    "ProjectId": 710,
    "SaleId": 159,
    "Archived": true,
    "ArchivedAt": "2010-12-13T14:58:04.0764653+01:00",
    "ArchivedBy": 77,
    "ArchivedDisplayName": "Feeney Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 627
      }
    }
  },
  "ServerId": 622,
  "Attachments": [
    {
      "Description": "Extended hybrid monitoring",
      "Filename": "a",
      "Size": 824,
      "Type": "quaerat",
      "Encoding": "dolorem",
      "Id": "fuga",
      "Disposition": "quaerat",
      "Stream": "GIF89....File contents as raw bytes...",
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
  "CustomHeaderList": [
    {
      "Name": "Gibson, Quitzon and O'Reilly",
      "Values": [
        "voluptates",
        "nihil"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 432
        }
      }
    },
    {
      "Name": "Gibson, Quitzon and O'Reilly",
      "Values": [
        "voluptates",
        "nihil"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 432
        }
      }
    }
  ],
  "FolderName": "Breitenberg, Baumbach and Champlin",
  "EmailItemId": 107,
  "AccountId": 725,
  "ReceivedAt": "2018-08-27T14:58:04.0764653+02:00",
  "InReplyTo": {
    "ServerId": 320,
    "MessageId": "molestiae",
    "Subject": "iste",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2001-08-09T14:58:04.0764653+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 770,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 283
      }
    }
  },
  "RepliedAt": "2004-09-04T14:58:04.0764653+02:00",
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
      "FieldType": "System.String",
      "FieldLength": 536
    }
  }
}
```