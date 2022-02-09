---
title: POST Agents/Configuration/DeleteDiaryViewEntity
id: v1ConfigurationAgent_DeleteDiaryViewEntity
---

# POST Agents/Configuration/DeleteDiaryViewEntity

```http
POST /api/v1/Agents/Configuration/DeleteDiaryViewEntity
```

Deletes the DiaryViewEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| DiaryViewEntityId | int32 | **Required** The id of the DiaryViewEntity to be deleted. |

```http
POST /api/v1/Agents/Configuration/DeleteDiaryViewEntity?DiaryViewEntityId=103
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