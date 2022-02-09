---
title: POST Agents/EMail/GetEMail
id: v1EMailAgent_GetEMail
---

# POST Agents/EMail/GetEMail

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Id": 199,
  "IncludeAttachments": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 594,
      "ContactName": "Bode, Muller and Corwin",
      "PersonId": 247,
      "PersonName": "Johnston-Beer",
      "AssociateId": 61,
      "Address": "et",
      "EmailId": 756,
      "DuplicatePersonIds": [
        130,
        627
      ],
      "Name": "Streich, Hansen and Greenholt",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 835
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 485,
      "ContactName": "Lemke LLC",
      "PersonId": 875,
      "PersonName": "Wilkinson-Purdy",
      "AssociateId": 653,
      "Address": "harum",
      "EmailId": 580,
      "DuplicatePersonIds": [
        478,
        137
      ],
      "Name": "Price Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 35
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 717,
      "ContactName": "Rohan-Sauer",
      "PersonId": 582,
      "PersonName": "DuBuque LLC",
      "AssociateId": 773,
      "Address": "quis",
      "EmailId": 484,
      "DuplicatePersonIds": [
        837,
        600
      ],
      "Name": "Morar-McGlynn",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    }
  ],
  "Subject": "illum",
  "HTMLBody": "omnis",
  "From": {
    "ContactId": 151,
    "ContactName": "Smitham, Murazik and Collins",
    "PersonId": 526,
    "PersonName": "Kessler, Schmidt and Runolfsson",
    "AssociateId": 719,
    "Address": "debitis",
    "EmailId": 294,
    "DuplicatePersonIds": [
      302,
      751
    ],
    "Name": "Thompson Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "expedite back-end systems"
        },
        "FieldType": "System.Int32",
        "FieldLength": 573
      }
    }
  },
  "Sent": "1998-11-14T18:28:49.0609673+01:00",
  "Size": 753,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "quisquam",
  "PlainBody": "incidunt",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 426,
    "AppointmentId": 368,
    "ProjectId": 913,
    "SaleId": 637,
    "Archived": true,
    "ArchivedAt": "2010-10-22T18:28:49.0609673+02:00",
    "ArchivedBy": 43,
    "ArchivedDisplayName": "Simonis LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 648
      }
    }
  },
  "ServerId": 355,
  "Attachments": [
    {
      "Description": "Digitized incremental matrix",
      "Filename": "blanditiis",
      "Size": 510,
      "Type": "sit",
      "Encoding": "error",
      "Id": "magni",
      "Disposition": "sed",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 646
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Terry, Homenick and Gaylord",
      "Values": [
        "accusamus",
        "illo"
      ],
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
    },
    {
      "Name": "Terry, Homenick and Gaylord",
      "Values": [
        "accusamus",
        "illo"
      ],
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
  "FolderName": "Macejkovic, Braun and Effertz",
  "EmailItemId": 495,
  "AccountId": 796,
  "ReceivedAt": "2018-07-18T18:28:49.0619695+02:00",
  "InReplyTo": {
    "ServerId": 853,
    "MessageId": "et",
    "Subject": "sit",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2011-10-23T18:28:49.0619695+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 277,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 657
      }
    }
  },
  "RepliedAt": "2003-07-03T18:28:49.0619695+02:00",
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
      "FieldLength": 402
    }
  }
}
```