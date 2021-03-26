---
title: POST Agents/Sale/GetSummaryByContact
id: v1SaleAgent_GetSummaryByContact
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
| ContactId | int32 |  |
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
POST /api/v1/Agents/Sale/GetSummaryByContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 844,
  "FromDate": "1999-07-02T16:48:30.6389064+02:00",
  "ToDate": "2015-02-01T16:48:30.6389064+01:00"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "BaseCurrency": "soluta",
  "OwnCurrency": "et",
  "SoldTotalBaseCurrency": 17794.852,
  "Sold": 247,
  "SoldTotalOwnCurrency": 27952.146,
  "Lost": 179,
  "LostTotalBaseCurrency": 8195.41,
  "LostTotalOwnCurrency": 29349.91,
  "Open": 645,
  "OpenTotalBaseCurrency": 30283.842,
  "OpenTotalOwnCurrency": 24548.622,
  "OpenWeightedBaseCurrency": 31108.084,
  "OpenWeightedOwnCurrency": 6882.264,
  "PreviousOverdue": 649,
  "PreviousOverdueTotalBaseCurrency": 23968.832,
  "PreviousOverdueTotalOwnCurrency": 7493.3939999999993,
  "PreviousOverdueWeightedBaseCurrency": 16281.13,
  "PreviousOverdueWeightedOwnCurrency": 3547.688,
  "CurrentOverdue": 932,
  "CurrentOverdueTotalBaseCurrency": 14124.938,
  "CurrentOverdueTotalOwnCurrency": 28488.059999999998,
  "CurrentOverdueWeightedBaseCurrency": 27174.914,
  "CurrentOverdueWeightedOwnCurrency": 27353.552,
  "FutureOpen": 923,
  "FutureOpenTotalBaseCurrency": 6161.4439999999995,
  "FutureOpenTotalOwnCurrency": 17343.556,
  "FutureOpenWeightedBaseCurrency": 7938.422,
  "FutureOpenWeightedOwnCurrency": 16462.902,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 829
    }
  }
}
```