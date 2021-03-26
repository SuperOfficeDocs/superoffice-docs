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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "OutgoingConnectionInfo": {
    "ServerName": "Schimmel-Willms",
    "UserName": "Runolfsson-Lang",
    "Password": "architecto",
    "Folder": "minima",
    "UseSSL": true
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
      "Subject": "architecto",
      "HTMLBody": "neque",
      "From": {},
      "Sent": "2002-11-28T16:48:29.5869296+01:00",
      "Size": 872,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "nihil",
      "PlainBody": "commodi",
      "IsSent": false,
      "EMailSOInfo": {},
      "ServerId": 158,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Block-Volkman",
      "EmailItemId": 932,
      "AccountId": 417,
      "ReceivedAt": "2017-03-17T16:48:29.5869296+01:00",
      "InReplyTo": {},
      "RepliedAt": "2017-09-29T16:48:29.5869296+02:00",
      "HasCalendarData": true,
      "CalMethod": "Add",
      "CalReplyStatus": "Accepted"
    }
  ],
  "SentItemsConnectionInfo": {
    "ServerName": "Gleason Group",
    "UserName": "Becker Group",
    "Password": "pariatur",
    "Folder": "temporibus",
    "UseSSL": false
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
        "ContactId": 780,
        "ContactName": "Torp-Reichel",
        "PersonId": 373,
        "PersonName": "Olson-Koelpin",
        "AssociateId": 791,
        "Address": "et",
        "EmailId": 264,
        "DuplicatePersonIds": [
          211,
          686
        ],
        "Name": "Leannon-Gerlach",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 9
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 837,
        "ContactName": "Tromp-Lubowitz",
        "PersonId": 302,
        "PersonName": "Stokes-Kshlerin",
        "AssociateId": 72,
        "Address": "dolorum",
        "EmailId": 113,
        "DuplicatePersonIds": [
          379,
          289
        ],
        "Name": "Corwin, Rau and Towne",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 252
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 278,
        "ContactName": "Halvorson, O'Conner and Weber",
        "PersonId": 964,
        "PersonName": "Swift-Borer",
        "AssociateId": 125,
        "Address": "expedita",
        "EmailId": 944,
        "DuplicatePersonIds": [
          12,
          986
        ],
        "Name": "Bernier Group",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 346
          }
        }
      }
    ],
    "Subject": "voluptatem",
    "HTMLBody": "qui",
    "From": {
      "ContactId": 754,
      "ContactName": "Lindgren-Mitchell",
      "PersonId": 659,
      "PersonName": "Kassulke-McDermott",
      "AssociateId": 274,
      "Address": "labore",
      "EmailId": 652,
      "DuplicatePersonIds": [
        676,
        898
      ],
      "Name": "Donnelly, Heidenreich and Kunze",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    },
    "Sent": "2016-08-28T16:48:29.5909344+02:00",
    "Size": 552,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "id",
    "PlainBody": "recusandae",
    "IsSent": false,
    "EMailSOInfo": {
      "DocumentId": 167,
      "AppointmentId": 820,
      "ProjectId": 541,
      "SaleId": 212,
      "Archived": true,
      "ArchivedAt": "2012-03-01T16:48:29.5909344+01:00",
      "ArchivedBy": 488,
      "ArchivedDisplayName": "Ferry-Farrell",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 930
        }
      }
    },
    "ServerId": 422,
    "Attachments": [
      {
        "Description": "Centralized transitional architecture",
        "Filename": "asperiores",
        "Size": 508,
        "Type": "aut",
        "Encoding": "consequatur",
        "Id": "doloribus",
        "Disposition": "omnis",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 342
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Bins Group",
        "Values": [
          "nobis",
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
            "FieldLength": 493
          }
        }
      },
      {
        "Name": "Bins Group",
        "Values": [
          "nobis",
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
            "FieldLength": 493
          }
        }
      }
    ],
    "FolderName": "Adams, Feest and Mueller",
    "EmailItemId": 399,
    "AccountId": 35,
    "ReceivedAt": "2011-02-19T16:48:29.5909344+01:00",
    "InReplyTo": {
      "ServerId": 524,
      "MessageId": "itaque",
      "Subject": "aliquid",
      "From": {},
      "To": [
        {},
        {}
      ],
      "Sent": "2001-11-16T16:48:29.5909344+01:00",
      "Priority": "High",
      "Flags": "Answered",
      "Size": 18,
      "EMailSOInfo": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 976
        }
      }
    },
    "RepliedAt": "2010-02-01T16:48:29.5919308+01:00",
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
        "FieldType": "System.Int32",
        "FieldLength": 659
      }
    }
  }
]
```