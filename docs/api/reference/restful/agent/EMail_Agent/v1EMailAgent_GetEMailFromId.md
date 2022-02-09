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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": {
    "ServerName": "Greenholt, Hammes and Kutch",
    "UserName": "Rau-Dietrich",
    "Password": "est",
    "Folder": "commodi",
    "UseSSL": false
  },
  "MessageServerId": 576,
  "LookupAddresses": true,
  "Flags": "Answered",
  "IncludeAttachments": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 549,
      "ContactName": "Zieme Group",
      "PersonId": 794,
      "PersonName": "Jast, Bayer and Russel",
      "AssociateId": 302,
      "Address": "fugiat",
      "EmailId": 724,
      "DuplicatePersonIds": [
        396,
        921
      ],
      "Name": "Osinski, Upton and Rohan",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 421
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 527,
      "ContactName": "Lang, Buckridge and Koch",
      "PersonId": 441,
      "PersonName": "Boyle LLC",
      "AssociateId": 963,
      "Address": "quia",
      "EmailId": 147,
      "DuplicatePersonIds": [
        803,
        399
      ],
      "Name": "Harris-Graham",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 35
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 196,
      "ContactName": "Borer-Mills",
      "PersonId": 362,
      "PersonName": "Haley LLC",
      "AssociateId": 516,
      "Address": "est",
      "EmailId": 879,
      "DuplicatePersonIds": [
        471,
        107
      ],
      "Name": "O'Keefe Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    }
  ],
  "Subject": "sit",
  "HTMLBody": "est",
  "From": {
    "ContactId": 906,
    "ContactName": "Heaney LLC",
    "PersonId": 885,
    "PersonName": "Ruecker, Terry and Kuhn",
    "AssociateId": 597,
    "Address": "accusantium",
    "EmailId": 860,
    "DuplicatePersonIds": [
      80,
      906
    ],
    "Name": "Bednar, Kihn and Bogan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 294
      }
    }
  },
  "Sent": "2014-02-04T18:28:49.1129637+01:00",
  "Size": 679,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "laboriosam",
  "PlainBody": "voluptatem",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 21,
    "AppointmentId": 831,
    "ProjectId": 458,
    "SaleId": 34,
    "Archived": false,
    "ArchivedAt": "2019-07-17T18:28:49.1129637+02:00",
    "ArchivedBy": 633,
    "ArchivedDisplayName": "Willms-Abbott",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 631
      }
    }
  },
  "ServerId": 90,
  "Attachments": [
    {
      "Description": "Open-source multi-state Graphical User Interface",
      "Filename": "molestiae",
      "Size": 247,
      "Type": "quas",
      "Encoding": "voluptatibus",
      "Id": "quod",
      "Disposition": "veritatis",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 276
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Adams, Bartell and Mueller",
      "Values": [
        "vel",
        "vel"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    },
    {
      "Name": "Adams, Bartell and Mueller",
      "Values": [
        "vel",
        "vel"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    }
  ],
  "FolderName": "Bauch, Beahan and Friesen",
  "EmailItemId": 366,
  "AccountId": 847,
  "ReceivedAt": "1996-08-17T18:28:49.1139282+02:00",
  "InReplyTo": {
    "ServerId": 776,
    "MessageId": "ut",
    "Subject": "quia",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1997-09-23T18:28:49.1139282+02:00",
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
        "FieldType": "System.String",
        "FieldLength": 467
      }
    }
  },
  "RepliedAt": "2012-01-09T18:28:49.1139282+01:00",
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
      "FieldLength": 614
    }
  }
}
```