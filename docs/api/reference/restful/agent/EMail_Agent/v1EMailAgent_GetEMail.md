---
title: POST Agents/EMail/GetEMail
uid: v1EMailAgent_GetEMail
---

# POST Agents/EMail/GetEMail

```http
POST /api/v1/Agents/EMail/GetEMail
```

Get en e-mail based on its primary key in the DB




## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMail?$select=name,department,category/id
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

Id, IncludeAttachments 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 |  |
| IncludeAttachments | bool |  |


## Response: 

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
POST /api/v1/Agents/EMail/GetEMail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Id": 218,
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
      "ContactId": 129,
      "ContactName": "Wehner Group",
      "PersonId": 651,
      "PersonName": "Larson-Marks",
      "AssociateId": 918,
      "Address": "sequi",
      "EmailId": 473,
      "DuplicatePersonIds": [
        482,
        493
      ],
      "Name": "Rohan, Mohr and Cormier",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 983
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 73,
      "ContactName": "D'Amore-Runte",
      "PersonId": 111,
      "PersonName": "Nader, Lakin and Wuckert",
      "AssociateId": 149,
      "Address": "officia",
      "EmailId": 489,
      "DuplicatePersonIds": [
        255,
        335
      ],
      "Name": "Hirthe Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 221
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 780,
      "ContactName": "Zulauf, Olson and Hilpert",
      "PersonId": 380,
      "PersonName": "Sanford, Kuhlman and Hettinger",
      "AssociateId": 498,
      "Address": "nobis",
      "EmailId": 209,
      "DuplicatePersonIds": [
        141,
        442
      ],
      "Name": "Reynolds Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "Subject": "unde",
  "HTMLBody": "reprehenderit",
  "From": null,
  "Sent": "2012-08-18T11:10:26.9784523+02:00",
  "Size": 880,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "architecto",
  "PlainBody": "voluptatem",
  "IsSent": true,
  "EMailSOInfo": null,
  "ServerId": 757,
  "Attachments": [
    {
      "Description": "Intuitive neutral architecture",
      "Filename": "et",
      "Size": 17,
      "Type": "tempore",
      "Encoding": "et",
      "Id": "eos",
      "Disposition": "quasi",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 796
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Casper, Abshire and Kessler",
      "Values": [
        "itaque",
        "voluptatem"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 311
        }
      }
    },
    {
      "Name": "Casper, Abshire and Kessler",
      "Values": [
        "itaque",
        "voluptatem"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 311
        }
      }
    }
  ],
  "FolderName": "Sawayn Group",
  "EmailItemId": 274,
  "AccountId": 516,
  "ReceivedAt": "2010-11-12T11:10:26.9784523+01:00",
  "InReplyTo": null,
  "RepliedAt": "2013-03-02T11:10:26.9784523+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 108
    }
  }
}
```