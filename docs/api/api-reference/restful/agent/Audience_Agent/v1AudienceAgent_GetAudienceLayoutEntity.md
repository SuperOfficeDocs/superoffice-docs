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
POST /api/v1/Agents/Audience/GetAudienceLayoutEntity?audienceLayoutEntityId=522
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
  "AudienceLayoutId": 808,
  "InstanceLayout": "aut",
  "InstanceName": "Predovic-Bergstrom",
  "CreatedDate": "2019-09-06T16:48:28.7701984+02:00",
  "UpdatedDate": "2003-06-13T16:48:28.7701984+02:00",
  "CreatedBy": {
    "AssociateId": 534,
    "Name": "Mills Inc and Sons",
    "PersonId": 490,
    "Rank": 886,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 403,
    "FullName": "Mr. Reilly Jerde",
    "FormalName": "Doyle, Ruecker and Kulas",
    "Deleted": true,
    "EjUserId": 93,
    "UserName": "Heller, Gleichner and Heller",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 804
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 893,
    "Name": "Pacocha Inc and Sons",
    "PersonId": 317,
    "Rank": 978,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 580,
    "FullName": "Annalise Hettinger",
    "FormalName": "Marquardt, Beer and Schamberger",
    "Deleted": false,
    "EjUserId": 660,
    "UserName": "Bradtke-Schoen",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 966
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
      "FieldLength": 234
    }
  }
}
```