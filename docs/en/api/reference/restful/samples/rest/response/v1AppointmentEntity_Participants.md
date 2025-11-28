```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "page=2",
  "value": [
    {
      "PrimaryKey": 9614,
      "EntityName": "person",
      "personId": 9614,
      "fullName": "Sarah Johnson"
    },
    {
      "PrimaryKey": 6253,
      "EntityName": "person",
      "personId": 6253,
      "fullName": "Michael Chen"
    }
  ]
}
```