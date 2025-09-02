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
Accept-Language: fr,de,ru,zh
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
      "ContactId": 5,
      "ContactName": "Smitham, Gutmann and Boyle",
      "PersonId": 837,
      "PersonName": "Hoppe Inc and Sons",
      "AssociateId": 977,
      "Address": "voluptatum",
      "EmailId": 325,
      "DuplicatePersonIds": [
        898,
        632
      ],
      "Name": "Haag Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 65
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 294,
      "ContactName": "Lesch-Braun",
      "PersonId": 325,
      "PersonName": "Abshire, Schaden and Brown",
      "AssociateId": 927,
      "Address": "ducimus",
      "EmailId": 418,
      "DuplicatePersonIds": [
        48,
        61
      ],
      "Name": "Kautzer-Ferry",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 733
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 73,
      "ContactName": "Macejkovic, Cronin and Will",
      "PersonId": 242,
      "PersonName": "Feil, Kunde and Reinger",
      "AssociateId": 563,
      "Address": "dolorem",
      "EmailId": 654,
      "DuplicatePersonIds": [
        941,
        638
      ],
      "Name": "Botsford Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    }
  ],
  "Subject": "sint",
  "HTMLBody": "et",
  "From": null,
  "Sent": "2008-04-04T03:46:54.8007556+02:00",
  "Size": 722,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "et",
  "PlainBody": "voluptate",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 678,
  "Attachments": [
    {
      "Description": "Stand-alone discrete initiative",
      "Filename": "provident",
      "Size": 907,
      "Type": "ex",
      "Encoding": "vel",
      "Id": "ut",
      "Disposition": "non",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 42
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hoeger-Daniel",
      "Values": [
        "autem",
        "et"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 79
        }
      }
    },
    {
      "Name": "Hoeger-Daniel",
      "Values": [
        "autem",
        "et"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 79
        }
      }
    }
  ],
  "FolderName": "Marks LLC",
  "EmailItemId": 242,
  "AccountId": 354,
  "ReceivedAt": "2007-09-25T03:46:54.8007556+02:00",
  "InReplyTo": null,
  "RepliedAt": "2023-12-05T03:46:54.8007556+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 14
    }
  }
}
```