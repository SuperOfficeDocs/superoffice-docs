```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "odata.metadata": "https://www.example.com/api/v1/archive$metadata",
  "odata.nextLink": "page=2",
  "value": [
    {
      "PrimaryKey": 7788,
      "EntityName": "document",
      "documentId": 7788,
      "name": "Meeting Minutes - Q4 Review"
    },
    {
      "PrimaryKey": 1525,
      "EntityName": "sale",
      "saleId": 1525,
      "name": "Enterprise CRM Deal"
    }
  ]
}
```