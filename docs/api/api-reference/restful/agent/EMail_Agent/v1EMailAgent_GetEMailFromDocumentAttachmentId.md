---
title: GetEMailFromDocumentAttachmentId
id: v1EMailAgent_GetEMailFromDocumentAttachmentId
---

# GetEMailFromDocumentAttachmentId

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId
```

Get an e-mail based on an email in the archive system and attachment id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId?$select=name,department,category/id
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

DocId, AttachmentIds, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocId | int32 |  |
| AttachmentIds | array |  |
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
POST /api/v1/Agents/EMail/GetEMailFromDocumentAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocId": 807,
  "AttachmentIds": [
    "velit",
    "perspiciatis"
  ],
  "IncludeAttachments": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 181,
      "ContactName": "Tillman-VonRueden",
      "PersonId": 52,
      "PersonName": "Langworth-Bashirian",
      "AssociateId": 937,
      "Address": "tenetur",
      "EmailId": 428,
      "DuplicatePersonIds": [
        907,
        575
      ],
      "Name": "Swaniawski Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 903
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 519,
      "ContactName": "Jast Inc and Sons",
      "PersonId": 198,
      "PersonName": "Sawayn Inc and Sons",
      "AssociateId": 775,
      "Address": "quasi",
      "EmailId": 926,
      "DuplicatePersonIds": [
        755,
        332
      ],
      "Name": "Dickinson, Schuppe and Batz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 699
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 575,
      "ContactName": "Auer-Friesen",
      "PersonId": 629,
      "PersonName": "Funk, Pollich and Konopelski",
      "AssociateId": 736,
      "Address": "adipisci",
      "EmailId": 664,
      "DuplicatePersonIds": [
        422,
        475
      ],
      "Name": "Stehr-Kozey",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 669
        }
      }
    }
  ],
  "Subject": "et",
  "HTMLBody": "et",
  "From": {
    "ContactId": 408,
    "ContactName": "Stanton, Kautzer and McKenzie",
    "PersonId": 875,
    "PersonName": "Schuppe, Ondricka and Runte",
    "AssociateId": 312,
    "Address": "laudantium",
    "EmailId": 902,
    "DuplicatePersonIds": [
      879,
      83
    ],
    "Name": "Hartmann Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 723
      }
    }
  },
  "Sent": "2015-05-24T14:58:04.1204608+02:00",
  "Size": 187,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "sed",
  "PlainBody": "possimus",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 99,
    "AppointmentId": 386,
    "ProjectId": 478,
    "SaleId": 576,
    "Archived": false,
    "ArchivedAt": "2020-07-21T14:58:04.1204608+02:00",
    "ArchivedBy": 148,
    "ArchivedDisplayName": "Kuphal, Spinka and Roob",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 14
      }
    }
  },
  "ServerId": 833,
  "Attachments": [
    {
      "Description": "Ameliorated assymetric migration",
      "Filename": "sit",
      "Size": 596,
      "Type": "ratione",
      "Encoding": "dolorum",
      "Id": "placeat",
      "Disposition": "reprehenderit",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 797
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Block, Jones and Gutkowski",
      "Values": [
        "asperiores",
        "officia"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 19
        }
      }
    },
    {
      "Name": "Block, Jones and Gutkowski",
      "Values": [
        "asperiores",
        "officia"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 19
        }
      }
    }
  ],
  "FolderName": "Gorczany, Shields and Heidenreich",
  "EmailItemId": 275,
  "AccountId": 457,
  "ReceivedAt": "2014-02-26T14:58:04.1214598+01:00",
  "InReplyTo": {
    "ServerId": 210,
    "MessageId": "quas",
    "Subject": "sit",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2004-10-16T14:58:04.1214598+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 400,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "mesh rich infomediaries"
        },
        "FieldType": "System.Int32",
        "FieldLength": 60
      }
    }
  },
  "RepliedAt": "1996-02-08T14:58:04.1214598+01:00",
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
      "FieldLength": 641
    }
  }
}
```