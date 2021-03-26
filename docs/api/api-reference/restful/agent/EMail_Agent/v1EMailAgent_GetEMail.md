---
title: POST Agents/EMail/GetEMail
id: v1EMailAgent_GetEMail
---

# POST Agents/EMail/GetEMail

```http
POST /api/v1/Agents/EMail/GetEMail
```

Get en e-mail based on its primary key in the DB



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMail?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetEMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Id": 47,
  "IncludeAttachments": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 205,
      "ContactName": "Dibbert, Zboncak and Parisian",
      "PersonId": 311,
      "PersonName": "Cremin-Schulist",
      "AssociateId": 245,
      "Address": "at",
      "EmailId": 74,
      "DuplicatePersonIds": [
        33,
        1000
      ],
      "Name": "Powlowski, Heidenreich and Ondricka",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 40
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 288,
      "ContactName": "Wilkinson, Kirlin and Luettgen",
      "PersonId": 823,
      "PersonName": "Hickle LLC",
      "AssociateId": 671,
      "Address": "aut",
      "EmailId": 730,
      "DuplicatePersonIds": [
        900,
        96
      ],
      "Name": "Franecki-Waelchi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "iterate proactive content"
          },
          "FieldType": "System.String",
          "FieldLength": 658
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 509,
      "ContactName": "Langosh, Yundt and Bruen",
      "PersonId": 191,
      "PersonName": "Wuckert-West",
      "AssociateId": 902,
      "Address": "qui",
      "EmailId": 859,
      "DuplicatePersonIds": [
        100,
        334
      ],
      "Name": "Terry-Rogahn",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 271
        }
      }
    }
  ],
  "Subject": "animi",
  "HTMLBody": "esse",
  "From": {
    "ContactId": 142,
    "ContactName": "Boyer, Champlin and Fahey",
    "PersonId": 499,
    "PersonName": "Schinner Inc and Sons",
    "AssociateId": 889,
    "Address": "vel",
    "EmailId": 277,
    "DuplicatePersonIds": [
      481,
      274
    ],
    "Name": "Sauer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 825
      }
    }
  },
  "Sent": "1995-06-21T16:48:29.5029249+02:00",
  "Size": 629,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "facilis",
  "PlainBody": "labore",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 915,
    "AppointmentId": 996,
    "ProjectId": 701,
    "SaleId": 51,
    "Archived": false,
    "ArchivedAt": "1997-01-12T16:48:29.5029249+01:00",
    "ArchivedBy": 821,
    "ArchivedDisplayName": "Lowe, Powlowski and Berge",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 501
      }
    }
  },
  "ServerId": 475,
  "Attachments": [
    {
      "Description": "Reactive 24 hour workforce",
      "Filename": "vero",
      "Size": 556,
      "Type": "voluptatem",
      "Encoding": "dolorem",
      "Id": "explicabo",
      "Disposition": "ut",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engineer wireless e-business"
          },
          "FieldType": "System.Int32",
          "FieldLength": 577
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Larkin-Corkery",
      "Values": [
        "quia",
        "recusandae"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 929
        }
      }
    },
    {
      "Name": "Larkin-Corkery",
      "Values": [
        "quia",
        "recusandae"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 929
        }
      }
    }
  ],
  "FolderName": "Smitham-Lynch",
  "EmailItemId": 638,
  "AccountId": 643,
  "ReceivedAt": "2000-09-04T16:48:29.5029249+02:00",
  "InReplyTo": {
    "ServerId": 225,
    "MessageId": "et",
    "Subject": "minus",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1995-11-02T16:48:29.5029249+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 760,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 238
      }
    }
  },
  "RepliedAt": "2003-10-13T16:48:29.5029249+02:00",
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
      "FieldLength": 61
    }
  }
}
```