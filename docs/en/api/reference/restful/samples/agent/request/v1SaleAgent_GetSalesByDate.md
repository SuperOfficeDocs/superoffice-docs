```http!
POST /api/v1/Agents/Sale/GetSalesByDate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "FromDate": "2018-10-21T10:11:01.1067442+02:00",
  "ToDate": "2002-11-11T10:11:01.1067442+01:00",
  "AmountLimit": 592,
  "Status": "Lost"
}
```