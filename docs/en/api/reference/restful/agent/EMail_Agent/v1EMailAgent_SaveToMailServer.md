---
title: POST Agents/EMail/SaveToMailServer
uid: v1EMailAgent_SaveToMailServer
generated: true
---

# POST Agents/EMail/SaveToMailServer

```http
POST /api/v1/Agents/EMail/SaveToMailServer
```

Save the passed e-mail back to the mail server


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SaveToMailServer?$select=name,department,category/id
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
POST /api/v1/Agents/EMail/SaveToMailServer
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
      "ContactId": 593,
      "ContactName": "Jenkins Inc and Sons",
      "PersonId": 177,
      "PersonName": "Farrell-Dooley",
      "AssociateId": 778,
      "Address": "dignissimos",
      "EmailId": 745,
      "DuplicatePersonIds": [
        797,
        751
      ],
      "Name": "Lynch-Gleason",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 765
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 969,
      "ContactName": "Abernathy, Bogisich and Cronin",
      "PersonId": 78,
      "PersonName": "Spencer, Sawayn and Price",
      "AssociateId": 860,
      "Address": "dolores",
      "EmailId": 238,
      "DuplicatePersonIds": [
        108,
        988
      ],
      "Name": "Spinka LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 786,
      "ContactName": "Mills Group",
      "PersonId": 132,
      "PersonName": "Gutkowski LLC",
      "AssociateId": 93,
      "Address": "facilis",
      "EmailId": 732,
      "DuplicatePersonIds": [
        87,
        38
      ],
      "Name": "Jacobi Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 295
        }
      }
    }
  ],
  "Subject": "quis",
  "HTMLBody": "fugiat",
  "From": null,
  "Sent": "2011-09-05T12:01:27.7752804+02:00",
  "Size": 710,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "corporis",
  "PlainBody": "cumque",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 426,
  "Attachments": [
    {
      "Description": "Optional tangible capacity",
      "Filename": "cumque",
      "Size": 958,
      "Type": "sed",
      "Encoding": "sed",
      "Id": "quo",
      "Disposition": "alias",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 782
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Tromp LLC",
      "Values": [
        "quo",
        "qui"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 55
        }
      }
    },
    {
      "Name": "Tromp LLC",
      "Values": [
        "quo",
        "qui"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 55
        }
      }
    }
  ],
  "FolderName": "Hamill, Daniel and Wilkinson",
  "EmailItemId": 88,
  "AccountId": 30,
  "ReceivedAt": "2015-01-03T12:01:27.7752804+01:00",
  "InReplyTo": null,
  "RepliedAt": "2004-07-10T12:01:27.7752804+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 622
    }
  }
}
```