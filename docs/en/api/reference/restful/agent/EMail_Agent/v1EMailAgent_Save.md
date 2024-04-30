---
title: POST Agents/EMail/Save
uid: v1EMailAgent_Save
generated: true
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
      "ContactId": 376,
      "ContactName": "Considine, Gleichner and Wintheiser",
      "PersonId": 698,
      "PersonName": "Turcotte Group",
      "AssociateId": 489,
      "Address": "nemo",
      "EmailId": 273,
      "DuplicatePersonIds": [
        745,
        227
      ],
      "Name": "Friesen Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 698
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 107,
      "ContactName": "Gutmann-Kunze",
      "PersonId": 436,
      "PersonName": "Schmeler Group",
      "AssociateId": 834,
      "Address": "perspiciatis",
      "EmailId": 178,
      "DuplicatePersonIds": [
        421,
        258
      ],
      "Name": "Bogisich, Rippin and Torphy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 88
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 177,
      "ContactName": "Goyette, Carroll and Olson",
      "PersonId": 571,
      "PersonName": "Heidenreich Inc and Sons",
      "AssociateId": 283,
      "Address": "et",
      "EmailId": 921,
      "DuplicatePersonIds": [
        739,
        150
      ],
      "Name": "Maggio-Anderson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 334
        }
      }
    }
  ],
  "Subject": "corrupti",
  "HTMLBody": "nihil",
  "From": null,
  "Sent": "2004-03-27T11:44:33.5722192+01:00",
  "Size": 789,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "velit",
  "PlainBody": "consequatur",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 491,
  "Attachments": [
    {
      "Description": "Implemented leading edge framework",
      "Filename": "iste",
      "Size": 408,
      "Type": "reiciendis",
      "Encoding": "sunt",
      "Id": "omnis",
      "Disposition": "expedita",
      "IsSafeFileExtension": true,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 998
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Kuhlman Group",
      "Values": [
        "impedit",
        "aut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    },
    {
      "Name": "Kuhlman Group",
      "Values": [
        "impedit",
        "aut"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 359
        }
      }
    }
  ],
  "FolderName": "Bahringer-Kuvalis",
  "EmailItemId": 388,
  "AccountId": 247,
  "ReceivedAt": "2000-12-19T11:44:33.5722192+01:00",
  "InReplyTo": null,
  "RepliedAt": "2022-09-28T11:44:33.5722192+02:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 929
    }
  }
}
```