```http!
POST /api/v1/Agents/User/ResolveUserFromInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 850,
  "PersonName": "Boyer LLC",
  "PhoneNumbers": [
    "47227",
    "762816"
  ],
  "Emails": [
    "lenore@metz.com",
    "gia.rogahn@hauck.ca"
  ],
  "UserType": "AnonymousAssociate",
  "Credential": null
}
```