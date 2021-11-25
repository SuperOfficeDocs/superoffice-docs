---
title: POST Agents/Person/CreateDefaultPersonEntity
id: v1PersonAgent_CreateDefaultPersonEntity
---

# POST Agents/Person/CreateDefaultPersonEntity

```http
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
```

Set default values into a new PersonEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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
POST /api/v1/Agents/Person/CreateDefaultPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 330,
  "Firstname": "Haylie",
  "MiddleName": "Dicki Inc and Sons",
  "Lastname": "Lang",
  "Mrmrs": "consequatur",
  "Title": "sed",
  "UpdatedDate": "1994-08-27T18:28:49.5410876+02:00",
  "CreatedDate": "2006-11-10T18:28:49.5410876+01:00",
  "BirthDate": "2001-03-01T18:28:49.5410876+01:00",
  "CreatedBy": {
    "AssociateId": 671,
    "Name": "Mohr, Gutmann and Pfeffer",
    "PersonId": 336,
    "Rank": 972,
    "Tooltip": "minima",
    "Type": "AnonymousAssociate",
    "GroupIdx": 760,
    "FullName": "Kasandra Ernser IV",
    "FormalName": "Keebler-Balistreri",
    "Deleted": true,
    "EjUserId": 660,
    "UserName": "Parisian-Parker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 529
      }
    }
  },
  "Emails": [
    {
      "Value": "recusandae",
      "StrippedValue": "laborum",
      "Description": "Focused executive standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 434
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "laborum",
      "Description": "Focused executive standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 434
        }
      }
    }
  ],
  "Description": "Open-architected exuding policy",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "natus",
      "StrippedValue": "sapiente",
      "Description": "Re-engineered discrete help-desk",
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
      "Value": "natus",
      "StrippedValue": "sapiente",
      "Description": "Re-engineered discrete help-desk",
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
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "eaque",
      "Description": "Organic human-resource initiative",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 132
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "eaque",
      "Description": "Organic human-resource initiative",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 132
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "totam",
      "StrippedValue": "est",
      "Description": "Diverse grid-enabled open architecture",
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
    {
      "Value": "totam",
      "StrippedValue": "est",
      "Description": "Diverse grid-enabled open architecture",
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
    }
  ],
  "OfficePhones": [
    {
      "Value": "harum",
      "StrippedValue": "omnis",
      "Description": "Synchronised heuristic core",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 106
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "omnis",
      "Description": "Synchronised heuristic core",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 106
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "rem",
      "StrippedValue": "doloremque",
      "Description": "Assimilated even-keeled throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 752
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "doloremque",
      "Description": "Assimilated even-keeled throughput",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 752
        }
      }
    }
  ],
  "Position": {
    "Id": 919,
    "Value": "aut",
    "Tooltip": "ab",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 356
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 995,
    "Name": "Wisozk-Kessler",
    "PersonId": 357,
    "Rank": 916,
    "Tooltip": "harum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 570,
    "FullName": "Dr. Etha Connelly",
    "FormalName": "Huel, Fisher and Daugherty",
    "Deleted": true,
    "EjUserId": 340,
    "UserName": "Kuphal LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 814
      }
    }
  },
  "Contact": {
    "ContactId": 970,
    "Name": "Jacobs, Crona and Reinger",
    "OrgNr": "649087",
    "Department": "synergize dot-com synergies",
    "URL": "http://www.example.com/",
    "City": "consequuntur",
    "DirectPhone": "280.775.1167 x851",
    "AssociateId": 304,
    "CountryId": 494,
    "EmailAddress": "wilburn.nikolaus@schumm.biz",
    "Kananame": "ea",
    "EmailAddressName": "sofia.gislason@feest.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kaden Ledner",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "consequatur",
    "FullName": "Lucienne Skiles Jr.",
    "IsOwnerContact": false,
    "ActiveErpLinks": 253,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 620
      }
    }
  },
  "Country": {
    "CountryId": 560,
    "Name": "Sawayn-Bartoletti",
    "CurrencyId": 25,
    "EnglishName": "Kessler, Hand and Mertz",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Multi-tiered bottom-line open architecture",
    "OrgNrText": "1009742",
    "InterAreaPrefix": "sunt",
    "DialInPrefix": "ipsam",
    "ZipPrefix": "similique",
    "DomainName": "Hammes, Simonis and Stehr",
    "AddressLayoutId": 509,
    "DomesticAddressLayoutId": 463,
    "ForeignAddressLayoutId": 984,
    "Rank": 825,
    "Tooltip": "nesciunt",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 708
      }
    }
  },
  "Interests": [
    {
      "Id": 371,
      "Name": "Koss-Funk",
      "ToolTip": "Exercitationem non.",
      "Deleted": false,
      "Rank": 665,
      "Type": "dignissimos",
      "ColorBlock": 500,
      "IconHint": "labore",
      "Selected": true,
      "LastChanged": "1998-08-03T18:28:49.5440875+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorum",
      "StyleHint": "distinctio",
      "Hidden": true,
      "FullName": "Tomasa Ledner",
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
  "PersonNumber": "698886",
  "FullName": "Toney Rempel",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "veritatis",
      "StrippedValue": "enim",
      "Description": "Reduced fault-tolerant challenge",
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
      "Value": "veritatis",
      "StrippedValue": "enim",
      "Description": "Reduced fault-tolerant challenge",
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
  "FormalName": "Bartell-Hackett",
  "Address": {
    "Wgs84Latitude": 12601.814,
    "Wgs84Longitude": 1319.414,
    "LocalizedAddress": [
      [
        {
          "Name": "Rolfson LLC",
          "Value": "occaecati",
          "Tooltip": "eligendi",
          "Label": "cum",
          "ValueLength": 941,
          "AddressType": "in",
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
              "FieldLength": 901
            }
          }
        }
      ],
      [
        {
          "Name": "Rowe, Feest and Gusikowski",
          "Value": "nulla",
          "Tooltip": "nostrum",
          "Label": "animi",
          "ValueLength": 754,
          "AddressType": "labore",
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
              "FieldLength": 693
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "animi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 595
      }
    }
  },
  "Post3": "eveniet",
  "Post2": "et",
  "Post1": "adipisci",
  "Kanalname": "temporibus",
  "Kanafname": "eum",
  "CorrespondingAssociate": {
    "AssociateId": 643,
    "Name": "Tillman, Smitham and Muller",
    "PersonId": 148,
    "Rank": 232,
    "Tooltip": "sunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 648,
    "FullName": "Freddy Lind",
    "FormalName": "Runolfsson Group",
    "Deleted": true,
    "EjUserId": 28,
    "UserName": "Weissnat LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 947
      }
    }
  },
  "Category": {
    "Id": 766,
    "Value": "sint",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "scale one-to-one systems"
        },
        "FieldType": "System.String",
        "FieldLength": 141
      }
    }
  },
  "Business": {
    "Id": 68,
    "Value": "consequatur",
    "Tooltip": "ad",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 535
      }
    }
  },
  "Associate": {
    "AssociateId": 224,
    "Name": "Sauer-Jacobs",
    "PersonId": 101,
    "Rank": 766,
    "Tooltip": "dignissimos",
    "Type": "AnonymousAssociate",
    "GroupIdx": 707,
    "FullName": "Moses Parisian III",
    "FormalName": "Mann, Paucek and Willms",
    "Deleted": true,
    "EjUserId": 594,
    "UserName": "Hand-Mueller",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 406
      }
    }
  },
  "Salutation": "dignissimos",
  "ActiveInterests": 116,
  "SupportAssociate": {
    "AssociateId": 471,
    "Name": "Zulauf, Jenkins and Lind",
    "PersonId": 717,
    "Rank": 136,
    "Tooltip": "odio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 276,
    "FullName": "Vivianne Wehner",
    "FormalName": "Jaskolski, Hoppe and Ferry",
    "Deleted": false,
    "EjUserId": 933,
    "UserName": "Osinski-Lind",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 32
      }
    }
  },
  "TicketPriority": {
    "Id": 881,
    "Value": "illo",
    "Tooltip": "ut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "enhance killer mindshare"
        },
        "FieldType": "System.Int32",
        "FieldLength": 842
      }
    }
  },
  "CustomerLanguage": {
    "Id": 148,
    "Value": "soluta",
    "Tooltip": "non",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 687
      }
    }
  },
  "DbiAgentId": 216,
  "DbiKey": "distinctio",
  "DbiLastModified": "2017-05-13T18:28:49.5470874+02:00",
  "DbiLastSyncronized": "2010-04-21T18:28:49.5470874+02:00",
  "SentInfo": 514,
  "ShowContactTickets": 525,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 221,
    "UserName": "Kuphal-Nitzsche",
    "PersonId": 686,
    "Rank": 256,
    "Tooltip": "iure",
    "UserGroupId": 117,
    "EjUserId": 374,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "cumque",
      "tempore"
    ],
    "CanLogon": true,
    "RoleName": "Herzog-Kunze",
    "RoleTooltip": "voluptatem",
    "UserGroupName": "Donnelly-McGlynn",
    "UserGroupTooltip": "nisi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 196
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "corrupti",
      "StrippedValue": "odio",
      "Description": "Distributed dedicated process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "odio",
      "Description": "Distributed dedicated process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "vel",
      "StrippedValue": "voluptatem",
      "Description": "Open-source zero defect throughput",
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
    {
      "Value": "vel",
      "StrippedValue": "voluptatem",
      "Description": "Open-source zero defect throughput",
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
    }
  ],
  "Source": 16,
  "ActiveErpLinks": 614,
  "ShipmentTypes": [
    {
      "Id": 647,
      "Name": "Graham-Volkman",
      "ToolTip": "Laboriosam deserunt.",
      "Deleted": false,
      "Rank": 996,
      "Type": "saepe",
      "ColorBlock": 816,
      "IconHint": "voluptatem",
      "Selected": true,
      "LastChanged": "2010-04-24T18:28:49.5480874+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "velit",
      "StyleHint": "voluptatem",
      "Hidden": true,
      "FullName": "Miss Denis Mann",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 935
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 852,
      "Comment": "esse",
      "Registered": "2008-12-23T18:28:49.5480874+01:00",
      "RegisteredAssociateId": 1001,
      "Updated": "2000-03-02T18:28:49.5480874+01:00",
      "UpdatedAssociateId": 590,
      "LegalBaseId": 966,
      "LegalBaseKey": "aut",
      "LegalBaseName": "McGlynn Group",
      "ConsentPurposeId": 139,
      "ConsentPurposeKey": "ab",
      "ConsentPurposeName": "Gulgowski Group",
      "ConsentSourceId": 871,
      "ConsentSourceKey": "consectetur",
      "ConsentSourceName": "Cummerata-Pouros",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 35
        }
      }
    }
  ],
  "BounceEmails": [
    "anya@strosin.uk",
    "everardo@konopelski.uk"
  ],
  "ActiveStatusMonitorId": 502,
  "UserDefinedFields": {
    "SuperOffice:1": "Reagan Tillman",
    "SuperOffice:2": "Mittie Nikolaus"
  },
  "ExtraFields": {
    "ExtraFields1": "repellendus",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "dolorem"
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
      "FieldLength": 718
    }
  }
}
```