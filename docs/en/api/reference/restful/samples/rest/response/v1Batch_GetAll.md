```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "est",
  "value": [
    {
      "PrimaryKey": 9700,
      "EntityName": "person",
      "personId": 9700,
      "fullName": "Mrs. Garry Ramiro Reichert"
    },
    {
      "PrimaryKey": 1337,
      "EntityName": "person",
      "personId": 1337,
      "fullName": "Kyra Aufderhar"
    }
  ]
}
```