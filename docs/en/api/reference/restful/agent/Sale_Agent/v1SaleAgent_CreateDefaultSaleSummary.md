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


NsApiSlow threshold: 3000 ms.







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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BaseCurrency": "omnis",
  "OwnCurrency": "delectus",
  "SoldTotalBaseCurrency": 10304.592,
  "Sold": 181,
  "SoldTotalOwnCurrency": 20135.95,
  "Lost": 479,
  "LostTotalBaseCurrency": 26629.597999999998,
  "LostTotalOwnCurrency": 12065.9,
  "Open": 213,
  "OpenTotalBaseCurrency": 23467.392,
  "OpenTotalOwnCurrency": 9684.06,
  "OpenWeightedBaseCurrency": 11990.684,
  "OpenWeightedOwnCurrency": 26733.02,
  "PreviousOverdue": 891,
  "PreviousOverdueTotalBaseCurrency": 5663.138,
  "PreviousOverdueTotalOwnCurrency": 28262.412,
  "PreviousOverdueWeightedBaseCurrency": 31180.165999999997,
  "PreviousOverdueWeightedOwnCurrency": 30490.685999999998,
  "CurrentOverdue": 819,
  "CurrentOverdueTotalBaseCurrency": 4281.044,
  "CurrentOverdueTotalOwnCurrency": 2739.116,
  "CurrentOverdueWeightedBaseCurrency": 11752.5,
  "CurrentOverdueWeightedOwnCurrency": 7167.458,
  "FutureOpen": 473,
  "FutureOpenTotalBaseCurrency": 30907.507999999998,
  "FutureOpenTotalOwnCurrency": 16629.004,
  "FutureOpenWeightedBaseCurrency": 8402.253999999999,
  "FutureOpenWeightedOwnCurrency": 3654.2439999999997,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 890
    }
  }
}
```