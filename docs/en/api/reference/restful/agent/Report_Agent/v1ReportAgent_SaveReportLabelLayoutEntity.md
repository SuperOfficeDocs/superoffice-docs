---
title: POST Agents/Report/SaveReportLabelLayoutEntity
uid: v1ReportAgent_SaveReportLabelLayoutEntity
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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Report/SaveReportLabelLayoutEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ReportLabelLayoutId": 848,
  "Name": "Schamberger-Koch",
  "Description": "Future-proofed client-driven algorithm",
  "Orientation": "Landscape",
  "PaperWidth": 925,
  "PaperHeight": 601,
  "LeftMargin": 175,
  "RightMargin": 555,
  "TopMargin": 666,
  "BottomMargin": 388,
  "CountColumns": 288,
  "CountRows": 771
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ReportLabelLayoutId": 425,
  "Name": "Rolfson Inc and Sons",
  "Description": "Ergonomic 6th generation Graphic Interface",
  "Orientation": "Landscape",
  "PaperWidth": 941,
  "PaperHeight": 153,
  "LeftMargin": 651,
  "RightMargin": 200,
  "TopMargin": 638,
  "BottomMargin": 837,
  "CountColumns": 276,
  "CountRows": 150,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 715
    }
  }
}
```