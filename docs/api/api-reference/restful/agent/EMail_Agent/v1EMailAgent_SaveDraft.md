---
title: SaveDraft
id: v1EMailAgent_SaveDraft
---

# SaveDraft

```http
POST /api/v1/Agents/EMail/SaveDraft
```

Save the Email entity to the drafts folder



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SaveDraft?$select=name,department,category/id
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

Entity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Entity |  | All information about an e-mail <para /> Carrier object for EMailEntity. Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |


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
POST /api/v1/Agents/EMail/SaveDraft
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Entity": {
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
    "Subject": "laudantium",
    "HTMLBody": "ab",
    "From": {},
    "Sent": "2013-12-06T14:58:04.0794657+01:00",
    "Size": 299,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "neque",
    "PlainBody": "non",
    "IsSent": true,
    "EMailSOInfo": {},
    "ServerId": 293,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Cremin-Vandervort",
    "EmailItemId": 87,
    "AccountId": 189,
    "ReceivedAt": "2015-12-29T14:58:04.0794657+01:00",
    "InReplyTo": {},
    "RepliedAt": "2002-07-25T14:58:04.0794657+02:00",
    "HasCalendarData": false,
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
      "ContactId": 508,
      "ContactName": "Smith-Oberbrunner",
      "PersonId": 290,
      "PersonName": "Rodriguez-Zulauf",
      "AssociateId": 839,
      "Address": "est",
      "EmailId": 288,
      "DuplicatePersonIds": [
        141,
        224
      ],
      "Name": "Wisoky Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 742,
      "ContactName": "Block-Keeling",
      "PersonId": 716,
      "PersonName": "Kilback Group",
      "AssociateId": 667,
      "Address": "sunt",
      "EmailId": 629,
      "DuplicatePersonIds": [
        305,
        592
      ],
      "Name": "Hansen Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 587
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 654,
      "ContactName": "Mills-Hilpert",
      "PersonId": 557,
      "PersonName": "Moore LLC",
      "AssociateId": 807,
      "Address": "qui",
      "EmailId": 941,
      "DuplicatePersonIds": [
        927,
        768
      ],
      "Name": "Rosenbaum, Effertz and Marvin",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    }
  ],
  "Subject": "architecto",
  "HTMLBody": "quo",
  "From": {
    "ContactId": 634,
    "ContactName": "Nienow Inc and Sons",
    "PersonId": 827,
    "PersonName": "Rohan, Stokes and Bogisich",
    "AssociateId": 222,
    "Address": "veritatis",
    "EmailId": 161,
    "DuplicatePersonIds": [
      797,
      836
    ],
    "Name": "Stokes Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 826
      }
    }
  },
  "Sent": "2015-08-02T14:58:04.0814649+02:00",
  "Size": 571,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "culpa",
  "PlainBody": "deleniti",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 528,
    "AppointmentId": 715,
    "ProjectId": 721,
    "SaleId": 640,
    "Archived": false,
    "ArchivedAt": "2021-04-30T14:58:04.0814649+02:00",
    "ArchivedBy": 522,
    "ArchivedDisplayName": "Stiedemann Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 284
      }
    }
  },
  "ServerId": 153,
  "Attachments": [
    {
      "Description": "Inverse hybrid implementation",
      "Filename": "enim",
      "Size": 386,
      "Type": "ut",
      "Encoding": "consequatur",
      "Id": "quasi",
      "Disposition": "accusantium",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 610
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Wiegand-Hegmann",
      "Values": [
        "sequi",
        "beatae"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 501
        }
      }
    },
    {
      "Name": "Wiegand-Hegmann",
      "Values": [
        "sequi",
        "beatae"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 501
        }
      }
    }
  ],
  "FolderName": "Corkery LLC",
  "EmailItemId": 289,
  "AccountId": 578,
  "ReceivedAt": "2011-03-01T14:58:04.0824658+01:00",
  "InReplyTo": {
    "ServerId": 78,
    "MessageId": "dolorem",
    "Subject": "reprehenderit",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2009-08-22T14:58:04.0824658+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 833,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 168
      }
    }
  },
  "RepliedAt": "2002-03-21T14:58:04.0824658+01:00",
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
      "FieldLength": 156
    }
  }
}
```