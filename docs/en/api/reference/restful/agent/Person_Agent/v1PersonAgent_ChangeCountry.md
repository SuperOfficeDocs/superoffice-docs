---
title: POST Agents/Person/ChangeCountry
uid: v1PersonAgent_ChangeCountry
generated: true
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
| PersonEntity | PersonEntity |  |
| ToCountryId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

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
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonEntity": null,
  "ToCountryId": 162
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 87,
  "Firstname": "Filomena",
  "MiddleName": "Boehm LLC",
  "Lastname": "Jewess",
  "Mrmrs": "inventore",
  "Title": "iusto",
  "UpdatedDate": "2002-01-04T13:38:13.8116104+01:00",
  "CreatedDate": "2015-11-25T13:38:13.8116104+01:00",
  "BirthDate": "1999-09-11T13:38:13.8116104+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "rem",
      "StrippedValue": "commodi",
      "Description": "Devolved 5th generation encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 557
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "commodi",
      "Description": "Devolved 5th generation encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 557
        }
      }
    }
  ],
  "Description": "Synchronised intermediate synergy",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "exercitationem",
      "StrippedValue": "quibusdam",
      "Description": "Quality-focused heuristic moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 154
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "quibusdam",
      "Description": "Quality-focused heuristic moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 154
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sequi",
      "StrippedValue": "ea",
      "Description": "Self-enabling even-keeled intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 153
        }
      }
    },
    {
      "Value": "sequi",
      "StrippedValue": "ea",
      "Description": "Self-enabling even-keeled intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 153
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "nulla",
      "Description": "Multi-layered zero administration utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 593
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "nulla",
      "Description": "Multi-layered zero administration utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 593
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "qui",
      "Description": "Re-engineered holistic leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 584
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "qui",
      "Description": "Re-engineered holistic leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 584
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "ab",
      "StrippedValue": "est",
      "Description": "Configurable optimal definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 830
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "est",
      "Description": "Configurable optimal definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 830
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 701,
      "Name": "O'Conner Group",
      "ToolTip": "Sit esse.",
      "Deleted": true,
      "Rank": 448,
      "Type": "et",
      "ColorBlock": 47,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2009-05-26T13:38:13.8116104+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "hic",
      "StyleHint": "aliquam",
      "Hidden": false,
      "FullName": "Mr. Kevon Nikita Stiedemann IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 392
        }
      }
    }
  ],
  "PersonNumber": "683413",
  "FullName": "Hayden Mohr",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "deleniti",
      "StrippedValue": "sit",
      "Description": "Upgradable full-range encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "sit",
      "Description": "Upgradable full-range encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    }
  ],
  "FormalName": "Adams, Christiansen and Gerhold",
  "Address": null,
  "Post3": "rem",
  "Post2": "enim",
  "Post1": "ut",
  "Kanalname": "delectus",
  "Kanafname": "aut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quae",
  "ActiveInterests": 743,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 25,
  "DbiKey": "rerum",
  "DbiLastModified": "2013-08-27T13:38:13.8116104+02:00",
  "DbiLastSyncronized": "2011-02-09T13:38:13.8116104+01:00",
  "SentInfo": 735,
  "ShowContactTickets": 283,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "recusandae",
      "StrippedValue": "eius",
      "Description": "Extended bottom-line service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 80
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "eius",
      "Description": "Extended bottom-line service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 80
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "iusto",
      "StrippedValue": "eveniet",
      "Description": "Optimized actuating productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    },
    {
      "Value": "iusto",
      "StrippedValue": "eveniet",
      "Description": "Optimized actuating productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 786
        }
      }
    }
  ],
  "Source": 254,
  "ActiveErpLinks": 425,
  "ShipmentTypes": [
    {
      "Id": 695,
      "Name": "Braun Group",
      "ToolTip": "Porro consequuntur quibusdam.",
      "Deleted": false,
      "Rank": 384,
      "Type": "excepturi",
      "ColorBlock": 183,
      "IconHint": "molestias",
      "Selected": false,
      "LastChanged": "2010-10-12T13:38:13.8116104+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatum",
      "StyleHint": "quibusdam",
      "Hidden": false,
      "FullName": "Juliana Larson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 715,
      "Comment": "sint",
      "Registered": "2016-12-26T13:38:13.8116104+01:00",
      "RegisteredAssociateId": 20,
      "Updated": "2005-10-22T13:38:13.8116104+02:00",
      "UpdatedAssociateId": 481,
      "LegalBaseId": 293,
      "LegalBaseKey": "laboriosam",
      "LegalBaseName": "Beatty-Larkin",
      "ConsentPurposeId": 589,
      "ConsentPurposeKey": "dolor",
      "ConsentPurposeName": "Boehm-Hagenes",
      "ConsentSourceId": 307,
      "ConsentSourceKey": "ullam",
      "ConsentSourceName": "Douglas, Zemlak and Kessler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 401
        }
      }
    }
  ],
  "BounceEmails": [
    "lenna.white@dicki.com",
    "stephen@boyle.info"
  ],
  "ActiveStatusMonitorId": 51,
  "UserDefinedFields": {
    "SuperOffice:1": "Izaiah Schultz",
    "SuperOffice:2": "Geovanny McCullough MD"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "eum",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 411
    }
  }
}
```