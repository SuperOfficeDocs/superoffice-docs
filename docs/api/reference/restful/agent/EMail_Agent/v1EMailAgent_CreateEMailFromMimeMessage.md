---
title: POST Agents/EMail/CreateEMailFromMimeMessage
id: v1EMailAgent_CreateEMailFromMimeMessage
---

# POST Agents/EMail/CreateEMailFromMimeMessage

```http
POST /api/v1/Agents/EMail/CreateEMailFromMimeMessage
```

Get an e-mail based on the provided MIME-message



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/CreateEMailFromMimeMessage?$select=name,department,category/id
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

MimeMessage 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MimeMessage | string |  |


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
POST /api/v1/Agents/EMail/CreateEMailFromMimeMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MimeMessage": "consectetur"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 4,
      "ContactName": "Reichert Group",
      "PersonId": 444,
      "PersonName": "Collier, Denesik and Zboncak",
      "AssociateId": 18,
      "Address": "quis",
      "EmailId": 945,
      "DuplicatePersonIds": [
        500,
        16
      ],
      "Name": "Dickinson-Fadel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 362
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 898,
      "ContactName": "Balistreri-Shanahan",
      "PersonId": 228,
      "PersonName": "Wisoky-Von",
      "AssociateId": 935,
      "Address": "quos",
      "EmailId": 620,
      "DuplicatePersonIds": [
        515,
        677
      ],
      "Name": "Ledner Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "optimize efficient communities"
          },
          "FieldType": "System.String",
          "FieldLength": 963
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 431,
      "ContactName": "Howell, Jast and Kunde",
      "PersonId": 909,
      "PersonName": "Zieme Inc and Sons",
      "AssociateId": 643,
      "Address": "ea",
      "EmailId": 751,
      "DuplicatePersonIds": [
        618,
        751
      ],
      "Name": "Emmerich-Bins",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 327
        }
      }
    }
  ],
  "Subject": "laboriosam",
  "HTMLBody": "libero",
  "From": {
    "ContactId": 953,
    "ContactName": "Schmeler Group",
    "PersonId": 797,
    "PersonName": "Rodriguez-Bergstrom",
    "AssociateId": 398,
    "Address": "voluptatem",
    "EmailId": 558,
    "DuplicatePersonIds": [
      421,
      27
    ],
    "Name": "Kulas-Moore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 778
      }
    }
  },
  "Sent": "2003-12-07T18:28:49.0489689+01:00",
  "Size": 731,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "dolorem",
  "PlainBody": "dolorem",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 896,
    "AppointmentId": 52,
    "ProjectId": 247,
    "SaleId": 832,
    "Archived": false,
    "ArchivedAt": "1994-11-18T18:28:49.0489689+01:00",
    "ArchivedBy": 201,
    "ArchivedDisplayName": "Stamm LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 404
      }
    }
  },
  "ServerId": 218,
  "Attachments": [
    {
      "Description": "Programmable multi-state analyzer",
      "Filename": "corporis",
      "Size": 714,
      "Type": "omnis",
      "Encoding": "necessitatibus",
      "Id": "autem",
      "Disposition": "rerum",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 902
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Kirlin Inc and Sons",
      "Values": [
        "officia",
        "et"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    },
    {
      "Name": "Kirlin Inc and Sons",
      "Values": [
        "officia",
        "et"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    }
  ],
  "FolderName": "Botsford-Kemmer",
  "EmailItemId": 329,
  "AccountId": 456,
  "ReceivedAt": "2016-08-16T18:28:49.0499621+02:00",
  "InReplyTo": {
    "ServerId": 838,
    "MessageId": "aperiam",
    "Subject": "reprehenderit",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2000-07-02T18:28:49.0499621+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 942,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 385
      }
    }
  },
  "RepliedAt": "2007-01-20T18:28:49.0499621+01:00",
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
      "FieldLength": 989
    }
  }
}
```