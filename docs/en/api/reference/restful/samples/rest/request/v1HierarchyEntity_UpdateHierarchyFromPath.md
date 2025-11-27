```http!
PUT /api/v1/Hierarchy/{domain}/{path}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 212,
  "Domain": "Dashboards",
  "Name": "Jacobson, Gutmann and Bednar",
  "Fullname": "aut",
  "ParentId": 961,
  "Children": [
    {
      "HierarchyId": 543,
      "Domain": "Dashboards",
      "Name": "Prohaska Inc and Sons",
      "Fullname": "voluptas",
      "ParentId": 953,
      "Children": [
        {},
        {}
      ],
      "Registered": "2021-08-07T14:35:43.7873563+02:00",
      "RegisteredAssociateId": 621,
      "Updated": "2016-11-27T14:35:43.7873563+01:00",
      "UpdatedAssociateId": 189
    }
  ],
  "Registered": "2017-12-31T14:35:43.7873563+01:00",
  "RegisteredAssociateId": 786,
  "Updated": "2014-12-19T14:35:43.7873563+01:00",
  "UpdatedAssociateId": 504
}
```