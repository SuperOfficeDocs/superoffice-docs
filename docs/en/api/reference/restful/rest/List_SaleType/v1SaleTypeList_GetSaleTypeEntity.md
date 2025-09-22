---
title: GET List/SaleType/Items/{id}
uid: v1SaleTypeList_GetSaleTypeEntity
generated: true
content_type: reference
---

# GET List/SaleType/Items/{id}

```http
GET /api/v1/List/SaleType/Items/{id}
```

Gets a SaleTypeEntity list item.


Calls the List agent service GetSaleTypeEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the SaleType to return. **Required** |



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
| 404 | Not Found. |

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
GET /api/v1/List/SaleType/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 558,
  "Name": "Purdy Inc and Sons",
  "Tooltip": "tenetur",
  "Rank": 340,
  "DurationUnit": "Century",
  "SaleDuration": 905,
  "SaleTypeCatId": 457,
  "Deleted": false,
  "HasGuide": false,
  "HasStakeholders": false,
  "IsAutoAdvance": true,
  "AllowQuoteAlternatives": true,
  "DefaultQuoteValidity": 906,
  "QuoteLinesTemplate": 749,
  "ConfirmationLinesTemplate": 190,
  "MaxDiscountPercentSet": true,
  "MinEarningPercentSet": true,
  "MaxDiscountPercent": 982,
  "MinEarningPercent": 609,
  "GroupQuoteLinesBy": 410,
  "SortGroupLinesBy": 876,
  "Stages": [
    {
      "Id": 81,
      "Name": "Gerhold-Dach",
      "ToolTip": "Totam nostrum voluptatem ipsam necessitatibus placeat.",
      "Deleted": true,
      "Rank": 49,
      "Type": "et",
      "ColorBlock": 801,
      "IconHint": "aliquid",
      "Selected": true,
      "LastChanged": "2005-06-26T11:24:54.1405361+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laborum",
      "StyleHint": "voluptate",
      "Hidden": false,
      "FullName": "Laney Cecilia Heller III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 943
    }
  }
}
```