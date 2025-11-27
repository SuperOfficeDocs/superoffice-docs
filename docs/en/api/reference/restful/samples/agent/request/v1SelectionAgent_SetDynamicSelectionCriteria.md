```http!
POST /api/v1/Agents/Selection/SetDynamicSelectionCriteria
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 199,
  "Criteria": [
    {
      "Name": "Collins Group",
      "Operator": "soluta",
      "Values": [
        "minus",
        "vitae"
      ],
      "DisplayValues": [
        "laudantium",
        "aut"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 98,
      "InterOperator": "And",
      "UniqueHash": 857
    }
  ]
}
```