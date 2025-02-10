---
title: POST List/SaleType/Items
uid: v1SaleTypeList_PostSaleTypeEntity
generated: true
---

# POST List/SaleType/Items

```http
POST /api/v1/List/SaleType/Items
```

Create a new SaleTypeEntity list item


Calls the List agent service SaveSaleTypeEntity.







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

The SaleTypeEntity to be created. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleTypeId | Integer | Primary key |
| Name | String | The list item |
| Tooltip | String | Tooltip or other description |
| Rank | Integer | Rank order |
| DurationUnit | String | Units for the duration (day, week, whatever) |
| SaleDuration | Integer | Expected number of dales from initiation to close of sale |
| SaleTypeCatId | Integer | Category of sale type, copied to sale |
| Deleted | Boolean | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| HasGuide | Boolean | Does this sale type have a guide attached |
| HasStakeholders | Boolean | Does this sale type have stakeholders |
| IsAutoAdvance | Boolean | Does the sale stage advance automatically, when the last guided activity in a stage is completed? |
| AllowQuoteAlternatives | Boolean | Can quotes linked to sales of this type, have multiple Alternatives |
| DefaultQuoteValidity | Integer | Default valid days for quotes linked to sales of this type (valid from quote transmission) |
| QuoteLinesTemplate | Integer | The template that this sale type should use when producing the product lines offer document; the template must have DocTmplQuoteType=QuoteLines |
| ConfirmationLinesTemplate | Integer | The template that this sale type should use when producing the order confirmation lines document; the template must have DocTmplQuoteType=ConfirmationLines |
| MaxDiscountPercentSet | Boolean | Is there a limit, in percent, to the total discount on quotes linked to sales of this type |
| MinEarningPercentSet | Boolean | Is there a limit, in earning as percent of total, on quotes linked to sales of this type |
| MaxDiscountPercent | Integer | The maximum discount in percent of total, if set, on quotes linked to sales of this type |
| MinEarningPercent | Integer | The minimum earning in percent of total, if set, on quotes linked to sales of this type |
| GroupQuoteLinesBy | Integer | Group quote lines by this field |
| SortGroupLinesBy | Integer | Sort group lines by this field |
| Stages | Array | Stages, those associated with this SaleType are selected.  <para>Use MDO List name "salestage" to get list items.</para> |

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
POST /api/v1/List/SaleType/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 561,
  "Name": "Lueilwitz-Erdman",
  "Tooltip": "nam",
  "Rank": 242,
  "DurationUnit": "Century",
  "SaleDuration": 732,
  "SaleTypeCatId": 171,
  "Deleted": false,
  "HasGuide": false,
  "HasStakeholders": false,
  "IsAutoAdvance": false,
  "AllowQuoteAlternatives": true,
  "DefaultQuoteValidity": 182,
  "QuoteLinesTemplate": 223,
  "ConfirmationLinesTemplate": 211,
  "MaxDiscountPercentSet": true,
  "MinEarningPercentSet": true,
  "MaxDiscountPercent": 180,
  "MinEarningPercent": 679,
  "GroupQuoteLinesBy": 475,
  "SortGroupLinesBy": 706,
  "Stages": [
    {
      "Id": 162,
      "Name": "Waters, Olson and Stoltenberg",
      "ToolTip": "Voluptatibus iure.",
      "Deleted": true,
      "Rank": 424,
      "Type": "suscipit",
      "ColorBlock": 253,
      "IconHint": "laudantium",
      "Selected": false,
      "LastChanged": "2023-12-05T12:01:33.6519877+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "consectetur",
      "Hidden": false,
      "FullName": "Prof. Kasey McKenzie"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 416,
  "Name": "Stark-Ankunding",
  "Tooltip": "laudantium",
  "Rank": 900,
  "DurationUnit": "Century",
  "SaleDuration": 308,
  "SaleTypeCatId": 585,
  "Deleted": false,
  "HasGuide": true,
  "HasStakeholders": true,
  "IsAutoAdvance": true,
  "AllowQuoteAlternatives": false,
  "DefaultQuoteValidity": 171,
  "QuoteLinesTemplate": 68,
  "ConfirmationLinesTemplate": 306,
  "MaxDiscountPercentSet": true,
  "MinEarningPercentSet": true,
  "MaxDiscountPercent": 810,
  "MinEarningPercent": 362,
  "GroupQuoteLinesBy": 242,
  "SortGroupLinesBy": 319,
  "Stages": [
    {
      "Id": 676,
      "Name": "Bednar Inc and Sons",
      "ToolTip": "Omnis inventore qui.",
      "Deleted": false,
      "Rank": 992,
      "Type": "rerum",
      "ColorBlock": 377,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2010-06-13T12:01:33.6519877+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "saepe",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Jonatan Reichert",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 815
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 92
    }
  }
}
```