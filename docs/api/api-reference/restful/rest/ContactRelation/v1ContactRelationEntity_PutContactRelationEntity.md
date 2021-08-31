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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 297,
  "SourcePersonId": 712,
  "DestinationContactId": 392,
  "DestinationPersonId": 175,
  "RelationId": 278,
  "Comment": "eveniet",
  "RelationDefinitionId": 644,
  "Reversed": 414,
  "UpdatedDate": "1997-03-10T15:05:42.0150026+01:00",
  "CreatedDate": "2010-09-06T15:05:42.0150026+02:00",
  "CreatedBy": {
    "AssociateId": 769,
    "Name": "McLaughlin-Kreiger",
    "PersonId": 135,
    "Rank": 13,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 893,
    "FullName": "Gay Moen",
    "FormalName": "Nicolas-Schamberger",
    "Deleted": false,
    "EjUserId": 228,
    "UserName": "Hansen-Padberg"
  },
  "UpdatedBy": {
    "AssociateId": 842,
    "Name": "Willms Inc and Sons",
    "PersonId": 423,
    "Rank": 370,
    "Tooltip": "animi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 391,
    "FullName": "Rogelio Kunze Jr.",
    "FormalName": "Abernathy LLC",
    "Deleted": false,
    "EjUserId": 431,
    "UserName": "Legros Group"
  },
  "SourceContactName": "Sanford, Harris and Schaden",
  "SourcePersonName": "Nikolaus-Legros",
  "DestinationContactName": "Jewess Group",
  "DestinationPersonName": "Reilly-Walter",
  "ActiveText": "harum",
  "PassiveText": "quo"
}
```

```http_
HTTP/1.1 200 ContactRelationEntity updated.
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 558,
  "SourcePersonId": 823,
  "DestinationContactId": 899,
  "DestinationPersonId": 363,
  "RelationId": 529,
  "Comment": "commodi",
  "RelationDefinitionId": 255,
  "Reversed": 330,
  "UpdatedDate": "2004-06-24T15:05:42.0180023+02:00",
  "CreatedDate": "2016-06-17T15:05:42.0180023+02:00",
  "CreatedBy": {
    "AssociateId": 553,
    "Name": "Kessler Inc and Sons",
    "PersonId": 104,
    "Rank": 703,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 779,
    "FullName": "Robb Howell MD",
    "FormalName": "Conn-Grimes",
    "Deleted": true,
    "EjUserId": 494,
    "UserName": "Schaefer, Gutkowski and Purdy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 387
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 573,
    "Name": "Mayer-Borer",
    "PersonId": 998,
    "Rank": 35,
    "Tooltip": "debitis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 752,
    "FullName": "Marjorie Ernser MD",
    "FormalName": "Casper, Spinka and Kautzer",
    "Deleted": false,
    "EjUserId": 509,
    "UserName": "Bartell, DuBuque and Bernhard",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 403
      }
    }
  },
  "SourceContactName": "Koss Group",
  "SourcePersonName": "Carter Inc and Sons",
  "DestinationContactName": "Labadie, Goyette and Pfeffer",
  "DestinationPersonName": "Schmidt LLC",
  "ActiveText": "ut",
  "PassiveText": "nesciunt",
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
      "FieldLength": 864
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```