---
title: POST Agents/EMail/GetEMailFromAttachmentId
id: v1EMailAgent_GetEMailFromAttachmentId
---

# POST Agents/EMail/GetEMailFromAttachmentId

```http
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
```

Get an e-mail based on an email and attachment id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId?$select=name,department,category/id
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

EmailId, AttachmentIds, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailId | int32 |  |
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
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EmailId": 597,
  "AttachmentIds": [
    "tempore",
    "repellat"
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
      "ContactId": 174,
      "ContactName": "Bailey Group",
      "PersonId": 311,
      "PersonName": "Goodwin Inc and Sons",
      "AssociateId": 81,
      "Address": "voluptatem",
      "EmailId": 889,
      "DuplicatePersonIds": [
        718,
        69
      ],
      "Name": "Jacobi LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 908
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 293,
      "ContactName": "Hilll LLC",
      "PersonId": 813,
      "PersonName": "Bashirian-Erdman",
      "AssociateId": 331,
      "Address": "ab",
      "EmailId": 13,
      "DuplicatePersonIds": [
        771,
        35
      ],
      "Name": "Kozey, Effertz and Dach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 308
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 100,
      "ContactName": "Borer, Torphy and Conroy",
      "PersonId": 775,
      "PersonName": "Grimes-Hilll",
      "AssociateId": 556,
      "Address": "itaque",
      "EmailId": 882,
      "DuplicatePersonIds": [
        98,
        658
      ],
      "Name": "Kunze-Stehr",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 485
        }
      }
    }
  ],
  "Subject": "debitis",
  "HTMLBody": "aperiam",
  "From": {
    "ContactId": 393,
    "ContactName": "Johns, Toy and Orn",
    "PersonId": 933,
    "PersonName": "Yost, White and Prohaska",
    "AssociateId": 296,
    "Address": "corporis",
    "EmailId": 265,
    "DuplicatePersonIds": [
      612,
      35
    ],
    "Name": "Kulas-Gaylord",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "expedite transparent applications"
        },
        "FieldType": "System.String",
        "FieldLength": 444
      }
    }
  },
  "Sent": "2016-10-29T18:28:49.0299564+02:00",
  "Size": 351,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "numquam",
  "PlainBody": "odit",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 689,
    "AppointmentId": 880,
    "ProjectId": 478,
    "SaleId": 887,
    "Archived": false,
    "ArchivedAt": "2016-03-27T18:28:49.0299564+02:00",
    "ArchivedBy": 896,
    "ArchivedDisplayName": "Wilkinson Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 219
      }
    }
  },
  "ServerId": 719,
  "Attachments": [
    {
      "Description": "Versatile mission-critical middleware",
      "Filename": "aut",
      "Size": 758,
      "Type": "error",
      "Encoding": "tempora",
      "Id": "vel",
      "Disposition": "sit",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 196
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Walker, Crist and Bayer",
      "Values": [
        "et",
        "quaerat"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 98
        }
      }
    },
    {
      "Name": "Walker, Crist and Bayer",
      "Values": [
        "et",
        "quaerat"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 98
        }
      }
    }
  ],
  "FolderName": "Ebert, Cole and Smitham",
  "EmailItemId": 655,
  "AccountId": 961,
  "ReceivedAt": "2005-08-28T18:28:49.0299564+02:00",
  "InReplyTo": {
    "ServerId": 826,
    "MessageId": "fuga",
    "Subject": "ipsam",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2014-11-13T18:28:49.0299564+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 828,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 982
      }
    }
  },
  "RepliedAt": "2005-09-11T18:28:49.0299564+02:00",
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
      "FieldLength": 626
    }
  }
}
```