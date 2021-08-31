---
title: Save
id: v1EMailAgent_Save
---

# Save

```http
POST /api/v1/Agents/EMail/Save
```

Save the e-mail back to the database



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/Save?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/Save
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
    "Subject": "ipsa",
    "HTMLBody": "id",
    "From": {},
    "Sent": "1994-07-22T14:58:04.1504304+02:00",
    "Size": 631,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "enim",
    "PlainBody": "iste",
    "IsSent": false,
    "EMailSOInfo": {},
    "ServerId": 350,
    "Attachments": [
      {},
      {}
    ],
    "CustomHeaderList": [
      {},
      {}
    ],
    "FolderName": "Hammes LLC",
    "EmailItemId": 689,
    "AccountId": 466,
    "ReceivedAt": "2010-03-23T14:58:04.1504304+01:00",
    "InReplyTo": {},
    "RepliedAt": "1996-10-01T14:58:04.1504304+02:00",
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
      "ContactId": 522,
      "ContactName": "Schroeder, Schmitt and Krajcik",
      "PersonId": 507,
      "PersonName": "Ratke-Rogahn",
      "AssociateId": 973,
      "Address": "neque",
      "EmailId": 263,
      "DuplicatePersonIds": [
        350,
        317
      ],
      "Name": "Yost Group",
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
    }
  ],
  "Cc": [
    {
      "ContactId": 991,
      "ContactName": "Thiel Inc and Sons",
      "PersonId": 673,
      "PersonName": "Baumbach-Mills",
      "AssociateId": 368,
      "Address": "et",
      "EmailId": 328,
      "DuplicatePersonIds": [
        209,
        538
      ],
      "Name": "Trantow Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 589
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 410,
      "ContactName": "Corwin, Reichel and Koepp",
      "PersonId": 126,
      "PersonName": "Bailey Group",
      "AssociateId": 857,
      "Address": "consequatur",
      "EmailId": 718,
      "DuplicatePersonIds": [
        953,
        707
      ],
      "Name": "Denesik, Skiles and Ankunding",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "maximize world-class bandwidth"
          },
          "FieldType": "System.String",
          "FieldLength": 142
        }
      }
    }
  ],
  "Subject": "repellat",
  "HTMLBody": "sunt",
  "From": {
    "ContactId": 311,
    "ContactName": "Lemke Inc and Sons",
    "PersonId": 583,
    "PersonName": "Reinger LLC",
    "AssociateId": 208,
    "Address": "placeat",
    "EmailId": 580,
    "DuplicatePersonIds": [
      377,
      849
    ],
    "Name": "Williamson LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 995
      }
    }
  },
  "Sent": "1999-09-04T14:58:04.1524302+02:00",
  "Size": 479,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "eos",
  "PlainBody": "repellendus",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 346,
    "AppointmentId": 296,
    "ProjectId": 931,
    "SaleId": 419,
    "Archived": false,
    "ArchivedAt": "1995-08-19T14:58:04.1524302+02:00",
    "ArchivedBy": 833,
    "ArchivedDisplayName": "Hills-Huel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 635
      }
    }
  },
  "ServerId": 924,
  "Attachments": [
    {
      "Description": "Organic contextually-based protocol",
      "Filename": "reiciendis",
      "Size": 651,
      "Type": "velit",
      "Encoding": "culpa",
      "Id": "possimus",
      "Disposition": "est",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 789
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Barton, Klein and O'Connell",
      "Values": [
        "corporis",
        "consequuntur"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    },
    {
      "Name": "Barton, Klein and O'Connell",
      "Values": [
        "corporis",
        "consequuntur"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    }
  ],
  "FolderName": "Dare-Spinka",
  "EmailItemId": 341,
  "AccountId": 877,
  "ReceivedAt": "2005-12-08T14:58:04.1534302+01:00",
  "InReplyTo": {
    "ServerId": 330,
    "MessageId": "consequatur",
    "Subject": "voluptatem",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "1997-06-20T14:58:04.1544306+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 42,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 595
      }
    }
  },
  "RepliedAt": "2015-08-28T14:58:04.1544306+02:00",
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
      "FieldLength": 991
    }
  }
}
```