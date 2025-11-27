```http!
POST /api/v1/Agents/Ticket/SetDeletedStatusByProvider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Braun-Schoen",
  "Restrictions": [
    {
      "Name": "Kirlin, Kunze and Hilpert",
      "Operator": "laboriosam",
      "Values": [
        "non",
        "nisi"
      ],
      "DisplayValues": [
        "inventore",
        "sit"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 864,
      "InterOperator": "And",
      "UniqueHash": 724
    }
  ]
}
```