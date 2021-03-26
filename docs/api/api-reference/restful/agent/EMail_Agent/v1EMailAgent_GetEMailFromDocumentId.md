---
title: POST Agents/EMail/GetEMailFromDocumentId
id: v1EMailAgent_GetEMailFromDocumentId
---

# POST Agents/EMail/GetEMailFromDocumentId

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentId
```

Get an e-mail based on an archived document



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentId?$select=name,department,category/id
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

DocumentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 |  |


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
POST /api/v1/Agents/EMail/GetEMailFromDocumentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 553
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 831,
      "ContactName": "Hoeger Inc and Sons",
      "PersonId": 802,
      "PersonName": "Bergnaum-Veum",
      "AssociateId": 592,
      "Address": "perferendis",
      "EmailId": 287,
      "DuplicatePersonIds": [
        599,
        349
      ],
      "Name": "Ryan Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 793
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 887,
      "ContactName": "Corwin, Boyer and Okuneva",
      "PersonId": 960,
      "PersonName": "Schneider Inc and Sons",
      "AssociateId": 296,
      "Address": "eius",
      "EmailId": 28,
      "DuplicatePersonIds": [
        691,
        311
      ],
      "Name": "Weber Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 88
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 108,
      "ContactName": "Abernathy LLC",
      "PersonId": 972,
      "PersonName": "Krajcik, Koelpin and Mayer",
      "AssociateId": 793,
      "Address": "aut",
      "EmailId": 946,
      "DuplicatePersonIds": [
        447,
        232
      ],
      "Name": "Conroy LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "brand next-generation action-items"
          },
          "FieldType": "System.Int32",
          "FieldLength": 572
        }
      }
    }
  ],
  "Subject": "aut",
  "HTMLBody": "amet",
  "From": {
    "ContactId": 571,
    "ContactName": "Johns, VonRueden and Schmeler",
    "PersonId": 597,
    "PersonName": "Bosco, Fay and Yundt",
    "AssociateId": 160,
    "Address": "tempore",
    "EmailId": 720,
    "DuplicatePersonIds": [
      863,
      116
    ],
    "Name": "Rodriguez, Stracke and Bashirian",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 448
      }
    }
  },
  "Sent": "2000-04-01T16:48:29.6029241+02:00",
  "Size": 633,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "vero",
  "PlainBody": "magni",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 277,
    "AppointmentId": 8,
    "ProjectId": 18,
    "SaleId": 688,
    "Archived": true,
    "ArchivedAt": "2017-04-08T16:48:29.6029241+02:00",
    "ArchivedBy": 852,
    "ArchivedDisplayName": "Bailey Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 784
      }
    }
  },
  "ServerId": 123,
  "Attachments": [
    {
      "Description": "Networked web-enabled moderator",
      "Filename": "earum",
      "Size": 471,
      "Type": "et",
      "Encoding": "aut",
      "Id": "dolorem",
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
          "FieldLength": 31
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hyatt-Rath",
      "Values": [
        "molestiae",
        "animi"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 162
        }
      }
    },
    {
      "Name": "Hyatt-Rath",
      "Values": [
        "molestiae",
        "animi"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 162
        }
      }
    }
  ],
  "FolderName": "Nader-Yost",
  "EmailItemId": 850,
  "AccountId": 147,
  "ReceivedAt": "2012-09-24T16:48:29.6039241+02:00",
  "InReplyTo": {
    "ServerId": 990,
    "MessageId": "in",
    "Subject": "et",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1996-06-02T16:48:29.6039241+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 715,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 74
      }
    }
  },
  "RepliedAt": "1997-05-02T16:48:29.6039241+02:00",
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
      "FieldLength": 905
    }
  }
}
```