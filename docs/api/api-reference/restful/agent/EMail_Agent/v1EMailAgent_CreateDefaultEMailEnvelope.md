---
title: CreateDefaultEMailEnvelope
id: v1EMailAgent_CreateDefaultEMailEnvelope
---

# CreateDefaultEMailEnvelope

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
  "ServerId": 162,
  "MessageId": "vel",
  "Subject": "itaque",
  "From": {
    "ContactId": 944,
    "ContactName": "Farrell Inc and Sons",
    "PersonId": 591,
    "PersonName": "Roberts, Muller and Ratke",
    "AssociateId": 424,
    "Address": "tenetur",
    "EmailId": 149,
    "DuplicatePersonIds": [
      436,
      641
    ],
    "Name": "Kohler LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 913
      }
    }
  },
  "To": [
    {
      "ContactId": 709,
      "ContactName": "McCullough Inc and Sons",
      "PersonId": 574,
      "PersonName": "Marvin Inc and Sons",
      "AssociateId": 645,
      "Address": "eos",
      "EmailId": 296,
      "DuplicatePersonIds": [
        380,
        928
      ],
      "Name": "Jaskolski-Hickle",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 978
        }
      }
    }
  ],
  "Sent": "2013-07-02T14:58:04.1794601+02:00",
  "Priority": "High",
  "Flags": "Answered",
  "Size": 459,
  "EMailSOInfo": {
    "DocumentId": 269,
    "AppointmentId": 798,
    "ProjectId": 474,
    "SaleId": 695,
    "Archived": false,
    "ArchivedAt": "2016-12-14T14:58:04.1794601+01:00",
    "ArchivedBy": 596,
    "ArchivedDisplayName": "Bartell-Johnston",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 315
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
      "FieldType": "System.String",
      "FieldLength": 816
    }
  }
}
```