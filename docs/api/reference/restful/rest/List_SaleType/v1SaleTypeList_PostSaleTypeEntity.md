---
title: POST List/SaleType/Items
id: v1SaleTypeList_PostSaleTypeEntity
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


## Response: object

Carrier object for SaleTypeEntity.
Services for the SaleTypeEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
POST /api/v1/List/SaleType/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 913,
  "Name": "Bechtelar-Fritsch",
  "Tooltip": "distinctio",
  "Rank": 21,
  "DurationUnit": "Century",
  "SaleDuration": 362,
  "SaleTypeCatId": 242,
  "Deleted": false,
  "HasGuide": true,
  "HasStakeholders": true,
  "IsAutoAdvance": true,
  "AllowQuoteAlternatives": true,
  "DefaultQuoteValidity": 165,
  "QuoteLinesTemplate": 420,
  "ConfirmationLinesTemplate": 248,
  "MaxDiscountPercentSet": false,
  "MinEarningPercentSet": false,
  "MaxDiscountPercent": 473,
  "MinEarningPercent": 219,
  "GroupQuoteLinesBy": 871,
  "SortGroupLinesBy": 28,
  "Stages": [
    {
      "Id": 708,
      "Name": "Koepp Group",
      "ToolTip": "Occaecati vitae consectetur earum quidem quas.",
      "Deleted": true,
      "Rank": 79,
      "Type": "suscipit",
      "ColorBlock": 84,
      "IconHint": "asperiores",
      "Selected": false,
      "LastChanged": "1996-12-05T18:25:52.1800202+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quod",
      "StyleHint": "quisquam",
      "Hidden": false,
      "FullName": "Betty Jerde"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 995,
  "Name": "Kemmer-Kuhlman",
  "Tooltip": "sint",
  "Rank": 470,
  "DurationUnit": "Century",
  "SaleDuration": 561,
  "SaleTypeCatId": 36,
  "Deleted": false,
  "HasGuide": false,
  "HasStakeholders": false,
  "IsAutoAdvance": false,
  "AllowQuoteAlternatives": false,
  "DefaultQuoteValidity": 813,
  "QuoteLinesTemplate": 205,
  "ConfirmationLinesTemplate": 578,
  "MaxDiscountPercentSet": false,
  "MinEarningPercentSet": true,
  "MaxDiscountPercent": 656,
  "MinEarningPercent": 716,
  "GroupQuoteLinesBy": 159,
  "SortGroupLinesBy": 603,
  "Stages": [
    {
      "Id": 168,
      "Name": "O'Connell, Ryan and Ratke",
      "ToolTip": "Rerum reiciendis nostrum molestiae architecto consequatur.",
      "Deleted": true,
      "Rank": 264,
      "Type": "omnis",
      "ColorBlock": 339,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2020-07-05T18:25:52.1810197+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "odio",
      "Hidden": true,
      "FullName": "Rodger Treutel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 207
        }
      }
    }
  ],
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
      "FieldLength": 109
    }
  }
}
```