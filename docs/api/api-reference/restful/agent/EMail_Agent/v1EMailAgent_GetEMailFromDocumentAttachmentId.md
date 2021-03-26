---
title: POST Agents/EMail/GetEMailFromDocumentAttachmentId
id: v1EMailAgent_GetEMailFromDocumentAttachmentId
---

# POST Agents/EMail/GetEMailFromDocumentAttachmentId

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId
```

Get an e-mail based on an email in the archive system and attachment id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocId": 958,
  "AttachmentIds": [
    "eum",
    "animi"
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
      "ContactId": 132,
      "ContactName": "Pfannerstill Inc and Sons",
      "PersonId": 301,
      "PersonName": "Ondricka-Dare",
      "AssociateId": 946,
      "Address": "non",
      "EmailId": 226,
      "DuplicatePersonIds": [
        600,
        659
      ],
      "Name": "Kovacek-Lubowitz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 131
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 194,
      "ContactName": "Schowalter Inc and Sons",
      "PersonId": 729,
      "PersonName": "King, Turner and Pacocha",
      "AssociateId": 150,
      "Address": "soluta",
      "EmailId": 52,
      "DuplicatePersonIds": [
        189,
        875
      ],
      "Name": "Parisian Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 242
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 348,
      "ContactName": "Sawayn LLC",
      "PersonId": 129,
      "PersonName": "Ryan, Dickinson and Bode",
      "AssociateId": 256,
      "Address": "iusto",
      "EmailId": 939,
      "DuplicatePersonIds": [
        957,
        877
      ],
      "Name": "Marquardt, McLaughlin and Effertz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 392
        }
      }
    }
  ],
  "Subject": "unde",
  "HTMLBody": "molestias",
  "From": {
    "ContactId": 451,
    "ContactName": "Dickens, Johnston and Prohaska",
    "PersonId": 604,
    "PersonName": "Reinger, Legros and Heaney",
    "AssociateId": 206,
    "Address": "omnis",
    "EmailId": 131,
    "DuplicatePersonIds": [
      483,
      68
    ],
    "Name": "Hammes-Morar",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 783
      }
    }
  },
  "Sent": "2016-06-18T16:48:29.6099284+02:00",
  "Size": 263,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ea",
  "PlainBody": "labore",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 659,
    "AppointmentId": 182,
    "ProjectId": 327,
    "SaleId": 321,
    "Archived": false,
    "ArchivedAt": "1998-06-20T16:48:29.6099284+02:00",
    "ArchivedBy": 657,
    "ArchivedDisplayName": "Wyman, Fahey and Heathcote",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 453
      }
    }
  },
  "ServerId": 145,
  "Attachments": [
    {
      "Description": "Seamless uniform secured line",
      "Filename": "recusandae",
      "Size": 222,
      "Type": "corporis",
      "Encoding": "perferendis",
      "Id": "dignissimos",
      "Disposition": "voluptatibus",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 232
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Mayert Group",
      "Values": [
        "quia",
        "nam"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 805
        }
      }
    },
    {
      "Name": "Mayert Group",
      "Values": [
        "quia",
        "nam"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 805
        }
      }
    }
  ],
  "FolderName": "Schoen LLC",
  "EmailItemId": 807,
  "AccountId": 113,
  "ReceivedAt": "2016-04-15T16:48:29.6099284+02:00",
  "InReplyTo": {
    "ServerId": 440,
    "MessageId": "perferendis",
    "Subject": "iusto",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2005-01-25T16:48:29.6099284+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 879,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 3
      }
    }
  },
  "RepliedAt": "1997-09-17T16:48:29.6099284+02:00",
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
      "FieldLength": 89
    }
  }
}
```