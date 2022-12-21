---
title: POST Agents/EMail/SaveDraft
uid: v1EMailAgent_SaveDraft
---

# POST Agents/EMail/SaveDraft

```http
POST /api/v1/Agents/EMail/SaveDraft
```

Save the Email entity to the drafts folder




## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/SaveDraft?$select=name,department,category/id
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

Entity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Entity |  | All information about an e-mail <para /> Carrier object for EMailEntity. Services for the EMailEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |


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
POST /api/v1/Agents/EMail/SaveDraft
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Entity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "To": [
    {
      "ContactId": 231,
      "ContactName": "Bartoletti-Reinger",
      "PersonId": 623,
      "PersonName": "Waters, Collins and Kilback",
      "AssociateId": 539,
      "Address": "incidunt",
      "EmailId": 527,
      "DuplicatePersonIds": [
        726,
        302
      ],
      "Name": "Kub, Koepp and Frami",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 632
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 153,
      "ContactName": "Carter, Haley and Willms",
      "PersonId": 493,
      "PersonName": "Zieme, Kunde and Lind",
      "AssociateId": 241,
      "Address": "neque",
      "EmailId": 745,
      "DuplicatePersonIds": [
        611,
        457
      ],
      "Name": "Hahn LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 694
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 513,
      "ContactName": "Kautzer Inc and Sons",
      "PersonId": 575,
      "PersonName": "Ritchie Inc and Sons",
      "AssociateId": 751,
      "Address": "et",
      "EmailId": 631,
      "DuplicatePersonIds": [
        397,
        406
      ],
      "Name": "Stark-Rohan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 787
        }
      }
    }
  ],
  "Subject": "et",
  "HTMLBody": "amet",
  "From": null,
  "Sent": "1996-04-28T02:49:44.3878864+02:00",
  "Size": 261,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "cum",
  "PlainBody": "perspiciatis",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 770,
  "Attachments": [
    {
      "Description": "User-centric composite standardization",
      "Filename": "magnam",
      "Size": 414,
      "Type": "nobis",
      "Encoding": "quia",
      "Id": "est",
      "Disposition": "exercitationem",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 142
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Douglas LLC",
      "Values": [
        "necessitatibus",
        "quis"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    },
    {
      "Name": "Douglas LLC",
      "Values": [
        "necessitatibus",
        "quis"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    }
  ],
  "FolderName": "Pouros-Dibbert",
  "EmailItemId": 269,
  "AccountId": 194,
  "ReceivedAt": "1998-06-04T02:49:44.3878864+02:00",
  "InReplyTo": null,
  "RepliedAt": "2003-09-22T02:49:44.3878864+02:00",
  "HasCalendarData": false,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 820
    }
  }
}
```