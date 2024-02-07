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
Accept-Language: sv
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
      "ContactId": 714,
      "ContactName": "Marquardt-Reichel",
      "PersonId": 663,
      "PersonName": "Blick, Welch and Wyman",
      "AssociateId": 359,
      "Address": "omnis",
      "EmailId": 372,
      "DuplicatePersonIds": [
        692,
        219
      ],
      "Name": "Jaskolski-Prosacco",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 394
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 813,
      "ContactName": "Greenholt-Blick",
      "PersonId": 144,
      "PersonName": "Jacobi, Nikolaus and Krajcik",
      "AssociateId": 157,
      "Address": "ut",
      "EmailId": 913,
      "DuplicatePersonIds": [
        467,
        358
      ],
      "Name": "Mertz Inc and Sons",
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
  "Bcc": [
    {
      "ContactId": 783,
      "ContactName": "Schimmel-Jenkins",
      "PersonId": 70,
      "PersonName": "Okuneva Group",
      "AssociateId": 844,
      "Address": "iusto",
      "EmailId": 399,
      "DuplicatePersonIds": [
        264,
        87
      ],
      "Name": "Adams-Schumm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    }
  ],
  "Subject": "culpa",
  "HTMLBody": "recusandae",
  "From": null,
  "Sent": "2000-06-16T16:54:55.3709476+02:00",
  "Size": 556,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "exercitationem",
  "PlainBody": "id",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 331,
  "Attachments": [
    {
      "Description": "Multi-tiered tangible interface",
      "Filename": "reiciendis",
      "Size": 147,
      "Type": "doloremque",
      "Encoding": "quia",
      "Id": "voluptate",
      "Disposition": "blanditiis",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 56
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Schuppe-Dare",
      "Values": [
        "est",
        "deserunt"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 35
        }
      }
    },
    {
      "Name": "Schuppe-Dare",
      "Values": [
        "est",
        "deserunt"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 35
        }
      }
    }
  ],
  "FolderName": "Langworth, Jaskolski and Nikolaus",
  "EmailItemId": 944,
  "AccountId": 486,
  "ReceivedAt": "1997-08-15T16:54:55.3719479+02:00",
  "InReplyTo": null,
  "RepliedAt": "2021-03-02T16:54:55.3719479+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 830
    }
  }
}
```