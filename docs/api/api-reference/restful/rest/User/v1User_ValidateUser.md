---
title: POST User/Validate
id: v1User_ValidateUser
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


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/User/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 694,
  "Name": "Lindgren-DuBuque",
  "Rank": 392,
  "Tooltip": "necessitatibus",
  "LicenseOwners": [
    {
      "Name": "Langworth LLC",
      "Description": "Optimized 3rd generation frame",
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
      "Name": "Langworth LLC",
      "Description": "Optimized 3rd generation frame",
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
  "Role": {
    "Id": 735,
    "Value": "vitae",
    "Tooltip": "et"
  },
  "UserGroup": {
    "Value": "consequuntur",
    "Tooltip": "et",
    "Id": 771,
    "Rank": 312,
    "Deleted": true
  },
  "OtherGroups": [
    {
      "Value": "ducimus",
      "Tooltip": "maxime",
      "Id": 430,
      "Rank": 434,
      "Deleted": true
    },
    {
      "Value": "ducimus",
      "Tooltip": "maxime",
      "Id": 430,
      "Rank": 434,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "et",
    "PersonId": 50,
    "Mrmrs": "eos",
    "Firstname": "Ernie",
    "Lastname": "Graham",
    "MiddleName": "Kovacek Group",
    "Title": "quae",
    "Description": "Configurable regional ability",
    "Email": "antwan@boyer.com",
    "FullName": "Angelo Steuber",
    "DirectPhone": "103-630-8414",
    "FormalName": "Quigley, Welch and Altenwerth",
    "CountryId": 368,
    "ContactId": 443,
    "ContactName": "Leffler-Harber",
    "Retired": 724,
    "Rank": 209,
    "ActiveInterests": 291,
    "ContactDepartment": "",
    "ContactCountryId": 112,
    "ContactOrgNr": "187569",
    "FaxPhone": "1-615-085-8126",
    "MobilePhone": "411.554.5360 x3342",
    "ContactPhone": "1-107-624-3612 x5460",
    "AssociateName": "Schowalter Inc and Sons",
    "AssociateId": 687,
    "UsePersonAddress": false,
    "ContactFax": "sed",
    "Kanafname": "officia",
    "Kanalname": "qui",
    "Post1": "omnis",
    "Post2": "dolore",
    "Post3": "facere",
    "EmailName": "maybell@kub.us",
    "ContactFullName": "Jacky Gibson",
    "ActiveErpLinks": 125,
    "TicketPriorityId": 461,
    "SupportLanguageId": 920,
    "SupportAssociateId": 327,
    "CategoryName": "VIP Customer"
  },
  "Deleted": true,
  "Lastlogin": "2020-07-16T15:05:43.1768998+02:00",
  "Lastlogout": "1995-06-30T15:05:43.1768998+02:00",
  "EjUserId": 277,
  "RequestSignature": "minima",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": false,
  "Credentials": [
    {
      "Type": {},
      "Value": "et",
      "DisplayValue": "odio"
    },
    {
      "Type": {},
      "Value": "et",
      "DisplayValue": "odio"
    }
  ],
  "UserName": "Toy Group",
  "TicketCategories": [
    {
      "Id": 761,
      "Name": "Labadie Group",
      "ToolTip": "Et est dignissimos animi neque.",
      "Deleted": true,
      "Rank": 603,
      "Type": "deserunt",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "expedita",
      "ColorBlock": 676,
      "ExtraInfo": "optio",
      "StyleHint": "et",
      "FullName": "Kirk Wisoky"
    }
  ],
  "NickName": "Abshire LLC",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "incidunt"
  },
  "CustomFields": {
    "CustomFields1": "laborum",
    "CustomFields2": "inventore"
  },
  "PostSaveCommands": [
    {
      "Name": "Beatty, Sawayn and McCullough",
      "DisplayName": "Langosh Group",
      "Description": "Optional solution-oriented migration",
      "ToolTip": "Quasi ut a et dolor.",
      "Actions": "Implicit",
      "ActionData": "laboriosam"
    },
    {
      "Name": "Beatty, Sawayn and McCullough",
      "DisplayName": "Langosh Group",
      "Description": "Optional solution-oriented migration",
      "ToolTip": "Quasi ut a et dolor.",
      "Actions": "Implicit",
      "ActionData": "laboriosam"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "delectus",
  "2": "aut"
}
```