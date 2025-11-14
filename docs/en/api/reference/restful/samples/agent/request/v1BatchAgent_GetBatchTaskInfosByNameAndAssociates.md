```http!
POST /api/v1/Agents/Batch/GetBatchTaskInfosByNameAndAssociates
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Name": "Mann, Spinka and Quigley",
  "AssociateIds": [
    433,
    739
  ]
}
```