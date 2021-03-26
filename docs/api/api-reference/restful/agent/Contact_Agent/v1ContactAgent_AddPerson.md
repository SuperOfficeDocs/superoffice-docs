---
title: POST Agents/Contact/AddPerson
id: v1ContactAgent_AddPerson
---

# POST Agents/Contact/AddPerson

```http
POST /api/v1/Agents/Contact/AddPerson
```

Add a person to the given contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/AddPerson?$select=name,department,category/id
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

ContactId, NewPersonEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| NewPersonEntity |  |  |


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
POST /api/v1/Agents/Contact/AddPerson
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 723,
  "NewPersonEntity": {
    "PersonId": 299,
    "Firstname": "Alan",
    "MiddleName": "Walter, Gutmann and Moen",
    "Lastname": "Reilly",
    "Mrmrs": "tenetur",
    "Title": "assumenda",
    "UpdatedDate": "1996-01-13T16:48:29.1708946+01:00",
    "CreatedDate": "2000-09-29T16:48:29.1708946+02:00",
    "BirthDate": "2009-10-04T16:48:29.1708946+02:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Persistent scalable secured line",
    "IsAssociate": false,
    "PrivatePhones": [
      {},
      {}
    ],
    "Faxes": [
      {},
      {}
    ],
    "MobilePhones": [
      {},
      {}
    ],
    "OfficePhones": [
      {},
      {}
    ],
    "OtherPhones": [
      {},
      {}
    ],
    "Position": {},
    "UpdatedBy": {},
    "Contact": {},
    "Country": {},
    "Interests": [
      {},
      {}
    ],
    "PersonNumber": "1156444",
    "FullName": "Idella Hayes Sr.",
    "NoMailing": true,
    "UsePersonAddress": false,
    "Retired": true,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Murray-Hickle",
    "Address": {},
    "Post3": "inventore",
    "Post2": "maiores",
    "Post1": "laborum",
    "Kanalname": "nisi",
    "Kanafname": "totam",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "pariatur",
    "ActiveInterests": 676,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 57,
    "DbiKey": "voluptatem",
    "DbiLastModified": "2004-01-02T16:48:29.1708946+01:00",
    "DbiLastSyncronized": "1997-07-03T16:48:29.1708946+02:00",
    "SentInfo": 505,
    "ShowContactTickets": 210,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 809,
    "ActiveErpLinks": 776,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "gennaro@stiedemannparisian.info",
      "lucius.beier@mcglynn.uk"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "Arely Kris",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "voluptas",
      "ExtraFields2": "sint"
    },
    "CustomFields": {
      "CustomFields1": "aperiam",
      "CustomFields2": "neque"
    }
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 101,
  "Firstname": "Saul",
  "MiddleName": "Bashirian-McKenzie",
  "Lastname": "Green",
  "Mrmrs": "sed",
  "Title": "laboriosam",
  "UpdatedDate": "2008-09-12T16:48:29.1798948+02:00",
  "CreatedDate": "2008-01-05T16:48:29.1798948+01:00",
  "BirthDate": "2012-12-19T16:48:29.1798948+01:00",
  "CreatedBy": {
    "AssociateId": 36,
    "Name": "Bayer, Klein and Stanton",
    "PersonId": 651,
    "Rank": 593,
    "Tooltip": "neque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 949,
    "FullName": "Emmet Grant",
    "FormalName": "Kertzmann-Flatley",
    "Deleted": false,
    "EjUserId": 18,
    "UserName": "Crooks-Bradtke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "productize efficient experiences"
        },
        "FieldType": "System.Int32",
        "FieldLength": 183
      }
    }
  },
  "Emails": [
    {
      "Value": "possimus",
      "StrippedValue": "est",
      "Description": "Universal actuating help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "implement killer systems"
          },
          "FieldType": "System.Int32",
          "FieldLength": 939
        }
      }
    },
    {
      "Value": "possimus",
      "StrippedValue": "est",
      "Description": "Universal actuating help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "implement killer systems"
          },
          "FieldType": "System.Int32",
          "FieldLength": 939
        }
      }
    }
  ],
  "Description": "Fundamental hybrid product",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "non",
      "Description": "Open-architected grid-enabled website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "non",
      "Description": "Open-architected grid-enabled website",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 910
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quis",
      "StrippedValue": "sunt",
      "Description": "Ergonomic secondary productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 226
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "sunt",
      "Description": "Ergonomic secondary productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 226
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "a",
      "StrippedValue": "illum",
      "Description": "Persistent systematic projection",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 188
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "illum",
      "Description": "Persistent systematic projection",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 188
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "hic",
      "StrippedValue": "esse",
      "Description": "Customer-focused content-based analyzer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "esse",
      "Description": "Customer-focused content-based analyzer",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 96
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "quisquam",
      "Description": "Business-focused attitude-oriented attitude",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quisquam",
      "Description": "Business-focused attitude-oriented attitude",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    }
  ],
  "Position": {
    "Id": 779,
    "Value": "aut",
    "Tooltip": "optio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "monetize integrated markets"
        },
        "FieldType": "System.Int32",
        "FieldLength": 304
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 996,
    "Name": "Marquardt, Shields and Parisian",
    "PersonId": 540,
    "Rank": 410,
    "Tooltip": "dolorum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 76,
    "FullName": "Iva Bradtke",
    "FormalName": "Schaefer, Price and Baumbach",
    "Deleted": false,
    "EjUserId": 588,
    "UserName": "Johnston Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 543
      }
    }
  },
  "Contact": {
    "ContactId": 208,
    "Name": "Kihn-Hessel",
    "OrgNr": "307886",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "ut",
    "DirectPhone": "(230)502-6635 x583",
    "AssociateId": 635,
    "CountryId": 728,
    "EmailAddress": "marvin@marks.uk",
    "Kananame": "est",
    "EmailAddressName": "colt_daniel@berge.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Elbert Johnson",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "soluta",
    "FullName": "Vernon Dare",
    "IsOwnerContact": true,
    "ActiveErpLinks": 386,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 247
      }
    }
  },
  "Country": {
    "CountryId": 161,
    "Name": "Nicolas, Murphy and Moen",
    "CurrencyId": 106,
    "EnglishName": "Huels Inc and Sons",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Business-focused regional adapter",
    "OrgNrText": "1007125",
    "InterAreaPrefix": "tenetur",
    "DialInPrefix": "quia",
    "ZipPrefix": "modi",
    "DomainName": "Bayer Inc and Sons",
    "AddressLayoutId": 127,
    "DomesticAddressLayoutId": 704,
    "ForeignAddressLayoutId": 743,
    "Rank": 287,
    "Tooltip": "sunt",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 958
      }
    }
  },
  "Interests": [
    {
      "Id": 371,
      "Name": "Boyer-Keeling",
      "ToolTip": "Repellat modi sint numquam.",
      "Deleted": true,
      "Rank": 811,
      "Type": "excepturi",
      "ColorBlock": 388,
      "IconHint": "provident",
      "Selected": false,
      "LastChanged": "1997-05-21T16:48:29.1818945+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quisquam",
      "StyleHint": "fugit",
      "Hidden": false,
      "FullName": "Tiffany Streich",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    }
  ],
  "PersonNumber": "555920",
  "FullName": "Javon Douglas",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "iste",
      "StrippedValue": "sed",
      "Description": "Streamlined systematic extranet",
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
    {
      "Value": "iste",
      "StrippedValue": "sed",
      "Description": "Streamlined systematic extranet",
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
    }
  ],
  "FormalName": "Hermiston-Corwin",
  "Address": {
    "Wgs84Latitude": 14244.029999999999,
    "Wgs84Longitude": 10505.168,
    "LocalizedAddress": [
      [
        {
          "Name": "Gaylord, Runolfsdottir and McDermott",
          "Value": "dolorum",
          "Tooltip": "totam",
          "Label": "dolorem",
          "ValueLength": 319,
          "AddressType": "eligendi",
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
              "FieldLength": 35
            }
          }
        }
      ],
      [
        {
          "Name": "Reichel LLC",
          "Value": "quod",
          "Tooltip": "rerum",
          "Label": "et",
          "ValueLength": 464,
          "AddressType": "est",
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
              "FieldLength": 949
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "assumenda",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 330
      }
    }
  },
  "Post3": "ut",
  "Post2": "ut",
  "Post1": "quo",
  "Kanalname": "rerum",
  "Kanafname": "sed",
  "CorrespondingAssociate": {
    "AssociateId": 190,
    "Name": "Breitenberg-Wiza",
    "PersonId": 23,
    "Rank": 395,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 5,
    "FullName": "Jayce Kautzer",
    "FormalName": "Berge Inc and Sons",
    "Deleted": true,
    "EjUserId": 445,
    "UserName": "Nader-Schumm",
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
  "Category": {
    "Id": 205,
    "Value": "sed",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 772
      }
    }
  },
  "Business": {
    "Id": 874,
    "Value": "est",
    "Tooltip": "molestiae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "architect leading-edge relationships"
        },
        "FieldType": "System.String",
        "FieldLength": 185
      }
    }
  },
  "Associate": {
    "AssociateId": 110,
    "Name": "Graham, Terry and Kozey",
    "PersonId": 462,
    "Rank": 488,
    "Tooltip": "ullam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 432,
    "FullName": "Filiberto Schumm",
    "FormalName": "Bogisich LLC",
    "Deleted": true,
    "EjUserId": 445,
    "UserName": "Rogahn-Okuneva",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 267
      }
    }
  },
  "Salutation": "occaecati",
  "ActiveInterests": 490,
  "SupportAssociate": {
    "AssociateId": 588,
    "Name": "O'Keefe, Koch and Kemmer",
    "PersonId": 96,
    "Rank": 380,
    "Tooltip": "similique",
    "Type": "AnonymousAssociate",
    "GroupIdx": 100,
    "FullName": "Hal Koss",
    "FormalName": "McDermott-Simonis",
    "Deleted": false,
    "EjUserId": 108,
    "UserName": "Beer-Pfeffer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "morph magnetic content"
        },
        "FieldType": "System.Int32",
        "FieldLength": 241
      }
    }
  },
  "TicketPriority": {
    "Id": 168,
    "Value": "earum",
    "Tooltip": "fugiat",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 320
      }
    }
  },
  "CustomerLanguage": {
    "Id": 920,
    "Value": "nulla",
    "Tooltip": "aut",
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
  "DbiAgentId": 189,
  "DbiKey": "laudantium",
  "DbiLastModified": "1997-02-19T16:48:29.1848947+01:00",
  "DbiLastSyncronized": "2003-07-02T16:48:29.1848947+02:00",
  "SentInfo": 412,
  "ShowContactTickets": 864,
  "UserInfo": {
    "Deleted": true,
    "UserInfoId": 899,
    "UserName": "Mante, Dickinson and Abbott",
    "PersonId": 646,
    "Rank": 947,
    "Tooltip": "in",
    "UserGroupId": 525,
    "EjUserId": 157,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "possimus",
      "consequatur"
    ],
    "CanLogon": false,
    "RoleName": "Homenick, Schroeder and Emmerich",
    "RoleTooltip": "maxime",
    "UserGroupName": "Bayer, Boyer and Gibson",
    "UserGroupTooltip": "omnis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 107
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "illum",
      "StrippedValue": "quia",
      "Description": "Cross-platform uniform architecture",
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
    {
      "Value": "illum",
      "StrippedValue": "quia",
      "Description": "Cross-platform uniform architecture",
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
    }
  ],
  "InternetPhones": [
    {
      "Value": "vel",
      "StrippedValue": "et",
      "Description": "Re-engineered multimedia framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 213
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "et",
      "Description": "Re-engineered multimedia framework",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 213
        }
      }
    }
  ],
  "Source": 185,
  "ActiveErpLinks": 960,
  "ShipmentTypes": [
    {
      "Id": 828,
      "Name": "Turner LLC",
      "ToolTip": "Incidunt fugit sapiente.",
      "Deleted": false,
      "Rank": 305,
      "Type": "earum",
      "ColorBlock": 225,
      "IconHint": "iure",
      "Selected": false,
      "LastChanged": "2012-11-24T16:48:29.1848947+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "reprehenderit",
      "StyleHint": "hic",
      "Hidden": false,
      "FullName": "Esta Sipes PhD",
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
  "Consents": [
    {
      "ConsentPersonId": 56,
      "Comment": "harum",
      "Registered": "1997-07-23T16:48:29.1858944+02:00",
      "RegisteredAssociateId": 382,
      "Updated": "1994-06-07T16:48:29.1858944+02:00",
      "UpdatedAssociateId": 16,
      "LegalBaseId": 700,
      "LegalBaseKey": "mollitia",
      "LegalBaseName": "Skiles-Mann",
      "ConsentPurposeId": 511,
      "ConsentPurposeKey": "corrupti",
      "ConsentPurposeName": "Beatty-Wunsch",
      "ConsentSourceId": 168,
      "ConsentSourceKey": "eos",
      "ConsentSourceName": "Baumbach, Adams and Goodwin",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 392
        }
      }
    }
  ],
  "BounceEmails": [
    "cleveland@carterfriesen.name",
    "florine@jaskolski.ca"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Bettie Yost",
    "SuperOffice:2": "Gladyce Blanda"
  },
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "repudiandae"
  },
  "CustomFields": {
    "CustomFields1": "officia",
    "CustomFields2": "odit"
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
      "FieldLength": 266
    }
  }
}
```