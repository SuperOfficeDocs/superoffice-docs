```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Name": "Active Sales Contacts",
  "Description": "Contacts with active sales opportunities",
  "Rank": 1,
  "Restrictions": [
    {
      "Name": "contact/category",
      "Operator": "equals",
      "Values": [
        "1"
      ],
      "DisplayValues": [
        "Customer"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 464,
      "InterOperator": "And",
      "UniqueHash": 965
    }
  ]
}
```
