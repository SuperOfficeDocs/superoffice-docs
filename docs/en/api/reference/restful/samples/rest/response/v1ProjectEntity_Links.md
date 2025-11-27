```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "sed",
  "value": [
    {
      "PrimaryKey": 8787,
      "EntityName": "person",
      "personId": 8787,
      "fullName": "Neal Jones"
    },
    {
      "PrimaryKey": 3584,
      "EntityName": "person",
      "personId": 3584,
      "fullName": "Jessica Abbott Sr."
    }
  ]
}
```