---
title: POST Agents/EMail/SendEMails
id: v1EMailAgent_SendEMails
---

# POST Agents/EMail/SendEMails

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "OutgoingConnectionInfo": {
    "ServerName": "Shields-Feil",
    "UserName": "Dooley Inc and Sons",
    "Password": "exercitationem",
    "Folder": "esse",
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
      "Subject": "vel",
      "HTMLBody": "blanditiis",
      "From": {},
      "Sent": "2002-07-30T18:28:49.1139282+02:00",
      "Size": 741,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "qui",
      "PlainBody": "itaque",
      "IsSent": false,
      "EMailSOInfo": {},
      "ServerId": 994,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Pollich-Jones",
      "EmailItemId": 191,
      "AccountId": 461,
      "ReceivedAt": "2020-03-19T18:28:49.1139282+01:00",
      "InReplyTo": {},
      "RepliedAt": "2013-03-21T18:28:49.1139282+01:00",
      "HasCalendarData": false,
      "CalMethod": "Add",
      "CalReplyStatus": "Accepted"
    }
  ],
  "SentItemsConnectionInfo": {
    "ServerName": "Bogan, Ondricka and Stanton",
    "UserName": "O'Hara, Schamberger and Mertz",
    "Password": "at",
    "Folder": "at",
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
        "ContactId": 573,
        "ContactName": "Considine, Gutmann and Ullrich",
        "PersonId": 832,
        "PersonName": "Gerhold, D'Amore and Schmeler",
        "AssociateId": 500,
        "Address": "incidunt",
        "EmailId": 733,
        "DuplicatePersonIds": [
          873,
          337
        ],
        "Name": "Bartoletti, McLaughlin and Howell",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 85
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 863,
        "ContactName": "Hintz Inc and Sons",
        "PersonId": 215,
        "PersonName": "Walker Group",
        "AssociateId": 656,
        "Address": "et",
        "EmailId": 382,
        "DuplicatePersonIds": [
          62,
          855
        ],
        "Name": "Jewess Group",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 302
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 379,
        "ContactName": "Fay, Mosciski and Hayes",
        "PersonId": 749,
        "PersonName": "Gibson, Greenfelder and Windler",
        "AssociateId": 134,
        "Address": "veritatis",
        "EmailId": 445,
        "DuplicatePersonIds": [
          852,
          458
        ],
        "Name": "Bayer, Ziemann and Swift",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 233
          }
        }
      }
    ],
    "Subject": "ad",
    "HTMLBody": "possimus",
    "From": {
      "ContactId": 177,
      "ContactName": "Fisher, Leffler and Block",
      "PersonId": 785,
      "PersonName": "Beer-Considine",
      "AssociateId": 646,
      "Address": "et",
      "EmailId": 221,
      "DuplicatePersonIds": [
        641,
        365
      ],
      "Name": "Hilll-Ruecker",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 962
        }
      }
    },
    "Sent": "1995-03-08T18:28:49.1169561+01:00",
    "Size": 227,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "nesciunt",
    "PlainBody": "repellat",
    "IsSent": true,
    "EMailSOInfo": {
      "DocumentId": 67,
      "AppointmentId": 914,
      "ProjectId": 947,
      "SaleId": 88,
      "Archived": false,
      "ArchivedAt": "2002-03-05T18:28:49.1169561+01:00",
      "ArchivedBy": 604,
      "ArchivedDisplayName": "Gottlieb-Williamson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    },
    "ServerId": 564,
    "Attachments": [
      {
        "Description": "Profound web-enabled standardization",
        "Filename": "et",
        "Size": 731,
        "Type": "nihil",
        "Encoding": "numquam",
        "Id": "sit",
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
            "FieldLength": 146
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Schoen-Larson",
        "Values": [
          "omnis",
          "sint"
        ],
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 452
          }
        }
      },
      {
        "Name": "Schoen-Larson",
        "Values": [
          "omnis",
          "sint"
        ],
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 452
          }
        }
      }
    ],
    "FolderName": "O'Connell-Turcotte",
    "EmailItemId": 54,
    "AccountId": 356,
    "ReceivedAt": "2008-10-31T18:28:49.1179644+01:00",
    "InReplyTo": {
      "ServerId": 750,
      "MessageId": "quis",
      "Subject": "in",
      "From": {},
      "To": [
        {},
        {}
      ],
      "Sent": "2000-04-15T18:28:49.1179644+02:00",
      "Priority": "High",
      "Flags": "Answered",
      "Size": 872,
      "EMailSOInfo": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    },
    "RepliedAt": "2016-06-03T18:28:49.1179644+02:00",
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
        "FieldLength": 92
      }
    }
  }
]
```