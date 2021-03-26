---
title: DEL List/ConsentPurpose/Items/{id}
id: v1ConsentPurposeList_DeleteConsentPurpose
---

# DEL List/ConsentPurpose/Items/{id}

```http
DELETE /api/v1/List/ConsentPurpose/Items/{id}
```

Marks the existing ConsentPurpose as deleted.

Calls the List agent service SaveConsentPurpose.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of ConsentPurpose to be marked as deleted. **Required** |



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