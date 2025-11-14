```http!
POST /api/v1/Agents/User/FindRolesWithoutFunctionalRights
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "FunctionalRightNames": [
    "Auer, Lebsack and Brakus",
    "Dooley, Rempel and Sauer"
  ]
}
```