---
title: CreateDefaultEMailEntity
id: v1EMailAgent_CreateDefaultEMailEntity
---

# CreateDefaultEMailEntity

```http
POST /api/v1/Agents/EMail/CreateDefaultEMailEntity
```

Set default values into a new EMailEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






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
POST /api/v1/Agents/EMail/CreateDefaultEMailEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 31,
      "ContactName": "Kohler, Schinner and Luettgen",
      "PersonId": 873,
      "PersonName": "Hodkiewicz-Smitham",
      "AssociateId": 526,
      "Address": "blanditiis",
      "EmailId": 543,
      "DuplicatePersonIds": [
        131,
        901
      ],
      "Name": "Donnelly Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 175,
      "ContactName": "Thompson-Kulas",
      "PersonId": 572,
      "PersonName": "Dibbert, Shanahan and Hermann",
      "AssociateId": 632,
      "Address": "nam",
      "EmailId": 477,
      "DuplicatePersonIds": [
        211,
        118
      ],
      "Name": "Bruen-Lubowitz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 872
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 699,
      "ContactName": "Paucek LLC",
      "PersonId": 248,
      "PersonName": "Graham, Ziemann and Breitenberg",
      "AssociateId": 123,
      "Address": "quia",
      "EmailId": 807,
      "DuplicatePersonIds": [
        848,
        917
      ],
      "Name": "Gusikowski Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 635
        }
      }
    }
  ],
  "Subject": "debitis",
  "HTMLBody": "est",
  "From": {
    "ContactId": 173,
    "ContactName": "Rath-Balistreri",
    "PersonId": 531,
    "PersonName": "King, Gutkowski and Walker",
    "AssociateId": 615,
    "Address": "quia",
    "EmailId": 440,
    "DuplicatePersonIds": [
      347,
      542
    ],
    "Name": "Leannon-Lowe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 272
      }
    }
  },
  "Sent": "2002-05-03T14:58:04.1764599+02:00",
  "Size": 52,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ea",
  "PlainBody": "et",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 808,
    "AppointmentId": 712,
    "ProjectId": 558,
    "SaleId": 673,
    "Archived": false,
    "ArchivedAt": "2013-12-04T14:58:04.1764599+01:00",
    "ArchivedBy": 84,
    "ArchivedDisplayName": "Hills-Roob",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 255
      }
    }
  },
  "ServerId": 97,
  "Attachments": [
    {
      "Description": "Implemented static implementation",
      "Filename": "aut",
      "Size": 232,
      "Type": "iure",
      "Encoding": "ut",
      "Id": "distinctio",
      "Disposition": "ut",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "maximize cutting-edge infrastructures"
          },
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Pacocha, Shields and Blick",
      "Values": [
        "sapiente",
        "excepturi"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 798
        }
      }
    },
    {
      "Name": "Pacocha, Shields and Blick",
      "Values": [
        "sapiente",
        "excepturi"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 798
        }
      }
    }
  ],
  "FolderName": "Monahan LLC",
  "EmailItemId": 891,
  "AccountId": 894,
  "ReceivedAt": "1995-07-24T14:58:04.1774609+02:00",
  "InReplyTo": {
    "ServerId": 255,
    "MessageId": "quia",
    "Subject": "assumenda",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1998-07-26T14:58:04.1774609+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 54,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 64
      }
    }
  },
  "RepliedAt": "2016-12-18T14:58:04.1774609+01:00",
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
      "FieldLength": 398
    }
  }
}
```