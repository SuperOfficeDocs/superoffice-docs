```http!
POST /api/v1/Agents/MDO/GetSelectableListWithHistory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Name": "Kerluke Group",
  "ForceFlatList": true,
  "AdditionalInfo": "optio",
  "HistoryItems": [
    201,
    512
  ],
  "OnlyHistory": false
}
```