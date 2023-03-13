---
title: POST Agents/EMail/GetEMailFromDocumentId
uid: v1EMailAgent_GetEMailFromDocumentId
---

# POST Agents/EMail/GetEMailFromDocumentId

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentId
```

Get an e-mail based on an archived document


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailFromDocumentId?$select=name,department,category/id
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

DocumentId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | Integer |  |

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
POST /api/v1/Agents/EMail/GetEMailFromDocumentId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 906
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 451,
      "ContactName": "Howe Group",
      "PersonId": 151,
      "PersonName": "Hoppe Group",
      "AssociateId": 67,
      "Address": "et",
      "EmailId": 454,
      "DuplicatePersonIds": [
        453,
        606
      ],
      "Name": "Stokes LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 912
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 622,
      "ContactName": "Feeney, Yost and Witting",
      "PersonId": 564,
      "PersonName": "Schroeder-Nienow",
      "AssociateId": 111,
      "Address": "eum",
      "EmailId": 675,
      "DuplicatePersonIds": [
        997,
        836
      ],
      "Name": "Feeney-Nienow",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 725
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 464,
      "ContactName": "Stiedemann-Haag",
      "PersonId": 36,
      "PersonName": "Balistreri Inc and Sons",
      "AssociateId": 982,
      "Address": "repellendus",
      "EmailId": 45,
      "DuplicatePersonIds": [
        287,
        69
      ],
      "Name": "Cassin Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 946
        }
      }
    }
  ],
  "Subject": "corrupti",
  "HTMLBody": "officiis",
  "From": null,
  "Sent": "1996-05-03T14:19:03.466522+02:00",
  "Size": 11,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "et",
  "PlainBody": "consequatur",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 929,
  "Attachments": [
    {
      "Description": "Re-contextualized radical encryption",
      "Filename": "ut",
      "Size": 864,
      "Type": "dignissimos",
      "Encoding": "laboriosam",
      "Id": "laudantium",
      "Disposition": "aut",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 452
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Hills-Pfeffer",
      "Values": [
        "magnam",
        "error"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 563
        }
      }
    },
    {
      "Name": "Hills-Pfeffer",
      "Values": [
        "magnam",
        "error"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 563
        }
      }
    }
  ],
  "FolderName": "Schamberger, Jenkins and Armstrong",
  "EmailItemId": 809,
  "AccountId": 530,
  "ReceivedAt": "2009-03-25T14:19:03.466522+01:00",
  "InReplyTo": null,
  "RepliedAt": "2012-07-31T14:19:03.466522+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 453
    }
  }
}
```