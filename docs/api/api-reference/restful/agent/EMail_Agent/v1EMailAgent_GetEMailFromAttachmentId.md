---
title: POST Agents/EMail/GetEMailFromAttachmentId
id: v1EMailAgent_GetEMailFromAttachmentId
---

# POST Agents/EMail/GetEMailFromAttachmentId

```http
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
```

Get an e-mail based on an email and attachment id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId?$select=name,department,category/id
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

EmailId, AttachmentIds, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailId | int32 |  |
| AttachmentIds | array |  |
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
POST /api/v1/Agents/EMail/GetEMailFromAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "EmailId": 314,
  "AttachmentIds": [
    "soluta",
    "laboriosam"
  ],
  "IncludeAttachments": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 651,
      "ContactName": "Denesik Inc and Sons",
      "PersonId": 978,
      "PersonName": "VonRueden-Brown",
      "AssociateId": 586,
      "Address": "provident",
      "EmailId": 174,
      "DuplicatePersonIds": [
        1001,
        116
      ],
      "Name": "Kling-Ziemann",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 511
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 65,
      "ContactName": "Lang-Brekke",
      "PersonId": 792,
      "PersonName": "Johns-McClure",
      "AssociateId": 2,
      "Address": "repellat",
      "EmailId": 859,
      "DuplicatePersonIds": [
        840,
        911
      ],
      "Name": "Ruecker, Abernathy and Rice",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "integrate user-centric deliverables"
          },
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 980,
      "ContactName": "Okuneva Inc and Sons",
      "PersonId": 257,
      "PersonName": "Jaskolski Group",
      "AssociateId": 420,
      "Address": "accusamus",
      "EmailId": 675,
      "DuplicatePersonIds": [
        129,
        188
      ],
      "Name": "Kunze, Legros and McDermott",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    }
  ],
  "Subject": "dolorem",
  "HTMLBody": "asperiores",
  "From": {
    "ContactId": 554,
    "ContactName": "Cartwright LLC",
    "PersonId": 198,
    "PersonName": "Feeney-Jones",
    "AssociateId": 814,
    "Address": "omnis",
    "EmailId": 265,
    "DuplicatePersonIds": [
      747,
      706
    ],
    "Name": "Wiegand-Johnson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 876
      }
    }
  },
  "Sent": "2006-03-19T16:48:29.6069247+01:00",
  "Size": 824,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "doloribus",
  "PlainBody": "consequatur",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 803,
    "AppointmentId": 837,
    "ProjectId": 625,
    "SaleId": 264,
    "Archived": false,
    "ArchivedAt": "2018-08-02T16:48:29.6069247+02:00",
    "ArchivedBy": 788,
    "ArchivedDisplayName": "Howell, Emmerich and Kertzmann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 741
      }
    }
  },
  "ServerId": 268,
  "Attachments": [
    {
      "Description": "Streamlined analyzing throughput",
      "Filename": "quod",
      "Size": 884,
      "Type": "id",
      "Encoding": "alias",
      "Id": "quos",
      "Disposition": "repudiandae",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 997
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Walsh, Nikolaus and Kris",
      "Values": [
        "dolores",
        "voluptatum"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 173
        }
      }
    },
    {
      "Name": "Walsh, Nikolaus and Kris",
      "Values": [
        "dolores",
        "voluptatum"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 173
        }
      }
    }
  ],
  "FolderName": "Murphy Group",
  "EmailItemId": 240,
  "AccountId": 445,
  "ReceivedAt": "1996-02-20T16:48:29.6069247+01:00",
  "InReplyTo": {
    "ServerId": 802,
    "MessageId": "architecto",
    "Subject": "vero",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2020-09-27T16:48:29.6079249+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 609,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 556
      }
    }
  },
  "RepliedAt": "1995-03-09T16:48:29.6079249+01:00",
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
        "Reason": "deploy sticky ROI"
      },
      "FieldType": "System.String",
      "FieldLength": 352
    }
  }
}
```