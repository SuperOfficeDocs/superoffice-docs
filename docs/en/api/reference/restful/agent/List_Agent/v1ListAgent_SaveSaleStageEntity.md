---
title: POST Agents/List/SaveSaleStageEntity
uid: v1ListAgent_SaveSaleStageEntity
generated: true
---

# POST Agents/List/SaveSaleStageEntity

```http
POST /api/v1/Agents/List/SaveSaleStageEntity
```

Updates the existing SaleStageEntity or creates a new SaleStageEntity if the id parameter is empty








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

The SaleStageEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleStageId | Integer | Primary key |
| Value | String | The sale stage |
| Tooltip | String | Tooltip or other description |
| Probability | Integer | The numeric probability of the sale |
| Deleted | Boolean | If true, the Sale stage is deleted |
| Rank | Integer | Rank order |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SaleStageEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleStageId | int32 | Primary key |
| Value | string | The sale stage |
| Tooltip | string | Tooltip or other description |
| Probability | int32 | The numeric probability of the sale |
| Deleted | bool | If true, the Sale stage is deleted |
| Rank | int32 | Rank order |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/SaveSaleStageEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SaleStageId": 26,
  "Value": "voluptatem",
  "Tooltip": "sed",
  "Probability": 116,
  "Deleted": false,
  "Rank": 918
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleStageId": 731,
  "Value": "iusto",
  "Tooltip": "cumque",
  "Probability": 980,
  "Deleted": false,
  "Rank": 428,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 731
    }
  }
}
```