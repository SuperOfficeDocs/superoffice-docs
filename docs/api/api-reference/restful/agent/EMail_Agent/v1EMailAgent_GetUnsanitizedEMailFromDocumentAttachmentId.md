---
title: GetUnsanitizedEMailFromDocumentAttachmentId
id: v1EMailAgent_GetUnsanitizedEMailFromDocumentAttachmentId
---

# GetUnsanitizedEMailFromDocumentAttachmentId

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocId": 943,
  "AttachmentIds": [
    "delectus",
    "nisi"
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
      "ContactId": 73,
      "ContactName": "Jones-Dietrich",
      "PersonId": 52,
      "PersonName": "Walsh Inc and Sons",
      "AssociateId": 261,
      "Address": "vero",
      "EmailId": 940,
      "DuplicatePersonIds": [
        641,
        400
      ],
      "Name": "Hammes LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 603
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 210,
      "ContactName": "Schamberger, Nicolas and King",
      "PersonId": 766,
      "PersonName": "Kuhlman LLC",
      "AssociateId": 765,
      "Address": "quo",
      "EmailId": 653,
      "DuplicatePersonIds": [
        9,
        709
      ],
      "Name": "Effertz-Marks",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 415
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 767,
      "ContactName": "Bogan LLC",
      "PersonId": 192,
      "PersonName": "Durgan, Bergstrom and Muller",
      "AssociateId": 651,
      "Address": "qui",
      "EmailId": 865,
      "DuplicatePersonIds": [
        585,
        637
      ],
      "Name": "Miller-Johnson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 99
        }
      }
    }
  ],
  "Subject": "aut",
  "HTMLBody": "reprehenderit",
  "From": {
    "ContactId": 479,
    "ContactName": "Huel, Hamill and Ratke",
    "PersonId": 703,
    "PersonName": "Schimmel Inc and Sons",
    "AssociateId": 590,
    "Address": "accusantium",
    "EmailId": 575,
    "DuplicatePersonIds": [
      290,
      285
    ],
    "Name": "Conn-Howe",
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
  "Sent": "2001-06-03T14:58:04.12346+02:00",
  "Size": 652,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "cumque",
  "PlainBody": "libero",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 986,
    "AppointmentId": 438,
    "ProjectId": 801,
    "SaleId": 333,
    "Archived": true,
    "ArchivedAt": "2003-04-12T14:58:04.12346+02:00",
    "ArchivedBy": 307,
    "ArchivedDisplayName": "McGlynn, Renner and Bernhard",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 575
      }
    }
  },
  "ServerId": 848,
  "Attachments": [
    {
      "Description": "Operative intangible challenge",
      "Filename": "iusto",
      "Size": 556,
      "Type": "dolore",
      "Encoding": "quia",
      "Id": "ut",
      "Disposition": "cupiditate",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 211
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "McKenzie-Ryan",
      "Values": [
        "voluptatem",
        "fugiat"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 77
        }
      }
    },
    {
      "Name": "McKenzie-Ryan",
      "Values": [
        "voluptatem",
        "fugiat"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 77
        }
      }
    }
  ],
  "FolderName": "Pouros, Nienow and Huels",
  "EmailItemId": 651,
  "AccountId": 639,
  "ReceivedAt": "2017-01-14T14:58:04.124434+01:00",
  "InReplyTo": {
    "ServerId": 560,
    "MessageId": "rerum",
    "Subject": "minima",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2006-07-22T14:58:04.124434+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 930,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 343
      }
    }
  },
  "RepliedAt": "2021-07-23T14:58:04.124434+02:00",
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
      "FieldType": "System.Int32",
      "FieldLength": 127
    }
  }
}
```