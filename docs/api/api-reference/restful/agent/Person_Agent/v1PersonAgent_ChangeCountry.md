---
title: POST Agents/Person/ChangeCountry
id: v1PersonAgent_ChangeCountry
---

# POST Agents/Person/ChangeCountry

```http
POST /api/v1/Agents/Person/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format for this entity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/ChangeCountry?$select=name,department,category/id
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

PersonEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonEntity |  |  |
| ToCountryId | int32 |  |


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
POST /api/v1/Agents/Person/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": {
    "PersonId": 753,
    "Firstname": "Katelin",
    "MiddleName": "Bednar Group",
    "Lastname": "Johnson",
    "Mrmrs": "velit",
    "Title": "ea",
    "UpdatedDate": "1997-09-18T18:28:49.6791179+02:00",
    "CreatedDate": "2001-11-08T18:28:49.6791179+01:00",
    "BirthDate": "1995-04-04T18:28:49.6791179+02:00",
    "CreatedBy": {},
    "Emails": [
      {},
      {}
    ],
    "Description": "Organized neutral emulation",
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
    "PersonNumber": "901694",
    "FullName": "Jordane Crist",
    "NoMailing": true,
    "UsePersonAddress": true,
    "Retired": true,
    "Urls": [
      {},
      {}
    ],
    "FormalName": "Jakubowski LLC",
    "Address": {},
    "Post3": "at",
    "Post2": "vitae",
    "Post1": "blanditiis",
    "Kanalname": "earum",
    "Kanafname": "est",
    "CorrespondingAssociate": {},
    "Category": {},
    "Business": {},
    "Associate": {},
    "Salutation": "ipsa",
    "ActiveInterests": 873,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "DbiAgentId": 259,
    "DbiKey": "commodi",
    "DbiLastModified": "2017-05-01T18:28:49.6791179+02:00",
    "DbiLastSyncronized": "1998-07-05T18:28:49.6791179+02:00",
    "SentInfo": 538,
    "ShowContactTickets": 541,
    "UserInfo": {},
    "ChatEmails": [
      {},
      {}
    ],
    "InternetPhones": [
      {},
      {}
    ],
    "Source": 960,
    "ActiveErpLinks": 22,
    "ShipmentTypes": [
      {},
      {}
    ],
    "Consents": [
      {},
      {}
    ],
    "BounceEmails": [
      "burley.leannon@mertz.info",
      "adrienne.walsh@wisokyschmidt.info"
    ],
    "ActiveStatusMonitorId": 520,
    "UserDefinedFields": {
      "SuperOffice:1": "1613262868",
      "SuperOffice:2": "Ms. Norberto Gaylord"
    },
    "ExtraFields": {
      "ExtraFields1": "qui",
      "ExtraFields2": "velit"
    },
    "CustomFields": {
      "CustomFields1": "et",
      "CustomFields2": "totam"
    }
  },
  "ToCountryId": 932
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 325,
  "Firstname": "Bethany",
  "MiddleName": "Morissette, Blanda and Schaefer",
  "Lastname": "McGlynn",
  "Mrmrs": "voluptatem",
  "Title": "consequatur",
  "UpdatedDate": "1997-07-01T18:28:49.6891504+02:00",
  "CreatedDate": "2008-10-19T18:28:49.6891504+02:00",
  "BirthDate": "2000-09-01T18:28:49.6891504+02:00",
  "CreatedBy": {
    "AssociateId": 688,
    "Name": "Okuneva, Raynor and Hermann",
    "PersonId": 352,
    "Rank": 917,
    "Tooltip": "qui",
    "Type": "AnonymousAssociate",
    "GroupIdx": 47,
    "FullName": "Ronaldo Lynch",
    "FormalName": "Sanford-Bednar",
    "Deleted": true,
    "EjUserId": 252,
    "UserName": "Blick Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 866
      }
    }
  },
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "fugit",
      "Description": "Reverse-engineered clear-thinking approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 388
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "fugit",
      "Description": "Reverse-engineered clear-thinking approach",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 388
        }
      }
    }
  ],
  "Description": "Distributed secondary installation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "exercitationem",
      "StrippedValue": "sunt",
      "Description": "Monitored value-added adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 883
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "sunt",
      "Description": "Monitored value-added adapter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 883
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laudantium",
      "StrippedValue": "rerum",
      "Description": "Sharable tertiary service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "rerum",
      "Description": "Sharable tertiary service-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 311
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quos",
      "StrippedValue": "natus",
      "Description": "Multi-lateral human-resource flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "natus",
      "Description": "Multi-lateral human-resource flexibility",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "est",
      "StrippedValue": "id",
      "Description": "Digitized heuristic synergy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "id",
      "Description": "Digitized heuristic synergy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "soluta",
      "Description": "Digitized explicit infrastructure",
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
    {
      "Value": "cupiditate",
      "StrippedValue": "soluta",
      "Description": "Digitized explicit infrastructure",
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
    }
  ],
  "Position": {
    "Id": 997,
    "Value": "sapiente",
    "Tooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 155
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 577,
    "Name": "Treutel-Gutkowski",
    "PersonId": 928,
    "Rank": 380,
    "Tooltip": "quo",
    "Type": "AnonymousAssociate",
    "GroupIdx": 574,
    "FullName": "Penelope Conroy",
    "FormalName": "Mraz LLC",
    "Deleted": false,
    "EjUserId": 781,
    "UserName": "Windler Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 517
      }
    }
  },
  "Contact": {
    "ContactId": 779,
    "Name": "Oberbrunner, Kunze and Macejkovic",
    "OrgNr": "781437",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "odit",
    "DirectPhone": "1-526-716-8647",
    "AssociateId": 854,
    "CountryId": 564,
    "EmailAddress": "ervin@purdy.us",
    "Kananame": "culpa",
    "EmailAddressName": "palma@klocko.com",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Brionna Effertz",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "magni",
    "FullName": "Emilie Reynolds",
    "IsOwnerContact": false,
    "ActiveErpLinks": 25,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 504
      }
    }
  },
  "Country": {
    "CountryId": 240,
    "Name": "O'Reilly Group",
    "CurrencyId": 358,
    "EnglishName": "Cummings LLC",
    "TwoLetterISOCountry": "Sokovia",
    "ThreeLetterISOCountry": "Sokovia",
    "ImageDescription": "Re-contextualized bandwidth-monitored infrastructure",
    "OrgNrText": "780437",
    "InterAreaPrefix": "ea",
    "DialInPrefix": "est",
    "ZipPrefix": "est",
    "DomainName": "Cruickshank-Moore",
    "AddressLayoutId": 297,
    "DomesticAddressLayoutId": 525,
    "ForeignAddressLayoutId": 724,
    "Rank": 644,
    "Tooltip": "mollitia",
    "Deleted": true,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 121
      }
    }
  },
  "Interests": [
    {
      "Id": 587,
      "Name": "Becker-Carter",
      "ToolTip": "Aut aliquam quae.",
      "Deleted": true,
      "Rank": 410,
      "Type": "nulla",
      "ColorBlock": 368,
      "IconHint": "mollitia",
      "Selected": true,
      "LastChanged": "2018-10-09T18:28:49.6911424+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Savanna Conroy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 573
        }
      }
    }
  ],
  "PersonNumber": "372329",
  "FullName": "Eileen Nitzsche",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "eum",
      "StrippedValue": "aliquid",
      "Description": "Open-architected well-modulated concept",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 742
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "aliquid",
      "Description": "Open-architected well-modulated concept",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 742
        }
      }
    }
  ],
  "FormalName": "Gleason-Denesik",
  "Address": {
    "Wgs84Latitude": 8330.172,
    "Wgs84Longitude": 17302.814,
    "LocalizedAddress": [
      [
        {
          "Name": "Lockman Inc and Sons",
          "Value": "sit",
          "Tooltip": "voluptatem",
          "Label": "ut",
          "ValueLength": 476,
          "AddressType": "ea",
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
              "FieldLength": 981
            }
          }
        }
      ],
      [
        {
          "Name": "Bartoletti, Walker and Smith",
          "Value": "autem",
          "Tooltip": "nam",
          "Label": "nulla",
          "ValueLength": 975,
          "AddressType": "corporis",
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
              "FieldLength": 188
            }
          }
        }
      ]
    ],
    "Street": {},
    "Postal": {},
    "Formatted": "dolorem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 385
      }
    }
  },
  "Post3": "explicabo",
  "Post2": "cupiditate",
  "Post1": "harum",
  "Kanalname": "non",
  "Kanafname": "voluptatum",
  "CorrespondingAssociate": {
    "AssociateId": 234,
    "Name": "Cummerata-Kuhlman",
    "PersonId": 873,
    "Rank": 295,
    "Tooltip": "excepturi",
    "Type": "AnonymousAssociate",
    "GroupIdx": 417,
    "FullName": "Mr. Moshe Mayert",
    "FormalName": "Gislason, Murphy and Grady",
    "Deleted": false,
    "EjUserId": 813,
    "UserName": "Pacocha Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 581
      }
    }
  },
  "Category": {
    "Id": 141,
    "Value": "non",
    "Tooltip": "facilis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 227
      }
    }
  },
  "Business": {
    "Id": 127,
    "Value": "ipsam",
    "Tooltip": "et",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 274
      }
    }
  },
  "Associate": {
    "AssociateId": 870,
    "Name": "Gibson-Predovic",
    "PersonId": 861,
    "Rank": 6,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 191,
    "FullName": "Kaylie Rath",
    "FormalName": "McLaughlin-Ratke",
    "Deleted": true,
    "EjUserId": 175,
    "UserName": "Rath, Koepp and Crist",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 141
      }
    }
  },
  "Salutation": "ut",
  "ActiveInterests": 179,
  "SupportAssociate": {
    "AssociateId": 161,
    "Name": "Kuhn-Nicolas",
    "PersonId": 182,
    "Rank": 152,
    "Tooltip": "ipsam",
    "Type": "AnonymousAssociate",
    "GroupIdx": 481,
    "FullName": "Mikayla Wyman IV",
    "FormalName": "Zboncak-Ortiz",
    "Deleted": true,
    "EjUserId": 133,
    "UserName": "O'Kon, Goodwin and Ritchie",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 715
      }
    }
  },
  "TicketPriority": {
    "Id": 296,
    "Value": "aspernatur",
    "Tooltip": "reiciendis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 818
      }
    }
  },
  "CustomerLanguage": {
    "Id": 67,
    "Value": "provident",
    "Tooltip": "tempore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 759
      }
    }
  },
  "DbiAgentId": 995,
  "DbiKey": "laborum",
  "DbiLastModified": "2005-09-23T18:28:49.6931447+02:00",
  "DbiLastSyncronized": "2020-10-30T18:28:49.6931447+01:00",
  "SentInfo": 934,
  "ShowContactTickets": 727,
  "UserInfo": {
    "Deleted": false,
    "UserInfoId": 246,
    "UserName": "Tillman-Murray",
    "PersonId": 278,
    "Rank": 911,
    "Tooltip": "iusto",
    "UserGroupId": 626,
    "EjUserId": 84,
    "UserType": "AnonymousAssociate",
    "GrantedLicenses": [
      "incidunt",
      "et"
    ],
    "CanLogon": true,
    "RoleName": "Walsh-Rogahn",
    "RoleTooltip": "consequatur",
    "UserGroupName": "Gerhold LLC",
    "UserGroupTooltip": "praesentium",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 705
      }
    }
  },
  "ChatEmails": [
    {
      "Value": "neque",
      "StrippedValue": "dicta",
      "Description": "Robust well-modulated help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "dicta",
      "Description": "Robust well-modulated help-desk",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 159
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ab",
      "StrippedValue": "officia",
      "Description": "Upgradable intangible encoding",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 114
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "officia",
      "Description": "Upgradable intangible encoding",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 114
        }
      }
    }
  ],
  "Source": 186,
  "ActiveErpLinks": 844,
  "ShipmentTypes": [
    {
      "Id": 86,
      "Name": "Gerlach LLC",
      "ToolTip": "Illum dolor quae suscipit et.",
      "Deleted": false,
      "Rank": 183,
      "Type": "ratione",
      "ColorBlock": 926,
      "IconHint": "temporibus",
      "Selected": true,
      "LastChanged": "2018-02-17T18:28:49.6941422+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "alias",
      "Hidden": false,
      "FullName": "Bertrand Ward",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 83,
      "Comment": "voluptatem",
      "Registered": "2021-11-23T18:28:49.6941422+01:00",
      "RegisteredAssociateId": 581,
      "Updated": "2002-08-12T18:28:49.6941422+02:00",
      "UpdatedAssociateId": 893,
      "LegalBaseId": 600,
      "LegalBaseKey": "fugiat",
      "LegalBaseName": "Little Inc and Sons",
      "ConsentPurposeId": 428,
      "ConsentPurposeKey": "ipsum",
      "ConsentPurposeName": "Hills-Kilback",
      "ConsentSourceId": 601,
      "ConsentSourceKey": "aut",
      "ConsentSourceName": "Carroll-Cronin",
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
  "BounceEmails": [
    "narciso_muller@schoen.ca",
    "ezekiel@treutel.name"
  ],
  "ActiveStatusMonitorId": 616,
  "UserDefinedFields": {
    "SuperOffice:1": "1872877285",
    "SuperOffice:2": "740048486"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "eveniet"
  },
  "CustomFields": {
    "CustomFields1": "ipsam",
    "CustomFields2": "provident"
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
      "FieldLength": 127
    }
  }
}
```