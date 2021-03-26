---
title: POST Agents/Person/GetPersonEntity
id: v1PersonAgent_GetPersonEntity
---

# POST Agents/Person/GetPersonEntity

```http
POST /api/v1/Agents/Person/GetPersonEntity
```

Gets a PersonEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=801
POST /api/v1/Agents/Person/GetPersonEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 709,
  "Firstname": "Mike",
  "MiddleName": "Kutch LLC",
  "Lastname": "Trantow",
  "Mrmrs": "minima",
  "Title": "ipsa",
  "UpdatedDate": "2005-03-05T16:48:30.0488968+01:00",
  "CreatedDate": "2018-09-22T16:48:30.0488968+02:00",
  "BirthDate": "2003-05-06T16:48:30.0488968+02:00",
  "CreatedBy": {
    "AssociateId": 705,
    "Name": "Lakin, Jakubowski and O'Conner",
    "PersonId": 36,
    "Rank": 769,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 793,
    "FullName": "Santiago Altenwerth",
    "FormalName": "Jones-Johnston",
    "Deleted": true,
    "EjUserId": 812,
    "UserName": "Little, Zemlak and Kovacek",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 608
      }
    }
  },
  "Emails": [
    {
      "Value": "unde",
      "StrippedValue": "distinctio",
      "Description": "Future-proofed radical time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "redefine compelling interfaces"
          },
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "distinctio",
      "Description": "Future-proofed radical time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "redefine compelling interfaces"
          },
          "FieldType": "System.Int32",
          "FieldLength": 253
        }
      }
    }
  ],
  "Description": "Upgradable tertiary capability",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "sunt",
      "Description": "Synchronised object-oriented moderator",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 713
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "sunt",
      "Description": "Synchronised object-oriented moderator",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 713
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "perferendis",
      "Description": "Managed zero defect system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 634
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "perferendis",
      "Description": "Managed zero defect system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 634
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "praesentium",
      "Description": "Multi-lateral solution-oriented info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 324
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "praesentium",
      "Description": "Multi-lateral solution-oriented info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 324
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "quisquam",
      "Description": "Quality-focused neutral pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quisquam",
      "Description": "Quality-focused neutral pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 851
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "soluta",
      "StrippedValue": "et",
      "Description": "Optional transitional data-warehouse",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    },
    {
      "Value": "soluta",
      "StrippedValue": "et",
      "Description": "Optional transitional data-warehouse",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 78
        }
      }
    }
  ],
  "Position": {
    "Id": 484,
    "Value": "nostrum",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 767
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 493,
    "Name": "Bruen-Schuppe",
    "PersonId": 810,
    "Rank": 148,
    "Tooltip": "nostrum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 571,
    "FullName": "Schuyler Daugherty",
    "FormalName": "Toy LLC",
    "Deleted": true,
    "EjUserId": 563,
    "UserName": "Marvin Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 10
      }
    }
  },
  "Contact": {
    "ContactId": 761,
    "Name": "Keebler Group",
    "OrgNr": "794515",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "est",
    "DirectPhone": "052.031.8703",
    "AssociateId": 205,
    "CountryId": 307,
    "EmailAddress": "greg.zulauf@luettgen.name",
    "Kananame": "aperiam",
    "EmailAddressName": "amani.gorczany@walshblock.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jeff Purdy",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ipsa",
    "FullName": "Jamal Stoltenberg III",
    "IsOwnerContact": true,
    "ActiveErpLinks": 833,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 456
      }
    }
  },
  "Country": {
    "CountryId": 228,
    "Name": "Predovic Inc and Sons",
    "CurrencyId": 791,
    "EnglishName": "Lockman-Dickinson",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Multi-layered zero tolerance internet solution",
    "OrgNrText": "481306",
    "InterAreaPrefix": "et",
    "DialInPrefix": "at",
    "ZipPrefix": "quidem",
    "DomainName": "Schumm-Boehm",
    "AddressLayoutId": 598,
    "DomesticAddressLayoutId": 151,
    "ForeignAddressLayoutId": 848,
    "Rank": 239,
    "Tooltip": "ut",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 6
      }
    }
  },
  "Interests": [
    {
      "Id": 596,
      "Name": "Frami, Prohaska and Mraz",
      "ToolTip": "Dicta ab exercitationem.",
      "Deleted": true,
      "Rank": 808,
      "Type": "quisquam",
      "ColorBlock": 417,
      "IconHint": "blanditiis",
      "Selected": false,
      "LastChanged": "1994-06-06T16:48:30.05193+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "explicabo",
      "StyleHint": "quidem",
      "Hidden": true,
      "FullName": "Katelin Kling",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 989
        }
      }
    }
  ],
  "PersonNumber": "855594",
  "FullName": "Hettie Klein III",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "unde",
      "StrippedValue": "cupiditate",
      "Description": "Synchronised regional model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "cupiditate",
      "Description": "Synchronised regional model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 890
        }
      }
    }
  ],
  "FormalName": "Bernier-Wisozk",
  "Address": {
    "Wgs84Latitude": 6612.74,
    "Wgs84Longitude": 25147.216,
    "LocalizedAddress": [
      [
        {
          "Name": "Ruecker, Schroeder and Crist",
          "Value": "id",
          "Tooltip": "nulla",
          "Label": "et",
          "ValueLength": 379,
          "AddressType": "nostrum",
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
              "FieldLength": 966
            }
          }
        }
      ],
      [
        {
          "Name": "O'Connell-Buckridge",
          "Value": "facilis",
          "Tooltip": "sit",
          "Label": "qui",
          "ValueLength": 318,
          "AddressType": "ex",
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
              "FieldLength": 864
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
        "FieldType": "System.String",
        "FieldLength": 216
      }
    }
  },
  "Post3": "velit",
  "Post2": "quo",
  "Post1": "saepe",
  "Kanalname": "et",
  "Kanafname": "consequatur",
  "CorrespondingAssociate": {
    "AssociateId": 668,
    "Name": "Spinka LLC",
    "PersonId": 171,
    "Rank": 247,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 529,
    "FullName": "Isabel VonRueden",
    "FormalName": "O'Reilly LLC",
    "Deleted": false,
    "EjUserId": 922,
    "UserName": "Pagac Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 236
      }
    }
  },
  "Category": {
    "Id": 232,
    "Value": "dolores",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 456
      }
    }
  },
  "Business": {
    "Id": 352,
    "Value": "et",
    "Tooltip": "eligendi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 55
      }
    }
  },
  "Associate": {
    "AssociateId": 183,
    "Name": "Moen-Kulas",
    "PersonId": 94,
    "Rank": 171,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 538,
    "FullName": "Trinity Langosh",
    "FormalName": "Weissnat Inc and Sons",
    "Deleted": false,
    "EjUserId": 696,
    "UserName": "Collier-Jenkins",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 465
      }
    }
  },
  "Salutation": "adipisci",
  "ActiveInterests": 812,
  "SupportAssociate": {
    "AssociateId": 472,
    "Name": "Nitzsche LLC",
    "PersonId": 172,
    "Rank": 101,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 737,
    "FullName": "Eriberto Kozey",
    "FormalName": "Balistreri-Gutmann",
    "Deleted": true,
    "EjUserId": 517,
    "UserName": "Gaylord, Rath and Tremblay",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 762
      }
    }
  },
  "TicketPriority": {
    "Id": 643,
    "Value": "molestiae",
    "Tooltip": "doloremque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 819
      }
    }
  },
  "CustomerLanguage": {
    "Id": 959,
    "Value": "velit",
    "Tooltip": "esse",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 205
      }
    }
  },
  "DbiAgentId": 237,
  "DbiKey": "distinctio",
  "DbiLastModified": "2000-01-10T16:48:30.0549241+01:00",
  "DbiLastSyncronized": "2013-04-17T16:48:30.0549241+02:00",
  "SentInfo": 669,
  "ShowContactTickets": 26,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 79,
    "UserName": "Boyle, Marvin and Kovacek",
    "PersonId": 861,
    "Rank": 552,
    "Tooltip": "blanditiis",
    "UserGroupId": 894,
    "EjUserId": 71,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "minima",
      "necessitatibus"
    ],
    "CanLogon": false,
    "RoleName": "Jaskolski Inc and Sons",
    "RoleTooltip": "quam",
    "UserGroupName": "Glover, Graham and Lockman",
    "UserGroupTooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 764
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "vitae",
      "StrippedValue": "aperiam",
      "Description": "Multi-tiered content-based infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "aperiam",
      "Description": "Multi-tiered content-based infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 959
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quis",
      "StrippedValue": "et",
      "Description": "User-friendly multi-tasking process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "et",
      "Description": "User-friendly multi-tasking process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    }
  ],
  "Source": 204,
  "ActiveErpLinks": 658,
  "ShipmentTypes": [
    {
      "Id": 140,
      "Name": "Green, Walker and Hahn",
      "ToolTip": "Nemo deserunt voluptatem nemo voluptatem dolorum.",
      "Deleted": true,
      "Rank": 317,
      "Type": "in",
      "ColorBlock": 585,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2008-07-10T16:48:30.0549241+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eveniet",
      "StyleHint": "ab",
      "Hidden": false,
      "FullName": "Estell Veum II",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 446
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 898,
      "Comment": "tenetur",
      "Registered": "2005-10-27T16:48:30.0549241+02:00",
      "RegisteredAssociateId": 723,
      "Updated": "1994-06-09T16:48:30.0549241+02:00",
      "UpdatedAssociateId": 53,
      "LegalBaseId": 368,
      "LegalBaseKey": "et",
      "LegalBaseName": "Thompson, Sanford and Hegmann",
      "ConsentPurposeId": 366,
      "ConsentPurposeKey": "quidem",
      "ConsentPurposeName": "Grimes, Schultz and Dickinson",
      "ConsentSourceId": 905,
      "ConsentSourceKey": "sit",
      "ConsentSourceName": "Reilly, Klein and Wolf",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 933
        }
      }
    }
  ],
  "BounceEmails": [
    "murl.roberts@aufderharohara.ca",
    "avis@sipes.info"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Michelle Mosciski",
    "SuperOffice:2": "Zackary Rempel"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "cupiditate"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "voluptatem"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": "integrate plug-and-play e-commerce"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 738
    }
  }
}
```