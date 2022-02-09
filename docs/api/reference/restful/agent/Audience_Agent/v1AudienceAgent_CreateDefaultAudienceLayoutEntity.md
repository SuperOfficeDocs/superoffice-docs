---
title: POST Agents/Audience/CreateDefaultAudienceLayoutEntity
id: v1AudienceAgent_CreateDefaultAudienceLayoutEntity
---

# POST Agents/Audience/CreateDefaultAudienceLayoutEntity

```http
POST /api/v1/Agents/Audience/CreateDefaultAudienceLayoutEntity
```

Set default values into a new AudienceLayoutEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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

Audience layout. Each instance of Audience has at least one layout. The layout is connected to the instance by it's instance name or is linked to the currently logged on user. The web part layout and the Audience configuration parameters belongs to an Audience layout



Carrier object for AudienceLayoutEntity.
Services for the AudienceLayoutEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAudienceAgent">Audience Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| AudienceLayoutId | int32 | The Id of the Audience layout |
| InstanceLayout | string | The web part layout as a serialized string |
| InstanceName | string | Name of the layout instance |
| CreatedDate | date-time | The date and time the Audience layout was created  in UTC. |
| UpdatedDate | date-time | The date and time the Audience layout was last updated  in UTC. |
| CreatedBy |  | Name of the person that created the Audience layout |
| UpdatedBy |  | Name of the person that last updated the Audience layout |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Audience/CreateDefaultAudienceLayoutEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 683,
  "InstanceLayout": "et",
  "InstanceName": "White-Stoltenberg",
  "CreatedDate": "2009-02-03T18:28:48.1245431+01:00",
  "UpdatedDate": "1999-01-23T18:28:48.1245431+01:00",
  "CreatedBy": {
    "AssociateId": 291,
    "Name": "Durgan Inc and Sons",
    "PersonId": 492,
    "Rank": 403,
    "Tooltip": "nobis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 62,
    "FullName": "Iva Turcotte",
    "FormalName": "Kessler LLC",
    "Deleted": true,
    "EjUserId": 896,
    "UserName": "Zboncak, Littel and Hamill",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 169
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 562,
    "Name": "Ledner LLC",
    "PersonId": 772,
    "Rank": 668,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 269,
    "FullName": "Kaitlyn Fritsch",
    "FormalName": "Towne, Jacobi and Huels",
    "Deleted": false,
    "EjUserId": 976,
    "UserName": "Nikolaus-Keebler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 55
      }
    }
  },
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
      "FieldLength": 611
    }
  }
}
```