```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Name": "VIP Customers",
  "Description": "High-value customer contacts",
  "Rank": 1,
  "Restrictions": [
    {
      "Name": "contact/category",
      "Operator": "equals",
      "Values": [
        "2"
      ],
      "DisplayValues": [
        "VIP"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 0,
      "InterOperator": "And",
      "UniqueHash": 19
    }
  ]
}
```
