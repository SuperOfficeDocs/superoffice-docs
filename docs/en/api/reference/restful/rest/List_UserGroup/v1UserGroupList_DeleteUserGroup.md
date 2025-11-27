---
title: DEL List/UserGroup/Items/{id}
uid: v1UserGroupList_DeleteUserGroup
generated: true
content_type: reference
---

# DEL List/UserGroup/Items/{id}

```http
DELETE /api/v1/List/UserGroup/Items/{id}
```

Marks the existing UserGroup as deleted.


Calls the User agent service SaveUserGroup.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of UserGroup to be marked as deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

[!include[sample request](../../samples/rest/request/v1UserGroupList_DeleteUserGroup.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1UserGroupList_DeleteUserGroup.md)]