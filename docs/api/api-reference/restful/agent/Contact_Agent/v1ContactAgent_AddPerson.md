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
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
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
  "ContactId": 755,
  "NewPersonEntity": {
    "PersonId": 774,
    "Firstname": "Sabryna",
    "MiddleName": "Harber, Goyette and Marvin",
    "Lastname": "Hickle",
    "Mrmrs": "vero",
    "Title": "sunt",
    "UpdatedDate": "2007-11-13T18:28:48.5869588+01:00",
    "CreatedDate": "2006-11-02T18:28:48.5869588+01:00",
    "BirthDate": "1997-07-24T18:28:48.5869588+02:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Configurable object-oriented moratorium",
    "IsAssociate": true,
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
    "PersonNumber": "889342",
    "FullName": "Bernadine Walker",
    "NoMailing": true,
    "UsePersonAddress": true,
    "Retired": true,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Crona, Osinski and Mann",
    "Address": {},
    "Post3": "voluptates",
    "Post2": "ad",
    "Post1": "quia",
    "Kanalname": "odit",
    "Kanafname": "libero",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "esse",
    "ActiveInterests": 973,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 499,
    "DbiKey": "cum",
    "DbiLastModified": "2019-10-15T18:28:48.5869588+02:00",
    "DbiLastSyncronized": "2006-11-06T18:28:48.5869588+01:00",
    "SentInfo": 295,
    "ShowContactTickets": 1000,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 553,
    "ActiveErpLinks": 76,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "jett.oreilly@parisian.biz",
      "richard@friesen.name"
    ],
    "ActiveStatusMonitorId": 275,
    "UserDefinedFields": {
      "SuperOffice:1": "1680618006",
      "SuperOffice:2": "False"
    },
    "ExtraFields": {
      "ExtraFields1": "sint",
      "ExtraFields2": "dolores"
    },
    "CustomFields": {
      "CustomFields1": "saepe",
      "CustomFields2": "enim"
    }
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 855,
  "Firstname": "Vaughn",
  "MiddleName": "Bashirian Inc and Sons",
  "Lastname": "Gerhold",
  "Mrmrs": "illum",
  "Title": "eos",
  "UpdatedDate": "2004-01-01T18:28:48.5969281+01:00",
  "CreatedDate": "1999-07-08T18:28:48.5969281+02:00",
  "BirthDate": "2001-06-26T18:28:48.5969281+02:00",
  "CreatedBy": {
    "AssociateId": 599,
    "Name": "Heaney, Bahringer and Reichert",
    "PersonId": 594,
    "Rank": 545,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 674,
    "FullName": "Christa Smitham PhD",
    "FormalName": "Jakubowski, Gutmann and Pfeffer",
    "Deleted": true,
    "EjUserId": 203,
    "UserName": "Halvorson, Jacobs and Mohr",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 897
      }
    }
  },
  "Emails": [
    {
      "Value": "molestias",
      "StrippedValue": "non",
      "Description": "Intuitive user-facing alliance",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "non",
      "Description": "Intuitive user-facing alliance",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    }
  ],
  "Description": "Ameliorated 24 hour portal",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "autem",
      "StrippedValue": "quam",
      "Description": "Pre-emptive background emulation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "quam",
      "Description": "Pre-emptive background emulation",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 546
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "cupiditate",
      "StrippedValue": "esse",
      "Description": "Business-focused fault-tolerant standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 592
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "esse",
      "Description": "Business-focused fault-tolerant standardization",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 592
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolor",
      "StrippedValue": "eum",
      "Description": "Monitored web-enabled array",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 990
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "eum",
      "Description": "Monitored web-enabled array",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 990
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "iste",
      "Description": "Robust 6th generation productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "iste",
      "Description": "Robust 6th generation productivity",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "architecto",
      "StrippedValue": "voluptatem",
      "Description": "Assimilated bi-directional concept",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    },
    {
      "Value": "architecto",
      "StrippedValue": "voluptatem",
      "Description": "Assimilated bi-directional concept",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    }
  ],
  "Position": {
    "Id": 802,
    "Value": "quia",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 878
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 959,
    "Name": "Swift-Hoppe",
    "PersonId": 929,
    "Rank": 602,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 462,
    "FullName": "Larue Kovacek",
    "FormalName": "Walsh Group",
    "Deleted": true,
    "EjUserId": 130,
    "UserName": "Wuckert, Thompson and Fritsch",
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
  "Contact": {
    "ContactId": 51,
    "Name": "Gerlach Inc and Sons",
    "OrgNr": "971117",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "aut",
    "DirectPhone": "1-113-355-3252 x253",
    "AssociateId": 695,
    "CountryId": 494,
    "EmailAddress": "hardy_zieme@upton.biz",
    "Kananame": "ut",
    "EmailAddressName": "ken@mertznitzsche.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Harrison Mraz",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "id",
    "FullName": "Felicity Green",
    "IsOwnerContact": false,
    "ActiveErpLinks": 140,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 479
      }
    }
  },
  "Country": {
    "CountryId": 838,
    "Name": "Rosenbaum-Mayer",
    "CurrencyId": 445,
    "EnglishName": "Flatley Inc and Sons",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Phased cohesive utilisation",
    "OrgNrText": "1562640",
    "InterAreaPrefix": "ut",
    "DialInPrefix": "tenetur",
    "ZipPrefix": "cum",
    "DomainName": "Gerlach Group",
    "AddressLayoutId": 73,
    "DomesticAddressLayoutId": 320,
    "ForeignAddressLayoutId": 803,
    "Rank": 935,
    "Tooltip": "impedit",
    "Deleted": false,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 833
      }
    }
  },
  "Interests": [
    {
      "Id": 75,
      "Name": "Schamberger-Schoen",
      "ToolTip": "Voluptatem iusto doloribus eos consequatur esse.",
      "Deleted": true,
      "Rank": 63,
      "Type": "doloribus",
      "ColorBlock": 57,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "2015-10-08T18:28:48.5999272+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "numquam",
      "StyleHint": "dolores",
      "Hidden": true,
      "FullName": "John Schultz",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 436
        }
      }
    }
  ],
  "PersonNumber": "1558736",
  "FullName": "Tillman Kiehn",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "odit",
      "StrippedValue": "quia",
      "Description": "Profound bandwidth-monitored policy",
      "TableRight": {},
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
    },
    {
      "Value": "odit",
      "StrippedValue": "quia",
      "Description": "Profound bandwidth-monitored policy",
      "TableRight": {},
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
  ],
  "FormalName": "Moore-Barton",
  "Address": {
    "Wgs84Latitude": 1328.816,
    "Wgs84Longitude": 26842.71,
    "LocalizedAddress": [
      [
        {
          "Name": "Greenholt-Hilll",
          "Value": "rerum",
          "Tooltip": "qui",
          "Label": "aut",
          "ValueLength": 982,
          "AddressType": "eius",
          "TableRight": {
            "Mask": "Delete",
            "Reason": ""
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": "recontextualize end-to-end methodologies"
              },
              "FieldType": "System.String",
              "FieldLength": 95
            }
          }
        }
      ],
      [
        {
          "Name": "Smitham, Hamill and Barton",
          "Value": "velit",
          "Tooltip": "cum",
          "Label": "qui",
          "ValueLength": 681,
          "AddressType": "a",
          "TableRight": {
            "Mask": "Delete",
            "Reason": "maximize mission-critical ROI"
          },
          "FieldProperties": {
            "fieldName": {
              "FieldRight": {
                "Mask": "FULL",
                "Reason": ""
              },
              "FieldType": "System.Int32",
              "FieldLength": 199
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "harum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 43
      }
    }
  },
  "Post3": "qui",
  "Post2": "illo",
  "Post1": "omnis",
  "Kanalname": "blanditiis",
  "Kanafname": "sapiente",
  "CorrespondingAssociate": {
    "AssociateId": 477,
    "Name": "Marks Inc and Sons",
    "PersonId": 727,
    "Rank": 161,
    "Tooltip": "esse",
    "Type": "AnonymousAssociate",
    "GroupIdx": 719,
    "FullName": "Josiah Schroeder",
    "FormalName": "Hessel, Bartell and Rippin",
    "Deleted": true,
    "EjUserId": 164,
    "UserName": "Lang, Mills and Blick",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reintermediate bleeding-edge e-commerce"
        },
        "FieldType": "System.Int32",
        "FieldLength": 196
      }
    }
  },
  "Category": {
    "Id": 447,
    "Value": "error",
    "Tooltip": "temporibus",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 474
      }
    }
  },
  "Business": {
    "Id": 519,
    "Value": "odit",
    "Tooltip": "dolorum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 378
      }
    }
  },
  "Associate": {
    "AssociateId": 692,
    "Name": "Bailey LLC",
    "PersonId": 294,
    "Rank": 363,
    "Tooltip": "officiis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 730,
    "FullName": "Angelica Prohaska",
    "FormalName": "Wiza LLC",
    "Deleted": true,
    "EjUserId": 764,
    "UserName": "McCullough, Dietrich and Wiegand",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 646
      }
    }
  },
  "Salutation": "voluptate",
  "ActiveInterests": 858,
  "SupportAssociate": {
    "AssociateId": 458,
    "Name": "Block Group",
    "PersonId": 84,
    "Rank": 938,
    "Tooltip": "ipsum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 406,
    "FullName": "Orlo Von II",
    "FormalName": "Greenfelder-Jenkins",
    "Deleted": false,
    "EjUserId": 653,
    "UserName": "Carter LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reinvent e-business mindshare"
        },
        "FieldType": "System.Int32",
        "FieldLength": 552
      }
    }
  },
  "TicketPriority": {
    "Id": 413,
    "Value": "quas",
    "Tooltip": "sit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 172
      }
    }
  },
  "CustomerLanguage": {
    "Id": 620,
    "Value": "eos",
    "Tooltip": "dolore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 278
      }
    }
  },
  "DbiAgentId": 674,
  "DbiKey": "sit",
  "DbiLastModified": "2005-07-18T18:28:48.6029268+02:00",
  "DbiLastSyncronized": "1999-03-25T18:28:48.6029268+01:00",
  "SentInfo": 207,
  "ShowContactTickets": 276,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 109,
    "UserName": "Zemlak-Price",
    "PersonId": 901,
    "Rank": 198,
    "Tooltip": "dolorum",
    "UserGroupId": 617,
    "EjUserId": 758,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "ut",
      "rerum"
    ],
    "CanLogon": true,
    "RoleName": "Donnelly LLC",
    "RoleTooltip": "nam",
    "UserGroupName": "Koch LLC",
    "UserGroupTooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 815
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "ullam",
      "StrippedValue": "minima",
      "Description": "Organic 4th generation superstructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "minima",
      "Description": "Organic 4th generation superstructure",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "ab",
      "Description": "Business-focused explicit approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 631
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ab",
      "Description": "Business-focused explicit approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 631
        }
      }
    }
  ],
  "Source": 797,
  "ActiveErpLinks": 7,
  "ShipmentTypes": [
    {
      "Id": 75,
      "Name": "Wolff LLC",
      "ToolTip": "Asperiores magni earum.",
      "Deleted": true,
      "Rank": 803,
      "Type": "in",
      "ColorBlock": 969,
      "IconHint": "aperiam",
      "Selected": false,
      "LastChanged": "2008-04-08T18:28:48.6039261+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deleniti",
      "StyleHint": "eos",
      "Hidden": false,
      "FullName": "Sabina Grant",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 82
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 589,
      "Comment": "consectetur",
      "Registered": "2008-02-07T18:28:48.6039261+01:00",
      "RegisteredAssociateId": 764,
      "Updated": "2016-03-25T18:28:48.6039261+01:00",
      "UpdatedAssociateId": 566,
      "LegalBaseId": 55,
      "LegalBaseKey": "nesciunt",
      "LegalBaseName": "Von, Dickens and McGlynn",
      "ConsentPurposeId": 830,
      "ConsentPurposeKey": "est",
      "ConsentPurposeName": "Roob Inc and Sons",
      "ConsentSourceId": 855,
      "ConsentSourceKey": "officia",
      "ConsentSourceName": "Keebler Group",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 366
        }
      }
    }
  ],
  "BounceEmails": [
    "jalyn.stoltenberg@heathcoterogahn.name",
    "harmon@schmidtfriesen.ca"
  ],
  "ActiveStatusMonitorId": 755,
  "UserDefinedFields": {
    "SuperOffice:1": "2036270104",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "numquam",
    "ExtraFields2": "delectus"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "eaque"
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
      "FieldLength": 885
    }
  }
}
```