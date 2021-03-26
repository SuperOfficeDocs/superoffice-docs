---
title: GET Person/default
id: v1PersonEntity_DefaultPersonEntity
---

# GET Person/default

```http
GET /api/v1/Person/default
```

Set default values into a new PersonEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Person agent service CreateDefaultPersonEntity.






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
GET /api/v1/Person/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 12 Jun 2002 09:40:59 G6T

{
  "PersonId": 171,
  "Firstname": "Lizeth",
  "MiddleName": "Treutel Group",
  "Lastname": "Howell",
  "Mrmrs": "corporis",
  "Title": "at",
  "UpdatedDate": "2002-06-12T09:40:59.2576662+02:00",
  "CreatedDate": "2016-03-20T09:40:59.2576662+01:00",
  "BirthDate": "2011-10-12T09:40:59.2576662+02:00",
  "CreatedBy": {
    "AssociateId": 780,
    "Name": "Metz, McDermott and Ryan",
    "PersonId": 451,
    "Rank": 643,
    "Tooltip": "at",
    "Type": "AnonymousAssociate",
    "GroupIdx": 207,
    "FullName": "Keven Boyer IV",
    "FormalName": "Lindgren-Yost",
    "Deleted": true,
    "EjUserId": 840,
    "UserName": "Mertz LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 964
      }
    }
  },
  "Emails": [
    {
      "Value": "dignissimos",
      "StrippedValue": "quo",
      "Description": "User-friendly attitude-oriented workforce",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    },
    {
      "Value": "dignissimos",
      "StrippedValue": "quo",
      "Description": "User-friendly attitude-oriented workforce",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    }
  ],
  "Description": "User-centric reciprocal attitude",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "autem",
      "StrippedValue": "facere",
      "Description": "Focused discrete software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 198
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "facere",
      "Description": "Focused discrete software",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 198
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempora",
      "StrippedValue": "ullam",
      "Description": "Focused client-driven product",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "ullam",
      "Description": "Focused client-driven product",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolore",
      "StrippedValue": "sunt",
      "Description": "Face to face methodical emulation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 721
        }
      }
    },
    {
      "Value": "dolore",
      "StrippedValue": "sunt",
      "Description": "Face to face methodical emulation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 721
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "minima",
      "StrippedValue": "ducimus",
      "Description": "Programmable neutral moratorium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 971
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "ducimus",
      "Description": "Programmable neutral moratorium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 971
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "possimus",
      "StrippedValue": "harum",
      "Description": "Profit-focused system-worthy challenge",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 866
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "harum",
      "Description": "Profit-focused system-worthy challenge",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 866
        }
      }
    }
  ],
  "Position": {
    "Id": 400,
    "Value": "laborum",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 119
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 825,
    "Name": "Muller-Murray",
    "PersonId": 906,
    "Rank": 476,
    "Tooltip": "molestias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 819,
    "FullName": "Annamarie Gutkowski",
    "FormalName": "Kris Inc and Sons",
    "Deleted": false,
    "EjUserId": 651,
    "UserName": "Jakubowski, Bashirian and Thompson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 882
      }
    }
  },
  "Contact": {
    "ContactId": 31,
    "Name": "Wilkinson, Wiza and O'Keefe",
    "OrgNr": "749569",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ad",
    "DirectPhone": "1-161-050-4370",
    "AssociateId": 767,
    "CountryId": 133,
    "EmailAddress": "tierra@gulgowskicruickshank.co.uk",
    "Kananame": "quasi",
    "EmailAddressName": "stephanie@kiehn.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Mr. Bret Baumbach",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "aut",
    "FullName": "Carlo Okuneva DVM",
    "IsOwnerContact": false,
    "ActiveErpLinks": 378,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 998
      }
    }
  },
  "Country": {
    "CountryId": 935,
    "Name": "Gislason, Prohaska and Lehner",
    "CurrencyId": 48,
    "EnglishName": "Jones Group",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Inverse cohesive concept",
    "OrgNrText": "1173534",
    "InterAreaPrefix": "qui",
    "DialInPrefix": "aut",
    "ZipPrefix": "enim",
    "DomainName": "Romaguera Inc and Sons",
    "AddressLayoutId": 885,
    "DomesticAddressLayoutId": 925,
    "ForeignAddressLayoutId": 267,
    "Rank": 268,
    "Tooltip": "cupiditate",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "embrace mission-critical web services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 183
      }
    }
  },
  "Interests": [
    {
      "Id": 317,
      "Name": "Beer Group",
      "ToolTip": "Sit reprehenderit soluta consequatur modi quam.",
      "Deleted": true,
      "Rank": 47,
      "Type": "voluptatem",
      "ColorBlock": 816,
      "IconHint": "optio",
      "Selected": true,
      "LastChanged": "2007-08-20T09:40:59.2596643+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "dolor",
      "Hidden": false,
      "FullName": "Aracely Quitzon",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 273
        }
      }
    }
  ],
  "PersonNumber": "1010846",
  "FullName": "Astrid Waelchi",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "ipsa",
      "Description": "Switchable context-sensitive info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 504
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "ipsa",
      "Description": "Switchable context-sensitive info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 504
        }
      }
    }
  ],
  "FormalName": "Schaefer-Robel",
  "Address": {
    "Wgs84Latitude": 25072.0,
    "Wgs84Longitude": 16838.982,
    "LocalizedAddress": [
      [
        {
          "Name": "Gottlieb, Aufderhar and Schowalter",
          "Value": "nobis",
          "Tooltip": "non",
          "Label": "ratione",
          "ValueLength": 758,
          "AddressType": "nam",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "maximize seamless initiatives"
              },
              "FieldType": "System.String",
              "FieldLength": 226
            }
          }
        }
      ],
      [
        {
          "Name": "Murphy, Johns and O'Hara",
          "Value": "est",
          "Tooltip": "ut",
          "Label": "quisquam",
          "ValueLength": 749,
          "AddressType": "suscipit",
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
              "FieldLength": 583
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "iste",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 758
      }
    }
  },
  "Post3": "odio",
  "Post2": "reprehenderit",
  "Post1": "qui",
  "Kanalname": "soluta",
  "Kanafname": "ut",
  "CorrespondingAssociate": {
    "AssociateId": 392,
    "Name": "Klein-Jerde",
    "PersonId": 901,
    "Rank": 362,
    "Tooltip": "nam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 752,
    "FullName": "Roel Friesen",
    "FormalName": "Hane, Conn and Howell",
    "Deleted": false,
    "EjUserId": 872,
    "UserName": "Feest, Cruickshank and Kemmer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 254
      }
    }
  },
  "Category": {
    "Id": 842,
    "Value": "culpa",
    "Tooltip": "deleniti",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 393
      }
    }
  },
  "Business": {
    "Id": 15,
    "Value": "soluta",
    "Tooltip": "ullam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 251
      }
    }
  },
  "Associate": {
    "AssociateId": 429,
    "Name": "Luettgen Inc and Sons",
    "PersonId": 46,
    "Rank": 754,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 112,
    "FullName": "Velda Luettgen III",
    "FormalName": "Brekke-Jerde",
    "Deleted": true,
    "EjUserId": 457,
    "UserName": "Bailey-Bartell",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 126
      }
    }
  },
  "Salutation": "repudiandae",
  "ActiveInterests": 244,
  "SupportAssociate": {
    "AssociateId": 371,
    "Name": "Reynolds Inc and Sons",
    "PersonId": 647,
    "Rank": 577,
    "Tooltip": "eligendi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 258,
    "FullName": "Avis Osinski",
    "FormalName": "Dibbert, Schoen and Kerluke",
    "Deleted": true,
    "EjUserId": 388,
    "UserName": "Larson Group",
    "TableRight": {},
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
  },
  "TicketPriority": {
    "Id": 398,
    "Value": "eum",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "mesh interactive e-business"
        },
        "FieldType": "System.Int32",
        "FieldLength": 751
      }
    }
  },
  "CustomerLanguage": {
    "Id": 913,
    "Value": "cupiditate",
    "Tooltip": "quidem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 354
      }
    }
  },
  "DbiAgentId": 85,
  "DbiKey": "et",
  "DbiLastModified": "2007-08-17T09:40:59.2616641+02:00",
  "DbiLastSyncronized": "2002-12-08T09:40:59.2616641+01:00",
  "SentInfo": 206,
  "ShowContactTickets": 852,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 485,
    "UserName": "Rowe-Metz",
    "PersonId": 422,
    "Rank": 181,
    "Tooltip": "et",
    "UserGroupId": 646,
    "EjUserId": 338,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "odit",
      "minima"
    ],
    "CanLogon": true,
    "RoleName": "Littel, Lowe and Lind",
    "RoleTooltip": "dolore",
    "UserGroupName": "Heathcote-Blick",
    "UserGroupTooltip": "enim",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 253
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "consequatur",
      "Description": "Implemented optimal capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 551
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "consequatur",
      "Description": "Implemented optimal capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 551
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "est",
      "StrippedValue": "perspiciatis",
      "Description": "Ergonomic modular infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 655
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "perspiciatis",
      "Description": "Ergonomic modular infrastructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 655
        }
      }
    }
  ],
  "Source": 311,
  "ActiveErpLinks": 620,
  "ShipmentTypes": [
    {
      "Id": 237,
      "Name": "Jerde, Leannon and Little",
      "ToolTip": "Iure tenetur aut dicta nihil est voluptatem.",
      "Deleted": true,
      "Rank": 907,
      "Type": "ut",
      "ColorBlock": 55,
      "IconHint": "officiis",
      "Selected": false,
      "LastChanged": "2014-04-09T09:40:59.2646645+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Elmer Shanahan",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 225
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 773,
      "Comment": "voluptatem",
      "Registered": "2004-01-15T09:40:59.2656644+01:00",
      "RegisteredAssociateId": 944,
      "Updated": "1999-08-23T09:40:59.2656644+02:00",
      "UpdatedAssociateId": 281,
      "LegalBaseId": 597,
      "LegalBaseKey": "nobis",
      "LegalBaseName": "Schuster Group",
      "ConsentPurposeId": 177,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Bernier Group",
      "ConsentSourceId": 438,
      "ConsentSourceKey": "voluptatibus",
      "ConsentSourceName": "Barton Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 650
        }
      }
    }
  ],
  "BounceEmails": [
    "vernice@russelbauch.biz",
    "diego_brown@medhurst.us"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Luther Lakin",
    "SuperOffice:2": "605144653"
  },
  "ExtraFields": {
    "ExtraFields1": "inventore",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "temporibus",
    "CustomFields2": "veniam"
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
      "FieldLength": 798
    }
  }
}
```