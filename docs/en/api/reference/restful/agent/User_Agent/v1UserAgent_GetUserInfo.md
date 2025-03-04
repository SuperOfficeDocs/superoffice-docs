---
title: POST Agents/User/GetUserInfo
uid: v1UserAgent_GetUserInfo
generated: true
---

# POST Agents/User/GetUserInfo

```http
POST /api/v1/Agents/User/GetUserInfo
```

Gets a UserInfo object.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| userInfoId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUserInfo?userInfoId=217
POST /api/v1/Agents/User/GetUserInfo?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: UserInfo

| Property Name | Type |  Description |
|----------------|------|--------------|
| Deleted | bool | If true, the user is retired and should have no rights, not appear in lists, etc. |
| UserInfoId | int32 | Primary key |
| UserName | string | Initials, also login name, possibly database user name |
| PersonId | int32 | Owning person record |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| UserGroupId | int32 | Primary group membership, see UserGroupLink for secondary memberships |
| EjUserId | int32 | ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| UserType | string |  |
| GrantedLicenses | array |  |
| CanLogon | bool |  |
| RoleName | string |  |
| RoleTooltip | string |  |
| UserGroupName | string |  |
| UserGroupTooltip | string |  |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/User/GetUserInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Deleted": false,
  "UserInfoId": 152,
  "UserName": "Murazik LLC",
  "PersonId": 689,
  "Rank": 504,
  "Tooltip": "ratione",
  "UserGroupId": 545,
  "EjUserId": 560,
  "UserType": "AnonymousAssociate",
  "GrantedLicenses": [
    "quo",
    "reiciendis"
  ],
  "CanLogon": true,
  "RoleName": "Tromp-Schiller",
  "RoleTooltip": "ipsa",
  "UserGroupName": "Bailey-Kshlerin",
  "UserGroupTooltip": "ratione",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 372
    }
  }
}
```