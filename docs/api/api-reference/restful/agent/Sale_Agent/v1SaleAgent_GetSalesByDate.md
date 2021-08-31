---
title: GetSalesByDate
id: v1SaleAgent_GetSalesByDate
---

# GetSalesByDate

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
| FromDate | date-time |  |
| ToDate | date-time |  |
| AmountLimit | int32 |  |
| Status | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Sale/GetSalesByDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2005-04-02T14:58:05.1876286+02:00",
  "ToDate": "2016-03-28T14:58:05.1876286+02:00",
  "AmountLimit": 398,
  "Status": "Lost"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ContactName": "Treutel-Zboncak",
    "SaleDate": "2006-06-02T14:58:05.1886281+02:00",
    "SaleId": 993,
    "Probability": 914,
    "Title": "excepturi",
    "Amount": 12739.71,
    "Currency": "et",
    "ProjectName": "Franecki-Zieme",
    "AssociateFullName": "Amie Cassin",
    "Description": "Pre-emptive multi-tasking approach",
    "Status": "Lost",
    "WeightedAmount": 22944.014,
    "ProjectId": 831,
    "EarningPercent": 19891.498,
    "Earning": 6709.894,
    "ContactId": 921,
    "AssociateId": 220,
    "PersonId": 656,
    "SaleTypeId": 422,
    "SaleTypeName": "Swift, Simonis and Cremin",
    "PersonFullName": "Abagail Kuvalis",
    "Completed": "Completed",
    "ActiveErpLinks": 853,
    "NextDueDate": "2014-04-04T14:58:05.1886281+02:00",
    "Number": "702513",
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
        "FieldLength": 849
      }
    }
  }
]
```