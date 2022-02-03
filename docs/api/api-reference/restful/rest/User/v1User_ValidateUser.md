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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 174,
  "Name": "Hodkiewicz, Wolf and Swaniawski",
  "Rank": 169,
  "Tooltip": "non",
  "LicenseOwners": [
    {
      "Name": "Yost, Becker and Welch",
      "Description": "Progressive background archive",
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
      "Name": "Yost, Becker and Welch",
      "Description": "Progressive background archive",
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
    "Id": 571,
    "Value": "enim",
    "Tooltip": "nemo"
  },
  "UserGroup": {
    "Value": "ipsa",
    "Tooltip": "aspernatur",
    "Id": 261,
    "Rank": 245,
    "Deleted": true
  },
  "OtherGroups": [
    {
      "Value": "quo",
      "Tooltip": "odit",
      "Id": 333,
      "Rank": 786,
      "Deleted": false
    },
    {
      "Value": "quo",
      "Tooltip": "odit",
      "Id": 333,
      "Rank": 786,
      "Deleted": false
    }
  ],
  "Person": {
    "Position": "et",
    "PersonId": 482,
    "Mrmrs": "dolores",
    "Firstname": "Robb",
    "Lastname": "Schultz",
    "MiddleName": "Langworth-Hirthe",
    "Title": "saepe",
    "Description": "Future-proofed uniform solution",
    "Email": "dashawn@howell.com",
    "FullName": "Dylan Rau",
    "DirectPhone": "630-676-1682 x0115",
    "FormalName": "Boyle-Lebsack",
    "CountryId": 840,
    "ContactId": 990,
    "ContactName": "Tremblay-Kuhn",
    "Retired": 755,
    "Rank": 733,
    "ActiveInterests": 902,
    "ContactDepartment": "",
    "ContactCountryId": 944,
    "ContactOrgNr": "1027552",
    "FaxPhone": "212-403-3743",
    "MobilePhone": "1-585-005-6185 x6236",
    "ContactPhone": "(537)470-7808",
    "AssociateName": "Murphy, Marquardt and Berge",
    "AssociateId": 759,
    "UsePersonAddress": false,
    "ContactFax": "animi",
    "Kanafname": "minima",
    "Kanalname": "consectetur",
    "Post1": "vel",
    "Post2": "velit",
    "Post3": "sit",
    "EmailName": "josephine@trantow.info",
    "ContactFullName": "Alf West",
    "ActiveErpLinks": 608,
    "TicketPriorityId": 669,
    "SupportLanguageId": 821,
    "SupportAssociateId": 953,
    "CategoryName": "VIP Customer"
  },
  "Deleted": false,
  "Lastlogin": "2018-06-21T18:25:51.5431212+02:00",
  "Lastlogout": "2016-12-23T18:25:51.5431212+01:00",
  "EjUserId": 14,
  "RequestSignature": "eos",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "quisquam",
      "DisplayValue": "nihil"
    },
    {
      "Type": {},
      "Value": "quisquam",
      "DisplayValue": "nihil"
    }
  ],
  "UserName": "Nolan-Wolf",
  "TicketCategories": [
    {
      "Id": 865,
      "Name": "D'Amore-Sanford",
      "ToolTip": "Non voluptatibus aut vero omnis.",
      "Deleted": true,
      "Rank": 779,
      "Type": "qui",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sapiente",
      "ColorBlock": 460,
      "ExtraInfo": "cum",
      "StyleHint": "quidem",
      "FullName": "Alexa Roob"
    }
  ],
  "NickName": "Kub, Collins and Emmerich",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "suscipit"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "dolores"
  },
  "PostSaveCommands": [
    {
      "Name": "Hettinger Group",
      "DisplayName": "Cummings Inc and Sons",
      "Description": "Intuitive systemic function",
      "ToolTip": "Maiores eligendi omnis.",
      "Actions": "Implicit",
      "ActionData": "voluptas"
    },
    {
      "Name": "Hettinger Group",
      "DisplayName": "Cummings Inc and Sons",
      "Description": "Intuitive systemic function",
      "ToolTip": "Maiores eligendi omnis.",
      "Actions": "Implicit",
      "ActionData": "voluptas"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "repudiandae",
  "2": "reprehenderit"
}
```