---
title: POST Agents/Sale/GetSummaryByAssociate
id: v1SaleAgent_GetSummaryByAssociate
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
POST /api/v1/Agents/Sale/GetSummaryByAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 2,
  "FromDate": "2009-12-03T16:48:30.6369375+01:00",
  "ToDate": "2003-12-30T16:48:30.6369375+01:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BaseCurrency": "unde",
  "OwnCurrency": "amet",
  "SoldTotalBaseCurrency": 28707.44,
  "Sold": 886,
  "SoldTotalOwnCurrency": 6014.146,
  "Lost": 246,
  "LostTotalBaseCurrency": 4212.096,
  "LostTotalOwnCurrency": 4638.32,
  "Open": 307,
  "OpenTotalBaseCurrency": 1833.3899999999999,
  "OpenTotalOwnCurrency": 25495.09,
  "OpenWeightedBaseCurrency": 17747.842,
  "OpenWeightedOwnCurrency": 23815.266,
  "PreviousOverdue": 680,
  "PreviousOverdueTotalBaseCurrency": 21665.342,
  "PreviousOverdueTotalOwnCurrency": 30550.232,
  "PreviousOverdueWeightedBaseCurrency": 10652.466,
  "PreviousOverdueWeightedOwnCurrency": 31264.784,
  "CurrentOverdue": 264,
  "CurrentOverdueTotalBaseCurrency": 7355.498,
  "CurrentOverdueTotalOwnCurrency": 1372.692,
  "CurrentOverdueWeightedBaseCurrency": 3475.6059999999998,
  "CurrentOverdueWeightedOwnCurrency": 22100.968,
  "FutureOpen": 90,
  "FutureOpenTotalBaseCurrency": 2441.386,
  "FutureOpenTotalOwnCurrency": 30139.678,
  "FutureOpenWeightedBaseCurrency": 28698.038,
  "FutureOpenWeightedOwnCurrency": 28770.12,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "empower extensible web services"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 651
    }
  }
}
```