```http!
PUT /api/v1/Selection/{selectionId}/Criteria
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Bernier, Abernathy and Roberts",
    "Operator": "est",
    "Values": [
      "optio",
      "illo"
    ],
    "DisplayValues": [
      "sed",
      "et"
    ],
    "ColumnInfo": null,
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Hilpert-Kub",
        "Operator": "illum",
        "Values": [
          "commodi",
          "illo"
        ],
        "DisplayValues": [
          "voluptatem",
          "velit"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 548,
        "InterOperator": "And",
        "UniqueHash": 755
      }
    ],
    "InterParenthesis": 912,
    "InterOperator": "And",
    "UniqueHash": 437
  }
]
```