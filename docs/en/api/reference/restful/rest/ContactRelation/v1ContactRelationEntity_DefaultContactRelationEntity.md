---
title: GET Relation/default
uid: v1ContactRelationEntity_DefaultContactRelationEntity
generated: true
---

# GET Relation/default

```http
GET /api/v1/Relation/default
```

Set default values into a new ContactRelationEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Relation agent service CreateDefaultContactRelationEntity.







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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactRelationEntity

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
| CreatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| UpdatedBy | Associate | Carrier object for Associate. Services for the Associate Carrier is available from the Associate Agent. |
| SourceContactName | string | Name of the source contact. |
| SourcePersonName | string | Name of the source person. |
| DestinationContactName | string | Name of the destination contact. |
| DestinationPersonName | string | Name of the destination person. |
| ActiveText | string | Active text for the relation. |
| PassiveText | string | Passive text for the relation. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Relation/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Thu, 02 Dec 2010 03:45:28 G12T

{
  "SourceContactId": 681,
  "SourcePersonId": 882,
  "DestinationContactId": 98,
  "DestinationPersonId": 742,
  "RelationId": 34,
  "Comment": "molestiae",
  "RelationDefinitionId": 202,
  "Reversed": 686,
  "UpdatedDate": "2010-12-02T03:45:28.2171945+01:00",
  "CreatedDate": "1998-12-04T03:45:28.2171945+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "SourceContactName": "Kozey, Spencer and Kessler",
  "SourcePersonName": "Abernathy Inc and Sons",
  "DestinationContactName": "Buckridge, Torphy and Grady",
  "DestinationPersonName": "Steuber, Grimes and Metz",
  "ActiveText": "quisquam",
  "PassiveText": "et",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 939
    }
  }
}
```