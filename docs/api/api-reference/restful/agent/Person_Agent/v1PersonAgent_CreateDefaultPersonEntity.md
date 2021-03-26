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
  "PersonId": 710,
  "Firstname": "Ariane",
  "MiddleName": "Marks-Block",
  "Lastname": "Jenkins",
  "Mrmrs": "veritatis",
  "Title": "numquam",
  "UpdatedDate": "2017-03-11T16:48:30.0069252+01:00",
  "CreatedDate": "2019-04-26T16:48:30.0069252+02:00",
  "BirthDate": "2006-02-24T16:48:30.0069252+01:00",
  "CreatedBy": {
    "AssociateId": 898,
    "Name": "Dach Group",
    "PersonId": 674,
    "Rank": 829,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 991,
    "FullName": "Monroe Jakubowski",
    "FormalName": "Tillman Group",
    "Deleted": false,
    "EjUserId": 355,
    "UserName": "Bogan Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 586
      }
    }
  },
  "Emails": [
    {
      "Value": "eligendi",
      "StrippedValue": "occaecati",
      "Description": "Object-based content-based hardware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "occaecati",
      "Description": "Object-based content-based hardware",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 171
        }
      }
    }
  ],
  "Description": "Multi-layered actuating Graphical User Interface",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "sit",
      "StrippedValue": "dicta",
      "Description": "Enhanced static neural-net",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 671
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "dicta",
      "Description": "Enhanced static neural-net",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 671
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "animi",
      "Description": "Business-focused executive standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "animi",
      "Description": "Business-focused executive standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "commodi",
      "StrippedValue": "rerum",
      "Description": "Triple-buffered intermediate pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 932
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "rerum",
      "Description": "Triple-buffered intermediate pricing structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 932
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ut",
      "StrippedValue": "voluptatibus",
      "Description": "Polarised assymetric portal",
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
      "Value": "ut",
      "StrippedValue": "voluptatibus",
      "Description": "Polarised assymetric portal",
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
  "OtherPhones": [
    {
      "Value": "eum",
      "StrippedValue": "quo",
      "Description": "Exclusive executive protocol",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 988
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "quo",
      "Description": "Exclusive executive protocol",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 988
        }
      }
    }
  ],
  "Position": {
    "Id": 756,
    "Value": "deleniti",
    "Tooltip": "veniam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "grow transparent schemas"
        },
        "FieldType": "System.String",
        "FieldLength": 932
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 212,
    "Name": "Wuckert Inc and Sons",
    "PersonId": 746,
    "Rank": 777,
    "Tooltip": "molestiae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 323,
    "FullName": "Justus Herzog",
    "FormalName": "Bins-Greenholt",
    "Deleted": true,
    "EjUserId": 906,
    "UserName": "Stiedemann, Konopelski and Walker",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 272
      }
    }
  },
  "Contact": {
    "ContactId": 799,
    "Name": "Volkman, Wunsch and Emard",
    "OrgNr": "1452536",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "qui",
    "DirectPhone": "(207)442-3388",
    "AssociateId": 652,
    "CountryId": 865,
    "EmailAddress": "asa_barton@koch.info",
    "Kananame": "qui",
    "EmailAddressName": "wiley@andersonpollich.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Laurianne Upton",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "magnam",
    "FullName": "Mr. Rogers Walter",
    "IsOwnerContact": true,
    "ActiveErpLinks": 936,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 554
      }
    }
  },
  "Country": {
    "CountryId": 289,
    "Name": "Weissnat Inc and Sons",
    "CurrencyId": 898,
    "EnglishName": "Kris Group",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Vision-oriented secondary adapter",
    "OrgNrText": "883904",
    "InterAreaPrefix": "et",
    "DialInPrefix": "cupiditate",
    "ZipPrefix": "voluptas",
    "DomainName": "Herman, Blanda and Carter",
    "AddressLayoutId": 616,
    "DomesticAddressLayoutId": 811,
    "ForeignAddressLayoutId": 970,
    "Rank": 82,
    "Tooltip": "est",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 31
      }
    }
  },
  "Interests": [
    {
      "Id": 188,
      "Name": "Okuneva, Walsh and Schimmel",
      "ToolTip": "Veniam optio repudiandae porro modi dolorem.",
      "Deleted": true,
      "Rank": 250,
      "Type": "dignissimos",
      "ColorBlock": 413,
      "IconHint": "blanditiis",
      "Selected": false,
      "LastChanged": "2015-10-13T16:48:30.0089264+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "accusantium",
      "StyleHint": "ad",
      "Hidden": false,
      "FullName": "Gardner DuBuque IV",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 664
        }
      }
    }
  ],
  "PersonNumber": "438682",
  "FullName": "Lavina Simonis IV",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "ut",
      "Description": "Streamlined 5th generation customer loyalty",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 858
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "ut",
      "Description": "Streamlined 5th generation customer loyalty",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 858
        }
      }
    }
  ],
  "FormalName": "Wolf, Schmitt and Harris",
  "Address": {
    "Wgs84Latitude": 20320.856,
    "Wgs84Longitude": 27127.904,
    "LocalizedAddress": [
      [
        {
          "Name": "Veum-Kuhn",
          "Value": "qui",
          "Tooltip": "ut",
          "Label": "nulla",
          "ValueLength": 27,
          "AddressType": "vel",
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
              "FieldLength": 628
            }
          }
        }
      ],
      [
        {
          "Name": "Greenholt, Howe and Homenick",
          "Value": "a",
          "Tooltip": "odio",
          "Label": "nihil",
          "ValueLength": 833,
          "AddressType": "incidunt",
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
              "FieldLength": 164
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "illum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 988
      }
    }
  },
  "Post3": "illo",
  "Post2": "sed",
  "Post1": "voluptatum",
  "Kanalname": "molestiae",
  "Kanafname": "qui",
  "CorrespondingAssociate": {
    "AssociateId": 356,
    "Name": "Effertz-McGlynn",
    "PersonId": 536,
    "Rank": 94,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 934,
    "FullName": "Peggie Goyette",
    "FormalName": "Dickinson, Auer and Tromp",
    "Deleted": true,
    "EjUserId": 336,
    "UserName": "Rowe, Mayert and Mohr",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 54
      }
    }
  },
  "Category": {
    "Id": 904,
    "Value": "tempora",
    "Tooltip": "quas",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 486
      }
    }
  },
  "Business": {
    "Id": 712,
    "Value": "et",
    "Tooltip": "cum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "generate front-end communities"
        },
        "FieldType": "System.String",
        "FieldLength": 440
      }
    }
  },
  "Associate": {
    "AssociateId": 346,
    "Name": "Marvin-Ullrich",
    "PersonId": 592,
    "Rank": 371,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 817,
    "FullName": "Lola Bauch",
    "FormalName": "Walter LLC",
    "Deleted": true,
    "EjUserId": 914,
    "UserName": "Ruecker, Gleason and Quigley",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 714
      }
    }
  },
  "Salutation": "nisi",
  "ActiveInterests": 426,
  "SupportAssociate": {
    "AssociateId": 767,
    "Name": "Blanda, Collier and Morar",
    "PersonId": 559,
    "Rank": 235,
    "Tooltip": "quidem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 687,
    "FullName": "Reese Morar",
    "FormalName": "Monahan, Zulauf and McClure",
    "Deleted": true,
    "EjUserId": 491,
    "UserName": "Kling, Okuneva and Kuhlman",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 294
      }
    }
  },
  "TicketPriority": {
    "Id": 570,
    "Value": "debitis",
    "Tooltip": "quis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "recontextualize sticky supply-chains"
        },
        "FieldType": "System.Int32",
        "FieldLength": 685
      }
    }
  },
  "CustomerLanguage": {
    "Id": 694,
    "Value": "placeat",
    "Tooltip": "illo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 415
      }
    }
  },
  "DbiAgentId": 397,
  "DbiKey": "magni",
  "DbiLastModified": "2002-02-12T16:48:30.0119301+01:00",
  "DbiLastSyncronized": "1997-10-27T16:48:30.0119301+01:00",
  "SentInfo": 608,
  "ShowContactTickets": 311,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 586,
    "UserName": "Kiehn Group",
    "PersonId": 943,
    "Rank": 87,
    "Tooltip": "aperiam",
    "UserGroupId": 450,
    "EjUserId": 599,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "et",
      "quas"
    ],
    "CanLogon": true,
    "RoleName": "Schinner, Conn and Purdy",
    "RoleTooltip": "iusto",
    "UserGroupName": "Reilly LLC",
    "UserGroupTooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 435
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "quibusdam",
      "StrippedValue": "fuga",
      "Description": "Horizontal zero defect process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 964
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "fuga",
      "Description": "Horizontal zero defect process improvement",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 964
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "minima",
      "StrippedValue": "qui",
      "Description": "Object-based zero tolerance database",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "qui",
      "Description": "Object-based zero tolerance database",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    }
  ],
  "Source": 604,
  "ActiveErpLinks": 509,
  "ShipmentTypes": [
    {
      "Id": 150,
      "Name": "Reichel, Hodkiewicz and Berge",
      "ToolTip": "Dicta quis voluptates neque est porro vitae.",
      "Deleted": false,
      "Rank": 135,
      "Type": "doloribus",
      "ColorBlock": 47,
      "IconHint": "odio",
      "Selected": false,
      "LastChanged": "1998-06-18T16:48:30.0119301+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "maxime",
      "StyleHint": "quis",
      "Hidden": true,
      "FullName": "Omari McLaughlin III",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 479
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 376,
      "Comment": "eum",
      "Registered": "2002-05-18T16:48:30.0129241+02:00",
      "RegisteredAssociateId": 685,
      "Updated": "2016-04-30T16:48:30.0129241+02:00",
      "UpdatedAssociateId": 676,
      "LegalBaseId": 696,
      "LegalBaseKey": "aliquam",
      "LegalBaseName": "Jones, Erdman and Carroll",
      "ConsentPurposeId": 802,
      "ConsentPurposeKey": "perferendis",
      "ConsentPurposeName": "Crooks, Schroeder and Halvorson",
      "ConsentSourceId": 142,
      "ConsentSourceKey": "esse",
      "ConsentSourceName": "Reynolds, Wehner and Langworth",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 525
        }
      }
    }
  ],
  "BounceEmails": [
    "eleonore_vandervort@hermistonstokes.us",
    "brigitte@kuhlman.name"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Francis Heller",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "repellat"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "autem"
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
      "FieldLength": 360
    }
  }
}
```