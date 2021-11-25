---
title: POST Agents/EMail/GetMailFromMessageId
id: v1EMailAgent_GetMailFromMessageId
---

# POST Agents/EMail/GetMailFromMessageId

```http
POST /api/v1/Agents/EMail/GetMailFromMessageId
```

Get email from db based on Message Id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetMailFromMessageId?$select=name,department,category/id
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

MessageId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MessageId | string |  |


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
POST /api/v1/Agents/EMail/GetMailFromMessageId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "MessageId": "dolores"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 627,
      "ContactName": "Dach-Abernathy",
      "PersonId": 769,
      "PersonName": "Eichmann Group",
      "AssociateId": 380,
      "Address": "voluptatem",
      "EmailId": 811,
      "DuplicatePersonIds": [
        382,
        341
      ],
      "Name": "Schuster Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 28,
      "ContactName": "Predovic-Sipes",
      "PersonId": 948,
      "PersonName": "Schuppe LLC",
      "AssociateId": 363,
      "Address": "dolorem",
      "EmailId": 312,
      "DuplicatePersonIds": [
        854,
        767
      ],
      "Name": "Hayes Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 718
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 975,
      "ContactName": "Hegmann-O'Hara",
      "PersonId": 877,
      "PersonName": "Von, Spinka and Ledner",
      "AssociateId": 605,
      "Address": "dolores",
      "EmailId": 608,
      "DuplicatePersonIds": [
        601,
        146
      ],
      "Name": "D'Amore-Schuster",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    }
  ],
  "Subject": "odio",
  "HTMLBody": "non",
  "From": {
    "ContactId": 576,
    "ContactName": "Kris, Mertz and Koss",
    "PersonId": 308,
    "PersonName": "Leuschke, Becker and Zulauf",
    "AssociateId": 352,
    "Address": "quasi",
    "EmailId": 410,
    "DuplicatePersonIds": [
      904,
      724
    ],
    "Name": "Becker, Collier and Dare",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "cultivate user-centric platforms"
        },
        "FieldType": "System.String",
        "FieldLength": 428
      }
    }
  },
  "Sent": "2015-05-26T18:28:48.9859557+02:00",
  "Size": 613,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "sequi",
  "PlainBody": "consectetur",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 363,
    "AppointmentId": 932,
    "ProjectId": 134,
    "SaleId": 389,
    "Archived": true,
    "ArchivedAt": "2020-01-23T18:28:48.9859557+01:00",
    "ArchivedBy": 548,
    "ArchivedDisplayName": "Casper Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 384
      }
    }
  },
  "ServerId": 183,
  "Attachments": [
    {
      "Description": "Reduced disintermediate firmware",
      "Filename": "voluptate",
      "Size": 48,
      "Type": "odio",
      "Encoding": "aut",
      "Id": "non",
      "Disposition": "suscipit",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 220
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hessel, Turner and Waelchi",
      "Values": [
        "facere",
        "dolorum"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    },
    {
      "Name": "Hessel, Turner and Waelchi",
      "Values": [
        "facere",
        "dolorum"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    }
  ],
  "FolderName": "Rodriguez, Farrell and Ryan",
  "EmailItemId": 918,
  "AccountId": 604,
  "ReceivedAt": "1999-02-26T18:28:48.9859557+01:00",
  "InReplyTo": {
    "ServerId": 66,
    "MessageId": "eveniet",
    "Subject": "quos",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2010-02-28T18:28:48.9859557+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 141,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 968
      }
    }
  },
  "RepliedAt": "2021-03-07T18:28:48.9859557+01:00",
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
      "FieldLength": 790
    }
  }
}
```