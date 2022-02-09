---
title: POST Agents/EMail/Send
id: v1EMailAgent_Send
---

# POST Agents/EMail/Send

```http
POST /api/v1/Agents/EMail/Send
```

Send the provided e-mails



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/Send?$select=name,department,category/id
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

Emails 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Emails | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
POST /api/v1/Agents/EMail/Send
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Emails": [
    {
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
      "Subject": "ex",
      "HTMLBody": "est",
      "From": {},
      "Sent": "2003-03-29T18:28:48.9709579+01:00",
      "Size": 225,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "consectetur",
      "PlainBody": "quam",
      "IsSent": true,
      "EMailSOInfo": {},
      "ServerId": 75,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Wolff, Blanda and Parker",
      "EmailItemId": 272,
      "AccountId": 13,
      "ReceivedAt": "2013-09-10T18:28:48.9709579+02:00",
      "InReplyTo": {},
      "RepliedAt": "1994-10-05T18:28:48.9709579+02:00",
      "HasCalendarData": false,
      "CalMethod": "Add",
      "CalReplyStatus": "Accepted"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "To": [
      {
        "ContactId": 602,
        "ContactName": "Herman, Prohaska and Hansen",
        "PersonId": 522,
        "PersonName": "Gerlach, Feil and Hagenes",
        "AssociateId": 97,
        "Address": "dignissimos",
        "EmailId": 371,
        "DuplicatePersonIds": [
          492,
          784
        ],
        "Name": "Ryan-Murphy",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 944
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 339,
        "ContactName": "Beatty Inc and Sons",
        "PersonId": 428,
        "PersonName": "Lueilwitz LLC",
        "AssociateId": 480,
        "Address": "est",
        "EmailId": 554,
        "DuplicatePersonIds": [
          257,
          317
        ],
        "Name": "Metz-O'Keefe",
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
      }
    ],
    "Bcc": [
      {
        "ContactId": 475,
        "ContactName": "Greenholt, Miller and Batz",
        "PersonId": 816,
        "PersonName": "Rath-Dibbert",
        "AssociateId": 221,
        "Address": "debitis",
        "EmailId": 906,
        "DuplicatePersonIds": [
          19,
          696
        ],
        "Name": "Howe Inc and Sons",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 618
          }
        }
      }
    ],
    "Subject": "quisquam",
    "HTMLBody": "ut",
    "From": {
      "ContactId": 469,
      "ContactName": "Dare, Wiza and Roob",
      "PersonId": 807,
      "PersonName": "Hackett, Stracke and Bernhard",
      "AssociateId": 757,
      "Address": "iure",
      "EmailId": 484,
      "DuplicatePersonIds": [
        18,
        889
      ],
      "Name": "Altenwerth LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    },
    "Sent": "2013-02-18T18:28:48.973955+01:00",
    "Size": 269,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "et",
    "PlainBody": "dolor",
    "IsSent": false,
    "EMailSOInfo": {
      "DocumentId": 785,
      "AppointmentId": 805,
      "ProjectId": 349,
      "SaleId": 722,
      "Archived": false,
      "ArchivedAt": "2016-02-13T18:28:48.973955+01:00",
      "ArchivedBy": 464,
      "ArchivedDisplayName": "Wunsch-Mertz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 855
        }
      }
    },
    "ServerId": 890,
    "Attachments": [
      {
        "Description": "Multi-tiered multi-tasking secured line",
        "Filename": "ratione",
        "Size": 205,
        "Type": "rerum",
        "Encoding": "accusamus",
        "Id": "impedit",
        "Disposition": "fugiat",
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 286
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Rohan LLC",
        "Values": [
          "exercitationem",
          "vitae"
        ],
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "visualize enterprise platforms"
            },
            "FieldType": "System.Int32",
            "FieldLength": 798
          }
        }
      },
      {
        "Name": "Rohan LLC",
        "Values": [
          "exercitationem",
          "vitae"
        ],
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "visualize enterprise platforms"
            },
            "FieldType": "System.Int32",
            "FieldLength": 798
          }
        }
      }
    ],
    "FolderName": "Pfannerstill-Kuhn",
    "EmailItemId": 480,
    "AccountId": 101,
    "ReceivedAt": "2007-04-16T18:28:48.973955+02:00",
    "InReplyTo": {
      "ServerId": 638,
      "MessageId": "rerum",
      "Subject": "dolor",
      "From": {},
      "To": [
        {},
        {}
      ],
      "Sent": "1998-07-23T18:28:48.973955+02:00",
      "Priority": "High",
      "Flags": "Answered",
      "Size": 283,
      "EMailSOInfo": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 148
        }
      }
    },
    "RepliedAt": "2012-07-09T18:28:48.973955+02:00",
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
        "FieldType": "System.String",
        "FieldLength": 93
      }
    }
  }
]
```