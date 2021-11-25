---
title: POST Agents/Marketing/DeleteFormEntity
id: v1MarketingAgent_DeleteFormEntity
---

# POST Agents/Marketing/DeleteFormEntity

```http
POST /api/v1/Agents/Marketing/DeleteFormEntity
```

Deletes the FormEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| FormEntityId | int32 | **Required** The id of the FormEntity to be deleted. |

```http
POST /api/v1/Agents/Marketing/DeleteFormEntity?FormEntityId=391
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