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
| MimeMessage | string |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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

## Sample request

```http!
POST /api/v1/Agents/EMail/CreateEMailFromMimeMessage
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "MimeMessage": "velit"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 830,
      "ContactName": "Bartoletti-Stracke",
      "PersonId": 130,
      "PersonName": "Cronin, Streich and Ebert",
      "AssociateId": 99,
      "Address": "voluptate",
      "EmailId": 963,
      "DuplicatePersonIds": [
        75,
        933
      ],
      "Name": "Mayert-Greenfelder",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 261
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 327,
      "ContactName": "Gorczany Inc and Sons",
      "PersonId": 32,
      "PersonName": "Glover LLC",
      "AssociateId": 422,
      "Address": "est",
      "EmailId": 38,
      "DuplicatePersonIds": [
        396,
        762
      ],
      "Name": "Luettgen Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 501
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 749,
      "ContactName": "Swaniawski LLC",
      "PersonId": 983,
      "PersonName": "Zieme Inc and Sons",
      "AssociateId": 979,
      "Address": "officia",
      "EmailId": 532,
      "DuplicatePersonIds": [
        183,
        477
      ],
      "Name": "Reilly, Kessler and Ward",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 703
        }
      }
    }
  ],
  "Subject": "culpa",
  "HTMLBody": "distinctio",
  "From": null,
  "Sent": "2021-01-13T02:49:44.4660393+01:00",
  "Size": 366,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "cupiditate",
  "PlainBody": "commodi",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 143,
  "Attachments": [
    {
      "Description": "Triple-buffered disintermediate interface",
      "Filename": "nulla",
      "Size": 577,
      "Type": "consequatur",
      "Encoding": "qui",
      "Id": "quis",
      "Disposition": "quibusdam",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 861
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Boyle-Smith",
      "Values": [
        "assumenda",
        "natus"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 122
        }
      }
    },
    {
      "Name": "Boyle-Smith",
      "Values": [
        "assumenda",
        "natus"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 122
        }
      }
    }
  ],
  "FolderName": "Pouros-Treutel",
  "EmailItemId": 300,
  "AccountId": 713,
  "ReceivedAt": "2008-06-02T02:49:44.4660393+02:00",
  "InReplyTo": null,
  "RepliedAt": "2016-03-24T02:49:44.4660393+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 765
    }
  }
}
```