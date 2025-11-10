```http!
POST /api/v1/Agents/Find/PopulateRestrictionValues
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Restrictions": [
    {
      "Name": "Swift, Grimes and Hickle",
      "Operator": "porro",
      "Values": [
        "aut",
        "facere"
      ],
      "DisplayValues": [
        "quam",
        "blanditiis"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 888,
      "InterOperator": "And",
      "UniqueHash": 116
    }
  ]
}
```