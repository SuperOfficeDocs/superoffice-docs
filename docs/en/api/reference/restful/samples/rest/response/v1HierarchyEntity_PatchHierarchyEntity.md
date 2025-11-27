```http_
HTTP/1.1 200 HierarchyEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 707,
  "Domain": "Dashboards",
  "Name": "D'Amore-Ryan",
  "Fullname": "est",
  "ParentId": 54,
  "Children": [
    {
      "HierarchyId": 555,
      "Domain": "Dashboards",
      "Name": "Hilpert, Turner and Nikolaus",
      "Fullname": "placeat",
      "ParentId": 974,
      "Children": [
        {},
        {}
      ],
      "Registered": "2007-11-22T14:35:43.7873563+01:00",
      "RegisteredAssociateId": 211,
      "Updated": "2015-07-29T14:35:43.7873563+02:00",
      "UpdatedAssociateId": 362,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 90
        }
      }
    }
  ],
  "Registered": "2012-08-10T14:35:43.7873563+02:00",
  "RegisteredAssociateId": 409,
  "Updated": "2007-08-27T14:35:43.7873563+02:00",
  "UpdatedAssociateId": 644,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 868
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```