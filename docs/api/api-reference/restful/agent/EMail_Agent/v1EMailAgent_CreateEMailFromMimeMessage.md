---
title: POST Agents/EMail/CreateEMailFromMimeMessage
id: v1EMailAgent_CreateEMailFromMimeMessage
---

# POST Agents/EMail/CreateEMailFromMimeMessage

```http
POST /api/v1/Agents/EMail/CreateEMailFromMimeMessage
```

Get an e-mail based on the provided MIME-message



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/CreateEMailFromMimeMessage?$select=name,department,category/id
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

MimeMessage 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MimeMessage | string |  |


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
POST /api/v1/Agents/EMail/CreateEMailFromMimeMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "MimeMessage": "sint"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 156,
      "ContactName": "O'Reilly-Wintheiser",
      "PersonId": 32,
      "PersonName": "Sanford Inc and Sons",
      "AssociateId": 419,
      "Address": "dolor",
      "EmailId": 435,
      "DuplicatePersonIds": [
        228,
        966
      ],
      "Name": "Metz Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 995
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 867,
      "ContactName": "Bahringer-Baumbach",
      "PersonId": 315,
      "PersonName": "Hickle, Zemlak and Doyle",
      "AssociateId": 960,
      "Address": "asperiores",
      "EmailId": 497,
      "DuplicatePersonIds": [
        128,
        129
      ],
      "Name": "Russel-Borer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 823
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 985,
      "ContactName": "Bogisich Group",
      "PersonId": 664,
      "PersonName": "Mosciski, O'Conner and Stokes",
      "AssociateId": 43,
      "Address": "accusantium",
      "EmailId": 290,
      "DuplicatePersonIds": [
        12,
        643
      ],
      "Name": "Raynor, Cormier and Jenkins",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 201
        }
      }
    }
  ],
  "Subject": "minus",
  "HTMLBody": "explicabo",
  "From": {
    "ContactId": 115,
    "ContactName": "Pagac-Schmitt",
    "PersonId": 112,
    "PersonName": "Bayer LLC",
    "AssociateId": 937,
    "Address": "perspiciatis",
    "EmailId": 241,
    "DuplicatePersonIds": [
      448,
      375
    ],
    "Name": "Bradtke-Wehner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 118
      }
    }
  },
  "Sent": "1998-02-26T16:48:29.6189288+01:00",
  "Size": 849,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "eum",
  "PlainBody": "iusto",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 649,
    "AppointmentId": 40,
    "ProjectId": 826,
    "SaleId": 826,
    "Archived": false,
    "ArchivedAt": "2014-05-06T16:48:29.6189288+02:00",
    "ArchivedBy": 182,
    "ArchivedDisplayName": "Grimes Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 968
      }
    }
  },
  "ServerId": 176,
  "Attachments": [
    {
      "Description": "Universal well-modulated productivity",
      "Filename": "ducimus",
      "Size": 263,
      "Type": "quaerat",
      "Encoding": "reiciendis",
      "Id": "omnis",
      "Disposition": "vero",
      "Stream": "GIF89....File contents as raw bytes...",
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
  "CustomHeaderList": [
    {
      "Name": "Hackett LLC",
      "Values": [
        "dolorum",
        "ullam"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    },
    {
      "Name": "Hackett LLC",
      "Values": [
        "dolorum",
        "ullam"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 460
        }
      }
    }
  ],
  "FolderName": "Kreiger-Collins",
  "EmailItemId": 882,
  "AccountId": 199,
  "ReceivedAt": "2020-03-24T16:48:29.6189288+01:00",
  "InReplyTo": {
    "ServerId": 220,
    "MessageId": "earum",
    "Subject": "et",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1999-06-16T16:48:29.6189288+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 848,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 384
      }
    }
  },
  "RepliedAt": "2011-02-09T16:48:29.6189288+01:00",
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
      "FieldLength": 912
    }
  }
}
```