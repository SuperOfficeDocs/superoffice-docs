---
title: POST Agents/ErpSync/DeleteErpSyncConnectorEntity
id: v1ErpSyncAgent_DeleteErpSyncConnectorEntity
---

# POST Agents/ErpSync/DeleteErpSyncConnectorEntity

```http
POST /api/v1/Agents/ErpSync/DeleteErpSyncConnectorEntity
```

Deletes the ErpSyncConnectorEntity



## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ErpSyncConnectorEntityId | int32 | **Required** The id of the ErpSyncConnectorEntity to be deleted. |

```http
POST /api/v1/Agents/ErpSync/DeleteErpSyncConnectorEntity?ErpSyncConnectorEntityId=741
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