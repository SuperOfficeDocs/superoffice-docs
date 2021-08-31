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
GET /api/v1/Person/{id}?fk=True
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
Accept-Language: *
```

```http_
HTTP/1.1 200 PersonEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Sat, 23 Oct 2010 15:05:42 G10T

{
  "PersonId": 683,
  "Firstname": "Justyn",
  "MiddleName": "Gottlieb-Batz",
  "Lastname": "Vandervort",
  "Mrmrs": "error",
  "Title": "fuga",
  "UpdatedDate": "2010-10-23T15:05:42.3076687+02:00",
  "CreatedDate": "1996-12-11T15:05:42.3076687+01:00",
  "BirthDate": "2011-01-23T15:05:42.3076687+01:00",
  "CreatedBy": {
    "AssociateId": 606,
    "Name": "Emard, Bartell and Nolan",
    "PersonId": 598,
    "Rank": 484,
    "Tooltip": "exercitationem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 224,
    "FullName": "Camryn Mitchell",
    "FormalName": "Aufderhar, Yost and Sporer",
    "Deleted": true,
    "EjUserId": 428,
    "UserName": "Fadel, Rolfson and Hyatt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 205
      }
    }
  },
  "Emails": [
    {
      "Value": "enim",
      "StrippedValue": "consequatur",
      "Description": "Compatible multi-tasking initiative",
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
    },
    {
      "Value": "enim",
      "StrippedValue": "consequatur",
      "Description": "Compatible multi-tasking initiative",
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
  "Description": "Seamless tangible groupware",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "rerum",
      "Description": "Front-line grid-enabled intranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "rerum",
      "Description": "Front-line grid-enabled intranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 478
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vel",
      "StrippedValue": "illum",
      "Description": "Networked composite conglomeration",
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
    {
      "Value": "vel",
      "StrippedValue": "illum",
      "Description": "Networked composite conglomeration",
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
    }
  ],
  "MobilePhones": [
    {
      "Value": "similique",
      "StrippedValue": "aut",
      "Description": "Cloned grid-enabled leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 387
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "aut",
      "Description": "Cloned grid-enabled leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 387
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "corporis",
      "StrippedValue": "et",
      "Description": "Optimized analyzing pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "et",
      "Description": "Optimized analyzing pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 265
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "architecto",
      "StrippedValue": "molestias",
      "Description": "Right-sized transitional challenge",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 400
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "molestias",
      "Description": "Right-sized transitional challenge",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 400
        }
      }
    }
  ],
  "Position": {
    "Id": 237,
    "Value": "ipsa",
    "Tooltip": "adipisci",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "syndicate granular e-markets"
        },
        "FieldType": "System.String",
        "FieldLength": 206
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 543,
    "Name": "Parker, Marvin and Ondricka",
    "PersonId": 140,
    "Rank": 523,
    "Tooltip": "assumenda",
    "Type": "AnonymousAssociate",
    "GroupIdx": 594,
    "FullName": "Hank Ziemann",
    "FormalName": "Pacocha-Pagac",
    "Deleted": true,
    "EjUserId": 931,
    "UserName": "Beahan, Kertzmann and Bergstrom",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 882
      }
    }
  },
  "Contact": {
    "ContactId": 399,
    "Name": "Rath, Ryan and Ondricka",
    "OrgNr": "1556005",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "beatae",
    "DirectPhone": "1-430-250-7081",
    "AssociateId": 786,
    "CountryId": 433,
    "EmailAddress": "afton_altenwerth@brakus.name",
    "Kananame": "occaecati",
    "EmailAddressName": "bradford@bednar.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kamren Johnson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "deserunt",
    "FullName": "Peggie Kulas",
    "IsOwnerContact": false,
    "ActiveErpLinks": 792,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 780
      }
    }
  },
  "Country": {
    "CountryId": 158,
    "Name": "Moore, Klein and Tillman",
    "CurrencyId": 761,
    "EnglishName": "Pacocha, Rath and Koss",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Sharable bandwidth-monitored migration",
    "OrgNrText": "1162170",
    "InterAreaPrefix": "veritatis",
    "DialInPrefix": "omnis",
    "ZipPrefix": "voluptas",
    "DomainName": "Sauer-Smith",
    "AddressLayoutId": 839,
    "DomesticAddressLayoutId": 482,
    "ForeignAddressLayoutId": 224,
    "Rank": 179,
    "Tooltip": "consequatur",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 364
      }
    }
  },
  "Interests": [
    {
      "Id": 580,
      "Name": "Robel-D'Amore",
      "ToolTip": "Itaque qui dolorem hic magni.",
      "Deleted": true,
      "Rank": 718,
      "Type": "ipsam",
      "ColorBlock": 877,
      "IconHint": "incidunt",
      "Selected": true,
      "LastChanged": "2020-12-02T15:05:42.3106672+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "impedit",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Kaitlyn Schultz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 961
        }
      }
    }
  ],
  "PersonNumber": "796146",
  "FullName": "Lavon Kirlin",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "aliquam",
      "StrippedValue": "fugiat",
      "Description": "Reactive explicit process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 640
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "fugiat",
      "Description": "Reactive explicit process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 640
        }
      }
    }
  ],
  "FormalName": "Okuneva Inc and Sons",
  "Address": {
    "Wgs84Latitude": 30694.396,
    "Wgs84Longitude": 20543.37,
    "LocalizedAddress": [
      [
        {
          "Name": "Rice, Casper and Runolfsson",
          "Value": "quia",
          "Tooltip": "atque",
          "Label": "ipsum",
          "ValueLength": 388,
          "AddressType": "amet",
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
              "FieldLength": 80
            }
          }
        }
      ],
      [
        {
          "Name": "Bogan, Bergnaum and Bernier",
          "Value": "rerum",
          "Tooltip": "tenetur",
          "Label": "impedit",
          "ValueLength": 119,
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
              "FieldLength": 640
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "dolorem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "streamline back-end methodologies"
        },
        "FieldType": "System.String",
        "FieldLength": 227
      }
    }
  },
  "Post3": "accusamus",
  "Post2": "ut",
  "Post1": "itaque",
  "Kanalname": "similique",
  "Kanafname": "nam",
  "CorrespondingAssociate": {
    "AssociateId": 878,
    "Name": "Ward Inc and Sons",
    "PersonId": 870,
    "Rank": 777,
    "Tooltip": "officiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 271,
    "FullName": "Pietro Prosacco I",
    "FormalName": "Volkman Inc and Sons",
    "Deleted": false,
    "EjUserId": 947,
    "UserName": "Lesch Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 341
      }
    }
  },
  "Category": {
    "Id": 480,
    "Value": "libero",
    "Tooltip": "odio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 321
      }
    }
  },
  "Business": {
    "Id": 512,
    "Value": "distinctio",
    "Tooltip": "commodi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 493
      }
    }
  },
  "Associate": {
    "AssociateId": 6,
    "Name": "Cummings-Ankunding",
    "PersonId": 46,
    "Rank": 719,
    "Tooltip": "repellendus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 614,
    "FullName": "Leonora Franecki Jr.",
    "FormalName": "Leffler-Grimes",
    "Deleted": false,
    "EjUserId": 207,
    "UserName": "Simonis Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 680
      }
    }
  },
  "Salutation": "deserunt",
  "ActiveInterests": 204,
  "SupportAssociate": {
    "AssociateId": 583,
    "Name": "Swift-Miller",
    "PersonId": 388,
    "Rank": 896,
    "Tooltip": "ipsum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 840,
    "FullName": "Isac O'Hara",
    "FormalName": "Pollich, Walsh and Quigley",
    "Deleted": true,
    "EjUserId": 156,
    "UserName": "Sanford Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 663
      }
    }
  },
  "TicketPriority": {
    "Id": 181,
    "Value": "sint",
    "Tooltip": "consequatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engage vertical synergies"
        },
        "FieldType": "System.Int32",
        "FieldLength": 13
      }
    }
  },
  "CustomerLanguage": {
    "Id": 863,
    "Value": "necessitatibus",
    "Tooltip": "fugiat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 180
      }
    }
  },
  "DbiAgentId": 55,
  "DbiKey": "est",
  "DbiLastModified": "2016-07-19T15:05:42.3126677+02:00",
  "DbiLastSyncronized": "2010-04-11T15:05:42.3126677+02:00",
  "SentInfo": 576,
  "ShowContactTickets": 292,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 515,
    "UserName": "Johns, Cartwright and Reilly",
    "PersonId": 717,
    "Rank": 618,
    "Tooltip": "nisi",
    "UserGroupId": 474,
    "EjUserId": 964,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "qui",
      "tempore"
    ],
    "CanLogon": false,
    "RoleName": "Aufderhar-Jenkins",
    "RoleTooltip": "ut",
    "UserGroupName": "Douglas, Ritchie and Kshlerin",
    "UserGroupTooltip": "quae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 415
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "nesciunt",
      "StrippedValue": "quasi",
      "Description": "Streamlined tangible budgetary management",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "quasi",
      "Description": "Streamlined tangible budgetary management",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 490
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nostrum",
      "StrippedValue": "aut",
      "Description": "Function-based bi-directional analyzer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 880
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "aut",
      "Description": "Function-based bi-directional analyzer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 880
        }
      }
    }
  ],
  "Source": 7,
  "ActiveErpLinks": 280,
  "ShipmentTypes": [
    {
      "Id": 241,
      "Name": "Homenick Inc and Sons",
      "ToolTip": "Sunt eos velit occaecati unde.",
      "Deleted": false,
      "Rank": 910,
      "Type": "animi",
      "ColorBlock": 842,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2017-11-21T15:05:42.3126677+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "maxime",
      "StyleHint": "voluptates",
      "Hidden": true,
      "FullName": "Prince Veum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 860
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 923,
      "Comment": "magnam",
      "Registered": "1998-12-13T15:05:42.3136671+01:00",
      "RegisteredAssociateId": 616,
      "Updated": "2007-10-10T15:05:42.3136671+02:00",
      "UpdatedAssociateId": 896,
      "LegalBaseId": 832,
      "LegalBaseKey": "voluptas",
      "LegalBaseName": "Weber Group",
      "ConsentPurposeId": 830,
      "ConsentPurposeKey": "consequuntur",
      "ConsentPurposeName": "Ebert-Paucek",
      "ConsentSourceId": 753,
      "ConsentSourceKey": "quod",
      "ConsentSourceName": "Lehner Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 789
        }
      }
    }
  ],
  "BounceEmails": [
    "birdie_mcglynn@murray.info",
    "elijah@runtekemmer.name"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Juliana D'Amore MD",
    "SuperOffice:2": "1143476876"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "porro",
    "CustomFields2": "corporis"
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
      "FieldLength": 107
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```