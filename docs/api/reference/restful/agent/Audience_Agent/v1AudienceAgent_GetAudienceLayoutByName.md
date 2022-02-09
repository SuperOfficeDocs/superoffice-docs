---
title: POST Agents/Audience/GetAudienceLayoutByName
id: v1AudienceAgent_GetAudienceLayoutByName
---

# POST Agents/Audience/GetAudienceLayoutByName

```http
POST /api/v1/Agents/Audience/GetAudienceLayoutByName
```

Gets an Audience layout by it's instance name







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Audience/GetAudienceLayoutByName?$select=name,department,category/id
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

## Request Body: request  

LayoutName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| LayoutName | string |  |


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
POST /api/v1/Agents/Audience/GetAudienceLayoutByName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "LayoutName": "Schinner-Homenick"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 293,
  "InstanceLayout": "eum",
  "InstanceName": "Russel-Champlin",
  "CreatedDate": "2017-12-07T18:28:48.1355428+01:00",
  "UpdatedDate": "1994-10-24T18:28:48.1355428+02:00",
  "CreatedBy": {
    "AssociateId": 7,
    "Name": "Pagac-Welch",
    "PersonId": 745,
    "Rank": 726,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 366,
    "FullName": "Alana Torphy",
    "FormalName": "Bashirian Inc and Sons",
    "Deleted": true,
    "EjUserId": 364,
    "UserName": "McGlynn Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 356
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 774,
    "Name": "Jewess Group",
    "PersonId": 846,
    "Rank": 916,
    "Tooltip": "officiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 430,
    "FullName": "Mervin Robel",
    "FormalName": "Waelchi-Bernier",
    "Deleted": true,
    "EjUserId": 526,
    "UserName": "Dach-Pouros",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "cultivate synergistic action-items"
        },
        "FieldType": "System.Int32",
        "FieldLength": 806
      }
    }
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "target visionary schemas"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 365
    }
  }
}
```