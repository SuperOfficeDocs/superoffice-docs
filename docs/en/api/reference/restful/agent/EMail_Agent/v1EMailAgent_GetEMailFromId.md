---
title: POST Agents/EMail/GetEMailFromId
uid: v1EMailAgent_GetEMailFromId
---

# POST Agents/EMail/GetEMailFromId

```http
POST /api/v1/Agents/EMail/GetEMailFromId
```

Get en e-mail based on its unique id


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromId?$select=name,department,category/id
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

ConnectionInfo, MessageServerId, LookupAddresses, Flags, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ConnectionInfo | EMailConnectionInfo | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| MessageServerId | Integer |  |
| LookupAddresses | Boolean |  |
| Flags | String |  |
| IncludeAttachments | Boolean |  |

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
POST /api/v1/Agents/EMail/GetEMailFromId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": null,
  "MessageServerId": 864,
  "LookupAddresses": false,
  "Flags": "Answered",
  "IncludeAttachments": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 234,
      "ContactName": "Ankunding LLC",
      "PersonId": 45,
      "PersonName": "Stoltenberg LLC",
      "AssociateId": 646,
      "Address": "dolorum",
      "EmailId": 556,
      "DuplicatePersonIds": [
        97,
        400
      ],
      "Name": "O'Keefe-Morar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 946
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 161,
      "ContactName": "Schroeder, Goodwin and Raynor",
      "PersonId": 458,
      "PersonName": "Ullrich-Walter",
      "AssociateId": 745,
      "Address": "est",
      "EmailId": 600,
      "DuplicatePersonIds": [
        455,
        345
      ],
      "Name": "Rath, Kutch and Durgan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 728
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 460,
      "ContactName": "Harris, Pfannerstill and Gutmann",
      "PersonId": 370,
      "PersonName": "Bernier Group",
      "AssociateId": 42,
      "Address": "odio",
      "EmailId": 304,
      "DuplicatePersonIds": [
        522,
        903
      ],
      "Name": "Daniel, Howe and Prosacco",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 204
        }
      }
    }
  ],
  "Subject": "soluta",
  "HTMLBody": "autem",
  "From": null,
  "Sent": "2018-03-02T17:37:17.9462408+01:00",
  "Size": 743,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "explicabo",
  "PlainBody": "porro",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 628,
  "Attachments": [
    {
      "Description": "Exclusive discrete capacity",
      "Filename": "ipsum",
      "Size": 843,
      "Type": "dolor",
      "Encoding": "possimus",
      "Id": "in",
      "Disposition": "magnam",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 851
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Vandervort, Gleason and Nitzsche",
      "Values": [
        "debitis",
        "aspernatur"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 30
        }
      }
    },
    {
      "Name": "Vandervort, Gleason and Nitzsche",
      "Values": [
        "debitis",
        "aspernatur"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 30
        }
      }
    }
  ],
  "FolderName": "Corwin LLC",
  "EmailItemId": 60,
  "AccountId": 745,
  "ReceivedAt": "1999-01-31T17:37:17.9462408+01:00",
  "InReplyTo": null,
  "RepliedAt": "2022-11-27T17:37:17.9462408+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 338
    }
  }
}
```