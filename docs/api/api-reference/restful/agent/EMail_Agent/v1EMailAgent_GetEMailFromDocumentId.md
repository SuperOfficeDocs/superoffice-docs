---
title: GetEMailFromDocumentId
id: v1EMailAgent_GetEMailFromDocumentId
---

# GetEMailFromDocumentId

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentId
```

Get an e-mail based on an archived document



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentId?$select=name,department,category/id
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

DocumentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 |  |


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
POST /api/v1/Agents/EMail/GetEMailFromDocumentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 956
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 301,
      "ContactName": "Boyle-Hudson",
      "PersonId": 583,
      "PersonName": "Trantow-Beer",
      "AssociateId": 867,
      "Address": "vero",
      "EmailId": 158,
      "DuplicatePersonIds": [
        622,
        509
      ],
      "Name": "Schultz, Durgan and Grant",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 82
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 694,
      "ContactName": "Rowe-Metz",
      "PersonId": 142,
      "PersonName": "Jakubowski LLC",
      "AssociateId": 474,
      "Address": "praesentium",
      "EmailId": 385,
      "DuplicatePersonIds": [
        895,
        156
      ],
      "Name": "Wolf-Weber",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 723
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 463,
      "ContactName": "Gislason-Leuschke",
      "PersonId": 995,
      "PersonName": "Hamill-Watsica",
      "AssociateId": 515,
      "Address": "harum",
      "EmailId": 765,
      "DuplicatePersonIds": [
        221,
        948
      ],
      "Name": "Murray-Wunsch",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 320
        }
      }
    }
  ],
  "Subject": "nostrum",
  "HTMLBody": "labore",
  "From": {
    "ContactId": 615,
    "ContactName": "Kris, Feeney and Herman",
    "PersonId": 513,
    "PersonName": "Durgan LLC",
    "AssociateId": 232,
    "Address": "dolores",
    "EmailId": 60,
    "DuplicatePersonIds": [
      148,
      637
    ],
    "Name": "Moore Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 676
      }
    }
  },
  "Sent": "2015-12-22T14:58:04.2204601+01:00",
  "Size": 884,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "in",
  "PlainBody": "ea",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 237,
    "AppointmentId": 568,
    "ProjectId": 304,
    "SaleId": 382,
    "Archived": false,
    "ArchivedAt": "1998-09-18T14:58:04.2204601+02:00",
    "ArchivedBy": 703,
    "ArchivedDisplayName": "Kohler LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 330
      }
    }
  },
  "ServerId": 138,
  "Attachments": [
    {
      "Description": "Up-sized empowering application",
      "Filename": "nihil",
      "Size": 318,
      "Type": "officiis",
      "Encoding": "itaque",
      "Id": "animi",
      "Disposition": "in",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 957
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Torphy Group",
      "Values": [
        "voluptas",
        "dolore"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    },
    {
      "Name": "Torphy Group",
      "Values": [
        "voluptas",
        "dolore"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    }
  ],
  "FolderName": "Schulist LLC",
  "EmailItemId": 556,
  "AccountId": 208,
  "ReceivedAt": "2020-11-24T14:58:04.2204601+01:00",
  "InReplyTo": {
    "ServerId": 211,
    "MessageId": "quis",
    "Subject": "accusamus",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2007-01-04T14:58:04.2204601+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 442,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 761
      }
    }
  },
  "RepliedAt": "2008-03-03T14:58:04.2204601+01:00",
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
      "FieldType": "System.String",
      "FieldLength": 258
    }
  }
}
```