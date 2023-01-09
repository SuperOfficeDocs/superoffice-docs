---
title: POST User/Validate
uid: v1User_ValidateUser
---

# POST User/Validate

```http
POST /api/v1/User/Validate
```

Check that entity is ready for saving, return error messages by field.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.







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

## Request Body: user 

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | Integer | Primary key |
| Name | String | Initials, UserId - also used as login name for on-site installations. Identifies user in archives. |
| Rank | Integer | Rank order |
| Tooltip | String | Tooltip or other description |
| LicenseOwners | Array | The restricted and unrestricted module licenses grouped by license owner. These module licenses are either assigned or unassigned to this user |
| Role | Role | Users role for role-based security. Determines permissions and access rights for the user. |
| UserGroup | UserGroup | The main user group that this user belongs to.  <para>Use MDO List name "usergroup" to get list items.</para> |
| OtherGroups | Array | The other groups this user is a member of, apart from the main user group.  <para>Use MDO List name "usergroup" to get list items.</para> |
| Person | Person | The person associated with this user. Detailed information about the user  <para>Use MDO List name "person_new" to get list items.</para> |
| Deleted | Boolean | If true, the user is retired and should have no rights, not appear in lists, etc. |
| Lastlogin | String | Last login date |
| Lastlogout | String | Last logout date |
| EjUserId | Integer | ID of the ej user record corresponding to this associate; 0 for associates that are not ej users |
| RequestSignature | String | ej users request signature |
| Type | String | User type: 1=InternalAssociate, 2=ResourceAssociate, 3=ExternalAssociate, 4=AnonymousAssociate, 5=SystemAssociate |
| IsPersonRetired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| IsOnTravel | Boolean | True if the user is on travel. |
| Credentials | Array | List of credentials registered for this user. i.e. valid authentication methods. |
| UserName | String | User name, a.k.a. Login name. This might be an e-mail address. |
| TicketCategories | Array | Request Ticket Categories assigned to the user.   <para>Use MDO List name "ejCategory" to get list items.</para> |
| NickName | String | The unique nick name for this user. Used in Service as an alias, similar to Name/Initials. |
| WaitingForApproval | Boolean | The user is waiting for an administrator to approve/grant her/him access. |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.User.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.User.ExtraFields} and <see cref="!:UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PostSaveCommands | Array | Post custom commands the client should execute after save has completed. |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/User/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 392,
  "Name": "Thompson, Fadel and Weber",
  "Rank": 884,
  "Tooltip": "ducimus",
  "LicenseOwners": [
    {
      "Name": "Kassulke LLC",
      "Description": "Synergized impactful infrastructure",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ]
    },
    {
      "Name": "Kassulke LLC",
      "Description": "Synergized impactful infrastructure",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ]
    }
  ],
  "Role": null,
  "UserGroup": null,
  "OtherGroups": [
    {
      "Value": "voluptatem",
      "Tooltip": "consequatur",
      "Id": 468,
      "Rank": 16,
      "Deleted": false
    },
    {
      "Value": "voluptatem",
      "Tooltip": "consequatur",
      "Id": 468,
      "Rank": 16,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2000-03-20T17:37:39.5804304+01:00",
  "Lastlogout": "2014-05-20T17:37:39.5804304+02:00",
  "EjUserId": 593,
  "RequestSignature": "repellat",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "totam",
      "DisplayValue": "corrupti"
    },
    {
      "Type": null,
      "Value": "totam",
      "DisplayValue": "corrupti"
    }
  ],
  "UserName": "Schinner Group",
  "TicketCategories": [
    {
      "Id": 767,
      "Name": "Swaniawski-Bergstrom",
      "ToolTip": "Accusantium voluptas rem.",
      "Deleted": false,
      "Rank": 486,
      "Type": "omnis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quasi",
      "ColorBlock": 735,
      "ExtraInfo": "culpa",
      "StyleHint": "et",
      "FullName": "Bridget Wilderman"
    }
  ],
  "NickName": "Beatty-King",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "delectus"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "libero"
  },
  "PostSaveCommands": [
    {
      "Name": "Frami-Kshlerin",
      "DisplayName": "Weissnat-Emmerich",
      "Description": "Persevering intermediate process improvement",
      "ToolTip": "Odit corrupti magni.",
      "Actions": "Implicit",
      "ActionData": "iure"
    },
    {
      "Name": "Frami-Kshlerin",
      "DisplayName": "Weissnat-Emmerich",
      "Description": "Persevering intermediate process improvement",
      "ToolTip": "Odit corrupti magni.",
      "Actions": "Implicit",
      "ActionData": "iure"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "suscipit",
  "2": "eaque"
}
```