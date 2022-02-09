---
title: POST Agents/EMail/GetUnsanitizedEMailFromDocumentId
id: v1EMailAgent_GetUnsanitizedEMailFromDocumentId
---

# POST Agents/EMail/GetUnsanitizedEMailFromDocumentId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId
```

Get an e-mail based on an archived document.

The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 975
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 307,
      "ContactName": "Ritchie, Kub and Kilback",
      "PersonId": 49,
      "PersonName": "Glover LLC",
      "AssociateId": 870,
      "Address": "nostrum",
      "EmailId": 824,
      "DuplicatePersonIds": [
        369,
        750
      ],
      "Name": "Mayert Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 430
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 12,
      "ContactName": "Block LLC",
      "PersonId": 146,
      "PersonName": "Hudson, Lindgren and Balistreri",
      "AssociateId": 680,
      "Address": "facere",
      "EmailId": 572,
      "DuplicatePersonIds": [
        585,
        656
      ],
      "Name": "O'Keefe, Turner and Gottlieb",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 175
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 957,
      "ContactName": "Hackett-Spencer",
      "PersonId": 615,
      "PersonName": "Fritsch, Rempel and Spencer",
      "AssociateId": 682,
      "Address": "ut",
      "EmailId": 578,
      "DuplicatePersonIds": [
        408,
        922
      ],
      "Name": "Kohler, Thompson and Berge",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 72
        }
      }
    }
  ],
  "Subject": "neque",
  "HTMLBody": "quidem",
  "From": {
    "ContactId": 538,
    "ContactName": "Adams Inc and Sons",
    "PersonId": 617,
    "PersonName": "Zboncak, Cassin and Tillman",
    "AssociateId": 837,
    "Address": "omnis",
    "EmailId": 730,
    "DuplicatePersonIds": [
      775,
      950
    ],
    "Name": "Bins-Pouros",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 736
      }
    }
  },
  "Sent": "1994-07-11T18:28:49.0259564+02:00",
  "Size": 814,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "illum",
  "PlainBody": "sunt",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 677,
    "AppointmentId": 48,
    "ProjectId": 179,
    "SaleId": 717,
    "Archived": false,
    "ArchivedAt": "1999-01-11T18:28:49.0269282+01:00",
    "ArchivedBy": 629,
    "ArchivedDisplayName": "Gorczany LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 629
      }
    }
  },
  "ServerId": 104,
  "Attachments": [
    {
      "Description": "Fundamental actuating groupware",
      "Filename": "repellat",
      "Size": 106,
      "Type": "corrupti",
      "Encoding": "et",
      "Id": "adipisci",
      "Disposition": "et",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 310
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Cruickshank Group",
      "Values": [
        "inventore",
        "qui"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    },
    {
      "Name": "Cruickshank Group",
      "Values": [
        "inventore",
        "qui"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    }
  ],
  "FolderName": "Predovic Group",
  "EmailItemId": 187,
  "AccountId": 492,
  "ReceivedAt": "2010-06-20T18:28:49.0269282+02:00",
  "InReplyTo": {
    "ServerId": 406,
    "MessageId": "placeat",
    "Subject": "voluptate",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2018-07-06T18:28:49.0269282+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 916,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 397
      }
    }
  },
  "RepliedAt": "2020-04-18T18:28:49.0269282+02:00",
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
      "FieldLength": 173
    }
  }
}
```