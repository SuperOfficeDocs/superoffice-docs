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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2003-06-14T13:38:14.0928295+02:00",
  "ToDate": "2022-08-04T13:38:14.0928295+02:00",
  "AmountLimit": 474,
  "Status": "Lost"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ContactName": "Bernier, Leannon and Smith",
    "SaleDate": "2005-05-12T13:38:14.1084486+02:00",
    "SaleId": 25,
    "Probability": 360,
    "Title": "et",
    "Amount": 16268.594,
    "Currency": "eum",
    "ProjectName": "Hyatt, Windler and Grady",
    "AssociateFullName": "Joy Pfannerstill",
    "Description": "Right-sized homogeneous support",
    "Status": "Lost",
    "WeightedAmount": 28566.41,
    "ProjectId": 684,
    "EarningPercent": 20643.658,
    "Earning": 21549.384,
    "ContactId": 907,
    "AssociateId": 551,
    "PersonId": 905,
    "SaleTypeId": 651,
    "SaleTypeName": "Schoen-Kuhn",
    "PersonFullName": "Ms. Elbert Mraz Jr.",
    "Completed": "Completed",
    "ActiveErpLinks": 358,
    "NextDueDate": "2020-03-03T13:38:14.1084486+01:00",
    "Number": "1534714",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 704
      }
    }
  }
]
```