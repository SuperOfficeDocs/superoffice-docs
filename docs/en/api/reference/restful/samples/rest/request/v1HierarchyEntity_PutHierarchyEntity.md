```http!
PUT /api/v1/Hierarchy/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 984,
  "Domain": "Dashboards",
  "Name": "Rodriguez LLC",
  "Fullname": "omnis",
  "ParentId": 945,
  "Children": [
    {
      "HierarchyId": 955,
      "Domain": "Dashboards",
      "Name": "Lakin, Doyle and Bartoletti",
      "Fullname": "porro",
      "ParentId": 299,
      "Children": [
        {},
        {}
      ],
      "Registered": "2006-01-22T14:34:02.0270898+01:00",
      "RegisteredAssociateId": 481,
      "Updated": "2020-11-27T14:34:02.0270898+01:00",
      "UpdatedAssociateId": 351
    }
  ],
  "Registered": "1999-03-12T14:34:02.0270898+01:00",
  "RegisteredAssociateId": 67,
  "Updated": "2004-09-17T14:34:02.0270898+02:00",
  "UpdatedAssociateId": 601
}
```