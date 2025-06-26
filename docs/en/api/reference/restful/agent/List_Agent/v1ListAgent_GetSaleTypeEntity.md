---
title: POST Agents/List/GetSaleTypeEntity
uid: v1ListAgent_GetSaleTypeEntity
generated: true
---

# POST Agents/List/GetSaleTypeEntity

```http
POST /api/v1/Agents/List/GetSaleTypeEntity
```

Gets a SaleTypeEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| saleTypeEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetSaleTypeEntity?saleTypeEntityId=640
POST /api/v1/Agents/List/GetSaleTypeEntity?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SaleTypeEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleTypeId | int32 | Primary key |
| Name | string | The list item |
| Tooltip | string | Tooltip or other description |
| Rank | int32 | Rank order |
| DurationUnit | string | Units for the duration (day, week, whatever) |
| SaleDuration | int32 | Expected number of dales from initiation to close of sale |
| SaleTypeCatId | int32 | Category of sale type, copied to sale |
| Deleted | bool | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| HasGuide | bool | Does this sale type have a guide attached |
| HasStakeholders | bool | Does this sale type have stakeholders |
| IsAutoAdvance | bool | Does the sale stage advance automatically, when the last guided activity in a stage is completed? |
| AllowQuoteAlternatives | bool | Can quotes linked to sales of this type, have multiple Alternatives |
| DefaultQuoteValidity | int32 | Default valid days for quotes linked to sales of this type (valid from quote transmission) |
| QuoteLinesTemplate | int32 | The template that this sale type should use when producing the product lines offer document; the template must have DocTmplQuoteType=QuoteLines |
| ConfirmationLinesTemplate | int32 | The template that this sale type should use when producing the order confirmation lines document; the template must have DocTmplQuoteType=ConfirmationLines |
| MaxDiscountPercentSet | bool | Is there a limit, in percent, to the total discount on quotes linked to sales of this type |
| MinEarningPercentSet | bool | Is there a limit, in earning as percent of total, on quotes linked to sales of this type |
| MaxDiscountPercent | int32 | The maximum discount in percent of total, if set, on quotes linked to sales of this type |
| MinEarningPercent | int32 | The minimum earning in percent of total, if set, on quotes linked to sales of this type |
| GroupQuoteLinesBy | int32 | Group quote lines by this field |
| SortGroupLinesBy | int32 | Sort group lines by this field |
| Stages | array | Stages, those associated with this SaleType are selected.  Use MDO List name "salestage" to get list items. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/GetSaleTypeEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 79,
  "Name": "Padberg Group",
  "Tooltip": "quos",
  "Rank": 41,
  "DurationUnit": "Century",
  "SaleDuration": 501,
  "SaleTypeCatId": 201,
  "Deleted": false,
  "HasGuide": false,
  "HasStakeholders": false,
  "IsAutoAdvance": true,
  "AllowQuoteAlternatives": true,
  "DefaultQuoteValidity": 406,
  "QuoteLinesTemplate": 225,
  "ConfirmationLinesTemplate": 60,
  "MaxDiscountPercentSet": false,
  "MinEarningPercentSet": true,
  "MaxDiscountPercent": 489,
  "MinEarningPercent": 557,
  "GroupQuoteLinesBy": 158,
  "SortGroupLinesBy": 728,
  "Stages": [
    {
      "Id": 795,
      "Name": "Schultz-Kutch",
      "ToolTip": "Autem sit quo nobis corrupti sed corporis voluptate.",
      "Deleted": false,
      "Rank": 807,
      "Type": "doloribus",
      "ColorBlock": 820,
      "IconHint": "facere",
      "Selected": false,
      "LastChanged": "1998-11-01T03:45:23.5142048+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "alias",
      "StyleHint": "quibusdam",
      "Hidden": true,
      "FullName": "Prof. Gino Dwight Grimes V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 902
    }
  }
}
```