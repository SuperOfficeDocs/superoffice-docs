---
title: POST Agents/Sale/GetSummaryByGroup
uid: v1SaleAgent_GetSummaryByGroup
generated: true
---

# POST Agents/Sale/GetSummaryByGroup

```http
POST /api/v1/Agents/Sale/GetSummaryByGroup
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/GetSummaryByGroup?$select=name,department,category/id
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

GroupId, FromDate, ToDate 

| Property Name | Type |  Description |
|----------------|------|--------------|
| GroupId | Integer |  |
| FromDate | String |  |
| ToDate | String |  |

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
POST /api/v1/Agents/Sale/GetSummaryByGroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "GroupId": 724,
  "FromDate": "2009-06-17T12:01:28.275316+02:00",
  "ToDate": "2008-02-09T12:01:28.275316+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BaseCurrency": "dignissimos",
  "OwnCurrency": "quasi",
  "SoldTotalBaseCurrency": 6615.874,
  "Sold": 889,
  "SoldTotalOwnCurrency": 19747.334,
  "Lost": 640,
  "LostTotalBaseCurrency": 26494.836,
  "LostTotalOwnCurrency": 26579.453999999998,
  "Open": 676,
  "OpenTotalBaseCurrency": 30578.438,
  "OpenTotalOwnCurrency": 11247.926,
  "OpenWeightedBaseCurrency": 17625.615999999998,
  "OpenWeightedOwnCurrency": 12250.806,
  "PreviousOverdue": 774,
  "PreviousOverdueTotalBaseCurrency": 20844.234,
  "PreviousOverdueTotalOwnCurrency": 18167.798,
  "PreviousOverdueWeightedBaseCurrency": 11222.854,
  "PreviousOverdueWeightedOwnCurrency": 24291.634,
  "CurrentOverdue": 673,
  "CurrentOverdueTotalBaseCurrency": 15682.536,
  "CurrentOverdueTotalOwnCurrency": 13463.663999999999,
  "CurrentOverdueWeightedBaseCurrency": 17146.113999999998,
  "CurrentOverdueWeightedOwnCurrency": 20273.845999999998,
  "FutureOpen": 917,
  "FutureOpenTotalBaseCurrency": 1896.07,
  "FutureOpenTotalOwnCurrency": 4785.6179999999995,
  "FutureOpenWeightedBaseCurrency": 20057.6,
  "FutureOpenWeightedOwnCurrency": 2391.2419999999997,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 387
    }
  }
}
```