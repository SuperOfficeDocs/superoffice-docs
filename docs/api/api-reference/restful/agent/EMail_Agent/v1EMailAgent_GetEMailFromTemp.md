---
title: POST Agents/EMail/GetEMailFromTemp
id: v1EMailAgent_GetEMailFromTemp
---

# POST Agents/EMail/GetEMailFromTemp

```http
POST /api/v1/Agents/EMail/GetEMailFromTemp
```

<para />

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromTemp?$select=name,department,category/id
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

FileName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FileName | string |  |


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
POST /api/v1/Agents/EMail/GetEMailFromTemp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FileName": "Nolan-Kassulke"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 700,
      "ContactName": "Tromp, Labadie and Friesen",
      "PersonId": 982,
      "PersonName": "Stanton, Klein and Koelpin",
      "AssociateId": 134,
      "Address": "aut",
      "EmailId": 875,
      "DuplicatePersonIds": [
        245,
        164
      ],
      "Name": "Ondricka Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 457
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 551,
      "ContactName": "Bergstrom LLC",
      "PersonId": 563,
      "PersonName": "Kovacek-Bahringer",
      "AssociateId": 492,
      "Address": "dignissimos",
      "EmailId": 845,
      "DuplicatePersonIds": [
        702,
        809
      ],
      "Name": "Mertz, Feil and Tillman",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 882
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 31,
      "ContactName": "Quitzon, Mills and Price",
      "PersonId": 169,
      "PersonName": "Torp LLC",
      "AssociateId": 571,
      "Address": "sed",
      "EmailId": 353,
      "DuplicatePersonIds": [
        191,
        184
      ],
      "Name": "Hammes-Kessler",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 940
        }
      }
    }
  ],
  "Subject": "doloremque",
  "HTMLBody": "ex",
  "From": {
    "ContactId": 328,
    "ContactName": "Quitzon Group",
    "PersonId": 234,
    "PersonName": "Wisoky Group",
    "AssociateId": 290,
    "Address": "voluptas",
    "EmailId": 961,
    "DuplicatePersonIds": [
      710,
      308
    ],
    "Name": "Mitchell, Hackett and Swaniawski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "brand real-time technologies"
        },
        "FieldType": "System.String",
        "FieldLength": 563
      }
    }
  },
  "Sent": "1996-12-29T18:28:49.0549578+01:00",
  "Size": 358,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "accusantium",
  "PlainBody": "inventore",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 842,
    "AppointmentId": 239,
    "ProjectId": 178,
    "SaleId": 817,
    "Archived": true,
    "ArchivedAt": "2002-03-20T18:28:49.0559616+01:00",
    "ArchivedBy": 569,
    "ArchivedDisplayName": "Turcotte, Schroeder and McGlynn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 728
      }
    }
  },
  "ServerId": 39,
  "Attachments": [
    {
      "Description": "Pre-emptive responsive contingency",
      "Filename": "eveniet",
      "Size": 776,
      "Type": "ut",
      "Encoding": "quia",
      "Id": "et",
      "Disposition": "velit",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "iterate viral vortals"
          },
          "FieldType": "System.Int32",
          "FieldLength": 430
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Lemke-Boehm",
      "Values": [
        "est",
        "animi"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    },
    {
      "Name": "Lemke-Boehm",
      "Values": [
        "est",
        "animi"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    }
  ],
  "FolderName": "Dooley LLC",
  "EmailItemId": 231,
  "AccountId": 455,
  "ReceivedAt": "2003-04-06T18:28:49.0559616+02:00",
  "InReplyTo": {
    "ServerId": 448,
    "MessageId": "qui",
    "Subject": "est",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2021-07-06T18:28:49.0559616+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 253,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 462
      }
    }
  },
  "RepliedAt": "2011-10-15T18:28:49.0559616+02:00",
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
      "FieldLength": 124
    }
  }
}
```