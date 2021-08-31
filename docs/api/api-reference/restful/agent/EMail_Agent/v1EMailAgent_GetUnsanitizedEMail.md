---
title: GetUnsanitizedEMail
id: v1EMailAgent_GetUnsanitizedEMail
---

# GetUnsanitizedEMail

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMail
```

Get en e-mail based on its primary key in the DB.

The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMail?$select=name,department,category/id
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

Id, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 |  |
| IncludeAttachments | bool |  |


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
POST /api/v1/Agents/EMail/GetUnsanitizedEMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Id": 462,
  "IncludeAttachments": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 691,
      "ContactName": "McKenzie-Johns",
      "PersonId": 419,
      "PersonName": "Leuschke, Crona and Leannon",
      "AssociateId": 656,
      "Address": "blanditiis",
      "EmailId": 90,
      "DuplicatePersonIds": [
        966,
        320
      ],
      "Name": "Franecki-Langworth",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 151
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 40,
      "ContactName": "Hauck, Corkery and Kuhic",
      "PersonId": 949,
      "PersonName": "Ebert Group",
      "AssociateId": 528,
      "Address": "necessitatibus",
      "EmailId": 816,
      "DuplicatePersonIds": [
        709,
        826
      ],
      "Name": "Lockman Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 512
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 745,
      "ContactName": "Langosh Inc and Sons",
      "PersonId": 891,
      "PersonName": "Koss-Hodkiewicz",
      "AssociateId": 42,
      "Address": "et",
      "EmailId": 542,
      "DuplicatePersonIds": [
        587,
        723
      ],
      "Name": "Glover LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    }
  ],
  "Subject": "minus",
  "HTMLBody": "voluptatem",
  "From": {
    "ContactId": 613,
    "ContactName": "Abernathy, Wisoky and Mitchell",
    "PersonId": 610,
    "PersonName": "Lockman, Leffler and Cassin",
    "AssociateId": 165,
    "Address": "totam",
    "EmailId": 60,
    "DuplicatePersonIds": [
      624,
      741
    ],
    "Name": "Kub-Wisoky",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 105
      }
    }
  },
  "Sent": "2017-02-10T14:58:04.1494305+01:00",
  "Size": 279,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "quis",
  "PlainBody": "est",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 316,
    "AppointmentId": 871,
    "ProjectId": 280,
    "SaleId": 813,
    "Archived": true,
    "ArchivedAt": "2010-05-20T14:58:04.1494305+02:00",
    "ArchivedBy": 438,
    "ArchivedDisplayName": "Swift Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 639
      }
    }
  },
  "ServerId": 906,
  "Attachments": [
    {
      "Description": "Operative explicit local area network",
      "Filename": "similique",
      "Size": 766,
      "Type": "officiis",
      "Encoding": "et",
      "Id": "est",
      "Disposition": "harum",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 439
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hamill, Miller and Satterfield",
      "Values": [
        "enim",
        "ab"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "empower robust convergence"
          },
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    },
    {
      "Name": "Hamill, Miller and Satterfield",
      "Values": [
        "enim",
        "ab"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "empower robust convergence"
          },
          "FieldType": "System.Int32",
          "FieldLength": 642
        }
      }
    }
  ],
  "FolderName": "Kessler, Aufderhar and Raynor",
  "EmailItemId": 280,
  "AccountId": 119,
  "ReceivedAt": "2003-02-05T14:58:04.1494305+01:00",
  "InReplyTo": {
    "ServerId": 140,
    "MessageId": "temporibus",
    "Subject": "harum",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2001-11-13T14:58:04.1494305+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 273,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 197
      }
    }
  },
  "RepliedAt": "2012-12-14T14:58:04.1494305+01:00",
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
      "FieldLength": 593
    }
  }
}
```