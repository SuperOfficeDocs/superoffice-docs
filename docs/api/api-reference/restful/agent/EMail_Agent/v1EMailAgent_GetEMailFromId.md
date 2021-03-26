---
title: POST Agents/EMail/GetEMailFromId
id: v1EMailAgent_GetEMailFromId
---

# POST Agents/EMail/GetEMailFromId

```http
POST /api/v1/Agents/EMail/GetEMailFromId
```

Get en e-mail based on its unique id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromId?$select=name,department,category/id
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

ConnectionInfo, MessageServerId, LookupAddresses, Flags, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| MessageServerId | int32 |  |
| LookupAddresses | bool |  |
| Flags | string |  |
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
POST /api/v1/Agents/EMail/GetEMailFromId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": {
    "ServerName": "Cassin Inc and Sons",
    "UserName": "Haley, Rodriguez and Nader",
    "Password": "repudiandae",
    "Folder": "et",
    "UseSSL": true
  },
  "MessageServerId": 605,
  "LookupAddresses": false,
  "Flags": "Answered",
  "IncludeAttachments": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 650,
      "ContactName": "Herzog, Jaskolski and Kirlin",
      "PersonId": 724,
      "PersonName": "Lebsack, Franecki and Kuphal",
      "AssociateId": 903,
      "Address": "sunt",
      "EmailId": 866,
      "DuplicatePersonIds": [
        394,
        137
      ],
      "Name": "Boehm, Brakus and Stiedemann",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 785,
      "ContactName": "DuBuque-Torphy",
      "PersonId": 811,
      "PersonName": "Hirthe-Botsford",
      "AssociateId": 34,
      "Address": "velit",
      "EmailId": 95,
      "DuplicatePersonIds": [
        933,
        63
      ],
      "Name": "Grant Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 945
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 205,
      "ContactName": "Wintheiser Inc and Sons",
      "PersonId": 715,
      "PersonName": "Frami, Gusikowski and Fadel",
      "AssociateId": 549,
      "Address": "qui",
      "EmailId": 179,
      "DuplicatePersonIds": [
        626,
        55
      ],
      "Name": "Brekke-Ratke",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engineer turn-key partnerships"
          },
          "FieldType": "System.String",
          "FieldLength": 300
        }
      }
    }
  ],
  "Subject": "fuga",
  "HTMLBody": "vel",
  "From": {
    "ContactId": 661,
    "ContactName": "Smitham-Christiansen",
    "PersonId": 241,
    "PersonName": "Bode-Fisher",
    "AssociateId": 822,
    "Address": "quas",
    "EmailId": 131,
    "DuplicatePersonIds": [
      795,
      809
    ],
    "Name": "Monahan-Lakin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 771
      }
    }
  },
  "Sent": "2018-10-11T16:48:29.5859298+02:00",
  "Size": 733,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "error",
  "PlainBody": "ullam",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 512,
    "AppointmentId": 265,
    "ProjectId": 233,
    "SaleId": 486,
    "Archived": false,
    "ArchivedAt": "2016-01-01T16:48:29.5859298+01:00",
    "ArchivedBy": 750,
    "ArchivedDisplayName": "Wehner-Bayer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 620
      }
    }
  },
  "ServerId": 350,
  "Attachments": [
    {
      "Description": "Vision-oriented 24/7 service-desk",
      "Filename": "illo",
      "Size": 791,
      "Type": "amet",
      "Encoding": "quae",
      "Id": "fuga",
      "Disposition": "odit",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 943
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "McDermott Inc and Sons",
      "Values": [
        "nemo",
        "dolore"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 395
        }
      }
    },
    {
      "Name": "McDermott Inc and Sons",
      "Values": [
        "nemo",
        "dolore"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 395
        }
      }
    }
  ],
  "FolderName": "Kuhn Group",
  "EmailItemId": 114,
  "AccountId": 21,
  "ReceivedAt": "2020-06-14T16:48:29.5869296+02:00",
  "InReplyTo": {
    "ServerId": 122,
    "MessageId": "unde",
    "Subject": "reiciendis",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2019-07-19T16:48:29.5869296+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 441,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 351
      }
    }
  },
  "RepliedAt": "1998-05-30T16:48:29.5869296+02:00",
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
        "Reason": "repurpose distributed technologies"
      },
      "FieldType": "System.Int32",
      "FieldLength": 735
    }
  }
}
```