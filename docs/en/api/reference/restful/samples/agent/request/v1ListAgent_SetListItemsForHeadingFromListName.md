```http!
POST /api/v1/Agents/List/SetListItemsForHeadingFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Hartmann, Hansen and Nikolaus",
  "HeadingId": 578,
  "ListItemIds": [
    937,
    543
  ],
  "Enable": false
}
```