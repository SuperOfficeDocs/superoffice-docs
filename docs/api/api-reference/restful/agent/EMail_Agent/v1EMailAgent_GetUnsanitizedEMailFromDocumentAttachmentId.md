---
title: POST Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
id: v1EMailAgent_GetUnsanitizedEMailFromDocumentAttachmentId
---

# POST Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
```

Get an e-mail based on an email in the archive system and attachment id.

The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId?$select=name,department,category/id
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

DocId, AttachmentIds, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocId | int32 |  |
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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocId": 388,
  "AttachmentIds": [
    "ipsam",
    "aperiam"
  ],
  "IncludeAttachments": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 889,
      "ContactName": "Shanahan-Dietrich",
      "PersonId": 94,
      "PersonName": "Hirthe-Bashirian",
      "AssociateId": 432,
      "Address": "repellendus",
      "EmailId": 506,
      "DuplicatePersonIds": [
        303,
        624
      ],
      "Name": "Gibson-Borer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 370,
      "ContactName": "Rohan-Jenkins",
      "PersonId": 95,
      "PersonName": "Koepp Group",
      "AssociateId": 90,
      "Address": "saepe",
      "EmailId": 965,
      "DuplicatePersonIds": [
        958,
        803
      ],
      "Name": "Gerhold, Bailey and Kassulke",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "target e-business communities"
          },
          "FieldType": "System.String",
          "FieldLength": 69
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 214,
      "ContactName": "Reynolds Group",
      "PersonId": 811,
      "PersonName": "Maggio-Roberts",
      "AssociateId": 732,
      "Address": "omnis",
      "EmailId": 79,
      "DuplicatePersonIds": [
        785,
        1001
      ],
      "Name": "Vandervort Inc and Sons",
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
  "Subject": "qui",
  "HTMLBody": "alias",
  "From": {
    "ContactId": 67,
    "ContactName": "Homenick Inc and Sons",
    "PersonId": 306,
    "PersonName": "Jacobi Inc and Sons",
    "AssociateId": 346,
    "Address": "doloribus",
    "EmailId": 733,
    "DuplicatePersonIds": [
      966,
      280
    ],
    "Name": "Harber, Emmerich and Fadel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 243
      }
    }
  },
  "Sent": "2010-03-19T18:28:49.039962+01:00",
  "Size": 256,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "possimus",
  "PlainBody": "non",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 503,
    "AppointmentId": 13,
    "ProjectId": 781,
    "SaleId": 746,
    "Archived": true,
    "ArchivedAt": "2016-11-25T18:28:49.039962+01:00",
    "ArchivedBy": 575,
    "ArchivedDisplayName": "Hartmann-Hettinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 305
      }
    }
  },
  "ServerId": 180,
  "Attachments": [
    {
      "Description": "Function-based actuating productivity",
      "Filename": "voluptatem",
      "Size": 121,
      "Type": "quibusdam",
      "Encoding": "qui",
      "Id": "consequuntur",
      "Disposition": "explicabo",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 819
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Kuhic Group",
      "Values": [
        "provident",
        "ratione"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 563
        }
      }
    },
    {
      "Name": "Kuhic Group",
      "Values": [
        "provident",
        "ratione"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 563
        }
      }
    }
  ],
  "FolderName": "Schmitt Inc and Sons",
  "EmailItemId": 953,
  "AccountId": 57,
  "ReceivedAt": "1997-09-27T18:28:49.039962+02:00",
  "InReplyTo": {
    "ServerId": 780,
    "MessageId": "explicabo",
    "Subject": "placeat",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1995-07-14T18:28:49.039962+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 923,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 331
      }
    }
  },
  "RepliedAt": "1994-10-19T18:28:49.039962+02:00",
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
        "Reason": "synthesize dot-com technologies"
      },
      "FieldType": "System.String",
      "FieldLength": 322
    }
  }
}
```