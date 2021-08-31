---
title: GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
id: v1EMailAgent_GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
---

# GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
```

Get an e-mail based on an archived document.

The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream?$select=name,department,category/id
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

DocumentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 |  |


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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 915
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 561,
      "ContactName": "Kovacek, Beatty and King",
      "PersonId": 524,
      "PersonName": "Klocko-Williamson",
      "AssociateId": 908,
      "Address": "unde",
      "EmailId": 396,
      "DuplicatePersonIds": [
        634,
        510
      ],
      "Name": "Von, Buckridge and Ruecker",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 24
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 736,
      "ContactName": "Lang, Johnston and Bogisich",
      "PersonId": 854,
      "PersonName": "Cummings-Boyer",
      "AssociateId": 11,
      "Address": "debitis",
      "EmailId": 465,
      "DuplicatePersonIds": [
        823,
        435
      ],
      "Name": "Russel, Raynor and Hilll",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 379,
      "ContactName": "Kreiger LLC",
      "PersonId": 432,
      "PersonName": "Medhurst-Rohan",
      "AssociateId": 538,
      "Address": "voluptas",
      "EmailId": 740,
      "DuplicatePersonIds": [
        311,
        940
      ],
      "Name": "Mayer LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 542
        }
      }
    }
  ],
  "Subject": "possimus",
  "HTMLBody": "consequatur",
  "From": {
    "ContactId": 485,
    "ContactName": "Zemlak Group",
    "PersonId": 990,
    "PersonName": "McKenzie-Haag",
    "AssociateId": 292,
    "Address": "voluptate",
    "EmailId": 609,
    "DuplicatePersonIds": [
      378,
      219
    ],
    "Name": "Kutch, Gerhold and Swift",
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
  "Sent": "1996-02-05T14:58:04.089465+01:00",
  "Size": 672,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "eligendi",
  "PlainBody": "voluptates",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 259,
    "AppointmentId": 437,
    "ProjectId": 470,
    "SaleId": 949,
    "Archived": true,
    "ArchivedAt": "2005-03-13T14:58:04.089465+01:00",
    "ArchivedBy": 834,
    "ArchivedDisplayName": "Dooley-Fritsch",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 693
      }
    }
  },
  "ServerId": 971,
  "Attachments": [
    {
      "Description": "Enhanced asynchronous application",
      "Filename": "veniam",
      "Size": 110,
      "Type": "nihil",
      "Encoding": "ea",
      "Id": "voluptatem",
      "Disposition": "tempora",
      "Stream": "GIF89....File contents as raw bytes...",
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
  "CustomHeaderList": [
    {
      "Name": "Corwin, D'Amore and Upton",
      "Values": [
        "quam",
        "molestiae"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 653
        }
      }
    },
    {
      "Name": "Corwin, D'Amore and Upton",
      "Values": [
        "quam",
        "molestiae"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 653
        }
      }
    }
  ],
  "FolderName": "Christiansen Group",
  "EmailItemId": 173,
  "AccountId": 535,
  "ReceivedAt": "2020-08-29T14:58:04.089465+02:00",
  "InReplyTo": {
    "ServerId": 631,
    "MessageId": "fuga",
    "Subject": "porro",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2021-04-19T14:58:04.0914683+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 944,
    "EMailSOInfo": {},
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
  },
  "RepliedAt": "2011-12-07T14:58:04.0924475+01:00",
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
      "FieldLength": 172
    }
  }
}
```