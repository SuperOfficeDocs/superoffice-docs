---
title: POST Agents/EMail/CreateEMailFromDocumentEntity
id: v1EMailAgent_CreateEMailFromDocumentEntity
---

# POST Agents/EMail/CreateEMailFromDocumentEntity

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DocumentEntity": {
    "DocumentId": 585,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "sit",
    "Header": "ut",
    "Name": "Gottlieb Inc and Sons",
    "OurRef": "non",
    "YourRef": "assumenda",
    "CreatedDate": "2017-07-11T16:48:29.6129377+02:00",
    "UpdatedDate": "2017-04-26T16:48:29.6129377+02:00",
    "Description": "Enterprise-wide exuding software",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "1995-03-21T16:48:29.6129377+01:00",
    "ExternalRef": "consequatur",
    "Completed": "Completed",
    "ActiveLinks": 29,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 604,
    "Snum": 761,
    "UserDefinedFields": {
      "SuperOffice:1": "613959979",
      "SuperOffice:2": "True"
    },
    "ExtraFields": {
      "ExtraFields1": "facilis",
      "ExtraFields2": "mollitia"
    },
    "CustomFields": {
      "CustomFields1": "autem",
      "CustomFields2": "expedita"
    },
    "PublishEventDate": "2010-05-24T16:48:29.6129377+02:00",
    "PublishTo": "2012-11-08T16:48:29.6129377+01:00",
    "PublishFrom": "1996-09-06T16:48:29.6129377+02:00",
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
      "ContactId": 565,
      "ContactName": "Mayert-Hane",
      "PersonId": 618,
      "PersonName": "Zieme, Ullrich and Hamill",
      "AssociateId": 507,
      "Address": "fuga",
      "EmailId": 796,
      "DuplicatePersonIds": [
        956,
        49
      ],
      "Name": "Price-Veum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 401
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 52,
      "ContactName": "Shields LLC",
      "PersonId": 679,
      "PersonName": "Mayer LLC",
      "AssociateId": 579,
      "Address": "ut",
      "EmailId": 601,
      "DuplicatePersonIds": [
        860,
        401
      ],
      "Name": "Kling-Swift",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 426
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 963,
      "ContactName": "Hoppe Group",
      "PersonId": 574,
      "PersonName": "Sporer-Torphy",
      "AssociateId": 325,
      "Address": "ut",
      "EmailId": 592,
      "DuplicatePersonIds": [
        166,
        423
      ],
      "Name": "Kunde Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 913
        }
      }
    }
  ],
  "Subject": "rerum",
  "HTMLBody": "adipisci",
  "From": {
    "ContactId": 98,
    "ContactName": "Bruen-Fisher",
    "PersonId": 39,
    "PersonName": "Marks Group",
    "AssociateId": 976,
    "Address": "voluptatem",
    "EmailId": 444,
    "DuplicatePersonIds": [
      781,
      107
    ],
    "Name": "Reynolds, Larson and Funk",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 695
      }
    }
  },
  "Sent": "1994-06-12T16:48:29.6149287+02:00",
  "Size": 93,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "explicabo",
  "PlainBody": "excepturi",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 205,
    "AppointmentId": 733,
    "ProjectId": 651,
    "SaleId": 477,
    "Archived": false,
    "ArchivedAt": "2001-03-24T16:48:29.6159287+01:00",
    "ArchivedBy": 647,
    "ArchivedDisplayName": "Parker LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 132
      }
    }
  },
  "ServerId": 56,
  "Attachments": [
    {
      "Description": "Down-sized 4th generation standardization",
      "Filename": "reprehenderit",
      "Size": 676,
      "Type": "et",
      "Encoding": "ea",
      "Id": "voluptatem",
      "Disposition": "sequi",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 464
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "West Group",
      "Values": [
        "et",
        "alias"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    },
    {
      "Name": "West Group",
      "Values": [
        "et",
        "alias"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 603
        }
      }
    }
  ],
  "FolderName": "Kutch LLC",
  "EmailItemId": 963,
  "AccountId": 907,
  "ReceivedAt": "2002-11-22T16:48:29.6159287+01:00",
  "InReplyTo": {
    "ServerId": 604,
    "MessageId": "harum",
    "Subject": "ea",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2018-02-24T16:48:29.6159287+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 73,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 133
      }
    }
  },
  "RepliedAt": "2020-08-27T16:48:29.6159287+02:00",
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
      "FieldLength": 747
    }
  }
}
```