---
title: GetUnsanitizedEMailFromDocumentId
id: v1EMailAgent_GetUnsanitizedEMailFromDocumentId
---

# GetUnsanitizedEMailFromDocumentId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId
```

Get an e-mail based on an archived document.

The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 767
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 658,
      "ContactName": "Lehner LLC",
      "PersonId": 863,
      "PersonName": "Langosh-Mante",
      "AssociateId": 796,
      "Address": "ullam",
      "EmailId": 830,
      "DuplicatePersonIds": [
        309,
        131
      ],
      "Name": "Macejkovic LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 305,
      "ContactName": "Davis LLC",
      "PersonId": 72,
      "PersonName": "Ratke-Koelpin",
      "AssociateId": 621,
      "Address": "est",
      "EmailId": 349,
      "DuplicatePersonIds": [
        278,
        462
      ],
      "Name": "Morar-Hirthe",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 19
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 555,
      "ContactName": "Balistreri Group",
      "PersonId": 990,
      "PersonName": "Gislason-Feeney",
      "AssociateId": 594,
      "Address": "aliquam",
      "EmailId": 355,
      "DuplicatePersonIds": [
        561,
        355
      ],
      "Name": "Herman Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 106
        }
      }
    }
  ],
  "Subject": "dolorem",
  "HTMLBody": "deleniti",
  "From": {
    "ContactId": 32,
    "ContactName": "McDermott, West and Douglas",
    "PersonId": 794,
    "PersonName": "Kemmer, Terry and Rohan",
    "AssociateId": 738,
    "Address": "natus",
    "EmailId": 84,
    "DuplicatePersonIds": [
      223,
      451
    ],
    "Name": "Barrows Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 109
      }
    }
  },
  "Sent": "2011-10-04T14:58:04.1094327+02:00",
  "Size": 264,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "aut",
  "PlainBody": "vel",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 416,
    "AppointmentId": 499,
    "ProjectId": 960,
    "SaleId": 707,
    "Archived": false,
    "ArchivedAt": "2013-10-28T14:58:04.1094327+01:00",
    "ArchivedBy": 392,
    "ArchivedDisplayName": "Glover Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 199
      }
    }
  },
  "ServerId": 511,
  "Attachments": [
    {
      "Description": "Reactive responsive forecast",
      "Filename": "ratione",
      "Size": 551,
      "Type": "corrupti",
      "Encoding": "natus",
      "Id": "nobis",
      "Disposition": "ut",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Robel Inc and Sons",
      "Values": [
        "sint",
        "earum"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "orchestrate robust web-readiness"
          },
          "FieldType": "System.String",
          "FieldLength": 963
        }
      }
    },
    {
      "Name": "Robel Inc and Sons",
      "Values": [
        "sint",
        "earum"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "orchestrate robust web-readiness"
          },
          "FieldType": "System.String",
          "FieldLength": 963
        }
      }
    }
  ],
  "FolderName": "Schmeler LLC",
  "EmailItemId": 414,
  "AccountId": 663,
  "ReceivedAt": "2020-08-19T14:58:04.1094327+02:00",
  "InReplyTo": {
    "ServerId": 234,
    "MessageId": "ut",
    "Subject": "facilis",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2017-09-26T14:58:04.1094327+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 498,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 721
      }
    }
  },
  "RepliedAt": "2015-05-02T14:58:04.1094327+02:00",
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
      "FieldLength": 464
    }
  }
}
```