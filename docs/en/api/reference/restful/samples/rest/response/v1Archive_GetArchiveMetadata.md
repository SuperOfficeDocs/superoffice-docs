```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "page=2",
  "value": [
    {
      "PrimaryKey": 6477,
      "EntityName": "person",
      "personId": 6477,
      "fullName": "Sarah Johnson"
    },
    {
      "PrimaryKey": 3803,
      "EntityName": "person",
      "personId": 3803,
      "fullName": "Michael Chen"
    }
  ]
}
```