---
title: POST Agents/Audience/GetAudienceLayoutEntity
id: v1AudienceAgent_GetAudienceLayoutEntity
---

# POST Agents/Audience/GetAudienceLayoutEntity

```http
POST /api/v1/Agents/Audience/GetAudienceLayoutEntity
```

Gets a AudienceLayoutEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| audienceLayoutEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Audience/GetAudienceLayoutEntity?audienceLayoutEntityId=47
POST /api/v1/Agents/Audience/GetAudienceLayoutEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Audience/GetAudienceLayoutEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 37,
  "InstanceLayout": "eveniet",
  "InstanceName": "Kuhic Inc and Sons",
  "CreatedDate": "2000-08-11T18:28:48.1335463+02:00",
  "UpdatedDate": "2012-02-21T18:28:48.1335463+01:00",
  "CreatedBy": {
    "AssociateId": 378,
    "Name": "O'Reilly LLC",
    "PersonId": 731,
    "Rank": 916,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 785,
    "FullName": "Lucy Fahey",
    "FormalName": "Collier-Bechtelar",
    "Deleted": true,
    "EjUserId": 290,
    "UserName": "Gutkowski, Haag and Sawayn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 935
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 534,
    "Name": "Vandervort-Skiles",
    "PersonId": 836,
    "Rank": 728,
    "Tooltip": "exercitationem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 183,
    "FullName": "Loy Wunsch",
    "FormalName": "DuBuque, Wisoky and Kuvalis",
    "Deleted": false,
    "EjUserId": 900,
    "UserName": "Kerluke-McCullough",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 200
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
      "FieldType": "System.Int32",
      "FieldLength": 672
    }
  }
}
```