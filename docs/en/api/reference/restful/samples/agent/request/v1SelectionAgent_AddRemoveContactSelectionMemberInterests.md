```http!
POST /api/v1/Agents/Selection/AddRemoveContactSelectionMemberInterests
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SelectionId": 156,
  "AddCompanyInterests": [
    510,
    291
  ],
  "RemoveCompanyInterests": [
    364,
    963
  ],
  "AddContactInterests": [
    967,
    118
  ],
  "RemoveContactInterests": [
    176,
    137
  ]
}
```