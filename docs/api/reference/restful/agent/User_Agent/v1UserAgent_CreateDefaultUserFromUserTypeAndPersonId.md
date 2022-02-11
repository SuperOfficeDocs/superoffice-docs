---
title: POST Agents/User/CreateDefaultUserFromUserTypeAndPersonId
id: v1UserAgent_CreateDefaultUserFromUserTypeAndPersonId
---

# POST Agents/User/CreateDefaultUserFromUserTypeAndPersonId

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndPersonId
```

Create default User providing the associate type and person id.

System and Anonymous users can be created without an exsisting person and permits person id to be 0.


## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndPersonId?$select=name,department,category/id
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

UserType, PersonId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserType | string |  |
| PersonId | int32 |  |


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
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndPersonId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "PersonId": 125
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 352,
  "Name": "McCullough, Greenfelder and Gutkowski",
  "Rank": 840,
  "Tooltip": "eius",
  "LicenseOwners": [
    {
      "Name": "Koelpin, Boehm and Gutmann",
      "Description": "Extended logistical service-desk",
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
          "FieldLength": 103
        }
      }
    },
    {
      "Name": "Koelpin, Boehm and Gutmann",
      "Description": "Extended logistical service-desk",
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
          "FieldLength": 103
        }
      }
    }
  ],
  "Role": {
    "Id": 55,
    "Value": "excepturi",
    "Tooltip": "odio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 524
      }
    }
  },
  "UserGroup": {
    "Value": "velit",
    "Tooltip": "amet",
    "Id": 955,
    "Rank": 172,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 807
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "qui",
      "Tooltip": "reiciendis",
      "Id": 687,
      "Rank": 153,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 611
        }
      }
    }
  ],
  "Person": {
    "Position": "quisquam",
    "PersonId": 647,
    "Mrmrs": "aut",
    "Firstname": "Rogelio",
    "Lastname": "Schamberger",
    "MiddleName": "Haley Group",
    "Title": "tempore",
    "Description": "Front-line intermediate workforce",
    "Email": "felix.tremblay@keebler.biz",
    "FullName": "Daron Dibbert",
    "DirectPhone": "1-322-858-2164 x817",
    "FormalName": "Marquardt, Orn and Aufderhar",
    "CountryId": 609,
    "ContactId": 149,
    "ContactName": "Jones, Pouros and Funk",
    "Retired": 383,
    "Rank": 434,
    "ActiveInterests": 366,
    "ContactDepartment": "",
    "ContactCountryId": 180,
    "ContactOrgNr": "504133",
    "FaxPhone": "1-772-370-7360",
    "MobilePhone": "233-804-7858 x030",
    "ContactPhone": "1-074-251-6631 x3436",
    "AssociateName": "Effertz-Frami",
    "AssociateId": 394,
    "UsePersonAddress": false,
    "ContactFax": "qui",
    "Kanafname": "hic",
    "Kanalname": "ipsam",
    "Post1": "voluptatem",
    "Post2": "velit",
    "Post3": "quo",
    "EmailName": "clyde@shieldseffertz.us",
    "ContactFullName": "Mr. Shayna Rolfson",
    "ActiveErpLinks": 549,
    "TicketPriorityId": 937,
    "SupportLanguageId": 309,
    "SupportAssociateId": 603,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 365
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2003-08-04T18:28:50.4684132+02:00",
  "Lastlogout": "2002-12-05T18:28:50.4684132+01:00",
  "EjUserId": 703,
  "RequestSignature": "ad",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": false,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "quo",
      "DisplayValue": "amet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    },
    {
      "Type": {},
      "Value": "quo",
      "DisplayValue": "amet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    }
  ],
  "UserName": "Reinger-Torp",
  "TicketCategories": [
    {
      "Id": 382,
      "Name": "Christiansen, Ferry and Stehr",
      "ToolTip": "Ut delectus facilis.",
      "Deleted": false,
      "Rank": 802,
      "Type": "ipsum",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptatibus",
      "ColorBlock": 540,
      "ExtraInfo": "soluta",
      "StyleHint": "quis",
      "FullName": "Ellen DuBuque",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    }
  ],
  "NickName": "Reichert Group",
  "WaitingForApproval": false,
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "voluptatibus"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "pariatur"
  },
  "PostSaveCommands": [
    {
      "Name": "Hilpert, Cummings and Gleason",
      "DisplayName": "Cole Inc and Sons",
      "Description": "Proactive 6th generation encryption",
      "ToolTip": "Iure minima magnam aliquid consectetur beatae.",
      "Actions": "Implicit",
      "ActionData": "molestiae",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 244
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
        "Reason": "iterate intuitive convergence"
      },
      "FieldType": "System.Int32",
      "FieldLength": 570
    }
  }
}
```