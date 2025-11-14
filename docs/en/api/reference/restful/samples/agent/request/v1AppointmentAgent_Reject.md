```http!
POST /api/v1/Agents/Appointment/Reject
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 312,
  "RejectReason": "",
  "UpdateMode": "OnlyThis"
}
```