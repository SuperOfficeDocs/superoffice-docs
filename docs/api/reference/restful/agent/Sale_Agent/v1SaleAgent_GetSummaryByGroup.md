---
title: POST Agents/Sale/GetSummaryByGroup
uid: v1SaleAgent_GetSummaryByGroup
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
| GroupId | int32 |  |
| FromDate | date-time |  |
| ToDate | date-time |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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

## Sample request

```http!
POST /api/v1/Agents/Sale/GetSummaryByGroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "GroupId": 725,
  "FromDate": "2012-07-01T11:10:27.8749768+02:00",
  "ToDate": "2015-09-28T11:10:27.8749768+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BaseCurrency": "unde",
  "OwnCurrency": "minus",
  "SoldTotalBaseCurrency": 16889.126,
  "Sold": 822,
  "SoldTotalOwnCurrency": 15789.091999999999,
  "Lost": 914,
  "LostTotalBaseCurrency": 1905.472,
  "LostTotalOwnCurrency": 30167.884,
  "Open": 165,
  "OpenTotalBaseCurrency": 1576.402,
  "OpenTotalOwnCurrency": 319.668,
  "OpenWeightedBaseCurrency": 25441.811999999998,
  "OpenWeightedOwnCurrency": 11304.338,
  "PreviousOverdue": 540,
  "PreviousOverdueTotalBaseCurrency": 30011.183999999997,
  "PreviousOverdueTotalOwnCurrency": 3829.748,
  "PreviousOverdueWeightedBaseCurrency": 27695.158,
  "PreviousOverdueWeightedOwnCurrency": 26864.647999999997,
  "CurrentOverdue": 10,
  "CurrentOverdueTotalBaseCurrency": 2422.582,
  "CurrentOverdueTotalOwnCurrency": 908.86,
  "CurrentOverdueWeightedBaseCurrency": 1275.538,
  "CurrentOverdueWeightedOwnCurrency": 28152.721999999998,
  "FutureOpen": 943,
  "FutureOpenTotalBaseCurrency": 23063.106,
  "FutureOpenTotalOwnCurrency": 29694.649999999998,
  "FutureOpenWeightedBaseCurrency": 16046.08,
  "FutureOpenWeightedOwnCurrency": 27801.714,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 466
    }
  }
}
```
