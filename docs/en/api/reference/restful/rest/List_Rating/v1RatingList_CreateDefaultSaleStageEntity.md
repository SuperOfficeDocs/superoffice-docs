---
title: GET List/Rating/Items/Default
uid: v1RatingList_CreateDefaultSaleStageEntity
generated: true
---

# GET List/Rating/Items/Default

```http
GET /api/v1/List/Rating/Items/Default
```

Gets a default SaleStageEntity list item.








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
GET /api/v1/List/Rating/Items/Default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleStageId": 946,
  "Value": "et",
  "Tooltip": "necessitatibus",
  "Probability": 354,
  "Deleted": false,
  "Rank": 827,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 62
    }
  }
}
```