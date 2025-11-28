```http!
PUT /api/v1/Selection/{selectionId}/Criteria
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Moore Inc and Sons",
    "Operator": "id",
    "Values": [
      "qui",
      "aliquid"
    ],
    "DisplayValues": [
      "adipisci",
      "excepturi"
    ],
    "ColumnInfo": null,
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "Balistreri-Barton",
        "Operator": "accusamus",
        "Values": [
          "fugiat",
          "odio"
        ],
        "DisplayValues": [
          "iste",
          "repellat"
        ],
        "ColumnInfo": null,
        "IsActive": true,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 331,
        "InterOperator": "And",
        "UniqueHash": 765
      }
    ],
    "InterParenthesis": 714,
    "InterOperator": "And",
    "UniqueHash": 472
  }
]
```