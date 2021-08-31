---
title: DeleteProjectMember
id: v1ProjectAgent_DeleteProjectMember
---

# DeleteProjectMember

```http
POST /api/v1/Agents/Project/DeleteProjectMember
```

Deletes the ProjectMember







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| ProjectMemberId | int32 | **Required** The id of the ProjectMember to be deleted. |

```http
POST /api/v1/Agents/Project/DeleteProjectMember?ProjectMemberId=529
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