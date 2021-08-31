---
title: GetUnsanitizedEMailFromAttachmentId
id: v1EMailAgent_GetUnsanitizedEMailFromAttachmentId
---

# GetUnsanitizedEMailFromAttachmentId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromAttachmentId
```

Get an e-mail based on an email and attachment id.

The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromAttachmentId?$select=name,department,category/id
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

EmailId, AttachmentIds, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailId | int32 |  |
| AttachmentIds | array |  |
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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EmailId": 455,
  "AttachmentIds": [
    "eos",
    "excepturi"
  ],
  "IncludeAttachments": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 817,
      "ContactName": "Russel Inc and Sons",
      "PersonId": 571,
      "PersonName": "Kuhic-Okuneva",
      "AssociateId": 25,
      "Address": "qui",
      "EmailId": 828,
      "DuplicatePersonIds": [
        60,
        145
      ],
      "Name": "Feil-Jast",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 928,
      "ContactName": "Lesch LLC",
      "PersonId": 194,
      "PersonName": "Donnelly-Hoppe",
      "AssociateId": 899,
      "Address": "sint",
      "EmailId": 108,
      "DuplicatePersonIds": [
        252,
        705
      ],
      "Name": "Heaney-Stroman",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 823
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 428,
      "ContactName": "Daniel Group",
      "PersonId": 587,
      "PersonName": "Schiller-Connelly",
      "AssociateId": 816,
      "Address": "nesciunt",
      "EmailId": 957,
      "DuplicatePersonIds": [
        545,
        891
      ],
      "Name": "Feest, Lemke and Hirthe",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 127
        }
      }
    }
  ],
  "Subject": "ut",
  "HTMLBody": "consequatur",
  "From": {
    "ContactId": 441,
    "ContactName": "Trantow, Lindgren and Kshlerin",
    "PersonId": 531,
    "PersonName": "Ebert-Kuphal",
    "AssociateId": 938,
    "Address": "natus",
    "EmailId": 609,
    "DuplicatePersonIds": [
      964,
      406
    ],
    "Name": "Boehm LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "repurpose wireless bandwidth"
        },
        "FieldType": "System.Int32",
        "FieldLength": 334
      }
    }
  },
  "Sent": "1996-03-31T14:58:04.1164307+02:00",
  "Size": 464,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ad",
  "PlainBody": "dolore",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 202,
    "AppointmentId": 845,
    "ProjectId": 250,
    "SaleId": 273,
    "Archived": false,
    "ArchivedAt": "2004-06-01T14:58:04.1164307+02:00",
    "ArchivedBy": 388,
    "ArchivedDisplayName": "Howell Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 917
      }
    }
  },
  "ServerId": 887,
  "Attachments": [
    {
      "Description": "Assimilated 5th generation leverage",
      "Filename": "similique",
      "Size": 103,
      "Type": "minima",
      "Encoding": "non",
      "Id": "et",
      "Disposition": "nam",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 314
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Ruecker, Macejkovic and Ziemann",
      "Values": [
        "temporibus",
        "voluptas"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 241
        }
      }
    },
    {
      "Name": "Ruecker, Macejkovic and Ziemann",
      "Values": [
        "temporibus",
        "voluptas"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 241
        }
      }
    }
  ],
  "FolderName": "Crona-Little",
  "EmailItemId": 280,
  "AccountId": 517,
  "ReceivedAt": "2014-07-23T14:58:04.1174303+02:00",
  "InReplyTo": {
    "ServerId": 698,
    "MessageId": "cum",
    "Subject": "in",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2006-04-06T14:58:04.1174303+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 112,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 192
      }
    }
  },
  "RepliedAt": "2014-01-24T14:58:04.1174303+01:00",
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
      "FieldLength": 15
    }
  }
}
```