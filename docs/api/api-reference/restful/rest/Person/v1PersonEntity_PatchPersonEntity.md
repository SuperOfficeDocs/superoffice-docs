---
title: PATCH Person/{id}
id: v1PersonEntity_PatchPersonEntity
---

# PATCH Person/{id}

```http
PATCH /api/v1/Person/{id}
```

Update a PersonEntity with changes, as described in a JSON Patch or a JSON Merge Patch document.

See <a href="https://tools.ietf.org/html/rfc6902">RFC6902</a> and <a href="https://tools.ietf.org/html/rfc7386">RFC 7396</a>. Update the Department field to "foo" can be done either as a JSON PATCH:

```js

[ { "op": "replace", "path": "/Department", "value": "foo" } ]

```

or as a JSON MERGE PATCH, which describes the change directly:

```js

{ "Department": "foo" }

```



JSON PATCH supports operations 'add', 'replace', 'remove' and 'test'.
The path is case insensitive, and the leading slash is optional, so the paths "/department", "Department" and "department" are all equivalent.



Calls the {SuperOffice.CRM.Services.IPersonAgent} service SavePersonEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PersonEntity  id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PATCH /api/v1/Person/{id}?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body:  |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: changes string 

JSON-Patch array of operations+path+value, or a MERGE-PATCH object (which will be converted to a list of JSON-PATCH operations). 

| Property Name | Type |  Description |
|----------------|------|--------------|
| op | string | "add", "replace", "remove", "test" "move" and "copy" not supported |
| path | string | The property names to modify.  "/users/0/email", "/users/-", |
| value | object | New/Replaced value - string or object. |


## Response: object

The Person Service. The service implements all services working with the Person object.



PersonEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity  updated. |
| 404 | PersonEntity with given id does not exist in the db. |
| 409 | Update blocked because a 'test' operation has detected a conflict with the entity value. |
| 412 | Update aborted because PersonEntity has changed since the requested If-Unmodified-Since timestamp. |

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
PATCH /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "op": "add",
    "path": "dolorem",
    "value": {
      "value1": {
        "PrimaryKey": 1504,
        "EntityName": "sale",
        "saleId": 1504,
        "contactId": 165,
        "name": "Schuppe LLC"
      },
      "value2": {
        "PrimaryKey": 1444,
        "EntityName": "person",
        "personId": 1444,
        "fullName": "Florence Towne"
      }
    }
  },
  {
    "op": "add",
    "path": "dolorem",
    "value": {
      "value1": {
        "PrimaryKey": 1504,
        "EntityName": "sale",
        "saleId": 1504,
        "contactId": 165,
        "name": "Schuppe LLC"
      },
      "value2": {
        "PrimaryKey": 1444,
        "EntityName": "person",
        "personId": 1444,
        "fullName": "Florence Towne"
      }
    }
  }
]
```

```http_
HTTP/1.1 200 PersonEntity  updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 858,
  "Firstname": "Therese",
  "MiddleName": "Funk, Schiller and Cremin",
  "Lastname": "Willms",
  "Mrmrs": "aut",
  "Title": "similique",
  "UpdatedDate": "2020-09-20T18:25:50.7126202+02:00",
  "CreatedDate": "2001-05-31T18:25:50.7126202+02:00",
  "BirthDate": "2018-09-09T18:25:50.7126202+02:00",
  "CreatedBy": {
    "AssociateId": 298,
    "Name": "Ernser, Corkery and Legros",
    "PersonId": 90,
    "Rank": 184,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 976,
    "FullName": "Leila Abbott",
    "FormalName": "Nienow Group",
    "Deleted": true,
    "EjUserId": 748,
    "UserName": "Reichert-Ryan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 426
      }
    }
  },
  "Emails": [
    {
      "Value": "asperiores",
      "StrippedValue": "molestias",
      "Description": "Distributed directional internet solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "molestias",
      "Description": "Distributed directional internet solution",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    }
  ],
  "Description": "Function-based responsive matrix",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "vel",
      "StrippedValue": "minima",
      "Description": "Triple-buffered intermediate time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 299
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "minima",
      "Description": "Triple-buffered intermediate time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 299
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "occaecati",
      "Description": "Public-key value-added framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 328
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "occaecati",
      "Description": "Public-key value-added framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 328
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "molestias",
      "StrippedValue": "ut",
      "Description": "Phased analyzing projection",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 144
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "ut",
      "Description": "Phased analyzing projection",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 144
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "esse",
      "StrippedValue": "hic",
      "Description": "Vision-oriented systemic structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 249
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "hic",
      "Description": "Vision-oriented systemic structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 249
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "maiores",
      "StrippedValue": "id",
      "Description": "Intuitive national extranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 547
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "id",
      "Description": "Intuitive national extranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 547
        }
      }
    }
  ],
  "Position": {
    "Id": 983,
    "Value": "omnis",
    "Tooltip": "natus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 867
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 888,
    "Name": "Crist, Grant and Wolff",
    "PersonId": 127,
    "Rank": 732,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 509,
    "FullName": "Ewell Schaefer",
    "FormalName": "Prosacco-Willms",
    "Deleted": true,
    "EjUserId": 668,
    "UserName": "Beier LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 436
      }
    }
  },
  "Contact": {
    "ContactId": 57,
    "Name": "Jaskolski Inc and Sons",
    "OrgNr": "1358163",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ea",
    "DirectPhone": "(705)283-4425",
    "AssociateId": 638,
    "CountryId": 554,
    "EmailAddress": "sharon@wehnererdman.info",
    "Kananame": "rem",
    "EmailAddressName": "phoebe@lindgren.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Eleonore Boehm DDS",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "molestiae",
    "FullName": "Savanna Stracke",
    "IsOwnerContact": true,
    "ActiveErpLinks": 386,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 329
      }
    }
  },
  "Country": {
    "CountryId": 80,
    "Name": "Schmeler, Kutch and Barton",
    "CurrencyId": 527,
    "EnglishName": "Ziemann, Doyle and Heaney",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Fully-configurable tertiary algorithm",
    "OrgNrText": "160747",
    "InterAreaPrefix": "non",
    "DialInPrefix": "qui",
    "ZipPrefix": "neque",
    "DomainName": "Schaefer LLC",
    "AddressLayoutId": 126,
    "DomesticAddressLayoutId": 628,
    "ForeignAddressLayoutId": 12,
    "Rank": 739,
    "Tooltip": "quo",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 720
      }
    }
  },
  "Interests": [
    {
      "Id": 217,
      "Name": "Mann, Labadie and Auer",
      "ToolTip": "Ullam aut et sint.",
      "Deleted": false,
      "Rank": 493,
      "Type": "id",
      "ColorBlock": 297,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "2002-12-30T18:25:50.7156199+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rerum",
      "StyleHint": "reprehenderit",
      "Hidden": true,
      "FullName": "Jordan Wisozk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 203
        }
      }
    }
  ],
  "PersonNumber": "704719",
  "FullName": "Talon Harvey",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "eos",
      "StrippedValue": "ea",
      "Description": "Multi-tiered maximized benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "ea",
      "Description": "Multi-tiered maximized benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    }
  ],
  "FormalName": "Feeney, Schuster and Littel",
  "Address": {
    "Wgs84Latitude": 26128.158,
    "Wgs84Longitude": 7737.846,
    "LocalizedAddress": [
      [
        {
          "Name": "Dibbert-Bradtke",
          "Value": "sint",
          "Tooltip": "excepturi",
          "Label": "porro",
          "ValueLength": 159,
          "AddressType": "occaecati",
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
              "FieldLength": 909
            }
          }
        }
      ],
      [
        {
          "Name": "Marks LLC",
          "Value": "temporibus",
          "Tooltip": "laboriosam",
          "Label": "ipsum",
          "ValueLength": 707,
          "AddressType": "ut",
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
              "FieldLength": 461
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "corporis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 572
      }
    }
  },
  "Post3": "et",
  "Post2": "et",
  "Post1": "nemo",
  "Kanalname": "beatae",
  "Kanafname": "repudiandae",
  "CorrespondingAssociate": {
    "AssociateId": 240,
    "Name": "Nicolas LLC",
    "PersonId": 398,
    "Rank": 829,
    "Tooltip": "perspiciatis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 809,
    "FullName": "Miss Layla Hoppe",
    "FormalName": "Cruickshank Group",
    "Deleted": true,
    "EjUserId": 58,
    "UserName": "Nikolaus, Hahn and Russel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate B2C infomediaries"
        },
        "FieldType": "System.String",
        "FieldLength": 864
      }
    }
  },
  "Category": {
    "Id": 570,
    "Value": "aut",
    "Tooltip": "ut",
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
  "Business": {
    "Id": 977,
    "Value": "est",
    "Tooltip": "asperiores",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 585
      }
    }
  },
  "Associate": {
    "AssociateId": 617,
    "Name": "Hansen Inc and Sons",
    "PersonId": 26,
    "Rank": 398,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 598,
    "FullName": "Alfreda Leannon",
    "FormalName": "Roberts-Skiles",
    "Deleted": true,
    "EjUserId": 461,
    "UserName": "Will, Spinka and Schumm",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 82
      }
    }
  },
  "Salutation": "repudiandae",
  "ActiveInterests": 19,
  "SupportAssociate": {
    "AssociateId": 779,
    "Name": "Brekke-Leffler",
    "PersonId": 723,
    "Rank": 73,
    "Tooltip": "provident",
    "Type": "AnonymousAssociate",
    "GroupIdx": 601,
    "FullName": "Fredy Morissette",
    "FormalName": "Kautzer, Ebert and Balistreri",
    "Deleted": true,
    "EjUserId": 666,
    "UserName": "Koch, Romaguera and Balistreri",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 800
      }
    }
  },
  "TicketPriority": {
    "Id": 871,
    "Value": "et",
    "Tooltip": "assumenda",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 45
      }
    }
  },
  "CustomerLanguage": {
    "Id": 212,
    "Value": "et",
    "Tooltip": "hic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 539
      }
    }
  },
  "DbiAgentId": 591,
  "DbiKey": "dicta",
  "DbiLastModified": "2002-07-15T18:25:50.7176225+02:00",
  "DbiLastSyncronized": "2015-05-31T18:25:50.7176225+02:00",
  "SentInfo": 977,
  "ShowContactTickets": 630,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 938,
    "UserName": "Bahringer-Ledner",
    "PersonId": 34,
    "Rank": 658,
    "Tooltip": "enim",
    "UserGroupId": 925,
    "EjUserId": 654,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "rerum",
      "impedit"
    ],
    "CanLogon": true,
    "RoleName": "Abbott-Larson",
    "RoleTooltip": "quaerat",
    "UserGroupName": "Cronin Inc and Sons",
    "UserGroupTooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 164
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "sunt",
      "StrippedValue": "aut",
      "Description": "Managed even-keeled open architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 821
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "aut",
      "Description": "Managed even-keeled open architecture",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 821
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "enim",
      "Description": "Diverse tertiary leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 238
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "enim",
      "Description": "Diverse tertiary leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 238
        }
      }
    }
  ],
  "Source": 458,
  "ActiveErpLinks": 979,
  "ShipmentTypes": [
    {
      "Id": 704,
      "Name": "Hyatt, Adams and Hermiston",
      "ToolTip": "Quis totam error omnis.",
      "Deleted": true,
      "Rank": 341,
      "Type": "fugiat",
      "ColorBlock": 586,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "1999-05-22T18:25:50.7185956+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eum",
      "StyleHint": "repellat",
      "Hidden": false,
      "FullName": "Violette Nitzsche",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 843
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 409,
      "Comment": "laboriosam",
      "Registered": "2019-02-07T18:25:50.7185956+01:00",
      "RegisteredAssociateId": 517,
      "Updated": "1995-10-23T18:25:50.7185956+02:00",
      "UpdatedAssociateId": 685,
      "LegalBaseId": 162,
      "LegalBaseKey": "voluptatum",
      "LegalBaseName": "Mante-Gleason",
      "ConsentPurposeId": 643,
      "ConsentPurposeKey": "eos",
      "ConsentPurposeName": "Zieme Inc and Sons",
      "ConsentSourceId": 751,
      "ConsentSourceKey": "esse",
      "ConsentSourceName": "Corkery, Marquardt and Upton",
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
  "BounceEmails": [
    "jarret_vonrueden@prosaccoabernathy.biz",
    "gunner@quigleycollins.com"
  ],
  "ActiveStatusMonitorId": 483,
  "UserDefinedFields": {
    "SuperOffice:1": "1572258520",
    "SuperOffice:2": "Ms. Mckayla Skiles"
  },
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "et"
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
      "FieldLength": 645
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```