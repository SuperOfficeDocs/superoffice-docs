```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Industry",
    "Operator": "oneOf",
    "Values": [
      "Technology",
      "Manufacturing"
    ],
    "DisplayValues": [
      "Technology",
      "Manufacturing"
    ],
    "ColumnInfo": null,
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "LastActivity",
        "Operator": "lessThan",
        "Values": [
          "90"
        ],
        "DisplayValues": [
          "Last 90 days"
        ],
        "ColumnInfo": null,
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 0,
        "InterOperator": "And",
        "UniqueHash": 3072
      }
    ],
    "InterParenthesis": 0,
    "InterOperator": "And",
    "UniqueHash": 2560
  }
]
```
