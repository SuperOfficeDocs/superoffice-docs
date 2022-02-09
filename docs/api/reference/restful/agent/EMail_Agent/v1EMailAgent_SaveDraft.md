---
title: POST Agents/EMail/SaveDraft
id: v1EMailAgent_SaveDraft
---

# POST Agents/EMail/SaveDraft

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
Accept-Language: sv
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
    "Subject": "et",
    "HTMLBody": "voluptas",
    "From": {},
    "Sent": "1998-05-23T18:28:48.9919272+02:00",
    "Size": 776,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "cumque",
    "PlainBody": "architecto",
    "IsSent": true,
    "EMailSOInfo": {},
    "ServerId": 186,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Stamm, Jakubowski and Terry",
    "EmailItemId": 308,
    "AccountId": 386,
    "ReceivedAt": "1996-02-25T18:28:48.9919272+01:00",
    "InReplyTo": {},
    "RepliedAt": "2013-12-07T18:28:48.9919272+01:00",
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
      "ContactId": 176,
      "ContactName": "Torp, Lehner and Lindgren",
      "PersonId": 996,
      "PersonName": "Hermiston-Schmeler",
      "AssociateId": 426,
      "Address": "quisquam",
      "EmailId": 54,
      "DuplicatePersonIds": [
        310,
        50
      ],
      "Name": "McKenzie-Douglas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 92
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 548,
      "ContactName": "Howell-Aufderhar",
      "PersonId": 442,
      "PersonName": "Nader, Breitenberg and Boehm",
      "AssociateId": 721,
      "Address": "ullam",
      "EmailId": 537,
      "DuplicatePersonIds": [
        823,
        973
      ],
      "Name": "Lehner Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 659
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 17,
      "ContactName": "Rohan-Schumm",
      "PersonId": 173,
      "PersonName": "Gulgowski, Graham and Graham",
      "AssociateId": 376,
      "Address": "vitae",
      "EmailId": 381,
      "DuplicatePersonIds": [
        298,
        144
      ],
      "Name": "Lubowitz-Sporer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "Subject": "facere",
  "HTMLBody": "tempora",
  "From": {
    "ContactId": 405,
    "ContactName": "Ortiz LLC",
    "PersonId": 836,
    "PersonName": "Cruickshank, Towne and Marks",
    "AssociateId": 942,
    "Address": "dolorum",
    "EmailId": 601,
    "DuplicatePersonIds": [
      688,
      808
    ],
    "Name": "Keeling, Wisoky and Bins",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 136
      }
    }
  },
  "Sent": "2021-08-30T18:28:48.9959561+02:00",
  "Size": 522,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ipsam",
  "PlainBody": "quasi",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 47,
    "AppointmentId": 947,
    "ProjectId": 545,
    "SaleId": 988,
    "Archived": false,
    "ArchivedAt": "1996-04-02T18:28:48.9959561+02:00",
    "ArchivedBy": 541,
    "ArchivedDisplayName": "Waelchi LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 933
      }
    }
  },
  "ServerId": 247,
  "Attachments": [
    {
      "Description": "Assimilated tangible intranet",
      "Filename": "velit",
      "Size": 680,
      "Type": "repellendus",
      "Encoding": "dolor",
      "Id": "eum",
      "Disposition": "omnis",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 872
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Mayer LLC",
      "Values": [
        "qui",
        "dolores"
      ],
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
    {
      "Name": "Mayer LLC",
      "Values": [
        "qui",
        "dolores"
      ],
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
    }
  ],
  "FolderName": "Waters, Romaguera and McKenzie",
  "EmailItemId": 559,
  "AccountId": 129,
  "ReceivedAt": "2012-06-02T18:28:48.9959561+02:00",
  "InReplyTo": {
    "ServerId": 775,
    "MessageId": "expedita",
    "Subject": "est",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2017-06-28T18:28:48.9959561+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 959,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 991
      }
    }
  },
  "RepliedAt": "1996-09-21T18:28:48.9959561+02:00",
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
      "FieldLength": 429
    }
  }
}
```