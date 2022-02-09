---
title: POST Agents/EMail/CreateDefaultEMailEnvelope
id: v1EMailAgent_CreateDefaultEMailEnvelope
---

# POST Agents/EMail/CreateDefaultEMailEnvelope

```http
POST /api/v1/Agents/EMail/CreateDefaultEMailEnvelope
```

Set default values into a new EMailEnvelope.

NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Limited information about one e-mail.



Carrier object for EMailEnvelope.
Services for the EMailEnvelope Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ServerId | int32 | Unique id for the e-mail on the server |
| MessageId | string | Unique id of e-mails |
| Subject | string | Subject of the e-mail |
| From |  | Who did the e-mail originate from |
| To | array | To recipients of e-mail |
| Sent | date-time | When was the e-mail sent |
| Priority | string | Importance of the e-mail |
| Flags | string | Flag status of this mail (unread, replied, deleted ) |
| Size | int32 | Total size of the e-mail |
| EMailSOInfo |  | Glue between SuperOffice data and an e-mail. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/CreateDefaultEMailEnvelope
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ServerId": 732,
  "MessageId": "officiis",
  "Subject": "ut",
  "From": {
    "ContactId": 641,
    "ContactName": "Price-Ebert",
    "PersonId": 579,
    "PersonName": "Schultz, Beatty and Lesch",
    "AssociateId": 177,
    "Address": "cupiditate",
    "EmailId": 805,
    "DuplicatePersonIds": [
      67,
      368
    ],
    "Name": "Konopelski-Jacobson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 622
      }
    }
  },
  "To": [
    {
      "ContactId": 553,
      "ContactName": "Zemlak Inc and Sons",
      "PersonId": 10,
      "PersonName": "Towne Inc and Sons",
      "AssociateId": 426,
      "Address": "quaerat",
      "EmailId": 891,
      "DuplicatePersonIds": [
        165,
        10
      ],
      "Name": "Green, Hagenes and Mann",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 493
        }
      }
    }
  ],
  "Sent": "2002-02-16T18:28:49.087957+01:00",
  "Priority": "High",
  "Flags": "Answered",
  "Size": 739,
  "EMailSOInfo": {
    "DocumentId": 936,
    "AppointmentId": 860,
    "ProjectId": 262,
    "SaleId": 957,
    "Archived": true,
    "ArchivedAt": "2008-09-08T18:28:49.087957+02:00",
    "ArchivedBy": 155,
    "ArchivedDisplayName": "Swaniawski LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 610
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "incentivize ubiquitous e-business"
      },
      "FieldType": "System.Int32",
      "FieldLength": 541
    }
  }
}
```