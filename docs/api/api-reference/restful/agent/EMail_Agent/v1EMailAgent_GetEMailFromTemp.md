---
title: POST Agents/EMail/GetEMailFromTemp
id: v1EMailAgent_GetEMailFromTemp
---

# POST Agents/EMail/GetEMailFromTemp

```http
POST /api/v1/Agents/EMail/GetEMailFromTemp
```

<para />

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromTemp?$select=name,department,category/id
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

FileName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FileName | string |  |


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
POST /api/v1/Agents/EMail/GetEMailFromTemp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FileName": "Schumm-Friesen"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 736,
      "ContactName": "Weber-Funk",
      "PersonId": 587,
      "PersonName": "Torp LLC",
      "AssociateId": 622,
      "Address": "sunt",
      "EmailId": 882,
      "DuplicatePersonIds": [
        168,
        384
      ],
      "Name": "Marquardt, Parker and Thiel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 558
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 745,
      "ContactName": "Dibbert-Stehr",
      "PersonId": 515,
      "PersonName": "Bins, Zulauf and Streich",
      "AssociateId": 804,
      "Address": "fugit",
      "EmailId": 792,
      "DuplicatePersonIds": [
        426,
        697
      ],
      "Name": "Wilderman Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 644
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 458,
      "ContactName": "Fay, Lindgren and Boehm",
      "PersonId": 539,
      "PersonName": "Nader LLC",
      "AssociateId": 597,
      "Address": "dolor",
      "EmailId": 870,
      "DuplicatePersonIds": [
        541,
        69
      ],
      "Name": "Reinger, Bins and Jacobson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 810
        }
      }
    }
  ],
  "Subject": "deserunt",
  "HTMLBody": "debitis",
  "From": {
    "ContactId": 661,
    "ContactName": "Kiehn, Reichert and Mosciski",
    "PersonId": 277,
    "PersonName": "Weimann Inc and Sons",
    "AssociateId": 624,
    "Address": "qui",
    "EmailId": 536,
    "DuplicatePersonIds": [
      754,
      233
    ],
    "Name": "Kozey Inc and Sons",
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
  },
  "Sent": "2015-03-06T16:48:29.4979238+01:00",
  "Size": 468,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "expedita",
  "PlainBody": "dolor",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 953,
    "AppointmentId": 546,
    "ProjectId": 661,
    "SaleId": 590,
    "Archived": false,
    "ArchivedAt": "2017-05-26T16:48:29.4979238+02:00",
    "ArchivedBy": 874,
    "ArchivedDisplayName": "Turcotte-Runolfsson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 758
      }
    }
  },
  "ServerId": 344,
  "Attachments": [
    {
      "Description": "Synergistic systemic pricing structure",
      "Filename": "sit",
      "Size": 985,
      "Type": "voluptatibus",
      "Encoding": "nihil",
      "Id": "reiciendis",
      "Disposition": "ab",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 24
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Auer-Denesik",
      "Values": [
        "neque",
        "beatae"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    },
    {
      "Name": "Auer-Denesik",
      "Values": [
        "neque",
        "beatae"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    }
  ],
  "FolderName": "Borer-Brown",
  "EmailItemId": 712,
  "AccountId": 687,
  "ReceivedAt": "2002-01-21T16:48:29.4979238+01:00",
  "InReplyTo": {
    "ServerId": 793,
    "MessageId": "magni",
    "Subject": "adipisci",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1994-08-27T16:48:29.4979238+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 886,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "leverage dynamic solutions"
        },
        "FieldType": "System.Int32",
        "FieldLength": 349
      }
    }
  },
  "RepliedAt": "1998-02-17T16:48:29.4979238+01:00",
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
      "FieldLength": 341
    }
  }
}
```