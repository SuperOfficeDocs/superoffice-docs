---
title: POST Agents/Sale/GetRecentSales
uid: v1SaleAgent_GetRecentSales
---

# POST Agents/Sale/GetRecentSales

```http
POST /api/v1/Agents/Sale/GetRecentSales
```

Returns the latest sales (that are sold) limited by their amount.


The result is sorted descending with the latest first. If the amount is -1, the amount restriction is omitted.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/GetRecentSales?$select=name,department,category/id
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

AmountLimit, Count 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AmountLimit | Integer |  |
| Count | Integer |  |

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Sale/GetRecentSales
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AmountLimit": 882,
  "Count": 305
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ContactName": "Morar Inc and Sons",
    "SaleDate": "2004-01-30T17:37:18.8862421+01:00",
    "SaleId": 402,
    "Probability": 199,
    "Title": "nulla",
    "Amount": 28447.318,
    "Currency": "non",
    "ProjectName": "Mayert LLC",
    "AssociateFullName": "Hosea Glover",
    "Description": "Horizontal reciprocal groupware",
    "Status": "Lost",
    "WeightedAmount": 27475.778,
    "ProjectId": 154,
    "EarningPercent": 8875.488,
    "Earning": 29299.766,
    "ContactId": 457,
    "AssociateId": 889,
    "PersonId": 351,
    "SaleTypeId": 183,
    "SaleTypeName": "Dach, Gaylord and Ziemann",
    "PersonFullName": "Ms. Ebony Barrows DDS",
    "Completed": "Completed",
    "ActiveErpLinks": 988,
    "NextDueDate": "2005-08-03T17:37:18.8872418+02:00",
    "Number": "1158781",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 364
      }
    }
  }
]
```