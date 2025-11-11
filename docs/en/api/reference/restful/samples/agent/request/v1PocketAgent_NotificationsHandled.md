```http!
POST /api/v1/Agents/Pocket/NotificationsHandled
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "NotificationEvents": [
    {
      "Type": "AppointmentCancelled",
      "Id": 187
    },
    {
      "Type": "AppointmentCancelled",
      "Id": 187
    }
  ]
}
```