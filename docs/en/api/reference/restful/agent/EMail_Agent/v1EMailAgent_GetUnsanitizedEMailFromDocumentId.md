---
title: POST Agents/EMail/GetUnsanitizedEMailFromDocumentId
uid: v1EMailAgent_GetUnsanitizedEMailFromDocumentId
generated: true
---

# POST Agents/EMail/GetUnsanitizedEMailFromDocumentId

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId
```

Get an e-mail based on an archived document.


The returned value is not sanitized.


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId?$select=name,department,category/id
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

DocumentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | Integer |  |

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetUnsanitizedEMailFromDocumentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 471
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 945,
      "ContactName": "Fisher Group",
      "PersonId": 660,
      "PersonName": "Towne-Hegmann",
      "AssociateId": 963,
      "Address": "repellat",
      "EmailId": 194,
      "DuplicatePersonIds": [
        953,
        145
      ],
      "Name": "Nolan, Wyman and Nader",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1000
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 171,
      "ContactName": "Abshire-Swaniawski",
      "PersonId": 303,
      "PersonName": "Gulgowski-Fritsch",
      "AssociateId": 829,
      "Address": "et",
      "EmailId": 543,
      "DuplicatePersonIds": [
        878,
        906
      ],
      "Name": "Gerhold Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 953
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 719,
      "ContactName": "Rice Inc and Sons",
      "PersonId": 763,
      "PersonName": "Wyman Inc and Sons",
      "AssociateId": 826,
      "Address": "eos",
      "EmailId": 765,
      "DuplicatePersonIds": [
        697,
        919
      ],
      "Name": "Franecki-Volkman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 369
        }
      }
    }
  ],
  "Subject": "nemo",
  "HTMLBody": "distinctio",
  "From": null,
  "Sent": "1999-05-19T16:00:40.9456053+02:00",
  "Size": 435,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "molestiae",
  "PlainBody": "similique",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 863,
  "Attachments": [
    {
      "Description": "Assimilated client-driven internet solution",
      "Filename": "maiores",
      "Size": 606,
      "Type": "deserunt",
      "Encoding": "et",
      "Id": "reiciendis",
      "Disposition": "quaerat",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 933
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Vandervort-Williamson",
      "Values": [
        "voluptatem",
        "magnam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 291
        }
      }
    },
    {
      "Name": "Vandervort-Williamson",
      "Values": [
        "voluptatem",
        "magnam"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 291
        }
      }
    }
  ],
  "FolderName": "Hodkiewicz-Bednar",
  "EmailItemId": 307,
  "AccountId": 796,
  "ReceivedAt": "2015-09-29T16:00:40.9456053+02:00",
  "InReplyTo": null,
  "RepliedAt": "1996-12-24T16:00:40.9456053+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 173
    }
  }
}
```