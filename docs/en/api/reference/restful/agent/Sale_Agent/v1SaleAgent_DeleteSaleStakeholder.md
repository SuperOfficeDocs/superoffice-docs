---
title: POST Agents/Sale/DeleteSaleStakeholder
uid: v1SaleAgent_DeleteSaleStakeholder
generated: true
content_type: reference
---

# POST Agents/Sale/DeleteSaleStakeholder

```http
POST /api/v1/Agents/Sale/DeleteSaleStakeholder
```

Deletes the SaleStakeholder


NsApiSlow threshold: 1000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| saleStakeholderId | int32 | **Required** The identity of the SaleStakeholder |

```http
POST /api/v1/Agents/Sale/DeleteSaleStakeholder?saleStakeholderId=48
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Sale/DeleteSaleStakeholder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```