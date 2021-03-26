---
title: POST Agents/Audience/GetAudienceLayoutOnPerson
id: v1AudienceAgent_GetAudienceLayoutOnPerson
---

# POST Agents/Audience/GetAudienceLayoutOnPerson

```http
POST /api/v1/Agents/Audience/GetAudienceLayoutOnPerson
```

Gets the Audience layout belonging to the person specified.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Audience/GetAudienceLayoutOnPerson?$select=name,department,category/id
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

PersonId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |


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
POST /api/v1/Agents/Audience/GetAudienceLayoutOnPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 423
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 142,
  "InstanceLayout": "molestias",
  "InstanceName": "Rippin-Shanahan",
  "CreatedDate": "2013-09-29T16:48:28.7751985+02:00",
  "UpdatedDate": "1999-04-26T16:48:28.7751985+02:00",
  "CreatedBy": {
    "AssociateId": 682,
    "Name": "West LLC",
    "PersonId": 92,
    "Rank": 412,
    "Tooltip": "dolorem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 466,
    "FullName": "Nicholaus Hegmann",
    "FormalName": "Schmeler Inc and Sons",
    "Deleted": true,
    "EjUserId": 652,
    "UserName": "McClure LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 739
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 366,
    "Name": "Zemlak, Grady and Shanahan",
    "PersonId": 276,
    "Rank": 78,
    "Tooltip": "corrupti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 618,
    "FullName": "Carole Maggio",
    "FormalName": "Littel Inc and Sons",
    "Deleted": false,
    "EjUserId": 415,
    "UserName": "McGlynn, Heller and Blanda",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 88
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
      "FieldLength": 221
    }
  }
}
```