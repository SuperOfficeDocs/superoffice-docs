---
title: PUT Relation/{id}
id: v1ContactRelationEntity_PutContactRelationEntity
---

# PUT Relation/{id}

```http
PUT /api/v1/Relation/{id}
```

Updates the existing ContactRelationEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactRelationEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Relation/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity  

The ContactRelationEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceContactId | int32 | Id of the source contact. The value is mandatory. |
| SourcePersonId | int32 | Id of the source person. The value is not mandatory. The person must belong to the source contact. |
| DestinationContactId | int32 | Id of the destination contact. The value is mandatory. |
| DestinationPersonId | int32 | Id of the destination person. The value is not mandatory. The person must belong to the destination contact. |
| RelationId | int32 | Primary key |
| Comment | string | Comment for relation |
| RelationDefinitionId | int32 | Reference to definition |
| Reversed | int32 | Is direction reversed relative to definition |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedDate | date-time | Registered when  in UTC. |
| CreatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| UpdatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| SourceContactName | string | Name of the source contact. |
| SourcePersonName | string | Name of the source person. |
| DestinationContactName | string | Name of the destination contact. |
| DestinationPersonName | string | Name of the destination person. |
| ActiveText | string | Active text for the relation. |
| PassiveText | string | Passive text for the relation. |


## Response: object

Relationship between a (contact/person) and another (contact/person), as described by the RelationDefinition.



ContactRelationEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ContactRelationEntity updated. |
| 412 | Update stopped because ContactRelationEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| SourceContactId | int32 | Id of the source contact. The value is mandatory. |
| SourcePersonId | int32 | Id of the source person. The value is not mandatory. The person must belong to the source contact. |
| DestinationContactId | int32 | Id of the destination contact. The value is mandatory. |
| DestinationPersonId | int32 | Id of the destination person. The value is not mandatory. The person must belong to the destination contact. |
| RelationId | int32 | Primary key |
| Comment | string | Comment for relation |
| RelationDefinitionId | int32 | Reference to definition |
| Reversed | int32 | Is direction reversed relative to definition |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedDate | date-time | Registered when  in UTC. |
| CreatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| UpdatedBy |  | Carrier object for Associate. Services for the Associate Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAssociateAgent">Associate Agent</see>. |
| SourceContactName | string | Name of the source contact. |
| SourcePersonName | string | Name of the source person. |
| DestinationContactName | string | Name of the destination contact. |
| DestinationPersonName | string | Name of the destination person. |
| ActiveText | string | Active text for the relation. |
| PassiveText | string | Passive text for the relation. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Relation/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 871,
  "SourcePersonId": 111,
  "DestinationContactId": 120,
  "DestinationPersonId": 829,
  "RelationId": 572,
  "Comment": "molestiae",
  "RelationDefinitionId": 735,
  "Reversed": 244,
  "UpdatedDate": "2007-06-06T18:25:50.3916228+02:00",
  "CreatedDate": "2002-03-30T18:25:50.3916228+01:00",
  "CreatedBy": {
    "AssociateId": 488,
    "Name": "Purdy-Howe",
    "PersonId": 466,
    "Rank": 669,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 192,
    "FullName": "Kara Lowe",
    "FormalName": "Schulist, Mueller and Pagac",
    "Deleted": false,
    "EjUserId": 48,
    "UserName": "Gutkowski-Kris"
  },
  "UpdatedBy": {
    "AssociateId": 507,
    "Name": "Stehr LLC",
    "PersonId": 407,
    "Rank": 968,
    "Tooltip": "nulla",
    "Type": "AnonymousAssociate",
    "GroupIdx": 33,
    "FullName": "Mr. Ottis O'Kon",
    "FormalName": "Cronin, Barton and Stracke",
    "Deleted": false,
    "EjUserId": 603,
    "UserName": "Collins-Hoeger"
  },
  "SourceContactName": "Mann-Adams",
  "SourcePersonName": "Cummings, Rohan and Buckridge",
  "DestinationContactName": "Baumbach LLC",
  "DestinationPersonName": "Wisoky LLC",
  "ActiveText": "aut",
  "PassiveText": "est"
}
```

```http_
HTTP/1.1 200 ContactRelationEntity updated.
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 566,
  "SourcePersonId": 458,
  "DestinationContactId": 717,
  "DestinationPersonId": 136,
  "RelationId": 409,
  "Comment": "consequatur",
  "RelationDefinitionId": 437,
  "Reversed": 715,
  "UpdatedDate": "2008-02-13T18:25:50.3935942+01:00",
  "CreatedDate": "1998-05-01T18:25:50.3935942+02:00",
  "CreatedBy": {
    "AssociateId": 274,
    "Name": "Bartell, Gleichner and Kertzmann",
    "PersonId": 906,
    "Rank": 627,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 853,
    "FullName": "Johanna Hintz",
    "FormalName": "Larson-Labadie",
    "Deleted": false,
    "EjUserId": 86,
    "UserName": "Zboncak, Hudson and Leffler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 477
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 224,
    "Name": "Kilback-Hoppe",
    "PersonId": 940,
    "Rank": 503,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 346,
    "FullName": "Elias Nolan",
    "FormalName": "Keebler-Gottlieb",
    "Deleted": true,
    "EjUserId": 715,
    "UserName": "DuBuque, Rowe and Towne",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 631
      }
    }
  },
  "SourceContactName": "Strosin-Thompson",
  "SourcePersonName": "Hodkiewicz-Wiegand",
  "DestinationContactName": "Kautzer, Jacobson and Eichmann",
  "DestinationPersonName": "Johns Group",
  "ActiveText": "fuga",
  "PassiveText": "velit",
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
      "FieldType": "System.Int32",
      "FieldLength": 560
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```