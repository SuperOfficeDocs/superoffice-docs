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
    "ServerName": "Boyle LLC",
    "UserName": "Wiza-Price",
    "Password": "illum",
    "Folder": "quaerat",
    "UseSSL": true
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
    "Subject": "accusantium",
    "HTMLBody": "aut",
    "From": {},
    "Sent": "2018-09-07T18:28:49.1179644+02:00",
    "Size": 19,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "necessitatibus",
    "PlainBody": "omnis",
    "IsSent": false,
    "EMailSOInfo": {},
    "ServerId": 521,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Legros, Kreiger and Heaney",
    "EmailItemId": 688,
    "AccountId": 313,
    "ReceivedAt": "2019-04-10T18:28:49.1179644+02:00",
    "InReplyTo": {},
    "RepliedAt": "2012-06-06T18:28:49.1179644+02:00",
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
      "ContactId": 572,
      "ContactName": "Konopelski Inc and Sons",
      "PersonId": 584,
      "PersonName": "Koch Group",
      "AssociateId": 882,
      "Address": "deserunt",
      "EmailId": 385,
      "DuplicatePersonIds": [
        67,
        568
      ],
      "Name": "Eichmann-Hettinger",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 689
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 922,
      "ContactName": "Kuhlman-McKenzie",
      "PersonId": 855,
      "PersonName": "Trantow, Boyer and Conroy",
      "AssociateId": 835,
      "Address": "dolor",
      "EmailId": 663,
      "DuplicatePersonIds": [
        285,
        121
      ],
      "Name": "Mills Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 776
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 528,
      "ContactName": "Schneider-Simonis",
      "PersonId": 340,
      "PersonName": "Volkman-Zboncak",
      "AssociateId": 930,
      "Address": "et",
      "EmailId": 105,
      "DuplicatePersonIds": [
        652,
        683
      ],
      "Name": "Mohr, Rempel and Lehner",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 57
        }
      }
    }
  ],
  "Subject": "id",
  "HTMLBody": "veniam",
  "From": {
    "ContactId": 296,
    "ContactName": "Rowe LLC",
    "PersonId": 60,
    "PersonName": "Brakus Inc and Sons",
    "AssociateId": 888,
    "Address": "repellendus",
    "EmailId": 26,
    "DuplicatePersonIds": [
      431,
      487
    ],
    "Name": "Corwin Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 635
      }
    }
  },
  "Sent": "2009-11-26T18:28:49.1199556+01:00",
  "Size": 223,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "dicta",
  "PlainBody": "aperiam",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 729,
    "AppointmentId": 203,
    "ProjectId": 427,
    "SaleId": 57,
    "Archived": true,
    "ArchivedAt": "1997-04-02T18:28:49.1199556+02:00",
    "ArchivedBy": 231,
    "ArchivedDisplayName": "Veum-Donnelly",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 952
      }
    }
  },
  "ServerId": 825,
  "Attachments": [
    {
      "Description": "Reactive attitude-oriented architecture",
      "Filename": "officia",
      "Size": 152,
      "Type": "quia",
      "Encoding": "est",
      "Id": "autem",
      "Disposition": "nemo",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 111
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Gusikowski-McCullough",
      "Values": [
        "autem",
        "minima"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 84
        }
      }
    },
    {
      "Name": "Gusikowski-McCullough",
      "Values": [
        "autem",
        "minima"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 84
        }
      }
    }
  ],
  "FolderName": "Christiansen-Nitzsche",
  "EmailItemId": 273,
  "AccountId": 173,
  "ReceivedAt": "2009-04-26T18:28:49.1209566+02:00",
  "InReplyTo": {
    "ServerId": 484,
    "MessageId": "dolores",
    "Subject": "voluptatem",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1997-09-21T18:28:49.1209566+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 407,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "brand intuitive content"
        },
        "FieldType": "System.String",
        "FieldLength": 667
      }
    }
  },
  "RepliedAt": "2011-02-04T18:28:49.1209566+01:00",
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
      "FieldType": "System.String",
      "FieldLength": 703
    }
  }
}
```