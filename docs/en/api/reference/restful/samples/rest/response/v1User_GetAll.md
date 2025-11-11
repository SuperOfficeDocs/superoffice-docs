```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "fuga",
  "value": [
    {
      "PrimaryKey": 7468,
      "EntityName": "person",
      "personId": 7468,
      "fullName": "Major Lockman"
    },
    {
      "PrimaryKey": 8867,
      "EntityName": "person",
      "personId": 8867,
      "fullName": "Dr. Elmore Pagac II"
    }
  ]
}
```