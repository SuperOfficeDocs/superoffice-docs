---
title: POST Agents/EMail/GetUnsanitizedEMail
id: v1EMailAgent_GetUnsanitizedEMail
---

# POST Agents/EMail/GetUnsanitizedEMail

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMail
```

Get en e-mail based on its primary key in the DB.

The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMail?$select=name,department,category/id
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

Id, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 |  |
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
POST /api/v1/Agents/EMail/GetUnsanitizedEMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Id": 905,
  "IncludeAttachments": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 764,
      "ContactName": "Kris Inc and Sons",
      "PersonId": 588,
      "PersonName": "Schimmel-Nienow",
      "AssociateId": 397,
      "Address": "atque",
      "EmailId": 169,
      "DuplicatePersonIds": [
        215,
        199
      ],
      "Name": "Heller, Johns and Wehner",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 77,
      "ContactName": "Frami-Beatty",
      "PersonId": 285,
      "PersonName": "Hayes Inc and Sons",
      "AssociateId": 499,
      "Address": "qui",
      "EmailId": 933,
      "DuplicatePersonIds": [
        134,
        661
      ],
      "Name": "Hermiston LLC",
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
    }
  ],
  "Bcc": [
    {
      "ContactId": 746,
      "ContactName": "Kessler, Jewess and Cremin",
      "PersonId": 976,
      "PersonName": "Bernier, Conroy and Zemlak",
      "AssociateId": 530,
      "Address": "eaque",
      "EmailId": 92,
      "DuplicatePersonIds": [
        45,
        935
      ],
      "Name": "Fadel-Mertz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 215
        }
      }
    }
  ],
  "Subject": "veniam",
  "HTMLBody": "magnam",
  "From": {
    "ContactId": 193,
    "ContactName": "Lehner Group",
    "PersonId": 42,
    "PersonName": "Rohan-Harber",
    "AssociateId": 672,
    "Address": "harum",
    "EmailId": 133,
    "DuplicatePersonIds": [
      225,
      576
    ],
    "Name": "Hermann Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "evolve front-end infrastructures"
        },
        "FieldType": "System.Int32",
        "FieldLength": 867
      }
    }
  },
  "Sent": "2005-02-05T18:28:49.0639699+01:00",
  "Size": 54,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "iste",
  "PlainBody": "dolores",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 724,
    "AppointmentId": 575,
    "ProjectId": 11,
    "SaleId": 609,
    "Archived": true,
    "ArchivedAt": "2008-07-17T18:28:49.0639699+02:00",
    "ArchivedBy": 383,
    "ArchivedDisplayName": "Rosenbaum LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 374
      }
    }
  },
  "ServerId": 725,
  "Attachments": [
    {
      "Description": "Balanced high-level task-force",
      "Filename": "ipsum",
      "Size": 971,
      "Type": "architecto",
      "Encoding": "libero",
      "Id": "doloribus",
      "Disposition": "sapiente",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "engineer dot-com web-readiness"
          },
          "FieldType": "System.String",
          "FieldLength": 3
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Rogahn Group",
      "Values": [
        "qui",
        "consequatur"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    },
    {
      "Name": "Rogahn Group",
      "Values": [
        "qui",
        "consequatur"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "FolderName": "Macejkovic, Rice and Kohler",
  "EmailItemId": 618,
  "AccountId": 771,
  "ReceivedAt": "1995-06-26T18:28:49.0639699+02:00",
  "InReplyTo": {
    "ServerId": 119,
    "MessageId": "et",
    "Subject": "itaque",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2016-09-16T18:28:49.0639699+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 325,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 413
      }
    }
  },
  "RepliedAt": "2020-07-20T18:28:49.0639699+02:00",
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
      "FieldLength": 874
    }
  }
}
```