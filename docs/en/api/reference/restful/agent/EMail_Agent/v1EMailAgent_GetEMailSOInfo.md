---
title: POST Agents/EMail/GetEMailSOInfo
uid: v1EMailAgent_GetEMailSOInfo
generated: true
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
POST /api/v1/Agents/EMail/GetEMailSOInfo?eMailSOInfoId=639
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: EMailSOInfo

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/EMail/GetEMailSOInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DocumentId": 413,
  "AppointmentId": 904,
  "ProjectId": 955,
  "SaleId": 805,
  "Archived": true,
  "ArchivedAt": "2015-07-07T13:38:13.5458695+02:00",
  "ArchivedBy": 749,
  "ArchivedDisplayName": "Hayes-Harris",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 65
    }
  }
}
```