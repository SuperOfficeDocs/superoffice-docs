---
title: GET Sale/{id}/Simple
uid: v1SaleEntity_Simple
generated: true
---

# GET Sale/{id}/Simple

```http
GET /api/v1/Sale/{id}/Simple
```

A simple Sale object.


This is a simpler, smaller variation of the full SaleEntity. Calls the Sale agent service GetSale.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the Sale to return. **Required** |



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

SaleEntity found.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity found. |
| 404 | Not Found. |

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
GET /api/v1/Sale/{id}/Simple
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 SaleEntity found.
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Jenkins, Funk and Shanahan",
  "SaleDate": "2007-08-22T17:54:08.5230811+02:00",
  "SaleId": 563,
  "Probability": 331,
  "Title": "animi",
  "Amount": 19321.11,
  "Currency": "illum",
  "ProjectName": "Krajcik Group",
  "AssociateFullName": "Miss Eleanore Effertz PhD",
  "Description": "Profit-focused local attitude",
  "Status": "Lost",
  "WeightedAmount": 513.976,
  "ProjectId": 555,
  "EarningPercent": 5757.1579999999994,
  "Earning": 6816.45,
  "ContactId": 286,
  "AssociateId": 128,
  "PersonId": 294,
  "SaleTypeId": 903,
  "SaleTypeName": "O'Reilly LLC",
  "PersonFullName": "Prof. Ara Hagenes",
  "Completed": "Completed",
  "ActiveErpLinks": 453,
  "NextDueDate": "2009-04-10T17:54:08.5230811+02:00",
  "Number": "1169544",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 422
    }
  }
}
```