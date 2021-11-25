---
title: POST Agents/EMail/GetMailFromInReplyTo
id: v1EMailAgent_GetMailFromInReplyTo
---

# POST Agents/EMail/GetMailFromInReplyTo

```http
POST /api/v1/Agents/EMail/GetMailFromInReplyTo
```

Get email from db based on In-Reply-To Message Id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetMailFromInReplyTo?$select=name,department,category/id
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

MessageId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MessageId | string |  |


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
POST /api/v1/Agents/EMail/GetMailFromInReplyTo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MessageId": "officiis"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 164,
      "ContactName": "Gottlieb-Klocko",
      "PersonId": 213,
      "PersonName": "Rippin-Bechtelar",
      "AssociateId": 905,
      "Address": "est",
      "EmailId": 29,
      "DuplicatePersonIds": [
        222,
        205
      ],
      "Name": "Will Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 943,
      "ContactName": "Weissnat-Kautzer",
      "PersonId": 70,
      "PersonName": "Stehr-Cummerata",
      "AssociateId": 904,
      "Address": "necessitatibus",
      "EmailId": 70,
      "DuplicatePersonIds": [
        993,
        227
      ],
      "Name": "Bins-Kuhic",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enable clicks-and-mortar content"
          },
          "FieldType": "System.Int32",
          "FieldLength": 242
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 175,
      "ContactName": "Stanton Inc and Sons",
      "PersonId": 383,
      "PersonName": "Hoppe Group",
      "AssociateId": 134,
      "Address": "eius",
      "EmailId": 760,
      "DuplicatePersonIds": [
        338,
        32
      ],
      "Name": "Bogan Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 724
        }
      }
    }
  ],
  "Subject": "tempora",
  "HTMLBody": "id",
  "From": {
    "ContactId": 887,
    "ContactName": "Jacobs Inc and Sons",
    "PersonId": 142,
    "PersonName": "Kuphal Inc and Sons",
    "AssociateId": 704,
    "Address": "rerum",
    "EmailId": 604,
    "DuplicatePersonIds": [
      830,
      786
    ],
    "Name": "Hand-Wolff",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 731
      }
    }
  },
  "Sent": "2001-10-02T18:28:48.9899549+02:00",
  "Size": 458,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "quia",
  "PlainBody": "id",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 215,
    "AppointmentId": 957,
    "ProjectId": 873,
    "SaleId": 421,
    "Archived": true,
    "ArchivedAt": "2021-10-17T18:28:48.9899549+02:00",
    "ArchivedBy": 985,
    "ArchivedDisplayName": "Zemlak, Tillman and Raynor",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 259
      }
    }
  },
  "ServerId": 484,
  "Attachments": [
    {
      "Description": "Balanced attitude-oriented function",
      "Filename": "maxime",
      "Size": 25,
      "Type": "aut",
      "Encoding": "voluptatem",
      "Id": "dolor",
      "Disposition": "aut",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 186
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Ward Group",
      "Values": [
        "quis",
        "laboriosam"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    },
    {
      "Name": "Ward Group",
      "Values": [
        "quis",
        "laboriosam"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 288
        }
      }
    }
  ],
  "FolderName": "Brakus Group",
  "EmailItemId": 365,
  "AccountId": 531,
  "ReceivedAt": "2016-05-09T18:28:48.9899549+02:00",
  "InReplyTo": {
    "ServerId": 24,
    "MessageId": "autem",
    "Subject": "consectetur",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2000-02-04T18:28:48.9899549+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 348,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 111
      }
    }
  },
  "RepliedAt": "1995-07-02T18:28:48.9899549+02:00",
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
      "FieldLength": 768
    }
  }
}
```