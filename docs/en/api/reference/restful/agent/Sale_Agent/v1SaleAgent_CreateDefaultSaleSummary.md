---
title: POST Agents/Sale/CreateDefaultSaleSummary
uid: v1SaleAgent_CreateDefaultSaleSummary
generated: true
content_type: reference
---

# POST Agents/Sale/CreateDefaultSaleSummary

```http
POST /api/v1/Agents/Sale/CreateDefaultSaleSummary
```

Loading default values into a new SaleSummary.








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

### Response body: SaleSummary

| Property Name | Type |  Description |
|----------------|------|--------------|
| BaseCurrency | string | Default currency for the installation |
| OwnCurrency | string | Default currency for the current user |
| SoldTotalBaseCurrency | double | Summed amount for all sold within the period in default currency for the installation |
| Sold | int32 | Number of all sold within the period |
| SoldTotalOwnCurrency | double | Summed amount for all sold within the period in default currency for the current user |
| Lost | int32 | Number of all lost within the period |
| LostTotalBaseCurrency | double | Summed amount for all lost within the period in default currency for the installation |
| LostTotalOwnCurrency | double | Summed amount for all lost within the period in default currency for the current user |
| Open | int32 | Number of all open within the period |
| OpenTotalBaseCurrency | double | Summed amount for all open within the period in default currency for the installation |
| OpenTotalOwnCurrency | double | Summed amount for all open within the period in default currency for the current user |
| OpenWeightedBaseCurrency | double | Weighted sum for all open within the period in default currency for the installation |
| OpenWeightedOwnCurrency | double | Weighted sum for all open within the period in default currency for the current user |
| PreviousOverdue | int32 | Number of all open sales with date before this period |
| PreviousOverdueTotalBaseCurrency | double | Summed amount for all open sales with date before this period in default currency for the installation |
| PreviousOverdueTotalOwnCurrency | double | Summed amount for all open sales with date before this period in default currency for the current user |
| PreviousOverdueWeightedBaseCurrency | double | Weighted sum for all open sales with date before this period in default currency for the installation |
| PreviousOverdueWeightedOwnCurrency | double | Weighted sum for all open sales with date before this period in default currency for the current user |
| CurrentOverdue | int32 | Number of all overdue sales within the period |
| CurrentOverdueTotalBaseCurrency | double | Summed amount for all overdue sales within the period in default currency for the installation |
| CurrentOverdueTotalOwnCurrency | double | Summed amount for all overdue sales within the period in default currency for the current user |
| CurrentOverdueWeightedBaseCurrency | double | Weighted sum for all overdue sales within the period in default currency for the installation |
| CurrentOverdueWeightedOwnCurrency | double | Weighted sum for all overdue sales within the period in default currency for the current user |
| FutureOpen | int32 | Number of all Future Pipe/All open sales with date after the period |
| FutureOpenTotalBaseCurrency | double | Summed amount for all Future Pipe/All open sales with date after the period in default currency for the installation |
| FutureOpenTotalOwnCurrency | double | Summed amount for all Future Pipe/All open sales with date after the period in default currency for the current user |
| FutureOpenWeightedBaseCurrency | double | Weighted sum for all Future Pipe/All open sales with date after the period in default currency for the installation |
| FutureOpenWeightedOwnCurrency | double | Weighted sum for all Future Pipe/All open sales with date after the period in default currency for the current user |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Sale/CreateDefaultSaleSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BaseCurrency": "veritatis",
  "OwnCurrency": "sed",
  "SoldTotalBaseCurrency": 13789.6,
  "Sold": 812,
  "SoldTotalOwnCurrency": 25962.056,
  "Lost": 192,
  "LostTotalBaseCurrency": 28563.275999999998,
  "LostTotalOwnCurrency": 16522.448,
  "Open": 162,
  "OpenTotalBaseCurrency": 10627.394,
  "OpenTotalOwnCurrency": 7383.704,
  "OpenWeightedBaseCurrency": 9010.25,
  "OpenWeightedOwnCurrency": 10345.333999999999,
  "PreviousOverdue": 422,
  "PreviousOverdueTotalBaseCurrency": 19913.435999999998,
  "PreviousOverdueTotalOwnCurrency": 14284.771999999999,
  "PreviousOverdueWeightedBaseCurrency": 15742.082,
  "PreviousOverdueWeightedOwnCurrency": 8455.532,
  "CurrentOverdue": 920,
  "CurrentOverdueTotalBaseCurrency": 25564.038,
  "CurrentOverdueTotalOwnCurrency": 20330.257999999998,
  "CurrentOverdueWeightedBaseCurrency": 1604.608,
  "CurrentOverdueWeightedOwnCurrency": 3359.6479999999997,
  "FutureOpen": 630,
  "FutureOpenTotalBaseCurrency": 19361.852,
  "FutureOpenTotalOwnCurrency": 4456.548,
  "FutureOpenWeightedBaseCurrency": 26764.36,
  "FutureOpenWeightedOwnCurrency": 17829.326,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 70
    }
  }
}
```