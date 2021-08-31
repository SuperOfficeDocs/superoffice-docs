---
title: CreateEMailFromDocumentEntity
id: v1EMailAgent_CreateEMailFromDocumentEntity
---

# CreateEMailFromDocumentEntity

```http
POST /api/v1/Agents/EMail/CreateEMailFromDocumentEntity
```

Get an e-mail based on the provided DocumentEntity



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/CreateEMailFromDocumentEntity?$select=name,department,category/id
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

DocumentEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentEntity |  | Partial DocumentEntity class associating the generated DocumentEntity with an interface. |


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
POST /api/v1/Agents/EMail/CreateEMailFromDocumentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 726,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "magni",
    "Header": "molestias",
    "Name": "Kris-Larson",
    "OurRef": "labore",
    "YourRef": "dolor",
    "CreatedDate": "2004-03-30T14:58:04.1274324+02:00",
    "UpdatedDate": "2006-09-01T14:58:04.1274324+02:00",
    "Description": "Assimilated 24/7 challenge",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "1997-02-05T14:58:04.1274324+01:00",
    "ExternalRef": "ea",
    "Completed": "Completed",
    "ActiveLinks": 709,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 439,
    "Snum": 237,
    "UserDefinedFields": {
      "SuperOffice:1": "Laurie Quitzon",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "asperiores",
      "ExtraFields2": "voluptatem"
    },
    "CustomFields": {
      "CustomFields1": "harum",
      "CustomFields2": "non"
    },
    "PublishEventDate": "2009-07-16T14:58:04.1274324+02:00",
    "PublishTo": "2001-05-10T14:58:04.1274324+02:00",
    "PublishFrom": "2018-02-06T14:58:04.1274324+01:00",
    "IsPublished": true,
    "VisibleFor": [
      {},
      {}
    ]
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 549,
      "ContactName": "Cassin Group",
      "PersonId": 788,
      "PersonName": "Schiller Inc and Sons",
      "AssociateId": 355,
      "Address": "dicta",
      "EmailId": 213,
      "DuplicatePersonIds": [
        38,
        184
      ],
      "Name": "Terry, Johnston and Kemmer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 807
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 317,
      "ContactName": "Mann Group",
      "PersonId": 206,
      "PersonName": "Schulist Group",
      "AssociateId": 367,
      "Address": "nobis",
      "EmailId": 297,
      "DuplicatePersonIds": [
        918,
        193
      ],
      "Name": "Parker LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "extend compelling functionalities"
          },
          "FieldType": "System.Int32",
          "FieldLength": 299
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 793,
      "ContactName": "Pagac, Kemmer and Turcotte",
      "PersonId": 537,
      "PersonName": "Hilpert-Kemmer",
      "AssociateId": 743,
      "Address": "ut",
      "EmailId": 242,
      "DuplicatePersonIds": [
        876,
        88
      ],
      "Name": "Klein-Hilpert",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 743
        }
      }
    }
  ],
  "Subject": "sint",
  "HTMLBody": "quod",
  "From": {
    "ContactId": 856,
    "ContactName": "Krajcik, Jerde and Stanton",
    "PersonId": 395,
    "PersonName": "Gleichner, Cartwright and Johns",
    "AssociateId": 461,
    "Address": "beatae",
    "EmailId": 831,
    "DuplicatePersonIds": [
      540,
      314
    ],
    "Name": "Daniel, Jewess and Breitenberg",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 498
      }
    }
  },
  "Sent": "2012-04-26T14:58:04.1294597+02:00",
  "Size": 587,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ab",
  "PlainBody": "neque",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 165,
    "AppointmentId": 683,
    "ProjectId": 784,
    "SaleId": 897,
    "Archived": true,
    "ArchivedAt": "1997-03-16T14:58:04.1294597+01:00",
    "ArchivedBy": 381,
    "ArchivedDisplayName": "Witting Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 294
      }
    }
  },
  "ServerId": 308,
  "Attachments": [
    {
      "Description": "Monitored composite structure",
      "Filename": "aspernatur",
      "Size": 762,
      "Type": "voluptatem",
      "Encoding": "voluptatibus",
      "Id": "voluptatem",
      "Disposition": "vel",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 298
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Von, Cormier and Roob",
      "Values": [
        "quo",
        "eaque"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 448
        }
      }
    },
    {
      "Name": "Von, Cormier and Roob",
      "Values": [
        "quo",
        "eaque"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 448
        }
      }
    }
  ],
  "FolderName": "Gislason Inc and Sons",
  "EmailItemId": 480,
  "AccountId": 982,
  "ReceivedAt": "2006-06-03T14:58:04.13046+02:00",
  "InReplyTo": {
    "ServerId": 170,
    "MessageId": "veritatis",
    "Subject": "et",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2007-02-04T14:58:04.13046+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 949,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 477
      }
    }
  },
  "RepliedAt": "2002-12-17T14:58:04.13046+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "visualize impactful web-readiness"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 828
    }
  }
}
```