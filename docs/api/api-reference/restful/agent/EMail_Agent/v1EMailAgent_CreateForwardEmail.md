---
title: CreateForwardEmail
id: v1EMailAgent_CreateForwardEmail
---

# CreateForwardEmail

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
Accept-Language: en
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
    "Subject": "eum",
    "HTMLBody": "rerum",
    "From": {},
    "Sent": "2015-01-16T14:58:04.1634604+01:00",
    "Size": 407,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "quis",
    "PlainBody": "sed",
    "IsSent": false,
    "EMailSOInfo": {},
    "ServerId": 725,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Ziemann, Wilkinson and Kirlin",
    "EmailItemId": 408,
    "AccountId": 661,
    "ReceivedAt": "2001-09-28T14:58:04.1634604+02:00",
    "InReplyTo": {},
    "RepliedAt": "2003-10-13T14:58:04.1634604+02:00",
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
      "ContactId": 813,
      "ContactName": "McCullough, Thiel and Sporer",
      "PersonId": 404,
      "PersonName": "Swaniawski, Fadel and Ferry",
      "AssociateId": 488,
      "Address": "voluptatem",
      "EmailId": 210,
      "DuplicatePersonIds": [
        963,
        133
      ],
      "Name": "Borer, Schamberger and Lang",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 110
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 172,
      "ContactName": "Wiegand-Turcotte",
      "PersonId": 682,
      "PersonName": "Macejkovic-Hane",
      "AssociateId": 280,
      "Address": "reiciendis",
      "EmailId": 642,
      "DuplicatePersonIds": [
        315,
        437
      ],
      "Name": "Casper, Moore and Bergnaum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 390,
      "ContactName": "Lemke Inc and Sons",
      "PersonId": 882,
      "PersonName": "Kiehn LLC",
      "AssociateId": 843,
      "Address": "maiores",
      "EmailId": 476,
      "DuplicatePersonIds": [
        710,
        221
      ],
      "Name": "Wisoky-Dicki",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    }
  ],
  "Subject": "incidunt",
  "HTMLBody": "illum",
  "From": {
    "ContactId": 468,
    "ContactName": "Orn Group",
    "PersonId": 323,
    "PersonName": "Daniel, Kreiger and Kessler",
    "AssociateId": 239,
    "Address": "consequatur",
    "EmailId": 396,
    "DuplicatePersonIds": [
      547,
      281
    ],
    "Name": "Schaden, Hoppe and Wisoky",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 644
      }
    }
  },
  "Sent": "2003-04-08T14:58:04.1654603+02:00",
  "Size": 647,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "totam",
  "PlainBody": "exercitationem",
  "IsSent": false,
  "EMailSOInfo": {
    "DocumentId": 215,
    "AppointmentId": 470,
    "ProjectId": 416,
    "SaleId": 57,
    "Archived": false,
    "ArchivedAt": "2005-05-30T14:58:04.1654603+02:00",
    "ArchivedBy": 521,
    "ArchivedDisplayName": "Schroeder Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 602
      }
    }
  },
  "ServerId": 798,
  "Attachments": [
    {
      "Description": "Exclusive foreground definition",
      "Filename": "impedit",
      "Size": 265,
      "Type": "reiciendis",
      "Encoding": "qui",
      "Id": "aliquam",
      "Disposition": "fuga",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 946
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Cremin, Walsh and Cole",
      "Values": [
        "odit",
        "et"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 462
        }
      }
    },
    {
      "Name": "Cremin, Walsh and Cole",
      "Values": [
        "odit",
        "et"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 462
        }
      }
    }
  ],
  "FolderName": "Bauch-Bayer",
  "EmailItemId": 78,
  "AccountId": 937,
  "ReceivedAt": "2003-03-18T14:58:04.1654603+01:00",
  "InReplyTo": {
    "ServerId": 194,
    "MessageId": "qui",
    "Subject": "unde",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2008-04-02T14:58:04.1664604+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 784,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 714
      }
    }
  },
  "RepliedAt": "1994-08-31T14:58:04.1664604+02:00",
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
      "FieldLength": 14
    }
  }
}
```