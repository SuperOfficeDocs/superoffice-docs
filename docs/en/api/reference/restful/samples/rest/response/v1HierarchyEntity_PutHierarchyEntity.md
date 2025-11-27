```http_
HTTP/1.1 200 HierarchyEntity updated.
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 416,
  "Domain": "Dashboards",
  "Name": "Hand-McKenzie",
  "Fullname": "est",
  "ParentId": 922,
  "Children": [
    {
      "HierarchyId": 657,
      "Domain": "Dashboards",
      "Name": "Lemke Group",
      "Fullname": "ex",
      "ParentId": 481,
      "Children": [
        {},
        {}
      ],
      "Registered": "2009-06-13T14:35:43.7873563+02:00",
      "RegisteredAssociateId": 703,
      "Updated": "2011-05-24T14:35:43.7873563+02:00",
      "UpdatedAssociateId": 972,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 32
        }
      }
    }
  ],
  "Registered": "2008-05-02T14:35:43.7873563+02:00",
  "RegisteredAssociateId": 538,
  "Updated": "2009-05-02T14:35:43.7873563+02:00",
  "UpdatedAssociateId": 285,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 156
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```