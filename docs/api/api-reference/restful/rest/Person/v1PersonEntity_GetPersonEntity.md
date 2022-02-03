---
title: GET Person/{id}
id: v1PersonEntity_GetPersonEntity
---

# GET Person/{id}

```http
GET /api/v1/Person/{id}
```

Gets a PersonEntity object.

Calls the Person agent service GetPersonEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the PersonEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Person/{id}?$select=name,department,category/id
GET /api/v1/Person/{id}?fk=False
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

The Person Service. The service implements all services working with the Person object.



PersonEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity found. |
| 304 | PersonEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

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
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 27 Nov 2006 18:25:50 G11T

{
  "PersonId": 87,
  "Firstname": "Arnulfo",
  "MiddleName": "Cole-Schaefer",
  "Lastname": "O'Kon",
  "Mrmrs": "animi",
  "Title": "vitae",
  "UpdatedDate": "2006-11-27T18:25:50.6755957+01:00",
  "CreatedDate": "2016-04-13T18:25:50.6755957+02:00",
  "BirthDate": "2010-11-06T18:25:50.6755957+01:00",
  "CreatedBy": {
    "AssociateId": 702,
    "Name": "Oberbrunner Inc and Sons",
    "PersonId": 466,
    "Rank": 120,
    "Tooltip": "tempore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 215,
    "FullName": "Elisha Schimmel",
    "FormalName": "Mitchell, Mayert and Prohaska",
    "Deleted": false,
    "EjUserId": 316,
    "UserName": "Mante-Kunze",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 115
      }
    }
  },
  "Emails": [
    {
      "Value": "nemo",
      "StrippedValue": "libero",
      "Description": "Mandatory clear-thinking support",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 553
        }
      }
    },
    {
      "Value": "nemo",
      "StrippedValue": "libero",
      "Description": "Mandatory clear-thinking support",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 553
        }
      }
    }
  ],
  "Description": "Diverse client-driven secured line",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "officiis",
      "Description": "Streamlined zero tolerance portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 176
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "officiis",
      "Description": "Streamlined zero tolerance portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 176
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "sed",
      "Description": "Open-architected high-level focus group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 306
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "sed",
      "Description": "Open-architected high-level focus group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 306
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "iure",
      "Description": "Multi-lateral 24 hour neural-net",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 495
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "iure",
      "Description": "Multi-lateral 24 hour neural-net",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 495
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "voluptates",
      "Description": "Fully-configurable tertiary attitude",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 281
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "voluptates",
      "Description": "Fully-configurable tertiary attitude",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 281
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "non",
      "StrippedValue": "quos",
      "Description": "Reactive fresh-thinking archive",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "quos",
      "Description": "Reactive fresh-thinking archive",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 359
        }
      }
    }
  ],
  "Position": {
    "Id": 285,
    "Value": "sunt",
    "Tooltip": "dignissimos",
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
  "UpdatedBy": {
    "AssociateId": 897,
    "Name": "Ritchie-Bernhard",
    "PersonId": 854,
    "Rank": 871,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 231,
    "FullName": "Edgardo Will",
    "FormalName": "Larson, Maggio and Boehm",
    "Deleted": false,
    "EjUserId": 298,
    "UserName": "Watsica LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 700
      }
    }
  },
  "Contact": {
    "ContactId": 414,
    "Name": "Weber, King and Metz",
    "OrgNr": "411847",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dolorem",
    "DirectPhone": "257.783.5802",
    "AssociateId": 950,
    "CountryId": 573,
    "EmailAddress": "florida_kilback@berge.biz",
    "Kananame": "sequi",
    "EmailAddressName": "patience@abbott.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Miss Kyler Powlowski",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "pariatur",
    "FullName": "Jaeden Konopelski",
    "IsOwnerContact": false,
    "ActiveErpLinks": 217,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "transform dynamic vortals"
        },
        "FieldType": "System.Int32",
        "FieldLength": 122
      }
    }
  },
  "Country": {
    "CountryId": 94,
    "Name": "Russel Inc and Sons",
    "CurrencyId": 290,
    "EnglishName": "Haag LLC",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Grass-roots human-resource function",
    "OrgNrText": "751675",
    "InterAreaPrefix": "a",
    "DialInPrefix": "reiciendis",
    "ZipPrefix": "ea",
    "DomainName": "Kertzmann, Lang and Ebert",
    "AddressLayoutId": 990,
    "DomesticAddressLayoutId": 477,
    "ForeignAddressLayoutId": 78,
    "Rank": 52,
    "Tooltip": "unde",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 90
      }
    }
  },
  "Interests": [
    {
      "Id": 909,
      "Name": "Klein-Stamm",
      "ToolTip": "Totam iure voluptas.",
      "Deleted": true,
      "Rank": 852,
      "Type": "praesentium",
      "ColorBlock": 247,
      "IconHint": "quis",
      "Selected": true,
      "LastChanged": "2018-04-12T18:25:50.6786301+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "soluta",
      "Hidden": false,
      "FullName": "Oswaldo Russel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 985
        }
      }
    }
  ],
  "PersonNumber": "1286186",
  "FullName": "Janae O'Conner",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "in",
      "StrippedValue": "corrupti",
      "Description": "Persistent 24/7 frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 250
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "corrupti",
      "Description": "Persistent 24/7 frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 250
        }
      }
    }
  ],
  "FormalName": "Deckow, Nikolaus and Cassin",
  "Address": {
    "Wgs84Latitude": 27858.126,
    "Wgs84Longitude": 5412.418,
    "LocalizedAddress": [
      [
        {
          "Name": "Hane-Reynolds",
          "Value": "architecto",
          "Tooltip": "ea",
          "Label": "vero",
          "ValueLength": 916,
          "AddressType": "eligendi",
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
              "FieldLength": 1001
            }
          }
        }
      ],
      [
        {
          "Name": "Effertz Group",
          "Value": "error",
          "Tooltip": "officiis",
          "Label": "vel",
          "ValueLength": 820,
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
              "FieldLength": 180
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "dolorum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 224
      }
    }
  },
  "Post3": "aut",
  "Post2": "numquam",
  "Post1": "labore",
  "Kanalname": "qui",
  "Kanafname": "rerum",
  "CorrespondingAssociate": {
    "AssociateId": 875,
    "Name": "Green, Hand and Rowe",
    "PersonId": 248,
    "Rank": 800,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 956,
    "FullName": "Dr. Kendra Dietrich",
    "FormalName": "Heidenreich, Carter and Heaney",
    "Deleted": true,
    "EjUserId": 944,
    "UserName": "Reichert, Okuneva and Heathcote",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 727
      }
    }
  },
  "Category": {
    "Id": 144,
    "Value": "quos",
    "Tooltip": "ullam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 923
      }
    }
  },
  "Business": {
    "Id": 420,
    "Value": "qui",
    "Tooltip": "sunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 127
      }
    }
  },
  "Associate": {
    "AssociateId": 651,
    "Name": "Hartmann Group",
    "PersonId": 833,
    "Rank": 480,
    "Tooltip": "cumque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 955,
    "FullName": "Wilfred Grimes",
    "FormalName": "Conn, Mertz and McCullough",
    "Deleted": false,
    "EjUserId": 466,
    "UserName": "Padberg-Stiedemann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 702
      }
    }
  },
  "Salutation": "quidem",
  "ActiveInterests": 208,
  "SupportAssociate": {
    "AssociateId": 388,
    "Name": "Hudson, Ondricka and Hauck",
    "PersonId": 624,
    "Rank": 642,
    "Tooltip": "magnam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 14,
    "FullName": "Ms. Pattie Streich",
    "FormalName": "Weissnat-Casper",
    "Deleted": true,
    "EjUserId": 683,
    "UserName": "Yost Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 793
      }
    }
  },
  "TicketPriority": {
    "Id": 646,
    "Value": "praesentium",
    "Tooltip": "sed",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 135
      }
    }
  },
  "CustomerLanguage": {
    "Id": 240,
    "Value": "a",
    "Tooltip": "et",
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
  "DbiAgentId": 323,
  "DbiKey": "et",
  "DbiLastModified": "2007-12-31T18:25:50.6806304+01:00",
  "DbiLastSyncronized": "2013-05-08T18:25:50.6806304+02:00",
  "SentInfo": 487,
  "ShowContactTickets": 580,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 956,
    "UserName": "Jacobi LLC",
    "PersonId": 589,
    "Rank": 346,
    "Tooltip": "eum",
    "UserGroupId": 998,
    "EjUserId": 747,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "voluptatum",
      "odit"
    ],
    "CanLogon": true,
    "RoleName": "Collins, Muller and Cummerata",
    "RoleTooltip": "sit",
    "UserGroupName": "O'Kon, Kutch and Heller",
    "UserGroupTooltip": "quis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "harness holistic architectures"
        },
        "FieldType": "System.Int32",
        "FieldLength": 62
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "magni",
      "StrippedValue": "est",
      "Description": "Virtual actuating interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 779
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "est",
      "Description": "Virtual actuating interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 779
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "exercitationem",
      "StrippedValue": "aut",
      "Description": "Robust client-driven standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 134
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "aut",
      "Description": "Robust client-driven standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 134
        }
      }
    }
  ],
  "Source": 745,
  "ActiveErpLinks": 133,
  "ShipmentTypes": [
    {
      "Id": 237,
      "Name": "Larkin-Breitenberg",
      "ToolTip": "Velit illum aliquid qui delectus nobis magni.",
      "Deleted": true,
      "Rank": 488,
      "Type": "aspernatur",
      "ColorBlock": 556,
      "IconHint": "voluptatum",
      "Selected": true,
      "LastChanged": "2002-01-10T18:25:50.6806304+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "sint",
      "Hidden": true,
      "FullName": "Betty Connelly V",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 368
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 416,
      "Comment": "unde",
      "Registered": "2010-07-19T18:25:50.6816313+02:00",
      "RegisteredAssociateId": 644,
      "Updated": "2020-08-17T18:25:50.6816313+02:00",
      "UpdatedAssociateId": 723,
      "LegalBaseId": 427,
      "LegalBaseKey": "voluptas",
      "LegalBaseName": "Pacocha LLC",
      "ConsentPurposeId": 690,
      "ConsentPurposeKey": "enim",
      "ConsentPurposeName": "Bosco, O'Keefe and Muller",
      "ConsentSourceId": 408,
      "ConsentSourceKey": "facilis",
      "ConsentSourceName": "Dibbert LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 870
        }
      }
    }
  ],
  "BounceEmails": [
    "giovanna_stroman@barrows.com",
    "hilma@gusikowskistark.us"
  ],
  "ActiveStatusMonitorId": 119,
  "UserDefinedFields": {
    "SuperOffice:1": "Talia Shields",
    "SuperOffice:2": "Noemie Willms"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatibus",
    "ExtraFields2": "tempora"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "numquam"
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
      "FieldLength": 618
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```