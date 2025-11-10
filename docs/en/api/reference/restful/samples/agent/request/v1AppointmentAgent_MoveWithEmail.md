```http!
POST /api/v1/Agents/Appointment/MoveWithEmail
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 520,
  "NewStartTime": "2015-08-20T10:10:58.6637867+02:00",
  "UpdateMode": "OnlyThis",
  "SendEmailToParticipants": false,
  "SmtpEMailConnectionInfo": null,
  "ImapEMailConnectionInfo": null
}
```