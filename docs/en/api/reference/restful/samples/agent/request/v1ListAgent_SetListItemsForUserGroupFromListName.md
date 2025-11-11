```http!
POST /api/v1/Agents/List/SetListItemsForUserGroupFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Wehner-Schoen",
  "UsergroupId": 387,
  "ListItemsID": [
    418,
    177
  ],
  "Enable": true
}
```