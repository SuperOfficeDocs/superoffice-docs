---
title: POST Agents/List/CreateDefaultSaleTypeEntity
id: v1ListAgent_CreateDefaultSaleTypeEntity
---

# POST Agents/List/CreateDefaultSaleTypeEntity

```http
POST /api/v1/Agents/List/CreateDefaultSaleTypeEntity
```

Set default values into a new SaleTypeEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/List/CreateDefaultSaleTypeEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 609,
  "Name": "Volkman Inc and Sons",
  "Tooltip": "ipsam",
  "Rank": 55,
  "DurationUnit": "Century",
  "SaleDuration": 899,
  "SaleTypeCatId": 501,
  "Deleted": true,
  "HasGuide": true,
  "HasStakeholders": true,
  "IsAutoAdvance": false,
  "AllowQuoteAlternatives": true,
  "DefaultQuoteValidity": 316,
  "QuoteLinesTemplate": 163,
  "ConfirmationLinesTemplate": 513,
  "MaxDiscountPercentSet": false,
  "MinEarningPercentSet": true,
  "MaxDiscountPercent": 968,
  "MinEarningPercent": 405,
  "GroupQuoteLinesBy": 452,
  "SortGroupLinesBy": 919,
  "Stages": [
    {
      "Id": 364,
      "Name": "Morissette, Hegmann and Kertzmann",
      "ToolTip": "Doloribus laboriosam et.",
      "Deleted": true,
      "Rank": 895,
      "Type": "nulla",
      "ColorBlock": 559,
      "IconHint": "accusantium",
      "Selected": false,
      "LastChanged": "2000-05-06T18:28:49.4510874+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "adipisci",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Augustus O'Reilly",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "utilize extensible synergies"
          },
          "FieldType": "System.Int32",
          "FieldLength": 805
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
      "FieldLength": 800
    }
  }
}
```