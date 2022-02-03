---
title: POST Agents/CRMScript/DeleteCRMScriptEntity
id: v1CRMScriptAgent_DeleteCRMScriptEntity
---

# POST Agents/CRMScript/DeleteCRMScriptEntity

```http
POST /api/v1/Agents/CRMScript/DeleteCRMScriptEntity
```

Deletes the CRMScriptEntity



## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| CRMScriptEntityId | int32 | **Required** The id of the CRMScriptEntity to be deleted. |

```http
POST /api/v1/Agents/CRMScript/DeleteCRMScriptEntity?CRMScriptEntityId=142
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