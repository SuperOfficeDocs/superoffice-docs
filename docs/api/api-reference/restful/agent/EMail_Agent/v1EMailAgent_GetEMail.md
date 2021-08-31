---
title: GetEMail
id: v1EMailAgent_GetEMail
---

# GetEMail

```http
POST /api/v1/Agents/EMail/GetEMail
```

Get en e-mail based on its primary key in the DB



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMail?$select=name,department,category/id
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

Id, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 |  |
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
POST /api/v1/Agents/EMail/GetEMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Id": 448,
  "IncludeAttachments": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 642,
      "ContactName": "Nienow, Stroman and Volkman",
      "PersonId": 21,
      "PersonName": "Smitham-Anderson",
      "AssociateId": 629,
      "Address": "ut",
      "EmailId": 230,
      "DuplicatePersonIds": [
        919,
        671
      ],
      "Name": "Heidenreich, Greenfelder and Hackett",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 865
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 368,
      "ContactName": "Mante Inc and Sons",
      "PersonId": 907,
      "PersonName": "Gerlach, Kemmer and Gerhold",
      "AssociateId": 909,
      "Address": "minima",
      "EmailId": 377,
      "DuplicatePersonIds": [
        301,
        364
      ],
      "Name": "Schowalter, Erdman and Barton",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 935
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 600,
      "ContactName": "Hilll LLC",
      "PersonId": 646,
      "PersonName": "Carter-Farrell",
      "AssociateId": 408,
      "Address": "itaque",
      "EmailId": 273,
      "DuplicatePersonIds": [
        834,
        347
      ],
      "Name": "Larkin Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 328
        }
      }
    }
  ],
  "Subject": "quidem",
  "HTMLBody": "quidem",
  "From": {
    "ContactId": 989,
    "ContactName": "Kuphal-Armstrong",
    "PersonId": 816,
    "PersonName": "Marquardt-Hand",
    "AssociateId": 102,
    "Address": "fugiat",
    "EmailId": 538,
    "DuplicatePersonIds": [
      399,
      618
    ],
    "Name": "Connelly, Pagac and Spencer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 531
      }
    }
  },
  "Sent": "2007-11-06T14:58:04.1444683+01:00",
  "Size": 807,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "aspernatur",
  "PlainBody": "est",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 545,
    "AppointmentId": 75,
    "ProjectId": 859,
    "SaleId": 659,
    "Archived": true,
    "ArchivedAt": "2004-09-26T14:58:04.14546+02:00",
    "ArchivedBy": 214,
    "ArchivedDisplayName": "Adams-Hettinger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 171
      }
    }
  },
  "ServerId": 982,
  "Attachments": [
    {
      "Description": "Optional bi-directional focus group",
      "Filename": "est",
      "Size": 141,
      "Type": "vero",
      "Encoding": "praesentium",
      "Id": "eligendi",
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
          "FieldLength": 496
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Green-Koelpin",
      "Values": [
        "a",
        "occaecati"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    },
    {
      "Name": "Green-Koelpin",
      "Values": [
        "a",
        "occaecati"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 77
        }
      }
    }
  ],
  "FolderName": "Schinner Inc and Sons",
  "EmailItemId": 638,
  "AccountId": 724,
  "ReceivedAt": "2006-12-19T14:58:04.14546+01:00",
  "InReplyTo": {
    "ServerId": 765,
    "MessageId": "itaque",
    "Subject": "deleniti",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2002-11-27T14:58:04.14546+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 201,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 867
      }
    }
  },
  "RepliedAt": "2010-04-18T14:58:04.14546+02:00",
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
      "FieldLength": 642
    }
  }
}
```