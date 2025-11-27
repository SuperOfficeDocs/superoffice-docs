```http!
POST /api/v1/Agents/Find/PopulateRestrictions
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "DuBuque LLC",
  "Restrictions": [
    {
      "Name": "Glover, Frami and Blick",
      "Operator": "est",
      "Values": [
        "voluptatibus",
        "dolor"
      ],
      "DisplayValues": [
        "qui",
        "maxime"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 312,
      "InterOperator": "And",
      "UniqueHash": 142
    }
  ]
}
```