---
title: POST Agents/Report/SaveReportLabelLayoutEntity
uid: v1ReportAgent_SaveReportLabelLayoutEntity
generated: true
---

# POST Agents/Report/SaveReportLabelLayoutEntity

```http
POST /api/v1/Agents/Report/SaveReportLabelLayoutEntity
```

Updates the existing ReportLabelLayoutEntity or creates a new ReportLabelLayoutEntity if the id parameter is empty








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

The ReportLabelLayoutEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ReportLabelLayoutId | Integer | Primary key |
| Name | String | Name of the label layout |
| Description | String | Description |
| Orientation | String | Paper orientation: 1=portrait, 2=landscape |
| PaperWidth | Integer | Paper width in twips |
| PaperHeight | Integer | Paper height in twips |
| LeftMargin | Integer | Left margin in twips |
| RightMargin | Integer | Right margin in twips |
| TopMargin | Integer | Top margin in twips |
| BottomMargin | Integer | Bottom margin in twips |
| CountColumns | Integer | Number og columns |
| CountRows | Integer | Number of rows |

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
POST /api/v1/Agents/Report/SaveReportLabelLayoutEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ReportLabelLayoutId": 683,
  "Name": "Schaefer-Reynolds",
  "Description": "Focused next generation solution",
  "Orientation": "Landscape",
  "PaperWidth": 940,
  "PaperHeight": 136,
  "LeftMargin": 422,
  "RightMargin": 455,
  "TopMargin": 812,
  "BottomMargin": 580,
  "CountColumns": 290,
  "CountRows": 318
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReportLabelLayoutId": 663,
  "Name": "McClure, Skiles and Bradtke",
  "Description": "Synchronised upward-trending protocol",
  "Orientation": "Landscape",
  "PaperWidth": 293,
  "PaperHeight": 839,
  "LeftMargin": 372,
  "RightMargin": 838,
  "TopMargin": 866,
  "BottomMargin": 564,
  "CountColumns": 537,
  "CountRows": 391,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 423
    }
  }
}
```