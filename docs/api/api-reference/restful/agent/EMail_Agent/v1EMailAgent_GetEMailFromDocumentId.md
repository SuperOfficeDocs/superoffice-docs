---
title: POST Agents/EMail/GetEMailFromDocumentId
id: v1EMailAgent_GetEMailFromDocumentId
---

# POST Agents/EMail/GetEMailFromDocumentId

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
  "DocumentId": 729
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 438,
      "ContactName": "Dickens-Wunsch",
      "PersonId": 201,
      "PersonName": "Beatty, Larson and McDermott",
      "AssociateId": 496,
      "Address": "et",
      "EmailId": 837,
      "DuplicatePersonIds": [
        554,
        132
      ],
      "Name": "Greenholt LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 722
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 367,
      "ContactName": "Jacobs, Ebert and Fisher",
      "PersonId": 824,
      "PersonName": "Murazik, White and Kemmer",
      "AssociateId": 522,
      "Address": "est",
      "EmailId": 705,
      "DuplicatePersonIds": [
        481,
        98
      ],
      "Name": "Gutkowski, Powlowski and Leannon",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 471
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 877,
      "ContactName": "Jast-Keebler",
      "PersonId": 604,
      "PersonName": "Cummerata, McLaughlin and Braun",
      "AssociateId": 718,
      "Address": "totam",
      "EmailId": 581,
      "DuplicatePersonIds": [
        990,
        707
      ],
      "Name": "Sporer Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 873
        }
      }
    }
  ],
  "Subject": "molestiae",
  "HTMLBody": "velit",
  "From": {
    "ContactId": 693,
    "ContactName": "Crona, Willms and Tremblay",
    "PersonId": 539,
    "PersonName": "Waters, Hartmann and Toy",
    "AssociateId": 412,
    "Address": "accusantium",
    "EmailId": 81,
    "DuplicatePersonIds": [
      271,
      931
    ],
    "Name": "Altenwerth, Leuschke and Anderson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 469
      }
    }
  },
  "Sent": "2003-05-19T18:28:49.0219352+02:00",
  "Size": 870,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "consequatur",
  "PlainBody": "voluptatibus",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 407,
    "AppointmentId": 179,
    "ProjectId": 384,
    "SaleId": 436,
    "Archived": true,
    "ArchivedAt": "1999-06-01T18:28:49.022929+02:00",
    "ArchivedBy": 628,
    "ArchivedDisplayName": "Oberbrunner-O'Hara",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 932
      }
    }
  },
  "ServerId": 469,
  "Attachments": [
    {
      "Description": "Enhanced regional access",
      "Filename": "necessitatibus",
      "Size": 653,
      "Type": "eos",
      "Encoding": "est",
      "Id": "accusantium",
      "Disposition": "nihil",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 429
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Mraz-Turcotte",
      "Values": [
        "dolores",
        "amet"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 178
        }
      }
    },
    {
      "Name": "Mraz-Turcotte",
      "Values": [
        "dolores",
        "amet"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 178
        }
      }
    }
  ],
  "FolderName": "O'Hara, Blanda and Wehner",
  "EmailItemId": 817,
  "AccountId": 41,
  "ReceivedAt": "1995-09-10T18:28:49.0239284+02:00",
  "InReplyTo": {
    "ServerId": 993,
    "MessageId": "explicabo",
    "Subject": "est",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2013-03-29T18:28:49.0239284+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 861,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 465
      }
    }
  },
  "RepliedAt": "2013-02-02T18:28:49.0239284+01:00",
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
      "FieldLength": 631
    }
  }
}
```