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
    "Subject": "veritatis",
    "HTMLBody": "non",
    "From": {},
    "Sent": "2000-07-25T16:48:29.5039269+02:00",
    "Size": 900,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "ut",
    "PlainBody": "dolor",
    "IsSent": false,
    "EMailSOInfo": {},
    "ServerId": 432,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Stiedemann-Buckridge",
    "EmailItemId": 420,
    "AccountId": 943,
    "ReceivedAt": "2013-05-21T16:48:29.5039269+02:00",
    "InReplyTo": {},
    "RepliedAt": "2017-02-23T16:48:29.5039269+01:00",
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
      "ContactId": 130,
      "ContactName": "Willms LLC",
      "PersonId": 311,
      "PersonName": "Rohan Inc and Sons",
      "AssociateId": 85,
      "Address": "ipsa",
      "EmailId": 380,
      "DuplicatePersonIds": [
        298,
        210
      ],
      "Name": "Cole-Parisian",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 694
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 456,
      "ContactName": "Stokes, Wuckert and Leannon",
      "PersonId": 972,
      "PersonName": "Dickens, Walker and Senger",
      "AssociateId": 323,
      "Address": "aut",
      "EmailId": 492,
      "DuplicatePersonIds": [
        742,
        943
      ],
      "Name": "Flatley, Keebler and Cronin",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 883
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 56,
      "ContactName": "Vandervort, Nienow and Jakubowski",
      "PersonId": 920,
      "PersonName": "Mills, Thiel and Senger",
      "AssociateId": 675,
      "Address": "aspernatur",
      "EmailId": 640,
      "DuplicatePersonIds": [
        789,
        127
      ],
      "Name": "Cole, Cronin and Donnelly",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 720
        }
      }
    }
  ],
  "Subject": "consectetur",
  "HTMLBody": "voluptas",
  "From": {
    "ContactId": 225,
    "ContactName": "Wolf-Kub",
    "PersonId": 299,
    "PersonName": "Walsh, Schamberger and Beier",
    "AssociateId": 339,
    "Address": "consequatur",
    "EmailId": 940,
    "DuplicatePersonIds": [
      720,
      285
    ],
    "Name": "Schumm LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 307
      }
    }
  },
  "Sent": "2010-09-10T16:48:29.5069244+02:00",
  "Size": 585,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "quo",
  "PlainBody": "consectetur",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 218,
    "AppointmentId": 939,
    "ProjectId": 47,
    "SaleId": 381,
    "Archived": true,
    "ArchivedAt": "1998-01-19T16:48:29.5069244+01:00",
    "ArchivedBy": 190,
    "ArchivedDisplayName": "Cartwright, Rath and Zieme",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 157
      }
    }
  },
  "ServerId": 260,
  "Attachments": [
    {
      "Description": "Adaptive user-facing artificial intelligence",
      "Filename": "eos",
      "Size": 349,
      "Type": "eum",
      "Encoding": "inventore",
      "Id": "cum",
      "Disposition": "illum",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 338
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Bernhard-Trantow",
      "Values": [
        "pariatur",
        "et"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    },
    {
      "Name": "Bernhard-Trantow",
      "Values": [
        "pariatur",
        "et"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    }
  ],
  "FolderName": "West Inc and Sons",
  "EmailItemId": 655,
  "AccountId": 225,
  "ReceivedAt": "2016-10-13T16:48:29.5069244+02:00",
  "InReplyTo": {
    "ServerId": 906,
    "MessageId": "nostrum",
    "Subject": "accusamus",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2020-10-06T16:48:29.5069244+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 376,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 305
      }
    }
  },
  "RepliedAt": "2004-02-18T16:48:29.5069244+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "facilitate world-class markets"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 628
    }
  }
}
```