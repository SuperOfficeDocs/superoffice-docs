---
title: POST Agents/Sale/GetSale
uid: v1SaleAgent_GetSale
generated: true
---

# POST Agents/Sale/GetSale

```http
POST /api/v1/Agents/Sale/GetSale
```

Gets a Sale object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| saleId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/GetSale?saleId=593
POST /api/v1/Agents/Sale/GetSale?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Sale

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
POST /api/v1/Agents/Sale/GetSale
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Wyman, Wisozk and Davis",
  "SaleDate": "1999-03-13T23:03:56.8961195+01:00",
  "SaleId": 133,
  "Probability": 794,
  "Title": "nisi",
  "Amount": 31280.453999999998,
  "Currency": "sed",
  "ProjectName": "Huel, Reichert and Jaskolski",
  "AssociateFullName": "Garrison Kemmer",
  "Description": "Expanded multi-tasking standardization",
  "Status": "Lost",
  "WeightedAmount": 11285.534,
  "ProjectId": 320,
  "EarningPercent": 20123.414,
  "Earning": 21997.546,
  "ContactId": 193,
  "AssociateId": 49,
  "PersonId": 802,
  "SaleTypeId": 464,
  "SaleTypeName": "Wunsch, Mann and Keebler",
  "PersonFullName": "Polly Ethel Ondricka Jr.",
  "Completed": "Completed",
  "ActiveErpLinks": 105,
  "NextDueDate": "2006-05-30T23:03:56.8966265+02:00",
  "Number": "943238",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 939
    }
  }
}
```