---
title: POST Agents/EMail/SendEMails
uid: v1EMailAgent_SendEMails
generated: true
---

# POST Agents/EMail/SendEMails

```http
POST /api/v1/Agents/EMail/SendEMails
```

Send the provided e-mails


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SendEMails?$select=name,department,category/id
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

OutgoingConnectionInfo, Emails, SentItemsConnectionInfo 

| Property Name | Type |  Description |
|----------------|------|--------------|
| OutgoingConnectionInfo | EMailConnectionInfo | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| Emails | Array |  |
| SentItemsConnectionInfo | EMailConnectionInfo | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| To | array | To recipients of e-mail |
| Cc | array | Cc recipients of e-mail |
| Bcc | array | Bcc recipient of e-mail |
| Subject | string | Subject of the e-mail |
| HTMLBody | string | Body formatted in HTML |
| From | EMailAddress | Who did the e-mail originate from |
| Sent | date-time | When was the e-mail sent |
| Size | int32 | Total size of the e-mail |
| Priority | string | Importance of the e-mail |
| Flags | string | Flag status of this mail (unread, replied, deleted ) |
| MessageID | string | Unique id of e-mails |
| PlainBody | string | Body formatted in plain text |
| IsSent | bool | Is this a sent e-mail (not new) |
| EMailSOInfo | EMailSOInfo | Glue between SuperOffice data and an e-mail. |
| ServerId | int32 | Unique id for the e-mail on the server |
| Attachments | array |  |
| CustomHeaderList | array | Non standard e-mail headers |
| FolderName | string | Name of folder the e-mail belongs in |
| EmailItemId | int32 | Primary key |
| AccountId | int32 | Account Id |
| ReceivedAt | date-time | Received date time |
| InReplyTo | EMailEnvelope | The envelope of the email this email is a reply to, if it exists |
| RepliedAt | date-time | When this email was replied at |
| HasCalendarData | bool | If this email contains exactly one iCal appointment |
| CalMethod | string | Method stored in the associated iCal appointment. Indicates if the iCal data is a reply, counter proposal etc. |
| CalReplyStatus | string | Reply status stored in calendar data for the ical method is REPLY |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/SendEMails
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "OutgoingConnectionInfo": null,
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
      "Subject": "adipisci",
      "HTMLBody": "quis",
      "From": null,
      "Sent": "2008-04-24T03:24:47.7520273+02:00",
      "Size": 208,
      "Priority": "High",
      "Flags": "Answered",
      "MessageID": "quos",
      "PlainBody": "totam",
      "IsSent": false,
      "EMailSOInfo": null,
      "ServerId": 613,
      "Attachments": [
        {},
        {}
      ],
      "CustomHeaderList": [
        {},
        {}
      ],
      "FolderName": "Kreiger, Rolfson and Borer",
      "EmailItemId": 56,
      "AccountId": 759,
      "ReceivedAt": "2020-01-14T03:24:47.7520273+01:00",
      "InReplyTo": null,
      "RepliedAt": "2013-04-27T03:24:47.7520273+02:00",
      "HasCalendarData": true,
      "CalMethod": "Add",
      "CalReplyStatus": "Accepted"
    }
  ],
  "SentItemsConnectionInfo": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "To": [
      {
        "ContactId": 451,
        "ContactName": "Hintz, Beatty and Schiller",
        "PersonId": 860,
        "PersonName": "Harvey Inc and Sons",
        "AssociateId": 110,
        "Address": "voluptatibus",
        "EmailId": 646,
        "DuplicatePersonIds": [
          994,
          374
        ],
        "Name": "Osinski LLC",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 822
          }
        }
      }
    ],
    "Cc": [
      {
        "ContactId": 499,
        "ContactName": "Brown LLC",
        "PersonId": 334,
        "PersonName": "Altenwerth-Kilback",
        "AssociateId": 572,
        "Address": "voluptas",
        "EmailId": 211,
        "DuplicatePersonIds": [
          951,
          944
        ],
        "Name": "Batz-Frami",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 16
          }
        }
      }
    ],
    "Bcc": [
      {
        "ContactId": 686,
        "ContactName": "Dooley-Watsica",
        "PersonId": 858,
        "PersonName": "Bahringer, Upton and Carroll",
        "AssociateId": 91,
        "Address": "porro",
        "EmailId": 70,
        "DuplicatePersonIds": [
          556,
          978
        ],
        "Name": "Fritsch, Wehner and Kassulke",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 377
          }
        }
      }
    ],
    "Subject": "repudiandae",
    "HTMLBody": "officia",
    "From": null,
    "Sent": "2006-03-27T03:24:47.7520273+02:00",
    "Size": 574,
    "Priority": "High",
    "Flags": "Answered",
    "MessageID": "reiciendis",
    "PlainBody": "id",
    "IsSent": false,
    "EMailSOInfo": null,
    "ServerId": 740,
    "Attachments": [
      {
        "Description": "Reduced encompassing algorithm",
        "Filename": "et",
        "Size": 668,
        "Type": "animi",
        "Encoding": "et",
        "Id": "libero",
        "Disposition": "optio",
        "IsSafeFileExtension": true,
        "Stream": "GIF89....File contents as raw bytes...",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 596
          }
        }
      }
    ],
    "CustomHeaderList": [
      {
        "Name": "Klein-Schuster",
        "Values": [
          "molestias",
          "voluptatem"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 880
          }
        }
      },
      {
        "Name": "Klein-Schuster",
        "Values": [
          "molestias",
          "voluptatem"
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 880
          }
        }
      }
    ],
    "FolderName": "Feest, Bartell and Hartmann",
    "EmailItemId": 823,
    "AccountId": 506,
    "ReceivedAt": "1998-10-27T03:24:47.7520273+01:00",
    "InReplyTo": null,
    "RepliedAt": "2021-03-25T03:24:47.7520273+01:00",
    "HasCalendarData": false,
    "CalMethod": "Add",
    "CalReplyStatus": "Accepted",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 823
      }
    }
  }
]
```