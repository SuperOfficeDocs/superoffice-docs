---
title: CreateEMailFromMimeMessage
id: v1EMailAgent_CreateEMailFromMimeMessage
---

# CreateEMailFromMimeMessage

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
  "MimeMessage": "eius"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 239,
      "ContactName": "Kassulke, Koelpin and Grady",
      "PersonId": 888,
      "PersonName": "Howell, Rowe and Christiansen",
      "AssociateId": 11,
      "Address": "animi",
      "EmailId": 503,
      "DuplicatePersonIds": [
        669,
        412
      ],
      "Name": "Anderson-Windler",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 285
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 393,
      "ContactName": "Wintheiser-Weissnat",
      "PersonId": 425,
      "PersonName": "Littel, Kris and Raynor",
      "AssociateId": 802,
      "Address": "unde",
      "EmailId": 375,
      "DuplicatePersonIds": [
        292,
        808
      ],
      "Name": "Hayes, Harvey and Hackett",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 527
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 637,
      "ContactName": "Halvorson-Schimmel",
      "PersonId": 406,
      "PersonName": "Feil, Reichel and Ondricka",
      "AssociateId": 283,
      "Address": "aperiam",
      "EmailId": 91,
      "DuplicatePersonIds": [
        321,
        945
      ],
      "Name": "Medhurst-Eichmann",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 824
        }
      }
    }
  ],
  "Subject": "exercitationem",
  "HTMLBody": "possimus",
  "From": {
    "ContactId": 340,
    "ContactName": "Sporer-Fadel",
    "PersonId": 528,
    "PersonName": "Klein, Stanton and Hansen",
    "AssociateId": 338,
    "Address": "alias",
    "EmailId": 143,
    "DuplicatePersonIds": [
      588,
      483
    ],
    "Name": "Bruen Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 354
      }
    }
  },
  "Sent": "2010-10-13T14:58:04.1334325+02:00",
  "Size": 865,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "facilis",
  "PlainBody": "vel",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 25,
    "AppointmentId": 676,
    "ProjectId": 648,
    "SaleId": 558,
    "Archived": false,
    "ArchivedAt": "1997-09-04T14:58:04.1334325+02:00",
    "ArchivedBy": 441,
    "ArchivedDisplayName": "Schultz, McClure and Fisher",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 594
      }
    }
  },
  "ServerId": 75,
  "Attachments": [
    {
      "Description": "Business-focused scalable standardization",
      "Filename": "soluta",
      "Size": 637,
      "Type": "ipsa",
      "Encoding": "modi",
      "Id": "molestias",
      "Disposition": "dolorem",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hane LLC",
      "Values": [
        "et",
        "tempore"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 478
        }
      }
    },
    {
      "Name": "Hane LLC",
      "Values": [
        "et",
        "tempore"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 478
        }
      }
    }
  ],
  "FolderName": "Schamberger-Kunde",
  "EmailItemId": 124,
  "AccountId": 144,
  "ReceivedAt": "2003-03-25T14:58:04.1344627+01:00",
  "InReplyTo": {
    "ServerId": 837,
    "MessageId": "aut",
    "Subject": "iure",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1999-07-05T14:58:04.1344627+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 393,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 652
      }
    }
  },
  "RepliedAt": "2000-07-23T14:58:04.1344627+02:00",
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
      "FieldLength": 662
    }
  }
}
```