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
  "MessageId": "dicta"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 536,
      "ContactName": "Cassin Inc and Sons",
      "PersonId": 108,
      "PersonName": "Thompson, Schroeder and Olson",
      "AssociateId": 766,
      "Address": "animi",
      "EmailId": 571,
      "DuplicatePersonIds": [
        502,
        106
      ],
      "Name": "Erdman-Cole",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 91
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 734,
      "ContactName": "Gerlach-Shields",
      "PersonId": 254,
      "PersonName": "Price, Effertz and Larkin",
      "AssociateId": 460,
      "Address": "dolor",
      "EmailId": 769,
      "DuplicatePersonIds": [
        76,
        703
      ],
      "Name": "Funk Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 536
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 192,
      "ContactName": "Armstrong-Hickle",
      "PersonId": 843,
      "PersonName": "Littel, Crist and Gibson",
      "AssociateId": 126,
      "Address": "dignissimos",
      "EmailId": 374,
      "DuplicatePersonIds": [
        482,
        754
      ],
      "Name": "Pouros Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    }
  ],
  "Subject": "temporibus",
  "HTMLBody": "doloremque",
  "From": {
    "ContactId": 920,
    "ContactName": "Thiel LLC",
    "PersonId": 489,
    "PersonName": "Ritchie-Donnelly",
    "AssociateId": 457,
    "Address": "vel",
    "EmailId": 887,
    "DuplicatePersonIds": [
      52,
      756
    ],
    "Name": "Hessel, Dietrich and Daugherty",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 222
      }
    }
  },
  "Sent": "2010-10-10T16:48:29.5299241+02:00",
  "Size": 978,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ut",
  "PlainBody": "et",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 230,
    "AppointmentId": 635,
    "ProjectId": 812,
    "SaleId": 27,
    "Archived": true,
    "ArchivedAt": "2013-08-16T16:48:29.5299241+02:00",
    "ArchivedBy": 860,
    "ArchivedDisplayName": "Schumm-Purdy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 467
      }
    }
  },
  "ServerId": 809,
  "Attachments": [
    {
      "Description": "User-centric executive productivity",
      "Filename": "vel",
      "Size": 125,
      "Type": "velit",
      "Encoding": "optio",
      "Id": "ut",
      "Disposition": "explicabo",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 841
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "McCullough Inc and Sons",
      "Values": [
        "qui",
        "vitae"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 617
        }
      }
    },
    {
      "Name": "McCullough Inc and Sons",
      "Values": [
        "qui",
        "vitae"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 617
        }
      }
    }
  ],
  "FolderName": "Dietrich-Goodwin",
  "EmailItemId": 512,
  "AccountId": 670,
  "ReceivedAt": "2008-11-12T16:48:29.5299241+01:00",
  "InReplyTo": {
    "ServerId": 749,
    "MessageId": "ea",
    "Subject": "consectetur",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1995-12-26T16:48:29.5299241+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 330,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 543
      }
    }
  },
  "RepliedAt": "2009-03-02T16:48:29.5309245+01:00",
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
      "FieldLength": 575
    }
  }
}
```