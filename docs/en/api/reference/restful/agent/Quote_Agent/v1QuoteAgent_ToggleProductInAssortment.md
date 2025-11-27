---
title: POST Agents/Quote/ToggleProductInAssortment
uid: v1QuoteAgent_ToggleProductInAssortment
generated: true
content_type: reference
---

# POST Agents/Quote/ToggleProductInAssortment

```http
POST /api/v1/Agents/Quote/ToggleProductInAssortment
```

Toggles if the prdouct is in assortment or not


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/ToggleProductInAssortment?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ProductId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProductId | Integer |  |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/agent/request/v1QuoteAgent_ToggleProductInAssortment.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1QuoteAgent_ToggleProductInAssortment.md)]