---
title: POST Agents/Quote/AddSaleTypeQuoteAttachment
id: v1QuoteAgent_AddSaleTypeQuoteAttachment
---

# POST Agents/Quote/AddSaleTypeQuoteAttachment

```http
POST /api/v1/Agents/Quote/AddSaleTypeQuoteAttachment
```

Adds a new quote attachment document to a sale type

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/AddSaleTypeQuoteAttachment?$select=name,department,category/id
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

SaleTypeId, DocumentId

| Property Name | Type |  Description |
|----------------|------|--------------|
| SaleTypeId | int32 |  |
| DocumentId | int32 |  |

## Response: int32

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: int32

## Sample Request

```http!
POST /api/v1/Agents/Quote/AddSaleTypeQuoteAttachment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SaleTypeId": 634,
  "DocumentId": 878
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

471
```
