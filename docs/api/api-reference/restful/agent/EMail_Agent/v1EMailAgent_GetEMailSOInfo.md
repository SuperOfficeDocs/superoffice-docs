---
title: POST Agents/EMail/GetEMailSOInfo
id: v1EMailAgent_GetEMailSOInfo
---

# POST Agents/EMail/GetEMailSOInfo

```http
POST /api/v1/Agents/EMail/GetEMailSOInfo
```

Gets a EMailSOInfo object.



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| eMailSOInfoId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/EMail/GetEMailSOInfo?eMailSOInfoId=983
POST /api/v1/Agents/EMail/GetEMailSOInfo?$select=name,department,category/id
```


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
POST /api/v1/Agents/EMail/GetEMailSOInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 243,
  "AppointmentId": 266,
  "ProjectId": 194,
  "SaleId": 99,
  "Archived": false,
  "ArchivedAt": "2020-09-10T16:48:29.548925+02:00",
  "ArchivedBy": 580,
  "ArchivedDisplayName": "Cassin, Armstrong and Sipes",
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
      "FieldLength": 841
    }
  }
}
```