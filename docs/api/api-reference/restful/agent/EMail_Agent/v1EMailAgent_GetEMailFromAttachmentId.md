---
title: GetEMailFromAttachmentId
id: v1EMailAgent_GetEMailFromAttachmentId
---

# GetEMailFromAttachmentId

```http
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
```

Get an e-mail based on an email and attachment id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "EmailId": 19,
  "AttachmentIds": [
    "minima",
    "voluptatem"
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
      "ContactId": 695,
      "ContactName": "Moen, Swaniawski and Trantow",
      "PersonId": 874,
      "PersonName": "Rosenbaum, Mertz and Wisozk",
      "AssociateId": 923,
      "Address": "quia",
      "EmailId": 66,
      "DuplicatePersonIds": [
        858,
        613
      ],
      "Name": "Metz Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enable dot-com web-readiness"
          },
          "FieldType": "System.String",
          "FieldLength": 276
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 34,
      "ContactName": "Herman, Kuphal and Heaney",
      "PersonId": 823,
      "PersonName": "Hauck LLC",
      "AssociateId": 459,
      "Address": "doloremque",
      "EmailId": 206,
      "DuplicatePersonIds": [
        253,
        611
      ],
      "Name": "Ratke LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 259
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 518,
      "ContactName": "Reilly Group",
      "PersonId": 662,
      "PersonName": "Cartwright-Lockman",
      "AssociateId": 240,
      "Address": "numquam",
      "EmailId": 621,
      "DuplicatePersonIds": [
        842,
        883
      ],
      "Name": "Boyer-Muller",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 655
        }
      }
    }
  ],
  "Subject": "ipsa",
  "HTMLBody": "reprehenderit",
  "From": {
    "ContactId": 39,
    "ContactName": "Bernier-Kautzer",
    "PersonId": 62,
    "PersonName": "Bogisich, Brown and Ryan",
    "AssociateId": 354,
    "Address": "est",
    "EmailId": 652,
    "DuplicatePersonIds": [
      162,
      552
    ],
    "Name": "Stoltenberg Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 412
      }
    }
  },
  "Sent": "2001-09-30T14:58:04.1124321+02:00",
  "Size": 615,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "consectetur",
  "PlainBody": "id",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 250,
    "AppointmentId": 712,
    "ProjectId": 302,
    "SaleId": 624,
    "Archived": false,
    "ArchivedAt": "2020-04-19T14:58:04.1124321+02:00",
    "ArchivedBy": 121,
    "ArchivedDisplayName": "Satterfield Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 341
      }
    }
  },
  "ServerId": 322,
  "Attachments": [
    {
      "Description": "Virtual user-facing service-desk",
      "Filename": "autem",
      "Size": 182,
      "Type": "velit",
      "Encoding": "et",
      "Id": "praesentium",
      "Disposition": "magnam",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
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
  ],
  "CustomHeaderList": [
    {
      "Name": "Schumm Inc and Sons",
      "Values": [
        "ut",
        "dolorem"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 689
        }
      }
    },
    {
      "Name": "Schumm Inc and Sons",
      "Values": [
        "ut",
        "dolorem"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 689
        }
      }
    }
  ],
  "FolderName": "Heathcote Inc and Sons",
  "EmailItemId": 275,
  "AccountId": 300,
  "ReceivedAt": "1998-11-02T14:58:04.1134325+01:00",
  "InReplyTo": {
    "ServerId": 203,
    "MessageId": "impedit",
    "Subject": "itaque",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2015-12-28T14:58:04.1134325+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 997,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 928
      }
    }
  },
  "RepliedAt": "2018-03-02T14:58:04.1134325+01:00",
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
      "FieldLength": 149
    }
  }
}
```