---
title: POST Agents/EMail/SaveToMailServer
id: v1EMailAgent_SaveToMailServer
---

# POST Agents/EMail/SaveToMailServer

```http
POST /api/v1/Agents/EMail/SaveToMailServer
```

Save the passed e-mail back to the mail server



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SaveToMailServer?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/SaveToMailServer
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
    "Subject": "sint",
    "HTMLBody": "magnam",
    "From": {},
    "Sent": "2005-04-24T18:28:49.0699577+02:00",
    "Size": 899,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "minima",
    "PlainBody": "eos",
    "IsSent": true,
    "EMailSOInfo": {},
    "ServerId": 7,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Bosco-Kiehn",
    "EmailItemId": 975,
    "AccountId": 895,
    "ReceivedAt": "2002-02-26T18:28:49.0699577+01:00",
    "InReplyTo": {},
    "RepliedAt": "2013-03-16T18:28:49.0699577+01:00",
    "HasCalendarData": false,
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
      "ContactId": 73,
      "ContactName": "Walker, Runolfsson and Ledner",
      "PersonId": 53,
      "PersonName": "Nicolas, Huel and Leannon",
      "AssociateId": 257,
      "Address": "at",
      "EmailId": 412,
      "DuplicatePersonIds": [
        867,
        663
      ],
      "Name": "Daugherty-Homenick",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 530
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 382,
      "ContactName": "Hagenes-Glover",
      "PersonId": 627,
      "PersonName": "McLaughlin Group",
      "AssociateId": 276,
      "Address": "maiores",
      "EmailId": 637,
      "DuplicatePersonIds": [
        130,
        947
      ],
      "Name": "Fisher Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 456
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 812,
      "ContactName": "Powlowski Group",
      "PersonId": 300,
      "PersonName": "Ritchie, Aufderhar and Barrows",
      "AssociateId": 104,
      "Address": "laborum",
      "EmailId": 331,
      "DuplicatePersonIds": [
        545,
        144
      ],
      "Name": "Sauer Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 983
        }
      }
    }
  ],
  "Subject": "accusamus",
  "HTMLBody": "id",
  "From": {
    "ContactId": 717,
    "ContactName": "Wehner-Halvorson",
    "PersonId": 861,
    "PersonName": "O'Conner-Blanda",
    "AssociateId": 571,
    "Address": "et",
    "EmailId": 307,
    "DuplicatePersonIds": [
      329,
      654
    ],
    "Name": "Tromp, Frami and Olson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 403
      }
    }
  },
  "Sent": "2021-04-02T18:28:49.0729573+02:00",
  "Size": 28,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "consequatur",
  "PlainBody": "eum",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 827,
    "AppointmentId": 192,
    "ProjectId": 563,
    "SaleId": 953,
    "Archived": true,
    "ArchivedAt": "2019-08-11T18:28:49.0729573+02:00",
    "ArchivedBy": 712,
    "ArchivedDisplayName": "Borer Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 599
      }
    }
  },
  "ServerId": 477,
  "Attachments": [
    {
      "Description": "Total multi-tasking throughput",
      "Filename": "minus",
      "Size": 103,
      "Type": "facere",
      "Encoding": "ipsam",
      "Id": "voluptates",
      "Disposition": "totam",
      "Stream": "GIF89....File contents as raw bytes...",
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
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Schiller, Buckridge and Runolfsdottir",
      "Values": [
        "totam",
        "sed"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    },
    {
      "Name": "Schiller, Buckridge and Runolfsdottir",
      "Values": [
        "totam",
        "sed"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    }
  ],
  "FolderName": "Goodwin-Kautzer",
  "EmailItemId": 810,
  "AccountId": 504,
  "ReceivedAt": "1999-10-06T18:28:49.0739613+02:00",
  "InReplyTo": {
    "ServerId": 56,
    "MessageId": "explicabo",
    "Subject": "ducimus",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2009-12-16T18:28:49.0739613+01:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 56,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 161
      }
    }
  },
  "RepliedAt": "2013-03-17T18:28:49.0739613+01:00",
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
      "FieldLength": 888
    }
  }
}
```