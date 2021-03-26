---
title: POST Agents/EMail/CreateForwardEmail
id: v1EMailAgent_CreateForwardEmail
---

# POST Agents/EMail/CreateForwardEmail

```http
POST /api/v1/Agents/EMail/CreateForwardEmail
```

Create forward email



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/CreateForwardEmail?$select=name,department,category/id
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

Email 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Email |  | All information about an e-mail <para /> Carrier object for EMailEntity. Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |


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
POST /api/v1/Agents/EMail/CreateForwardEmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Email": {
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
    "Subject": "eaque",
    "HTMLBody": "in",
    "From": {},
    "Sent": "2000-10-21T16:48:29.515924+02:00",
    "Size": 568,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "inventore",
    "PlainBody": "vitae",
    "IsSent": false,
    "EMailSOInfo": {},
    "ServerId": 562,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Watsica LLC",
    "EmailItemId": 124,
    "AccountId": 468,
    "ReceivedAt": "2009-09-05T16:48:29.515924+02:00",
    "InReplyTo": {},
    "RepliedAt": "2016-08-31T16:48:29.515924+02:00",
    "HasCalendarData": true,
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
      "ContactId": 431,
      "ContactName": "Harvey, Bogisich and Mosciski",
      "PersonId": 463,
      "PersonName": "Orn LLC",
      "AssociateId": 763,
      "Address": "animi",
      "EmailId": 692,
      "DuplicatePersonIds": [
        850,
        35
      ],
      "Name": "Maggio Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 11
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 699,
      "ContactName": "Glover LLC",
      "PersonId": 509,
      "PersonName": "Koepp, O'Kon and Ortiz",
      "AssociateId": 966,
      "Address": "neque",
      "EmailId": 139,
      "DuplicatePersonIds": [
        117,
        489
      ],
      "Name": "O'Hara Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 994
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 708,
      "ContactName": "Nolan-Paucek",
      "PersonId": 394,
      "PersonName": "Shanahan LLC",
      "AssociateId": 539,
      "Address": "neque",
      "EmailId": 421,
      "DuplicatePersonIds": [
        5,
        198
      ],
      "Name": "Franecki, Wilkinson and Labadie",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 891
        }
      }
    }
  ],
  "Subject": "non",
  "HTMLBody": "sint",
  "From": {
    "ContactId": 730,
    "ContactName": "Beier Inc and Sons",
    "PersonId": 420,
    "PersonName": "Heidenreich Group",
    "AssociateId": 435,
    "Address": "est",
    "EmailId": 824,
    "DuplicatePersonIds": [
      412,
      422
    ],
    "Name": "Braun, Kassulke and Metz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 293
      }
    }
  },
  "Sent": "2008-06-29T16:48:29.5189241+02:00",
  "Size": 407,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "repudiandae",
  "PlainBody": "illum",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 118,
    "AppointmentId": 975,
    "ProjectId": 477,
    "SaleId": 317,
    "Archived": false,
    "ArchivedAt": "2007-05-30T16:48:29.5189241+02:00",
    "ArchivedBy": 385,
    "ArchivedDisplayName": "Terry, Bernier and Gulgowski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "synthesize innovative partnerships"
        },
        "FieldType": "System.String",
        "FieldLength": 916
      }
    }
  },
  "ServerId": 988,
  "Attachments": [
    {
      "Description": "Multi-lateral client-driven interface",
      "Filename": "aut",
      "Size": 438,
      "Type": "et",
      "Encoding": "et",
      "Id": "iusto",
      "Disposition": "et",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 937
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Grant LLC",
      "Values": [
        "dolor",
        "est"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 885
        }
      }
    },
    {
      "Name": "Grant LLC",
      "Values": [
        "dolor",
        "est"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 885
        }
      }
    }
  ],
  "FolderName": "Prosacco, Runte and Zulauf",
  "EmailItemId": 916,
  "AccountId": 357,
  "ReceivedAt": "2004-02-01T16:48:29.5189241+01:00",
  "InReplyTo": {
    "ServerId": 593,
    "MessageId": "libero",
    "Subject": "est",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1997-12-09T16:48:29.5189241+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 143,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 198
      }
    }
  },
  "RepliedAt": "1996-03-30T16:48:29.5189241+01:00",
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
      "FieldLength": 349
    }
  }
}
```