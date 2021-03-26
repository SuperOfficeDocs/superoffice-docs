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
  "SourceContactId": 381,
  "SourcePersonId": 272,
  "DestinationContactId": 262,
  "DestinationPersonId": 492,
  "RelationId": 918,
  "Comment": "et",
  "RelationDefinitionId": 47,
  "Reversed": 812,
  "UpdatedDate": "2014-03-31T09:40:59.0213705+02:00",
  "CreatedDate": "2015-10-29T09:40:59.0213705+01:00",
  "CreatedBy": {
    "AssociateId": 910,
    "Name": "Leuschke LLC",
    "PersonId": 149,
    "Rank": 183,
    "Tooltip": "totam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 431,
    "FullName": "Jordy Johnston",
    "FormalName": "Pagac, Emard and Satterfield",
    "Deleted": false,
    "EjUserId": 652,
    "UserName": "Botsford LLC"
  },
  "UpdatedBy": {
    "AssociateId": 590,
    "Name": "Leannon Group",
    "PersonId": 864,
    "Rank": 186,
    "Tooltip": "totam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 748,
    "FullName": "Mustafa Kuphal",
    "FormalName": "Gutkowski LLC",
    "Deleted": false,
    "EjUserId": 798,
    "UserName": "Towne Group"
  },
  "SourceContactName": "Pfannerstill, Romaguera and Smith",
  "SourcePersonName": "Feil-Kessler",
  "DestinationContactName": "Brekke, Cronin and Feest",
  "DestinationPersonName": "Fisher LLC",
  "ActiveText": "non",
  "PassiveText": "voluptatem"
}
```

```http_
HTTP/1.1 200 ContactRelationEntity updated.
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 380,
  "SourcePersonId": 374,
  "DestinationContactId": 95,
  "DestinationPersonId": 979,
  "RelationId": 819,
  "Comment": "est",
  "RelationDefinitionId": 77,
  "Reversed": 933,
  "UpdatedDate": "2019-11-06T09:40:59.0508473+01:00",
  "CreatedDate": "2014-08-25T09:40:59.0508473+02:00",
  "CreatedBy": {
    "AssociateId": 624,
    "Name": "Ankunding Inc and Sons",
    "PersonId": 498,
    "Rank": 872,
    "Tooltip": "molestias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 33,
    "FullName": "Mrs. Enos Davis",
    "FormalName": "Ruecker, Kerluke and Rolfson",
    "Deleted": false,
    "EjUserId": 829,
    "UserName": "Bosco, Hahn and Jaskolski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 441
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 563,
    "Name": "Jones-Heidenreich",
    "PersonId": 74,
    "Rank": 493,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 101,
    "FullName": "Krystel Green",
    "FormalName": "Tremblay-Huels",
    "Deleted": true,
    "EjUserId": 2,
    "UserName": "Schinner, Stracke and Shields",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 224
      }
    }
  },
  "SourceContactName": "Legros-Price",
  "SourcePersonName": "Reynolds-Rolfson",
  "DestinationContactName": "Olson, West and Green",
  "DestinationPersonName": "Renner-Gulgowski",
  "ActiveText": "illum",
  "PassiveText": "animi",
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
      "FieldLength": 196
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```