```http!
POST /api/v1/Agents/Appointment/AcceptWithSmtpEmailConfirmation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 169,
  "UpdateMode": "OnlyThis",
  "SmtpEMailConnectionInfo": null
}
```