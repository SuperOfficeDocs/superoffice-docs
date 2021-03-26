---
title: POST Agents/Person/GetSalesRep
id: v1PersonAgent_GetSalesRep
---

# POST Agents/Person/GetSalesRep

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
  "ContactName": "Bins, Crona and McKenzie",
  "PersonFirstname": "Iliana",
  "PersonLastname": "Prosacco",
  "EmailAddress": "hilbert@lakin.uk",
  "PhoneNumber": "976725"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 211,
  "Firstname": "Josue",
  "MiddleName": "Murphy Inc and Sons",
  "Lastname": "Schmitt",
  "Mrmrs": "adipisci",
  "Title": "quis",
  "UpdatedDate": "2004-08-24T16:48:30.1299344+02:00",
  "CreatedDate": "1995-01-06T16:48:30.1299344+01:00",
  "BirthDate": "2014-09-05T16:48:30.1299344+02:00",
  "CreatedBy": {
    "AssociateId": 817,
    "Name": "Littel, Halvorson and D'Amore",
    "PersonId": 629,
    "Rank": 944,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 171,
    "FullName": "Tara VonRueden",
    "FormalName": "Russel LLC",
    "Deleted": false,
    "EjUserId": 262,
    "UserName": "Pfannerstill Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 104
      }
    }
  },
  "Emails": [
    {
      "Value": "optio",
      "StrippedValue": "possimus",
      "Description": "Operative hybrid definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 596
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "possimus",
      "Description": "Operative hybrid definition",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 596
        }
      }
    }
  ],
  "Description": "Public-key content-based methodology",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "veritatis",
      "Description": "Grass-roots asynchronous structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 585
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "veritatis",
      "Description": "Grass-roots asynchronous structure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 585
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vero",
      "StrippedValue": "reiciendis",
      "Description": "Face to face transitional leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enhance efficient e-business"
          },
          "FieldType": "System.Int32",
          "FieldLength": 675
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "reiciendis",
      "Description": "Face to face transitional leverage",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "enhance efficient e-business"
          },
          "FieldType": "System.Int32",
          "FieldLength": 675
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quo",
      "StrippedValue": "voluptatem",
      "Description": "Devolved zero administration knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "cultivate B2B metrics"
          },
          "FieldType": "System.String",
          "FieldLength": 382
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "voluptatem",
      "Description": "Devolved zero administration knowledge user",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "cultivate B2B metrics"
          },
          "FieldType": "System.String",
          "FieldLength": 382
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "culpa",
      "StrippedValue": "aperiam",
      "Description": "Pre-emptive web-enabled capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "aperiam",
      "Description": "Pre-emptive web-enabled capability",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 856
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "aspernatur",
      "StrippedValue": "qui",
      "Description": "Re-contextualized cohesive moderator",
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
      "Value": "aspernatur",
      "StrippedValue": "qui",
      "Description": "Re-contextualized cohesive moderator",
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
  "Position": {
    "Id": 351,
    "Value": "et",
    "Tooltip": "aperiam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 696
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 399,
    "Name": "Doyle Inc and Sons",
    "PersonId": 583,
    "Rank": 708,
    "Tooltip": "ad",
    "Type": "AnonymousAssociate",
    "GroupIdx": 523,
    "FullName": "Annabel Champlin",
    "FormalName": "Kuhic Group",
    "Deleted": true,
    "EjUserId": 198,
    "UserName": "Rath-Murphy",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 634
      }
    }
  },
  "Contact": {
    "ContactId": 232,
    "Name": "Schamberger-Kohler",
    "OrgNr": "1371744",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quo",
    "DirectPhone": "(380)706-3276 x218",
    "AssociateId": 758,
    "CountryId": 284,
    "EmailAddress": "jesus.walker@bednar.com",
    "Kananame": "aliquid",
    "EmailAddressName": "name@heidenreich.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Melody Casper",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "enim",
    "FullName": "Gloria Bashirian",
    "IsOwnerContact": true,
    "ActiveErpLinks": 63,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 10
      }
    }
  },
  "Country": {
    "CountryId": 430,
    "Name": "Denesik Inc and Sons",
    "CurrencyId": 956,
    "EnglishName": "Borer-Oberbrunner",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Intuitive contextually-based paradigm",
    "OrgNrText": "1200545",
    "InterAreaPrefix": "recusandae",
    "DialInPrefix": "non",
    "ZipPrefix": "necessitatibus",
    "DomainName": "Schoen Inc and Sons",
    "AddressLayoutId": 635,
    "DomesticAddressLayoutId": 305,
    "ForeignAddressLayoutId": 384,
    "Rank": 174,
    "Tooltip": "rerum",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 108
      }
    }
  },
  "Interests": [
    {
      "Id": 343,
      "Name": "Quigley, Mraz and Bogisich",
      "ToolTip": "Et delectus.",
      "Deleted": false,
      "Rank": 310,
      "Type": "quaerat",
      "ColorBlock": 593,
      "IconHint": "nobis",
      "Selected": true,
      "LastChanged": "2002-08-05T16:48:30.1319362+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "veritatis",
      "Hidden": true,
      "FullName": "Grayson Thompson PhD",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 835
        }
      }
    }
  ],
  "PersonNumber": "827237",
  "FullName": "Kim Daugherty",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "nobis",
      "StrippedValue": "nostrum",
      "Description": "Assimilated web-enabled portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 236
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "nostrum",
      "Description": "Assimilated web-enabled portal",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 236
        }
      }
    }
  ],
  "FormalName": "Cole, Stracke and Goyette",
  "Address": {
    "Wgs84Latitude": 17381.164,
    "Wgs84Longitude": 1375.826,
    "LocalizedAddress": [
      [
        {
          "Name": "Quitzon Inc and Sons",
          "Value": "quia",
          "Tooltip": "aperiam",
          "Label": "recusandae",
          "ValueLength": 905,
          "AddressType": "laudantium",
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
              "FieldLength": 292
            }
          }
        }
      ],
      [
        {
          "Name": "Wolff, Runte and Cummerata",
          "Value": "expedita",
          "Tooltip": "sunt",
          "Label": "incidunt",
          "ValueLength": 424,
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
              "FieldType": "System.Int32",
              "FieldLength": 920
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "quidem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 103
      }
    }
  },
  "Post3": "ad",
  "Post2": "est",
  "Post1": "iure",
  "Kanalname": "in",
  "Kanafname": "dignissimos",
  "CorrespondingAssociate": {
    "AssociateId": 578,
    "Name": "Wiza LLC",
    "PersonId": 653,
    "Rank": 904,
    "Tooltip": "repudiandae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 339,
    "FullName": "Francis Hansen I",
    "FormalName": "McLaughlin-Reichert",
    "Deleted": false,
    "EjUserId": 526,
    "UserName": "Kub-Mraz",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 384
      }
    }
  },
  "Category": {
    "Id": 259,
    "Value": "soluta",
    "Tooltip": "occaecati",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 668
      }
    }
  },
  "Business": {
    "Id": 258,
    "Value": "fuga",
    "Tooltip": "nemo",
    "TableRight": {},
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
  },
  "Associate": {
    "AssociateId": 869,
    "Name": "West, Herzog and Green",
    "PersonId": 145,
    "Rank": 666,
    "Tooltip": "debitis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 957,
    "FullName": "Alfreda Upton",
    "FormalName": "Gleichner-Nolan",
    "Deleted": false,
    "EjUserId": 234,
    "UserName": "Schuppe, Waters and Huel",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 527
      }
    }
  },
  "Salutation": "eligendi",
  "ActiveInterests": 220,
  "SupportAssociate": {
    "AssociateId": 138,
    "Name": "Bergstrom Inc and Sons",
    "PersonId": 198,
    "Rank": 473,
    "Tooltip": "eveniet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 540,
    "FullName": "Kiley Jones Jr.",
    "FormalName": "Rath, Erdman and Crona",
    "Deleted": true,
    "EjUserId": 999,
    "UserName": "Rau-Durgan",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 296
      }
    }
  },
  "TicketPriority": {
    "Id": 317,
    "Value": "inventore",
    "Tooltip": "similique",
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
  },
  "CustomerLanguage": {
    "Id": 890,
    "Value": "quo",
    "Tooltip": "fugiat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 776
      }
    }
  },
  "DbiAgentId": 246,
  "DbiKey": "nisi",
  "DbiLastModified": "1996-12-08T16:48:30.1359342+01:00",
  "DbiLastSyncronized": "1998-02-27T16:48:30.1359342+01:00",
  "SentInfo": 10,
  "ShowContactTickets": 370,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 697,
    "UserName": "Johnson-Smitham",
    "PersonId": 467,
    "Rank": 670,
    "Tooltip": "quia",
    "UserGroupId": 124,
    "EjUserId": 93,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "laborum",
      "assumenda"
    ],
    "CanLogon": true,
    "RoleName": "Senger, Fahey and Kiehn",
    "RoleTooltip": "dolorem",
    "UserGroupName": "Wehner, Langosh and Shanahan",
    "UserGroupTooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 53
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "possimus",
      "StrippedValue": "aspernatur",
      "Description": "Grass-roots analyzing Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 711
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "aspernatur",
      "Description": "Grass-roots analyzing Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 711
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "vel",
      "StrippedValue": "neque",
      "Description": "Up-sized optimal approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "neque",
      "Description": "Up-sized optimal approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 926
        }
      }
    }
  ],
  "Source": 397,
  "ActiveErpLinks": 532,
  "ShipmentTypes": [
    {
      "Id": 647,
      "Name": "Hane-Nienow",
      "ToolTip": "Fugiat modi eligendi consequuntur repudiandae.",
      "Deleted": false,
      "Rank": 858,
      "Type": "libero",
      "ColorBlock": 911,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "1994-01-29T16:48:30.1369365+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "blanditiis",
      "StyleHint": "consequuntur",
      "Hidden": false,
      "FullName": "Cornelius Pollich",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 271
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 325,
      "Comment": "accusantium",
      "Registered": "2008-10-26T16:48:30.1369365+01:00",
      "RegisteredAssociateId": 877,
      "Updated": "2000-11-11T16:48:30.1369365+01:00",
      "UpdatedAssociateId": 786,
      "LegalBaseId": 789,
      "LegalBaseKey": "totam",
      "LegalBaseName": "Ledner Group",
      "ConsentPurposeId": 101,
      "ConsentPurposeKey": "sequi",
      "ConsentPurposeName": "Cruickshank Inc and Sons",
      "ConsentSourceId": 621,
      "ConsentSourceKey": "recusandae",
      "ConsentSourceName": "Blanda, Howe and Herzog",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 142
        }
      }
    }
  ],
  "BounceEmails": [
    "emmet@nolan.uk",
    "curtis.aufderhar@buckridgehills.us"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1568301299",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "fuga",
    "ExtraFields2": "vitae"
  },
  "CustomFields": {
    "CustomFields1": "reprehenderit",
    "CustomFields2": "est"
  },
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "engineer bleeding-edge supply-chains"
      },
      "FieldType": "System.Int32",
      "FieldLength": 697
    }
  }
}
```