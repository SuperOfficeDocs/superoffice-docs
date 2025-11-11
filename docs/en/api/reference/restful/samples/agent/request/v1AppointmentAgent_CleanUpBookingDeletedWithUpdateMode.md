```http!
POST /api/v1/Agents/Appointment/CleanUpBookingDeletedWithUpdateMode
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentIds": [
    870,
    525
  ],
  "UpdateMode": "OnlyThis"
}
```