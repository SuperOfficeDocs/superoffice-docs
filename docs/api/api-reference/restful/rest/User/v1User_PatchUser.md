---
title: PATCH User/{id}
id: v1User_PatchUser
---

# PATCH User/{id}

```http
PATCH /api/v1/User/{id}
```

Update a User with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IUserAgent} service SaveUser.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The User  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/User/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

SuperOffice User, with login credentials and an associated person.



User entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | User  updated. |
| 404 | User with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because User has changed since the requested If-Unmodified-Since timestamp. |

Response body: object

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
| _Links | object |  |

## Sample Request

```http!
PATCH /api/v1/User/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "qui",
    "value": {
      "value1": {
        "PrimaryKey": 1921,
        "EntityName": "person",
        "personId": 1921,
        "fullName": "Oscar Kuhlman"
      },
      "value2": {
        "PrimaryKey": 4483,
        "EntityName": "person",
        "personId": 4483,
        "fullName": "Alysson Bechtelar II"
      }
    }
  },
  {
    "op": "add",
    "path": "qui",
    "value": {
      "value1": {
        "PrimaryKey": 1921,
        "EntityName": "person",
        "personId": 1921,
        "fullName": "Oscar Kuhlman"
      },
      "value2": {
        "PrimaryKey": 4483,
        "EntityName": "person",
        "personId": 4483,
        "fullName": "Alysson Bechtelar II"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 User  updated.
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 506,
  "Name": "VonRueden LLC",
  "Rank": 32,
  "Tooltip": "expedita",
  "LicenseOwners": [
    {
      "Name": "O'Kon Group",
      "Description": "Adaptive non-volatile standardization",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    },
    {
      "Name": "O'Kon Group",
      "Description": "Adaptive non-volatile standardization",
      "RestrictedModuleLicenses": [
        {},
        {}
      ],
      "UnrestrictedModuleLicenses": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    }
  ],
  "Role": {
    "Id": 627,
    "Value": "aut",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 684
      }
    }
  },
  "UserGroup": {
    "Value": "et",
    "Tooltip": "corporis",
    "Id": 629,
    "Rank": 333,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 878
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "voluptatem",
      "Tooltip": "in",
      "Id": 114,
      "Rank": 343,
      "Deleted": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 704
        }
      }
    }
  ],
  "Person": {
    "Position": "accusamus",
    "PersonId": 916,
    "Mrmrs": "inventore",
    "Firstname": "Larissa",
    "Lastname": "Kuvalis",
    "MiddleName": "Hoppe-Weissnat",
    "Title": "ut",
    "Description": "Ameliorated 24 hour service-desk",
    "Email": "domenico@smitham.name",
    "FullName": "Graham Kozey",
    "DirectPhone": "(556)221-3412",
    "FormalName": "Ryan-Goodwin",
    "CountryId": 287,
    "ContactId": 756,
    "ContactName": "Welch-Watsica",
    "Retired": 842,
    "Rank": 803,
    "ActiveInterests": 644,
    "ContactDepartment": "",
    "ContactCountryId": 278,
    "ContactOrgNr": "1095217",
    "FaxPhone": "(562)554-3607",
    "MobilePhone": "065-847-4843 x4788",
    "ContactPhone": "1-565-136-1156",
    "AssociateName": "Morissette Group",
    "AssociateId": 872,
    "UsePersonAddress": true,
    "ContactFax": "enim",
    "Kanafname": "eum",
    "Kanalname": "numquam",
    "Post1": "vero",
    "Post2": "qui",
    "Post3": "sit",
    "EmailName": "mariah.senger@nader.name",
    "ContactFullName": "Brooks Skiles",
    "ActiveErpLinks": 458,
    "TicketPriorityId": 872,
    "SupportLanguageId": 901,
    "SupportAssociateId": 576,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 195
      }
    }
  },
  "Deleted": false,
  "Lastlogin": "2018-12-21T15:05:43.1498654+01:00",
  "Lastlogout": "2019-01-03T15:05:43.1498654+01:00",
  "EjUserId": 906,
  "RequestSignature": "itaque",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "illum",
      "DisplayValue": "mollitia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 471
        }
      }
    },
    {
      "Type": {},
      "Value": "illum",
      "DisplayValue": "mollitia",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 471
        }
      }
    }
  ],
  "UserName": "Upton-Weimann",
  "TicketCategories": [
    {
      "Id": 984,
      "Name": "Veum-Powlowski",
      "ToolTip": "Iusto blanditiis a a.",
      "Deleted": false,
      "Rank": 175,
      "Type": "qui",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "aut",
      "ColorBlock": 919,
      "ExtraInfo": "assumenda",
      "StyleHint": "rerum",
      "FullName": "Kathryne Considine V",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 835
        }
      }
    }
  ],
  "NickName": "Hansen Inc and Sons",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "suscipit"
  },
  "CustomFields": {
    "CustomFields1": "ea",
    "CustomFields2": "nulla"
  },
  "PostSaveCommands": [
    {
      "Name": "Deckow-Cassin",
      "DisplayName": "Cruickshank-D'Amore",
      "Description": "Quality-focused cohesive moderator",
      "ToolTip": "Illo cumque cumque voluptatem temporibus et enim.",
      "Actions": "Implicit",
      "ActionData": "id",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 631
        }
      }
    }
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 638
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```