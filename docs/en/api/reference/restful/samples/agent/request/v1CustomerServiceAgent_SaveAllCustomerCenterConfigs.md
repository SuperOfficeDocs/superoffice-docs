```http!
POST /api/v1/Agents/CustomerService/SaveAllCustomerCenterConfigs
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "CustConfigs": [
    {
      "CustConfigId": 262,
      "Type": "Options",
      "Config": "ut",
      "CustLangId": 376,
      "Registered": "2022-10-20T10:10:59.5778352+02:00",
      "RegisteredAssociateId": 212,
      "Updated": "2014-01-27T10:10:59.5778352+01:00",
      "UpdatedAssociateId": 909
    }
  ]
}
```