```http!
POST /api/v1/Agents/Diagnostics/ChangeLogSettings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "LogWarning": false,
  "LogInformation": false,
  "LogSuccessAudit": true,
  "LogFailureAudit": true,
  "LogToEventLog": false,
  "LogToSuperOffice": false,
  "LogToFile": false,
  "LogToTrace": true
}
```