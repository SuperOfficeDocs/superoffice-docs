---
title: CreateDefaultEMailSOInfo
id: v1EMailAgent_CreateDefaultEMailSOInfo
---

# CreateDefaultEMailSOInfo

```http
POST /api/v1/Agents/EMail/CreateDefaultEMailSOInfo
```

Set default values into a new EMailSOInfo.

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

Glue between SuperOffice data and an e-mail.



Carrier object for EMailSOInfo.
Services for the EMailSOInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DocumentId | int32 | Primary key |
| AppointmentId | int32 | Primary key |
| ProjectId | int32 | Primary key |
| SaleId | int32 | Primary key |
| Archived | bool | Is this e-mail archived in SuperOffice |
| ArchivedAt | date-time | The datetime when this email was archived |
| ArchivedBy | int32 | The associate who archived this email |
| ArchivedDisplayName | string | The full name of the associate who archived this email |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/EMail/CreateDefaultEMailSOInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 14,
  "AppointmentId": 546,
  "ProjectId": 273,
  "SaleId": 94,
  "Archived": false,
  "ArchivedAt": "2015-12-10T14:58:04.1794601+01:00",
  "ArchivedBy": 214,
  "ArchivedDisplayName": "Hahn LLC",
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
      "FieldLength": 935
    }
  }
}
```