---
title: POST List/SaleType/Items
uid: v1SaleTypeList_PostSaleTypeEntity
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
| Stages | array | Stages, those associated with this SaleType are selected.  <para>Use MDO List name "salestage" to get list items.</para> |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/List/SaleType/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 535,
  "Name": "Mueller, Jast and Hackett",
  "Tooltip": "sit",
  "Rank": 627,
  "DurationUnit": "Century",
  "SaleDuration": 498,
  "SaleTypeCatId": 722,
  "Deleted": true,
  "HasGuide": false,
  "HasStakeholders": false,
  "IsAutoAdvance": false,
  "AllowQuoteAlternatives": false,
  "DefaultQuoteValidity": 333,
  "QuoteLinesTemplate": 716,
  "ConfirmationLinesTemplate": 870,
  "MaxDiscountPercentSet": false,
  "MinEarningPercentSet": false,
  "MaxDiscountPercent": 872,
  "MinEarningPercent": 414,
  "GroupQuoteLinesBy": 694,
  "SortGroupLinesBy": 576,
  "Stages": [
    {
      "Id": 562,
      "Name": "Greenholt Inc and Sons",
      "ToolTip": "Omnis sequi beatae recusandae cumque qui et consequatur.",
      "Deleted": false,
      "Rank": 708,
      "Type": "voluptatem",
      "ColorBlock": 433,
      "IconHint": "in",
      "Selected": true,
      "LastChanged": "2006-01-10T17:37:40.3315004+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "deserunt",
      "Hidden": false,
      "FullName": "Juvenal Kuhlman"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 897,
  "Name": "Von Group",
  "Tooltip": "qui",
  "Rank": 165,
  "DurationUnit": "Century",
  "SaleDuration": 416,
  "SaleTypeCatId": 64,
  "Deleted": false,
  "HasGuide": false,
  "HasStakeholders": true,
  "IsAutoAdvance": true,
  "AllowQuoteAlternatives": true,
  "DefaultQuoteValidity": 310,
  "QuoteLinesTemplate": 159,
  "ConfirmationLinesTemplate": 1002,
  "MaxDiscountPercentSet": false,
  "MinEarningPercentSet": true,
  "MaxDiscountPercent": 502,
  "MinEarningPercent": 66,
  "GroupQuoteLinesBy": 828,
  "SortGroupLinesBy": 642,
  "Stages": [
    {
      "Id": 161,
      "Name": "Yost-Ankunding",
      "ToolTip": "Ratione vitae deleniti tempore expedita maxime.",
      "Deleted": false,
      "Rank": 114,
      "Type": "tenetur",
      "ColorBlock": 754,
      "IconHint": "fuga",
      "Selected": true,
      "LastChanged": "2003-02-09T17:37:40.3315004+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "exercitationem",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Kenton Lexus Auer II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 461
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 13
    }
  }
}
```