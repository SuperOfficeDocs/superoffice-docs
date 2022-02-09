---
title: DEL Sale/UdefLayout/{progidOrLabel}
id: v1SaleEntity_DeleteUdefFieldInfo
---

# DEL Sale/UdefLayout/{progidOrLabel}

```http
DELETE /api/v1/Sale/UdefLayout/{progidOrLabel}
```

Delete a SaleEntity user-defined field's details based on the prog-id or label.

Deletes the admin version of the field. The layout needs to be published before the change is visible.




| Path Part | Type | Description |
|-----------|------|-------------|
| progidOrLabel | string | The udef field id, case-sensitive prog-id, or field label. **Required** |



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