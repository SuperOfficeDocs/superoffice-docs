---
title: POST Agents/List/SaveSaleTypeEntity
id: v1ListAgent_SaveSaleTypeEntity
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
POST /api/v1/Agents/List/SaveSaleTypeEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 495,
  "Name": "Effertz, Bernhard and Wisoky",
  "Tooltip": "excepturi",
  "Rank": 703,
  "DurationUnit": "Century",
  "SaleDuration": 529,
  "SaleTypeCatId": 763,
  "Deleted": true,
  "HasGuide": true,
  "HasStakeholders": false,
  "IsAutoAdvance": true,
  "AllowQuoteAlternatives": false,
  "DefaultQuoteValidity": 917,
  "QuoteLinesTemplate": 715,
  "ConfirmationLinesTemplate": 420,
  "MaxDiscountPercentSet": true,
  "MinEarningPercentSet": false,
  "MaxDiscountPercent": 100,
  "MinEarningPercent": 964,
  "GroupQuoteLinesBy": 675,
  "SortGroupLinesBy": 9,
  "Stages": [
    {
      "Id": 566,
      "Name": "Zieme-Hayes",
      "ToolTip": "Minus quo enim et quo nam ea.",
      "Deleted": false,
      "Rank": 420,
      "Type": "asperiores",
      "ColorBlock": 544,
      "IconHint": "velit",
      "Selected": true,
      "LastChanged": "1994-02-12T16:48:29.9329247+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aspernatur",
      "StyleHint": "quisquam",
      "Hidden": true,
      "FullName": "Grayson Harris"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 308,
  "Name": "Rice, Considine and Koelpin",
  "Tooltip": "aut",
  "Rank": 615,
  "DurationUnit": "Century",
  "SaleDuration": 281,
  "SaleTypeCatId": 912,
  "Deleted": false,
  "HasGuide": true,
  "HasStakeholders": false,
  "IsAutoAdvance": true,
  "AllowQuoteAlternatives": true,
  "DefaultQuoteValidity": 154,
  "QuoteLinesTemplate": 477,
  "ConfirmationLinesTemplate": 520,
  "MaxDiscountPercentSet": false,
  "MinEarningPercentSet": true,
  "MaxDiscountPercent": 273,
  "MinEarningPercent": 528,
  "GroupQuoteLinesBy": 343,
  "SortGroupLinesBy": 702,
  "Stages": [
    {
      "Id": 819,
      "Name": "Okuneva Group",
      "ToolTip": "Pariatur non at odio voluptates.",
      "Deleted": false,
      "Rank": 398,
      "Type": "corporis",
      "ColorBlock": 164,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2016-05-24T16:48:29.9339271+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quo",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Sigrid Pfeffer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 36
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
      "FieldLength": 352
    }
  }
}
```