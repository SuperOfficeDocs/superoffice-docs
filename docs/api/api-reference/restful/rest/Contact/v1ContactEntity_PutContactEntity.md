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
  "ContactId": 240,
  "Name": "Abbott, Mueller and Hintz",
  "Department": "",
  "OrgNr": "1378673",
  "Number1": "1043199",
  "Number2": "1013677",
  "UpdatedDate": "2018-09-23T15:05:41.8880052+02:00",
  "CreatedDate": "2012-03-04T15:05:41.8880052+01:00",
  "Emails": [
    {
      "Value": "ratione",
      "StrippedValue": "sit",
      "Description": "Balanced maximized knowledge base"
    },
    {
      "Value": "ratione",
      "StrippedValue": "sit",
      "Description": "Balanced maximized knowledge base"
    }
  ],
  "Interests": [
    {
      "Id": 96,
      "Name": "Homenick, Zulauf and Heidenreich",
      "ToolTip": "Cumque est maiores soluta ut omnis.",
      "Deleted": false,
      "Rank": 966,
      "Type": "numquam",
      "ColorBlock": 12,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "1996-11-29T15:05:41.8880052+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "sed",
      "Hidden": true,
      "FullName": "Keira Langworth"
    }
  ],
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "qui",
      "Description": "Profit-focused bifurcated workforce"
    },
    {
      "Value": "quia",
      "StrippedValue": "qui",
      "Description": "Profit-focused bifurcated workforce"
    }
  ],
  "Phones": [
    {
      "Value": "fuga",
      "StrippedValue": "consectetur",
      "Description": "Switchable client-server open architecture"
    },
    {
      "Value": "fuga",
      "StrippedValue": "consectetur",
      "Description": "Switchable client-server open architecture"
    }
  ],
  "Faxes": [
    {
      "Value": "eligendi",
      "StrippedValue": "animi",
      "Description": "Innovative directional system engine"
    },
    {
      "Value": "eligendi",
      "StrippedValue": "animi",
      "Description": "Innovative directional system engine"
    }
  ],
  "Description": "Fully-configurable secondary structure",
  "UpdatedBy": {
    "AssociateId": 608,
    "Name": "Windler-Jewess",
    "PersonId": 617,
    "Rank": 465,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 134,
    "FullName": "Flo Grimes",
    "FormalName": "Stracke-Schuster",
    "Deleted": false,
    "EjUserId": 597,
    "UserName": "Harvey-Wyman"
  },
  "CreatedBy": {
    "AssociateId": 138,
    "Name": "Kihn, Shields and Blanda",
    "PersonId": 309,
    "Rank": 583,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 895,
    "FullName": "Forrest Lemke",
    "FormalName": "Davis, Mayer and Abernathy",
    "Deleted": true,
    "EjUserId": 857,
    "UserName": "Quitzon Inc and Sons"
  },
  "Associate": {
    "AssociateId": 911,
    "Name": "Huels Group",
    "PersonId": 737,
    "Rank": 562,
    "Tooltip": "suscipit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 486,
    "FullName": "Janelle Wehner",
    "FormalName": "McKenzie-Lind",
    "Deleted": true,
    "EjUserId": 589,
    "UserName": "Stoltenberg-Little"
  },
  "Business": {
    "Id": 882,
    "Value": "itaque",
    "Tooltip": "debitis"
  },
  "Category": {
    "Id": 643,
    "Value": "deserunt",
    "Tooltip": "atque"
  },
  "Country": {
    "CountryId": 781,
    "Name": "Osinski-Lesch",
    "CurrencyId": 497,
    "EnglishName": "Kub, Sporer and Smitham",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Phased dedicated toolset",
    "OrgNrText": "478721",
    "InterAreaPrefix": "quae",
    "DialInPrefix": "maiores",
    "ZipPrefix": "consequatur",
    "DomainName": "Mosciski Group",
    "AddressLayoutId": 505,
    "DomesticAddressLayoutId": 31,
    "ForeignAddressLayoutId": 480,
    "Rank": 462,
    "Tooltip": "vero",
    "Deleted": false
  },
  "Persons": [
    {
      "Position": "quod",
      "PersonId": 708,
      "Mrmrs": "quia",
      "Firstname": "Alta",
      "Lastname": "Gleason",
      "MiddleName": "Botsford, Stracke and Ortiz",
      "Title": "placeat",
      "Description": "Exclusive discrete synergy",
      "Email": "jarret_skiles@bayer.com",
      "FullName": "Kirsten Dach IV",
      "DirectPhone": "148-884-2030",
      "FormalName": "Paucek, Toy and Metz",
      "CountryId": 336,
      "ContactId": 527,
      "ContactName": "McLaughlin, Durgan and Brown",
      "Retired": 645,
      "Rank": 986,
      "ActiveInterests": 143,
      "ContactDepartment": "",
      "ContactCountryId": 944,
      "ContactOrgNr": "1205774",
      "FaxPhone": "(784)040-5167 x275",
      "MobilePhone": "170-214-7628 x83323",
      "ContactPhone": "838.623.5617 x81602",
      "AssociateName": "Kihn-Senger",
      "AssociateId": 849,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "architecto",
      "Kanalname": "aspernatur",
      "Post1": "deleniti",
      "Post2": "quasi",
      "Post3": "velit",
      "EmailName": "owen_watsica@trantow.com",
      "ContactFullName": "Arden Hayes",
      "ActiveErpLinks": 582,
      "TicketPriorityId": 684,
      "SupportLanguageId": 917,
      "SupportAssociateId": 252,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "tenetur",
  "Xstop": false,
  "ActiveInterests": 388,
  "GroupId": 42,
  "ActiveStatusMonitorId": 1001,
  "SupportAssociate": {
    "AssociateId": 326,
    "Name": "Shanahan, Dach and Christiansen",
    "PersonId": 710,
    "Rank": 78,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 543,
    "FullName": "Yadira Dibbert",
    "FormalName": "Lesch-Lowe",
    "Deleted": true,
    "EjUserId": 90,
    "UserName": "Mertz LLC"
  },
  "TicketPriority": {
    "Id": 104,
    "Value": "sint",
    "Tooltip": "quam"
  },
  "CustomerLanguage": {
    "Id": 790,
    "Value": "sed",
    "Tooltip": "accusantium"
  },
  "Deleted": 694,
  "DbiAgentId": 787,
  "DbiLastSyncronized": "2007-03-05T15:05:41.8920052+01:00",
  "DbiKey": "veritatis",
  "DbiLastModified": "2001-11-04T15:05:41.8920052+01:00",
  "SupportPerson": {
    "Position": "ab",
    "PersonId": 152,
    "Mrmrs": "recusandae",
    "Firstname": "Darion",
    "Lastname": "Batz",
    "MiddleName": "Walter Inc and Sons",
    "Title": "consequatur",
    "Description": "Intuitive dynamic encryption",
    "Email": "guido_schuppe@funk.us",
    "FullName": "Van Bailey",
    "DirectPhone": "471.534.7608 x65746",
    "FormalName": "Hermann LLC",
    "CountryId": 593,
    "ContactId": 721,
    "ContactName": "Reinger, Sawayn and Hoeger",
    "Retired": 781,
    "Rank": 195,
    "ActiveInterests": 731,
    "ContactDepartment": "",
    "ContactCountryId": 518,
    "ContactOrgNr": "1624667",
    "FaxPhone": "(824)363-8454 x28508",
    "MobilePhone": "(468)732-0787 x71632",
    "ContactPhone": "(186)582-4840",
    "AssociateName": "Gulgowski LLC",
    "AssociateId": 857,
    "UsePersonAddress": false,
    "ContactFax": "dolore",
    "Kanafname": "et",
    "Kanalname": "eum",
    "Post1": "excepturi",
    "Post2": "ipsum",
    "Post3": "odio",
    "EmailName": "julius_sawayn@green.info",
    "ContactFullName": "Garland Herzog",
    "ActiveErpLinks": 944,
    "TicketPriorityId": 279,
    "SupportLanguageId": 160,
    "SupportAssociateId": 984,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 11360.75,
    "Wgs84Longitude": 9326.784,
    "LocalizedAddress": [
      [
        {
          "Name": "Schowalter Inc and Sons",
          "Value": "architecto",
          "Tooltip": "voluptates",
          "Label": "iusto",
          "ValueLength": 428,
          "AddressType": "dicta",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "strategize mission-critical networks"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.String",
              "FieldLength": 281
            }
          }
        }
      ],
      [
        {
          "Name": "Altenwerth, Kreiger and Bayer",
          "Value": "ullam",
          "Tooltip": "repudiandae",
          "Label": "libero",
          "ValueLength": 848,
          "AddressType": "numquam",
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
              "FieldLength": 325
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "saepe"
  },
  "Source": 780,
  "ActiveErpLinks": 865,
  "BounceEmails": [
    "misael.frami@rodriguez.ca",
    "ahmed.schmidt@botsford.co.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Lavinia Johnson",
    "SuperOffice:2": "Miss Junius Schmeler"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "et"
  }
}
```

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 61,
  "Name": "Luettgen Group",
  "Department": "",
  "OrgNr": "431045",
  "Number1": "1818938",
  "Number2": "1486062",
  "UpdatedDate": "1996-09-11T15:05:41.9010055+02:00",
  "CreatedDate": "2017-11-27T15:05:41.9010055+01:00",
  "Emails": [
    {
      "Value": "fugit",
      "StrippedValue": "qui",
      "Description": "Reactive dedicated benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "qui",
      "Description": "Reactive dedicated benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 440
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 21,
      "Name": "Reichert, Leannon and Sporer",
      "ToolTip": "Itaque sint.",
      "Deleted": false,
      "Rank": 879,
      "Type": "sint",
      "ColorBlock": 138,
      "IconHint": "veniam",
      "Selected": true,
      "LastChanged": "1996-09-21T15:05:41.9010055+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iusto",
      "StyleHint": "illum",
      "Hidden": false,
      "FullName": "Ansley Prosacco",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 575
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "cum",
      "StrippedValue": "dolorum",
      "Description": "Cross-group object-oriented hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 659
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "dolorum",
      "Description": "Cross-group object-oriented hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 659
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "est",
      "StrippedValue": "quaerat",
      "Description": "Cross-group methodical function",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 217
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "quaerat",
      "Description": "Cross-group methodical function",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 217
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "dolorum",
      "Description": "Monitored 6th generation moderator",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 482
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "dolorum",
      "Description": "Monitored 6th generation moderator",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 482
        }
      }
    }
  ],
  "Description": "Future-proofed stable complexity",
  "UpdatedBy": {
    "AssociateId": 121,
    "Name": "Auer, Will and Senger",
    "PersonId": 103,
    "Rank": 38,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 172,
    "FullName": "Kadin Wiegand Sr.",
    "FormalName": "Harris, Bashirian and Rice",
    "Deleted": false,
    "EjUserId": 159,
    "UserName": "Schroeder-Kunde",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 58
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 376,
    "Name": "Kuvalis-Gutmann",
    "PersonId": 516,
    "Rank": 62,
    "Tooltip": "nihil",
    "Type": "AnonymousAssociate",
    "GroupIdx": 761,
    "FullName": "Myrl Davis",
    "FormalName": "Feeney, Cronin and Kirlin",
    "Deleted": true,
    "EjUserId": 525,
    "UserName": "Rath, Borer and Schaefer",
    "TableRight": {},
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
  },
  "Associate": {
    "AssociateId": 519,
    "Name": "Larson Group",
    "PersonId": 426,
    "Rank": 442,
    "Tooltip": "rem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 148,
    "FullName": "Melany Kovacek",
    "FormalName": "Jacobi, Hand and Marquardt",
    "Deleted": true,
    "EjUserId": 999,
    "UserName": "Kshlerin LLC",
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
  "Business": {
    "Id": 961,
    "Value": "quis",
    "Tooltip": "veritatis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 484
      }
    }
  },
  "Category": {
    "Id": 625,
    "Value": "vitae",
    "Tooltip": "ullam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 15
      }
    }
  },
  "Country": {
    "CountryId": 587,
    "Name": "Beatty-Rohan",
    "CurrencyId": 316,
    "EnglishName": "Eichmann, Abbott and Monahan",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Vision-oriented leading edge capability",
    "OrgNrText": "906560",
    "InterAreaPrefix": "unde",
    "DialInPrefix": "quidem",
    "ZipPrefix": "atque",
    "DomainName": "Cummings LLC",
    "AddressLayoutId": 458,
    "DomesticAddressLayoutId": 470,
    "ForeignAddressLayoutId": 776,
    "Rank": 484,
    "Tooltip": "enim",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 639
      }
    }
  },
  "Persons": [
    {
      "Position": "sed",
      "PersonId": 830,
      "Mrmrs": "doloremque",
      "Firstname": "Jovany",
      "Lastname": "Lesch",
      "MiddleName": "Bogisich Inc and Sons",
      "Title": "sit",
      "Description": "Distributed explicit hub",
      "Email": "raymundo_armstrong@walterjewess.name",
      "FullName": "Earnestine Leuschke",
      "DirectPhone": "(668)726-7006",
      "FormalName": "Moen LLC",
      "CountryId": 950,
      "ContactId": 27,
      "ContactName": "Hartmann Group",
      "Retired": 137,
      "Rank": 584,
      "ActiveInterests": 117,
      "ContactDepartment": "",
      "ContactCountryId": 652,
      "ContactOrgNr": "1448390",
      "FaxPhone": "(760)428-4273",
      "MobilePhone": "214.333.8483",
      "ContactPhone": "835.518.1600 x208",
      "AssociateName": "Witting LLC",
      "AssociateId": 486,
      "UsePersonAddress": true,
      "ContactFax": "nihil",
      "Kanafname": "eligendi",
      "Kanalname": "sit",
      "Post1": "culpa",
      "Post2": "voluptas",
      "Post3": "placeat",
      "EmailName": "lenny@gusikowski.name",
      "ContactFullName": "Oscar Lehner",
      "ActiveErpLinks": 77,
      "TicketPriorityId": 123,
      "SupportLanguageId": 258,
      "SupportAssociateId": 152,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 314
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quam",
  "Xstop": true,
  "ActiveInterests": 843,
  "GroupId": 929,
  "ActiveStatusMonitorId": 427,
  "SupportAssociate": {
    "AssociateId": 212,
    "Name": "Nolan-Schiller",
    "PersonId": 567,
    "Rank": 773,
    "Tooltip": "doloremque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 690,
    "FullName": "Art Morar",
    "FormalName": "Gislason LLC",
    "Deleted": false,
    "EjUserId": 565,
    "UserName": "Hegmann-Ankunding",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 621
      }
    }
  },
  "TicketPriority": {
    "Id": 943,
    "Value": "eum",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 877
      }
    }
  },
  "CustomerLanguage": {
    "Id": 599,
    "Value": "ut",
    "Tooltip": "numquam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 931
      }
    }
  },
  "Deleted": 463,
  "DbiAgentId": 314,
  "DbiLastSyncronized": "2018-11-11T15:05:41.9060049+01:00",
  "DbiKey": "aperiam",
  "DbiLastModified": "2018-06-29T15:05:41.9060049+02:00",
  "SupportPerson": {
    "Position": "sunt",
    "PersonId": 639,
    "Mrmrs": "culpa",
    "Firstname": "Hans",
    "Lastname": "Ryan",
    "MiddleName": "Nicolas, D'Amore and Mueller",
    "Title": "sit",
    "Description": "Distributed zero tolerance knowledge user",
    "Email": "audrey_parisian@kassulke.info",
    "FullName": "Theron Kuvalis",
    "DirectPhone": "(648)726-6443",
    "FormalName": "Schuster-Mills",
    "CountryId": 600,
    "ContactId": 676,
    "ContactName": "Stracke-O'Keefe",
    "Retired": 893,
    "Rank": 933,
    "ActiveInterests": 912,
    "ContactDepartment": "",
    "ContactCountryId": 12,
    "ContactOrgNr": "641295",
    "FaxPhone": "1-652-384-2385",
    "MobilePhone": "1-064-203-6273 x7268",
    "ContactPhone": "053-245-4181",
    "AssociateName": "Bernhard LLC",
    "AssociateId": 976,
    "UsePersonAddress": false,
    "ContactFax": "expedita",
    "Kanafname": "rerum",
    "Kanalname": "ut",
    "Post1": "eligendi",
    "Post2": "tenetur",
    "Post3": "aut",
    "EmailName": "narciso@franecki.name",
    "ContactFullName": "Maude Zulauf",
    "ActiveErpLinks": 630,
    "TicketPriorityId": 150,
    "SupportLanguageId": 78,
    "SupportAssociateId": 579,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 840
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 11178.978,
    "Wgs84Longitude": 5462.562,
    "LocalizedAddress": [
      [
        {
          "Name": "Gutmann Inc and Sons",
          "Value": "nemo",
          "Tooltip": "voluptatem",
          "Label": "libero",
          "ValueLength": 884,
          "AddressType": "ea",
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
              "FieldLength": 938
            }
          }
        }
      ],
      [
        {
          "Name": "McGlynn, Mosciski and Larkin",
          "Value": "eius",
          "Tooltip": "accusamus",
          "Label": "tempora",
          "ValueLength": 290,
          "AddressType": "quidem",
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
              "FieldLength": 578
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "earum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 788
      }
    }
  },
  "Source": 814,
  "ActiveErpLinks": 479,
  "BounceEmails": [
    "wanda@mclaughlinemmerich.ca",
    "carolyn@lueilwitz.name"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dejah Kuphal"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatem",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "exercitationem",
    "CustomFields2": "perferendis"
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
      "FieldLength": 761
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```