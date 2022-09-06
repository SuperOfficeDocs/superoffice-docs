---
title: POST Agents/EMail/CreateForwardEmail
uid: v1EMailAgent_CreateForwardEmail
---

# POST Agents/EMail/CreateForwardEmail

```http
POST /api/v1/Agents/EMail/CreateForwardEmail
```

Create forward email

## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/CreateForwardEmail?$select=name,department,category/id
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
| Email |  | All information about an e-mail <para /> Carrier object for EMailEntity. Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| To | array | To recipients of e-mail |
| Cc | array | Cc recipients of e-mail |
| Bcc | array | Bcc recipient of e-mail |
| Subject | string | Subject of the e-mail |
| HTMLBody | string | Body formatted in HTML |
| From |  | Who did the e-mail originate from |
| Sent | date-time | When was the e-mail sent |
| Size | int32 | Total size of the e-mail |
| Priority | string | Importance of the e-mail |
| Flags | string | Flag status of this mail (unread, replied, deleted ) |
| MessageID | string | Unique id of e-mails |
| PlainBody | string | Body formatted in plain text |
| IsSent | bool | Is this a sent e-mail (not new) |
| EMailSOInfo |  | Glue between SuperOffice data and an e-mail. |
| ServerId | int32 | Unique id for the e-mail on the server |
| Attachments | array |  |
| CustomHeaderList | array | Non standard e-mail headers |
| FolderName | string | Name of folder the e-mail belongs in |
| EmailItemId | int32 | Primary key |
| AccountId | int32 | Account Id |
| ReceivedAt | date-time | Received date time |
| InReplyTo |  | The envelope of the email this email is a reply to, if it exists |
| RepliedAt | date-time | When this email was replied at |
| HasCalendarData | bool | If this email contains exactly one iCal appointment |
| CalMethod | string | Method stored in the associated iCal appointment. Indicates if the iCal data is a reply, counter proposal etc. |
| CalReplyStatus | string | Reply status stored in calendar data for the ical method is REPLY |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/EMail/CreateForwardEmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
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
      "ContactId": 169,
      "ContactName": "Rutherford-Walsh",
      "PersonId": 230,
      "PersonName": "Kunze Inc and Sons",
      "AssociateId": 323,
      "Address": "beatae",
      "EmailId": 682,
      "DuplicatePersonIds": [
        841,
        956
      ],
      "Name": "Rodriguez, Daugherty and Ferry",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 152
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 458,
      "ContactName": "Boyle Group",
      "PersonId": 455,
      "PersonName": "Jewess LLC",
      "AssociateId": 832,
      "Address": "temporibus",
      "EmailId": 792,
      "DuplicatePersonIds": [
        949,
        332
      ],
      "Name": "Goodwin-Witting",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 234,
      "ContactName": "Bednar, Wehner and Bernhard",
      "PersonId": 83,
      "PersonName": "Gusikowski-Greenholt",
      "AssociateId": 320,
      "Address": "vel",
      "EmailId": 161,
      "DuplicatePersonIds": [
        132,
        507
      ],
      "Name": "Williamson-Treutel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 287
        }
      }
    }
  ],
  "Subject": "sunt",
  "HTMLBody": "dolores",
  "From": null,
  "Sent": "2021-05-28T11:10:26.8484526+02:00",
  "Size": 241,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "ut",
  "PlainBody": "distinctio",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 480,
  "Attachments": [
    {
      "Description": "Phased needs-based flexibility",
      "Filename": "voluptas",
      "Size": 245,
      "Type": "veniam",
      "Encoding": "dolore",
      "Id": "quaerat",
      "Disposition": "officia",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Predovic-Mueller",
      "Values": [
        "ullam",
        "est"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 271
        }
      }
    },
    {
      "Name": "Predovic-Mueller",
      "Values": [
        "ullam",
        "est"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 271
        }
      }
    }
  ],
  "FolderName": "Wolf Inc and Sons",
  "EmailItemId": 633,
  "AccountId": 449,
  "ReceivedAt": "2010-01-14T11:10:26.8484526+01:00",
  "InReplyTo": null,
  "RepliedAt": "2018-10-17T11:10:26.8484526+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 738
    }
  }
}
```
