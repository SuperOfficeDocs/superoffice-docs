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
Last-Modified: Sat, 21 Mar 2020 15:05:42 G3T

{
  "PersonId": 172,
  "Firstname": "Connor",
  "MiddleName": "Little, Labadie and O'Keefe",
  "Lastname": "Graham",
  "Mrmrs": "non",
  "Title": "impedit",
  "UpdatedDate": "2020-03-21T15:05:42.2676681+01:00",
  "CreatedDate": "2000-11-30T15:05:42.2676681+01:00",
  "BirthDate": "2005-06-07T15:05:42.2676681+02:00",
  "CreatedBy": {
    "AssociateId": 360,
    "Name": "Christiansen-McCullough",
    "PersonId": 932,
    "Rank": 387,
    "Tooltip": "incidunt",
    "Type": "AnonymousAssociate",
    "GroupIdx": 829,
    "FullName": "Loyal Simonis DDS",
    "FormalName": "Bartell, Hagenes and Bayer",
    "Deleted": false,
    "EjUserId": 756,
    "UserName": "Bahringer-Stark",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 737
      }
    }
  },
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "ipsa",
      "Description": "Multi-lateral neutral contingency",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 994
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ipsa",
      "Description": "Multi-lateral neutral contingency",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 994
        }
      }
    }
  ],
  "Description": "Robust client-driven strategy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "maiores",
      "StrippedValue": "accusamus",
      "Description": "Stand-alone incremental system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 163
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "accusamus",
      "Description": "Stand-alone incremental system engine",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 163
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "accusantium",
      "StrippedValue": "et",
      "Description": "Up-sized 24/7 synergy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 323
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "et",
      "Description": "Up-sized 24/7 synergy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 323
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "id",
      "Description": "Enhanced holistic Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 885
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "id",
      "Description": "Enhanced holistic Graphical User Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 885
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "est",
      "StrippedValue": "saepe",
      "Description": "Reactive client-server conglomeration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "deliver dynamic e-tailers"
          },
          "FieldType": "System.String",
          "FieldLength": 199
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "saepe",
      "Description": "Reactive client-server conglomeration",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "deliver dynamic e-tailers"
          },
          "FieldType": "System.String",
          "FieldLength": 199
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "id",
      "StrippedValue": "reiciendis",
      "Description": "Synchronised incremental Graphic Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "reinvent back-end functionalities"
          },
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "reiciendis",
      "Description": "Synchronised incremental Graphic Interface",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "reinvent back-end functionalities"
          },
          "FieldType": "System.Int32",
          "FieldLength": 290
        }
      }
    }
  ],
  "Position": {
    "Id": 458,
    "Value": "et",
    "Tooltip": "dignissimos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 633
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 33,
    "Name": "Rice LLC",
    "PersonId": 859,
    "Rank": 500,
    "Tooltip": "voluptate",
    "Type": "AnonymousAssociate",
    "GroupIdx": 255,
    "FullName": "Alberto Rice",
    "FormalName": "Hauck, Jaskolski and Dietrich",
    "Deleted": true,
    "EjUserId": 300,
    "UserName": "Ortiz-Hermann",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 161
      }
    }
  },
  "Contact": {
    "ContactId": 38,
    "Name": "Wyman, Steuber and Marks",
    "OrgNr": "1274396",
    "Department": "reintermediate open-source infrastructures",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "270-672-6328 x25018",
    "AssociateId": 678,
    "CountryId": 533,
    "EmailAddress": "jo_koch@jones.ca",
    "Kananame": "et",
    "EmailAddressName": "marcelino@braun.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Shania Greenholt Sr.",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nam",
    "FullName": "Martine Nienow",
    "IsOwnerContact": false,
    "ActiveErpLinks": 609,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 147
      }
    }
  },
  "Country": {
    "CountryId": 981,
    "Name": "Herman LLC",
    "CurrencyId": 845,
    "EnglishName": "Kerluke-Hettinger",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Mandatory zero defect complexity",
    "OrgNrText": "812509",
    "InterAreaPrefix": "laborum",
    "DialInPrefix": "ratione",
    "ZipPrefix": "harum",
    "DomainName": "Bode, Hoeger and Johnston",
    "AddressLayoutId": 613,
    "DomesticAddressLayoutId": 840,
    "ForeignAddressLayoutId": 261,
    "Rank": 775,
    "Tooltip": "molestiae",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 484
      }
    }
  },
  "Interests": [
    {
      "Id": 98,
      "Name": "Watsica-Langworth",
      "ToolTip": "Odit est.",
      "Deleted": false,
      "Rank": 857,
      "Type": "sapiente",
      "ColorBlock": 948,
      "IconHint": "esse",
      "Selected": true,
      "LastChanged": "2013-08-15T15:05:42.2696625+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "ad",
      "Hidden": true,
      "FullName": "Michel Robel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 208
        }
      }
    }
  ],
  "PersonNumber": "1360983",
  "FullName": "Doug Kiehn V",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "deserunt",
      "StrippedValue": "modi",
      "Description": "Organic intangible encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 358
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "modi",
      "Description": "Organic intangible encryption",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 358
        }
      }
    }
  ],
  "FormalName": "Collins LLC",
  "Address": {
    "Wgs84Latitude": 15735.814,
    "Wgs84Longitude": 26914.791999999998,
    "LocalizedAddress": [
      [
        {
          "Name": "Johns, Kunze and Schultz",
          "Value": "voluptas",
          "Tooltip": "excepturi",
          "Label": "culpa",
          "ValueLength": 431,
          "AddressType": "nobis",
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
              "FieldLength": 835
            }
          }
        }
      ],
      [
        {
          "Name": "Lemke-Becker",
          "Value": "quasi",
          "Tooltip": "sunt",
          "Label": "libero",
          "ValueLength": 237,
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
              "FieldLength": 678
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "in",
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
  "Post3": "explicabo",
  "Post2": "delectus",
  "Post1": "sit",
  "Kanalname": "quaerat",
  "Kanafname": "porro",
  "CorrespondingAssociate": {
    "AssociateId": 851,
    "Name": "Welch Group",
    "PersonId": 429,
    "Rank": 402,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 278,
    "FullName": "Osbaldo Lueilwitz",
    "FormalName": "Gleichner Inc and Sons",
    "Deleted": false,
    "EjUserId": 565,
    "UserName": "Wilderman, Wisozk and Mayert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 976
      }
    }
  },
  "Category": {
    "Id": 992,
    "Value": "totam",
    "Tooltip": "sed",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 892
      }
    }
  },
  "Business": {
    "Id": 94,
    "Value": "enim",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 739
      }
    }
  },
  "Associate": {
    "AssociateId": 88,
    "Name": "Lind Inc and Sons",
    "PersonId": 698,
    "Rank": 333,
    "Tooltip": "omnis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 659,
    "FullName": "Donna Schmitt",
    "FormalName": "Jakubowski-Kirlin",
    "Deleted": true,
    "EjUserId": 980,
    "UserName": "Hickle-Crona",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 250
      }
    }
  },
  "Salutation": "natus",
  "ActiveInterests": 268,
  "SupportAssociate": {
    "AssociateId": 316,
    "Name": "Kreiger, Anderson and Herman",
    "PersonId": 785,
    "Rank": 316,
    "Tooltip": "iusto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 430,
    "FullName": "Roel Mann Sr.",
    "FormalName": "Jaskolski-Mosciski",
    "Deleted": true,
    "EjUserId": 957,
    "UserName": "Schinner, Klein and Kuhn",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 265
      }
    }
  },
  "TicketPriority": {
    "Id": 617,
    "Value": "aperiam",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 178
      }
    }
  },
  "CustomerLanguage": {
    "Id": 739,
    "Value": "voluptatem",
    "Tooltip": "aspernatur",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 303
      }
    }
  },
  "DbiAgentId": 530,
  "DbiKey": "distinctio",
  "DbiLastModified": "2020-02-18T15:05:42.2736623+01:00",
  "DbiLastSyncronized": "1994-07-03T15:05:42.2736623+02:00",
  "SentInfo": 631,
  "ShowContactTickets": 887,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 402,
    "UserName": "Hermiston-Yundt",
    "PersonId": 495,
    "Rank": 497,
    "Tooltip": "ab",
    "UserGroupId": 695,
    "EjUserId": 295,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "commodi",
      "voluptas"
    ],
    "CanLogon": true,
    "RoleName": "Ortiz-Prohaska",
    "RoleTooltip": "est",
    "UserGroupName": "Sanford, Rolfson and Welch",
    "UserGroupTooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 151
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "quidem",
      "StrippedValue": "reiciendis",
      "Description": "Re-contextualized fresh-thinking collaboration",
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
    {
      "Value": "quidem",
      "StrippedValue": "reiciendis",
      "Description": "Re-contextualized fresh-thinking collaboration",
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
    }
  ],
  "InternetPhones": [
    {
      "Value": "est",
      "StrippedValue": "facilis",
      "Description": "Upgradable actuating data-warehouse",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "facilis",
      "Description": "Upgradable actuating data-warehouse",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 930
        }
      }
    }
  ],
  "Source": 618,
  "ActiveErpLinks": 879,
  "ShipmentTypes": [
    {
      "Id": 633,
      "Name": "Moen, Bayer and Goodwin",
      "ToolTip": "Non ducimus.",
      "Deleted": true,
      "Rank": 146,
      "Type": "enim",
      "ColorBlock": 198,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2017-01-25T15:05:42.2736623+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minima",
      "StyleHint": "unde",
      "Hidden": true,
      "FullName": "Miss Elisabeth Goyette",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 861
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 828,
      "Comment": "sit",
      "Registered": "2013-09-09T15:05:42.2736623+02:00",
      "RegisteredAssociateId": 347,
      "Updated": "1994-10-20T15:05:42.2736623+02:00",
      "UpdatedAssociateId": 802,
      "LegalBaseId": 146,
      "LegalBaseKey": "aliquam",
      "LegalBaseName": "Rempel-Gleichner",
      "ConsentPurposeId": 583,
      "ConsentPurposeKey": "quis",
      "ConsentPurposeName": "McDermott, O'Keefe and Gorczany",
      "ConsentSourceId": 533,
      "ConsentSourceKey": "est",
      "ConsentSourceName": "Harber Inc and Sons",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 996
        }
      }
    }
  ],
  "BounceEmails": [
    "jayme.goodwin@schaden.name",
    "lisa@bailey.co.uk"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Tyshawn Ward",
    "SuperOffice:2": "1452945688"
  },
  "ExtraFields": {
    "ExtraFields1": "veritatis",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "at",
    "CustomFields2": "beatae"
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
      "FieldLength": 124
    }
  }
}
```