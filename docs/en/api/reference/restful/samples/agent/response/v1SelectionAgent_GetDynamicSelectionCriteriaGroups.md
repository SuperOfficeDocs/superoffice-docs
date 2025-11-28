```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Geographic Filter",
    "Description": "Filter by Nordic countries",
    "Rank": 1,
    "Restrictions": [
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
          {},
          {}
        ],
        "InterParenthesis": 0,
        "InterOperator": "And",
        "UniqueHash": 1024
      }
    ]
  },
  {
    "Name": "Business Criteria",
    "Description": "Filter by customer category and revenue",
    "Rank": 2,
    "Restrictions": [
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
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 264,
        "InterOperator": "And",
        "UniqueHash": 130
      }
    ]
  }
]
```
