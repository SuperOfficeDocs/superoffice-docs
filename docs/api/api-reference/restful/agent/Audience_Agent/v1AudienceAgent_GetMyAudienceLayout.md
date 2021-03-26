---
title: POST Agents/Audience/GetMyAudienceLayout
id: v1AudienceAgent_GetMyAudienceLayout
---

# POST Agents/Audience/GetMyAudienceLayout

```http
POST /api/v1/Agents/Audience/GetMyAudienceLayout
```

Gets the Audience layout belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Audience/GetMyAudienceLayout?$select=name,department,category/id
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
POST /api/v1/Agents/Audience/GetMyAudienceLayout
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AudienceLayoutId": 878,
  "InstanceLayout": "quis",
  "InstanceName": "Windler-Franecki",
  "CreatedDate": "2002-07-07T16:48:28.7731984+02:00",
  "UpdatedDate": "2006-10-17T16:48:28.7731984+02:00",
  "CreatedBy": {
    "AssociateId": 571,
    "Name": "Hoppe Group",
    "PersonId": 961,
    "Rank": 16,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 362,
    "FullName": "Ila Shields I",
    "FormalName": "Mante, Osinski and Mann",
    "Deleted": true,
    "EjUserId": 976,
    "UserName": "Bins, Crona and Wilkinson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 820
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 153,
    "Name": "Lowe-Koepp",
    "PersonId": 312,
    "Rank": 283,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 766,
    "FullName": "Kristin Torp DVM",
    "FormalName": "Buckridge, Jones and Ferry",
    "Deleted": true,
    "EjUserId": 643,
    "UserName": "Schneider Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 665
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
      "FieldLength": 298
    }
  }
}
```