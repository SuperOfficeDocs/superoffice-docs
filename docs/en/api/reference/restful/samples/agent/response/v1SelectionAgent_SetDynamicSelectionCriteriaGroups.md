```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Geographic and Business Filters",
    "Description": "Combined geographic and business criteria",
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
    "Name": "Revenue Criteria",
    "Description": "Filter by company revenue",
    "Rank": 2,
    "Restrictions": [
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
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 160,
        "InterOperator": "And",
        "UniqueHash": 765
      }
    ]
  }
]
```
