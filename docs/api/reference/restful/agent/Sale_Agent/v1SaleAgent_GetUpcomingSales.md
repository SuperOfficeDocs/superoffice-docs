---
title: POST Agents/Sale/GetUpcomingSales
id: v1SaleAgent_GetUpcomingSales
---

# POST Agents/Sale/GetUpcomingSales

```http
POST /api/v1/Agents/Sale/GetUpcomingSales
```

Returns all open sales, sorted descending with the latest first.

If the weigthed amount is -1, the amount restriction is omitted.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Sale/GetUpcomingSales?$select=name,department,category/id
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

WeightedAmountLimit, Count 

| Property Name | Type |  Description |
|----------------|------|--------------|
| WeightedAmountLimit | int32 |  |
| Count | int32 |  |


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
POST /api/v1/Agents/Sale/GetUpcomingSales
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WeightedAmountLimit": 183,
  "Count": 150
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ContactName": "Crooks LLC",
    "SaleDate": "1999-05-18T18:28:50.1774438+02:00",
    "SaleId": 77,
    "Probability": 192,
    "Title": "maxime",
    "Amount": 26275.456,
    "Currency": "eos",
    "ProjectName": "Bode-Kautzer",
    "AssociateFullName": "Aron Reinger",
    "Description": "Persevering scalable standardization",
    "Status": "Lost",
    "WeightedAmount": 24254.025999999998,
    "ProjectId": 508,
    "EarningPercent": 3917.5,
    "Earning": 20104.61,
    "ContactId": 703,
    "AssociateId": 732,
    "PersonId": 52,
    "SaleTypeId": 711,
    "SaleTypeName": "Little, McGlynn and Farrell",
    "PersonFullName": "Vanessa Zulauf",
    "Completed": "Completed",
    "ActiveErpLinks": 872,
    "NextDueDate": "2016-05-09T18:28:50.1784416+02:00",
    "Number": "1229088",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "synergize leading-edge bandwidth"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 644
      }
    }
  }
]
```