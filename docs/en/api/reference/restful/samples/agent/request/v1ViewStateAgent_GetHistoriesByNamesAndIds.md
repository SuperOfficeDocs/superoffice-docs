```http!
POST /api/v1/Agents/ViewState/GetHistoriesByNamesAndIds
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Requests": [
    {
      "EntityName": "Tremblay-Eichmann",
      "EntityOrParentId": 819,
      "RequestForNewRecord": true
    },
    {
      "EntityName": "Tremblay-Eichmann",
      "EntityOrParentId": 819,
      "RequestForNewRecord": true
    }
  ]
}
```