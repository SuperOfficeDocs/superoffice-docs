---
title: GET List/SaleType/Items
uid: v1SaleTypeList_GetAllSaleTypeEntity
---

# GET List/SaleType/Items

```http
GET /api/v1/List/SaleType/Items
```

Gets a list of all SaleTypeEntity list items.

Calls the List agent service GetAllSaleTypeEntity.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| includeDeleted | bool |   |

```http
GET /api/v1/List/SaleType/Items?includeDeleted=True
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

## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/List/SaleType/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "SaleTypeId": 725,
    "Name": "Green Group",
    "Tooltip": "repudiandae",
    "Rank": 402,
    "DurationUnit": "Century",
    "SaleDuration": 62,
    "SaleTypeCatId": 191,
    "Deleted": true,
    "HasGuide": false,
    "HasStakeholders": true,
    "IsAutoAdvance": false,
    "AllowQuoteAlternatives": false,
    "DefaultQuoteValidity": 348,
    "QuoteLinesTemplate": 799,
    "ConfirmationLinesTemplate": 753,
    "MaxDiscountPercentSet": false,
    "MinEarningPercentSet": false,
    "MaxDiscountPercent": 26,
    "MinEarningPercent": 201,
    "GroupQuoteLinesBy": 49,
    "SortGroupLinesBy": 262,
    "Stages": [
      {
        "Id": 218,
        "Name": "Armstrong-Schuster",
        "ToolTip": "Quia facere quis sunt dolor alias.",
        "Deleted": false,
        "Rank": 555,
        "Type": "quae",
        "ColorBlock": 780,
        "IconHint": "aliquam",
        "Selected": false,
        "LastChanged": "2012-01-10T11:10:54.595935+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "suscipit",
        "Hidden": true,
        "FullName": "Shanel Little",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 546
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 721
      }
    }
  }
]
```
