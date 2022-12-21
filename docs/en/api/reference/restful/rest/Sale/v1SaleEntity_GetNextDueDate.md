---
title: GET Sale/{id}/NextDueDate
uid: v1SaleEntity_GetNextDueDate
---

# GET Sale/{id}/NextDueDate

```http
GET /api/v1/Sale/{saleId}/NextDueDate
```

Gets the next due date for a sale.


The next due date is the next future appointment that is not completed.





| Path Part | Type | Description |
|-----------|------|-------------|
| saleId | int32 | Sale id **Required** |



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


## Response: date-time

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: date-time


## Sample request

```http!
GET /api/v1/Sale/{saleId}/NextDueDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

"2008-03-12T02:49:51.4894333+01:00"
```