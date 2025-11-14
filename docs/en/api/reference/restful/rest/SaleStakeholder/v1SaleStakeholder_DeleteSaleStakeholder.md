---
title: DEL SaleStakeholder/{id}
uid: v1SaleStakeholder_DeleteSaleStakeholder
generated: true
content_type: reference
---

# DEL SaleStakeholder/{id}

```http
DELETE /api/v1/SaleStakeholder/{id}
```

Deletes the SaleStakeholder


Calls the Sale agent service DeleteSaleStakeholder.
NsApiSlow threshold: 1000 ms.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleStakeholder to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

SaleStakeholder deleted.

| Response | Description |
|----------------|-------------|
| 204 | SaleStakeholder deleted. |

### Response body: TimeZoneData


## Sample request

```http!
DELETE /api/v1/SaleStakeholder/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 SaleStakeholder deleted.
Content-Type: application/json; charset=utf-8

null
```