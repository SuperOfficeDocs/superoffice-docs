---
title: POST Agents/User/GetUserFromEjUserId
uid: v1UserAgent_GetUserFromEjUserId
generated: true
content_type: reference
---

# POST Agents/User/GetUserFromEjUserId

```http
POST /api/v1/Agents/User/GetUserFromEjUserId
```

Get user from ejUserId - used for eJournal Legacy Support.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUserFromEjUserId?$select=name,department,category/id
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

EjUserId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EjUserId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 | Primary key |
| Name | string | Initials, UserId - also used as login name for on-site installations. Identifies user in archives. |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| Role | Role | Users role for role-based security. Determines permissions and access rights for the user. |
| UserGroup | UserGroup | The main user group that this user belongs to.  Use MDO List name "usergroup" to get list items. |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  Use MDO List name "usergroup" to get list items. |
| Person | Person | The person associated with this user. Detailed information about the user  Use MDO List name "person_new" to get list items. |
| Deleted | bool | If true, the user is retired and should have no rights, not appear in lists, etc. |
| Lastlogin | date-time | Last login date |
| Lastlogout | date-time | Last logout date |
| EjUserId | int32 | ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| RequestSignature | string | ej users request signature |
| Type | string | User type: 1=InternalAssociate, 2=ResourceAssociate, 3=ExternalAssociate, 4=AnonymousAssociate, 5=SystemAssociate |
| IsPersonRetired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| IsOnTravel | bool | True if the user is on travel. |
| Credentials | array | List of credentials registered for this user. i.e. valid authentication methods. |
| UserName | string | User name, a.k.a. Login name. This might be an e-mail address. |
| TicketCategories | array | Request Ticket Categories assigned to the user.   Use MDO List name "ejCategory" to get list items. |
| NickName | string | The unique nick name for this user. Used in Service as an alias, similar to Name/Initials. |
| WaitingForApproval | bool | The user is waiting for an administrator to approve/grant her/him access. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.User.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.User.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PostSaveCommands | array | Post custom commands the client should execute after save has completed. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/User/GetUserFromEjUserId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EjUserId": 108
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AssociateId": 989,
    "Name": "O'Conner-Wintheiser",
    "Rank": 952,
    "Tooltip": "laudantium",
    "LicenseOwners": [
      {
        "Name": "Ortiz-Lesch",
        "Description": "Adaptive asynchronous product",
        "RestrictedModuleLicenses": [
          {},
          {}
        ],
        "UnrestrictedModuleLicenses": [
          {},
          {}
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 621
          }
        }
      },
      {
        "Name": "Ortiz-Lesch",
        "Description": "Adaptive asynchronous product",
        "RestrictedModuleLicenses": [
          {},
          {}
        ],
        "UnrestrictedModuleLicenses": [
          {},
          {}
        ],
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 621
          }
        }
      }
    ],
    "Role": null,
    "UserGroup": null,
    "OtherGroups": [
      {
        "Value": "repellendus",
        "Tooltip": "maiores",
        "Id": 901,
        "Rank": 363,
        "Deleted": false,
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 496
          }
        }
      }
    ],
    "Person": null,
    "Deleted": false,
    "Lastlogin": "1999-11-01T03:41:54.3713224+01:00",
    "Lastlogout": "2012-05-28T03:41:54.3713224+02:00",
    "EjUserId": 156,
    "RequestSignature": "eius",
    "Type": "AnonymousAssociate",
    "IsPersonRetired": false,
    "IsOnTravel": false,
    "Credentials": [
      {
        "Type": null,
        "Value": "itaque",
        "DisplayValue": "aspernatur",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 992
          }
        }
      },
      {
        "Type": null,
        "Value": "itaque",
        "DisplayValue": "aspernatur",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 992
          }
        }
      }
    ],
    "UserName": "Adams, Johnson and Grady",
    "TicketCategories": [
      {
        "Id": 737,
        "Name": "Green Inc and Sons",
        "ToolTip": "Ipsum quo ab.",
        "Deleted": true,
        "Rank": 243,
        "Type": "modi",
        "ChildItems": [
          {},
          {}
        ],
        "IconHint": "quasi",
        "ColorBlock": 111,
        "ExtraInfo": "id",
        "StyleHint": "hic",
        "FullName": "Hiram Reichel",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 895
          }
        }
      }
    ],
    "NickName": "Mayer-Denesik",
    "WaitingForApproval": true,
    "ExtraFields": {
      "ExtraFields1": "quia",
      "ExtraFields2": "aut"
    },
    "CustomFields": {
      "CustomFields1": "esse",
      "CustomFields2": "illo"
    },
    "PostSaveCommands": [
      {
        "Name": "Homenick, Bruen and Jones",
        "DisplayName": "Brown, Green and Satterfield",
        "Description": "Implemented exuding neural-net",
        "ToolTip": "Doloribus beatae aperiam quisquam et molestiae aut molestiae.",
        "Actions": "Implicit",
        "ActionData": "et",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 154
          }
        }
      }
    ],
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 526
      }
    }
  }
]
```