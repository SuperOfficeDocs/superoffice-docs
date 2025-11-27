```http!
POST /api/v1/Agents/Appointment/RejectWithSmtpEmailConfirmation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 254,
  "RejectReason": "",
  "UpdateMode": "OnlyThis",
  "SmtpEMailConnectionInfo": null
}
```