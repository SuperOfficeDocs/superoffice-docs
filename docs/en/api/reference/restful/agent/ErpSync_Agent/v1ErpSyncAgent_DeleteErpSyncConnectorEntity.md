---
title: POST Agents/ErpSync/DeleteErpSyncConnectorEntity
uid: v1ErpSyncAgent_DeleteErpSyncConnectorEntity
generated: true
content_type: reference
---

# POST Agents/ErpSync/DeleteErpSyncConnectorEntity

```http
POST /api/v1/Agents/ErpSync/DeleteErpSyncConnectorEntity
```

Deletes the ErpSyncConnectorEntity


NsApiSlow threshold: 5000 ms.


## Online Restricted: ## The ErpSync agent is not available in Online by default. Access must be requested specifically when app is registered. Intended for ERP integration apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| erpSyncConnectorEntityId | int32 | **Required** The identity of the ErpSyncConnectorEntity |

```http
POST /api/v1/Agents/ErpSync/DeleteErpSyncConnectorEntity?erpSyncConnectorEntityId=370
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

[!include[sample request](../../samples/agent/request/v1ErpSyncAgent_DeleteErpSyncConnectorEntity.md)]

## Sample response

[!include[sample response](../../samples/agent/response/v1ErpSyncAgent_DeleteErpSyncConnectorEntity.md)]