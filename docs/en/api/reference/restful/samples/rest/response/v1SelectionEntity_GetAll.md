```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "est",
  "value": [
    {
      "PrimaryKey": 2939,
      "EntityName": "person",
      "personId": 2939,
      "fullName": "Mateo Zulauf"
    },
    {
      "PrimaryKey": 418,
      "EntityName": "person",
      "personId": 418,
      "fullName": "Bernhard Hessel"
    }
  ]
}
```