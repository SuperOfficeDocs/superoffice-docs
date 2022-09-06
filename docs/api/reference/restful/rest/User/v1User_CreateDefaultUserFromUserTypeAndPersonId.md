---
title: GET User/Default
uid: v1User_CreateDefaultUserFromUserTypeAndPersonId
---

# GET User/Default

```http
GET /api/v1/User/Default
```

Create default User providing the associate type and person id.

System and Anonymous users can be created without an exsisting person and permits person id to be 0.

## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| userType | Enum: Unknown, InternalAssociate, ResourceAssociate, ExternalAssociate, AnonymousAssociate, SystemAssociate |  Type of associate for the user |
| personId | int32 |  Primary key of the person to become a user. |

```http
GET /api/v1/User/Default?userType=AnonymousAssociate
GET /api/v1/User/Default?personId=272
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 | Primary key |
| Name | string | Initials, UserId - also used as login name for on-site installations. Identifies user in archives. |
| Rank | int32 | Rank order |
| Tooltip | string | Tooltip or other description |
| LicenseOwners | array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| Role |  | Users role for role-based security. Determines permissions and access rights for the user. |
| UserGroup |  | The main user group that this user belongs to.  <para>Use MDO List name "usergroup" to get list items.</para> |
| OtherGroups | array | The other groups this user is a member of, apart from the main user group.  <para>Use MDO List name "usergroup" to get list items.</para> |
| Person |  | The person associated with this user. Detailed information about the user  <para>Use MDO List name "person_new" to get list items.</para> |
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
| TicketCategories | array | Request Ticket Categories assigned to the user.   <para>Use MDO List name "ejCategory" to get list items.</para> |
| NickName | string | The unique nick name for this user. Used in Service as an alias, similar to Name/Initials. |
| WaitingForApproval | bool | The user is waiting for an administrator to approve/grant her/him access. |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.User.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.User.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PostSaveCommands | array | Post custom commands the client should execute after save has completed. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/User/Default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 903,
  "Name": "Abbott-Macejkovic",
  "Rank": 434,
  "Tooltip": "doloremque",
  "LicenseOwners": [
    {
      "Name": "Runolfsson-Kovacek",
      "Description": "Configurable solution-oriented archive",
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
          "FieldLength": 119
        }
      }
    },
    {
      "Name": "Runolfsson-Kovacek",
      "Description": "Configurable solution-oriented archive",
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
          "FieldLength": 119
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "laborum",
      "Tooltip": "quia",
      "Id": 917,
      "Rank": 685,
      "Deleted": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 839
        }
      }
    }
  ],
  "Person": null,
  "Deleted": true,
  "Lastlogin": "2018-01-02T11:10:53.8512177+01:00",
  "Lastlogout": "2004-02-16T11:10:53.8512177+01:00",
  "EjUserId": 75,
  "RequestSignature": "voluptates",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "totam",
      "DisplayValue": "qui",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 880
        }
      }
    },
    {
      "Type": null,
      "Value": "totam",
      "DisplayValue": "qui",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 880
        }
      }
    }
  ],
  "UserName": "Corkery-Wiegand",
  "TicketCategories": [
    {
      "Id": 998,
      "Name": "Schumm, Mohr and Koss",
      "ToolTip": "Rerum sed nostrum.",
      "Deleted": false,
      "Rank": 112,
      "Type": "iste",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "molestiae",
      "ColorBlock": 660,
      "ExtraInfo": "sit",
      "StyleHint": "fugiat",
      "FullName": "Prof. Graciela Filiberto Kunze V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 657
        }
      }
    }
  ],
  "NickName": "Daugherty, Kertzmann and Toy",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "iste",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "dolore",
    "CustomFields2": "repellendus"
  },
  "PostSaveCommands": [
    {
      "Name": "Jewess-Haley",
      "DisplayName": "Schmidt, Russel and Wolff",
      "Description": "Managed optimal orchestration",
      "ToolTip": "Ut aperiam exercitationem eaque amet et.",
      "Actions": "Implicit",
      "ActionData": "sit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 510
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 488
    }
  }
}
```
