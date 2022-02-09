---
title: POST Agents/EMail/GetUnsanitizedEMailFromAttachmentId
id: v1EMailAgent_GetUnsanitizedEMailFromAttachmentId
---

# POST Agents/EMail/GetUnsanitizedEMailFromAttachmentId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromAttachmentId
```

Get an e-mail based on an email and attachment id.

The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromAttachmentId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromAttachmentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "EmailId": 272,
  "AttachmentIds": [
    "assumenda",
    "suscipit"
  ],
  "IncludeAttachments": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 27,
      "ContactName": "Leuschke, Schamberger and Howell",
      "PersonId": 807,
      "PersonName": "Feeney Group",
      "AssociateId": 312,
      "Address": "sed",
      "EmailId": 232,
      "DuplicatePersonIds": [
        882,
        335
      ],
      "Name": "Bartoletti Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 434
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 683,
      "ContactName": "O'Keefe-Wyman",
      "PersonId": 163,
      "PersonName": "Mertz Inc and Sons",
      "AssociateId": 980,
      "Address": "maiores",
      "EmailId": 716,
      "DuplicatePersonIds": [
        63,
        828
      ],
      "Name": "Schuppe Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 244
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 431,
      "ContactName": "Wehner-Langworth",
      "PersonId": 292,
      "PersonName": "Mante, Hodkiewicz and Johnston",
      "AssociateId": 798,
      "Address": "veritatis",
      "EmailId": 595,
      "DuplicatePersonIds": [
        24,
        206
      ],
      "Name": "Jacobson LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 334
        }
      }
    }
  ],
  "Subject": "omnis",
  "HTMLBody": "illum",
  "From": {
    "ContactId": 508,
    "ContactName": "Effertz, Towne and Grant",
    "PersonId": 646,
    "PersonName": "Dicki Inc and Sons",
    "AssociateId": 830,
    "Address": "totam",
    "EmailId": 873,
    "DuplicatePersonIds": [
      187,
      31
    ],
    "Name": "Lubowitz-Kohler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 805
      }
    }
  },
  "Sent": "2020-01-09T18:28:49.0329563+01:00",
  "Size": 687,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "vitae",
  "PlainBody": "aspernatur",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 388,
    "AppointmentId": 1000,
    "ProjectId": 473,
    "SaleId": 397,
    "Archived": false,
    "ArchivedAt": "2017-05-11T18:28:49.0329563+02:00",
    "ArchivedBy": 536,
    "ArchivedDisplayName": "Towne-Skiles",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 419
      }
    }
  },
  "ServerId": 935,
  "Attachments": [
    {
      "Description": "Robust tangible methodology",
      "Filename": "omnis",
      "Size": 224,
      "Type": "et",
      "Encoding": "nihil",
      "Id": "non",
      "Disposition": "perspiciatis",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "repurpose strategic synergies"
          },
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Schamberger-Hegmann",
      "Values": [
        "sit",
        "natus"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 694
        }
      }
    },
    {
      "Name": "Schamberger-Hegmann",
      "Values": [
        "sit",
        "natus"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 694
        }
      }
    }
  ],
  "FolderName": "VonRueden Group",
  "EmailItemId": 710,
  "AccountId": 477,
  "ReceivedAt": "2011-11-23T18:28:49.0339616+01:00",
  "InReplyTo": {
    "ServerId": 320,
    "MessageId": "quis",
    "Subject": "quia",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2002-12-08T18:28:49.0339616+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 501,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 703
      }
    }
  },
  "RepliedAt": "2005-01-24T18:28:49.0339616+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "incentivize open-source deliverables"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 285
    }
  }
}
```