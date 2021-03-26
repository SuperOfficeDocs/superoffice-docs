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
  "ServerId": 442,
  "MessageId": "pariatur",
  "Subject": "sapiente",
  "From": {
    "ContactId": 408,
    "ContactName": "Kshlerin, Bogisich and Ferry",
    "PersonId": 945,
    "PersonName": "Torp Group",
    "AssociateId": 300,
    "Address": "illo",
    "EmailId": 403,
    "DuplicatePersonIds": [
      848,
      70
    ],
    "Name": "Howe Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 250
      }
    }
  },
  "To": [
    {
      "ContactId": 7,
      "ContactName": "Funk-Carter",
      "PersonId": 58,
      "PersonName": "Breitenberg-Gibson",
      "AssociateId": 767,
      "Address": "corporis",
      "EmailId": 101,
      "DuplicatePersonIds": [
        365,
        594
      ],
      "Name": "Cartwright-Fay",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 607
        }
      }
    }
  ],
  "Sent": "2012-09-26T16:48:29.5599244+02:00",
  "Priority": "High",
  "Flags": "Answered",
  "Size": 406,
  "EMailSOInfo": {
    "DocumentId": 127,
    "AppointmentId": 778,
    "ProjectId": 101,
    "SaleId": 55,
    "Archived": true,
    "ArchivedAt": "2012-02-15T16:48:29.5599244+01:00",
    "ArchivedBy": 74,
    "ArchivedDisplayName": "Crona, Skiles and Bayer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "e-enable plug-and-play users"
        },
        "FieldType": "System.String",
        "FieldLength": 534
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
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 861
    }
  }
}
```