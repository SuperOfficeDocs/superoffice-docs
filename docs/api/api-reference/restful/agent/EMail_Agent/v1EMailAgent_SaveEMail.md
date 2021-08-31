---
title: SaveEMail
id: v1EMailAgent_SaveEMail
---

# SaveEMail

```http
POST /api/v1/Agents/EMail/SaveEMail
```

Save the passed e-mail back to the server



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SaveEMail?$select=name,department,category/id
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

ConnectionInfo, Email 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| Email |  | All information about an e-mail <para /> Carrier object for EMailEntity. Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |


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
POST /api/v1/Agents/EMail/SaveEMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": {
    "ServerName": "Gutkowski Group",
    "UserName": "Wolf-Jakubowski",
    "Password": "qui",
    "Folder": "voluptatem",
    "UseSSL": false
  },
  "Email": {
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
    "Subject": "et",
    "HTMLBody": "maxime",
    "From": {},
    "Sent": "1994-11-30T14:58:04.20946+01:00",
    "Size": 501,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "omnis",
    "PlainBody": "ipsum",
    "IsSent": true,
    "EMailSOInfo": {},
    "ServerId": 583,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Macejkovic LLC",
    "EmailItemId": 29,
    "AccountId": 428,
    "ReceivedAt": "2014-09-20T14:58:04.20946+02:00",
    "InReplyTo": {},
    "RepliedAt": "2007-09-14T14:58:04.20946+02:00",
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
      "ContactId": 200,
      "ContactName": "Hirthe-Mayer",
      "PersonId": 254,
      "PersonName": "Romaguera-Herman",
      "AssociateId": 127,
      "Address": "commodi",
      "EmailId": 278,
      "DuplicatePersonIds": [
        827,
        951
      ],
      "Name": "Wiegand Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 599
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 951,
      "ContactName": "Mayer, Klein and Ankunding",
      "PersonId": 545,
      "PersonName": "Reichel, Hintz and Cummerata",
      "AssociateId": 579,
      "Address": "nulla",
      "EmailId": 274,
      "DuplicatePersonIds": [
        371,
        60
      ],
      "Name": "Boyer Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 994
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 181,
      "ContactName": "Fay Inc and Sons",
      "PersonId": 924,
      "PersonName": "Toy, Kilback and Stanton",
      "AssociateId": 404,
      "Address": "magnam",
      "EmailId": 623,
      "DuplicatePersonIds": [
        801,
        124
      ],
      "Name": "Skiles Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    }
  ],
  "Subject": "voluptatibus",
  "HTMLBody": "soluta",
  "From": {
    "ContactId": 894,
    "ContactName": "Swift, Erdman and Beier",
    "PersonId": 707,
    "PersonName": "Ruecker LLC",
    "AssociateId": 281,
    "Address": "eum",
    "EmailId": 911,
    "DuplicatePersonIds": [
      842,
      484
    ],
    "Name": "Reinger, Zboncak and Johnson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 943
      }
    }
  },
  "Sent": "1998-03-15T14:58:04.2124604+01:00",
  "Size": 953,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "excepturi",
  "PlainBody": "nostrum",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 485,
    "AppointmentId": 245,
    "ProjectId": 988,
    "SaleId": 100,
    "Archived": false,
    "ArchivedAt": "2004-06-14T14:58:04.2124604+02:00",
    "ArchivedBy": 343,
    "ArchivedDisplayName": "Yundt, Stiedemann and Jacobson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 15
      }
    }
  },
  "ServerId": 793,
  "Attachments": [
    {
      "Description": "Expanded real-time analyzer",
      "Filename": "natus",
      "Size": 655,
      "Type": "quidem",
      "Encoding": "sit",
      "Id": "labore",
      "Disposition": "quia",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 534
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "O'Reilly, Stehr and Hoppe",
      "Values": [
        "aspernatur",
        "nihil"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 101
        }
      }
    },
    {
      "Name": "O'Reilly, Stehr and Hoppe",
      "Values": [
        "aspernatur",
        "nihil"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 101
        }
      }
    }
  ],
  "FolderName": "Kunze-Schowalter",
  "EmailItemId": 469,
  "AccountId": 668,
  "ReceivedAt": "2001-03-09T14:58:04.2134607+01:00",
  "InReplyTo": {
    "ServerId": 339,
    "MessageId": "eligendi",
    "Subject": "ipsam",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2012-01-09T14:58:04.2134607+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 361,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 609
      }
    }
  },
  "RepliedAt": "2010-09-02T14:58:04.2134607+02:00",
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
      "FieldLength": 249
    }
  }
}
```