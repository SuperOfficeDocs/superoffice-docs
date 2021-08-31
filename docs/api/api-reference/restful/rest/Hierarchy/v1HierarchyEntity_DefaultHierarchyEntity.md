---
title: GET Hierarchy/default
id: v1HierarchyEntity_DefaultHierarchyEntity
---

# GET Hierarchy/default

```http
GET /api/v1/Hierarchy/default
```

Set default values into a new HierarchyEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the List agent service CreateDefaultHierarchyEntity.






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Folder structures



Carrier object for HierarchyEntity.
Services for the HierarchyEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| HierarchyId | int32 | The primary key (auto-incremented) |
| Domain | string | Domain seperating the different hierarchy |
| Name | string | Name of this hierarchy folder. |
| Fullname | string | The full name of this category, i.e. Foo/bar/test. |
| ParentId | int32 | Parent table |
| Children | array | Sub-items, if any. |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/Hierarchy/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 969,
  "Domain": "Dashboards",
  "Name": "Schumm-Johns",
  "Fullname": "et",
  "ParentId": 54,
  "Children": [
    {
      "HierarchyId": 801,
      "Domain": "Dashboards",
      "Name": "Tillman, Altenwerth and Schiller",
      "Fullname": "enim",
      "ParentId": 623,
      "Children": [
        {},
        {}
      ],
      "Registered": "1996-11-17T15:05:42.2496623+01:00",
      "RegisteredAssociateId": 436,
      "Updated": "2009-08-28T15:05:42.2496623+02:00",
      "UpdatedAssociateId": 393,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 515
        }
      }
    }
  ],
  "Registered": "2013-05-21T15:05:42.2496623+02:00",
  "RegisteredAssociateId": 867,
  "Updated": "2000-09-19T15:05:42.2496623+02:00",
  "UpdatedAssociateId": 386,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 906
    }
  }
}
```