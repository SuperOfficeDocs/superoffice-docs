---
title: POST Agents/Person/GetPersonEntity
id: v1PersonAgent_GetPersonEntity
---

# POST Agents/Person/GetPersonEntity

```http
POST /api/v1/Agents/Person/GetPersonEntity
```

Gets a PersonEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| personEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=179
POST /api/v1/Agents/Person/GetPersonEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 596,
  "Firstname": "Norris",
  "MiddleName": "Mayert, Lubowitz and Abernathy",
  "Lastname": "Wilkinson",
  "Mrmrs": "pariatur",
  "Title": "deserunt",
  "UpdatedDate": "2009-04-18T18:28:49.6360885+02:00",
  "CreatedDate": "1995-02-18T18:28:49.6360885+01:00",
  "BirthDate": "2008-12-23T18:28:49.6360885+01:00",
  "CreatedBy": {
    "AssociateId": 374,
    "Name": "Zulauf, Prohaska and Schmidt",
    "PersonId": 772,
    "Rank": 283,
    "Tooltip": "quia",
    "Type": "AnonymousAssociate",
    "GroupIdx": 32,
    "FullName": "Dovie Crist Jr.",
    "FormalName": "Macejkovic, Carroll and Rippin",
    "Deleted": false,
    "EjUserId": 585,
    "UserName": "Ledner-Lind",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 879
      }
    }
  },
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "iure",
      "Description": "Function-based needs-based website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 934
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "iure",
      "Description": "Function-based needs-based website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 934
        }
      }
    }
  ],
  "Description": "Digitized global database",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "unde",
      "StrippedValue": "est",
      "Description": "Secured attitude-oriented capacity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 993
        }
      }
    },
    {
      "Value": "unde",
      "StrippedValue": "est",
      "Description": "Secured attitude-oriented capacity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 993
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "at",
      "StrippedValue": "blanditiis",
      "Description": "Horizontal even-keeled pricing structure",
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
    {
      "Value": "at",
      "StrippedValue": "blanditiis",
      "Description": "Horizontal even-keeled pricing structure",
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
    }
  ],
  "MobilePhones": [
    {
      "Value": "eum",
      "StrippedValue": "dolorem",
      "Description": "Down-sized neutral system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 332
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "dolorem",
      "Description": "Down-sized neutral system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 332
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "alias",
      "StrippedValue": "recusandae",
      "Description": "Re-contextualized context-sensitive product",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "recusandae",
      "Description": "Re-contextualized context-sensitive product",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quibusdam",
      "StrippedValue": "tempore",
      "Description": "Operative didactic leverage",
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
    {
      "Value": "quibusdam",
      "StrippedValue": "tempore",
      "Description": "Operative didactic leverage",
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
    }
  ],
  "Position": {
    "Id": 171,
    "Value": "sunt",
    "Tooltip": "harum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 295
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 169,
    "Name": "Luettgen-Waelchi",
    "PersonId": 159,
    "Rank": 465,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 628,
    "FullName": "Tressa Bartoletti",
    "FormalName": "Kunde, Schamberger and Bartell",
    "Deleted": false,
    "EjUserId": 158,
    "UserName": "Mills-Champlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "envisioneer next-generation markets"
        },
        "FieldType": "System.Int32",
        "FieldLength": 586
      }
    }
  },
  "Contact": {
    "ContactId": 588,
    "Name": "Nitzsche, Schaden and Balistreri",
    "OrgNr": "1396204",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "sint",
    "DirectPhone": "(788)316-1803",
    "AssociateId": 604,
    "CountryId": 347,
    "EmailAddress": "ladarius@bauch.ca",
    "Kananame": "vel",
    "EmailAddressName": "alvah@rippin.co.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Laverna Lockman",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "accusantium",
    "FullName": "Dr. Mabelle Farrell",
    "IsOwnerContact": true,
    "ActiveErpLinks": 945,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 286
      }
    }
  },
  "Country": {
    "CountryId": 240,
    "Name": "Lindgren, Hartmann and Donnelly",
    "CurrencyId": 336,
    "EnglishName": "Abshire-Skiles",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Phased coherent open system",
    "OrgNrText": "1680676",
    "InterAreaPrefix": "expedita",
    "DialInPrefix": "non",
    "ZipPrefix": "qui",
    "DomainName": "Schinner-Schaefer",
    "AddressLayoutId": 321,
    "DomesticAddressLayoutId": 229,
    "ForeignAddressLayoutId": 774,
    "Rank": 43,
    "Tooltip": "facere",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 785
      }
    }
  },
  "Interests": [
    {
      "Id": 808,
      "Name": "Dietrich, Ziemann and Wilderman",
      "ToolTip": "Voluptatem deserunt porro non fugiat eum.",
      "Deleted": true,
      "Rank": 744,
      "Type": "atque",
      "ColorBlock": 64,
      "IconHint": "error",
      "Selected": false,
      "LastChanged": "1999-10-31T18:28:49.6390884+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "adipisci",
      "StyleHint": "odit",
      "Hidden": true,
      "FullName": "Luella Fritsch",
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
    }
  ],
  "PersonNumber": "1091541",
  "FullName": "Jalon Torphy",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "beatae",
      "StrippedValue": "atque",
      "Description": "Switchable object-oriented encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 876
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "atque",
      "Description": "Switchable object-oriented encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 876
        }
      }
    }
  ],
  "FormalName": "Leannon Group",
  "Address": {
    "Wgs84Latitude": 11404.626,
    "Wgs84Longitude": 23981.368,
    "LocalizedAddress": [
      [
        {
          "Name": "Torphy, Ledner and Hirthe",
          "Value": "laboriosam",
          "Tooltip": "qui",
          "Label": "voluptates",
          "ValueLength": 55,
          "AddressType": "quis",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "morph ubiquitous action-items"
              },
              "FieldType": "System.String",
              "FieldLength": 741
            }
          }
        }
      ],
      [
        {
          "Name": "Predovic Group",
          "Value": "maiores",
          "Tooltip": "facere",
          "Label": "hic",
          "ValueLength": 15,
          "AddressType": "tempora",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "integrate real-time mindshare"
              },
              "FieldType": "System.String",
              "FieldLength": 215
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "cum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 227
      }
    }
  },
  "Post3": "a",
  "Post2": "illo",
  "Post1": "ratione",
  "Kanalname": "fuga",
  "Kanafname": "vel",
  "CorrespondingAssociate": {
    "AssociateId": 274,
    "Name": "Hintz-Simonis",
    "PersonId": 770,
    "Rank": 961,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 529,
    "FullName": "Jarred Aufderhar I",
    "FormalName": "Murazik-Muller",
    "Deleted": false,
    "EjUserId": 331,
    "UserName": "Hauck Group",
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
  "Category": {
    "Id": 705,
    "Value": "id",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 778
      }
    }
  },
  "Business": {
    "Id": 189,
    "Value": "neque",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 720
      }
    }
  },
  "Associate": {
    "AssociateId": 53,
    "Name": "Weimann, Bahringer and Parisian",
    "PersonId": 377,
    "Rank": 520,
    "Tooltip": "exercitationem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 44,
    "FullName": "Lia Murphy",
    "FormalName": "Fadel-Gaylord",
    "Deleted": true,
    "EjUserId": 170,
    "UserName": "Gislason, Schmeler and Funk",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 267
      }
    }
  },
  "Salutation": "beatae",
  "ActiveInterests": 358,
  "SupportAssociate": {
    "AssociateId": 387,
    "Name": "Orn-Aufderhar",
    "PersonId": 695,
    "Rank": 530,
    "Tooltip": "soluta",
    "Type": "AnonymousAssociate",
    "GroupIdx": 362,
    "FullName": "Keagan Bode",
    "FormalName": "Okuneva-Hessel",
    "Deleted": false,
    "EjUserId": 733,
    "UserName": "Erdman, Rau and Lowe",
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
  "TicketPriority": {
    "Id": 622,
    "Value": "in",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 424
      }
    }
  },
  "CustomerLanguage": {
    "Id": 459,
    "Value": "mollitia",
    "Tooltip": "eveniet",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 810
      }
    }
  },
  "DbiAgentId": 420,
  "DbiKey": "porro",
  "DbiLastModified": "1998-10-26T18:28:49.642087+01:00",
  "DbiLastSyncronized": "2003-12-09T18:28:49.642087+01:00",
  "SentInfo": 88,
  "ShowContactTickets": 620,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 725,
    "UserName": "Nikolaus, Skiles and Abbott",
    "PersonId": 459,
    "Rank": 569,
    "Tooltip": "voluptates",
    "UserGroupId": 982,
    "EjUserId": 107,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "quas",
      "qui"
    ],
    "CanLogon": false,
    "RoleName": "Morar Group",
    "RoleTooltip": "voluptas",
    "UserGroupName": "Connelly-Rodriguez",
    "UserGroupTooltip": "autem",
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
  "ChatEmails": [
    {
      "Value": "officiis",
      "StrippedValue": "suscipit",
      "Description": "Right-sized disintermediate matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "suscipit",
      "Description": "Right-sized disintermediate matrices",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 498
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "rerum",
      "StrippedValue": "sit",
      "Description": "Optional uniform product",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "sit",
      "Description": "Optional uniform product",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 473
        }
      }
    }
  ],
  "Source": 648,
  "ActiveErpLinks": 740,
  "ShipmentTypes": [
    {
      "Id": 883,
      "Name": "Kunze Inc and Sons",
      "ToolTip": "Nam qui et.",
      "Deleted": true,
      "Rank": 14,
      "Type": "repudiandae",
      "ColorBlock": 676,
      "IconHint": "dolorem",
      "Selected": false,
      "LastChanged": "2010-12-07T18:28:49.642087+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "ullam",
      "Hidden": false,
      "FullName": "Marcelo Reinger",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 963
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 925,
      "Comment": "sit",
      "Registered": "2015-09-23T18:28:49.642087+02:00",
      "RegisteredAssociateId": 839,
      "Updated": "2009-07-06T18:28:49.642087+02:00",
      "UpdatedAssociateId": 506,
      "LegalBaseId": 802,
      "LegalBaseKey": "incidunt",
      "LegalBaseName": "DuBuque-McLaughlin",
      "ConsentPurposeId": 859,
      "ConsentPurposeKey": "at",
      "ConsentPurposeName": "Tillman Group",
      "ConsentSourceId": 610,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Corkery, Prosacco and Kertzmann",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 362
        }
      }
    }
  ],
  "BounceEmails": [
    "paolo@welch.ca",
    "rodrick_ondricka@tromp.biz"
  ],
  "ActiveStatusMonitorId": 739,
  "UserDefinedFields": {
    "SuperOffice:1": "Raul Mueller",
    "SuperOffice:2": "289131751"
  },
  "ExtraFields": {
    "ExtraFields1": "incidunt",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "cupiditate",
    "CustomFields2": "nihil"
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
      "FieldLength": 354
    }
  }
}
```