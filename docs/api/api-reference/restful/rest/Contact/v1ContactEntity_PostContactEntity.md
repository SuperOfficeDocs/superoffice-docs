---
title: POST Contact
id: v1ContactEntity_PostContactEntity
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity

Calls the Contact agent service SaveContactEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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

## Request Body: newEntity  

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: object

The Contact Service. The service implements all services working with the Contact object



ContactEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 626,
  "Name": "Schroeder-Weber",
  "Department": "",
  "OrgNr": "1181081",
  "Number1": "239802",
  "Number2": "1302693",
  "UpdatedDate": "1999-07-15T15:05:41.8530054+02:00",
  "CreatedDate": "2013-09-23T15:05:41.8530054+02:00",
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "cumque",
      "Description": "Assimilated 24/7 knowledge user"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "cumque",
      "Description": "Assimilated 24/7 knowledge user"
    }
  ],
  "Interests": [
    {
      "Id": 619,
      "Name": "Paucek, Klocko and Gusikowski",
      "ToolTip": "Eos alias.",
      "Deleted": true,
      "Rank": 491,
      "Type": "non",
      "ColorBlock": 632,
      "IconHint": "velit",
      "Selected": false,
      "LastChanged": "1995-03-19T15:05:41.8530054+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nobis",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Mckayla Grady"
    }
  ],
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "ipsum",
      "Description": "Extended stable analyzer"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "ipsum",
      "Description": "Extended stable analyzer"
    }
  ],
  "Phones": [
    {
      "Value": "exercitationem",
      "StrippedValue": "repudiandae",
      "Description": "Reverse-engineered even-keeled migration"
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "repudiandae",
      "Description": "Reverse-engineered even-keeled migration"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatum",
      "StrippedValue": "est",
      "Description": "Re-engineered executive customer loyalty"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "est",
      "Description": "Re-engineered executive customer loyalty"
    }
  ],
  "Description": "Devolved 5th generation matrices",
  "UpdatedBy": {
    "AssociateId": 803,
    "Name": "Schoen LLC",
    "PersonId": 208,
    "Rank": 798,
    "Tooltip": "iure",
    "Type": "AnonymousAssociate",
    "GroupIdx": 176,
    "FullName": "Lisandro Prohaska",
    "FormalName": "Champlin, O'Keefe and Keeling",
    "Deleted": true,
    "EjUserId": 337,
    "UserName": "Graham Group"
  },
  "CreatedBy": {
    "AssociateId": 615,
    "Name": "Borer Inc and Sons",
    "PersonId": 917,
    "Rank": 340,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 140,
    "FullName": "Kenny Hilpert",
    "FormalName": "Barrows Group",
    "Deleted": false,
    "EjUserId": 500,
    "UserName": "Lebsack-Satterfield"
  },
  "Associate": {
    "AssociateId": 180,
    "Name": "Wisoky-Rutherford",
    "PersonId": 18,
    "Rank": 482,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 843,
    "FullName": "Eloise Waters",
    "FormalName": "Little-Gislason",
    "Deleted": false,
    "EjUserId": 882,
    "UserName": "Schmidt LLC"
  },
  "Business": {
    "Id": 136,
    "Value": "minima",
    "Tooltip": "blanditiis"
  },
  "Category": {
    "Id": 945,
    "Value": "qui",
    "Tooltip": "quo"
  },
  "Country": {
    "CountryId": 759,
    "Name": "Bosco, Kemmer and Mohr",
    "CurrencyId": 124,
    "EnglishName": "Tromp-Stiedemann",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Object-based full-range application",
    "OrgNrText": "770872",
    "InterAreaPrefix": "odio",
    "DialInPrefix": "deleniti",
    "ZipPrefix": "et",
    "DomainName": "Blick-Reilly",
    "AddressLayoutId": 146,
    "DomesticAddressLayoutId": 45,
    "ForeignAddressLayoutId": 805,
    "Rank": 691,
    "Tooltip": "natus",
    "Deleted": false
  },
  "Persons": [
    {
      "Position": "adipisci",
      "PersonId": 459,
      "Mrmrs": "sed",
      "Firstname": "Karlie",
      "Lastname": "Spencer",
      "MiddleName": "Wehner Inc and Sons",
      "Title": "voluptatibus",
      "Description": "Multi-layered discrete conglomeration",
      "Email": "katharina@swift.com",
      "FullName": "Maeve Emmerich",
      "DirectPhone": "(083)738-3202 x5236",
      "FormalName": "Ondricka-Lindgren",
      "CountryId": 297,
      "ContactId": 552,
      "ContactName": "Mills-Kautzer",
      "Retired": 933,
      "Rank": 970,
      "ActiveInterests": 255,
      "ContactDepartment": "",
      "ContactCountryId": 764,
      "ContactOrgNr": "844436",
      "FaxPhone": "1-877-348-5163",
      "MobilePhone": "128-424-1355 x8050",
      "ContactPhone": "034-417-0627 x4816",
      "AssociateName": "Jenkins LLC",
      "AssociateId": 159,
      "UsePersonAddress": false,
      "ContactFax": "amet",
      "Kanafname": "quos",
      "Kanalname": "iusto",
      "Post1": "consequuntur",
      "Post2": "impedit",
      "Post3": "est",
      "EmailName": "frances@thiel.com",
      "ContactFullName": "Rosetta Collins IV",
      "ActiveErpLinks": 658,
      "TicketPriorityId": 674,
      "SupportLanguageId": 752,
      "SupportAssociateId": 531,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "natus",
  "Xstop": true,
  "ActiveInterests": 412,
  "GroupId": 952,
  "ActiveStatusMonitorId": 590,
  "SupportAssociate": {
    "AssociateId": 631,
    "Name": "Bernhard-Ward",
    "PersonId": 557,
    "Rank": 113,
    "Tooltip": "libero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 33,
    "FullName": "Bertha Gutkowski",
    "FormalName": "Gutmann-Shanahan",
    "Deleted": false,
    "EjUserId": 834,
    "UserName": "Walker-Considine"
  },
  "TicketPriority": {
    "Id": 312,
    "Value": "nostrum",
    "Tooltip": "dolore"
  },
  "CustomerLanguage": {
    "Id": 908,
    "Value": "esse",
    "Tooltip": "occaecati"
  },
  "Deleted": 493,
  "DbiAgentId": 741,
  "DbiLastSyncronized": "2004-10-28T15:05:41.8570057+02:00",
  "DbiKey": "deleniti",
  "DbiLastModified": "1999-06-27T15:05:41.8570057+02:00",
  "SupportPerson": {
    "Position": "voluptatem",
    "PersonId": 50,
    "Mrmrs": "sit",
    "Firstname": "Rosa",
    "Lastname": "Koss",
    "MiddleName": "Lynch LLC",
    "Title": "et",
    "Description": "Team-oriented reciprocal frame",
    "Email": "alek.hamill@sanford.com",
    "FullName": "Dennis Champlin",
    "DirectPhone": "1-836-770-4732 x841",
    "FormalName": "Gibson Group",
    "CountryId": 935,
    "ContactId": 994,
    "ContactName": "Howe-Crooks",
    "Retired": 509,
    "Rank": 713,
    "ActiveInterests": 173,
    "ContactDepartment": "",
    "ContactCountryId": 745,
    "ContactOrgNr": "220938",
    "FaxPhone": "1-768-682-1617 x7245",
    "MobilePhone": "474.674.2866 x3354",
    "ContactPhone": "082-044-0626 x007",
    "AssociateName": "Olson Inc and Sons",
    "AssociateId": 615,
    "UsePersonAddress": false,
    "ContactFax": "eligendi",
    "Kanafname": "modi",
    "Kanalname": "laboriosam",
    "Post1": "sunt",
    "Post2": "sed",
    "Post3": "id",
    "EmailName": "julian.rice@torp.co.uk",
    "ContactFullName": "Imogene Boyle",
    "ActiveErpLinks": 267,
    "TicketPriorityId": 956,
    "SupportLanguageId": 774,
    "SupportAssociateId": 475,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 15218.704,
    "Wgs84Longitude": 23620.958,
    "LocalizedAddress": [
      [
        {
          "Name": "Oberbrunner Group",
          "Value": "qui",
          "Tooltip": "at",
          "Label": "libero",
          "ValueLength": 959,
          "AddressType": "sapiente",
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
              "FieldLength": 550
            }
          }
        }
      ],
      [
        {
          "Name": "Bechtelar, Jones and Sanford",
          "Value": "nesciunt",
          "Tooltip": "quidem",
          "Label": "praesentium",
          "ValueLength": 958,
          "AddressType": "similique",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "evolve intuitive e-services"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 422
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "aut"
  },
  "Source": 217,
  "ActiveErpLinks": 36,
  "BounceEmails": [
    "bertram_moore@morar.com",
    "hosea.grady@mayertprohaska.co.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "839777807",
    "SuperOffice:2": "Carolina Swift"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "repellendus"
  },
  "CustomFields": {
    "CustomFields1": "facere",
    "CustomFields2": "ipsum"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 148,
  "Name": "Jerde Group",
  "Department": "",
  "OrgNr": "1677776",
  "Number1": "708297",
  "Number2": "729462",
  "UpdatedDate": "2004-03-19T15:05:41.8660054+01:00",
  "CreatedDate": "2006-04-25T15:05:41.8660054+02:00",
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "fugiat",
      "Description": "Multi-channelled asynchronous function",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 999
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "fugiat",
      "Description": "Multi-channelled asynchronous function",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 999
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 801,
      "Name": "Mertz-Collins",
      "ToolTip": "Laudantium excepturi tempore.",
      "Deleted": true,
      "Rank": 922,
      "Type": "sint",
      "ColorBlock": 829,
      "IconHint": "provident",
      "Selected": false,
      "LastChanged": "1996-07-18T15:05:41.8660054+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "natus",
      "Hidden": true,
      "FullName": "Van Brown",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 329
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "odit",
      "StrippedValue": "qui",
      "Description": "Inverse 4th generation toolset",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "qui",
      "Description": "Inverse 4th generation toolset",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 824
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ea",
      "StrippedValue": "rerum",
      "Description": "Cross-platform systematic attitude",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 464
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "rerum",
      "Description": "Cross-platform systematic attitude",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 464
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "iusto",
      "Description": "Fully-configurable context-sensitive model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 30
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "iusto",
      "Description": "Fully-configurable context-sensitive model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 30
        }
      }
    }
  ],
  "Description": "Future-proofed executive protocol",
  "UpdatedBy": {
    "AssociateId": 522,
    "Name": "Jenkins LLC",
    "PersonId": 562,
    "Rank": 686,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 141,
    "FullName": "Casandra Ruecker PhD",
    "FormalName": "Cartwright Inc and Sons",
    "Deleted": false,
    "EjUserId": 73,
    "UserName": "Gleichner-Schuppe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 754
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 506,
    "Name": "Gorczany, Reynolds and Cronin",
    "PersonId": 17,
    "Rank": 956,
    "Tooltip": "animi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 708,
    "FullName": "Frederik Marquardt",
    "FormalName": "Turcotte-Ebert",
    "Deleted": true,
    "EjUserId": 236,
    "UserName": "Klein Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 472
      }
    }
  },
  "Associate": {
    "AssociateId": 274,
    "Name": "Littel, Prohaska and Stoltenberg",
    "PersonId": 434,
    "Rank": 871,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 659,
    "FullName": "Willa Dibbert",
    "FormalName": "Wehner Inc and Sons",
    "Deleted": true,
    "EjUserId": 417,
    "UserName": "Dicki-Kunze",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 92
      }
    }
  },
  "Business": {
    "Id": 746,
    "Value": "exercitationem",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 745
      }
    }
  },
  "Category": {
    "Id": 94,
    "Value": "eveniet",
    "Tooltip": "ad",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 997
      }
    }
  },
  "Country": {
    "CountryId": 245,
    "Name": "Christiansen Inc and Sons",
    "CurrencyId": 949,
    "EnglishName": "McCullough-Grimes",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Inverse fresh-thinking emulation",
    "OrgNrText": "1479738",
    "InterAreaPrefix": "sunt",
    "DialInPrefix": "est",
    "ZipPrefix": "excepturi",
    "DomainName": "Hayes-Ebert",
    "AddressLayoutId": 161,
    "DomesticAddressLayoutId": 295,
    "ForeignAddressLayoutId": 445,
    "Rank": 118,
    "Tooltip": "sit",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 107
      }
    }
  },
  "Persons": [
    {
      "Position": "consequuntur",
      "PersonId": 365,
      "Mrmrs": "optio",
      "Firstname": "Leola",
      "Lastname": "Sanford",
      "MiddleName": "Quitzon Inc and Sons",
      "Title": "voluptate",
      "Description": "Versatile fault-tolerant artificial intelligence",
      "Email": "cara_kirlin@turner.co.uk",
      "FullName": "Dr. Leif Sipes",
      "DirectPhone": "(262)556-4067 x86635",
      "FormalName": "Runolfsdottir Group",
      "CountryId": 476,
      "ContactId": 731,
      "ContactName": "Leannon-Howell",
      "Retired": 559,
      "Rank": 307,
      "ActiveInterests": 586,
      "ContactDepartment": "",
      "ContactCountryId": 507,
      "ContactOrgNr": "368722",
      "FaxPhone": "1-068-786-6627",
      "MobilePhone": "(035)624-0728",
      "ContactPhone": "1-026-363-0408",
      "AssociateName": "Pfannerstill-Treutel",
      "AssociateId": 929,
      "UsePersonAddress": false,
      "ContactFax": "tempore",
      "Kanafname": "sit",
      "Kanalname": "quia",
      "Post1": "dolores",
      "Post2": "quae",
      "Post3": "natus",
      "EmailName": "marian@ferrywilderman.com",
      "ContactFullName": "Mariah Mitchell",
      "ActiveErpLinks": 125,
      "TicketPriorityId": 599,
      "SupportLanguageId": 45,
      "SupportAssociateId": 402,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 99
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "eligendi",
  "Xstop": false,
  "ActiveInterests": 499,
  "GroupId": 1000,
  "ActiveStatusMonitorId": 356,
  "SupportAssociate": {
    "AssociateId": 436,
    "Name": "Shanahan Group",
    "PersonId": 215,
    "Rank": 816,
    "Tooltip": "ipsam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 787,
    "FullName": "Pauline Lynch",
    "FormalName": "Kunze, Langosh and Watsica",
    "Deleted": true,
    "EjUserId": 213,
    "UserName": "Bins-Hirthe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 88
      }
    }
  },
  "TicketPriority": {
    "Id": 400,
    "Value": "reprehenderit",
    "Tooltip": "id",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 806
      }
    }
  },
  "CustomerLanguage": {
    "Id": 652,
    "Value": "aut",
    "Tooltip": "temporibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 617
      }
    }
  },
  "Deleted": 904,
  "DbiAgentId": 43,
  "DbiLastSyncronized": "2015-01-08T15:05:41.8700053+01:00",
  "DbiKey": "magni",
  "DbiLastModified": "2017-10-17T15:05:41.8700053+02:00",
  "SupportPerson": {
    "Position": "similique",
    "PersonId": 287,
    "Mrmrs": "minima",
    "Firstname": "Andre",
    "Lastname": "Paucek",
    "MiddleName": "Morar-Champlin",
    "Title": "voluptatum",
    "Description": "Up-sized homogeneous alliance",
    "Email": "beth@volkmanstanton.com",
    "FullName": "Patsy Johnson",
    "DirectPhone": "700.427.0624 x140",
    "FormalName": "Rodriguez, Wisoky and White",
    "CountryId": 394,
    "ContactId": 335,
    "ContactName": "Hermiston-Herzog",
    "Retired": 810,
    "Rank": 570,
    "ActiveInterests": 884,
    "ContactDepartment": "",
    "ContactCountryId": 811,
    "ContactOrgNr": "747222",
    "FaxPhone": "767.048.6722 x37687",
    "MobilePhone": "1-051-714-4013 x235",
    "ContactPhone": "043.263.5036",
    "AssociateName": "Block Inc and Sons",
    "AssociateId": 51,
    "UsePersonAddress": false,
    "ContactFax": "nobis",
    "Kanafname": "eligendi",
    "Kanalname": "saepe",
    "Post1": "ullam",
    "Post2": "facere",
    "Post3": "voluptatem",
    "EmailName": "rebecca.predovic@fahey.us",
    "ContactFullName": "Giovanni Hyatt",
    "ActiveErpLinks": 299,
    "TicketPriorityId": 484,
    "SupportLanguageId": 911,
    "SupportAssociateId": 982,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 142
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 14369.39,
    "Wgs84Longitude": 12771.05,
    "LocalizedAddress": [
      [
        {
          "Name": "Oberbrunner Group",
          "Value": "quod",
          "Tooltip": "voluptatum",
          "Label": "aliquam",
          "ValueLength": 3,
          "AddressType": "autem",
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
              "FieldLength": 43
            }
          }
        }
      ],
      [
        {
          "Name": "Champlin, Schmeler and Cole",
          "Value": "nostrum",
          "Tooltip": "non",
          "Label": "repudiandae",
          "ValueLength": 989,
          "AddressType": "aut",
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
              "FieldLength": 316
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "quas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 591
      }
    }
  },
  "Source": 391,
  "ActiveErpLinks": 875,
  "BounceEmails": [
    "halle.rodriguez@halvorson.us",
    "tristin.klein@lehner.info"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "419574005",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "ea"
  },
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
      "FieldLength": 339
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```