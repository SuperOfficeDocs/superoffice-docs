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
      "ContactId": 660,
      "ContactName": "Mohr-Casper",
      "PersonId": 738,
      "PersonName": "Larkin-Marks",
      "AssociateId": 54,
      "Address": "dolores",
      "EmailId": 451,
      "DuplicatePersonIds": [
        701,
        949
      ],
      "Name": "Cremin, Lakin and Shanahan",
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
  "Cc": [
    {
      "ContactId": 730,
      "ContactName": "Weber-Hintz",
      "PersonId": 324,
      "PersonName": "Kuhic, Orn and Jaskolski",
      "AssociateId": 875,
      "Address": "quae",
      "EmailId": 328,
      "DuplicatePersonIds": [
        242,
        153
      ],
      "Name": "Reynolds Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 882
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 620,
      "ContactName": "Schimmel-Turner",
      "PersonId": 607,
      "PersonName": "Sipes-Lind",
      "AssociateId": 29,
      "Address": "quasi",
      "EmailId": 120,
      "DuplicatePersonIds": [
        914,
        458
      ],
      "Name": "Bednar Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 615
        }
      }
    }
  ],
  "Subject": "omnis",
  "HTMLBody": "et",
  "From": null,
  "Sent": "2009-06-08T13:28:22.6323326+02:00",
  "Size": 703,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "dolorem",
  "PlainBody": "voluptate",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 932,
  "Attachments": [
    {
      "Description": "Polarised tangible orchestration",
      "Filename": "dignissimos",
      "Size": 160,
      "Type": "hic",
      "Encoding": "voluptatum",
      "Id": "nihil",
      "Disposition": "ut",
      "IsSafeFileExtension": false,
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 267
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Schamberger Group",
      "Values": [
        "autem",
        "voluptatem"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    },
    {
      "Name": "Schamberger Group",
      "Values": [
        "autem",
        "voluptatem"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    }
  ],
  "FolderName": "Kohler, Bernier and Keebler",
  "EmailItemId": 462,
  "AccountId": 231,
  "ReceivedAt": "2022-06-27T13:28:22.6323326+02:00",
  "InReplyTo": null,
  "RepliedAt": "2012-04-15T13:28:22.6323326+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 210
    }
  }
}
```