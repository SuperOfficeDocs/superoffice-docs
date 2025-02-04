---
title: POST Agents/Sale/GetSalesByDate
uid: v1SaleAgent_GetSalesByDate
generated: true
---

# POST Agents/Sale/GetSalesByDate

```http
POST /api/v1/Agents/Sale/GetSalesByDate
```

Returns all sales within a time period.


The sales array can be limited by amount and status.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/GetSalesByDate?$select=name,department,category/id
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

FromDate, ToDate, AmountLimit, Status 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FromDate | String |  |
| ToDate | String |  |
| AmountLimit | Integer |  |
| Status | String |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactName | string | Contact name |
| SaleDate | date-time | (expected / lost / won) sales date |
| SaleId | int32 | Primary key |
| Probability | int32 | Actual probability, may differ from the one in the list |
| Title | string | Sale heading (short description?) |
| Amount | double | Total sale amount |
| Currency | string | Currency the sale was made in. |
| ProjectName | string | Project name |
| AssociateFullName | string | The sale's owner |
| Description | string | The sales description |
| Status | string | The sale's status, indicating wether the sale is open, sold or lost. |
| WeightedAmount | double | The weighted amount ( amount *  probability / 100) |
| ProjectId | int32 | Optional project reference |
| EarningPercent | double | Earning as percent of total |
| Earning | double | Earning on sale |
| ContactId | int32 | Optional contact reference |
| AssociateId | int32 | The sale's owner id |
| PersonId | int32 | The sale's contact persons id |
| SaleTypeId | int32 | The sale's type id |
| SaleTypeName | string | The sale's type name |
| PersonFullName | string | The name of the person this sale belongs to. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveErpLinks | int32 | The number of active erp links |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Number | string | Alphanumeric user field |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Sale/GetSalesByDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2003-10-26T13:13:23.8729256+01:00",
  "ToDate": "2005-01-03T13:13:23.8729256+01:00",
  "AmountLimit": 983,
  "Status": "Lost"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ContactName": "McLaughlin-Russel",
    "SaleDate": "2022-08-12T13:13:23.8839994+02:00",
    "SaleId": 183,
    "Probability": 825,
    "Title": "nulla",
    "Amount": 19051.586,
    "Currency": "error",
    "ProjectName": "Johns-Wiza",
    "AssociateFullName": "Joshuah Mann",
    "Description": "Integrated systematic infrastructure",
    "Status": "Lost",
    "WeightedAmount": 14485.348,
    "ProjectId": 706,
    "EarningPercent": 12203.796,
    "Earning": 2027.6979999999999,
    "ContactId": 920,
    "AssociateId": 716,
    "PersonId": 202,
    "SaleTypeId": 582,
    "SaleTypeName": "Hilll LLC",
    "PersonFullName": "Millie Eldridge Ankunding PhD",
    "Completed": "Completed",
    "ActiveErpLinks": 198,
    "NextDueDate": "2010-01-10T13:13:23.8839994+01:00",
    "Number": "1194790",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 575
      }
    }
  }
]
```