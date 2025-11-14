```http!
POST /api/v1/Agents/Favourite/RemoveTicketsFromFavouritesByProvider
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProviderName": "Moore, Collins and Koss",
  "Restrictions": [
    {
      "Name": "Rath, Russel and Stark",
      "Operator": "commodi",
      "Values": [
        "a",
        "et"
      ],
      "DisplayValues": [
        "modi",
        "cum"
      ],
      "ColumnInfo": null,
      "IsActive": true,
      "SubRestrictions": [
        {},
        {}
      ],
      "InterParenthesis": 299,
      "InterOperator": "And",
      "UniqueHash": 907
    }
  ],
  "AssociateId": 268
}
```