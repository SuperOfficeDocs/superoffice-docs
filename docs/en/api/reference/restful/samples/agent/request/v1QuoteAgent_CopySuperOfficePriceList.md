```http!
POST /api/v1/Agents/Quote/CopySuperOfficePriceList
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "OriginalPriceListId": 653,
  "NewName": "Hahn-Steuber",
  "ValidFrom": "2008-02-13T10:11:00.9128382+01:00",
  "ValidTo": "2002-12-03T10:11:00.9128382+01:00",
  "NewCurrencyId": 977,
  "ConvertCurrency": false
}
```