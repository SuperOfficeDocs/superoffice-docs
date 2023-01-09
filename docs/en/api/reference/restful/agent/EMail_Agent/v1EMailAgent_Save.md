---
title: POST Agents/EMail/Save
uid: v1EMailAgent_Save
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
      "ContactId": 369,
      "ContactName": "O'Kon LLC",
      "PersonId": 667,
      "PersonName": "Nader Inc and Sons",
      "AssociateId": 932,
      "Address": "id",
      "EmailId": 770,
      "DuplicatePersonIds": [
        601,
        680
      ],
      "Name": "Medhurst-Boyle",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 226
        }
      }
    }
  ],
  "Cc": [
    {
      "ContactId": 168,
      "ContactName": "Altenwerth-Heller",
      "PersonId": 388,
      "PersonName": "Trantow Inc and Sons",
      "AssociateId": 322,
      "Address": "ea",
      "EmailId": 436,
      "DuplicatePersonIds": [
        543,
        23
      ],
      "Name": "Jones, Erdman and Waelchi",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 150
        }
      }
    }
  ],
  "Bcc": [
    {
      "ContactId": 757,
      "ContactName": "Weissnat Group",
      "PersonId": 394,
      "PersonName": "Senger-Feeney",
      "AssociateId": 861,
      "Address": "illum",
      "EmailId": 710,
      "DuplicatePersonIds": [
        58,
        716
      ],
      "Name": "Cassin-Rogahn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 21
        }
      }
    }
  ],
  "Subject": "ipsam",
  "HTMLBody": "sit",
  "From": null,
  "Sent": "1997-06-24T17:37:17.8512444+02:00",
  "Size": 631,
  "Priority": "High",
  "Flags": "Answered",
  "MessageID": "velit",
  "PlainBody": "non",
  "IsSent": false,
  "EMailSOInfo": null,
  "ServerId": 9,
  "Attachments": [
    {
      "Description": "Fundamental coherent array",
      "Filename": "aliquam",
      "Size": 3,
      "Type": "et",
      "Encoding": "omnis",
      "Id": "reiciendis",
      "Disposition": "sit",
      "Stream": "GIF89....File contents as raw bytes...",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    }
  ],
  "CustomHeaderList": [
    {
      "Name": "Nolan, Goodwin and Sipes",
      "Values": [
        "debitis",
        "atque"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 625
        }
      }
    },
    {
      "Name": "Nolan, Goodwin and Sipes",
      "Values": [
        "debitis",
        "atque"
      ],
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 625
        }
      }
    }
  ],
  "FolderName": "Sawayn, Strosin and Lind",
  "EmailItemId": 809,
  "AccountId": 410,
  "ReceivedAt": "2014-03-05T17:37:17.8512444+01:00",
  "InReplyTo": null,
  "RepliedAt": "2005-01-25T17:37:17.8522441+01:00",
  "HasCalendarData": true,
  "CalMethod": "Add",
  "CalReplyStatus": "Accepted",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 775
    }
  }
}
```