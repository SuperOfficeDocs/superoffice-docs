---
title: POST Agents/List/SaveSaleTypeEntity
uid: v1ListAgent_SaveSaleTypeEntity
generated: true
content_type: reference
---

# POST Agents/List/SaveSaleTypeEntity

```http
POST /api/v1/Agents/List/SaveSaleTypeEntity
```

Updates the existing SaleTypeEntity or creates a new SaleTypeEntity if the id parameter is 0.


NsApiSlow threshold: 5000 ms.







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

## Request Body: saleTypeEntity 

The SaleTypeEntity that is saved 

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
POST /api/v1/Agents/List/SaveSaleTypeEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 955,
  "Name": "Krajcik-Daniel",
  "Tooltip": "fugiat",
  "Rank": 740,
  "DurationUnit": "Century",
  "SaleDuration": 881,
  "SaleTypeCatId": 838,
  "Deleted": false,
  "HasGuide": false,
  "HasStakeholders": false,
  "IsAutoAdvance": true,
  "AllowQuoteAlternatives": false,
  "DefaultQuoteValidity": 351,
  "QuoteLinesTemplate": 825,
  "ConfirmationLinesTemplate": 969,
  "MaxDiscountPercentSet": false,
  "MinEarningPercentSet": false,
  "MaxDiscountPercent": 456,
  "MinEarningPercent": 424,
  "GroupQuoteLinesBy": 750,
  "SortGroupLinesBy": 139,
  "Stages": [
    {
      "Id": 840,
      "Name": "Hirthe Inc and Sons",
      "ToolTip": "Rem hic mollitia minus et at.",
      "Deleted": false,
      "Rank": 446,
      "Type": "id",
      "ColorBlock": 276,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2015-03-25T02:30:47.3975807+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laudantium",
      "StyleHint": "nesciunt",
      "Hidden": false,
      "FullName": "Mr. Juliet Oceane Hansen PhD"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 724,
  "Name": "Gleichner, Miller and Gleason",
  "Tooltip": "expedita",
  "Rank": 835,
  "DurationUnit": "Century",
  "SaleDuration": 35,
  "SaleTypeCatId": 493,
  "Deleted": false,
  "HasGuide": false,
  "HasStakeholders": true,
  "IsAutoAdvance": false,
  "AllowQuoteAlternatives": false,
  "DefaultQuoteValidity": 758,
  "QuoteLinesTemplate": 9,
  "ConfirmationLinesTemplate": 758,
  "MaxDiscountPercentSet": false,
  "MinEarningPercentSet": true,
  "MaxDiscountPercent": 683,
  "MinEarningPercent": 864,
  "GroupQuoteLinesBy": 944,
  "SortGroupLinesBy": 665,
  "Stages": [
    {
      "Id": 764,
      "Name": "Macejkovic Group",
      "ToolTip": "Illum ex cum illo aut eligendi minima.",
      "Deleted": true,
      "Rank": 921,
      "Type": "voluptatem",
      "ColorBlock": 75,
      "IconHint": "nam",
      "Selected": true,
      "LastChanged": "2012-09-02T02:30:47.3975807+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "totam",
      "StyleHint": "aspernatur",
      "Hidden": false,
      "FullName": "Carroll Watson Turner DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 714
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 59
    }
  }
}
```