---
title: POST List/Rating/Items
id: v1RatingList_PostSaleStageEntity
---

# POST List/Rating/Items

```http
POST /api/v1/List/Rating/Items
```

Create a new SaleStageEntity list item

Calls the List agent service SaveSaleStageEntity.






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

## Request Body: newEntity  

The SaleStageEntity to be created. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleStageId | int32 | Primary key |
| Value | string | The sale stage |
| Tooltip | string | Tooltip or other description |
| Probability | int32 | The numeric probability of the sale |
| Deleted | bool | If true, the Sale stage is deleted |
| Rank | int32 | Rank order |


## Response: object

This entity represents a sale stage with a default percentage rating.



Carrier object for SaleStageEntity.
Services for the SaleStageEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/List/Rating/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SaleStageId": 671,
  "Value": "debitis",
  "Tooltip": "dolores",
  "Probability": 136,
  "Deleted": false,
  "Rank": 798
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleStageId": 702,
  "Value": "rerum",
  "Tooltip": "at",
  "Probability": 173,
  "Deleted": false,
  "Rank": 334,
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
      "FieldLength": 370
    }
  }
}
```