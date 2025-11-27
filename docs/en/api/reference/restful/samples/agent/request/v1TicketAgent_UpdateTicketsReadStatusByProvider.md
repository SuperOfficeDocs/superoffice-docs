```http!
POST /api/v1/Agents/Ticket/UpdateTicketsReadStatusByProvider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Provider": "numquam",
  "Restrictions": [
    {
      "Name": "McKenzie LLC",
      "Operator": "et",
      "Values": [
        "vero",
        "magni"
      ],
      "DisplayValues": [
        "eligendi",
        "aliquid"
      ],
      "ColumnInfo": null,
      "IsActive": false,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 241,
      "InterOperator": "And",
      "UniqueHash": 908
    }
  ],
  "NewStatus": "Green"
}
```