---
title: POST Agents/EMail/SaveEMail
uid: v1EMailAgent_SaveEMail
generated: true
---

# POST Agents/EMail/SaveEMail

```http
POST /api/v1/Agents/EMail/SaveEMail
```

Save the passed e-mail back to the server


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SaveEMail?$select=name,department,category/id
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

ConnectionInfo, Email 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectionInfo | EMailConnectionInfo | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
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
POST /api/v1/Agents/EMail/SaveEMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": null,
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
      "ContactId": 877,
      "ContactName": "Kessler Group",
      "PersonId": 762,
      "PersonName": "Kulas-Harber",
      "AssociateId": 238,
      "Address": "dolores",
      "EmailId": 971,
      "DuplicatePersonIds": [
        29,
        695
      ],
      "Name": "Blanda LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 397
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 440,
      "ContactName": "Kuphal, Littel and Rowe",
      "PersonId": 868,
      "PersonName": "Pollich-Nienow",
      "AssociateId": 195,
      "Address": "accusamus",
      "EmailId": 756,
      "DuplicatePersonIds": [
        254,
        665
      ],
      "Name": "Ruecker LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 979
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 879,
      "ContactName": "Green-Reinger",
      "PersonId": 849,
      "PersonName": "McKenzie, Mertz and Quigley",
      "AssociateId": 691,
      "Address": "quia",
      "EmailId": 226,
      "DuplicatePersonIds": [
        24,
        68
      ],
      "Name": "Hermiston, Schowalter and Labadie",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 479
        }
      }
    }
  ],
  "Subject": "esse",
  "HTMLBody": "accusamus",
  "From": null,
  "Sent": "2016-05-17T10:17:55.5977887+02:00",
  "Size": 650,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "nam",
  "PlainBody": "architecto",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 175,
  "Attachments": [
    {
      "Description": "Cloned real-time data-warehouse",
      "Filename": "architecto",
      "Size": 702,
      "Type": "perferendis",
      "Encoding": "sit",
      "Id": "officia",
      "Disposition": "consequatur",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 472
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Schuster LLC",
      "Values": [
        "eveniet",
        "rerum"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
        }
      }
    },
    {
      "Name": "Schuster LLC",
      "Values": [
        "eveniet",
        "rerum"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 637
        }
      }
    }
  ],
  "FolderName": "Haley LLC",
  "EmailItemId": 647,
  "AccountId": 8,
  "ReceivedAt": "1999-01-21T10:17:55.5977887+01:00",
  "InReplyTo": null,
  "RepliedAt": "2024-03-14T10:17:55.5977887+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 488
    }
  }
}
```