---
title: POST Agents/List/GetAllSaleTypeEntities
uid: v1ListAgent_GetAllSaleTypeEntities
generated: true
---

# POST Agents/List/GetAllSaleTypeEntities

```http
POST /api/v1/Agents/List/GetAllSaleTypeEntities
```

Returns all sale types as entities with stakeholders, guide and quote properties







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetAllSaleTypeEntities?$select=name,department,category/id
```


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

## Request Body: request 

IncludeDeleted 

| Property Name | Type |  Description |
|----------------|------|--------------|
| IncludeDeleted | Boolean |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

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
POST /api/v1/Agents/List/GetAllSaleTypeEntities
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "IncludeDeleted": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "SaleTypeId": 57,
    "Name": "Kertzmann, Gibson and Maggio",
    "Tooltip": "nobis",
    "Rank": 703,
    "DurationUnit": "Century",
    "SaleDuration": 693,
    "SaleTypeCatId": 769,
    "Deleted": false,
    "HasGuide": false,
    "HasStakeholders": false,
    "IsAutoAdvance": true,
    "AllowQuoteAlternatives": true,
    "DefaultQuoteValidity": 616,
    "QuoteLinesTemplate": 380,
    "ConfirmationLinesTemplate": 911,
    "MaxDiscountPercentSet": false,
    "MinEarningPercentSet": false,
    "MaxDiscountPercent": 740,
    "MinEarningPercent": 869,
    "GroupQuoteLinesBy": 91,
    "SortGroupLinesBy": 159,
    "Stages": [
      {
        "Id": 715,
        "Name": "Lang-Barton",
        "ToolTip": "Sed autem et ex veritatis in vero et.",
        "Deleted": false,
        "Rank": 882,
        "Type": "veritatis",
        "ColorBlock": 739,
        "IconHint": "voluptatem",
        "Selected": false,
        "LastChanged": "2006-11-23T03:45:23.5142048+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "debitis",
        "StyleHint": "ut",
        "Hidden": true,
        "FullName": "Dejon Braun",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 841
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 646
      }
    }
  }
]
```