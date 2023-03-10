---
title: POST Agents/Person/GetPersonEntity
uid: v1PersonAgent_GetPersonEntity
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
POST /api/v1/Agents/Person/GetPersonEntity?personEntityId=227
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/GetPersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 739,
  "Firstname": "Sydney",
  "MiddleName": "Ferry-Vandervort",
  "Lastname": "Wisozk",
  "Mrmrs": "similique",
  "Title": "itaque",
  "UpdatedDate": "1996-05-23T12:15:19.5907424+02:00",
  "CreatedDate": "2006-09-09T12:15:19.5907424+02:00",
  "BirthDate": "2020-07-20T12:15:19.5907424+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dicta",
      "StrippedValue": "placeat",
      "Description": "Total incremental analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 140
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "placeat",
      "Description": "Total incremental analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 140
        }
      }
    }
  ],
  "Description": "Ergonomic background hierarchy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "beatae",
      "Description": "Object-based composite concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "beatae",
      "Description": "Object-based composite concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 174
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "in",
      "Description": "Total context-sensitive firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "in",
      "Description": "Total context-sensitive firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "at",
      "Description": "Multi-tiered dedicated encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "at",
      "Description": "Multi-tiered dedicated encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "mollitia",
      "Description": "Fully-configurable holistic methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "mollitia",
      "Description": "Fully-configurable holistic methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "suscipit",
      "StrippedValue": "similique",
      "Description": "Object-based uniform budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 894
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "similique",
      "Description": "Object-based uniform budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 894
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
      "Id": 55,
      "Name": "Thompson Inc and Sons",
      "ToolTip": "Est aut veniam.",
      "Deleted": false,
      "Rank": 347,
      "Type": "non",
      "ColorBlock": 548,
      "IconHint": "velit",
      "Selected": false,
      "LastChanged": "2003-03-01T12:15:19.5937422+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quas",
      "StyleHint": "temporibus",
      "Hidden": false,
      "FullName": "Justine Bernhard",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 838
        }
      }
    }
  ],
  "PersonNumber": "1193430",
  "FullName": "Cleta Rolfson",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "ducimus",
      "Description": "Streamlined systemic migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "ducimus",
      "Description": "Streamlined systemic migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    }
  ],
  "FormalName": "Bechtelar, McDermott and Gerhold",
  "Address": null,
  "Post3": "sed",
  "Post2": "omnis",
  "Post1": "dolor",
  "Kanalname": "voluptatem",
  "Kanafname": "vel",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "repudiandae",
  "ActiveInterests": 456,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 667,
  "DbiKey": "inventore",
  "DbiLastModified": "2012-09-15T12:15:19.5957423+02:00",
  "DbiLastSyncronized": "2001-06-13T12:15:19.5957423+02:00",
  "SentInfo": 361,
  "ShowContactTickets": 391,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nihil",
      "StrippedValue": "consequatur",
      "Description": "Vision-oriented coherent benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 724
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "consequatur",
      "Description": "Vision-oriented coherent benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 724
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "esse",
      "StrippedValue": "et",
      "Description": "Re-contextualized high-level encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 437
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "et",
      "Description": "Re-contextualized high-level encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 437
        }
      }
    }
  ],
  "Source": 715,
  "ActiveErpLinks": 839,
  "ShipmentTypes": [
    {
      "Id": 925,
      "Name": "Cummings, Nicolas and Lang",
      "ToolTip": "Aut repellendus eligendi qui.",
      "Deleted": false,
      "Rank": 228,
      "Type": "est",
      "ColorBlock": 935,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2022-01-20T12:15:19.5967436+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ipsa",
      "StyleHint": "dolorem",
      "Hidden": false,
      "FullName": "Prof. Jaylon Emanuel Zulauf Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 19
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 923,
      "Comment": "sit",
      "Registered": "2007-01-19T12:15:19.5977441+01:00",
      "RegisteredAssociateId": 147,
      "Updated": "2012-02-28T12:15:19.5977441+01:00",
      "UpdatedAssociateId": 814,
      "LegalBaseId": 68,
      "LegalBaseKey": "quam",
      "LegalBaseName": "Schinner Group",
      "ConsentPurposeId": 510,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Mills, Dickens and Morissette",
      "ConsentSourceId": 315,
      "ConsentSourceKey": "quasi",
      "ConsentSourceName": "Rutherford, Langosh and Feeney",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 856
        }
      }
    }
  ],
  "BounceEmails": [
    "marcelino@waelchi.us",
    "nova_cole@leuschke.us"
  ],
  "ActiveStatusMonitorId": 52,
  "UserDefinedFields": {
    "SuperOffice:1": "Glenda Ward",
    "SuperOffice:2": "Thaddeus Josephine Aufderhar III"
  },
  "ExtraFields": {
    "ExtraFields1": "sed",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 335
    }
  }
}
```