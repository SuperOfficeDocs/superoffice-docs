---
title: POST Agents/EMail/GetEMailFromId
uid: v1EMailAgent_GetEMailFromId
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetEMailFromId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": null,
  "MessageServerId": 550,
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
      "ContactId": 38,
      "ContactName": "Kiehn LLC",
      "PersonId": 672,
      "PersonName": "Crona, Rogahn and Yost",
      "AssociateId": 992,
      "Address": "veniam",
      "EmailId": 402,
      "DuplicatePersonIds": [
        571,
        395
      ],
      "Name": "Kemmer-Heidenreich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 358
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 201,
      "ContactName": "Quitzon-Nicolas",
      "PersonId": 58,
      "PersonName": "Turcotte-Koepp",
      "AssociateId": 567,
      "Address": "dolor",
      "EmailId": 540,
      "DuplicatePersonIds": [
        162,
        447
      ],
      "Name": "Bergstrom-Ferry",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 950,
      "ContactName": "Johnson-Reinger",
      "PersonId": 276,
      "PersonName": "Paucek LLC",
      "AssociateId": 466,
      "Address": "sed",
      "EmailId": 756,
      "DuplicatePersonIds": [
        541,
        721
      ],
      "Name": "Zemlak LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 145
        }
      }
    }
  ],
  "Subject": "sapiente",
  "HTMLBody": "voluptates",
  "From": null,
  "Sent": "2014-04-23T13:13:23.0396028+02:00",
  "Size": 41,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "reiciendis",
  "PlainBody": "id",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 230,
  "Attachments": [
    {
      "Description": "Business-focused fault-tolerant instruction set",
      "Filename": "aut",
      "Size": 585,
      "Type": "odit",
      "Encoding": "repudiandae",
      "Id": "atque",
      "Disposition": "delectus",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 969
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Trantow Group",
      "Values": [
        "possimus",
        "cumque"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 217
        }
      }
    },
    {
      "Name": "Trantow Group",
      "Values": [
        "possimus",
        "cumque"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 217
        }
      }
    }
  ],
  "FolderName": "Zboncak, Moen and Wiegand",
  "EmailItemId": 452,
  "AccountId": 687,
  "ReceivedAt": "2021-10-30T13:13:23.0396028+02:00",
  "InReplyTo": null,
  "RepliedAt": "2011-08-19T13:13:23.0396028+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 183
    }
  }
}
```