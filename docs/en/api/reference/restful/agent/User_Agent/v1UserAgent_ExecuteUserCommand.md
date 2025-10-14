---
title: POST Agents/User/ExecuteUserCommand
uid: v1UserAgent_ExecuteUserCommand
generated: true
content_type: reference
---

# POST Agents/User/ExecuteUserCommand

```http
POST /api/v1/Agents/User/ExecuteUserCommand
```

Executes the custom command for User


NsApiSlow threshold: 2000 ms.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| commandName | string | **Required**  |
| actionResult | Enum: Implicit, Yes, Ok, No, Cancel | **Required**  |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/ExecuteUserCommand?commandName=Pfannerstill, Legros and Little
POST /api/v1/Agents/User/ExecuteUserCommand?actionResult=Cancel
POST /api/v1/Agents/User/ExecuteUserCommand?$select=name,department,category/id
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

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CommandResult

| Property Name | Type |  Description |
|----------------|------|--------------|
| Success | bool | The command was successfully executed. |
| Message | string | Message which should be displayed in GUI. |
| Result | string | The result used in this action. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/User/ExecuteUserCommand
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 516,
  "Name": "Marks Inc and Sons",
  "Rank": 233,
  "Tooltip": "neque",
  "LicenseOwners": [
    {
      "Name": "Kiehn, Balistreri and Kautzer",
      "Description": "Exclusive multimedia circuit",
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
      "Name": "Kiehn, Balistreri and Kautzer",
      "Description": "Exclusive multimedia circuit",
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
      "Value": "cupiditate",
      "Tooltip": "dolor",
      "Id": 112,
      "Rank": 391,
      "Deleted": false
    },
    {
      "Value": "cupiditate",
      "Tooltip": "dolor",
      "Id": 112,
      "Rank": 391,
      "Deleted": false
    }
  ],
  "Person": null,
  "Deleted": false,
  "Lastlogin": "2017-07-10T03:40:48.2036224+02:00",
  "Lastlogout": "2010-02-24T03:40:48.2036224+01:00",
  "EjUserId": 971,
  "RequestSignature": "tempora",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": null,
      "Value": "nisi",
      "DisplayValue": "sunt"
    },
    {
      "Type": null,
      "Value": "nisi",
      "DisplayValue": "sunt"
    }
  ],
  "UserName": "Tromp-Abbott",
  "TicketCategories": [
    {
      "Id": 88,
      "Name": "Stracke Group",
      "ToolTip": "Ea libero dolorem.",
      "Deleted": true,
      "Rank": 102,
      "Type": "cumque",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "velit",
      "ColorBlock": 868,
      "ExtraInfo": "reprehenderit",
      "StyleHint": "ut",
      "FullName": "Heloise Muller"
    }
  ],
  "NickName": "Lockman LLC",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "voluptas"
  },
  "PostSaveCommands": [
    {
      "Name": "Leannon-Morissette",
      "DisplayName": "Beier-Leffler",
      "Description": "Enterprise-wide object-oriented analyzer",
      "ToolTip": "Consequatur id accusamus.",
      "Actions": "Implicit",
      "ActionData": "qui"
    },
    {
      "Name": "Leannon-Morissette",
      "DisplayName": "Beier-Leffler",
      "Description": "Enterprise-wide object-oriented analyzer",
      "ToolTip": "Consequatur id accusamus.",
      "Actions": "Implicit",
      "ActionData": "qui"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Success": false,
  "Message": "aut",
  "Result": "Cancel",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 428
    }
  }
}
```