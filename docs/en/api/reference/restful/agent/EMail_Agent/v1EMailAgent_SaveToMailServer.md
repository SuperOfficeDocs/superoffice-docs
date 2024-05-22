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
      "ContactId": 654,
      "ContactName": "Kuhn-Moen",
      "PersonId": 45,
      "PersonName": "O'Connell-Schiller",
      "AssociateId": 953,
      "Address": "sed",
      "EmailId": 367,
      "DuplicatePersonIds": [
        500,
        306
      ],
      "Name": "Runolfsson-Wehner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 619
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 426,
      "ContactName": "Fritsch-O'Kon",
      "PersonId": 392,
      "PersonName": "Sporer, Nader and Hirthe",
      "AssociateId": 794,
      "Address": "sequi",
      "EmailId": 816,
      "DuplicatePersonIds": [
        179,
        967
      ],
      "Name": "Purdy Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 320
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 615,
      "ContactName": "Deckow Group",
      "PersonId": 935,
      "PersonName": "Goyette Inc and Sons",
      "AssociateId": 386,
      "Address": "asperiores",
      "EmailId": 500,
      "DuplicatePersonIds": [
        406,
        320
      ],
      "Name": "Lakin-Cummings",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 390
        }
      }
    }
  ],
  "Subject": "minus",
  "HTMLBody": "repellendus",
  "From": null,
  "Sent": "2004-06-04T12:57:33.8523907+02:00",
  "Size": 42,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "voluptatum",
  "PlainBody": "accusamus",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 598,
  "Attachments": [
    {
      "Description": "Programmable human-resource function",
      "Filename": "facere",
      "Size": 597,
      "Type": "assumenda",
      "Encoding": "voluptatibus",
      "Id": "sed",
      "Disposition": "qui",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 631
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Price-Leannon",
      "Values": [
        "doloremque",
        "iure"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 780
        }
      }
    },
    {
      "Name": "Price-Leannon",
      "Values": [
        "doloremque",
        "iure"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 780
        }
      }
    }
  ],
  "FolderName": "Champlin-Glover",
  "EmailItemId": 818,
  "AccountId": 738,
  "ReceivedAt": "2016-06-01T12:57:33.8523907+02:00",
  "InReplyTo": null,
  "RepliedAt": "1998-03-22T12:57:33.8523907+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 567
    }
  }
}
```