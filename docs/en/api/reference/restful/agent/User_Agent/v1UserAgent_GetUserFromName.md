---
title: POST Agents/User/GetUserFromName
uid: v1UserAgent_GetUserFromName
generated: true
---

# POST Agents/User/GetUserFromName

```http
POST /api/v1/Agents/User/GetUserFromName
```

Get a user, with lookup based on user name.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUserFromName?$select=name,department,category/id
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

UserName 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserName | String |  |

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
POST /api/v1/Agents/User/GetUserFromName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "UserName": "Schaden, Davis and Stanton"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 143,
  "Name": "Abshire Group",
  "Rank": 744,
  "Tooltip": "sunt",
  "LicenseOwners": [
    {
      "Name": "Yundt LLC",
      "Description": "Intuitive fresh-thinking extranet",
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
          "FieldLength": 616
        }
      }
    },
    {
      "Name": "Yundt LLC",
      "Description": "Intuitive fresh-thinking extranet",
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
          "FieldLength": 616
        }
      }
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "alias",
      "Tooltip": "optio",
      "Id": 263,
      "Rank": 269,
      "Deleted": true,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 611
        }
      }
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2002-10-22T03:45:24.1704335+02:00",
  "Lastlogout": "2021-04-06T03:45:24.1704335+02:00",
  "EjUserId": 689,
  "RequestSignature": "ea",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": null,
      "Value": "quaerat",
      "DisplayValue": "sit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 594
        }
      }
    },
    {
      "Type": null,
      "Value": "quaerat",
      "DisplayValue": "sit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 594
        }
      }
    }
  ],
  "UserName": "Corkery, Berge and Gerlach",
  "TicketCategories": [
    {
      "Id": 865,
      "Name": "Nienow-Spinka",
      "ToolTip": "Dignissimos voluptatem aliquam vel.",
      "Deleted": false,
      "Rank": 833,
      "Type": "earum",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "assumenda",
      "ColorBlock": 494,
      "ExtraInfo": "non",
      "StyleHint": "voluptatem",
      "FullName": "Dr. Herta Keira Smitham",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 58
        }
      }
    }
  ],
  "NickName": "Dooley, Bednar and Padberg",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "nulla"
  },
  "PostSaveCommands": [
    {
      "Name": "Kihn, Gleichner and Beier",
      "DisplayName": "Schiller LLC",
      "Description": "Pre-emptive object-oriented forecast",
      "ToolTip": "Ut quasi dolor.",
      "Actions": "Implicit",
      "ActionData": "pariatur",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 265
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 500
    }
  }
}
```