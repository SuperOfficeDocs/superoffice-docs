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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocId": 671,
  "AttachmentIds": [
    "quaerat",
    "in"
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
      "ContactId": 7,
      "ContactName": "Medhurst LLC",
      "PersonId": 995,
      "PersonName": "Quitzon, Block and Champlin",
      "AssociateId": 218,
      "Address": "a",
      "EmailId": 224,
      "DuplicatePersonIds": [
        101,
        344
      ],
      "Name": "Moen, Schneider and Lehner",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 671
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 811,
      "ContactName": "Homenick Inc and Sons",
      "PersonId": 615,
      "PersonName": "Zemlak-Kovacek",
      "AssociateId": 678,
      "Address": "voluptas",
      "EmailId": 257,
      "DuplicatePersonIds": [
        360,
        878
      ],
      "Name": "Macejkovic Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 83
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 207,
      "ContactName": "Schaefer-Mueller",
      "PersonId": 180,
      "PersonName": "Okuneva-Wolf",
      "AssociateId": 481,
      "Address": "omnis",
      "EmailId": 104,
      "DuplicatePersonIds": [
        630,
        786
      ],
      "Name": "Monahan-Mitchell",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "Subject": "omnis",
  "HTMLBody": "nulla",
  "From": {
    "ContactId": 986,
    "ContactName": "Hartmann, Flatley and Hauck",
    "PersonId": 377,
    "PersonName": "Huel, McGlynn and Mitchell",
    "AssociateId": 601,
    "Address": "dignissimos",
    "EmailId": 437,
    "DuplicatePersonIds": [
      27,
      336
    ],
    "Name": "Donnelly-Dooley",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "innovate revolutionary metrics"
        },
        "FieldType": "System.String",
        "FieldLength": 594
      }
    }
  },
  "Sent": "1999-05-06T18:28:49.0359616+02:00",
  "Size": 732,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "officiis",
  "PlainBody": "dolor",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 639,
    "AppointmentId": 325,
    "ProjectId": 734,
    "SaleId": 143,
    "Archived": false,
    "ArchivedAt": "2004-07-11T18:28:49.0359616+02:00",
    "ArchivedBy": 711,
    "ArchivedDisplayName": "Davis Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reintermediate front-end schemas"
        },
        "FieldType": "System.Int32",
        "FieldLength": 657
      }
    }
  },
  "ServerId": 580,
  "Attachments": [
    {
      "Description": "Cross-platform needs-based database",
      "Filename": "praesentium",
      "Size": 293,
      "Type": "omnis",
      "Encoding": "sit",
      "Id": "magnam",
      "Disposition": "cumque",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 12
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Bednar, Mertz and Connelly",
      "Values": [
        "est",
        "architecto"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    },
    {
      "Name": "Bednar, Mertz and Connelly",
      "Values": [
        "est",
        "architecto"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    }
  ],
  "FolderName": "Bosco-Powlowski",
  "EmailItemId": 295,
  "AccountId": 773,
  "ReceivedAt": "2019-06-27T18:28:49.0369625+02:00",
  "InReplyTo": {
    "ServerId": 942,
    "MessageId": "eos",
    "Subject": "qui",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2020-06-22T18:28:49.0369625+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 793,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 498
      }
    }
  },
  "RepliedAt": "2010-05-10T18:28:49.0369625+02:00",
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
      "FieldLength": 813
    }
  }
}
```