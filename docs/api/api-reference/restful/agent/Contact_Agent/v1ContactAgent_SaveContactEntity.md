---
title: POST Agents/Contact/SaveContactEntity
id: v1ContactAgent_SaveContactEntity
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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



Carrier object for ContactEntity.
Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>.

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
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 823,
  "Name": "Purdy, Dietrich and McClure",
  "Department": "",
  "OrgNr": "935061",
  "Number1": "1034803",
  "Number2": "918959",
  "UpdatedDate": "1994-08-24T18:28:48.4366232+02:00",
  "CreatedDate": "2015-05-08T18:28:48.4366232+02:00",
  "Emails": [
    {
      "Value": "maxime",
      "StrippedValue": "esse",
      "Description": "Grass-roots content-based task-force"
    },
    {
      "Value": "maxime",
      "StrippedValue": "esse",
      "Description": "Grass-roots content-based task-force"
    }
  ],
  "Interests": [
    {
      "Id": 554,
      "Name": "Price, Lebsack and Goyette",
      "ToolTip": "Provident fugit.",
      "Deleted": true,
      "Rank": 791,
      "Type": "doloremque",
      "ColorBlock": 715,
      "IconHint": "nesciunt",
      "Selected": true,
      "LastChanged": "2009-06-26T18:28:48.4386236+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cupiditate",
      "StyleHint": "dolore",
      "Hidden": true,
      "FullName": "Evert Hagenes"
    }
  ],
  "Urls": [
    {
      "Value": "aliquid",
      "StrippedValue": "ut",
      "Description": "Polarised even-keeled website"
    },
    {
      "Value": "aliquid",
      "StrippedValue": "ut",
      "Description": "Polarised even-keeled website"
    }
  ],
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "qui",
      "Description": "Adaptive multi-tasking encryption"
    },
    {
      "Value": "qui",
      "StrippedValue": "qui",
      "Description": "Adaptive multi-tasking encryption"
    }
  ],
  "Faxes": [
    {
      "Value": "aliquam",
      "StrippedValue": "et",
      "Description": "Cross-platform zero administration application"
    },
    {
      "Value": "aliquam",
      "StrippedValue": "et",
      "Description": "Cross-platform zero administration application"
    }
  ],
  "Description": "Face to face dedicated open system",
  "UpdatedBy": {
    "AssociateId": 414,
    "Name": "Turcotte-Sipes",
    "PersonId": 624,
    "Rank": 693,
    "Tooltip": "deleniti",
    "Type": "AnonymousAssociate",
    "GroupIdx": 216,
    "FullName": "Manuel D'Amore",
    "FormalName": "Stanton, Kessler and Strosin",
    "Deleted": true,
    "EjUserId": 571,
    "UserName": "Harvey, Hansen and Sauer"
  },
  "CreatedBy": {
    "AssociateId": 215,
    "Name": "Hettinger-Emard",
    "PersonId": 350,
    "Rank": 301,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 101,
    "FullName": "Tremaine Block",
    "FormalName": "Cormier-Volkman",
    "Deleted": true,
    "EjUserId": 718,
    "UserName": "O'Conner-Kling"
  },
  "Associate": {
    "AssociateId": 379,
    "Name": "Boehm Inc and Sons",
    "PersonId": 806,
    "Rank": 688,
    "Tooltip": "error",
    "Type": "AnonymousAssociate",
    "GroupIdx": 530,
    "FullName": "Arvilla Romaguera",
    "FormalName": "Gerhold, Gerhold and Kozey",
    "Deleted": true,
    "EjUserId": 181,
    "UserName": "Windler, Sporer and Mann"
  },
  "Business": {
    "Id": 509,
    "Value": "assumenda",
    "Tooltip": "quisquam"
  },
  "Category": {
    "Id": 581,
    "Value": "consequatur",
    "Tooltip": "cum"
  },
  "Country": {
    "CountryId": 327,
    "Name": "Greenholt, Goyette and Wiegand",
    "CurrencyId": 546,
    "EnglishName": "Gaylord-Pfannerstill",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Horizontal local encryption",
    "OrgNrText": "1173875",
    "InterAreaPrefix": "necessitatibus",
    "DialInPrefix": "reiciendis",
    "ZipPrefix": "dolorem",
    "DomainName": "Kulas-Lehner",
    "AddressLayoutId": 715,
    "DomesticAddressLayoutId": 577,
    "ForeignAddressLayoutId": 437,
    "Rank": 36,
    "Tooltip": "iure",
    "Deleted": false
  },
  "Persons": [
    {
      "Position": "cupiditate",
      "PersonId": 368,
      "Mrmrs": "et",
      "Firstname": "Roxane",
      "Lastname": "Windler",
      "MiddleName": "Ledner, Okuneva and Mann",
      "Title": "ad",
      "Description": "Multi-tiered zero tolerance complexity",
      "Email": "isabell.simonis@connelly.co.uk",
      "FullName": "Ellis Mayert",
      "DirectPhone": "1-448-766-0838 x8864",
      "FormalName": "Metz, Walter and Emmerich",
      "CountryId": 53,
      "ContactId": 718,
      "ContactName": "Klein-McGlynn",
      "Retired": 458,
      "Rank": 559,
      "ActiveInterests": 64,
      "ContactDepartment": "",
      "ContactCountryId": 36,
      "ContactOrgNr": "933623",
      "FaxPhone": "432.015.7568 x244",
      "MobilePhone": "1-826-520-5272",
      "ContactPhone": "(842)520-3023",
      "AssociateName": "Jast-Kertzmann",
      "AssociateId": 707,
      "UsePersonAddress": false,
      "ContactFax": "facilis",
      "Kanafname": "voluptas",
      "Kanalname": "sint",
      "Post1": "consequuntur",
      "Post2": "illum",
      "Post3": "in",
      "EmailName": "elroy@greenholt.name",
      "ContactFullName": "Christiana Lueilwitz DVM",
      "ActiveErpLinks": 397,
      "TicketPriorityId": 941,
      "SupportLanguageId": 863,
      "SupportAssociateId": 495,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "ea",
  "Xstop": false,
  "ActiveInterests": 251,
  "GroupId": 931,
  "ActiveStatusMonitorId": 282,
  "SupportAssociate": {
    "AssociateId": 26,
    "Name": "Veum, Boyer and Erdman",
    "PersonId": 144,
    "Rank": 887,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 553,
    "FullName": "Augustine Rippin",
    "FormalName": "Bergstrom Inc and Sons",
    "Deleted": true,
    "EjUserId": 490,
    "UserName": "Runolfsson-Labadie"
  },
  "TicketPriority": {
    "Id": 709,
    "Value": "dolorem",
    "Tooltip": "nihil"
  },
  "CustomerLanguage": {
    "Id": 779,
    "Value": "exercitationem",
    "Tooltip": "excepturi"
  },
  "Deleted": 471,
  "DbiAgentId": 29,
  "DbiLastSyncronized": "2014-02-11T18:28:48.4416536+01:00",
  "DbiKey": "vel",
  "DbiLastModified": "2010-04-11T18:28:48.4416536+02:00",
  "SupportPerson": {
    "Position": "consequatur",
    "PersonId": 345,
    "Mrmrs": "ut",
    "Firstname": "Bianka",
    "Lastname": "Spinka",
    "MiddleName": "Runolfsson Group",
    "Title": "ut",
    "Description": "Fundamental executive process improvement",
    "Email": "jordan@gerlachwisozk.us",
    "FullName": "Milton Brekke",
    "DirectPhone": "370.104.2656",
    "FormalName": "Collier, Von and Moen",
    "CountryId": 592,
    "ContactId": 102,
    "ContactName": "Kris-O'Reilly",
    "Retired": 826,
    "Rank": 259,
    "ActiveInterests": 958,
    "ContactDepartment": "",
    "ContactCountryId": 754,
    "ContactOrgNr": "529865",
    "FaxPhone": "631.602.6427 x1626",
    "MobilePhone": "650-258-6764",
    "ContactPhone": "(283)121-4642",
    "AssociateName": "Altenwerth-McLaughlin",
    "AssociateId": 900,
    "UsePersonAddress": true,
    "ContactFax": "nemo",
    "Kanafname": "ipsam",
    "Kanalname": "ea",
    "Post1": "ipsa",
    "Post2": "voluptatem",
    "Post3": "optio",
    "EmailName": "russel.lindgren@gerholdbartoletti.name",
    "ContactFullName": "Brian Block",
    "ActiveErpLinks": 522,
    "TicketPriorityId": 57,
    "SupportLanguageId": 152,
    "SupportAssociateId": 621,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 4453.414,
    "Wgs84Longitude": 29506.61,
    "LocalizedAddress": [
      [
        {
          "Name": "Medhurst LLC",
          "Value": "aliquid",
          "Tooltip": "commodi",
          "Label": "blanditiis",
          "ValueLength": 710,
          "AddressType": "consequuntur",
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
              "FieldLength": 637
            }
          }
        }
      ],
      [
        {
          "Name": "Kemmer, Reynolds and Beier",
          "Value": "natus",
          "Tooltip": "corrupti",
          "Label": "tempora",
          "ValueLength": 776,
          "AddressType": "et",
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
              "FieldLength": 186
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "error"
  },
  "Source": 15,
  "ActiveErpLinks": 727,
  "BounceEmails": [
    "tina_hauck@thiel.name",
    "jordane_quigley@ferry.name"
  ],
  "Domains": [
    "eos",
    "eos"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Bernita Ryan",
    "SuperOffice:2": "Candido Bernier"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "modi",
    "CustomFields2": "laborum"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 714,
  "Name": "Cole Group",
  "Department": "",
  "OrgNr": "1294282",
  "Number1": "974863",
  "Number2": "743292",
  "UpdatedDate": "2001-04-25T18:28:48.4526562+02:00",
  "CreatedDate": "2005-07-29T18:28:48.4526562+02:00",
  "Emails": [
    {
      "Value": "atque",
      "StrippedValue": "rerum",
      "Description": "Monitored background installation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 506
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "rerum",
      "Description": "Monitored background installation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 506
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 69,
      "Name": "O'Hara, Bruen and Prohaska",
      "ToolTip": "Excepturi incidunt ipsam unde esse.",
      "Deleted": true,
      "Rank": 558,
      "Type": "aut",
      "ColorBlock": 202,
      "IconHint": "explicabo",
      "Selected": false,
      "LastChanged": "2016-01-28T18:28:48.4526562+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eum",
      "StyleHint": "numquam",
      "Hidden": false,
      "FullName": "Afton Koepp",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 366
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "neque",
      "Description": "Secured object-oriented adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 437
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "neque",
      "Description": "Secured object-oriented adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 437
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "officiis",
      "StrippedValue": "ut",
      "Description": "Integrated holistic support",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 616
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "ut",
      "Description": "Integrated holistic support",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 616
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nobis",
      "StrippedValue": "odio",
      "Description": "Function-based global leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "odio",
      "Description": "Function-based global leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    }
  ],
  "Description": "Automated 24/7 system engine",
  "UpdatedBy": {
    "AssociateId": 667,
    "Name": "Jakubowski, Pollich and Bergstrom",
    "PersonId": 131,
    "Rank": 580,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 341,
    "FullName": "Alexys Mraz",
    "FormalName": "Greenholt, Cartwright and Stanton",
    "Deleted": false,
    "EjUserId": 756,
    "UserName": "Douglas-Larson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 65
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 590,
    "Name": "Hand-Beer",
    "PersonId": 825,
    "Rank": 88,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 505,
    "FullName": "Lucious Kessler",
    "FormalName": "Dickens Group",
    "Deleted": false,
    "EjUserId": 102,
    "UserName": "Hyatt-Windler",
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
  "Associate": {
    "AssociateId": 259,
    "Name": "Koepp LLC",
    "PersonId": 292,
    "Rank": 52,
    "Tooltip": "rem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 992,
    "FullName": "Lina VonRueden",
    "FormalName": "Mitchell-Reinger",
    "Deleted": false,
    "EjUserId": 335,
    "UserName": "Reinger, Durgan and Heidenreich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 856
      }
    }
  },
  "Business": {
    "Id": 256,
    "Value": "velit",
    "Tooltip": "sed",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 568
      }
    }
  },
  "Category": {
    "Id": 828,
    "Value": "voluptatem",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 47
      }
    }
  },
  "Country": {
    "CountryId": 558,
    "Name": "Rodriguez LLC",
    "CurrencyId": 30,
    "EnglishName": "Bernier, Raynor and Weimann",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Expanded user-facing support",
    "OrgNrText": "731141",
    "InterAreaPrefix": "iusto",
    "DialInPrefix": "quas",
    "ZipPrefix": "delectus",
    "DomainName": "Bailey-Grant",
    "AddressLayoutId": 3,
    "DomesticAddressLayoutId": 951,
    "ForeignAddressLayoutId": 779,
    "Rank": 886,
    "Tooltip": "delectus",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 675
      }
    }
  },
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 110,
      "Mrmrs": "placeat",
      "Firstname": "Julianne",
      "Lastname": "Bartell",
      "MiddleName": "Orn, Bernier and Yost",
      "Title": "quis",
      "Description": "Profound demand-driven system engine",
      "Email": "leonor_jerde@legrosshanahan.biz",
      "FullName": "Demetris Schaden",
      "DirectPhone": "655-887-4521 x668",
      "FormalName": "Hermiston-Emmerich",
      "CountryId": 18,
      "ContactId": 293,
      "ContactName": "Feeney-Hickle",
      "Retired": 34,
      "Rank": 682,
      "ActiveInterests": 2,
      "ContactDepartment": "mesh revolutionary channels",
      "ContactCountryId": 525,
      "ContactOrgNr": "397161",
      "FaxPhone": "(650)030-6315 x547",
      "MobilePhone": "1-481-563-6406",
      "ContactPhone": "1-563-721-8020 x35278",
      "AssociateName": "Blanda-Becker",
      "AssociateId": 758,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "beatae",
      "Kanalname": "perferendis",
      "Post1": "quidem",
      "Post2": "id",
      "Post3": "molestias",
      "EmailName": "bryon@hayes.name",
      "ContactFullName": "Lucas Kerluke",
      "ActiveErpLinks": 601,
      "TicketPriorityId": 143,
      "SupportLanguageId": 137,
      "SupportAssociateId": 385,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 775
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quia",
  "Xstop": true,
  "ActiveInterests": 775,
  "GroupId": 511,
  "ActiveStatusMonitorId": 757,
  "SupportAssociate": {
    "AssociateId": 302,
    "Name": "Goldner-Eichmann",
    "PersonId": 330,
    "Rank": 405,
    "Tooltip": "illum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 230,
    "FullName": "Alexis McCullough I",
    "FormalName": "Cronin-Gorczany",
    "Deleted": false,
    "EjUserId": 712,
    "UserName": "Stehr-Weissnat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transform next-generation functionalities"
        },
        "FieldType": "System.Int32",
        "FieldLength": 691
      }
    }
  },
  "TicketPriority": {
    "Id": 189,
    "Value": "consequatur",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 266
      }
    }
  },
  "CustomerLanguage": {
    "Id": 312,
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
        "FieldLength": 220
      }
    }
  },
  "Deleted": 547,
  "DbiAgentId": 244,
  "DbiLastSyncronized": "2012-07-29T18:28:48.4576262+02:00",
  "DbiKey": "quas",
  "DbiLastModified": "2020-03-01T18:28:48.4576262+01:00",
  "SupportPerson": {
    "Position": "ut",
    "PersonId": 359,
    "Mrmrs": "qui",
    "Firstname": "Bernhard",
    "Lastname": "Kulas",
    "MiddleName": "Koepp-Champlin",
    "Title": "dolor",
    "Description": "Robust reciprocal workforce",
    "Email": "jamison@ankundingkrajcik.biz",
    "FullName": "Justine Nitzsche",
    "DirectPhone": "325.373.1422 x660",
    "FormalName": "Crist-Schultz",
    "CountryId": 548,
    "ContactId": 618,
    "ContactName": "O'Conner Group",
    "Retired": 956,
    "Rank": 1000,
    "ActiveInterests": 222,
    "ContactDepartment": "",
    "ContactCountryId": 777,
    "ContactOrgNr": "836902",
    "FaxPhone": "343-626-7715",
    "MobilePhone": "454.424.3075 x1738",
    "ContactPhone": "323-004-0487 x2866",
    "AssociateName": "Watsica-Kautzer",
    "AssociateId": 965,
    "UsePersonAddress": true,
    "ContactFax": "ut",
    "Kanafname": "excepturi",
    "Kanalname": "vero",
    "Post1": "placeat",
    "Post2": "commodi",
    "Post3": "expedita",
    "EmailName": "missouri@haag.co.uk",
    "ContactFullName": "Darryl Huel",
    "ActiveErpLinks": 107,
    "TicketPriorityId": 557,
    "SupportLanguageId": 698,
    "SupportAssociateId": 3,
    "CategoryName": "VIP Customer",
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
  "Address": {
    "Wgs84Latitude": 22878.2,
    "Wgs84Longitude": 21950.536,
    "LocalizedAddress": [
      [
        {
          "Name": "Waelchi, Sporer and Gibson",
          "Value": "qui",
          "Tooltip": "sequi",
          "Label": "quibusdam",
          "ValueLength": 938,
          "AddressType": "distinctio",
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
              "FieldLength": 930
            }
          }
        }
      ],
      [
        {
          "Name": "Hand-Heathcote",
          "Value": "facere",
          "Tooltip": "molestiae",
          "Label": "et",
          "ValueLength": 326,
          "AddressType": "nihil",
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
              "FieldLength": 879
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
        "FieldType": "System.String",
        "FieldLength": 951
      }
    }
  },
  "Source": 441,
  "ActiveErpLinks": 459,
  "BounceEmails": [
    "skylar_reichert@oconner.ca",
    "garrison@robelbotsford.co.uk"
  ],
  "Domains": [
    "alias",
    "eum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "225947711"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "autem"
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
      "FieldType": "System.Int32",
      "FieldLength": 256
    }
  }
}
```