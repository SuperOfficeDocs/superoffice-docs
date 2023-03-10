---
title: POST Agents/EMail/SaveDraft
uid: v1EMailAgent_SaveDraft
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/SaveDraft
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
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
      "ContactId": 44,
      "ContactName": "Kilback-Mayert",
      "PersonId": 655,
      "PersonName": "Toy, Stracke and Mosciski",
      "AssociateId": 485,
      "Address": "aut",
      "EmailId": 598,
      "DuplicatePersonIds": [
        228,
        732
      ],
      "Name": "Stracke, Dicki and Denesik",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 747
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 142,
      "ContactName": "Hayes Group",
      "PersonId": 778,
      "PersonName": "Cummings, Reichel and O'Keefe",
      "AssociateId": 976,
      "Address": "assumenda",
      "EmailId": 352,
      "DuplicatePersonIds": [
        804,
        363
      ],
      "Name": "Friesen-Koelpin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 534
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 389,
      "ContactName": "Gibson LLC",
      "PersonId": 802,
      "PersonName": "Torp-Mertz",
      "AssociateId": 980,
      "Address": "perferendis",
      "EmailId": 121,
      "DuplicatePersonIds": [
        946,
        122
      ],
      "Name": "Jast-Murphy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 832
        }
      }
    }
  ],
  "Subject": "autem",
  "HTMLBody": "ipsa",
  "From": null,
  "Sent": "2011-10-11T12:15:18.9367522+02:00",
  "Size": 786,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "sint",
  "PlainBody": "facilis",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 217,
  "Attachments": [
    {
      "Description": "Configurable tertiary emulation",
      "Filename": "neque",
      "Size": 731,
      "Type": "autem",
      "Encoding": "incidunt",
      "Id": "voluptates",
      "Disposition": "nisi",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 147
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Konopelski Group",
      "Values": [
        "harum",
        "pariatur"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 95
        }
      }
    },
    {
      "Name": "Konopelski Group",
      "Values": [
        "harum",
        "pariatur"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 95
        }
      }
    }
  ],
  "FolderName": "Donnelly, Schumm and Funk",
  "EmailItemId": 360,
  "AccountId": 580,
  "ReceivedAt": "2001-02-04T12:15:18.9377527+01:00",
  "InReplyTo": null,
  "RepliedAt": "2007-09-10T12:15:18.9377527+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 435
    }
  }
}
```