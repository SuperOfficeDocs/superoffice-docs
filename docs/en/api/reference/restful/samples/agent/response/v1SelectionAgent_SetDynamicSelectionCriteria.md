```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Country",
    "Operator": "oneOf",
    "Values": [
      "Norway",
      "Sweden",
      "Denmark"
    ],
    "DisplayValues": [
      "Norway",
      "Sweden",
      "Denmark"
    ],
    "ColumnInfo": null,
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "Category",
        "Operator": "oneOf",
        "Values": [
          "Customer",
          "Prospect"
        ],
        "DisplayValues": [
          "Customer",
          "Prospect"
        ],
        "ColumnInfo": null,
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 0,
        "InterOperator": "And",
        "UniqueHash": 2048
      }
    ],
    "InterParenthesis": 0,
    "InterOperator": "And",
    "UniqueHash": 1024
  }
]
```
