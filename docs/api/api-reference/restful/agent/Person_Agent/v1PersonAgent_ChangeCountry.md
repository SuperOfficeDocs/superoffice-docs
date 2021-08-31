---
title: ChangeCountry
id: v1PersonAgent_ChangeCountry
---

# ChangeCountry

```http
POST /api/v1/Agents/Person/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format for this entity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/ChangeCountry?$select=name,department,category/id
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

PersonEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonEntity |  |  |
| ToCountryId | int32 |  |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as Date |
| CreatedBy |  | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position |  | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy |  | The person that last updated the person object |
| Contact |  | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country |  | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address |  | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate |  | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category |  | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business |  | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate |  | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo |  | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Person/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": {
    "PersonId": 452,
    "Firstname": "Jackeline",
    "MiddleName": "Tremblay, Pfeffer and Gerhold",
    "Lastname": "Kuphal",
    "Mrmrs": "saepe",
    "Title": "similique",
    "UpdatedDate": "2016-03-12T14:58:04.7054598+01:00",
    "CreatedDate": "2015-02-20T14:58:04.7054598+01:00",
    "BirthDate": "2020-09-23T14:58:04.7054598+02:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Quality-focused didactic product",
    "IsAssociate": true,
    "PrivatePhones": [
      {},
      {}
    ],
    "Faxes": [
      {},
      {}
    ],
    "MobilePhones": [
      {},
      {}
    ],
    "OfficePhones": [
      {},
      {}
    ],
    "OtherPhones": [
      {},
      {}
    ],
    "Position": {},
    "UpdatedBy": {},
    "Contact": {},
    "Country": {},
    "Interests": [
      {},
      {}
    ],
    "PersonNumber": "1712796",
    "FullName": "Manuel Windler",
    "NoMailing": true,
    "UsePersonAddress": false,
    "Retired": true,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Cremin, Armstrong and Hauck",
    "Address": {},
    "Post3": "voluptates",
    "Post2": "sint",
    "Post1": "rerum",
    "Kanalname": "laborum",
    "Kanafname": "perspiciatis",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "et",
    "ActiveInterests": 263,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 132,
    "DbiKey": "rerum",
    "DbiLastModified": "2020-08-26T14:58:04.7054598+02:00",
    "DbiLastSyncronized": "2018-12-24T14:58:04.7054598+01:00",
    "SentInfo": 298,
    "ShowContactTickets": 323,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 740,
    "ActiveErpLinks": 875,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "curt@sawayn.uk",
      "kamron.franecki@schummokuneva.info"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "Ms. Carter O'Hara",
      "SuperOffice:2": "Ms. Rico Prohaska"
    },
    "ExtraFields": {
      "ExtraFields1": "aut",
      "ExtraFields2": "vero"
    },
    "CustomFields": {
      "CustomFields1": "animi",
      "CustomFields2": "eligendi"
    }
  },
  "ToCountryId": 228
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 887,
  "Firstname": "Birdie",
  "MiddleName": "Parker LLC",
  "Lastname": "Stokes",
  "Mrmrs": "ipsam",
  "Title": "quae",
  "UpdatedDate": "1995-11-17T14:58:04.7144597+01:00",
  "CreatedDate": "2018-11-30T14:58:04.7144597+01:00",
  "BirthDate": "1999-06-21T14:58:04.7144597+02:00",
  "CreatedBy": {
    "AssociateId": 497,
    "Name": "Kiehn, Legros and Schinner",
    "PersonId": 886,
    "Rank": 636,
    "Tooltip": "quos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 142,
    "FullName": "Eulalia Simonis",
    "FormalName": "Dibbert LLC",
    "Deleted": true,
    "EjUserId": 991,
    "UserName": "Hansen Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 402
      }
    }
  },
  "Emails": [
    {
      "Value": "rerum",
      "StrippedValue": "quasi",
      "Description": "Multi-channelled bi-directional product",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "quasi",
      "Description": "Multi-channelled bi-directional product",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 209
        }
      }
    }
  ],
  "Description": "Synergized tertiary complexity",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "beatae",
      "Description": "Seamless bandwidth-monitored algorithm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "seize turn-key experiences"
          },
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "beatae",
      "Description": "Seamless bandwidth-monitored algorithm",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "seize turn-key experiences"
          },
          "FieldType": "System.String",
          "FieldLength": 483
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "quas",
      "Description": "Integrated hybrid pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 10
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "quas",
      "Description": "Integrated hybrid pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 10
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "iure",
      "StrippedValue": "eos",
      "Description": "Virtual mission-critical instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 453
        }
      }
    },
    {
      "Value": "iure",
      "StrippedValue": "eos",
      "Description": "Virtual mission-critical instruction set",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 453
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "vel",
      "StrippedValue": "minima",
      "Description": "Grass-roots contextually-based infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "minima",
      "Description": "Grass-roots contextually-based infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "laborum",
      "StrippedValue": "expedita",
      "Description": "Implemented hybrid open system",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 378
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "expedita",
      "Description": "Implemented hybrid open system",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 378
        }
      }
    }
  ],
  "Position": {
    "Id": 72,
    "Value": "minus",
    "Tooltip": "temporibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 158
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 859,
    "Name": "Dooley, Schuster and Ritchie",
    "PersonId": 268,
    "Rank": 118,
    "Tooltip": "occaecati",
    "Type": "AnonymousAssociate",
    "GroupIdx": 726,
    "FullName": "Rhoda DuBuque",
    "FormalName": "Wilderman, Marquardt and Hand",
    "Deleted": true,
    "EjUserId": 18,
    "UserName": "Kutch Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 574
      }
    }
  },
  "Contact": {
    "ContactId": 547,
    "Name": "Kessler, Hartmann and Waters",
    "OrgNr": "707260",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "velit",
    "DirectPhone": "(803)480-2424 x741",
    "AssociateId": 827,
    "CountryId": 536,
    "EmailAddress": "amparo@wuckertraynor.com",
    "Kananame": "eligendi",
    "EmailAddressName": "deon.pfeffer@connelly.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Benjamin Jakubowski",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quidem",
    "FullName": "Julia Price",
    "IsOwnerContact": true,
    "ActiveErpLinks": 135,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "innovate dynamic eyeballs"
        },
        "FieldType": "System.String",
        "FieldLength": 399
      }
    }
  },
  "Country": {
    "CountryId": 569,
    "Name": "Prosacco, Sawayn and Powlowski",
    "CurrencyId": 331,
    "EnglishName": "Jenkins, Schowalter and Grimes",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Triple-buffered encompassing hub",
    "OrgNrText": "847157",
    "InterAreaPrefix": "distinctio",
    "DialInPrefix": "aut",
    "ZipPrefix": "voluptate",
    "DomainName": "Kuvalis-Shields",
    "AddressLayoutId": 281,
    "DomesticAddressLayoutId": 482,
    "ForeignAddressLayoutId": 5,
    "Rank": 498,
    "Tooltip": "voluptas",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 574
      }
    }
  },
  "Interests": [
    {
      "Id": 839,
      "Name": "Hilpert-Spinka",
      "ToolTip": "Atque quo eum aliquam fuga ea.",
      "Deleted": false,
      "Rank": 724,
      "Type": "et",
      "ColorBlock": 73,
      "IconHint": "aut",
      "Selected": true,
      "LastChanged": "1994-08-11T14:58:04.7694668+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "laudantium",
      "StyleHint": "quas",
      "Hidden": true,
      "FullName": "Herman Skiles",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 160
        }
      }
    }
  ],
  "PersonNumber": "896480",
  "FullName": "Sandrine Graham",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "sed",
      "Description": "Universal neutral emulation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 476
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sed",
      "Description": "Universal neutral emulation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 476
        }
      }
    }
  ],
  "FormalName": "Bosco, Jakubowski and Kshlerin",
  "Address": {
    "Wgs84Latitude": 11683.552,
    "Wgs84Longitude": 17766.646,
    "LocalizedAddress": [
      [
        {
          "Name": "Murazik, King and Beier",
          "Value": "vero",
          "Tooltip": "in",
          "Label": "est",
          "ValueLength": 886,
          "AddressType": "recusandae",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "empower magnetic eyeballs"
              },
              "FieldType": "System.String",
              "FieldLength": 587
            }
          }
        }
      ],
      [
        {
          "Name": "Baumbach-Zemlak",
          "Value": "velit",
          "Tooltip": "enim",
          "Label": "et",
          "ValueLength": 355,
          "AddressType": "ullam",
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
              "FieldLength": 794
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 968
      }
    }
  },
  "Post3": "voluptatibus",
  "Post2": "sapiente",
  "Post1": "fugit",
  "Kanalname": "nesciunt",
  "Kanafname": "veniam",
  "CorrespondingAssociate": {
    "AssociateId": 111,
    "Name": "Bergstrom-Schuster",
    "PersonId": 660,
    "Rank": 887,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 532,
    "FullName": "Lorenza Hilll DDS",
    "FormalName": "Goodwin, Koss and Nolan",
    "Deleted": false,
    "EjUserId": 47,
    "UserName": "Little, Oberbrunner and Balistreri",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 350
      }
    }
  },
  "Category": {
    "Id": 127,
    "Value": "nemo",
    "Tooltip": "voluptate",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 811
      }
    }
  },
  "Business": {
    "Id": 999,
    "Value": "provident",
    "Tooltip": "culpa",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 209
      }
    }
  },
  "Associate": {
    "AssociateId": 617,
    "Name": "Bernhard-O'Reilly",
    "PersonId": 646,
    "Rank": 404,
    "Tooltip": "pariatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 564,
    "FullName": "Alize Moen",
    "FormalName": "Considine-Von",
    "Deleted": true,
    "EjUserId": 539,
    "UserName": "D'Amore Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 468
      }
    }
  },
  "Salutation": "excepturi",
  "ActiveInterests": 262,
  "SupportAssociate": {
    "AssociateId": 683,
    "Name": "O'Connell Group",
    "PersonId": 300,
    "Rank": 8,
    "Tooltip": "ullam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 463,
    "FullName": "Susan Price",
    "FormalName": "Reichel-Sipes",
    "Deleted": false,
    "EjUserId": 770,
    "UserName": "Powlowski-Howell",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 645
      }
    }
  },
  "TicketPriority": {
    "Id": 556,
    "Value": "vel",
    "Tooltip": "et",
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
  "CustomerLanguage": {
    "Id": 168,
    "Value": "repudiandae",
    "Tooltip": "quod",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 639
      }
    }
  },
  "DbiAgentId": 551,
  "DbiKey": "voluptatem",
  "DbiLastModified": "2008-09-23T14:58:04.7724788+02:00",
  "DbiLastSyncronized": "2003-05-15T14:58:04.7724788+02:00",
  "SentInfo": 516,
  "ShowContactTickets": 537,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 700,
    "UserName": "Schultz Group",
    "PersonId": 235,
    "Rank": 721,
    "Tooltip": "dolores",
    "UserGroupId": 746,
    "EjUserId": 27,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "fuga",
      "quisquam"
    ],
    "CanLogon": true,
    "RoleName": "Hudson-Medhurst",
    "RoleTooltip": "id",
    "UserGroupName": "Schaefer Group",
    "UserGroupTooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 83
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "tenetur",
      "Description": "Networked assymetric approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 625
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "tenetur",
      "Description": "Networked assymetric approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 625
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "repellat",
      "StrippedValue": "et",
      "Description": "Polarised 24/7 emulation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 278
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "et",
      "Description": "Polarised 24/7 emulation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 278
        }
      }
    }
  ],
  "Source": 921,
  "ActiveErpLinks": 616,
  "ShipmentTypes": [
    {
      "Id": 966,
      "Name": "Greenholt, Williamson and Harber",
      "ToolTip": "Cumque sunt consequatur distinctio.",
      "Deleted": false,
      "Rank": 355,
      "Type": "libero",
      "ColorBlock": 765,
      "IconHint": "itaque",
      "Selected": true,
      "LastChanged": "2009-02-06T14:58:04.7734656+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ullam",
      "StyleHint": "doloremque",
      "Hidden": true,
      "FullName": "Theron Schmeler DDS",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 949,
      "Comment": "doloribus",
      "Registered": "1998-12-28T14:58:04.7734656+01:00",
      "RegisteredAssociateId": 794,
      "Updated": "2018-06-25T14:58:04.7734656+02:00",
      "UpdatedAssociateId": 905,
      "LegalBaseId": 511,
      "LegalBaseKey": "ab",
      "LegalBaseName": "Hartmann Group",
      "ConsentPurposeId": 265,
      "ConsentPurposeKey": "nisi",
      "ConsentPurposeName": "Green-Hilll",
      "ConsentSourceId": 517,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Blanda LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 627
        }
      }
    }
  ],
  "BounceEmails": [
    "otilia_klocko@jakubowski.name",
    "reggie.white@franeckistehr.biz"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "2094959649",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "eius"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "amet"
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
      "FieldLength": 267
    }
  }
}
```