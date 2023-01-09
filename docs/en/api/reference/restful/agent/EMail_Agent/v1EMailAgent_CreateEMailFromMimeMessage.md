---
title: POST Agents/EMail/CreateEMailFromMimeMessage
uid: v1EMailAgent_CreateEMailFromMimeMessage
---

# POST Agents/EMail/CreateEMailFromMimeMessage

```http
POST /api/v1/Agents/EMail/CreateEMailFromMimeMessage
```

Get an e-mail based on the provided MIME-message


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/CreateEMailFromMimeMessage?$select=name,department,category/id
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

MimeMessage 

| Property Name | Type |  Description |
|----------------|------|--------------|
| MimeMessage | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: EMailEntity

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/CreateEMailFromMimeMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MimeMessage": "fuga"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 843,
      "ContactName": "Nader Inc and Sons",
      "PersonId": 927,
      "PersonName": "Ritchie, Oberbrunner and Kilback",
      "AssociateId": 327,
      "Address": "vel",
      "EmailId": 846,
      "DuplicatePersonIds": [
        822,
        649
      ],
      "Name": "Berge, Towne and Nolan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 675
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 813,
      "ContactName": "Pfannerstill Inc and Sons",
      "PersonId": 880,
      "PersonName": "Blick Inc and Sons",
      "AssociateId": 266,
      "Address": "laudantium",
      "EmailId": 838,
      "DuplicatePersonIds": [
        277,
        765
      ],
      "Name": "O'Conner-Cole",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 549
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 403,
      "ContactName": "Schumm-McClure",
      "PersonId": 378,
      "PersonName": "Purdy Group",
      "AssociateId": 850,
      "Address": "quas",
      "EmailId": 251,
      "DuplicatePersonIds": [
        172,
        679
      ],
      "Name": "Wunsch Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    }
  ],
  "Subject": "facilis",
  "HTMLBody": "voluptatibus",
  "From": null,
  "Sent": "2022-09-09T17:37:17.9932408+02:00",
  "Size": 354,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "voluptate",
  "PlainBody": "et",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 794,
  "Attachments": [
    {
      "Description": "Quality-focused tertiary installation",
      "Filename": "est",
      "Size": 262,
      "Type": "temporibus",
      "Encoding": "doloremque",
      "Id": "perspiciatis",
      "Disposition": "dolorem",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 983
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hoppe, Aufderhar and Reichert",
      "Values": [
        "rerum",
        "recusandae"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    },
    {
      "Name": "Hoppe, Aufderhar and Reichert",
      "Values": [
        "rerum",
        "recusandae"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 535
        }
      }
    }
  ],
  "FolderName": "Littel, Luettgen and Hessel",
  "EmailItemId": 429,
  "AccountId": 387,
  "ReceivedAt": "1998-07-02T17:37:17.9932408+02:00",
  "InReplyTo": null,
  "RepliedAt": "2006-11-14T17:37:17.9932408+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 696
    }
  }
}
```