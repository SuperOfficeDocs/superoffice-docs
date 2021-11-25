---
title: POST Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
id: v1EMailAgent_GetEMailFromDocumentIdWithoutAttachmentStream
---

# POST Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
```

Get an e-mail based on an archived document



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 791
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 831,
      "ContactName": "Labadie, Kovacek and O'Conner",
      "PersonId": 6,
      "PersonName": "Sawayn-Rolfson",
      "AssociateId": 73,
      "Address": "perferendis",
      "EmailId": 18,
      "DuplicatePersonIds": [
        571,
        604
      ],
      "Name": "Lockman Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 581
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 897,
      "ContactName": "Rosenbaum-Kuvalis",
      "PersonId": 922,
      "PersonName": "Kutch, Harris and Koepp",
      "AssociateId": 181,
      "Address": "natus",
      "EmailId": 780,
      "DuplicatePersonIds": [
        293,
        131
      ],
      "Name": "Purdy Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 786
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 342,
      "ContactName": "Beer-Considine",
      "PersonId": 783,
      "PersonName": "Muller, Harris and Bergnaum",
      "AssociateId": 328,
      "Address": "magnam",
      "EmailId": 963,
      "DuplicatePersonIds": [
        896,
        716
      ],
      "Name": "Boehm Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 299
        }
      }
    }
  ],
  "Subject": "blanditiis",
  "HTMLBody": "enim",
  "From": {
    "ContactId": 146,
    "ContactName": "Bogan-Herman",
    "PersonId": 278,
    "PersonName": "Morissette Inc and Sons",
    "AssociateId": 274,
    "Address": "ducimus",
    "EmailId": 778,
    "DuplicatePersonIds": [
      97,
      529
    ],
    "Name": "Collier, Buckridge and Bruen",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 237
      }
    }
  },
  "Sent": "2008-05-03T18:28:48.9979582+02:00",
  "Size": 562,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ut",
  "PlainBody": "ipsa",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 605,
    "AppointmentId": 354,
    "ProjectId": 472,
    "SaleId": 833,
    "Archived": true,
    "ArchivedAt": "2015-02-25T18:28:48.9989585+01:00",
    "ArchivedBy": 714,
    "ArchivedDisplayName": "Murazik LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 701
      }
    }
  },
  "ServerId": 309,
  "Attachments": [
    {
      "Description": "Programmable optimizing paradigm",
      "Filename": "sit",
      "Size": 461,
      "Type": "voluptatem",
      "Encoding": "voluptates",
      "Id": "cupiditate",
      "Disposition": "ullam",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 231
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Spinka LLC",
      "Values": [
        "optio",
        "necessitatibus"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 896
        }
      }
    },
    {
      "Name": "Spinka LLC",
      "Values": [
        "optio",
        "necessitatibus"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 896
        }
      }
    }
  ],
  "FolderName": "Moore-Wisozk",
  "EmailItemId": 863,
  "AccountId": 899,
  "ReceivedAt": "2013-05-15T18:28:48.9989585+02:00",
  "InReplyTo": {
    "ServerId": 252,
    "MessageId": "impedit",
    "Subject": "ut",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1999-09-29T18:28:48.9989585+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 924,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 751
      }
    }
  },
  "RepliedAt": "2012-02-18T18:28:48.9989585+01:00",
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
      "FieldLength": 293
    }
  }
}
```