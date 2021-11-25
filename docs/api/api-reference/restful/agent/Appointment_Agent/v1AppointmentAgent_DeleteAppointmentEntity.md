---
title: POST Agents/Appointment/DeleteAppointmentEntity
id: v1AppointmentAgent_DeleteAppointmentEntity
---

# POST Agents/Appointment/DeleteAppointmentEntity

```http
POST /api/v1/Agents/Appointment/DeleteAppointmentEntity
```

Deletes the AppointmentEntity







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| AppointmentEntityId | int32 | **Required** The id of the AppointmentEntity to be deleted. |

```http
POST /api/v1/Agents/Appointment/DeleteAppointmentEntity?AppointmentEntityId=46
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