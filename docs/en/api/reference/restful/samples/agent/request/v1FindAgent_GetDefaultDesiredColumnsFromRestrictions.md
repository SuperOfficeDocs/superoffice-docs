```http!
POST /api/v1/Agents/Find/GetDefaultDesiredColumnsFromRestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Bode-Kling",
  "Restrictions": [
    {
      "Name": "Kub Inc and Sons",
      "Operator": "debitis",
      "Values": [
        "eligendi",
        "quaerat"
      ],
      "DisplayValues": [
        "laborum",
        "laudantium"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 790,
      "InterOperator": "And",
      "UniqueHash": 120
    }
  ]
}
```