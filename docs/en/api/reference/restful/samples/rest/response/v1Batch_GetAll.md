```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "page=2",
  "value": [
    {
      "PrimaryKey": 9700,
      "EntityName": "batchTask",
      "batchTaskId": 9700,
      "name": "Weekly Report Generation"
    },
    {
      "PrimaryKey": 1337,
      "EntityName": "batchTask",
      "batchTaskId": 1337,
      "name": "Contact Sync Task"
    }
  ]
}
```