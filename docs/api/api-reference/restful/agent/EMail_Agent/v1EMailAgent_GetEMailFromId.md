---
title: GetEMailFromId
id: v1EMailAgent_GetEMailFromId
---

# GetEMailFromId

```http
POST /api/v1/Agents/EMail/GetEMailFromId
```

Get en e-mail based on its unique id



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromId?$select=name,department,category/id
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

ConnectionInfo, MessageServerId, LookupAddresses, Flags, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectionInfo |  | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| MessageServerId | int32 |  |
| LookupAddresses | bool |  |
| Flags | string |  |
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
POST /api/v1/Agents/EMail/GetEMailFromId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": {
    "ServerName": "Waters-Stracke",
    "UserName": "Robel Inc and Sons",
    "Password": "amet",
    "Folder": "iusto",
    "UseSSL": false
  },
  "MessageServerId": 574,
  "LookupAddresses": true,
  "Flags": "Answered",
  "IncludeAttachments": false
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 878,
      "ContactName": "Metz LLC",
      "PersonId": 180,
      "PersonName": "Hodkiewicz-Waters",
      "AssociateId": 374,
      "Address": "voluptas",
      "EmailId": 628,
      "DuplicatePersonIds": [
        871,
        884
      ],
      "Name": "Goyette-Nicolas",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 533
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 552,
      "ContactName": "Halvorson LLC",
      "PersonId": 942,
      "PersonName": "Williamson-Moen",
      "AssociateId": 184,
      "Address": "totam",
      "EmailId": 669,
      "DuplicatePersonIds": [
        536,
        624
      ],
      "Name": "Rau-Harris",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 64
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 576,
      "ContactName": "Labadie-Bogisich",
      "PersonId": 788,
      "PersonName": "Lueilwitz, Jones and Bashirian",
      "AssociateId": 311,
      "Address": "animi",
      "EmailId": 66,
      "DuplicatePersonIds": [
        327,
        768
      ],
      "Name": "Wolf Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 192
        }
      }
    }
  ],
  "Subject": "exercitationem",
  "HTMLBody": "suscipit",
  "From": {
    "ContactId": 261,
    "ContactName": "Maggio Inc and Sons",
    "PersonId": 70,
    "PersonName": "Schaefer-Konopelski",
    "AssociateId": 978,
    "Address": "consequatur",
    "EmailId": 411,
    "DuplicatePersonIds": [
      156,
      595
    ],
    "Name": "Deckow-Corkery",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 472
      }
    }
  },
  "Sent": "2013-07-15T14:58:04.2044598+02:00",
  "Size": 890,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "reprehenderit",
  "PlainBody": "id",
  "IsSent": true,
  "EMailSOInfo": {
    "DocumentId": 25,
    "AppointmentId": 214,
    "ProjectId": 130,
    "SaleId": 453,
    "Archived": false,
    "ArchivedAt": "2006-09-08T14:58:04.2044598+02:00",
    "ArchivedBy": 861,
    "ArchivedDisplayName": "Fisher, Zboncak and Schroeder",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 470
      }
    }
  },
  "ServerId": 568,
  "Attachments": [
    {
      "Description": "Cloned intangible access",
      "Filename": "ipsa",
      "Size": 130,
      "Type": "necessitatibus",
      "Encoding": "sapiente",
      "Id": "consequuntur",
      "Disposition": "nostrum",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Metz, Goyette and Prosacco",
      "Values": [
        "vero",
        "velit"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 877
        }
      }
    },
    {
      "Name": "Metz, Goyette and Prosacco",
      "Values": [
        "vero",
        "velit"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 877
        }
      }
    }
  ],
  "FolderName": "Beahan, Wisozk and Schiller",
  "EmailItemId": 697,
  "AccountId": 861,
  "ReceivedAt": "2013-07-11T14:58:04.205463+02:00",
  "InReplyTo": {
    "ServerId": 595,
    "MessageId": "saepe",
    "Subject": "labore",
    "From": {},
    "To": [
      {},
      {}
    ],
    "Sent": "2005-08-04T14:58:04.205463+02:00",
    "Priority": "High",
    "Flags": "Answered",
    "Size": 734,
    "EMailSOInfo": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 338
      }
    }
  },
  "RepliedAt": "1998-01-08T14:58:04.205463+01:00",
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
        "Reason": "revolutionize extensible platforms"
      },
      "FieldType": "System.Int32",
      "FieldLength": 636
    }
  }
}
```