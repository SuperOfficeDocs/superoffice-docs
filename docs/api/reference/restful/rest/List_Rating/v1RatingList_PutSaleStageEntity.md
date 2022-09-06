---
title: PUT List/Rating/Items/{id}
uid: v1RatingList_PutSaleStageEntity
---

# PUT List/Rating/Items/{id}

```http
PUT /api/v1/List/Rating/Items/{id}
```

Updates the existing SaleStageEntity

Calls the List agent service SaveSaleStageEntity.

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of SaleStageEntity to be saved. **Required** |

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

The details of SaleStageEntity to be saved.

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleStageId | int32 | Primary key |
| Value | string | The sale stage |
| Tooltip | string | Tooltip or other description |
| Probability | int32 | The numeric probability of the sale |
| Deleted | bool | If true, the Sale stage is deleted |
| Rank | int32 | Rank order |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleStageId | int32 | Primary key |
| Value | string | The sale stage |
| Tooltip | string | Tooltip or other description |
| Probability | int32 | The numeric probability of the sale |
| Deleted | bool | If true, the Sale stage is deleted |
| Rank | int32 | Rank order |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/Rating/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SaleStageId": 165,
  "Value": "dignissimos",
  "Tooltip": "quia",
  "Probability": 297,
  "Deleted": false,
  "Rank": 918
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleStageId": 365,
  "Value": "doloribus",
  "Tooltip": "exercitationem",
  "Probability": 287,
  "Deleted": false,
  "Rank": 111,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 630
    }
  }
}
```
