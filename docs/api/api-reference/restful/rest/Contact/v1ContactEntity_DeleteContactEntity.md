---
title: DEL Contact/{id}
id: v1ContactEntity_DeleteContactEntity
---

# DEL Contact/{id}

```http
DELETE /api/v1/Contact/{id}
```

Deletes the ContactEntity

Calls the Contact agent service DeleteContactEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response


| Response | Description |
|----------------|-------------|
| 204 | ContactEntity deleted. |
| 412 | Delete aborted because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |