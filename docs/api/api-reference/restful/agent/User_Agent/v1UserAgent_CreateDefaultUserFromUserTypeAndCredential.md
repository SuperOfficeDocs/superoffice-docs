---
title: POST Agents/User/CreateDefaultUserFromUserTypeAndCredential
id: v1UserAgent_CreateDefaultUserFromUserTypeAndCredential
---

# POST Agents/User/CreateDefaultUserFromUserTypeAndCredential

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndCredential
```

Creates a PersonEntity with default values based on the contactId and credentials.



## Online Restricted: ## The User agent is not available in Online by default. User management is not allowed for partner apps.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndCredential?$select=name,department,category/id
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

UserType, ContactId, CredentialType, CredentialValue, CredentialDisplayValue 

| Property Name | Type |  Description |
|----------------|------|--------------|
| UserType | string |  |
| ContactId | int32 |  |
| CredentialType | string |  |
| CredentialValue | string |  |
| CredentialDisplayValue | string |  |


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
POST /api/v1/Agents/User/CreateDefaultUserFromUserTypeAndCredential
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UserType": "AnonymousAssociate",
  "ContactId": 677,
  "CredentialType": "illum",
  "CredentialValue": "quisquam",
  "CredentialDisplayValue": "aspernatur"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 583,
  "Name": "Murazik-Beer",
  "Rank": 569,
  "Tooltip": "maxime",
  "LicenseOwners": [
    {
      "Name": "Treutel LLC",
      "Description": "Upgradable context-sensitive budgetary management",
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
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    },
    {
      "Name": "Treutel LLC",
      "Description": "Upgradable context-sensitive budgetary management",
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
          "FieldType": "System.String",
          "FieldLength": 447
        }
      }
    }
  ],
  "Role": {
    "Id": 56,
    "Value": "incidunt",
    "Tooltip": "nulla",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 351
      }
    }
  },
  "UserGroup": {
    "Value": "quia",
    "Tooltip": "occaecati",
    "Id": 639,
    "Rank": 736,
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 969
      }
    }
  },
  "OtherGroups": [
    {
      "Value": "enim",
      "Tooltip": "iste",
      "Id": 900,
      "Rank": 783,
      "Deleted": false,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "seize cutting-edge experiences"
          },
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    }
  ],
  "Person": {
    "Position": "laborum",
    "PersonId": 924,
    "Mrmrs": "minus",
    "Firstname": "Lisa",
    "Lastname": "Oberbrunner",
    "MiddleName": "Emmerich, Langosh and Johnson",
    "Title": "autem",
    "Description": "Advanced cohesive contingency",
    "Email": "leann@morissette.biz",
    "FullName": "Margarita McKenzie",
    "DirectPhone": "(252)823-0861",
    "FormalName": "Williamson Inc and Sons",
    "CountryId": 443,
    "ContactId": 322,
    "ContactName": "Bosco LLC",
    "Retired": 137,
    "Rank": 973,
    "ActiveInterests": 407,
    "ContactDepartment": "",
    "ContactCountryId": 209,
    "ContactOrgNr": "1160257",
    "FaxPhone": "(641)102-4620",
    "MobilePhone": "220-742-0115 x621",
    "ContactPhone": "(145)553-3685 x5650",
    "AssociateName": "Klocko, Herzog and Christiansen",
    "AssociateId": 250,
    "UsePersonAddress": false,
    "ContactFax": "architecto",
    "Kanafname": "fugit",
    "Kanalname": "velit",
    "Post1": "porro",
    "Post2": "nobis",
    "Post3": "neque",
    "EmailName": "joelle_rath@altenwerth.co.uk",
    "ContactFullName": "Enos Kerluke",
    "ActiveErpLinks": 245,
    "TicketPriorityId": 748,
    "SupportLanguageId": 704,
    "SupportAssociateId": 47,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 602
      }
    }
  },
  "Deleted": true,
  "Lastlogin": "2013-08-18T16:48:30.8709355+02:00",
  "Lastlogout": "1999-02-02T16:48:30.8709355+01:00",
  "EjUserId": 89,
  "RequestSignature": "quas",
  "Type": "AnonymousAssociate",
  "IsPersonRetired": true,
  "IsOnTravel": true,
  "Credentials": [
    {
      "Type": {},
      "Value": "cupiditate",
      "DisplayValue": "natus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    },
    {
      "Type": {},
      "Value": "cupiditate",
      "DisplayValue": "natus",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    }
  ],
  "UserName": "Mayer LLC",
  "TicketCategories": [
    {
      "Id": 445,
      "Name": "Thiel-Goldner",
      "ToolTip": "Expedita officiis dolor impedit vitae vel.",
      "Deleted": true,
      "Rank": 475,
      "Type": "fugit",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "optio",
      "ColorBlock": 840,
      "ExtraInfo": "vel",
      "StyleHint": "totam",
      "FullName": "Ena Bayer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 9
        }
      }
    }
  ],
  "NickName": "Wehner-Fahey",
  "WaitingForApproval": true,
  "ExtraFields": {
    "ExtraFields1": "nesciunt",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "harum"
  },
  "PostSaveCommands": [
    {
      "Name": "Lakin-Cremin",
      "DisplayName": "Bayer Group",
      "Description": "Cross-group empowering adapter",
      "ToolTip": "Ut voluptas velit beatae.",
      "Actions": "Implicit",
      "ActionData": "iste",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 78
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
        "Reason": "seize seamless solutions"
      },
      "FieldType": "System.String",
      "FieldLength": 321
    }
  }
}
```