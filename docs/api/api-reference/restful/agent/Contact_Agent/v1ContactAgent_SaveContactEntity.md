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
  "ContactId": 349,
  "Name": "King, DuBuque and Hintz",
  "Department": "",
  "OrgNr": "1976854",
  "Number1": "1460607",
  "Number2": "917245",
  "UpdatedDate": "2011-12-21T16:48:29.0299296+01:00",
  "CreatedDate": "2011-10-03T16:48:29.0299296+02:00",
  "Emails": [
    {
      "Value": "saepe",
      "StrippedValue": "eligendi",
      "Description": "Phased multi-tasking protocol"
    },
    {
      "Value": "saepe",
      "StrippedValue": "eligendi",
      "Description": "Phased multi-tasking protocol"
    }
  ],
  "Interests": [
    {
      "Id": 903,
      "Name": "Cartwright, Hodkiewicz and Stroman",
      "ToolTip": "Omnis deleniti ex debitis quos voluptatem sed.",
      "Deleted": false,
      "Rank": 628,
      "Type": "laboriosam",
      "ColorBlock": 537,
      "IconHint": "iste",
      "Selected": false,
      "LastChanged": "2013-09-16T16:48:29.0299296+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "aut",
      "Hidden": true,
      "FullName": "Vivian Willms"
    }
  ],
  "Urls": [
    {
      "Value": "laboriosam",
      "StrippedValue": "illo",
      "Description": "Monitored zero defect flexibility"
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "illo",
      "Description": "Monitored zero defect flexibility"
    }
  ],
  "Phones": [
    {
      "Value": "molestias",
      "StrippedValue": "tempora",
      "Description": "Object-based bottom-line approach"
    },
    {
      "Value": "molestias",
      "StrippedValue": "tempora",
      "Description": "Object-based bottom-line approach"
    }
  ],
  "Faxes": [
    {
      "Value": "repellendus",
      "StrippedValue": "porro",
      "Description": "Innovative bandwidth-monitored system engine"
    },
    {
      "Value": "repellendus",
      "StrippedValue": "porro",
      "Description": "Innovative bandwidth-monitored system engine"
    }
  ],
  "Description": "Decentralized user-facing array",
  "UpdatedBy": {
    "AssociateId": 200,
    "Name": "Sanford-Haley",
    "PersonId": 412,
    "Rank": 65,
    "Tooltip": "at",
    "Type": "AnonymousAssociate",
    "GroupIdx": 395,
    "FullName": "Candace Zboncak",
    "FormalName": "Denesik-Nikolaus",
    "Deleted": true,
    "EjUserId": 514,
    "UserName": "Prohaska Inc and Sons"
  },
  "CreatedBy": {
    "AssociateId": 104,
    "Name": "Turcotte Inc and Sons",
    "PersonId": 185,
    "Rank": 6,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 36,
    "FullName": "Gust Walker PhD",
    "FormalName": "DuBuque, Anderson and Jewess",
    "Deleted": true,
    "EjUserId": 217,
    "UserName": "Zieme-Rowe"
  },
  "Associate": {
    "AssociateId": 504,
    "Name": "Schimmel-Halvorson",
    "PersonId": 533,
    "Rank": 747,
    "Tooltip": "velit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 232,
    "FullName": "Ava Labadie",
    "FormalName": "Christiansen, Fahey and Beer",
    "Deleted": true,
    "EjUserId": 340,
    "UserName": "Herzog-Jones"
  },
  "Business": {
    "Id": 748,
    "Value": "et",
    "Tooltip": "iusto"
  },
  "Category": {
    "Id": 436,
    "Value": "qui",
    "Tooltip": "a"
  },
  "Country": {
    "CountryId": 107,
    "Name": "Jacobi-Raynor",
    "CurrencyId": 391,
    "EnglishName": "Sporer, Russel and D'Amore",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Pre-emptive 24/7 circuit",
    "OrgNrText": "903913",
    "InterAreaPrefix": "sit",
    "DialInPrefix": "consectetur",
    "ZipPrefix": "voluptas",
    "DomainName": "Harber LLC",
    "AddressLayoutId": 78,
    "DomesticAddressLayoutId": 722,
    "ForeignAddressLayoutId": 729,
    "Rank": 689,
    "Tooltip": "enim",
    "Deleted": true
  },
  "Persons": [
    {
      "Position": "perspiciatis",
      "PersonId": 746,
      "Mrmrs": "doloribus",
      "Firstname": "Calista",
      "Lastname": "Kozey",
      "MiddleName": "Smitham-Hilpert",
      "Title": "similique",
      "Description": "Networked optimal groupware",
      "Email": "thea_beatty@lowe.com",
      "FullName": "Thora Ryan",
      "DirectPhone": "285.864.8243 x26174",
      "FormalName": "Ankunding-Hagenes",
      "CountryId": 469,
      "ContactId": 838,
      "ContactName": "Ortiz-Corwin",
      "Retired": 808,
      "Rank": 818,
      "ActiveInterests": 121,
      "ContactDepartment": "",
      "ContactCountryId": 690,
      "ContactOrgNr": "753579",
      "FaxPhone": "1-811-131-3705",
      "MobilePhone": "815-072-0413 x482",
      "ContactPhone": "(771)522-8123 x4860",
      "AssociateName": "Nikolaus LLC",
      "AssociateId": 363,
      "UsePersonAddress": true,
      "ContactFax": "id",
      "Kanafname": "non",
      "Kanalname": "ut",
      "Post1": "est",
      "Post2": "sequi",
      "Post3": "odio",
      "EmailName": "stefanie@maggiohammes.com",
      "ContactFullName": "Ruben Hamill",
      "ActiveErpLinks": 545,
      "TicketPriorityId": 800,
      "SupportLanguageId": 811,
      "SupportAssociateId": 166,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "ut",
  "Xstop": true,
  "ActiveInterests": 380,
  "GroupId": 548,
  "ActiveStatusMonitorId": 876,
  "SupportAssociate": {
    "AssociateId": 97,
    "Name": "Bergstrom-Volkman",
    "PersonId": 838,
    "Rank": 645,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 637,
    "FullName": "Dr. Kendall Zemlak",
    "FormalName": "Bins Inc and Sons",
    "Deleted": true,
    "EjUserId": 856,
    "UserName": "Cummerata-Labadie"
  },
  "TicketPriority": {
    "Id": 955,
    "Value": "earum",
    "Tooltip": "quae"
  },
  "CustomerLanguage": {
    "Id": 161,
    "Value": "quam",
    "Tooltip": "voluptatum"
  },
  "Deleted": 610,
  "DbiAgentId": 894,
  "DbiLastSyncronized": "2011-10-27T16:48:29.0339293+02:00",
  "DbiKey": "fugiat",
  "DbiLastModified": "2005-04-27T16:48:29.0339293+02:00",
  "SupportPerson": {
    "Position": "cum",
    "PersonId": 718,
    "Mrmrs": "natus",
    "Firstname": "Marlen",
    "Lastname": "Labadie",
    "MiddleName": "Frami, D'Amore and Gorczany",
    "Title": "sit",
    "Description": "Open-source incremental archive",
    "Email": "kylie_hoeger@nicolas.name",
    "FullName": "Amari Luettgen",
    "DirectPhone": "655.256.1618",
    "FormalName": "Dare Inc and Sons",
    "CountryId": 958,
    "ContactId": 876,
    "ContactName": "Kub, Bogisich and Bednar",
    "Retired": 955,
    "Rank": 517,
    "ActiveInterests": 184,
    "ContactDepartment": "",
    "ContactCountryId": 901,
    "ContactOrgNr": "1058334",
    "FaxPhone": "(038)658-4545",
    "MobilePhone": "663.345.3176 x634",
    "ContactPhone": "857.486.7060 x2125",
    "AssociateName": "Orn LLC",
    "AssociateId": 351,
    "UsePersonAddress": true,
    "ContactFax": "eum",
    "Kanafname": "id",
    "Kanalname": "nam",
    "Post1": "blanditiis",
    "Post2": "placeat",
    "Post3": "ea",
    "EmailName": "jadyn_nitzsche@millerboehm.biz",
    "ContactFullName": "Raphaelle Parker",
    "ActiveErpLinks": 91,
    "TicketPriorityId": 254,
    "SupportLanguageId": 27,
    "SupportAssociateId": 298,
    "CategoryName": "VIP Customer"
  },
  "Address": {
    "Wgs84Latitude": 12028.292,
    "Wgs84Longitude": 25397.935999999998,
    "LocalizedAddress": [
      [
        {
          "Name": "Dickens, Greenholt and Hills",
          "Value": "et",
          "Tooltip": "cumque",
          "Label": "eligendi",
          "ValueLength": 826,
          "AddressType": "nemo",
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
              "FieldLength": 763
            }
          }
        }
      ],
      [
        {
          "Name": "Zboncak-Torp",
          "Value": "ullam",
          "Tooltip": "quam",
          "Label": "cumque",
          "ValueLength": 206,
          "AddressType": "dolores",
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
              "FieldLength": 122
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "vel"
  },
  "Source": 834,
  "ActiveErpLinks": 507,
  "BounceEmails": [
    "everette_gerhold@lind.info",
    "marcelo_bartoletti@bosco.biz"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1385108203"
  },
  "ExtraFields": {
    "ExtraFields1": "blanditiis",
    "ExtraFields2": "nam"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "maxime"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 828,
  "Name": "Gaylord Group",
  "Department": "",
  "OrgNr": "747132",
  "Number1": "539017",
  "Number2": "642745",
  "UpdatedDate": "2004-12-17T16:48:29.0429308+01:00",
  "CreatedDate": "2001-03-21T16:48:29.0429308+01:00",
  "Emails": [
    {
      "Value": "maiores",
      "StrippedValue": "modi",
      "Description": "Digitized clear-thinking customer loyalty",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 237
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "modi",
      "Description": "Digitized clear-thinking customer loyalty",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 237
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 176,
      "Name": "Smitham Inc and Sons",
      "ToolTip": "Est ea voluptatem aut nihil beatae omnis.",
      "Deleted": true,
      "Rank": 802,
      "Type": "velit",
      "ColorBlock": 125,
      "IconHint": "harum",
      "Selected": false,
      "LastChanged": "2007-04-27T16:48:29.0429308+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "asperiores",
      "Hidden": true,
      "FullName": "Cletus Gusikowski",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 311
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nobis",
      "StrippedValue": "amet",
      "Description": "Reactive mission-critical flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 29
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "amet",
      "Description": "Reactive mission-critical flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 29
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quia",
      "StrippedValue": "nihil",
      "Description": "Operative radical attitude",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 729
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "nihil",
      "Description": "Operative radical attitude",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 729
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quos",
      "StrippedValue": "accusantium",
      "Description": "Open-architected bifurcated challenge",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "accusantium",
      "Description": "Open-architected bifurcated challenge",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 506
        }
      }
    }
  ],
  "Description": "Multi-lateral bottom-line array",
  "UpdatedBy": {
    "AssociateId": 642,
    "Name": "Johns Inc and Sons",
    "PersonId": 300,
    "Rank": 786,
    "Tooltip": "quas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 565,
    "FullName": "Freeman Crist",
    "FormalName": "Littel-Goyette",
    "Deleted": true,
    "EjUserId": 952,
    "UserName": "Greenfelder-Nicolas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 100
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 187,
    "Name": "Willms, Beahan and Treutel",
    "PersonId": 969,
    "Rank": 739,
    "Tooltip": "nemo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 532,
    "FullName": "Zackery Hand",
    "FormalName": "Considine LLC",
    "Deleted": false,
    "EjUserId": 240,
    "UserName": "Considine Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 826
      }
    }
  },
  "Associate": {
    "AssociateId": 556,
    "Name": "Stracke LLC",
    "PersonId": 116,
    "Rank": 843,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 855,
    "FullName": "Jacky Schmeler",
    "FormalName": "Beahan-Leuschke",
    "Deleted": false,
    "EjUserId": 775,
    "UserName": "McClure Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 91
      }
    }
  },
  "Business": {
    "Id": 732,
    "Value": "iusto",
    "Tooltip": "adipisci",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 75
      }
    }
  },
  "Category": {
    "Id": 414,
    "Value": "delectus",
    "Tooltip": "omnis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 213
      }
    }
  },
  "Country": {
    "CountryId": 262,
    "Name": "Borer-Zieme",
    "CurrencyId": 643,
    "EnglishName": "Moen Inc and Sons",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Re-contextualized foreground orchestration",
    "OrgNrText": "1441038",
    "InterAreaPrefix": "quo",
    "DialInPrefix": "eum",
    "ZipPrefix": "corporis",
    "DomainName": "VonRueden LLC",
    "AddressLayoutId": 83,
    "DomesticAddressLayoutId": 700,
    "ForeignAddressLayoutId": 727,
    "Rank": 185,
    "Tooltip": "sunt",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 496
      }
    }
  },
  "Persons": [
    {
      "Position": "eaque",
      "PersonId": 629,
      "Mrmrs": "minus",
      "Firstname": "Jo",
      "Lastname": "Frami",
      "MiddleName": "Beatty-Purdy",
      "Title": "ab",
      "Description": "Optional human-resource synergy",
      "Email": "ignatius@zemlakokuneva.ca",
      "FullName": "Roger Kertzmann",
      "DirectPhone": "247.016.0004",
      "FormalName": "Bogisich, Hudson and O'Conner",
      "CountryId": 195,
      "ContactId": 59,
      "ContactName": "Strosin, Ratke and Welch",
      "Retired": 651,
      "Rank": 167,
      "ActiveInterests": 700,
      "ContactDepartment": "",
      "ContactCountryId": 321,
      "ContactOrgNr": "1181927",
      "FaxPhone": "1-881-115-4032",
      "MobilePhone": "1-808-481-1067 x56314",
      "ContactPhone": "1-063-641-6113 x4871",
      "AssociateName": "Nicolas LLC",
      "AssociateId": 949,
      "UsePersonAddress": false,
      "ContactFax": "est",
      "Kanafname": "est",
      "Kanalname": "sequi",
      "Post1": "et",
      "Post2": "ea",
      "Post3": "cumque",
      "EmailName": "mason@hermiston.ca",
      "ContactFullName": "Russell Hagenes",
      "ActiveErpLinks": 835,
      "TicketPriorityId": 425,
      "SupportLanguageId": 583,
      "SupportAssociateId": 674,
      "CategoryName": "VIP Customer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 651
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatum",
  "Xstop": true,
  "ActiveInterests": 610,
  "GroupId": 55,
  "ActiveStatusMonitorId": 482,
  "SupportAssociate": {
    "AssociateId": 35,
    "Name": "Macejkovic Inc and Sons",
    "PersonId": 257,
    "Rank": 213,
    "Tooltip": "itaque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 454,
    "FullName": "Terrence Simonis PhD",
    "FormalName": "Windler-Mayer",
    "Deleted": false,
    "EjUserId": 578,
    "UserName": "Douglas, Considine and Mayer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 887
      }
    }
  },
  "TicketPriority": {
    "Id": 395,
    "Value": "modi",
    "Tooltip": "vitae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 919
      }
    }
  },
  "CustomerLanguage": {
    "Id": 38,
    "Value": "animi",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 58
      }
    }
  },
  "Deleted": 350,
  "DbiAgentId": 724,
  "DbiLastSyncronized": "1999-09-16T16:48:29.0469292+02:00",
  "DbiKey": "adipisci",
  "DbiLastModified": "1996-08-20T16:48:29.0469292+02:00",
  "SupportPerson": {
    "Position": "doloremque",
    "PersonId": 199,
    "Mrmrs": "necessitatibus",
    "Firstname": "Katelynn",
    "Lastname": "Osinski",
    "MiddleName": "Weissnat, Hane and Hintz",
    "Title": "totam",
    "Description": "Right-sized bandwidth-monitored array",
    "Email": "leopold_walter@gottlieb.info",
    "FullName": "Deon Hermiston",
    "DirectPhone": "850-072-1055 x33355",
    "FormalName": "Pollich, Mann and Johnston",
    "CountryId": 453,
    "ContactId": 932,
    "ContactName": "Russel Inc and Sons",
    "Retired": 701,
    "Rank": 272,
    "ActiveInterests": 666,
    "ContactDepartment": "",
    "ContactCountryId": 556,
    "ContactOrgNr": "969723",
    "FaxPhone": "177-323-0150 x4322",
    "MobilePhone": "556.017.8867 x824",
    "ContactPhone": "(841)061-4624 x3427",
    "AssociateName": "Rohan, Johns and Walsh",
    "AssociateId": 396,
    "UsePersonAddress": false,
    "ContactFax": "laborum",
    "Kanafname": "enim",
    "Kanalname": "aut",
    "Post1": "itaque",
    "Post2": "non",
    "Post3": "aperiam",
    "EmailName": "jayden_mayer@hahn.com",
    "ContactFullName": "Dr. Elvera Cronin",
    "ActiveErpLinks": 763,
    "TicketPriorityId": 678,
    "SupportLanguageId": 550,
    "SupportAssociateId": 50,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 1000
      }
    }
  },
  "Address": {
    "Wgs84Latitude": 28995.768,
    "Wgs84Longitude": 26497.969999999998,
    "LocalizedAddress": [
      [
        {
          "Name": "Harber-Oberbrunner",
          "Value": "et",
          "Tooltip": "necessitatibus",
          "Label": "non",
          "ValueLength": 782,
          "AddressType": "corporis",
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
              "FieldLength": 107
            }
          }
        }
      ],
      [
        {
          "Name": "Gleason-Ortiz",
          "Value": "ullam",
          "Tooltip": "unde",
          "Label": "quaerat",
          "ValueLength": 240,
          "AddressType": "ad",
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
              "FieldLength": 323
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "reprehenderit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 454
      }
    }
  },
  "Source": 415,
  "ActiveErpLinks": 533,
  "BounceEmails": [
    "jadon_rohan@runte.ca",
    "charity_bartell@hegmann.biz"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Trevion Dickinson",
    "SuperOffice:2": "Fabiola Blanda"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "eius"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "sunt"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "revolutionize transparent models"
      },
      "FieldType": "System.Int32",
      "FieldLength": 520
    }
  }
}
```