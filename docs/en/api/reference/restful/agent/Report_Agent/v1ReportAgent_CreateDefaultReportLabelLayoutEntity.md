---
title: POST Agents/Report/CreateDefaultReportLabelLayoutEntity
uid: v1ReportAgent_CreateDefaultReportLabelLayoutEntity
---

# POST Agents/Report/CreateDefaultReportLabelLayoutEntity

```http
POST /api/v1/Agents/Report/CreateDefaultReportLabelLayoutEntity
```

Set default values into a new ReportLabelLayoutEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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

### Response body: ReportLabelLayoutEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReportLabelLayoutId | int32 | Primary key |
| Name | string | Name of the label layout |
| Description | string | Description |
| Orientation | string | Paper orientation: 1=portrait, 2=landscape |
| PaperWidth | int32 | Paper width in twips |
| PaperHeight | int32 | Paper height in twips |
| LeftMargin | int32 | Left margin in twips |
| RightMargin | int32 | Right margin in twips |
| TopMargin | int32 | Top margin in twips |
| BottomMargin | int32 | Bottom margin in twips |
| CountColumns | int32 | Number og columns |
| CountRows | int32 | Number of rows |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Report/CreateDefaultReportLabelLayoutEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReportLabelLayoutId": 961,
  "Name": "Bradtke, Yost and Lesch",
  "Description": "Extended motivating alliance",
  "Orientation": "Landscape",
  "PaperWidth": 502,
  "PaperHeight": 312,
  "LeftMargin": 659,
  "RightMargin": 804,
  "TopMargin": 486,
  "BottomMargin": 375,
  "CountColumns": 434,
  "CountRows": 176,
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