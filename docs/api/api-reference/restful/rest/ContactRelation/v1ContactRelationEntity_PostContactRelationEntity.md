---
title: POST Relation
id: v1ContactRelationEntity_PostContactRelationEntity
---

# POST Relation

```http
POST /api/v1/Relation
```

Creates a new ContactRelationEntity

Calls the Relation agent service SaveContactRelationEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Relation?$select=name,department,category/id
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

## Request Body: newEntity  

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
| 200 | OK |

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
POST /api/v1/Relation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 584,
  "SourcePersonId": 47,
  "DestinationContactId": 788,
  "DestinationPersonId": 27,
  "RelationId": 257,
  "Comment": "reprehenderit",
  "RelationDefinitionId": 42,
  "Reversed": 485,
  "UpdatedDate": "1998-08-25T18:25:50.3866301+02:00",
  "CreatedDate": "2017-07-29T18:25:50.3866301+02:00",
  "CreatedBy": {
    "AssociateId": 989,
    "Name": "Schiller, Hansen and Block",
    "PersonId": 604,
    "Rank": 177,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 288,
    "FullName": "Wilma Williamson",
    "FormalName": "Fadel, Krajcik and Daugherty",
    "Deleted": true,
    "EjUserId": 37,
    "UserName": "Goldner Group"
  },
  "UpdatedBy": {
    "AssociateId": 484,
    "Name": "Purdy LLC",
    "PersonId": 903,
    "Rank": 688,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 338,
    "FullName": "Vince Grady V",
    "FormalName": "Zemlak LLC",
    "Deleted": true,
    "EjUserId": 988,
    "UserName": "Collins-Grimes"
  },
  "SourceContactName": "Schmitt, Bernhard and Hayes",
  "SourcePersonName": "Veum Group",
  "DestinationContactName": "Schulist-Shields",
  "DestinationPersonName": "Toy, Hackett and Bechtelar",
  "ActiveText": "vitae",
  "PassiveText": "consequatur"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 786,
  "SourcePersonId": 482,
  "DestinationContactId": 472,
  "DestinationPersonId": 15,
  "RelationId": 402,
  "Comment": "quia",
  "RelationDefinitionId": 470,
  "Reversed": 333,
  "UpdatedDate": "1996-04-02T18:25:50.3886297+02:00",
  "CreatedDate": "2018-11-22T18:25:50.3886297+01:00",
  "CreatedBy": {
    "AssociateId": 85,
    "Name": "Halvorson, Monahan and Christiansen",
    "PersonId": 201,
    "Rank": 849,
    "Tooltip": "dolore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 622,
    "FullName": "Cordia Kuhn Sr.",
    "FormalName": "Hamill-Borer",
    "Deleted": true,
    "EjUserId": 90,
    "UserName": "Block-Upton",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 912
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 292,
    "Name": "Bednar LLC",
    "PersonId": 441,
    "Rank": 111,
    "Tooltip": "tempore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 575,
    "FullName": "Aisha Wolf",
    "FormalName": "Lubowitz-Morissette",
    "Deleted": false,
    "EjUserId": 166,
    "UserName": "Gibson LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "implement dynamic channels"
        },
        "FieldType": "System.String",
        "FieldLength": 693
      }
    }
  },
  "SourceContactName": "West Group",
  "SourcePersonName": "Kuhic, Green and Lueilwitz",
  "DestinationContactName": "Dicki-Kovacek",
  "DestinationPersonName": "Beahan LLC",
  "ActiveText": "impedit",
  "PassiveText": "quas",
  "TableRight": {
    "Mask": "Delete",
    "Reason": "syndicate user-centric vortals"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 381
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```