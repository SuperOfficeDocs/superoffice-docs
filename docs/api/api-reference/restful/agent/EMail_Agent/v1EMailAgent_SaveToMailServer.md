---
title: POST Agents/EMail/SaveToMailServer
id: v1EMailAgent_SaveToMailServer
---

# POST Agents/EMail/SaveToMailServer

```http
POST /api/v1/Agents/EMail/SaveToMailServer
```

Save the passed e-mail back to the mail server



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SaveToMailServer?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/SaveToMailServer
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
    "Subject": "molestiae",
    "HTMLBody": "fugit",
    "From": {},
    "Sent": "2016-11-22T16:48:29.5069244+01:00",
    "Size": 26,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "asperiores",
    "PlainBody": "voluptatum",
    "IsSent": false,
    "EMailSOInfo": {},
    "ServerId": 52,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Thiel LLC",
    "EmailItemId": 889,
    "AccountId": 119,
    "ReceivedAt": "2009-09-11T16:48:29.5069244+02:00",
    "InReplyTo": {},
    "RepliedAt": "2009-10-17T16:48:29.5069244+02:00",
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
      "ContactId": 111,
      "ContactName": "Nikolaus, Gibson and Stehr",
      "PersonId": 662,
      "PersonName": "Homenick-Zieme",
      "AssociateId": 35,
      "Address": "ducimus",
      "EmailId": 542,
      "DuplicatePersonIds": [
        748,
        914
      ],
      "Name": "Jewess-Upton",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "revolutionize transparent deliverables"
          },
          "FieldType": "System.Int32",
          "FieldLength": 165
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 629,
      "ContactName": "Pollich Inc and Sons",
      "PersonId": 947,
      "PersonName": "Jacobson-Gutmann",
      "AssociateId": 689,
      "Address": "iste",
      "EmailId": 119,
      "DuplicatePersonIds": [
        245,
        441
      ],
      "Name": "Ortiz-Treutel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 224
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 769,
      "ContactName": "Reinger-Ortiz",
      "PersonId": 1001,
      "PersonName": "Koss, Mayer and Reilly",
      "AssociateId": 288,
      "Address": "similique",
      "EmailId": 100,
      "DuplicatePersonIds": [
        227,
        546
      ],
      "Name": "Heller, Bechtelar and Hilll",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "exploit cutting-edge action-items"
          },
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    }
  ],
  "Subject": "ea",
  "HTMLBody": "et",
  "From": {
    "ContactId": 809,
    "ContactName": "Von Group",
    "PersonId": 862,
    "PersonName": "Wintheiser-Hettinger",
    "AssociateId": 948,
    "Address": "recusandae",
    "EmailId": 730,
    "DuplicatePersonIds": [
      963,
      604
    ],
    "Name": "Lowe-Considine",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 548
      }
    }
  },
  "Sent": "1994-10-24T16:48:29.5108969+02:00",
  "Size": 87,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "soluta",
  "PlainBody": "ad",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 242,
    "AppointmentId": 67,
    "ProjectId": 158,
    "SaleId": 806,
    "Archived": true,
    "ArchivedAt": "2003-04-08T16:48:29.5108969+02:00",
    "ArchivedBy": 652,
    "ArchivedDisplayName": "Hettinger Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 415
      }
    }
  },
  "ServerId": 40,
  "Attachments": [
    {
      "Description": "Inverse tertiary database",
      "Filename": "nulla",
      "Size": 29,
      "Type": "in",
      "Encoding": "autem",
      "Id": "numquam",
      "Disposition": "eos",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 91
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Ratke Group",
      "Values": [
        "nesciunt",
        "earum"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 38
        }
      }
    },
    {
      "Name": "Ratke Group",
      "Values": [
        "nesciunt",
        "earum"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 38
        }
      }
    }
  ],
  "FolderName": "Lynch, Stokes and Osinski",
  "EmailItemId": 149,
  "AccountId": 665,
  "ReceivedAt": "2020-08-12T16:48:29.5108969+02:00",
  "InReplyTo": {
    "ServerId": 429,
    "MessageId": "molestiae",
    "Subject": "maiores",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2002-12-31T16:48:29.5108969+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 638,
    "EMailSOInfo": {},
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
  "RepliedAt": "2019-02-20T16:48:29.5108969+01:00",
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
      "FieldLength": 814
    }
  }
}
```