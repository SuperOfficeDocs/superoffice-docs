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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 880,
  "SourcePersonId": 150,
  "DestinationContactId": 955,
  "DestinationPersonId": 757,
  "RelationId": 481,
  "Comment": "pariatur",
  "RelationDefinitionId": 974,
  "Reversed": 254,
  "UpdatedDate": "2007-02-09T09:40:59.010371+01:00",
  "CreatedDate": "2018-03-20T09:40:59.010371+01:00",
  "CreatedBy": {
    "AssociateId": 828,
    "Name": "Dach-Cummerata",
    "PersonId": 414,
    "Rank": 149,
    "Tooltip": "quaerat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 508,
    "FullName": "Miss Amira Konopelski",
    "FormalName": "Pacocha, Walter and Boehm",
    "Deleted": false,
    "EjUserId": 926,
    "UserName": "Ondricka Group"
  },
  "UpdatedBy": {
    "AssociateId": 406,
    "Name": "Dibbert LLC",
    "PersonId": 133,
    "Rank": 77,
    "Tooltip": "quae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 722,
    "FullName": "Francesca D'Amore",
    "FormalName": "Glover Inc and Sons",
    "Deleted": true,
    "EjUserId": 223,
    "UserName": "Frami Inc and Sons"
  },
  "SourceContactName": "Jerde, Tromp and Graham",
  "SourcePersonName": "Carter-Waelchi",
  "DestinationContactName": "Mann, McLaughlin and Treutel",
  "DestinationPersonName": "McDermott Group",
  "ActiveText": "tempora",
  "PassiveText": "harum"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SourceContactId": 725,
  "SourcePersonId": 526,
  "DestinationContactId": 393,
  "DestinationPersonId": 25,
  "RelationId": 520,
  "Comment": "enim",
  "RelationDefinitionId": 502,
  "Reversed": 975,
  "UpdatedDate": "1999-06-11T09:40:59.0133706+02:00",
  "CreatedDate": "2018-02-02T09:40:59.0133706+01:00",
  "CreatedBy": {
    "AssociateId": 1001,
    "Name": "Pfeffer, Zboncak and Weimann",
    "PersonId": 263,
    "Rank": 154,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 40,
    "FullName": "Carmen Moen",
    "FormalName": "Farrell-Klocko",
    "Deleted": false,
    "EjUserId": 399,
    "UserName": "Stokes, Ritchie and Lehner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 878
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 747,
    "Name": "Smith-Jast",
    "PersonId": 217,
    "Rank": 393,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 76,
    "FullName": "Mortimer Collins",
    "FormalName": "Bednar-Johnston",
    "Deleted": true,
    "EjUserId": 687,
    "UserName": "Fay-Jewess",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engineer compelling interfaces"
        },
        "FieldType": "System.Int32",
        "FieldLength": 256
      }
    }
  },
  "SourceContactName": "Fisher Inc and Sons",
  "SourcePersonName": "Hermiston, Hoppe and Jakubowski",
  "DestinationContactName": "Hayes-Pfeffer",
  "DestinationPersonName": "Lueilwitz, Christiansen and Lehner",
  "ActiveText": "sequi",
  "PassiveText": "consequatur",
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
      "FieldLength": 720
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```