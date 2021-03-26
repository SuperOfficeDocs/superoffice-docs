---
title: POST Agents/EMail/SaveDraft
id: v1EMailAgent_SaveDraft
---

# POST Agents/EMail/SaveDraft

```http
POST /api/v1/Agents/EMail/SaveDraft
```

Save the Email entity to the drafts folder



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SaveDraft?$select=name,department,category/id
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

Entity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Entity |  | All information about an e-mail <para /> Carrier object for EMailEntity. Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |


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
POST /api/v1/Agents/EMail/SaveDraft
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Entity": {
    "To": [
      {},
      {}
    ],
    "Cc": [
      {},
      {}
    ],
    "Bcc": [
      {},
      {}
    ],
    "Subject": "est",
    "HTMLBody": "nihil",
    "From": {},
    "Sent": "1997-05-10T16:48:29.5329242+02:00",
    "Size": 412,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "nihil",
    "PlainBody": "iste",
    "IsSent": true,
    "EMailSOInfo": {},
    "ServerId": 863,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Collins-Harris",
    "EmailItemId": 402,
    "AccountId": 224,
    "ReceivedAt": "2006-12-10T16:48:29.5329242+01:00",
    "InReplyTo": {},
    "RepliedAt": "2021-02-05T16:48:29.5329242+01:00",
    "HasCalendarData": true,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 289,
      "ContactName": "Fadel, Beer and Larson",
      "PersonId": 922,
      "PersonName": "Buckridge-Dietrich",
      "AssociateId": 885,
      "Address": "est",
      "EmailId": 852,
      "DuplicatePersonIds": [
        183,
        364
      ],
      "Name": "Will-Hansen",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 460
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 823,
      "ContactName": "Waters, Rohan and Oberbrunner",
      "PersonId": 275,
      "PersonName": "Kovacek Group",
      "AssociateId": 337,
      "Address": "quia",
      "EmailId": 230,
      "DuplicatePersonIds": [
        959,
        288
      ],
      "Name": "Koch-O'Connell",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 844
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 299,
      "ContactName": "Wisoky Group",
      "PersonId": 915,
      "PersonName": "Wiegand Inc and Sons",
      "AssociateId": 736,
      "Address": "sequi",
      "EmailId": 831,
      "DuplicatePersonIds": [
        1000,
        485
      ],
      "Name": "Russel Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 187
        }
      }
    }
  ],
  "Subject": "iure",
  "HTMLBody": "tenetur",
  "From": {
    "ContactId": 407,
    "ContactName": "Kiehn-Streich",
    "PersonId": 319,
    "PersonName": "Boehm Group",
    "AssociateId": 980,
    "Address": "qui",
    "EmailId": 785,
    "DuplicatePersonIds": [
      874,
      361
    ],
    "Name": "Leannon, Kihn and Miller",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 960
      }
    }
  },
  "Sent": "1999-04-06T16:48:29.5349247+02:00",
  "Size": 388,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "cupiditate",
  "PlainBody": "expedita",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 813,
    "AppointmentId": 241,
    "ProjectId": 822,
    "SaleId": 510,
    "Archived": false,
    "ArchivedAt": "2007-05-04T16:48:29.5349247+02:00",
    "ArchivedBy": 386,
    "ArchivedDisplayName": "Toy-Bernier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 399
      }
    }
  },
  "ServerId": 988,
  "Attachments": [
    {
      "Description": "Intuitive optimizing firmware",
      "Filename": "quod",
      "Size": 3,
      "Type": "possimus",
      "Encoding": "ducimus",
      "Id": "inventore",
      "Disposition": "earum",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 324
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "VonRueden, Lindgren and Bechtelar",
      "Values": [
        "dolor",
        "veritatis"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    },
    {
      "Name": "VonRueden, Lindgren and Bechtelar",
      "Values": [
        "dolor",
        "veritatis"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 520
        }
      }
    }
  ],
  "FolderName": "Rowe, Yundt and Prosacco",
  "EmailItemId": 974,
  "AccountId": 903,
  "ReceivedAt": "2015-10-04T16:48:29.5349247+02:00",
  "InReplyTo": {
    "ServerId": 590,
    "MessageId": "eligendi",
    "Subject": "atque",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2013-12-08T16:48:29.5349247+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 452,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 513
      }
    }
  },
  "RepliedAt": "2001-07-17T16:48:29.5349247+02:00",
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
      "FieldLength": 679
    }
  }
}
```