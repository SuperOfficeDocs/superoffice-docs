---
title: DEL Script/{uniqueIdentifier}
id: v1Script_DeleteCRMScriptByUniqueIdentifier
---

# DEL Script/{uniqueIdentifier}

```http
DELETE /api/v1/Script/{uniqueIdentifier}
```

Delete the CRMScript



## Online Restricted: ## The CRMScript agent is not available in Online by default. Access must be requested specifically when app is registered.




| Path Part | Type | Description |
|-----------|------|-------------|
| uniqueIdentifier | string | Global unique reference to script (independent of installation) **Required** |



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