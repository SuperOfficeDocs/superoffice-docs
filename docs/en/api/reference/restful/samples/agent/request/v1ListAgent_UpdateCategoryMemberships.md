```http!
POST /api/v1/Agents/List/UpdateCategoryMemberships
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "TicketCategoryId": 28,
  "MembershipsToAdd": [
    {
      "User": null,
      "Weight": 676
    },
    {
      "User": null,
      "Weight": 676
    }
  ],
  "MembershipsToUpdate": [
    {
      "User": null,
      "Weight": 304
    },
    {
      "User": null,
      "Weight": 304
    }
  ],
  "MembershipsToDelete": [
    {
      "User": null,
      "Weight": 12
    },
    {
      "User": null,
      "Weight": 12
    }
  ]
}
```