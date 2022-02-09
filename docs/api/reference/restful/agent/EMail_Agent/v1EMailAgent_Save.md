---
title: POST Agents/EMail/Save
id: v1EMailAgent_Save
---

# POST Agents/EMail/Save

```http
POST /api/v1/Agents/EMail/Save
```

Save the e-mail back to the database



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/Save?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/Save
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
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
    "Subject": "provident",
    "HTMLBody": "praesentium",
    "From": {},
    "Sent": "2008-02-22T18:28:49.0659619+01:00",
    "Size": 754,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "et",
    "PlainBody": "qui",
    "IsSent": true,
    "EMailSOInfo": {},
    "ServerId": 968,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Koss-Schowalter",
    "EmailItemId": 841,
    "AccountId": 811,
    "ReceivedAt": "2001-03-10T18:28:49.0659619+01:00",
    "InReplyTo": {},
    "RepliedAt": "2003-07-07T18:28:49.0659619+02:00",
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
      "ContactId": 883,
      "ContactName": "Donnelly-Stehr",
      "PersonId": 750,
      "PersonName": "Cartwright, Blanda and Heller",
      "AssociateId": 821,
      "Address": "unde",
      "EmailId": 805,
      "DuplicatePersonIds": [
        85,
        433
      ],
      "Name": "Kutch-Gorczany",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 62
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 716,
      "ContactName": "Toy, Lebsack and Robel",
      "PersonId": 277,
      "PersonName": "Schuster, Wolff and Hayes",
      "AssociateId": 758,
      "Address": "eum",
      "EmailId": 930,
      "DuplicatePersonIds": [
        520,
        565
      ],
      "Name": "Aufderhar, Schmeler and Hane",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 798
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 495,
      "ContactName": "Koss Inc and Sons",
      "PersonId": 24,
      "PersonName": "Welch-Fay",
      "AssociateId": 580,
      "Address": "et",
      "EmailId": 218,
      "DuplicatePersonIds": [
        964,
        225
      ],
      "Name": "Stamm, Bogisich and Leffler",
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
  "Subject": "quas",
  "HTMLBody": "itaque",
  "From": {
    "ContactId": 605,
    "ContactName": "Bergstrom-Hoeger",
    "PersonId": 539,
    "PersonName": "Hagenes Inc and Sons",
    "AssociateId": 32,
    "Address": "et",
    "EmailId": 959,
    "DuplicatePersonIds": [
      802,
      497
    ],
    "Name": "Ledner-Walter",
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
  "Sent": "2009-08-03T18:28:49.068928+02:00",
  "Size": 25,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ut",
  "PlainBody": "alias",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 791,
    "AppointmentId": 971,
    "ProjectId": 82,
    "SaleId": 84,
    "Archived": false,
    "ArchivedAt": "2007-05-05T18:28:49.068928+02:00",
    "ArchivedBy": 164,
    "ArchivedDisplayName": "Grady Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 298
      }
    }
  },
  "ServerId": 46,
  "Attachments": [
    {
      "Description": "Customer-focused object-oriented forecast",
      "Filename": "ut",
      "Size": 370,
      "Type": "tempora",
      "Encoding": "laboriosam",
      "Id": "reprehenderit",
      "Disposition": "qui",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 92
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Vandervort, Skiles and Terry",
      "Values": [
        "et",
        "commodi"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 397
        }
      }
    },
    {
      "Name": "Vandervort, Skiles and Terry",
      "Values": [
        "et",
        "commodi"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 397
        }
      }
    }
  ],
  "FolderName": "Gaylord, Reinger and Ullrich",
  "EmailItemId": 108,
  "AccountId": 267,
  "ReceivedAt": "2016-08-08T18:28:49.0699577+02:00",
  "InReplyTo": {
    "ServerId": 543,
    "MessageId": "eum",
    "Subject": "quod",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2010-01-08T18:28:49.0699577+01:00",
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
        "FieldType": "System.String",
        "FieldLength": 528
      }
    }
  },
  "RepliedAt": "2008-03-07T18:28:49.0699577+01:00",
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
      "FieldType": "System.String",
      "FieldLength": 904
    }
  }
}
```