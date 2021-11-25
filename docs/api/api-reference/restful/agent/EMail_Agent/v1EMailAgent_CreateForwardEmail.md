---
title: POST Agents/EMail/CreateForwardEmail
id: v1EMailAgent_CreateForwardEmail
---

# POST Agents/EMail/CreateForwardEmail

```http
POST /api/v1/Agents/EMail/CreateForwardEmail
```

Create forward email



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/CreateForwardEmail?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/CreateForwardEmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
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
    "Subject": "magni",
    "HTMLBody": "perspiciatis",
    "From": {},
    "Sent": "2020-04-01T18:28:48.973955+02:00",
    "Size": 295,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "quis",
    "PlainBody": "est",
    "IsSent": false,
    "EMailSOInfo": {},
    "ServerId": 112,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Will-Kiehn",
    "EmailItemId": 676,
    "AccountId": 580,
    "ReceivedAt": "2014-08-24T18:28:48.9749549+02:00",
    "InReplyTo": {},
    "RepliedAt": "2007-01-31T18:28:48.9749549+01:00",
    "HasCalendarData": true,
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
      "ContactId": 902,
      "ContactName": "Marks-Huel",
      "PersonId": 563,
      "PersonName": "Von LLC",
      "AssociateId": 239,
      "Address": "quisquam",
      "EmailId": 103,
      "DuplicatePersonIds": [
        889,
        300
      ],
      "Name": "Padberg-Koss",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 319
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 915,
      "ContactName": "Wisoky, Bashirian and Beahan",
      "PersonId": 514,
      "PersonName": "Zieme-McCullough",
      "AssociateId": 346,
      "Address": "quis",
      "EmailId": 801,
      "DuplicatePersonIds": [
        139,
        823
      ],
      "Name": "Lehner, Crist and Kihn",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 228
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 174,
      "ContactName": "Sipes, Monahan and Gerhold",
      "PersonId": 585,
      "PersonName": "Jewess-Moen",
      "AssociateId": 217,
      "Address": "maiores",
      "EmailId": 941,
      "DuplicatePersonIds": [
        603,
        358
      ],
      "Name": "Mueller-Johnson",
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
  "Subject": "sunt",
  "HTMLBody": "vel",
  "From": {
    "ContactId": 8,
    "ContactName": "Schuster, Champlin and Zemlak",
    "PersonId": 17,
    "PersonName": "Klocko Group",
    "AssociateId": 105,
    "Address": "ut",
    "EmailId": 237,
    "DuplicatePersonIds": [
      415,
      56
    ],
    "Name": "Keeling, Bernier and Mills",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 177
      }
    }
  },
  "Sent": "2004-05-09T18:28:48.9779273+02:00",
  "Size": 823,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "officiis",
  "PlainBody": "sed",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 452,
    "AppointmentId": 446,
    "ProjectId": 579,
    "SaleId": 591,
    "Archived": false,
    "ArchivedAt": "2008-10-16T18:28:48.9779273+02:00",
    "ArchivedBy": 224,
    "ArchivedDisplayName": "Raynor LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 725
      }
    }
  },
  "ServerId": 187,
  "Attachments": [
    {
      "Description": "User-centric methodical hardware",
      "Filename": "maxime",
      "Size": 487,
      "Type": "recusandae",
      "Encoding": "voluptas",
      "Id": "nemo",
      "Disposition": "quasi",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 988
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "King-Schiller",
      "Values": [
        "laudantium",
        "tenetur"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 402
        }
      }
    },
    {
      "Name": "King-Schiller",
      "Values": [
        "laudantium",
        "tenetur"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 402
        }
      }
    }
  ],
  "FolderName": "Waelchi LLC",
  "EmailItemId": 99,
  "AccountId": 970,
  "ReceivedAt": "2021-11-03T18:28:48.9779273+01:00",
  "InReplyTo": {
    "ServerId": 391,
    "MessageId": "labore",
    "Subject": "aliquam",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2009-11-26T18:28:48.9779273+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 828,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 113
      }
    }
  },
  "RepliedAt": "2009-11-23T18:28:48.9779273+01:00",
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
        "Reason": "enable revolutionary e-tailers"
      },
      "FieldType": "System.String",
      "FieldLength": 67
    }
  }
}
```