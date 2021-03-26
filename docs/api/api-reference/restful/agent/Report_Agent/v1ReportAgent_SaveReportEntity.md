---
title: POST Agents/Report/SaveReportEntity
id: v1ReportAgent_SaveReportEntity
---

# POST Agents/Report/SaveReportEntity

```http
POST /api/v1/Agents/Report/SaveReportEntity
```

Updates the existing ReportEntity or creates a new ReportEntity if the id parameter is empty








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

## Request Body: entity  

The ReportEntity to be saved. 

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
POST /api/v1/Agents/Report/SaveReportEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ReportId": 866,
  "ReportCategory": "All",
  "Description": "Compatible fresh-thinking capacity",
  "ReportLayout": "CalendarMonth",
  "Name": "Quitzon LLC",
  "AssociateId": 208,
  "TemplateId": 802,
  "Published": true
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReportId": 636,
  "ReportCategory": "All",
  "Description": "Grass-roots reciprocal focus group",
  "ReportLayout": "CalendarMonth",
  "Name": "Gleichner Group",
  "AssociateId": 353,
  "TemplateId": 830,
  "Published": true,
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
      "FieldLength": 28
    }
  }
}
```