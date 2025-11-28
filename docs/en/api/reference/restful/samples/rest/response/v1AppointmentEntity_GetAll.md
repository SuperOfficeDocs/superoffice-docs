```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "page=2",
  "value": [
    {
      "PrimaryKey": 3235,
      "EntityName": "appointment",
      "appointmentId": 3235,
      "title": "Quarterly Business Review"
    },
    {
      "PrimaryKey": 3003,
      "EntityName": "appointment",
      "appointmentId": 3003,
      "title": "Product Demo - Enterprise CRM"
    }
  ]
}
```