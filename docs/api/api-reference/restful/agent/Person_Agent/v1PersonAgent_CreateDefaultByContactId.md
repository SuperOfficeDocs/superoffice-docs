---
title: POST Agents/Person/CreateDefaultByContactId
id: v1PersonAgent_CreateDefaultByContactId
---

# POST Agents/Person/CreateDefaultByContactId

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId
```

Creates a PersonEntity with default values based on the contactId.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/CreateDefaultByContactId?$select=name,department,category/id
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

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |


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
POST /api/v1/Agents/Person/CreateDefaultByContactId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 930
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 987,
  "Firstname": "Alana",
  "MiddleName": "Gislason-Bauch",
  "Lastname": "Hauck",
  "Mrmrs": "qui",
  "Title": "debitis",
  "UpdatedDate": "2003-04-08T16:48:30.1659354+02:00",
  "CreatedDate": "2015-09-12T16:48:30.1659354+02:00",
  "BirthDate": "2002-06-29T16:48:30.1659354+02:00",
  "CreatedBy": {
    "AssociateId": 851,
    "Name": "Schiller Inc and Sons",
    "PersonId": 44,
    "Rank": 368,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 728,
    "FullName": "Cora Muller",
    "FormalName": "Osinski, Littel and Mayert",
    "Deleted": false,
    "EjUserId": 101,
    "UserName": "Langosh Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 555
      }
    }
  },
  "Emails": [
    {
      "Value": "rerum",
      "StrippedValue": "unde",
      "Description": "Monitored transitional data-warehouse",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "unde",
      "Description": "Monitored transitional data-warehouse",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 871
        }
      }
    }
  ],
  "Description": "Ameliorated systemic initiative",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "ut",
      "Description": "Balanced fresh-thinking middleware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "ut",
      "Description": "Balanced fresh-thinking middleware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 238
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "magni",
      "StrippedValue": "id",
      "Description": "Synchronised clear-thinking throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "deliver leading-edge eyeballs"
          },
          "FieldType": "System.Int32",
          "FieldLength": 369
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "id",
      "Description": "Synchronised clear-thinking throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "deliver leading-edge eyeballs"
          },
          "FieldType": "System.Int32",
          "FieldLength": 369
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "at",
      "StrippedValue": "dolor",
      "Description": "Progressive intermediate productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 17
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "dolor",
      "Description": "Progressive intermediate productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 17
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quis",
      "StrippedValue": "eos",
      "Description": "Polarised mission-critical initiative",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 131
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "eos",
      "Description": "Polarised mission-critical initiative",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 131
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "impedit",
      "Description": "Cloned explicit framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "impedit",
      "Description": "Cloned explicit framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 18
        }
      }
    }
  ],
  "Position": {
    "Id": 980,
    "Value": "natus",
    "Tooltip": "magnam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 951
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 854,
    "Name": "McGlynn Group",
    "PersonId": 876,
    "Rank": 647,
    "Tooltip": "molestias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 630,
    "FullName": "Annette Ankunding",
    "FormalName": "Fritsch, Terry and Robel",
    "Deleted": false,
    "EjUserId": 474,
    "UserName": "Fisher-Bashirian",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 308
      }
    }
  },
  "Contact": {
    "ContactId": 186,
    "Name": "Kub-Herzog",
    "OrgNr": "726807",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ad",
    "DirectPhone": "017.307.2758",
    "AssociateId": 966,
    "CountryId": 298,
    "EmailAddress": "dena@jacobireilly.co.uk",
    "Kananame": "illum",
    "EmailAddressName": "laury_mante@rutherfordbahringer.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Raoul Haley",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ut",
    "FullName": "Rosetta Lueilwitz",
    "IsOwnerContact": true,
    "ActiveErpLinks": 38,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 719
      }
    }
  },
  "Country": {
    "CountryId": 381,
    "Name": "Heaney Group",
    "CurrencyId": 271,
    "EnglishName": "Stark Group",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Synergized neutral open system",
    "OrgNrText": "1161203",
    "InterAreaPrefix": "nemo",
    "DialInPrefix": "reiciendis",
    "ZipPrefix": "fugiat",
    "DomainName": "Gutmann, Schmeler and Nader",
    "AddressLayoutId": 355,
    "DomesticAddressLayoutId": 759,
    "ForeignAddressLayoutId": 446,
    "Rank": 405,
    "Tooltip": "ut",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 972
      }
    }
  },
  "Interests": [
    {
      "Id": 218,
      "Name": "Fahey, Marquardt and Kutch",
      "ToolTip": "Est est itaque laborum sint beatae.",
      "Deleted": true,
      "Rank": 417,
      "Type": "et",
      "ColorBlock": 62,
      "IconHint": "unde",
      "Selected": true,
      "LastChanged": "2009-12-12T16:48:30.1679352+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "magni",
      "Hidden": false,
      "FullName": "Stefan Klocko",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 380
        }
      }
    }
  ],
  "PersonNumber": "945553",
  "FullName": "Aliyah Jacobson",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "eos",
      "StrippedValue": "iusto",
      "Description": "Progressive directional website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 538
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "iusto",
      "Description": "Progressive directional website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 538
        }
      }
    }
  ],
  "FormalName": "Block, Luettgen and Nicolas",
  "Address": {
    "Wgs84Latitude": 14012.114,
    "Wgs84Longitude": 7455.786,
    "LocalizedAddress": [
      [
        {
          "Name": "Pagac-Will",
          "Value": "enim",
          "Tooltip": "in",
          "Label": "cumque",
          "ValueLength": 436,
          "AddressType": "repellendus",
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
      ],
      [
        {
          "Name": "Hirthe, Lowe and Kirlin",
          "Value": "voluptas",
          "Tooltip": "illo",
          "Label": "et",
          "ValueLength": 594,
          "AddressType": "ipsum",
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
              "FieldLength": 91
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "modi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 980
      }
    }
  },
  "Post3": "temporibus",
  "Post2": "culpa",
  "Post1": "sequi",
  "Kanalname": "architecto",
  "Kanafname": "repudiandae",
  "CorrespondingAssociate": {
    "AssociateId": 72,
    "Name": "Zboncak, Collins and Bruen",
    "PersonId": 633,
    "Rank": 259,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 402,
    "FullName": "Liana Runte",
    "FormalName": "Powlowski Inc and Sons",
    "Deleted": true,
    "EjUserId": 829,
    "UserName": "Moore-Waters",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 56
      }
    }
  },
  "Category": {
    "Id": 275,
    "Value": "qui",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 947
      }
    }
  },
  "Business": {
    "Id": 118,
    "Value": "recusandae",
    "Tooltip": "perspiciatis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 933
      }
    }
  },
  "Associate": {
    "AssociateId": 580,
    "Name": "Dach-Cremin",
    "PersonId": 560,
    "Rank": 279,
    "Tooltip": "eos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 26,
    "FullName": "Britney Bahringer",
    "FormalName": "Kerluke-Beer",
    "Deleted": true,
    "EjUserId": 785,
    "UserName": "Reynolds-Nienow",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 824
      }
    }
  },
  "Salutation": "quisquam",
  "ActiveInterests": 383,
  "SupportAssociate": {
    "AssociateId": 438,
    "Name": "Pollich Group",
    "PersonId": 568,
    "Rank": 735,
    "Tooltip": "fugit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 122,
    "FullName": "Eloisa Labadie",
    "FormalName": "Wolff-Koepp",
    "Deleted": true,
    "EjUserId": 809,
    "UserName": "Kling LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 304
      }
    }
  },
  "TicketPriority": {
    "Id": 634,
    "Value": "ea",
    "Tooltip": "eius",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 458
      }
    }
  },
  "CustomerLanguage": {
    "Id": 426,
    "Value": "suscipit",
    "Tooltip": "sunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 175
      }
    }
  },
  "DbiAgentId": 239,
  "DbiKey": "corporis",
  "DbiLastModified": "2015-01-22T16:48:30.1709348+01:00",
  "DbiLastSyncronized": "2016-04-20T16:48:30.1709348+02:00",
  "SentInfo": 200,
  "ShowContactTickets": 310,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 17,
    "UserName": "Gislason, Torp and Larkin",
    "PersonId": 99,
    "Rank": 510,
    "Tooltip": "recusandae",
    "UserGroupId": 442,
    "EjUserId": 492,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "temporibus",
      "facere"
    ],
    "CanLogon": true,
    "RoleName": "Anderson Inc and Sons",
    "RoleTooltip": "ut",
    "UserGroupName": "Skiles, Daniel and Roberts",
    "UserGroupTooltip": "enim",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 207
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Focused local support",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptas",
      "Description": "Focused local support",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "magni",
      "StrippedValue": "molestias",
      "Description": "Monitored mission-critical knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "reinvent e-business networks"
          },
          "FieldType": "System.String",
          "FieldLength": 6
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "molestias",
      "Description": "Monitored mission-critical knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "reinvent e-business networks"
          },
          "FieldType": "System.String",
          "FieldLength": 6
        }
      }
    }
  ],
  "Source": 433,
  "ActiveErpLinks": 712,
  "ShipmentTypes": [
    {
      "Id": 775,
      "Name": "Dietrich LLC",
      "ToolTip": "Voluptas quis consequatur eaque voluptatum.",
      "Deleted": true,
      "Rank": 462,
      "Type": "consequuntur",
      "ColorBlock": 147,
      "IconHint": "natus",
      "Selected": false,
      "LastChanged": "1994-12-25T16:48:30.1719357+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Darlene Wisoky",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 537
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 839,
      "Comment": "eos",
      "Registered": "2017-08-07T16:48:30.1719357+02:00",
      "RegisteredAssociateId": 719,
      "Updated": "2004-01-01T16:48:30.1719357+01:00",
      "UpdatedAssociateId": 805,
      "LegalBaseId": 110,
      "LegalBaseKey": "nulla",
      "LegalBaseName": "Kohler Group",
      "ConsentPurposeId": 188,
      "ConsentPurposeKey": "optio",
      "ConsentPurposeName": "Bauch Group",
      "ConsentSourceId": 268,
      "ConsentSourceKey": "quae",
      "ConsentSourceName": "Lowe, Lesch and O'Connell",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 362
        }
      }
    }
  ],
  "BounceEmails": [
    "jed@weimann.ca",
    "zakary.padberg@kuhlman.name"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "1154386170"
  },
  "ExtraFields": {
    "ExtraFields1": "reiciendis",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "enim"
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
      "FieldLength": 162
    }
  }
}
```