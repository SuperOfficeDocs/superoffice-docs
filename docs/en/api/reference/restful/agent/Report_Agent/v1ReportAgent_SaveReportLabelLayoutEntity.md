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
  "ReportLabelLayoutId": 346,
  "Name": "Botsford-Watsica",
  "Description": "Adaptive explicit system engine",
  "Orientation": "Landscape",
  "PaperWidth": 662,
  "PaperHeight": 509,
  "LeftMargin": 816,
  "RightMargin": 168,
  "TopMargin": 766,
  "BottomMargin": 86,
  "CountColumns": 447,
  "CountRows": 676
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReportLabelLayoutId": 416,
  "Name": "Reinger-Bartoletti",
  "Description": "Assimilated tangible methodology",
  "Orientation": "Landscape",
  "PaperWidth": 199,
  "PaperHeight": 198,
  "LeftMargin": 742,
  "RightMargin": 347,
  "TopMargin": 12,
  "BottomMargin": 385,
  "CountColumns": 692,
  "CountRows": 652,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 863
    }
  }
}
```