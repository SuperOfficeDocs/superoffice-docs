```http!
POST /api/v1/Agents/Preference/SaveTabOrders
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TabOrders": [
    {
      "TabOrderId": 234,
      "TabName": "Fritsch Group",
      "Order": "maxime",
      "AssociateId": 326
    },
    {
      "TabOrderId": 234,
      "TabName": "Fritsch Group",
      "Order": "maxime",
      "AssociateId": 326
    }
  ]
}
```