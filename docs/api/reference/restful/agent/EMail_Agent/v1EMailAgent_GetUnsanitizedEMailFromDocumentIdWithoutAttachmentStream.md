---
title: POST Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
id: v1EMailAgent_GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream
---

# POST Agents/EMail/GetUnsanitizedEMailFromDocumentIdWithoutAttachmentStream

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
  "DocumentId": 584
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 749,
      "ContactName": "Conn Group",
      "PersonId": 434,
      "PersonName": "Schumm, Ferry and Corkery",
      "AssociateId": 914,
      "Address": "repellendus",
      "EmailId": 152,
      "DuplicatePersonIds": [
        820,
        232
      ],
      "Name": "Bayer Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 957
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 229,
      "ContactName": "Schmidt-Roob",
      "PersonId": 517,
      "PersonName": "Braun Inc and Sons",
      "AssociateId": 270,
      "Address": "temporibus",
      "EmailId": 56,
      "DuplicatePersonIds": [
        944,
        459
      ],
      "Name": "Farrell, Cormier and Schuster",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 636
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 714,
      "ContactName": "Schultz, Dooley and Pollich",
      "PersonId": 271,
      "PersonName": "Lebsack, Kshlerin and Mertz",
      "AssociateId": 735,
      "Address": "repudiandae",
      "EmailId": 585,
      "DuplicatePersonIds": [
        187,
        678
      ],
      "Name": "Leffler-Collier",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 996
        }
      }
    }
  ],
  "Subject": "debitis",
  "HTMLBody": "sit",
  "From": {
    "ContactId": 818,
    "ContactName": "Emard, Littel and Rippin",
    "PersonId": 452,
    "PersonName": "Spinka-Wunsch",
    "AssociateId": 943,
    "Address": "animi",
    "EmailId": 837,
    "DuplicatePersonIds": [
      365,
      745
    ],
    "Name": "Dickinson Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 46
      }
    }
  },
  "Sent": "2008-12-27T18:28:49.00294+01:00",
  "Size": 429,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "doloribus",
  "PlainBody": "qui",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 325,
    "AppointmentId": 919,
    "ProjectId": 941,
    "SaleId": 960,
    "Archived": false,
    "ArchivedAt": "2014-07-13T18:28:49.00294+02:00",
    "ArchivedBy": 53,
    "ArchivedDisplayName": "Hayes, Hamill and Ritchie",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 932
      }
    }
  },
  "ServerId": 300,
  "Attachments": [
    {
      "Description": "Profit-focused tertiary knowledge user",
      "Filename": "est",
      "Size": 727,
      "Type": "recusandae",
      "Encoding": "ut",
      "Id": "vitae",
      "Disposition": "tenetur",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 223
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Parker, Tremblay and Jacobson",
      "Values": [
        "placeat",
        "quia"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 843
        }
      }
    },
    {
      "Name": "Parker, Tremblay and Jacobson",
      "Values": [
        "placeat",
        "quia"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 843
        }
      }
    }
  ],
  "FolderName": "Hegmann, Legros and Heaney",
  "EmailItemId": 853,
  "AccountId": 93,
  "ReceivedAt": "2005-10-20T18:28:49.00294+02:00",
  "InReplyTo": {
    "ServerId": 23,
    "MessageId": "mollitia",
    "Subject": "alias",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2016-10-17T18:28:49.00294+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 969,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 39
      }
    }
  },
  "RepliedAt": "2020-10-02T18:28:49.00294+02:00",
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
      "FieldLength": 450
    }
  }
}
```