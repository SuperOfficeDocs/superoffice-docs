```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Revenue",
    "Operator": "greaterThan",
    "Values": [
      "50000"
    ],
    "DisplayValues": [
      "$50,000"
    ],
    "ColumnInfo": null,
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "EmployeeCount",
        "Operator": "greaterThan",
        "Values": [
          "10"
        ],
        "DisplayValues": [
          "10 employees"
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
