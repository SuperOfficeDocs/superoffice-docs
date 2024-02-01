---
title: POST Agents/EMail/GetEMailFromDocumentId
uid: v1EMailAgent_GetEMailFromDocumentId
generated: true
---

# POST Agents/EMail/GetEMailFromDocumentId

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentId
```

Get an e-mail based on an archived document


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentId?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/GetEMailFromDocumentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 476
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 566,
      "ContactName": "Baumbach, Jerde and Considine",
      "PersonId": 104,
      "PersonName": "Schroeder-Douglas",
      "AssociateId": 818,
      "Address": "et",
      "EmailId": 73,
      "DuplicatePersonIds": [
        880,
        9
      ],
      "Name": "Ondricka-Mayert",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 601
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 1000,
      "ContactName": "Bashirian-Klocko",
      "PersonId": 171,
      "PersonName": "Larson-DuBuque",
      "AssociateId": 471,
      "Address": "sint",
      "EmailId": 250,
      "DuplicatePersonIds": [
        783,
        375
      ],
      "Name": "Murazik, Walsh and Watsica",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 89
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 56,
      "ContactName": "Lueilwitz-Swift",
      "PersonId": 135,
      "PersonName": "Grady-Mueller",
      "AssociateId": 3,
      "Address": "et",
      "EmailId": 756,
      "DuplicatePersonIds": [
        832,
        204
      ],
      "Name": "Kulas-Jones",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 63
        }
      }
    }
  ],
  "Subject": "alias",
  "HTMLBody": "nisi",
  "From": null,
  "Sent": "2010-10-07T23:03:55.9776288+02:00",
  "Size": 783,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "nobis",
  "PlainBody": "dolores",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 895,
  "Attachments": [
    {
      "Description": "Expanded reciprocal Graphic Interface",
      "Filename": "ut",
      "Size": 556,
      "Type": "deserunt",
      "Encoding": "autem",
      "Id": "temporibus",
      "Disposition": "facilis",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 528
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Kessler, Hickle and Huels",
      "Values": [
        "nam",
        "occaecati"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    },
    {
      "Name": "Kessler, Hickle and Huels",
      "Values": [
        "nam",
        "occaecati"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "FolderName": "O'Keefe, Gleason and Weimann",
  "EmailItemId": 732,
  "AccountId": 1000,
  "ReceivedAt": "2004-11-13T23:03:55.9781289+01:00",
  "InReplyTo": null,
  "RepliedAt": "2003-06-08T23:03:55.9781289+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 410
    }
  }
}
```