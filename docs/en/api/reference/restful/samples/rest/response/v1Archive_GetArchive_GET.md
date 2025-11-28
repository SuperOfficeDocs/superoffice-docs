```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "page=2",
  "value": [
    {
      "PrimaryKey": 4966,
      "EntityName": "person",
      "personId": 4966,
      "fullName": "Lisa Anderson"
    },
    {
      "PrimaryKey": 1140,
      "EntityName": "person",
      "personId": 1140,
      "fullName": "David Martinez"
    }
  ]
}
```