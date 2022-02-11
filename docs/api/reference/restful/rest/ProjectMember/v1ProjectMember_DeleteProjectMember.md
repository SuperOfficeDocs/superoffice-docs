---
title: DEL ProjectMember/{id}
id: v1ProjectMember_DeleteProjectMember
---

# DEL ProjectMember/{id}

```http
DELETE /api/v1/ProjectMember/{id}
```

Deletes the ProjectMember

Calls the Project agent service DeleteProjectMember.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ProjectMember to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | ProjectMember deleted. |