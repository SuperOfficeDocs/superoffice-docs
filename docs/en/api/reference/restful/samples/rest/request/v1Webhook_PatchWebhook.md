```http!
PATCH /api/v1/Webhook/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "ipsum",
    "value": {}
  },
  {
    "op": "add",
    "path": "ipsum",
    "value": {}
  }
]
```