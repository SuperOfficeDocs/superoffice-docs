---
title: POST Agents/EMail/DeleteEMailAccount
id: v1EMailAgent_DeleteEMailAccount
---

# POST Agents/EMail/DeleteEMailAccount

```http
POST /api/v1/Agents/EMail/DeleteEMailAccount
```

Deletes the EMailAccount



## Online Restricted: ## The EMail agent is not available in Online by default. Access must be requested specifically when app is registered.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| EMailAccountId | int32 | **Required** The id of the EMailAccount to be deleted. |

```http
POST /api/v1/Agents/EMail/DeleteEMailAccount?EMailAccountId=363
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