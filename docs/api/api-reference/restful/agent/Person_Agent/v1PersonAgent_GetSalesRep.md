---
title: GetSalesRep
id: v1PersonAgent_GetSalesRep
---

# GetSalesRep

```http
POST /api/v1/Agents/Person/GetSalesRep
```

Returns the sales representative for an external user.

If this method is accessed with anonymous authentication the external user is recognized by contact and name, or by email, or phone number. If the external user is recognized as an CRM5 user (internal or external) the input fields can be left blank.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetSalesRep?$select=name,department,category/id
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

ContactName, PersonFirstname, PersonLastname, EmailAddress, PhoneNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactName | string |  |
| PersonFirstname | string |  |
| PersonLastname | string |  |
| EmailAddress | string |  |
| PhoneNumber | string |  |


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
POST /api/v1/Agents/Person/GetSalesRep
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactName": "Bailey, Schneider and Reichert",
  "PersonFirstname": "Marcel",
  "PersonLastname": "Bechtelar",
  "EmailAddress": "preston.weber@walker.com",
  "PhoneNumber": "709002"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 878,
  "Firstname": "Constance",
  "MiddleName": "Satterfield, Kihn and Lesch",
  "Lastname": "O'Reilly",
  "Mrmrs": "vitae",
  "Title": "omnis",
  "UpdatedDate": "2015-09-24T14:58:04.6974602+02:00",
  "CreatedDate": "2005-03-04T14:58:04.6974602+01:00",
  "BirthDate": "1996-05-28T14:58:04.6974602+02:00",
  "CreatedBy": {
    "AssociateId": 884,
    "Name": "Boehm LLC",
    "PersonId": 707,
    "Rank": 577,
    "Tooltip": "quisquam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 750,
    "FullName": "Miss Donny Zboncak",
    "FormalName": "Pagac, Olson and Hilpert",
    "Deleted": false,
    "EjUserId": 93,
    "UserName": "Gerhold, Stroman and Bernier",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 255
      }
    }
  },
  "Emails": [
    {
      "Value": "modi",
      "StrippedValue": "voluptates",
      "Description": "Upgradable heuristic forecast",
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
      "Value": "modi",
      "StrippedValue": "voluptates",
      "Description": "Upgradable heuristic forecast",
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
  "Description": "Up-sized grid-enabled capacity",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nobis",
      "StrippedValue": "voluptatem",
      "Description": "Progressive attitude-oriented groupware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "voluptatem",
      "Description": "Progressive attitude-oriented groupware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "fuga",
      "StrippedValue": "aut",
      "Description": "Visionary systemic flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "aut",
      "Description": "Visionary systemic flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "quidem",
      "Description": "Virtual client-server budgetary management",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 713
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "quidem",
      "Description": "Virtual client-server budgetary management",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 713
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "et",
      "StrippedValue": "omnis",
      "Description": "Organized local capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 512
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "omnis",
      "Description": "Organized local capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 512
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "in",
      "StrippedValue": "ut",
      "Description": "Multi-layered intangible model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 73
        }
      }
    },
    {
      "Value": "in",
      "StrippedValue": "ut",
      "Description": "Multi-layered intangible model",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 73
        }
      }
    }
  ],
  "Position": {
    "Id": 834,
    "Value": "reiciendis",
    "Tooltip": "eaque",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 312
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 509,
    "Name": "Heaney, Toy and Jast",
    "PersonId": 627,
    "Rank": 214,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 306,
    "FullName": "Odell Pacocha II",
    "FormalName": "Ullrich-Kertzmann",
    "Deleted": false,
    "EjUserId": 617,
    "UserName": "Greenholt LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 888
      }
    }
  },
  "Contact": {
    "ContactId": 801,
    "Name": "Leffler Inc and Sons",
    "OrgNr": "1213412",
    "Department": "implement front-end paradigms",
    "URL": "http://www.example.com/",
    "City": "magni",
    "DirectPhone": "(237)747-0750 x16410",
    "AssociateId": 215,
    "CountryId": 239,
    "EmailAddress": "daphney@ritchiejenkins.com",
    "Kananame": "labore",
    "EmailAddressName": "oma_osinski@hickle.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Sophia Koch",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quia",
    "FullName": "Wallace Berge",
    "IsOwnerContact": true,
    "ActiveErpLinks": 106,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 222
      }
    }
  },
  "Country": {
    "CountryId": 15,
    "Name": "Hartmann, Mayert and Monahan",
    "CurrencyId": 756,
    "EnglishName": "Turcotte Inc and Sons",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Persistent interactive adapter",
    "OrgNrText": "479921",
    "InterAreaPrefix": "debitis",
    "DialInPrefix": "quasi",
    "ZipPrefix": "distinctio",
    "DomainName": "Davis, Rolfson and Huels",
    "AddressLayoutId": 158,
    "DomesticAddressLayoutId": 439,
    "ForeignAddressLayoutId": 406,
    "Rank": 679,
    "Tooltip": "et",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 666
      }
    }
  },
  "Interests": [
    {
      "Id": 883,
      "Name": "Schaefer-Klein",
      "ToolTip": "Id qui qui et corporis.",
      "Deleted": true,
      "Rank": 699,
      "Type": "voluptates",
      "ColorBlock": 284,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2005-01-14T14:58:04.7004602+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugiat",
      "StyleHint": "itaque",
      "Hidden": true,
      "FullName": "Federico Kerluke MD",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 773
        }
      }
    }
  ],
  "PersonNumber": "1262625",
  "FullName": "Immanuel Stroman",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "sunt",
      "Description": "Synchronised optimal secured line",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 519
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "sunt",
      "Description": "Synchronised optimal secured line",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 519
        }
      }
    }
  ],
  "FormalName": "Nolan, Ferry and Simonis",
  "Address": {
    "Wgs84Latitude": 26463.496,
    "Wgs84Longitude": 15481.96,
    "LocalizedAddress": [
      [
        {
          "Name": "Gottlieb-DuBuque",
          "Value": "placeat",
          "Tooltip": "aut",
          "Label": "non",
          "ValueLength": 157,
          "AddressType": "quidem",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "whiteboard wireless portals"
              },
              "FieldType": "System.Int32",
              "FieldLength": 848
            }
          }
        }
      ],
      [
        {
          "Name": "Kemmer-Lehner",
          "Value": "cum",
          "Tooltip": "ut",
          "Label": "consequuntur",
          "ValueLength": 304,
          "AddressType": "molestiae",
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
              "FieldLength": 764
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "omnis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 954
      }
    }
  },
  "Post3": "magni",
  "Post2": "consequatur",
  "Post1": "sapiente",
  "Kanalname": "ducimus",
  "Kanafname": "est",
  "CorrespondingAssociate": {
    "AssociateId": 803,
    "Name": "Pacocha, Murazik and Bernier",
    "PersonId": 147,
    "Rank": 877,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 977,
    "FullName": "Sienna Blick III",
    "FormalName": "Beatty-Batz",
    "Deleted": false,
    "EjUserId": 375,
    "UserName": "Feest-Stark",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 447
      }
    }
  },
  "Category": {
    "Id": 429,
    "Value": "neque",
    "Tooltip": "dignissimos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 491
      }
    }
  },
  "Business": {
    "Id": 945,
    "Value": "eligendi",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 978
      }
    }
  },
  "Associate": {
    "AssociateId": 924,
    "Name": "Willms LLC",
    "PersonId": 342,
    "Rank": 915,
    "Tooltip": "rerum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 213,
    "FullName": "Zane Boyer",
    "FormalName": "Lebsack Group",
    "Deleted": true,
    "EjUserId": 214,
    "UserName": "Yundt LLC",
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
  "Salutation": "quae",
  "ActiveInterests": 349,
  "SupportAssociate": {
    "AssociateId": 887,
    "Name": "Beahan-Hackett",
    "PersonId": 122,
    "Rank": 604,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 995,
    "FullName": "Demetris Koepp",
    "FormalName": "Jenkins-Borer",
    "Deleted": true,
    "EjUserId": 496,
    "UserName": "Volkman, Cummerata and Wolff",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 743
      }
    }
  },
  "TicketPriority": {
    "Id": 446,
    "Value": "et",
    "Tooltip": "unde",
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
  "CustomerLanguage": {
    "Id": 850,
    "Value": "aliquam",
    "Tooltip": "quos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 455
      }
    }
  },
  "DbiAgentId": 743,
  "DbiKey": "cupiditate",
  "DbiLastModified": "1994-12-30T14:58:04.70246+01:00",
  "DbiLastSyncronized": "2019-11-19T14:58:04.70246+01:00",
  "SentInfo": 499,
  "ShowContactTickets": 240,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 714,
    "UserName": "Deckow Group",
    "PersonId": 20,
    "Rank": 875,
    "Tooltip": "vel",
    "UserGroupId": 160,
    "EjUserId": 171,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "dignissimos",
      "eum"
    ],
    "CanLogon": true,
    "RoleName": "Macejkovic-Walter",
    "RoleTooltip": "dolorum",
    "UserGroupName": "Kessler-Welch",
    "UserGroupTooltip": "alias",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 471
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "sequi",
      "StrippedValue": "nesciunt",
      "Description": "Business-focused optimal strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "nesciunt",
      "Description": "Business-focused optimal strategy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 641
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "suscipit",
      "StrippedValue": "sunt",
      "Description": "Fully-configurable 24 hour analyzer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "synergize dot-com interfaces"
          },
          "FieldType": "System.Int32",
          "FieldLength": 771
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "sunt",
      "Description": "Fully-configurable 24 hour analyzer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "synergize dot-com interfaces"
          },
          "FieldType": "System.Int32",
          "FieldLength": 771
        }
      }
    }
  ],
  "Source": 359,
  "ActiveErpLinks": 691,
  "ShipmentTypes": [
    {
      "Id": 238,
      "Name": "Auer LLC",
      "ToolTip": "Neque est temporibus quos omnis quis fuga.",
      "Deleted": false,
      "Rank": 547,
      "Type": "minus",
      "ColorBlock": 638,
      "IconHint": "consequuntur",
      "Selected": true,
      "LastChanged": "2017-11-15T14:58:04.7034629+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ducimus",
      "StyleHint": "eum",
      "Hidden": true,
      "FullName": "Mr. Shaina McDermott",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 48
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 634,
      "Comment": "vel",
      "Registered": "1998-05-31T14:58:04.7034629+02:00",
      "RegisteredAssociateId": 730,
      "Updated": "2012-07-19T14:58:04.7034629+02:00",
      "UpdatedAssociateId": 647,
      "LegalBaseId": 517,
      "LegalBaseKey": "omnis",
      "LegalBaseName": "Johnston, Wiegand and Macejkovic",
      "ConsentPurposeId": 947,
      "ConsentPurposeKey": "recusandae",
      "ConsentPurposeName": "Nolan LLC",
      "ConsentSourceId": 552,
      "ConsentSourceKey": "optio",
      "ConsentSourceName": "Bednar Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    }
  ],
  "BounceEmails": [
    "stanton_mills@lebsack.ca",
    "garrick_greenholt@glover.ca"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Santina Roberts",
    "SuperOffice:2": "1064627545"
  },
  "ExtraFields": {
    "ExtraFields1": "dolore",
    "ExtraFields2": "autem"
  },
  "CustomFields": {
    "CustomFields1": "minima",
    "CustomFields2": "id"
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
      "FieldLength": 651
    }
  }
}
```