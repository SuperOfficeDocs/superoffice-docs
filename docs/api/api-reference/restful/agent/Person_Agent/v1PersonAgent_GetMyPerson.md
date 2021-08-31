---
title: GetMyPerson
id: v1PersonAgent_GetMyPerson
---

# GetMyPerson

```http
POST /api/v1/Agents/Person/GetMyPerson
```

Gets the person info belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetMyPerson?$select=name,department,category/id
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
POST /api/v1/Agents/Person/GetMyPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 551,
  "Firstname": "Thad",
  "MiddleName": "Gulgowski-Hamill",
  "Lastname": "Block",
  "Mrmrs": "asperiores",
  "Title": "repellendus",
  "UpdatedDate": "2017-07-05T14:58:04.6824599+02:00",
  "CreatedDate": "2006-05-30T14:58:04.6824599+02:00",
  "BirthDate": "1994-05-13T14:58:04.6824599+02:00",
  "CreatedBy": {
    "AssociateId": 349,
    "Name": "Osinski-Wisoky",
    "PersonId": 15,
    "Rank": 722,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 642,
    "FullName": "Cooper Casper",
    "FormalName": "Marquardt LLC",
    "Deleted": false,
    "EjUserId": 211,
    "UserName": "Eichmann Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 555
      }
    }
  },
  "Emails": [
    {
      "Value": "eum",
      "StrippedValue": "tempore",
      "Description": "Assimilated clear-thinking orchestration",
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
      "Value": "eum",
      "StrippedValue": "tempore",
      "Description": "Assimilated clear-thinking orchestration",
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
  "Description": "Balanced zero administration utilisation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "cumque",
      "StrippedValue": "minima",
      "Description": "Total asynchronous complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 39
        }
      }
    },
    {
      "Value": "cumque",
      "StrippedValue": "minima",
      "Description": "Total asynchronous complexity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 39
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "asperiores",
      "StrippedValue": "qui",
      "Description": "Optimized 24 hour system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    },
    {
      "Value": "asperiores",
      "StrippedValue": "qui",
      "Description": "Optimized 24 hour system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 319
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sed",
      "StrippedValue": "et",
      "Description": "Cross-platform multi-state core",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "et",
      "Description": "Cross-platform multi-state core",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 231
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "itaque",
      "StrippedValue": "corrupti",
      "Description": "Down-sized static hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "corrupti",
      "Description": "Down-sized static hub",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 106
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "officia",
      "StrippedValue": "quod",
      "Description": "Function-based dedicated intranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 295
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "quod",
      "Description": "Function-based dedicated intranet",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 295
        }
      }
    }
  ],
  "Position": {
    "Id": 961,
    "Value": "odit",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 183
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 196,
    "Name": "Heidenreich LLC",
    "PersonId": 407,
    "Rank": 989,
    "Tooltip": "quibusdam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 954,
    "FullName": "Dr. Timmothy Smitham",
    "FormalName": "Tillman Inc and Sons",
    "Deleted": true,
    "EjUserId": 332,
    "UserName": "Kris, Gaylord and Kessler",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 401
      }
    }
  },
  "Contact": {
    "ContactId": 383,
    "Name": "Swift-Kulas",
    "OrgNr": "1339612",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "233-160-5320",
    "AssociateId": 918,
    "CountryId": 909,
    "EmailAddress": "norberto_ebert@price.biz",
    "Kananame": "molestiae",
    "EmailAddressName": "marielle.effertz@grahamkovacek.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Daphne Nitzsche",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ab",
    "FullName": "Paxton Rippin",
    "IsOwnerContact": true,
    "ActiveErpLinks": 834,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 484
      }
    }
  },
  "Country": {
    "CountryId": 475,
    "Name": "Brown-Vandervort",
    "CurrencyId": 607,
    "EnglishName": "Lakin, Witting and Hoeger",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Phased 3rd generation support",
    "OrgNrText": "1258961",
    "InterAreaPrefix": "illum",
    "DialInPrefix": "magni",
    "ZipPrefix": "ipsam",
    "DomainName": "Pagac, Goyette and Schowalter",
    "AddressLayoutId": 534,
    "DomesticAddressLayoutId": 219,
    "ForeignAddressLayoutId": 42,
    "Rank": 964,
    "Tooltip": "possimus",
    "Deleted": true,
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
  "Interests": [
    {
      "Id": 911,
      "Name": "Little Group",
      "ToolTip": "Non a nulla eaque molestiae qui.",
      "Deleted": true,
      "Rank": 283,
      "Type": "voluptate",
      "ColorBlock": 682,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2008-02-19T14:58:04.6854603+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "vel",
      "Hidden": true,
      "FullName": "Karolann Gerhold",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 430
        }
      }
    }
  ],
  "PersonNumber": "947469",
  "FullName": "Michele Mitchell",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "fugiat",
      "StrippedValue": "aut",
      "Description": "Integrated zero administration pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "aut",
      "Description": "Integrated zero administration pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 191
        }
      }
    }
  ],
  "FormalName": "Stamm LLC",
  "Address": {
    "Wgs84Latitude": 12849.4,
    "Wgs84Longitude": 22267.07,
    "LocalizedAddress": [
      [
        {
          "Name": "Dach, Greenholt and Collier",
          "Value": "cumque",
          "Tooltip": "repellendus",
          "Label": "quo",
          "ValueLength": 604,
          "AddressType": "itaque",
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
              "FieldLength": 464
            }
          }
        }
      ],
      [
        {
          "Name": "Will, Johnson and Yundt",
          "Value": "necessitatibus",
          "Tooltip": "hic",
          "Label": "veritatis",
          "ValueLength": 584,
          "AddressType": "doloremque",
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
              "FieldLength": 906
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 677
      }
    }
  },
  "Post3": "dolor",
  "Post2": "et",
  "Post1": "deleniti",
  "Kanalname": "ipsam",
  "Kanafname": "ducimus",
  "CorrespondingAssociate": {
    "AssociateId": 756,
    "Name": "Davis-Thiel",
    "PersonId": 245,
    "Rank": 699,
    "Tooltip": "tempore",
    "Type": "AnonymousAssociate",
    "GroupIdx": 599,
    "FullName": "Kiana Bode I",
    "FormalName": "Nikolaus, Lowe and Daugherty",
    "Deleted": true,
    "EjUserId": 132,
    "UserName": "Kunze-Reichel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 323
      }
    }
  },
  "Category": {
    "Id": 334,
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
        "FieldLength": 539
      }
    }
  },
  "Business": {
    "Id": 256,
    "Value": "distinctio",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 545
      }
    }
  },
  "Associate": {
    "AssociateId": 801,
    "Name": "Kessler, Sporer and Hessel",
    "PersonId": 930,
    "Rank": 905,
    "Tooltip": "sit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 256,
    "FullName": "Santino Smith",
    "FormalName": "Hintz LLC",
    "Deleted": true,
    "EjUserId": 141,
    "UserName": "Stroman Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 387
      }
    }
  },
  "Salutation": "sint",
  "ActiveInterests": 344,
  "SupportAssociate": {
    "AssociateId": 548,
    "Name": "Runolfsson-Morissette",
    "PersonId": 770,
    "Rank": 245,
    "Tooltip": "debitis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 188,
    "FullName": "Laverna Barton",
    "FormalName": "Hermann, Reilly and Thiel",
    "Deleted": true,
    "EjUserId": 442,
    "UserName": "Hilll-Cummings",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 677
      }
    }
  },
  "TicketPriority": {
    "Id": 109,
    "Value": "modi",
    "Tooltip": "reiciendis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 474
      }
    }
  },
  "CustomerLanguage": {
    "Id": 677,
    "Value": "ipsa",
    "Tooltip": "deserunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 939
      }
    }
  },
  "DbiAgentId": 487,
  "DbiKey": "fugiat",
  "DbiLastModified": "1998-12-12T14:58:04.6874625+01:00",
  "DbiLastSyncronized": "2014-02-06T14:58:04.6874625+01:00",
  "SentInfo": 497,
  "ShowContactTickets": 360,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 835,
    "UserName": "Wiza, Hodkiewicz and Mitchell",
    "PersonId": 174,
    "Rank": 611,
    "Tooltip": "dolores",
    "UserGroupId": 339,
    "EjUserId": 660,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "repellat",
      "ratione"
    ],
    "CanLogon": true,
    "RoleName": "Feil, Skiles and Grady",
    "RoleTooltip": "quibusdam",
    "UserGroupName": "Ferry, Swift and Brekke",
    "UserGroupTooltip": "nulla",
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
  "ChatEmails": [
    {
      "Value": "qui",
      "StrippedValue": "repudiandae",
      "Description": "Compatible analyzing extranet",
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
    {
      "Value": "qui",
      "StrippedValue": "repudiandae",
      "Description": "Compatible analyzing extranet",
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
    }
  ],
  "InternetPhones": [
    {
      "Value": "quae",
      "StrippedValue": "atque",
      "Description": "Face to face needs-based help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 717
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "atque",
      "Description": "Face to face needs-based help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 717
        }
      }
    }
  ],
  "Source": 987,
  "ActiveErpLinks": 194,
  "ShipmentTypes": [
    {
      "Id": 102,
      "Name": "Rempel Inc and Sons",
      "ToolTip": "Dolore vero.",
      "Deleted": false,
      "Rank": 934,
      "Type": "ut",
      "ColorBlock": 179,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2005-01-04T14:58:04.68846+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "reprehenderit",
      "Hidden": true,
      "FullName": "Mr. Calista Mueller",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "generate mission-critical vortals"
          },
          "FieldType": "System.String",
          "FieldLength": 262
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 838,
      "Comment": "vel",
      "Registered": "1995-07-28T14:58:04.68846+02:00",
      "RegisteredAssociateId": 345,
      "Updated": "2014-10-04T14:58:04.68846+02:00",
      "UpdatedAssociateId": 334,
      "LegalBaseId": 761,
      "LegalBaseKey": "nulla",
      "LegalBaseName": "Jewess, Kuhn and Hackett",
      "ConsentPurposeId": 478,
      "ConsentPurposeKey": "ratione",
      "ConsentPurposeName": "Harvey, Cartwright and Kertzmann",
      "ConsentSourceId": 595,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Mayert, Kertzmann and Thompson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 467
        }
      }
    }
  ],
  "BounceEmails": [
    "weldon.moen@heaneygislason.biz",
    "jordyn@lynch.biz"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Maryam Ebert",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "libero"
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
      "FieldLength": 969
    }
  }
}
```