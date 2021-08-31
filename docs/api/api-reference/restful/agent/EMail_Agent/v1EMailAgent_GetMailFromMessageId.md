---
title: GetMailFromMessageId
id: v1EMailAgent_GetMailFromMessageId
---

# GetMailFromMessageId

```http
POST /api/v1/Agents/EMail/GetMailFromMessageId
```

Get email from db based on Message Id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetMailFromMessageId?$select=name,department,category/id
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

MessageId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MessageId | string |  |


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
POST /api/v1/Agents/EMail/GetMailFromMessageId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "MessageId": "tempore"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 782,
      "ContactName": "McCullough-Durgan",
      "PersonId": 742,
      "PersonName": "Corkery, Armstrong and Metz",
      "AssociateId": 841,
      "Address": "dolores",
      "EmailId": 56,
      "DuplicatePersonIds": [
        129,
        622
      ],
      "Name": "Stokes-Yost",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 273,
      "ContactName": "Morar-Emard",
      "PersonId": 4,
      "PersonName": "Kreiger, Boyer and Barrows",
      "AssociateId": 790,
      "Address": "eius",
      "EmailId": 759,
      "DuplicatePersonIds": [
        644,
        197
      ],
      "Name": "Kilback, Mills and Walsh",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 195
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 718,
      "ContactName": "Thompson, Berge and Heidenreich",
      "PersonId": 498,
      "PersonName": "Leannon Group",
      "AssociateId": 330,
      "Address": "magni",
      "EmailId": 43,
      "DuplicatePersonIds": [
        594,
        526
      ],
      "Name": "Cummings, Lesch and Kuphal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 838
        }
      }
    }
  ],
  "Subject": "reiciendis",
  "HTMLBody": "explicabo",
  "From": {
    "ContactId": 541,
    "ContactName": "Schinner, Schiller and Schimmel",
    "PersonId": 195,
    "PersonName": "Tromp-Littel",
    "AssociateId": 123,
    "Address": "magni",
    "EmailId": 601,
    "DuplicatePersonIds": [
      827,
      269
    ],
    "Name": "Towne-Braun",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "leverage plug-and-play metrics"
        },
        "FieldType": "System.String",
        "FieldLength": 768
      }
    }
  },
  "Sent": "1998-11-22T14:58:04.0734604+01:00",
  "Size": 269,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "excepturi",
  "PlainBody": "et",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 666,
    "AppointmentId": 764,
    "ProjectId": 933,
    "SaleId": 538,
    "Archived": false,
    "ArchivedAt": "1996-01-06T14:58:04.0734604+01:00",
    "ArchivedBy": 694,
    "ArchivedDisplayName": "Wolff, Monahan and Friesen",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 679
      }
    }
  },
  "ServerId": 368,
  "Attachments": [
    {
      "Description": "User-centric demand-driven implementation",
      "Filename": "molestiae",
      "Size": 618,
      "Type": "eaque",
      "Encoding": "sapiente",
      "Id": "aspernatur",
      "Disposition": "quo",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 200
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Kuvalis LLC",
      "Values": [
        "et",
        "laudantium"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 509
        }
      }
    },
    {
      "Name": "Kuvalis LLC",
      "Values": [
        "et",
        "laudantium"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 509
        }
      }
    }
  ],
  "FolderName": "Ward-Grady",
  "EmailItemId": 573,
  "AccountId": 464,
  "ReceivedAt": "1997-05-28T14:58:04.0734604+02:00",
  "InReplyTo": {
    "ServerId": 247,
    "MessageId": "recusandae",
    "Subject": "ab",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1997-09-20T14:58:04.0734604+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 900,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 267
      }
    }
  },
  "RepliedAt": "2021-08-29T14:58:04.0734604+02:00",
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
      "FieldLength": 894
    }
  }
}
```