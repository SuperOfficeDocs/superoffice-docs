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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

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
      "ContactId": 304,
      "ContactName": "Welch Inc and Sons",
      "PersonId": 718,
      "PersonName": "Jakubowski-Gaylord",
      "AssociateId": 300,
      "Address": "accusantium",
      "EmailId": 937,
      "DuplicatePersonIds": [
        946,
        377
      ],
      "Name": "Carroll, Collier and Goyette",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 952
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 762,
      "ContactName": "Mante Inc and Sons",
      "PersonId": 731,
      "PersonName": "Kutch, Zieme and Hirthe",
      "AssociateId": 657,
      "Address": "porro",
      "EmailId": 383,
      "DuplicatePersonIds": [
        865,
        305
      ],
      "Name": "Langosh LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 230
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 193,
      "ContactName": "Hirthe, Jacobi and Schaden",
      "PersonId": 87,
      "PersonName": "Beahan LLC",
      "AssociateId": 659,
      "Address": "amet",
      "EmailId": 207,
      "DuplicatePersonIds": [
        206,
        818
      ],
      "Name": "Stamm Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 387
        }
      }
    }
  ],
  "Subject": "magnam",
  "HTMLBody": "ut",
  "From": null,
  "Sent": "2010-07-14T15:29:21.7047772+02:00",
  "Size": 159,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "repudiandae",
  "PlainBody": "eaque",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 884,
  "Attachments": [
    {
      "Description": "Fully-configurable disintermediate access",
      "Filename": "porro",
      "Size": 161,
      "Type": "velit",
      "Encoding": "ut",
      "Id": "et",
      "Disposition": "optio",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 987
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Buckridge, Becker and Wyman",
      "Values": [
        "incidunt",
        "commodi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 561
        }
      }
    },
    {
      "Name": "Buckridge, Becker and Wyman",
      "Values": [
        "incidunt",
        "commodi"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 561
        }
      }
    }
  ],
  "FolderName": "Nikolaus LLC",
  "EmailItemId": 455,
  "AccountId": 990,
  "ReceivedAt": "2003-01-08T15:29:21.7062771+01:00",
  "InReplyTo": null,
  "RepliedAt": "2004-06-01T15:29:21.7062771+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 477
    }
  }
}
```