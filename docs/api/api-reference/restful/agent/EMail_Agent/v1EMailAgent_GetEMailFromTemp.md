---
title: GetEMailFromTemp
id: v1EMailAgent_GetEMailFromTemp
---

# GetEMailFromTemp

```http
POST /api/v1/Agents/EMail/GetEMailFromTemp
```

<para />

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromTemp?$select=name,department,category/id
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

FileName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FileName | string |  |


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
POST /api/v1/Agents/EMail/GetEMailFromTemp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FileName": "Buckridge LLC"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 228,
      "ContactName": "Hettinger, Johns and Labadie",
      "PersonId": 704,
      "PersonName": "Keebler, Crist and Abshire",
      "AssociateId": 300,
      "Address": "maiores",
      "EmailId": 784,
      "DuplicatePersonIds": [
        872,
        401
      ],
      "Name": "Howe Group",
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
  "Cc": [
    {
      "ContactId": 486,
      "ContactName": "Hoppe Inc and Sons",
      "PersonId": 819,
      "PersonName": "Crona Group",
      "AssociateId": 715,
      "Address": "aut",
      "EmailId": 955,
      "DuplicatePersonIds": [
        870,
        304
      ],
      "Name": "Stroman, Marvin and Satterfield",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 939
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 499,
      "ContactName": "Dare, Schuppe and Erdman",
      "PersonId": 797,
      "PersonName": "Hirthe Group",
      "AssociateId": 430,
      "Address": "aut",
      "EmailId": 880,
      "DuplicatePersonIds": [
        288,
        125
      ],
      "Name": "Bahringer-Feeney",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 288
        }
      }
    }
  ],
  "Subject": "eum",
  "HTMLBody": "aspernatur",
  "From": {
    "ContactId": 548,
    "ContactName": "Fadel-Goldner",
    "PersonId": 957,
    "PersonName": "Smitham LLC",
    "AssociateId": 637,
    "Address": "doloribus",
    "EmailId": 1000,
    "DuplicatePersonIds": [
      977,
      364
    ],
    "Name": "Harvey-Lemke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 426
      }
    }
  },
  "Sent": "2009-03-20T14:58:04.139463+01:00",
  "Size": 747,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "molestiae",
  "PlainBody": "aliquid",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 786,
    "AppointmentId": 348,
    "ProjectId": 818,
    "SaleId": 126,
    "Archived": true,
    "ArchivedAt": "2007-07-21T14:58:04.139463+02:00",
    "ArchivedBy": 153,
    "ArchivedDisplayName": "Kovacek-Corwin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 502
      }
    }
  },
  "ServerId": 551,
  "Attachments": [
    {
      "Description": "Ameliorated demand-driven migration",
      "Filename": "dolore",
      "Size": 753,
      "Type": "aut",
      "Encoding": "tempore",
      "Id": "est",
      "Disposition": "sint",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enable mission-critical technologies"
          },
          "FieldType": "System.String",
          "FieldLength": 643
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Stark Inc and Sons",
      "Values": [
        "amet",
        "odit"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    },
    {
      "Name": "Stark Inc and Sons",
      "Values": [
        "amet",
        "odit"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 805
        }
      }
    }
  ],
  "FolderName": "Kuhic Group",
  "EmailItemId": 330,
  "AccountId": 294,
  "ReceivedAt": "2020-03-23T14:58:04.139463+01:00",
  "InReplyTo": {
    "ServerId": 106,
    "MessageId": "iure",
    "Subject": "impedit",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2009-04-12T14:58:04.139463+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 966,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "implement rich infrastructures"
        },
        "FieldType": "System.Int32",
        "FieldLength": 663
      }
    }
  },
  "RepliedAt": "1996-10-16T14:58:04.1404598+02:00",
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
      "FieldLength": 347
    }
  }
}
```