---
title: POST Agents/Sale/GetSummaryByAssociate
uid: v1SaleAgent_GetSummaryByAssociate
---

# POST Agents/Sale/GetSummaryByAssociate

```http
POST /api/v1/Agents/Sale/GetSummaryByAssociate
```

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/GetSummaryByAssociate?$select=name,department,category/id
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

AssociateId, FromDate, ToDate

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 |  |
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
POST /api/v1/Agents/Sale/GetSummaryByAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 476,
  "FromDate": "1995-12-03T11:10:27.8739785+01:00",
  "ToDate": "2021-12-09T11:10:27.8739785+01:00"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BaseCurrency": "assumenda",
  "OwnCurrency": "quibusdam",
  "SoldTotalBaseCurrency": 28967.561999999998,
  "Sold": 848,
  "SoldTotalOwnCurrency": 29688.381999999998,
  "Lost": 518,
  "LostTotalBaseCurrency": 15287.652,
  "LostTotalOwnCurrency": 19020.246,
  "Open": 567,
  "OpenTotalBaseCurrency": 9502.288,
  "OpenTotalOwnCurrency": 30857.363999999998,
  "OpenWeightedBaseCurrency": 833.644,
  "OpenWeightedOwnCurrency": 28083.773999999998,
  "PreviousOverdue": 524,
  "PreviousOverdueTotalBaseCurrency": 6872.862,
  "PreviousOverdueTotalOwnCurrency": 6872.862,
  "PreviousOverdueWeightedBaseCurrency": 20446.216,
  "PreviousOverdueWeightedOwnCurrency": 17540.998,
  "CurrentOverdue": 545,
  "CurrentOverdueTotalBaseCurrency": 3923.768,
  "CurrentOverdueTotalOwnCurrency": 25134.68,
  "CurrentOverdueWeightedBaseCurrency": 18349.57,
  "CurrentOverdueWeightedOwnCurrency": 13626.632,
  "FutureOpen": 100,
  "FutureOpenTotalBaseCurrency": 5227.512,
  "FutureOpenTotalOwnCurrency": 23426.649999999998,
  "FutureOpenWeightedBaseCurrency": 23050.57,
  "FutureOpenWeightedOwnCurrency": 20161.022,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 378
    }
  }
}
```
