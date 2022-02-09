---
title: DEL CRMScript/{id}
id: v1CRMScriptEntity_DeleteCRMScriptEntity
---

# DEL CRMScript/{id}

```http
DELETE /api/v1/CRMScript/{id}
```

Deletes the CRMScriptEntity



## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered. Calls the CRMScript agent service DeleteCRMScriptEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The CRMScriptEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | CRMScriptEntity deleted. |