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
    "DocumentId": 58,
    "UpdatedBy": {},
    "CreatedBy": {},
    "Attention": "iusto",
    "Header": "tenetur",
    "Name": "Wilderman-Koelpin",
    "OurRef": "enim",
    "YourRef": "perferendis",
    "CreatedDate": "2003-02-03T18:28:49.0429637+01:00",
    "UpdatedDate": "2019-09-28T18:28:49.0429637+02:00",
    "Description": "Horizontal zero defect complexity",
    "DocumentTemplate": {},
    "Person": {},
    "Associate": {},
    "Contact": {},
    "Project": {},
    "Date": "1997-04-07T18:28:49.0429637+02:00",
    "ExternalRef": "quos",
    "Completed": "Completed",
    "ActiveLinks": 484,
    "Type": "BookingForChecklist",
    "Links": [
      {},
      {}
    ],
    "LockSemantics": "Locking",
    "Sale": {},
    "SuggestedDocumentId": 615,
    "Snum": 942,
    "UserDefinedFields": {
      "SuperOffice:1": "Hortense Goodwin",
      "SuperOffice:2": "True"
    },
    "ExtraFields": {
      "ExtraFields1": "ipsa",
      "ExtraFields2": "est"
    },
    "CustomFields": {
      "CustomFields1": "architecto",
      "CustomFields2": "ipsam"
    },
    "PublishEventDate": "2004-02-28T18:28:49.0429637+01:00",
    "PublishTo": "2014-11-09T18:28:49.0429637+01:00",
    "PublishFrom": "2014-04-18T18:28:49.0429637+02:00",
    "IsPublished": false,
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
      "ContactId": 989,
      "ContactName": "Connelly Group",
      "PersonId": 834,
      "PersonName": "Willms LLC",
      "AssociateId": 215,
      "Address": "perspiciatis",
      "EmailId": 901,
      "DuplicatePersonIds": [
        922,
        981
      ],
      "Name": "Smith, Casper and Bosco",
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
  "Cc": [
    {
      "ContactId": 756,
      "ContactName": "Jones, Crooks and Collins",
      "PersonId": 256,
      "PersonName": "Wehner Group",
      "AssociateId": 258,
      "Address": "quia",
      "EmailId": 999,
      "DuplicatePersonIds": [
        149,
        29
      ],
      "Name": "Marvin Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 833
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 599,
      "ContactName": "Kuhn LLC",
      "PersonId": 235,
      "PersonName": "Schinner-Padberg",
      "AssociateId": 738,
      "Address": "est",
      "EmailId": 168,
      "DuplicatePersonIds": [
        510,
        247
      ],
      "Name": "Osinski Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 119
        }
      }
    }
  ],
  "Subject": "delectus",
  "HTMLBody": "voluptatibus",
  "From": {
    "ContactId": 760,
    "ContactName": "Shanahan, Langworth and Wunsch",
    "PersonId": 405,
    "PersonName": "Dickinson, Walker and Grimes",
    "AssociateId": 322,
    "Address": "quidem",
    "EmailId": 23,
    "DuplicatePersonIds": [
      427,
      143
    ],
    "Name": "Larson Group",
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
  "Sent": "2021-05-23T18:28:49.0459623+02:00",
  "Size": 905,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "aliquid",
  "PlainBody": "enim",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 695,
    "AppointmentId": 518,
    "ProjectId": 476,
    "SaleId": 792,
    "Archived": false,
    "ArchivedAt": "2017-06-25T18:28:49.0459623+02:00",
    "ArchivedBy": 757,
    "ArchivedDisplayName": "Upton, Wiza and McDermott",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 419
      }
    }
  },
  "ServerId": 687,
  "Attachments": [
    {
      "Description": "Decentralized bi-directional workforce",
      "Filename": "voluptatem",
      "Size": 324,
      "Type": "sed",
      "Encoding": "consequatur",
      "Id": "dolorem",
      "Disposition": "iste",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 184
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Cartwright, Little and Nader",
      "Values": [
        "sapiente",
        "aut"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 835
        }
      }
    },
    {
      "Name": "Cartwright, Little and Nader",
      "Values": [
        "sapiente",
        "aut"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 835
        }
      }
    }
  ],
  "FolderName": "Tromp LLC",
  "EmailItemId": 639,
  "AccountId": 25,
  "ReceivedAt": "2015-12-18T18:28:49.0459623+01:00",
  "InReplyTo": {
    "ServerId": 723,
    "MessageId": "maiores",
    "Subject": "consequatur",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2012-03-08T18:28:49.0459623+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 550,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 134
      }
    }
  },
  "RepliedAt": "2011-07-22T18:28:49.0459623+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "synthesize compelling web-readiness"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 293
    }
  }
}
```