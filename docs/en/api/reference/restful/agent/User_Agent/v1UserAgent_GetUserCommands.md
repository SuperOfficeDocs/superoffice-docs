---
title: POST Agents/User/GetUserCommands
uid: v1UserAgent_GetUserCommands
generated: true
content_type: reference
---

# POST Agents/User/GetUserCommands

```http
POST /api/v1/Agents/User/GetUserCommands
```

Get registered custom commands for User


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/GetUserCommands?$select=name,department,category/id
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

## Request Body: user 

SuperOffice User, with login credentials and an associated person.
<para />
Carrier object for User.
Services for the User Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>. 

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

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | Unique name of the command |
| DisplayName | string | The name to show in GUI |
| Description | string | Description of the command. |
| ToolTip | string | Tooltip to be used in the GUI |
| Actions | string | The actions to call when invoked |
| ActionData | string | The data to be used when the command is invoked |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/User/GetUserCommands
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 373,
  "Name": "Balistreri Group",
  "Rank": 234,
  "Tooltip": "omnis",
  "LicenseOwners": [
    {
      "Name": "Batz-Adams",
      "Description": "Synchronised web-enabled firmware",
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
      "Name": "Batz-Adams",
      "Description": "Synchronised web-enabled firmware",
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
      "Value": "corporis",
      "Tooltip": "neque",
      "Id": 624,
      "Rank": 774,
      "Deleted": false
    },
    {
      "Value": "corporis",
      "Tooltip": "neque",
      "Id": 624,
      "Rank": 774,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2002-11-25T03:41:54.3400739+01:00",
  "Lastlogout": "1998-06-09T03:41:54.3400739+02:00",
  "EjUserId": 559,
  "RequestSignature": "et",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "et",
      "DisplayValue": "illum"
    },
    {
      "Type": null,
      "Value": "et",
      "DisplayValue": "illum"
    }
  ],
  "UserName": "Krajcik, Mitchell and Gleason",
  "TicketCategories": [
    {
      "Id": 847,
      "Name": "McLaughlin Inc and Sons",
      "ToolTip": "Voluptates exercitationem iste dolor.",
      "Deleted": false,
      "Rank": 311,
      "Type": "totam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "rem",
      "ColorBlock": 469,
      "ExtraInfo": "et",
      "StyleHint": "qui",
      "FullName": "Carolyne Moen"
    }
  ],
  "NickName": "Fay, Kessler and Hoeger",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "porro"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "ab"
  },
  "PostSaveCommands": [
    {
      "Name": "Swift Group",
      "DisplayName": "Collier, Walsh and Gottlieb",
      "Description": "Customer-focused even-keeled help-desk",
      "ToolTip": "Animi perspiciatis ipsum quibusdam.",
      "Actions": "Implicit",
      "ActionData": "quia"
    },
    {
      "Name": "Swift Group",
      "DisplayName": "Collier, Walsh and Gottlieb",
      "Description": "Customer-focused even-keeled help-desk",
      "ToolTip": "Animi perspiciatis ipsum quibusdam.",
      "Actions": "Implicit",
      "ActionData": "quia"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Rowe-Volkman",
    "DisplayName": "Ferry, McKenzie and Boyer",
    "Description": "Polarised bandwidth-monitored website",
    "ToolTip": "Vel accusantium est nihil hic occaecati.",
    "Actions": "Implicit",
    "ActionData": "sunt",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 145
      }
    }
  }
]
```