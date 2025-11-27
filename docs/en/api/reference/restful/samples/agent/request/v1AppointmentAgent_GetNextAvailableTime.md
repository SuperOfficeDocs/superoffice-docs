```http!
POST /api/v1/Agents/Appointment/GetNextAvailableTime
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Associates": [
    165,
    660
  ],
  "StartTime": "2021-07-27T10:10:58.4174244+02:00",
  "EndTime": "1999-03-15T10:10:58.4174244+01:00",
  "Count": 676,
  "IsAllDay": true
}
```