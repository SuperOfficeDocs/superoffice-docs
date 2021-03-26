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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 758,
  "Name": "Durgan, Nader and Trantow",
  "Rank": 128,
  "Tooltip": "repellat",
  "LicenseOwners": [
    {
      "Name": "Mertz, Hintz and Greenfelder",
      "Description": "Triple-buffered heuristic policy",
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
      "Name": "Mertz, Hintz and Greenfelder",
      "Description": "Triple-buffered heuristic policy",
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
    "Id": 692,
    "Value": "odit",
    "Tooltip": "itaque"
  },
  "UserGroup": {
    "Value": "nobis",
    "Tooltip": "sit",
    "Id": 61,
    "Rank": 141,
    "Deleted": true
  },
  "OtherGroups": [
    {
      "Value": "ea",
      "Tooltip": "cupiditate",
      "Id": 587,
      "Rank": 901,
      "Deleted": true
    },
    {
      "Value": "ea",
      "Tooltip": "cupiditate",
      "Id": 587,
      "Rank": 901,
      "Deleted": true
    }
  ],
  "Person": {
    "Position": "minus",
    "PersonId": 362,
    "Mrmrs": "est",
    "Firstname": "Willa",
    "Lastname": "Durgan",
    "MiddleName": "Douglas-O'Conner",
    "Title": "inventore",
    "Description": "Assimilated modular capability",
    "Email": "ottis@gislasonboehm.biz",
    "FullName": "Dr. Cielo Marquardt",
    "DirectPhone": "555.207.3410 x2838",
    "FormalName": "Maggio, Kris and Harris",
    "CountryId": 371,
    "ContactId": 3,
    "ContactName": "Steuber Group",
    "Retired": 217,
    "Rank": 678,
    "ActiveInterests": 920,
    "ContactDepartment": "",
    "ContactCountryId": 818,
    "ContactOrgNr": "955005",
    "FaxPhone": "148-357-8575 x44177",
    "MobilePhone": "230-557-5576",
    "ContactPhone": "514.568.1133",
    "AssociateName": "D'Amore-Satterfield",
    "AssociateId": 533,
    "UsePersonAddress": false,
    "ContactFax": "laboriosam",
    "Kanafname": "qui",
    "Kanalname": "ex",
    "Post1": "eligendi",
    "Post2": "laudantium",
    "Post3": "est",
    "EmailName": "fiona@hamill.uk",
    "ContactFullName": "Hilma Hudson",
    "ActiveErpLinks": 89,
    "TicketPriorityId": 816,
    "SupportLanguageId": 490,
    "SupportAssociateId": 986,
    "CategoryName": "VIP Customer"
  },
  "Deleted": false,
  "Lastlogin": "2010-03-05T09:41:00.0960621+01:00",
  "Lastlogout": "1998-11-08T09:41:00.0960621+01:00",
  "EjUserId": 701,
  "RequestSignature": "quia",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "aut",
      "DisplayValue": "reiciendis"
    },
    {
      "Type": {},
      "Value": "aut",
      "DisplayValue": "reiciendis"
    }
  ],
  "UserName": "Reynolds LLC",
  "TicketCategories": [
    {
      "Id": 461,
      "Name": "Bogan LLC",
      "ToolTip": "Et corrupti sunt illo aliquid quis sequi.",
      "Deleted": true,
      "Rank": 121,
      "Type": "id",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "omnis",
      "ColorBlock": 657,
      "ExtraInfo": "officiis",
      "StyleHint": "veniam",
      "FullName": "Katheryn Koelpin"
    }
  ],
  "NickName": "Quigley Inc and Sons",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "consequuntur"
  },
  "PostSaveCommands": [
    {
      "Name": "Tromp Group",
      "DisplayName": "Nolan, Shields and Wilderman",
      "Description": "Triple-buffered human-resource collaboration",
      "ToolTip": "Commodi deleniti sed commodi exercitationem qui voluptatem.",
      "Actions": "Implicit",
      "ActionData": "vel"
    },
    {
      "Name": "Tromp Group",
      "DisplayName": "Nolan, Shields and Wilderman",
      "Description": "Triple-buffered human-resource collaboration",
      "ToolTip": "Commodi deleniti sed commodi exercitationem qui voluptatem.",
      "Actions": "Implicit",
      "ActionData": "vel"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "molestias",
  "2": "excepturi"
}
```