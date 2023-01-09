---
title: DEL Appointment/{id}
uid: v1AppointmentEntity_DeleteAppointmentEntity
---

# DEL Appointment/{id}

```http
DELETE /api/v1/Appointment/{id}
```

Deletes the AppointmentEntity


Calls the Appointment agent service DeleteAppointmentEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The AppointmentEntity to be deleted. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response:

AppointmentEntity deleted.

| Response | Description |
|----------------|-------------|
| 204 | AppointmentEntity deleted. |
| 412 | Delete aborted because AppointmentEntity has changed since the requested If-Unmodified-Since timestamp. |

### Response body: RecurrenceInfo


## Sample request

```http!
DELETE /api/v1/Appointment/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 204 AppointmentEntity deleted.
Content-Type: application/json; charset=utf-8

null
```