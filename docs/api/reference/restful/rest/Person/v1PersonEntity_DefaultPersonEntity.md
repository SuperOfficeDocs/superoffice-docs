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
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
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
Last-Modified: Mon, 28 Jul 2014 18:25:50 G7T

{
  "PersonId": 579,
  "Firstname": "Maybell",
  "MiddleName": "Kihn-Roob",
  "Lastname": "Berge",
  "Mrmrs": "sed",
  "Title": "perspiciatis",
  "UpdatedDate": "2014-07-28T18:25:50.6326244+02:00",
  "CreatedDate": "1999-03-21T18:25:50.6326244+01:00",
  "BirthDate": "1999-07-12T18:25:50.6326244+02:00",
  "CreatedBy": {
    "AssociateId": 286,
    "Name": "Bradtke Inc and Sons",
    "PersonId": 979,
    "Rank": 122,
    "Tooltip": "molestias",
    "Type": "AnonymousAssociate",
    "GroupIdx": 542,
    "FullName": "Kennedi Dickinson",
    "FormalName": "Langworth Group",
    "Deleted": false,
    "EjUserId": 272,
    "UserName": "Muller Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 472
      }
    }
  },
  "Emails": [
    {
      "Value": "culpa",
      "StrippedValue": "et",
      "Description": "Diverse assymetric info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 199
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "et",
      "Description": "Diverse assymetric info-mediaries",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 199
        }
      }
    }
  ],
  "Description": "Quality-focused client-server algorithm",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "esse",
      "StrippedValue": "neque",
      "Description": "Extended tangible knowledge base",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 50
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "neque",
      "Description": "Extended tangible knowledge base",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 50
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "explicabo",
      "StrippedValue": "maiores",
      "Description": "Polarised bifurcated moderator",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 783
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "maiores",
      "Description": "Polarised bifurcated moderator",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 783
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "debitis",
      "Description": "Realigned reciprocal capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 241
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "debitis",
      "Description": "Realigned reciprocal capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 241
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "temporibus",
      "StrippedValue": "quisquam",
      "Description": "Streamlined client-driven matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 276
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "quisquam",
      "Description": "Streamlined client-driven matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 276
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "vel",
      "StrippedValue": "est",
      "Description": "Mandatory empowering analyzer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "est",
      "Description": "Mandatory empowering analyzer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 184
        }
      }
    }
  ],
  "Position": {
    "Id": 58,
    "Value": "excepturi",
    "Tooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 234
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 550,
    "Name": "Barton LLC",
    "PersonId": 418,
    "Rank": 573,
    "Tooltip": "nemo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 113,
    "FullName": "Tessie Abbott",
    "FormalName": "Gottlieb-Nikolaus",
    "Deleted": true,
    "EjUserId": 67,
    "UserName": "Schuppe-Gerlach",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 269
      }
    }
  },
  "Contact": {
    "ContactId": 733,
    "Name": "Effertz, Cassin and Sauer",
    "OrgNr": "1163561",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "est",
    "DirectPhone": "(762)736-5372 x02208",
    "AssociateId": 104,
    "CountryId": 448,
    "EmailAddress": "ward_white@hirthe.biz",
    "Kananame": "eligendi",
    "EmailAddressName": "leone.kirlin@hoppe.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Geovany Lang",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "rerum",
    "FullName": "Abelardo Padberg",
    "IsOwnerContact": true,
    "ActiveErpLinks": 981,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 297
      }
    }
  },
  "Country": {
    "CountryId": 824,
    "Name": "Breitenberg-West",
    "CurrencyId": 838,
    "EnglishName": "Little-Zulauf",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Reverse-engineered local success",
    "OrgNrText": "860388",
    "InterAreaPrefix": "id",
    "DialInPrefix": "nulla",
    "ZipPrefix": "ratione",
    "DomainName": "Wintheiser LLC",
    "AddressLayoutId": 463,
    "DomesticAddressLayoutId": 270,
    "ForeignAddressLayoutId": 4,
    "Rank": 646,
    "Tooltip": "aut",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "engineer dynamic e-tailers"
        },
        "FieldType": "System.Int32",
        "FieldLength": 877
      }
    }
  },
  "Interests": [
    {
      "Id": 604,
      "Name": "Balistreri-Hudson",
      "ToolTip": "Deleniti harum rerum.",
      "Deleted": true,
      "Rank": 271,
      "Type": "pariatur",
      "ColorBlock": 72,
      "IconHint": "dolores",
      "Selected": false,
      "LastChanged": "2001-12-01T18:25:50.6356248+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "fugit",
      "Hidden": false,
      "FullName": "Claudia Zboncak",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 442
        }
      }
    }
  ],
  "PersonNumber": "376682",
  "FullName": "Sarina Rempel",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "aut",
      "Description": "Open-architected scalable policy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 543
        }
      }
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "aut",
      "Description": "Open-architected scalable policy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 543
        }
      }
    }
  ],
  "FormalName": "Goodwin-Boehm",
  "Address": {
    "Wgs84Latitude": 10144.758,
    "Wgs84Longitude": 30813.487999999998,
    "LocalizedAddress": [
      [
        {
          "Name": "Rowe Group",
          "Value": "fugiat",
          "Tooltip": "placeat",
          "Label": "qui",
          "ValueLength": 506,
          "AddressType": "delectus",
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
              "FieldLength": 674
            }
          }
        }
      ],
      [
        {
          "Name": "Bergstrom, Stamm and Flatley",
          "Value": "aperiam",
          "Tooltip": "distinctio",
          "Label": "mollitia",
          "ValueLength": 39,
          "AddressType": "dolorem",
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
              "FieldLength": 196
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "nisi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 391
      }
    }
  },
  "Post3": "velit",
  "Post2": "nostrum",
  "Post1": "mollitia",
  "Kanalname": "voluptas",
  "Kanafname": "aut",
  "CorrespondingAssociate": {
    "AssociateId": 259,
    "Name": "Shanahan Inc and Sons",
    "PersonId": 730,
    "Rank": 286,
    "Tooltip": "recusandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 866,
    "FullName": "Mrs. Gregory Yost",
    "FormalName": "Daniel-Hintz",
    "Deleted": false,
    "EjUserId": 822,
    "UserName": "Morar Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 626
      }
    }
  },
  "Category": {
    "Id": 447,
    "Value": "et",
    "Tooltip": "esse",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 723
      }
    }
  },
  "Business": {
    "Id": 753,
    "Value": "aut",
    "Tooltip": "fuga",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 719
      }
    }
  },
  "Associate": {
    "AssociateId": 283,
    "Name": "Altenwerth, Satterfield and Weber",
    "PersonId": 373,
    "Rank": 225,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 496,
    "FullName": "Sarah Witting",
    "FormalName": "Braun-Smitham",
    "Deleted": false,
    "EjUserId": 14,
    "UserName": "Kihn LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 605
      }
    }
  },
  "Salutation": "similique",
  "ActiveInterests": 263,
  "SupportAssociate": {
    "AssociateId": 197,
    "Name": "Dickinson Group",
    "PersonId": 550,
    "Rank": 573,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 438,
    "FullName": "Oral Lebsack",
    "FormalName": "Grant-Howe",
    "Deleted": true,
    "EjUserId": 883,
    "UserName": "Farrell LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 926
      }
    }
  },
  "TicketPriority": {
    "Id": 272,
    "Value": "eveniet",
    "Tooltip": "excepturi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 634
      }
    }
  },
  "CustomerLanguage": {
    "Id": 827,
    "Value": "corporis",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 173
      }
    }
  },
  "DbiAgentId": 368,
  "DbiKey": "vel",
  "DbiLastModified": "1996-08-15T18:25:50.6376243+02:00",
  "DbiLastSyncronized": "1998-06-12T18:25:50.6376243+02:00",
  "SentInfo": 488,
  "ShowContactTickets": 136,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 723,
    "UserName": "Hauck Group",
    "PersonId": 411,
    "Rank": 791,
    "Tooltip": "eum",
    "UserGroupId": 280,
    "EjUserId": 763,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "sequi",
      "autem"
    ],
    "CanLogon": true,
    "RoleName": "Schamberger, D'Amore and Boehm",
    "RoleTooltip": "natus",
    "UserGroupName": "Mann-Swaniawski",
    "UserGroupTooltip": "alias",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 955
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "ex",
      "StrippedValue": "est",
      "Description": "Visionary eco-centric policy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 841
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "est",
      "Description": "Visionary eco-centric policy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 841
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quidem",
      "StrippedValue": "commodi",
      "Description": "Advanced demand-driven archive",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "commodi",
      "Description": "Advanced demand-driven archive",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 317
        }
      }
    }
  ],
  "Source": 52,
  "ActiveErpLinks": 342,
  "ShipmentTypes": [
    {
      "Id": 164,
      "Name": "Russel-Barrows",
      "ToolTip": "Temporibus fugiat veniam non consequatur animi.",
      "Deleted": false,
      "Rank": 611,
      "Type": "qui",
      "ColorBlock": 803,
      "IconHint": "autem",
      "Selected": false,
      "LastChanged": "2006-06-21T18:25:50.6386284+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Myrtis Stokes",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 98
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 305,
      "Comment": "ducimus",
      "Registered": "2011-01-28T18:25:50.6386284+01:00",
      "RegisteredAssociateId": 547,
      "Updated": "2002-09-05T18:25:50.6386284+02:00",
      "UpdatedAssociateId": 621,
      "LegalBaseId": 542,
      "LegalBaseKey": "iste",
      "LegalBaseName": "Simonis Inc and Sons",
      "ConsentPurposeId": 594,
      "ConsentPurposeKey": "voluptas",
      "ConsentPurposeName": "Kling, Swaniawski and Pouros",
      "ConsentSourceId": 474,
      "ConsentSourceKey": "omnis",
      "ConsentSourceName": "Mosciski-Steuber",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    }
  ],
  "BounceEmails": [
    "lew_kuvalis@jakubowskibeahan.name",
    "jacynthe@gusikowski.uk"
  ],
  "ActiveStatusMonitorId": 140,
  "UserDefinedFields": {
    "SuperOffice:1": "Watson Cummerata PhD",
    "SuperOffice:2": "414335218"
  },
  "ExtraFields": {
    "ExtraFields1": "illum",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "quam"
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
      "FieldLength": 543
    }
  }
}
```