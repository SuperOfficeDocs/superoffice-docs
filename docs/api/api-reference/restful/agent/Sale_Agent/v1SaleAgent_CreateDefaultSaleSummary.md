---
title: POST Agents/Sale/CreateDefaultSaleSummary
id: v1SaleAgent_CreateDefaultSaleSummary
---

# POST Agents/Sale/CreateDefaultSaleSummary

```http
POST /api/v1/Agents/Sale/CreateDefaultSaleSummary
```

Set default values into a new SaleSummary.

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

Carrier object for SaleSummary.
Services for the SaleSummary Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ISaleAgent">Sale Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Sale/CreateDefaultSaleSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BaseCurrency": "similique",
  "OwnCurrency": "dolorum",
  "SoldTotalBaseCurrency": 8254.956,
  "Sold": 646,
  "SoldTotalOwnCurrency": 21201.51,
  "Lost": 308,
  "LostTotalBaseCurrency": 5619.262,
  "LostTotalOwnCurrency": 27002.543999999998,
  "Open": 752,
  "OpenTotalBaseCurrency": 19032.782,
  "OpenTotalOwnCurrency": 27980.352,
  "OpenWeightedBaseCurrency": 13573.354,
  "OpenWeightedOwnCurrency": 17240.134,
  "PreviousOverdue": 62,
  "PreviousOverdueTotalBaseCurrency": 30045.658,
  "PreviousOverdueTotalOwnCurrency": 2977.2999999999997,
  "PreviousOverdueWeightedBaseCurrency": 29030.242,
  "PreviousOverdueWeightedOwnCurrency": 17995.428,
  "CurrentOverdue": 996,
  "CurrentOverdueTotalBaseCurrency": 11116.297999999999,
  "CurrentOverdueTotalOwnCurrency": 5973.4039999999995,
  "CurrentOverdueWeightedBaseCurrency": 25219.298,
  "CurrentOverdueWeightedOwnCurrency": 1642.216,
  "FutureOpen": 213,
  "FutureOpenTotalBaseCurrency": 12727.173999999999,
  "FutureOpenTotalOwnCurrency": 25701.933999999997,
  "FutureOpenWeightedBaseCurrency": 27350.417999999998,
  "FutureOpenWeightedOwnCurrency": 30443.676,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "repurpose distributed e-commerce"
      },
      "FieldType": "System.String",
      "FieldLength": 870
    }
  }
}
```