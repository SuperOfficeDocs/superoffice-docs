---
title: POST Agents/Sale/GetSummaryByContact
uid: v1SaleAgent_GetSummaryByContact
---

# POST Agents/Sale/GetSummaryByContact

```http
POST /api/v1/Agents/Sale/GetSummaryByContact
```









## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/GetSummaryByContact?$select=name,department,category/id
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

ContactId, FromDate, ToDate 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Sale/GetSummaryByContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 956,
  "FromDate": "2013-07-12T14:19:04.1567293+02:00",
  "ToDate": "1999-05-22T14:19:04.1567293+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BaseCurrency": "qui",
  "OwnCurrency": "autem",
  "SoldTotalBaseCurrency": 10583.518,
  "Sold": 483,
  "SoldTotalOwnCurrency": 15005.591999999999,
  "Lost": 461,
  "LostTotalBaseCurrency": 11812.046,
  "LostTotalOwnCurrency": 20386.67,
  "Open": 255,
  "OpenTotalBaseCurrency": 15707.608,
  "OpenTotalOwnCurrency": 30684.994,
  "OpenWeightedBaseCurrency": 18728.784,
  "OpenWeightedOwnCurrency": 9969.253999999999,
  "PreviousOverdue": 470,
  "PreviousOverdueTotalBaseCurrency": 4541.166,
  "PreviousOverdueTotalOwnCurrency": 7515.3319999999994,
  "PreviousOverdueWeightedBaseCurrency": 21395.818,
  "PreviousOverdueWeightedOwnCurrency": 17196.257999999998,
  "CurrentOverdue": 896,
  "CurrentOverdueTotalBaseCurrency": 25137.814,
  "CurrentOverdueTotalOwnCurrency": 23273.084,
  "CurrentOverdueWeightedBaseCurrency": 789.768,
  "CurrentOverdueWeightedOwnCurrency": 30847.962,
  "FutureOpen": 861,
  "FutureOpenTotalBaseCurrency": 24260.293999999998,
  "FutureOpenTotalOwnCurrency": 1121.972,
  "FutureOpenWeightedBaseCurrency": 131.628,
  "FutureOpenWeightedOwnCurrency": 19480.944,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 842
    }
  }
}
```