---
title: POST Agents/Person/GetMyPerson
id: v1PersonAgent_GetMyPerson
---

# POST Agents/Person/GetMyPerson

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
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 743,
  "Firstname": "Aubree",
  "MiddleName": "Terry Inc and Sons",
  "Lastname": "Doyle",
  "Mrmrs": "tempora",
  "Title": "vitae",
  "UpdatedDate": "2010-03-25T18:28:49.6530897+01:00",
  "CreatedDate": "2002-02-11T18:28:49.6530897+01:00",
  "BirthDate": "1999-01-17T18:28:49.6530897+01:00",
  "CreatedBy": {
    "AssociateId": 899,
    "Name": "Ullrich, Lebsack and Wintheiser",
    "PersonId": 229,
    "Rank": 513,
    "Tooltip": "mollitia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 340,
    "FullName": "Willard Boehm Sr.",
    "FormalName": "Champlin Group",
    "Deleted": false,
    "EjUserId": 207,
    "UserName": "Corkery, Swaniawski and O'Conner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 711
      }
    }
  },
  "Emails": [
    {
      "Value": "sed",
      "StrippedValue": "cum",
      "Description": "Enhanced disintermediate benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "reinvent 24/7 networks"
          },
          "FieldType": "System.String",
          "FieldLength": 70
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "cum",
      "Description": "Enhanced disintermediate benchmark",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "reinvent 24/7 networks"
          },
          "FieldType": "System.String",
          "FieldLength": 70
        }
      }
    }
  ],
  "Description": "Customizable dynamic utilisation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sed",
      "StrippedValue": "non",
      "Description": "Cloned context-sensitive moratorium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 16
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "non",
      "Description": "Cloned context-sensitive moratorium",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 16
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "architecto",
      "Description": "Self-enabling 3rd generation info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "architecto",
      "Description": "Self-enabling 3rd generation info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 683
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "molestiae",
      "Description": "Polarised upward-trending functionalities",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 676
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "molestiae",
      "Description": "Polarised upward-trending functionalities",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 676
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "id",
      "StrippedValue": "odio",
      "Description": "Programmable 4th generation database",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "odio",
      "Description": "Programmable 4th generation database",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "debitis",
      "StrippedValue": "aut",
      "Description": "Reverse-engineered 24/7 alliance",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 845
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "aut",
      "Description": "Reverse-engineered 24/7 alliance",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 845
        }
      }
    }
  ],
  "Position": {
    "Id": 422,
    "Value": "labore",
    "Tooltip": "sequi",
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
  "UpdatedBy": {
    "AssociateId": 751,
    "Name": "McClure-Bartoletti",
    "PersonId": 390,
    "Rank": 40,
    "Tooltip": "commodi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 34,
    "FullName": "Claudie Hirthe",
    "FormalName": "Wiza-Zulauf",
    "Deleted": false,
    "EjUserId": 512,
    "UserName": "Hintz Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 31
      }
    }
  },
  "Contact": {
    "ContactId": 318,
    "Name": "Dooley, Hansen and Thompson",
    "OrgNr": "920466",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "harum",
    "DirectPhone": "226.656.2855 x052",
    "AssociateId": 334,
    "CountryId": 523,
    "EmailAddress": "kenyatta@kulas.com",
    "Kananame": "architecto",
    "EmailAddressName": "carson@luettgen.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Eldridge Watsica",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "cumque",
    "FullName": "Patsy Klein",
    "IsOwnerContact": false,
    "ActiveErpLinks": 50,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 379
      }
    }
  },
  "Country": {
    "CountryId": 274,
    "Name": "Watsica Group",
    "CurrencyId": 361,
    "EnglishName": "Prohaska-Shields",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Persevering composite neural-net",
    "OrgNrText": "333271",
    "InterAreaPrefix": "perspiciatis",
    "DialInPrefix": "facilis",
    "ZipPrefix": "est",
    "DomainName": "Bauch Group",
    "AddressLayoutId": 674,
    "DomesticAddressLayoutId": 894,
    "ForeignAddressLayoutId": 633,
    "Rank": 150,
    "Tooltip": "fugit",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 528
      }
    }
  },
  "Interests": [
    {
      "Id": 628,
      "Name": "Volkman, Fay and Bauch",
      "ToolTip": "Dolorem soluta dolor.",
      "Deleted": false,
      "Rank": 718,
      "Type": "fuga",
      "ColorBlock": 118,
      "IconHint": "repudiandae",
      "Selected": true,
      "LastChanged": "2010-10-25T18:28:49.6555968+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "recusandae",
      "StyleHint": "suscipit",
      "Hidden": false,
      "FullName": "Aliya Hettinger",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 799
        }
      }
    }
  ],
  "PersonNumber": "1049351",
  "FullName": "Katheryn Murphy",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "totam",
      "StrippedValue": "mollitia",
      "Description": "Expanded 5th generation time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 164
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "mollitia",
      "Description": "Expanded 5th generation time-frame",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 164
        }
      }
    }
  ],
  "FormalName": "Schinner Inc and Sons",
  "Address": {
    "Wgs84Latitude": 27409.964,
    "Wgs84Longitude": 13864.815999999999,
    "LocalizedAddress": [
      [
        {
          "Name": "Green Inc and Sons",
          "Value": "consectetur",
          "Tooltip": "doloribus",
          "Label": "explicabo",
          "ValueLength": 985,
          "AddressType": "consequatur",
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
              "FieldLength": 976
            }
          }
        }
      ],
      [
        {
          "Name": "Wisoky, Cormier and Schumm",
          "Value": "voluptatum",
          "Tooltip": "voluptas",
          "Label": "dolor",
          "ValueLength": 89,
          "AddressType": "alias",
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
              "FieldLength": 571
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "quasi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 505
      }
    }
  },
  "Post3": "atque",
  "Post2": "aut",
  "Post1": "perspiciatis",
  "Kanalname": "repudiandae",
  "Kanafname": "labore",
  "CorrespondingAssociate": {
    "AssociateId": 909,
    "Name": "Greenholt Inc and Sons",
    "PersonId": 803,
    "Rank": 698,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 487,
    "FullName": "Wilma Kling",
    "FormalName": "Lehner, Nicolas and Considine",
    "Deleted": false,
    "EjUserId": 987,
    "UserName": "Swift, Kub and Wehner",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 488
      }
    }
  },
  "Category": {
    "Id": 38,
    "Value": "harum",
    "Tooltip": "rem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 568
      }
    }
  },
  "Business": {
    "Id": 144,
    "Value": "assumenda",
    "Tooltip": "quisquam",
    "TableRight": {},
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
  },
  "Associate": {
    "AssociateId": 295,
    "Name": "Hettinger Inc and Sons",
    "PersonId": 298,
    "Rank": 402,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 367,
    "FullName": "Fleta Wunsch",
    "FormalName": "Schowalter-Ebert",
    "Deleted": true,
    "EjUserId": 896,
    "UserName": "Gleason Inc and Sons",
    "TableRight": {},
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
  },
  "Salutation": "sit",
  "ActiveInterests": 959,
  "SupportAssociate": {
    "AssociateId": 384,
    "Name": "Gislason Group",
    "PersonId": 213,
    "Rank": 519,
    "Tooltip": "delectus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 767,
    "FullName": "Daron Blick IV",
    "FormalName": "Kunze Group",
    "Deleted": true,
    "EjUserId": 163,
    "UserName": "Williamson, Huel and Jaskolski",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 564
      }
    }
  },
  "TicketPriority": {
    "Id": 489,
    "Value": "impedit",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 733
      }
    }
  },
  "CustomerLanguage": {
    "Id": 102,
    "Value": "ratione",
    "Tooltip": "voluptates",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "deliver enterprise experiences"
        },
        "FieldType": "System.Int32",
        "FieldLength": 692
      }
    }
  },
  "DbiAgentId": 547,
  "DbiKey": "tenetur",
  "DbiLastModified": "2001-02-25T18:28:49.6581375+01:00",
  "DbiLastSyncronized": "2012-10-24T18:28:49.6581375+02:00",
  "SentInfo": 306,
  "ShowContactTickets": 1000,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 778,
    "UserName": "Hand-Rolfson",
    "PersonId": 957,
    "Rank": 20,
    "Tooltip": "esse",
    "UserGroupId": 463,
    "EjUserId": 327,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "repellat",
      "in"
    ],
    "CanLogon": true,
    "RoleName": "Predovic Group",
    "RoleTooltip": "corporis",
    "UserGroupName": "White, Little and Gleichner",
    "UserGroupTooltip": "earum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 472
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "amet",
      "StrippedValue": "tenetur",
      "Description": "Optional directional functionalities",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 675
        }
      }
    },
    {
      "Value": "amet",
      "StrippedValue": "tenetur",
      "Description": "Optional directional functionalities",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 675
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "odio",
      "StrippedValue": "ullam",
      "Description": "Quality-focused 24/7 open system",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 500
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "ullam",
      "Description": "Quality-focused 24/7 open system",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 500
        }
      }
    }
  ],
  "Source": 885,
  "ActiveErpLinks": 687,
  "ShipmentTypes": [
    {
      "Id": 915,
      "Name": "Ryan-Kris",
      "ToolTip": "Architecto consectetur.",
      "Deleted": false,
      "Rank": 917,
      "Type": "est",
      "ColorBlock": 705,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "1999-06-22T18:28:49.6591372+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consectetur",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Johann Klein",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 647
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 899,
      "Comment": "quo",
      "Registered": "2006-01-23T18:28:49.6591372+01:00",
      "RegisteredAssociateId": 306,
      "Updated": "1998-01-19T18:28:49.6591372+01:00",
      "UpdatedAssociateId": 43,
      "LegalBaseId": 952,
      "LegalBaseKey": "repudiandae",
      "LegalBaseName": "Schulist-Cartwright",
      "ConsentPurposeId": 13,
      "ConsentPurposeKey": "qui",
      "ConsentPurposeName": "Mertz Inc and Sons",
      "ConsentSourceId": 443,
      "ConsentSourceKey": "eaque",
      "ConsentSourceName": "Kiehn LLC",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    }
  ],
  "BounceEmails": [
    "johnny@cormier.co.uk",
    "cleora@mantelehner.name"
  ],
  "ActiveStatusMonitorId": 317,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Lilian Monahan",
    "SuperOffice:2": "Theo Kshlerin"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "reprehenderit"
  },
  "CustomFields": {
    "CustomFields1": "tempora",
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
      "FieldLength": 577
    }
  }
}
```