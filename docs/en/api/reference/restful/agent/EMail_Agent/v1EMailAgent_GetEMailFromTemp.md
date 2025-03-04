---
title: POST Agents/EMail/GetEMailFromTemp
uid: v1EMailAgent_GetEMailFromTemp
generated: true
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
| FileName | String |  |

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
POST /api/v1/Agents/EMail/GetEMailFromTemp
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FileName": "Lubowitz-Murray"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 170,
      "ContactName": "Schuster, Larson and Bosco",
      "PersonId": 396,
      "PersonName": "Nolan LLC",
      "AssociateId": 623,
      "Address": "nulla",
      "EmailId": 342,
      "DuplicatePersonIds": [
        146,
        823
      ],
      "Name": "Emmerich, Wehner and Davis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 839
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 186,
      "ContactName": "Walter-Rolfson",
      "PersonId": 147,
      "PersonName": "Kuhn, McGlynn and D'Amore",
      "AssociateId": 862,
      "Address": "doloremque",
      "EmailId": 608,
      "DuplicatePersonIds": [
        496,
        583
      ],
      "Name": "Jewess-Goodwin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 540
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 723,
      "ContactName": "Schmeler Group",
      "PersonId": 635,
      "PersonName": "Dach, Wunsch and Runolfsdottir",
      "AssociateId": 203,
      "Address": "qui",
      "EmailId": 504,
      "DuplicatePersonIds": [
        977,
        580
      ],
      "Name": "Jaskolski Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 825
        }
      }
    }
  ],
  "Subject": "qui",
  "HTMLBody": "necessitatibus",
  "From": null,
  "Sent": "2021-11-27T14:13:40.2972545+01:00",
  "Size": 263,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "illo",
  "PlainBody": "sint",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 187,
  "Attachments": [
    {
      "Description": "Extended zero tolerance product",
      "Filename": "recusandae",
      "Size": 181,
      "Type": "modi",
      "Encoding": "nobis",
      "Id": "maxime",
      "Disposition": "consequatur",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 543
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Ullrich-Hauck",
      "Values": [
        "velit",
        "sequi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    },
    {
      "Name": "Ullrich-Hauck",
      "Values": [
        "velit",
        "sequi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    }
  ],
  "FolderName": "Crooks Group",
  "EmailItemId": 156,
  "AccountId": 435,
  "ReceivedAt": "2016-03-08T14:13:40.2972545+01:00",
  "InReplyTo": null,
  "RepliedAt": "2021-10-18T14:13:40.2972545+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 468
    }
  }
}
```