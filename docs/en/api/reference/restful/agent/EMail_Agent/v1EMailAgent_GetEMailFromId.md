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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": null,
  "MessageServerId": 163,
  "LookupAddresses": true,
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
      "ContactId": 659,
      "ContactName": "Wuckert, Runolfsdottir and Streich",
      "PersonId": 37,
      "PersonName": "Green, Green and Morissette",
      "AssociateId": 935,
      "Address": "illum",
      "EmailId": 232,
      "DuplicatePersonIds": [
        542,
        770
      ],
      "Name": "Schmidt-Muller",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 876,
      "ContactName": "Smith-Schmeler",
      "PersonId": 474,
      "PersonName": "Murazik, Bailey and Ziemann",
      "AssociateId": 683,
      "Address": "ut",
      "EmailId": 101,
      "DuplicatePersonIds": [
        153,
        570
      ],
      "Name": "Hilpert-Schuster",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 858,
      "ContactName": "Hudson-McLaughlin",
      "PersonId": 140,
      "PersonName": "Quigley, Nienow and Borer",
      "AssociateId": 533,
      "Address": "quis",
      "EmailId": 286,
      "DuplicatePersonIds": [
        267,
        478
      ],
      "Name": "Harvey LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 747
        }
      }
    }
  ],
  "Subject": "accusantium",
  "HTMLBody": "maxime",
  "From": null,
  "Sent": "2012-02-16T14:23:46.6418272+01:00",
  "Size": 452,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "esse",
  "PlainBody": "sit",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 53,
  "Attachments": [
    {
      "Description": "Automated zero defect secured line",
      "Filename": "est",
      "Size": 401,
      "Type": "nihil",
      "Encoding": "et",
      "Id": "deleniti",
      "Disposition": "quo",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 250
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Schamberger, Rutherford and McLaughlin",
      "Values": [
        "ad",
        "asperiores"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 223
        }
      }
    },
    {
      "Name": "Schamberger, Rutherford and McLaughlin",
      "Values": [
        "ad",
        "asperiores"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 223
        }
      }
    }
  ],
  "FolderName": "Schoen-Raynor",
  "EmailItemId": 567,
  "AccountId": 284,
  "ReceivedAt": "2023-12-23T14:23:46.6418272+01:00",
  "InReplyTo": null,
  "RepliedAt": "2021-11-18T14:23:46.6418272+01:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 222
    }
  }
}
```