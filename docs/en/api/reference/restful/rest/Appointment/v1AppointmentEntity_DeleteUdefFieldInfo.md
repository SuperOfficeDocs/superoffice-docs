---
title: DEL Appointment/UdefLayout/{progidOrLabel}
uid: v1AppointmentEntity_DeleteUdefFieldInfo
generated: true
---

# DEL Appointment/UdefLayout/{progidOrLabel}

```http
DELETE /api/v1/Appointment/UdefLayout/{progidOrLabel}
```

Delete a AppointmentEntity user-defined field's details based on the prog-id or label.


Deletes the admin version of the field. The layout needs to be published before the change is visible.





| Path Part | Type | Description |
|-----------|------|-------------|
| progidOrLabel | string | The udef field id, case-sensitive prog-id, or field label. **Required** |



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

```http!
DELETE /api/v1/Appointment/UdefLayout/{progidOrLabel}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```