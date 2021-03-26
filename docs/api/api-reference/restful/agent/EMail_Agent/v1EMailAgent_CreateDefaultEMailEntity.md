---
title: POST Agents/EMail/CreateDefaultEMailEntity
id: v1EMailAgent_CreateDefaultEMailEntity
---

# POST Agents/EMail/CreateDefaultEMailEntity

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
      "ContactId": 121,
      "ContactName": "Ryan LLC",
      "PersonId": 23,
      "PersonName": "Brakus-Willms",
      "AssociateId": 599,
      "Address": "esse",
      "EmailId": 77,
      "DuplicatePersonIds": [
        652,
        766
      ],
      "Name": "Ullrich-Adams",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 452
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 952,
      "ContactName": "Lebsack-Zieme",
      "PersonId": 967,
      "PersonName": "Swift-Halvorson",
      "AssociateId": 728,
      "Address": "ut",
      "EmailId": 315,
      "DuplicatePersonIds": [
        369,
        294
      ],
      "Name": "Franecki-Weber",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 656
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 569,
      "ContactName": "Harber, Kautzer and Carroll",
      "PersonId": 444,
      "PersonName": "Ferry, Christiansen and Nienow",
      "AssociateId": 394,
      "Address": "quia",
      "EmailId": 170,
      "DuplicatePersonIds": [
        685,
        253
      ],
      "Name": "Bednar-Anderson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 973
        }
      }
    }
  ],
  "Subject": "omnis",
  "HTMLBody": "rem",
  "From": {
    "ContactId": 780,
    "ContactName": "Bernier-Mann",
    "PersonId": 320,
    "PersonName": "Schinner-Homenick",
    "AssociateId": 612,
    "Address": "similique",
    "EmailId": 849,
    "DuplicatePersonIds": [
      185,
      915
    ],
    "Name": "Mertz Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 126
      }
    }
  },
  "Sent": "1994-04-29T16:48:29.5579246+02:00",
  "Size": 998,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "laudantium",
  "PlainBody": "optio",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 261,
    "AppointmentId": 669,
    "ProjectId": 836,
    "SaleId": 973,
    "Archived": true,
    "ArchivedAt": "2005-04-29T16:48:29.5579246+02:00",
    "ArchivedBy": 61,
    "ArchivedDisplayName": "Blanda Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 60
      }
    }
  },
  "ServerId": 859,
  "Attachments": [
    {
      "Description": "Diverse solution-oriented extranet",
      "Filename": "ad",
      "Size": 222,
      "Type": "sed",
      "Encoding": "ut",
      "Id": "nam",
      "Disposition": "repellat",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "extend cross-platform e-commerce"
          },
          "FieldType": "System.String",
          "FieldLength": 900
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Effertz Group",
      "Values": [
        "sed",
        "debitis"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 912
        }
      }
    },
    {
      "Name": "Effertz Group",
      "Values": [
        "sed",
        "debitis"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 912
        }
      }
    }
  ],
  "FolderName": "O'Keefe, Hessel and McGlynn",
  "EmailItemId": 151,
  "AccountId": 448,
  "ReceivedAt": "2009-09-18T16:48:29.5579246+02:00",
  "InReplyTo": {
    "ServerId": 776,
    "MessageId": "unde",
    "Subject": "fuga",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2010-08-28T16:48:29.5579246+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 75,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 101
      }
    }
  },
  "RepliedAt": "2008-09-25T16:48:29.5579246+02:00",
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
      "FieldType": "System.String",
      "FieldLength": 240
    }
  }
}
```