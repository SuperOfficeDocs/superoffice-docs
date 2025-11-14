---
title: POST Agents/EMail/Save
uid: v1EMailAgent_Save
generated: true
content_type: reference
---

# POST Agents/EMail/Save

```http
POST /api/v1/Agents/EMail/Save
```

Save the e-mail back to the database


NsApiSlow threshold: 5000 ms.


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
| Email | EMailEntity | All information about an e-mail <para /> Carrier object for EMailEntity. Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |

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
POST /api/v1/Agents/EMail/Save
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Email": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 284,
      "ContactName": "Langworth, Botsford and Bogan",
      "PersonId": 328,
      "PersonName": "O'Kon, Stark and Abernathy",
      "AssociateId": 283,
      "Address": "deserunt",
      "EmailId": 526,
      "DuplicatePersonIds": [
        537,
        687
      ],
      "Name": "Bosco LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 773
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 801,
      "ContactName": "Walker-Ziemann",
      "PersonId": 601,
      "PersonName": "Wintheiser-Schmeler",
      "AssociateId": 894,
      "Address": "atque",
      "EmailId": 71,
      "DuplicatePersonIds": [
        671,
        86
      ],
      "Name": "Bahringer-Schuppe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 557,
      "ContactName": "Mraz, Huel and Heathcote",
      "PersonId": 36,
      "PersonName": "Williamson, Bins and Bruen",
      "AssociateId": 563,
      "Address": "harum",
      "EmailId": 46,
      "DuplicatePersonIds": [
        379,
        876
      ],
      "Name": "Konopelski Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    }
  ],
  "Subject": "veritatis",
  "HTMLBody": "eum",
  "From": null,
  "Sent": "2013-06-17T02:30:47.3194579+02:00",
  "Size": 926,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "et",
  "PlainBody": "labore",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 648,
  "Attachments": [
    {
      "Description": "User-centric optimizing adapter",
      "Filename": "aut",
      "Size": 521,
      "Type": "quia",
      "Encoding": "cupiditate",
      "Id": "eveniet",
      "Disposition": "sint",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Krajcik Group",
      "Values": [
        "voluptates",
        "ut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 83
        }
      }
    },
    {
      "Name": "Krajcik Group",
      "Values": [
        "voluptates",
        "ut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 83
        }
      }
    }
  ],
  "FolderName": "Satterfield, Keeling and Cruickshank",
  "EmailItemId": 11,
  "AccountId": 199,
  "ReceivedAt": "1999-06-24T02:30:47.3194579+02:00",
  "InReplyTo": null,
  "RepliedAt": "2013-03-31T02:30:47.3194579+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 836
    }
  }
}
```