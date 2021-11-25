---
title: POST Agents/Report/GetReportEntity
id: v1ReportAgent_GetReportEntity
---

# POST Agents/Report/GetReportEntity

```http
POST /api/v1/Agents/Report/GetReportEntity
```

Gets a ReportEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| reportEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Report/GetReportEntity?reportEntityId=133
POST /api/v1/Agents/Report/GetReportEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Report/GetReportEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReportId": 973,
  "ReportCategory": "All",
  "Description": "Total impactful intranet",
  "ReportLayout": "CalendarMonth",
  "Name": "Deckow-White",
  "AssociateId": 253,
  "TemplateId": 377,
  "Published": false,
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
      "FieldLength": 717
    }
  }
}
```