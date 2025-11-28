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
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Category",
        "Operator": "equals",
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
        "InterParenthesis": 169,
        "InterOperator": "And",
        "UniqueHash": 272
      }
    ],
    "InterParenthesis": 213,
    "InterOperator": "And",
    "UniqueHash": 884
  }
]
```
