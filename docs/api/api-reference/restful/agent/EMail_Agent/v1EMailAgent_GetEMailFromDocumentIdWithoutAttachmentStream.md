---
title: POST Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
id: v1EMailAgent_GetEMailFromDocumentIdWithoutAttachmentStream
---

# POST Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
```

Get an e-mail based on an archived document



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetEMailFromDocumentIdWithoutAttachmentStream
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 859
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 35,
      "ContactName": "Lindgren Group",
      "PersonId": 360,
      "PersonName": "Witting Inc and Sons",
      "AssociateId": 668,
      "Address": "sit",
      "EmailId": 809,
      "DuplicatePersonIds": [
        563,
        78
      ],
      "Name": "Kuvalis-Muller",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 905
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 267,
      "ContactName": "Adams-Stracke",
      "PersonId": 477,
      "PersonName": "Kreiger-Hartmann",
      "AssociateId": 803,
      "Address": "dolorum",
      "EmailId": 94,
      "DuplicatePersonIds": [
        5,
        566
      ],
      "Name": "Bruen-Smitham",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 984
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 418,
      "ContactName": "Pacocha, Bogisich and Torp",
      "PersonId": 834,
      "PersonName": "Jewess Inc and Sons",
      "AssociateId": 135,
      "Address": "est",
      "EmailId": 319,
      "DuplicatePersonIds": [
        769,
        441
      ],
      "Name": "Waelchi-Tillman",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 866
        }
      }
    }
  ],
  "Subject": "error",
  "HTMLBody": "iste",
  "From": {
    "ContactId": 514,
    "ContactName": "Hudson Group",
    "PersonId": 962,
    "PersonName": "Collins Group",
    "AssociateId": 851,
    "Address": "suscipit",
    "EmailId": 778,
    "DuplicatePersonIds": [
      592,
      672
    ],
    "Name": "Von-Leuschke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 687
      }
    }
  },
  "Sent": "1999-06-04T16:48:29.5389244+02:00",
  "Size": 900,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "distinctio",
  "PlainBody": "velit",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 75,
    "AppointmentId": 113,
    "ProjectId": 375,
    "SaleId": 329,
    "Archived": true,
    "ArchivedAt": "1995-06-02T16:48:29.5389244+02:00",
    "ArchivedBy": 26,
    "ArchivedDisplayName": "D'Amore-Herzog",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 538
      }
    }
  },
  "ServerId": 204,
  "Attachments": [
    {
      "Description": "Customizable discrete utilisation",
      "Filename": "et",
      "Size": 327,
      "Type": "deserunt",
      "Encoding": "officiis",
      "Id": "quia",
      "Disposition": "accusamus",
      "Stream": "GIF89....File contents as raw bytes...",
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
  "CustomHeaderList": [
    {
      "Name": "Shields Inc and Sons",
      "Values": [
        "voluptatem",
        "corrupti"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    },
    {
      "Name": "Shields Inc and Sons",
      "Values": [
        "voluptatem",
        "corrupti"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 610
        }
      }
    }
  ],
  "FolderName": "Grant, Thiel and Hessel",
  "EmailItemId": 375,
  "AccountId": 775,
  "ReceivedAt": "2017-08-01T16:48:29.5389244+02:00",
  "InReplyTo": {
    "ServerId": 688,
    "MessageId": "sit",
    "Subject": "aut",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2007-01-18T16:48:29.5389244+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 605,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 639
      }
    }
  },
  "RepliedAt": "2001-04-03T16:48:29.5389244+02:00",
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
      "FieldLength": 576
    }
  }
}
```