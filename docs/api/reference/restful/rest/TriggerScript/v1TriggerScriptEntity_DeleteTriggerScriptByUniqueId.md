---
title: DEL TriggerScript/{id}
id: v1TriggerScriptEntity_DeleteTriggerScriptByUniqueId
---

# DEL TriggerScript/{id}

```http
DELETE /api/v1/TriggerScript/{triggerScriptUniqueId}
```

Delete a trigger CRMScript.



## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.




| Path Part | Type | Description |
|-----------|------|-------------|
| triggerScriptUniqueId | string | The unique id of the CRMScript to validate **Required** |



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