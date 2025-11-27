```http!
POST /api/v1/Agents/Appointment/CreateDefaultAppointmentEntityFromSaleSuggestion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 470,
  "SaleId": 296,
  "CreateNow": true,
  "OwnerId": 226
}
```