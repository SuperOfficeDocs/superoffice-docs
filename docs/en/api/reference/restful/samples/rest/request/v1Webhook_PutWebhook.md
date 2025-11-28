```http!
PUT /api/v1/Webhook/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "WebhookId": 22,
  "Name": "Johnson-Brekke",
  "Events": [
    "non",
    "distinctio"
  ],
  "TargetUrl": "http://www.example.com/",
  "Secret": "corporis",
  "State": "Active",
  "Type": "officiis",
  "Headers": {
    "Headers1": "tempora",
    "Headers2": "aut"
  },
  "Properties": {
    "fieldName": {}
  },
  "Registered": "2018-05-23T14:34:02.9327773+02:00",
  "RegisteredAssociate": null,
  "Updated": "2012-01-20T14:34:02.9327773+01:00",
  "UpdatedAssociate": null,
  "ErrorsEmail": "kris@lebsackemmerich.biz"
}
```