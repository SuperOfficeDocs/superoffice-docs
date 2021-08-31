---
title: SaveToMailServer
id: v1EMailAgent_SaveToMailServer
---

# SaveToMailServer

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
    "Subject": "distinctio",
    "HTMLBody": "numquam",
    "From": {},
    "Sent": "2011-12-08T14:58:04.1544306+01:00",
    "Size": 201,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "eveniet",
    "PlainBody": "nulla",
    "IsSent": true,
    "EMailSOInfo": {},
    "ServerId": 981,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Torp LLC",
    "EmailItemId": 849,
    "AccountId": 122,
    "ReceivedAt": "2014-07-08T14:58:04.1544306+02:00",
    "InReplyTo": {},
    "RepliedAt": "2017-01-21T14:58:04.1544306+01:00",
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
      "ContactId": 282,
      "ContactName": "Sanford-Auer",
      "PersonId": 324,
      "PersonName": "Hettinger, Zieme and Kshlerin",
      "AssociateId": 326,
      "Address": "dolores",
      "EmailId": 870,
      "DuplicatePersonIds": [
        850,
        843
      ],
      "Name": "Rosenbaum, Abshire and Smith",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 29
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 766,
      "ContactName": "Ratke-Cummerata",
      "PersonId": 655,
      "PersonName": "Will, Oberbrunner and Kub",
      "AssociateId": 601,
      "Address": "a",
      "EmailId": 274,
      "DuplicatePersonIds": [
        405,
        406
      ],
      "Name": "Williamson-Littel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 730
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 901,
      "ContactName": "Metz, Morar and Beatty",
      "PersonId": 546,
      "PersonName": "Vandervort, Heidenreich and Luettgen",
      "AssociateId": 884,
      "Address": "perferendis",
      "EmailId": 368,
      "DuplicatePersonIds": [
        610,
        693
      ],
      "Name": "Doyle, Ledner and Pagac",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 893
        }
      }
    }
  ],
  "Subject": "officia",
  "HTMLBody": "vel",
  "From": {
    "ContactId": 879,
    "ContactName": "Witting-Torphy",
    "PersonId": 997,
    "PersonName": "Rolfson Group",
    "AssociateId": 569,
    "Address": "maxime",
    "EmailId": 415,
    "DuplicatePersonIds": [
      726,
      579
    ],
    "Name": "Brakus Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 17
      }
    }
  },
  "Sent": "2014-05-14T14:58:04.1574302+02:00",
  "Size": 837,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ipsum",
  "PlainBody": "nobis",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 47,
    "AppointmentId": 461,
    "ProjectId": 191,
    "SaleId": 541,
    "Archived": true,
    "ArchivedAt": "1998-05-17T14:58:04.1574302+02:00",
    "ArchivedBy": 588,
    "ArchivedDisplayName": "Hoppe, Wolff and Morar",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "whiteboard bleeding-edge partnerships"
        },
        "FieldType": "System.String",
        "FieldLength": 982
      }
    }
  },
  "ServerId": 647,
  "Attachments": [
    {
      "Description": "Configurable secondary neural-net",
      "Filename": "ipsam",
      "Size": 367,
      "Type": "distinctio",
      "Encoding": "ut",
      "Id": "et",
      "Disposition": "eos",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Littel LLC",
      "Values": [
        "beatae",
        "velit"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 165
        }
      }
    },
    {
      "Name": "Littel LLC",
      "Values": [
        "beatae",
        "velit"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 165
        }
      }
    }
  ],
  "FolderName": "Swaniawski LLC",
  "EmailItemId": 192,
  "AccountId": 359,
  "ReceivedAt": "2005-11-14T14:58:04.1574302+01:00",
  "InReplyTo": {
    "ServerId": 891,
    "MessageId": "quaerat",
    "Subject": "quia",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2010-02-16T14:58:04.1574302+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 93,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "exploit world-class ROI"
        },
        "FieldType": "System.String",
        "FieldLength": 180
      }
    }
  },
  "RepliedAt": "1997-04-27T14:58:04.1574302+02:00",
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
      "FieldLength": 138
    }
  }
}
```