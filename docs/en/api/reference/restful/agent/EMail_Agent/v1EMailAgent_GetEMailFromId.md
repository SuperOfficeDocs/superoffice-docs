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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ConnectionInfo": null,
  "MessageServerId": 614,
  "LookupAddresses": false,
  "Flags": "Answered",
  "IncludeAttachments": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 121,
      "ContactName": "Hoeger LLC",
      "PersonId": 916,
      "PersonName": "Mosciski-Willms",
      "AssociateId": 142,
      "Address": "aut",
      "EmailId": 587,
      "DuplicatePersonIds": [
        652,
        595
      ],
      "Name": "Erdman, Ondricka and Hickle",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 831
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 458,
      "ContactName": "Kiehn-Schowalter",
      "PersonId": 195,
      "PersonName": "Leuschke-Toy",
      "AssociateId": 421,
      "Address": "distinctio",
      "EmailId": 37,
      "DuplicatePersonIds": [
        632,
        183
      ],
      "Name": "Gottlieb, Boyer and Gaylord",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 173
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 631,
      "ContactName": "Christiansen, Bahringer and Luettgen",
      "PersonId": 547,
      "PersonName": "Conroy-Lehner",
      "AssociateId": 626,
      "Address": "voluptatibus",
      "EmailId": 948,
      "DuplicatePersonIds": [
        501,
        838
      ],
      "Name": "Von, Runte and Schiller",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 942
        }
      }
    }
  ],
  "Subject": "autem",
  "HTMLBody": "quia",
  "From": null,
  "Sent": "2013-07-17T16:54:55.3659474+02:00",
  "Size": 356,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "dolorem",
  "PlainBody": "et",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 566,
  "Attachments": [
    {
      "Description": "Integrated next generation frame",
      "Filename": "rem",
      "Size": 62,
      "Type": "placeat",
      "Encoding": "tenetur",
      "Id": "iusto",
      "Disposition": "blanditiis",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 87
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Casper Inc and Sons",
      "Values": [
        "ab",
        "deleniti"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 463
        }
      }
    },
    {
      "Name": "Casper Inc and Sons",
      "Values": [
        "ab",
        "deleniti"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 463
        }
      }
    }
  ],
  "FolderName": "Jones, Erdman and Lemke",
  "EmailItemId": 919,
  "AccountId": 735,
  "ReceivedAt": "2000-02-21T16:54:55.3659474+01:00",
  "InReplyTo": null,
  "RepliedAt": "2020-05-27T16:54:55.3659474+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 339
    }
  }
}
```