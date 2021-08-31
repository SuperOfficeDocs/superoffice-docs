---
title: SendEMails
id: v1EMailAgent_SendEMails
---

# SendEMails

```http
POST /api/v1/Agents/EMail/SendEMails
```

Send the provided e-mails



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SendEMails?$select=name,department,category/id
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

OutgoingConnectionInfo, Emails, SentItemsConnectionInfo 

| Property Name | Type |  Description |
|----------------|------|--------------|
| OutgoingConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| Emails | array |  |
| SentItemsConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/EMail/SendEMails
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "OutgoingConnectionInfo": {
    "ServerName": "Armstrong, Bins and Crona",
    "UserName": "Medhurst Inc and Sons",
    "Password": "eos",
    "Folder": "consequatur",
    "UseSSL": false
  },
  "Emails": [
    {
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
      "Subject": "fugit",
      "HTMLBody": "molestiae",
      "From": {},
      "Sent": "2005-07-10T14:58:04.2064603+02:00",
      "Size": 626,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "aut",
      "PlainBody": "aut",
      "IsSent": true,
      "EMailSOInfo": {},
      "ServerId": 508,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Jast Inc and Sons",
      "EmailItemId": 774,
      "AccountId": 712,
      "ReceivedAt": "2001-04-26T14:58:04.2064603+02:00",
      "InReplyTo": {},
      "RepliedAt": "2001-05-01T14:58:04.2064603+02:00",
      "HasCalendarData": false,
      "CalMethod": "Add",
      "CalReplyStatus": "Accepted"
    }
  ],
  "SentItemsConnectionInfo": {
    "ServerName": "Marvin-Nader",
    "UserName": "Rodriguez-Cronin",
    "Password": "molestias",
    "Folder": "tempora",
    "UseSSL": true
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "To": [
      {
        "ContactId": 158,
        "ContactName": "Kris, Rogahn and Bradtke",
        "PersonId": 894,
        "PersonName": "Dietrich-Schamberger",
        "AssociateId": 989,
        "Address": "animi",
        "EmailId": 731,
        "DuplicatePersonIds": [
          487,
          715
        ],
        "Name": "Rowe, Lynch and Heller",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 573
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 563,
        "ContactName": "Torphy Inc and Sons",
        "PersonId": 59,
        "PersonName": "Will LLC",
        "AssociateId": 788,
        "Address": "in",
        "EmailId": 533,
        "DuplicatePersonIds": [
          973,
          436
        ],
        "Name": "Kuphal Inc and Sons",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 652
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 88,
        "ContactName": "Cummerata Inc and Sons",
        "PersonId": 904,
        "PersonName": "Stanton LLC",
        "AssociateId": 27,
        "Address": "et",
        "EmailId": 381,
        "DuplicatePersonIds": [
          143,
          922
        ],
        "Name": "Eichmann, Simonis and Jewess",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 16
          }
        }
      }
    ],
    "Subject": "voluptatem",
    "HTMLBody": "quod",
    "From": {
      "ContactId": 398,
      "ContactName": "Beer-Durgan",
      "PersonId": 88,
      "PersonName": "Stokes-Waelchi",
      "AssociateId": 477,
      "Address": "quisquam",
      "EmailId": 5,
      "DuplicatePersonIds": [
        156,
        884
      ],
      "Name": "Torphy Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    },
    "Sent": "2007-08-06T14:58:04.20846+02:00",
    "Size": 543,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "ipsam",
    "PlainBody": "eos",
    "IsSent": true,
    "EMailSOInfo": {
      "DocumentId": 971,
      "AppointmentId": 15,
      "ProjectId": 107,
      "SaleId": 162,
      "Archived": false,
      "ArchivedAt": "2013-04-24T14:58:04.20846+02:00",
      "ArchivedBy": 533,
      "ArchivedDisplayName": "Cruickshank, Cummings and Larson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 494
        }
      }
    },
    "ServerId": 827,
    "Attachments": [
      {
        "Description": "Expanded bi-directional parallelism",
        "Filename": "magnam",
        "Size": 286,
        "Type": "et",
        "Encoding": "aut",
        "Id": "assumenda",
        "Disposition": "doloribus",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 405
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Quigley, Treutel and Ziemann",
        "Values": [
          "et",
          "earum"
        ],
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 611
          }
        }
      },
      {
        "Name": "Quigley, Treutel and Ziemann",
        "Values": [
          "et",
          "earum"
        ],
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 611
          }
        }
      }
    ],
    "FolderName": "O'Hara Group",
    "EmailItemId": 490,
    "AccountId": 835,
    "ReceivedAt": "2016-10-31T14:58:04.20846+01:00",
    "InReplyTo": {
      "ServerId": 356,
      "MessageId": "illum",
      "Subject": "rerum",
      "From": {},
      "To": [
        {},
        {}
      ],
      "Sent": "2013-05-21T14:58:04.20946+02:00",
      "Priority": "High",
      "Flags": "Answered",
      "Size": 303,
      "EMailSOInfo": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    },
    "RepliedAt": "2001-04-17T14:58:04.20946+02:00",
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
          "Reason": "cultivate global e-tailers"
        },
        "FieldType": "System.Int32",
        "FieldLength": 764
      }
    }
  }
]
```