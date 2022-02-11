---
title: PUT Contact/{id}
id: v1ContactEntity_PutContactEntity
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

## Request Body: entity  

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
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |


## Response: object

The Contact Service. The service implements all services working with the Contact object



ContactEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

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
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 64,
  "Name": "Durgan LLC",
  "Department": "",
  "OrgNr": "962088",
  "Number1": "352465",
  "Number2": "1055589",
  "UpdatedDate": "2002-06-17T18:25:50.2786248+02:00",
  "CreatedDate": "2019-10-07T18:25:50.2786248+02:00",
  "Emails": [
    {
      "Value": "expedita",
      "StrippedValue": "consequatur",
      "Description": "Decentralized mission-critical emulation"
    },
    {
      "Value": "expedita",
      "StrippedValue": "consequatur",
      "Description": "Decentralized mission-critical emulation"
    }
  ],
  "Interests": [
    {
      "Id": 901,
      "Name": "Bashirian, Keeling and O'Keefe",
      "ToolTip": "Ut est natus.",
      "Deleted": false,
      "Rank": 811,
      "Type": "aliquid",
      "ColorBlock": 382,
      "IconHint": "vel",
      "Selected": false,
      "LastChanged": "2016-12-05T18:25:50.2786248+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "quibusdam",
      "Hidden": true,
      "FullName": "Fabian Hodkiewicz"
    }
  ],
  "Urls": [
    {
      "Value": "odio",
      "StrippedValue": "ut",
      "Description": "Re-contextualized hybrid focus group"
    },
    {
      "Value": "odio",
      "StrippedValue": "ut",
      "Description": "Re-contextualized hybrid focus group"
    }
  ],
  "Phones": [
    {
      "Value": "tempora",
      "StrippedValue": "magni",
      "Description": "Robust neutral concept"
    },
    {
      "Value": "tempora",
      "StrippedValue": "magni",
      "Description": "Robust neutral concept"
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "quis",
      "Description": "Focused homogeneous frame"
    },
    {
      "Value": "ut",
      "StrippedValue": "quis",
      "Description": "Focused homogeneous frame"
    }
  ],
  "Description": "Quality-focused 24/7 software",
  "UpdatedBy": {
    "AssociateId": 252,
    "Name": "Ebert-Johns",
    "PersonId": 416,
    "Rank": 102,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 278,
    "FullName": "Justice Lehner",
    "FormalName": "Corkery Inc and Sons",
    "Deleted": true,
    "EjUserId": 572,
    "UserName": "Leffler Group"
  },
  "CreatedBy": {
    "AssociateId": 757,
    "Name": "Ritchie-Schaefer",
    "PersonId": 971,
    "Rank": 164,
    "Tooltip": "voluptatum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 21,
    "FullName": "Herminia Haley",
    "FormalName": "Boyer Inc and Sons",
    "Deleted": false,
    "EjUserId": 369,
    "UserName": "Rogahn Group"
  },
  "Associate": {
    "AssociateId": 689,
    "Name": "Konopelski-Strosin",
    "PersonId": 370,
    "Rank": 424,
    "Tooltip": "asperiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 790,
    "FullName": "Jeanette Crooks",
    "FormalName": "Corkery-Konopelski",
    "Deleted": false,
    "EjUserId": 447,
    "UserName": "Quitzon, Schaden and Emard"
  },
  "Business": {
    "Id": 259,
    "Value": "aut",
    "Tooltip": "sed"
  },
  "Category": {
    "Id": 54,
    "Value": "adipisci",
    "Tooltip": "voluptatem"
  },
  "Country": {
    "CountryId": 782,
    "Name": "Bernhard, Becker and Gleichner",
    "CurrencyId": 919,
    "EnglishName": "Ritchie-Rempel",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Multi-tiered incremental core",
    "OrgNrText": "1137545",
    "InterAreaPrefix": "animi",
    "DialInPrefix": "dolorem",
    "ZipPrefix": "et",
    "DomainName": "Bashirian Inc and Sons",
    "AddressLayoutId": 472,
    "DomesticAddressLayoutId": 170,
    "ForeignAddressLayoutId": 484,
    "Rank": 768,
    "Tooltip": "corporis",
    "Deleted": true
  },
  "Persons": [
    {
      "Position": "sequi",
      "PersonId": 587,
      "Mrmrs": "nihil",
      "Firstname": "Faustino",
      "Lastname": "Kassulke",
      "MiddleName": "Dooley Group",
      "Title": "velit",
      "Description": "Visionary disintermediate open system",
      "Email": "patsy@berge.co.uk",
      "FullName": "Stacey Goyette PhD",
      "DirectPhone": "1-657-714-3543 x5627",
      "FormalName": "Steuber LLC",
      "CountryId": 589,
      "ContactId": 79,
      "ContactName": "Bednar, Sawayn and Rutherford",
      "Retired": 145,
      "Rank": 693,
      "ActiveInterests": 604,
      "ContactDepartment": "drive holistic users",
      "ContactCountryId": 259,
      "ContactOrgNr": "993436",
      "FaxPhone": "571.353.6372 x31823",
      "MobilePhone": "521-768-7604",
      "ContactPhone": "556.038.2135",
      "AssociateName": "Barrows Group",
      "AssociateId": 232,
      "UsePersonAddress": false,
      "ContactFax": "odio",
      "Kanafname": "in",
      "Kanalname": "eum",
      "Post1": "id",
      "Post2": "rerum",
      "Post3": "pariatur",
      "EmailName": "maribel@koepp.co.uk",
      "ContactFullName": "Mr. Maritza Bode",
      "ActiveErpLinks": 227,
      "TicketPriorityId": 37,
      "SupportLanguageId": 132,
      "SupportAssociateId": 659,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "animi",
  "Xstop": true,
  "ActiveInterests": 284,
  "GroupId": 523,
  "ActiveStatusMonitorId": 613,
  "SupportAssociate": {
    "AssociateId": 974,
    "Name": "Hoppe, Wolff and Larson",
    "PersonId": 879,
    "Rank": 532,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 161,
    "FullName": "Brionna Zulauf IV",
    "FormalName": "Deckow-Trantow",
    "Deleted": true,
    "EjUserId": 650,
    "UserName": "Bartoletti Group"
  },
  "TicketPriority": {
    "Id": 216,
    "Value": "dignissimos",
    "Tooltip": "possimus"
  },
  "CustomerLanguage": {
    "Id": 428,
    "Value": "et",
    "Tooltip": "culpa"
  },
  "Deleted": 238,
  "DbiAgentId": 302,
  "DbiLastSyncronized": "2002-02-17T18:25:50.2826252+01:00",
  "DbiKey": "corrupti",
  "DbiLastModified": "2000-01-23T18:25:50.2826252+01:00",
  "SupportPerson": {
    "Position": "quas",
    "PersonId": 886,
    "Mrmrs": "qui",
    "Firstname": "Anjali",
    "Lastname": "Schiller",
    "MiddleName": "Okuneva, Mann and Ortiz",
    "Title": "laudantium",
    "Description": "Expanded system-worthy infrastructure",
    "Email": "amari.franecki@stoltenberg.info",
    "FullName": "Lois Kulas",
    "DirectPhone": "(867)660-7122 x2184",
    "FormalName": "Dicki-Roob",
    "CountryId": 723,
    "ContactId": 405,
    "ContactName": "Purdy-Rohan",
    "Retired": 362,
    "Rank": 674,
    "ActiveInterests": 453,
    "ContactDepartment": "",
    "ContactCountryId": 725,
    "ContactOrgNr": "1003167",
    "FaxPhone": "(885)108-7863",
    "MobilePhone": "626.602.5450",
    "ContactPhone": "(208)131-2435",
    "AssociateName": "Corwin-Greenholt",
    "AssociateId": 366,
    "UsePersonAddress": false,
    "ContactFax": "ea",
    "Kanafname": "voluptate",
    "Kanalname": "alias",
    "Post1": "sit",
    "Post2": "quas",
    "Post3": "earum",
    "EmailName": "timothy@runolfsdottir.co.uk",
    "ContactFullName": "Moriah Kozey",
    "ActiveErpLinks": 170,
    "TicketPriorityId": 942,
    "SupportLanguageId": 624,
    "SupportAssociateId": 673,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 21696.682,
    "Wgs84Longitude": 8298.832,
    "LocalizedAddress": [
      [
        {
          "Name": "Russel, Halvorson and Boyer",
          "Value": "commodi",
          "Tooltip": "quas",
          "Label": "aut",
          "ValueLength": 175,
          "AddressType": "veritatis",
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
              "FieldLength": 170
            }
          }
        }
      ],
      [
        {
          "Name": "Leffler, Glover and Stamm",
          "Value": "aut",
          "Tooltip": "harum",
          "Label": "rerum",
          "ValueLength": 421,
          "AddressType": "id",
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
              "FieldLength": 409
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "culpa"
  },
  "Source": 992,
  "ActiveErpLinks": 426,
  "BounceEmails": [
    "mackenzie_schowalter@lindgren.us",
    "jimmy_rippin@walsh.name"
  ],
  "Domains": [
    "laboriosam",
    "voluptas"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "937470351",
    "SuperOffice:2": "Roberto Hane I"
  },
  "ExtraFields": {
    "ExtraFields1": "officia",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "adipisci",
    "CustomFields2": "nostrum"
  }
}
```

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 801,
  "Name": "Schuppe, Greenfelder and Johnson",
  "Department": "",
  "OrgNr": "1034432",
  "Number1": "669456",
  "Number2": "433205",
  "UpdatedDate": "2004-05-10T18:25:50.2936277+02:00",
  "CreatedDate": "2011-04-22T18:25:50.2936277+02:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "eaque",
      "Description": "Reduced homogeneous infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 485
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "eaque",
      "Description": "Reduced homogeneous infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 485
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 654,
      "Name": "Yundt-Williamson",
      "ToolTip": "Iste sit eveniet est ut modi.",
      "Deleted": false,
      "Rank": 567,
      "Type": "et",
      "ColorBlock": 83,
      "IconHint": "deserunt",
      "Selected": true,
      "LastChanged": "2014-04-23T18:25:50.2936277+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "magnam",
      "Hidden": true,
      "FullName": "Kacie Spencer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 770
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "id",
      "Description": "Front-line reciprocal monitoring",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "id",
      "Description": "Front-line reciprocal monitoring",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 34
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "autem",
      "StrippedValue": "tempora",
      "Description": "Visionary content-based Graphic Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "tempora",
      "Description": "Visionary content-based Graphic Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nihil",
      "StrippedValue": "id",
      "Description": "Networked bi-directional adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 886
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "id",
      "Description": "Networked bi-directional adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 886
        }
      }
    }
  ],
  "Description": "Multi-channelled fresh-thinking pricing structure",
  "UpdatedBy": {
    "AssociateId": 285,
    "Name": "Ryan, McLaughlin and Weber",
    "PersonId": 483,
    "Rank": 71,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 458,
    "FullName": "Hermann Little",
    "FormalName": "Grimes-Osinski",
    "Deleted": false,
    "EjUserId": 714,
    "UserName": "Labadie, Heathcote and McLaughlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 641
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 868,
    "Name": "Ebert, Feil and Hauck",
    "PersonId": 317,
    "Rank": 472,
    "Tooltip": "nisi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 523,
    "FullName": "Kieran Heller",
    "FormalName": "Fadel Group",
    "Deleted": true,
    "EjUserId": 760,
    "UserName": "Kozey, Ritchie and Upton",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 713
      }
    }
  },
  "Associate": {
    "AssociateId": 252,
    "Name": "Haag, DuBuque and Gutmann",
    "PersonId": 418,
    "Rank": 844,
    "Tooltip": "aspernatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 980,
    "FullName": "Ms. Velva Stamm",
    "FormalName": "Padberg Inc and Sons",
    "Deleted": false,
    "EjUserId": 140,
    "UserName": "Flatley-Carter",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 809
      }
    }
  },
  "Business": {
    "Id": 165,
    "Value": "aperiam",
    "Tooltip": "voluptates",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 765
      }
    }
  },
  "Category": {
    "Id": 39,
    "Value": "numquam",
    "Tooltip": "minus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 820
      }
    }
  },
  "Country": {
    "CountryId": 166,
    "Name": "Rosenbaum-Murphy",
    "CurrencyId": 486,
    "EnglishName": "Abbott LLC",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Phased executive ability",
    "OrgNrText": "1330822",
    "InterAreaPrefix": "omnis",
    "DialInPrefix": "cum",
    "ZipPrefix": "veritatis",
    "DomainName": "Bernhard, Leannon and Schultz",
    "AddressLayoutId": 736,
    "DomesticAddressLayoutId": 85,
    "ForeignAddressLayoutId": 220,
    "Rank": 263,
    "Tooltip": "adipisci",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 977
      }
    }
  },
  "Persons": [
    {
      "Position": "consectetur",
      "PersonId": 52,
      "Mrmrs": "rerum",
      "Firstname": "Preston",
      "Lastname": "Beer",
      "MiddleName": "Zboncak Inc and Sons",
      "Title": "rerum",
      "Description": "Open-source hybrid help-desk",
      "Email": "amina.brakus@rohan.ca",
      "FullName": "Ms. Dino Wisozk",
      "DirectPhone": "(411)884-7551",
      "FormalName": "Gibson-Stroman",
      "CountryId": 819,
      "ContactId": 532,
      "ContactName": "Leannon-Conn",
      "Retired": 694,
      "Rank": 767,
      "ActiveInterests": 497,
      "ContactDepartment": "",
      "ContactCountryId": 355,
      "ContactOrgNr": "1105256",
      "FaxPhone": "246.083.7877 x020",
      "MobilePhone": "672.857.3818 x43515",
      "ContactPhone": "1-708-322-8410",
      "AssociateName": "Terry-Bartell",
      "AssociateId": 739,
      "UsePersonAddress": true,
      "ContactFax": "dolores",
      "Kanafname": "et",
      "Kanalname": "voluptatem",
      "Post1": "dolores",
      "Post2": "magni",
      "Post3": "consequatur",
      "EmailName": "jules_schmitt@johnstonokeefe.name",
      "ContactFullName": "Mrs. Lucas Pagac",
      "ActiveErpLinks": 383,
      "TicketPriorityId": 932,
      "SupportLanguageId": 778,
      "SupportAssociateId": 756,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 904
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quaerat",
  "Xstop": true,
  "ActiveInterests": 871,
  "GroupId": 138,
  "ActiveStatusMonitorId": 926,
  "SupportAssociate": {
    "AssociateId": 111,
    "Name": "Legros-Shanahan",
    "PersonId": 240,
    "Rank": 20,
    "Tooltip": "sed",
    "Type": "AnonymousAssociate",
    "GroupIdx": 573,
    "FullName": "Quentin Kirlin",
    "FormalName": "Schaefer-Johnston",
    "Deleted": false,
    "EjUserId": 495,
    "UserName": "Pfannerstill Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 724
      }
    }
  },
  "TicketPriority": {
    "Id": 565,
    "Value": "asperiores",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 500
      }
    }
  },
  "CustomerLanguage": {
    "Id": 546,
    "Value": "provident",
    "Tooltip": "in",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 773
      }
    }
  },
  "Deleted": 185,
  "DbiAgentId": 329,
  "DbiLastSyncronized": "2005-04-29T18:25:50.2965955+02:00",
  "DbiKey": "cupiditate",
  "DbiLastModified": "2005-10-31T18:25:50.2965955+01:00",
  "SupportPerson": {
    "Position": "nisi",
    "PersonId": 782,
    "Mrmrs": "qui",
    "Firstname": "Cornell",
    "Lastname": "Stoltenberg",
    "MiddleName": "Morissette, Brakus and Pacocha",
    "Title": "a",
    "Description": "User-centric optimal data-warehouse",
    "Email": "emelie@sipes.uk",
    "FullName": "Mrs. Deonte Yost",
    "DirectPhone": "(451)473-1840 x026",
    "FormalName": "Volkman, Huels and Reinger",
    "CountryId": 35,
    "ContactId": 476,
    "ContactName": "Bartell, Waelchi and Adams",
    "Retired": 293,
    "Rank": 160,
    "ActiveInterests": 696,
    "ContactDepartment": "",
    "ContactCountryId": 154,
    "ContactOrgNr": "1614382",
    "FaxPhone": "(123)108-2646 x762",
    "MobilePhone": "(613)803-2713",
    "ContactPhone": "572.100.8757 x025",
    "AssociateName": "Jast, Kutch and Glover",
    "AssociateId": 924,
    "UsePersonAddress": true,
    "ContactFax": "amet",
    "Kanafname": "perferendis",
    "Kanalname": "perspiciatis",
    "Post1": "dolor",
    "Post2": "quia",
    "Post3": "esse",
    "EmailName": "twila@kirlincronin.name",
    "ContactFullName": "Jeremie Parisian",
    "ActiveErpLinks": 826,
    "TicketPriorityId": 895,
    "SupportLanguageId": 626,
    "SupportAssociateId": 434,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 94
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 19142.471999999998,
    "Wgs84Longitude": 27040.152,
    "LocalizedAddress": [
      [
        {
          "Name": "Stiedemann Inc and Sons",
          "Value": "qui",
          "Tooltip": "consequatur",
          "Label": "fuga",
          "ValueLength": 114,
          "AddressType": "sunt",
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
              "FieldLength": 14
            }
          }
        }
      ],
      [
        {
          "Name": "Fritsch-Marks",
          "Value": "molestiae",
          "Tooltip": "iure",
          "Label": "voluptatem",
          "ValueLength": 585,
          "AddressType": "eligendi",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "empower bleeding-edge markets"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 226
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 800
      }
    }
  },
  "Source": 734,
  "ActiveErpLinks": 378,
  "BounceEmails": [
    "adah@kunzeroob.biz",
    "elda@kautzerschimmel.info"
  ],
  "Domains": [
    "et",
    "repudiandae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Pink Bednar",
    "SuperOffice:2": "1860904135"
  },
  "ExtraFields": {
    "ExtraFields1": "rerum",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "odio",
    "CustomFields2": "quae"
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
      "FieldLength": 327
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```