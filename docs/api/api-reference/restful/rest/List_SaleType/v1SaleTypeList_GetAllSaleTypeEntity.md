---
title: GET List/SaleType/Items
id: v1SaleTypeList_GetAllSaleTypeEntity
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
GET /api/v1/List/SaleType/Items?includeDeleted=False
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

## Sample Request

```http!
GET /api/v1/List/SaleType/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "SaleTypeId": 639,
    "Name": "Wiegand-Pouros",
    "Tooltip": "culpa",
    "Rank": 61,
    "DurationUnit": "Century",
    "SaleDuration": 465,
    "SaleTypeCatId": 869,
    "Deleted": false,
    "HasGuide": true,
    "HasStakeholders": false,
    "IsAutoAdvance": true,
    "AllowQuoteAlternatives": true,
    "DefaultQuoteValidity": 108,
    "QuoteLinesTemplate": 352,
    "ConfirmationLinesTemplate": 77,
    "MaxDiscountPercentSet": true,
    "MinEarningPercentSet": true,
    "MaxDiscountPercent": 830,
    "MinEarningPercent": 683,
    "GroupQuoteLinesBy": 567,
    "SortGroupLinesBy": 233,
    "Stages": [
      {
        "Id": 607,
        "Name": "Feest, Hayes and Heathcote",
        "ToolTip": "A quos laudantium.",
        "Deleted": true,
        "Rank": 748,
        "Type": "minus",
        "ColorBlock": 815,
        "IconHint": "maiores",
        "Selected": true,
        "LastChanged": "2009-11-25T15:05:43.7871195+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "asperiores",
        "StyleHint": "ipsam",
        "Hidden": true,
        "FullName": "Kasey Ferry",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "incentivize value-added markets"
            },
            "FieldType": "System.String",
            "FieldLength": 863
          }
        }
      }
    ],
    "TableRight": {
      "Mask": "Delete",
      "Reason": "leverage virtual models"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 35
      }
    }
  }
]
```