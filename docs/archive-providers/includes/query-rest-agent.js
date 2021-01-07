POST /Cust12345/api/v1/Agents/Find/FindFromRestrictionsColumns HTTP/1.1
Host: sod.superoffice.com:443
Authorization: Bearer 8A:Cust12345.AS5...sy9
Accept: application/json
Content-Type: application/json

{
  "ProviderName": "FindSale",
  "DesiredColumns": [
    "saleId",
    "heading",
    "projectId"
  ],
  "Restrictions": [
    {
      "Name": "projectId",
      "Operator": "=",
      "Values": [
        "47"
      ],
      "IsActive": true
    }
  ],
  "Page": 0,
  "PageSize": 100
}