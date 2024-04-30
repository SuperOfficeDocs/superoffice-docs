---
title: POST Agents/User/CreateDefaultUser
uid: v1UserAgent_CreateDefaultUser
generated: true
---

# POST Agents/User/CreateDefaultUser

```http
POST /api/v1/Agents/User/CreateDefaultUser
```

Set default values into a new User.


NetServer calculates default values on the entity, which is required when creating/storing a new instance


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.







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

### Response body: User

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
POST /api/v1/Agents/User/CreateDefaultUser
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 528,
  "Name": "Murazik, Keeling and Koelpin",
  "Rank": 585,
  "Tooltip": "et",
  "LicenseOwners": [
    {
      "Name": "Batz Group",
      "Description": "Triple-buffered assymetric groupware",
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
          "FieldType": "System.String",
          "FieldLength": 617
        }
      }
    },
    {
      "Name": "Batz Group",
      "Description": "Triple-buffered assymetric groupware",
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
          "FieldType": "System.String",
          "FieldLength": 617
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "debitis",
      "Tooltip": "iste",
      "Id": 55,
      "Rank": 861,
      "Deleted": false,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2013-12-14T11:44:34.9469084+01:00",
  "Lastlogout": "2001-01-18T11:44:34.9469084+01:00",
  "EjUserId": 563,
  "RequestSignature": "reprehenderit",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "pariatur",
      "DisplayValue": "debitis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 21
        }
      }
    },
    {
      "Type": null,
      "Value": "pariatur",
      "DisplayValue": "debitis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 21
        }
      }
    }
  ],
  "UserName": "Auer, Hermiston and Kunde",
  "TicketCategories": [
    {
      "Id": 11,
      "Name": "Reinger-Hintz",
      "ToolTip": "Inventore doloremque.",
      "Deleted": true,
      "Rank": 658,
      "Type": "eum",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "nulla",
      "ColorBlock": 253,
      "ExtraInfo": "suscipit",
      "StyleHint": "et",
      "FullName": "Miss Hollie Timothy Walker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    }
  ],
  "NickName": "Lubowitz-Buckridge",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "maxime"
  },
  "CustomFields": {
    "CustomFields1": "accusantium",
    "CustomFields2": "aut"
  },
  "PostSaveCommands": [
    {
      "Name": "Bode-Mraz",
      "DisplayName": "Spinka, Ruecker and Kihn",
      "Description": "Grass-roots 4th generation projection",
      "ToolTip": "Illum ducimus nihil sed dignissimos.",
      "Actions": "Implicit",
      "ActionData": "blanditiis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 613
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 322
    }
  }
}
```