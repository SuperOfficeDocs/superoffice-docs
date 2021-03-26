---
title: POST Agents/Audience/DeleteAudienceLayoutEntity
id: v1AudienceAgent_DeleteAudienceLayoutEntity
---

# POST Agents/Audience/DeleteAudienceLayoutEntity

```http
POST /api/v1/Agents/Audience/DeleteAudienceLayoutEntity
```

Deletes the AudienceLayoutEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| AudienceLayoutEntityId | int32 | **Required** The id of the AudienceLayoutEntity to be deleted. |

```http
POST /api/v1/Agents/Audience/DeleteAudienceLayoutEntity?AudienceLayoutEntityId=577
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