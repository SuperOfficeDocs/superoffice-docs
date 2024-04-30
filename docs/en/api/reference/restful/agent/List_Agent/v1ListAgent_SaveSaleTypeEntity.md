---
title: POST Agents/List/SaveSaleTypeEntity
uid: v1ListAgent_SaveSaleTypeEntity
generated: true
---

# POST Agents/List/SaveSaleTypeEntity

```http
POST /api/v1/Agents/List/SaveSaleTypeEntity
```

Updates the existing SaleTypeEntity or creates a new SaleTypeEntity if the id parameter is empty








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

The SaleTypeEntity to be saved. 

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 491,
  "Name": "Kohler-Douglas",
  "Tooltip": "omnis",
  "Rank": 995,
  "DurationUnit": "Century",
  "SaleDuration": 26,
  "SaleTypeCatId": 836,
  "Deleted": false,
  "HasGuide": true,
  "HasStakeholders": false,
  "IsAutoAdvance": false,
  "AllowQuoteAlternatives": false,
  "DefaultQuoteValidity": 708,
  "QuoteLinesTemplate": 190,
  "ConfirmationLinesTemplate": 886,
  "MaxDiscountPercentSet": true,
  "MinEarningPercentSet": true,
  "MaxDiscountPercent": 324,
  "MinEarningPercent": 633,
  "GroupQuoteLinesBy": 893,
  "SortGroupLinesBy": 714,
  "Stages": [
    {
      "Id": 159,
      "Name": "O'Connell, Smith and Schinner",
      "ToolTip": "Ea laboriosam.",
      "Deleted": true,
      "Rank": 894,
      "Type": "quis",
      "ColorBlock": 218,
      "IconHint": "laborum",
      "Selected": true,
      "LastChanged": "2011-06-29T11:44:33.9158989+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "voluptatum",
      "Hidden": false,
      "FullName": "Gabrielle Ortiz"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 715,
  "Name": "Hoeger, Stroman and Tillman",
  "Tooltip": "officia",
  "Rank": 765,
  "DurationUnit": "Century",
  "SaleDuration": 599,
  "SaleTypeCatId": 820,
  "Deleted": false,
  "HasGuide": true,
  "HasStakeholders": true,
  "IsAutoAdvance": false,
  "AllowQuoteAlternatives": true,
  "DefaultQuoteValidity": 160,
  "QuoteLinesTemplate": 804,
  "ConfirmationLinesTemplate": 458,
  "MaxDiscountPercentSet": true,
  "MinEarningPercentSet": false,
  "MaxDiscountPercent": 907,
  "MinEarningPercent": 133,
  "GroupQuoteLinesBy": 805,
  "SortGroupLinesBy": 373,
  "Stages": [
    {
      "Id": 492,
      "Name": "Lemke-Nolan",
      "ToolTip": "Voluptates at at aut repellat ut repellendus quaerat.",
      "Deleted": true,
      "Rank": 275,
      "Type": "vel",
      "ColorBlock": 440,
      "IconHint": "voluptatum",
      "Selected": false,
      "LastChanged": "2017-02-06T11:44:33.9158989+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "soluta",
      "StyleHint": "quos",
      "Hidden": false,
      "FullName": "Evelyn Heidenreich",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 818
    }
  }
}
```