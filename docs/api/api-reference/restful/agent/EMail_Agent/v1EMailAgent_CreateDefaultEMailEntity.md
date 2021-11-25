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
      "ContactId": 250,
      "ContactName": "Senger, Denesik and Ritchie",
      "PersonId": 741,
      "PersonName": "Schroeder, Effertz and Kreiger",
      "AssociateId": 784,
      "Address": "voluptas",
      "EmailId": 480,
      "DuplicatePersonIds": [
        444,
        339
      ],
      "Name": "Hodkiewicz, Collier and Howe",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "integrate rich relationships"
          },
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 973,
      "ContactName": "Baumbach, Hermiston and Sauer",
      "PersonId": 453,
      "PersonName": "Leffler-Gerhold",
      "AssociateId": 138,
      "Address": "quaerat",
      "EmailId": 212,
      "DuplicatePersonIds": [
        455,
        842
      ],
      "Name": "Beahan LLC",
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
  "Bcc": [
    {
      "ContactId": 1001,
      "ContactName": "Bergnaum LLC",
      "PersonId": 119,
      "PersonName": "Conn-Swift",
      "AssociateId": 835,
      "Address": "voluptate",
      "EmailId": 853,
      "DuplicatePersonIds": [
        749,
        822
      ],
      "Name": "Casper Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 185
        }
      }
    }
  ],
  "Subject": "impedit",
  "HTMLBody": "molestiae",
  "From": {
    "ContactId": 936,
    "ContactName": "Strosin Group",
    "PersonId": 475,
    "PersonName": "Auer, Wunsch and Gerhold",
    "AssociateId": 992,
    "Address": "exercitationem",
    "EmailId": 418,
    "DuplicatePersonIds": [
      335,
      999
    ],
    "Name": "Homenick-Gutkowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 708
      }
    }
  },
  "Sent": "2021-05-08T18:28:49.0859569+02:00",
  "Size": 73,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "vitae",
  "PlainBody": "non",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 615,
    "AppointmentId": 947,
    "ProjectId": 443,
    "SaleId": 185,
    "Archived": true,
    "ArchivedAt": "2014-07-26T18:28:49.0859569+02:00",
    "ArchivedBy": 880,
    "ArchivedDisplayName": "Wilderman-Hudson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 449
      }
    }
  },
  "ServerId": 831,
  "Attachments": [
    {
      "Description": "Persevering homogeneous core",
      "Filename": "quibusdam",
      "Size": 901,
      "Type": "ut",
      "Encoding": "tempora",
      "Id": "quibusdam",
      "Disposition": "a",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 731
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Brekke LLC",
      "Values": [
        "voluptatem",
        "quia"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    },
    {
      "Name": "Brekke LLC",
      "Values": [
        "voluptatem",
        "quia"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "FolderName": "Emmerich-Dicki",
  "EmailItemId": 626,
  "AccountId": 95,
  "ReceivedAt": "1996-05-16T18:28:49.0869567+02:00",
  "InReplyTo": {
    "ServerId": 527,
    "MessageId": "qui",
    "Subject": "eveniet",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2008-10-25T18:28:49.0869567+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 957,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 405
      }
    }
  },
  "RepliedAt": "2014-10-17T18:28:49.0869567+02:00",
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
      "FieldLength": 507
    }
  }
}
```