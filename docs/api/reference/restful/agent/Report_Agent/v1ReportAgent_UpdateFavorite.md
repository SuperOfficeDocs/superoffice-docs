---
title: POST Agents/Report/UpdateFavorite
id: v1ReportAgent_UpdateFavorite
---

# POST Agents/Report/UpdateFavorite

```http
POST /api/v1/Agents/Report/UpdateFavorite
```

Updates the favorite.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Report/UpdateFavorite?$select=name,department,category/id
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

ReportEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReportEntity |  | Carrier object for ReportEntity. Services for the ReportEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IReportAgent">Report Agent</see>. |


## Response: object

Carrier object for ReportEntity.
Services for the ReportEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IReportAgent">Report Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReportId | int32 | The id of the report. |
| ReportCategory | string | The category of the report. |
| Description | string | The description of the report. |
| ReportLayout | string | The layout of the report. |
| Name | string | The name of the report |
| AssociateId | int32 | The owner of the report. |
| TemplateId | int32 | The id of report template. |
| Published | bool | Is the report published? |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Report/UpdateFavorite
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ReportEntity": {
    "ReportId": 759,
    "ReportCategory": "All",
    "Description": "Mandatory real-time database",
    "ReportLayout": "CalendarMonth",
    "Name": "Morar-O'Kon",
    "AssociateId": 103,
    "TemplateId": 50,
    "Published": false
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReportId": 126,
  "ReportCategory": "All",
  "Description": "Public-key intangible strategy",
  "ReportLayout": "CalendarMonth",
  "Name": "Greenfelder, Roob and Borer",
  "AssociateId": 221,
  "TemplateId": 227,
  "Published": false,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "integrate e-business synergies"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 981
    }
  }
}
```