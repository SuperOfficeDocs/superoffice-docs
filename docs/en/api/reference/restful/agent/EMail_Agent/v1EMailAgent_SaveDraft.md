---
title: POST Agents/EMail/SaveDraft
uid: v1EMailAgent_SaveDraft
generated: true
---

# POST Agents/EMail/SaveDraft

```http
POST /api/v1/Agents/EMail/SaveDraft
```

Save the Email entity to the drafts folder


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SaveDraft?$select=name,department,category/id
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

Entity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Entity | EMailEntity | All information about an e-mail <para /> Carrier object for EMailEntity. Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |

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
POST /api/v1/Agents/EMail/SaveDraft
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Entity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 633,
      "ContactName": "Von, Schiller and Lemke",
      "PersonId": 755,
      "PersonName": "Corkery-Walter",
      "AssociateId": 735,
      "Address": "deserunt",
      "EmailId": 871,
      "DuplicatePersonIds": [
        104,
        84
      ],
      "Name": "Mann Group",
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
  "Cc": [
    {
      "ContactId": 924,
      "ContactName": "Leuschke Group",
      "PersonId": 68,
      "PersonName": "Braun, Purdy and Marvin",
      "AssociateId": 352,
      "Address": "ad",
      "EmailId": 163,
      "DuplicatePersonIds": [
        553,
        18
      ],
      "Name": "Rau-Hamill",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 283
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 852,
      "ContactName": "Wilkinson LLC",
      "PersonId": 816,
      "PersonName": "Becker-Bernier",
      "AssociateId": 302,
      "Address": "officia",
      "EmailId": 732,
      "DuplicatePersonIds": [
        766,
        569
      ],
      "Name": "Howell-Fisher",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 29
        }
      }
    }
  ],
  "Subject": "aut",
  "HTMLBody": "est",
  "From": null,
  "Sent": "2016-09-27T12:01:27.8065326+02:00",
  "Size": 78,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "voluptatem",
  "PlainBody": "est",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 376,
  "Attachments": [
    {
      "Description": "Self-enabling local knowledge user",
      "Filename": "in",
      "Size": 855,
      "Type": "molestias",
      "Encoding": "totam",
      "Id": "id",
      "Disposition": "suscipit",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 105
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Kautzer, Braun and Monahan",
      "Values": [
        "excepturi",
        "praesentium"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 892
        }
      }
    },
    {
      "Name": "Kautzer, Braun and Monahan",
      "Values": [
        "excepturi",
        "praesentium"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 892
        }
      }
    }
  ],
  "FolderName": "McDermott, Friesen and Lubowitz",
  "EmailItemId": 456,
  "AccountId": 308,
  "ReceivedAt": "2008-12-07T12:01:27.8065326+01:00",
  "InReplyTo": null,
  "RepliedAt": "2005-09-15T12:01:27.8065326+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 36
    }
  }
}
```