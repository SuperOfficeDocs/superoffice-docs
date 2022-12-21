---
title: POST List/UserGroup/Items
uid: v1UserGroupList_PostUserGroup
---

# POST List/UserGroup/Items

```http
POST /api/v1/List/UserGroup/Items
```

Create a new UserGroup list item


Calls the User agent service SaveUserGroup.







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

The UserGroup to be created. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Value | string | UserGroup name |
| Tooltip | string | Tooltip or other description |
| Id | int32 | Primary key |
| Rank | int32 | Rank order |
| Deleted | bool | Deleted equal to true means that this is a user group that no longer can be selected by the user.  It is not permitted to delete a UserGroup. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Value | string | UserGroup name |
| Tooltip | string | Tooltip or other description |
| Id | int32 | Primary key |
| Rank | int32 | Rank order |
| Deleted | bool | Deleted equal to true means that this is a user group that no longer can be selected by the user.  It is not permitted to delete a UserGroup. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/List/UserGroup/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Value": "blanditiis",
  "Tooltip": "vel",
  "Id": 167,
  "Rank": 672,
  "Deleted": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Value": "exercitationem",
  "Tooltip": "ipsam",
  "Id": 743,
  "Rank": 159,
  "Deleted": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 317
    }
  }
}
```