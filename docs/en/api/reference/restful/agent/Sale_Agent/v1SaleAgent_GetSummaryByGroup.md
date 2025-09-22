---
title: POST Agents/Sale/GetSummaryByGroup
uid: v1SaleAgent_GetSummaryByGroup
generated: true
content_type: reference
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "GroupId": 344,
  "FromDate": "2003-12-09T11:24:48.6095199+01:00",
  "ToDate": "2008-10-10T11:24:48.6095199+02:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BaseCurrency": "et",
  "OwnCurrency": "cumque",
  "SoldTotalBaseCurrency": 20258.176,
  "Sold": 245,
  "SoldTotalOwnCurrency": 5133.492,
  "Lost": 47,
  "LostTotalBaseCurrency": 17910.809999999998,
  "LostTotalOwnCurrency": 12272.743999999999,
  "Open": 470,
  "OpenTotalBaseCurrency": 29807.474,
  "OpenTotalOwnCurrency": 930.798,
  "OpenWeightedBaseCurrency": 6832.12,
  "OpenWeightedOwnCurrency": 26494.836,
  "PreviousOverdue": 861,
  "PreviousOverdueTotalBaseCurrency": 30359.057999999997,
  "PreviousOverdueTotalOwnCurrency": 27795.446,
  "PreviousOverdueWeightedBaseCurrency": 18371.507999999998,
  "PreviousOverdueWeightedOwnCurrency": 22881.334,
  "CurrentOverdue": 618,
  "CurrentOverdueTotalBaseCurrency": 18023.634,
  "CurrentOverdueTotalOwnCurrency": 22978.487999999998,
  "CurrentOverdueWeightedBaseCurrency": 7693.9699999999993,
  "CurrentOverdueWeightedOwnCurrency": 10837.372,
  "FutureOpen": 650,
  "FutureOpenTotalBaseCurrency": 14833.222,
  "FutureOpenTotalOwnCurrency": 30810.354,
  "FutureOpenWeightedBaseCurrency": 6506.184,
  "FutureOpenWeightedOwnCurrency": 17268.34,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 582
    }
  }
}
```