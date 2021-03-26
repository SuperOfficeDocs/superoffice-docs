---
title: POST Agents/CustomerService/DeleteCustomerCenterConfig
id: v1CustomerServiceAgent_DeleteCustomerCenterConfig
---

# POST Agents/CustomerService/DeleteCustomerCenterConfig

```http
POST /api/v1/Agents/CustomerService/DeleteCustomerCenterConfig
```

Deletes the CustomerCenterConfig







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| CustomerCenterConfigId | int32 | **Required** The id of the CustomerCenterConfig to be deleted. |

```http
POST /api/v1/Agents/CustomerService/DeleteCustomerCenterConfig?CustomerCenterConfigId=464
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | No Content |