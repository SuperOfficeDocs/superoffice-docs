---
title: POST Agents/User/GetUserFromName
id: v1UserAgent_GetUserFromName
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
| UserName | string |  |


## Response: object

SuperOffice User, with login credentials and an associated person.



Carrier object for User.
Services for the User Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IUserAgent">User Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

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

## Sample Request

```http!
POST /api/v1/Agents/User/GetUserFromName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "UserName": "Keeling, Vandervort and Strosin"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 378,
  "Name": "Lynch-Schowalter",
  "Rank": 873,
  "Tooltip": "neque",
  "LicenseOwners": [
    {
      "Name": "Grady-Daniel",
      "Description": "Exclusive actuating artificial intelligence",
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
          "FieldLength": 696
        }
      }
    },
    {
      "Name": "Grady-Daniel",
      "Description": "Exclusive actuating artificial intelligence",
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
          "FieldLength": 696
        }
      }
    }
  ],
  "Role": {
    "Id": 720,
    "Value": "vel",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 797
      }
    }
  },
  "UserGroup": {
    "Value": "doloremque",
    "Tooltip": "et",
    "Id": 241,
    "Rank": 954,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deliver rich ROI"
        },
        "FieldType": "System.String",
        "FieldLength": 100
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "maiores",
      "Tooltip": "enim",
      "Id": 947,
      "Rank": 198,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 547
        }
      }
    }
  ],
  "Person": {
    "Position": "odit",
    "PersonId": 957,
    "Mrmrs": "consequatur",
    "Firstname": "Jaren",
    "Lastname": "Hansen",
    "MiddleName": "Blanda, Hoeger and Collins",
    "Title": "libero",
    "Description": "Upgradable disintermediate data-warehouse",
    "Email": "cordia_batz@bashirianreichel.name",
    "FullName": "Jeffrey Streich",
    "DirectPhone": "(678)630-8775",
    "FormalName": "Blanda, O'Reilly and Herzog",
    "CountryId": 608,
    "ContactId": 720,
    "ContactName": "Heaney, Stehr and Hintz",
    "Retired": 647,
    "Rank": 930,
    "ActiveInterests": 360,
    "ContactDepartment": "",
    "ContactCountryId": 846,
    "ContactOrgNr": "562993",
    "FaxPhone": "380-750-1244",
    "MobilePhone": "(584)384-3303",
    "ContactPhone": "245-457-4178",
    "AssociateName": "Runolfsson, Koelpin and Stroman",
    "AssociateId": 575,
    "UsePersonAddress": false,
    "ContactFax": "et",
    "Kanafname": "vel",
    "Kanalname": "ut",
    "Post1": "aliquam",
    "Post2": "consectetur",
    "Post3": "qui",
    "EmailName": "harmon@barton.uk",
    "ContactFullName": "Kenna Fisher",
    "ActiveErpLinks": 118,
    "TicketPriorityId": 398,
    "SupportLanguageId": 408,
    "SupportAssociateId": 739,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 638
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "1994-02-15T16:48:30.9849338+01:00",
  "Lastlogout": "2005-11-13T16:48:30.9849338+01:00",
  "EjUserId": 391,
  "RequestSignature": "delectus",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "inventore",
      "DisplayValue": "vel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    },
    {
      "Type": {},
      "Value": "inventore",
      "DisplayValue": "vel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    }
  ],
  "UserName": "Johnson Group",
  "TicketCategories": [
    {
      "Id": 926,
      "Name": "Bode, Dickinson and Adams",
      "ToolTip": "Aliquid incidunt omnis rerum ut.",
      "Deleted": false,
      "Rank": 646,
      "Type": "labore",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "itaque",
      "ColorBlock": 7,
      "ExtraInfo": "ducimus",
      "StyleHint": "consequuntur",
      "FullName": "Letha Mosciski",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 947
        }
      }
    }
  ],
  "NickName": "Nolan Inc and Sons",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "et"
  },
  "PostSaveCommands": [
    {
      "Name": "Considine-Jaskolski",
      "DisplayName": "Kiehn, Schimmel and Rosenbaum",
      "Description": "Streamlined dedicated forecast",
      "ToolTip": "Eum aut.",
      "Actions": "Implicit",
      "ActionData": "labore",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 763
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
      "FieldType": "System.String",
      "FieldLength": 413
    }
  }
}
```