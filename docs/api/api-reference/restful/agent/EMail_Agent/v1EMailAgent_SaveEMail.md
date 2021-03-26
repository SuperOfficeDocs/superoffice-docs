---
title: POST Agents/EMail/SaveEMail
id: v1EMailAgent_SaveEMail
---

# POST Agents/EMail/SaveEMail

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
    "ServerName": "Kozey Group",
    "UserName": "Bergstrom-Abbott",
    "Password": "consequatur",
    "Folder": "occaecati",
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
    "Subject": "quae",
    "HTMLBody": "debitis",
    "From": {},
    "Sent": "2001-06-22T16:48:29.5919308+02:00",
    "Size": 126,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "cupiditate",
    "PlainBody": "fugit",
    "IsSent": true,
    "EMailSOInfo": {},
    "ServerId": 86,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Mohr, Langosh and Runolfsson",
    "EmailItemId": 810,
    "AccountId": 96,
    "ReceivedAt": "2017-01-30T16:48:29.5919308+01:00",
    "InReplyTo": {},
    "RepliedAt": "2017-12-19T16:48:29.5919308+01:00",
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
      "ContactId": 473,
      "ContactName": "Marks-Friesen",
      "PersonId": 569,
      "PersonName": "Jerde-Kilback",
      "AssociateId": 772,
      "Address": "voluptates",
      "EmailId": 599,
      "DuplicatePersonIds": [
        383,
        503
      ],
      "Name": "Mayer Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 341
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 26,
      "ContactName": "Jenkins-McCullough",
      "PersonId": 347,
      "PersonName": "Waters, Abernathy and Collier",
      "AssociateId": 953,
      "Address": "dolor",
      "EmailId": 444,
      "DuplicatePersonIds": [
        922,
        57
      ],
      "Name": "Leannon-Bashirian",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 89
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 454,
      "ContactName": "O'Keefe Inc and Sons",
      "PersonId": 468,
      "PersonName": "Veum-Oberbrunner",
      "AssociateId": 545,
      "Address": "modi",
      "EmailId": 840,
      "DuplicatePersonIds": [
        449,
        282
      ],
      "Name": "Orn Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    }
  ],
  "Subject": "in",
  "HTMLBody": "itaque",
  "From": {
    "ContactId": 583,
    "ContactName": "Emmerich Group",
    "PersonId": 909,
    "PersonName": "Mills-Schowalter",
    "AssociateId": 938,
    "Address": "sit",
    "EmailId": 931,
    "DuplicatePersonIds": [
      17,
      219
    ],
    "Name": "Bosco-Kuhic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 605
      }
    }
  },
  "Sent": "2008-04-16T16:48:29.593924+02:00",
  "Size": 776,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "aut",
  "PlainBody": "dicta",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 866,
    "AppointmentId": 657,
    "ProjectId": 839,
    "SaleId": 392,
    "Archived": false,
    "ArchivedAt": "2009-08-23T16:48:29.593924+02:00",
    "ArchivedBy": 696,
    "ArchivedDisplayName": "Nicolas, Tremblay and Mraz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 979
      }
    }
  },
  "ServerId": 739,
  "Attachments": [
    {
      "Description": "Diverse real-time analyzer",
      "Filename": "voluptatem",
      "Size": 181,
      "Type": "voluptatem",
      "Encoding": "aut",
      "Id": "sit",
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
          "FieldLength": 487
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Ledner Inc and Sons",
      "Values": [
        "sit",
        "qui"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 936
        }
      }
    },
    {
      "Name": "Ledner Inc and Sons",
      "Values": [
        "sit",
        "qui"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 936
        }
      }
    }
  ],
  "FolderName": "Willms-Jast",
  "EmailItemId": 224,
  "AccountId": 119,
  "ReceivedAt": "2004-08-04T16:48:29.5969239+02:00",
  "InReplyTo": {
    "ServerId": 119,
    "MessageId": "minus",
    "Subject": "nobis",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1995-01-03T16:48:29.5969239+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 778,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 544
      }
    }
  },
  "RepliedAt": "2015-04-13T16:48:29.5969239+02:00",
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
      "FieldLength": 55
    }
  }
}
```