---
title: POST Person
uid: v1PersonEntity_PostPersonEntity
generated: true
---

# POST Person

```http
POST /api/v1/Person
```

Creates a new PersonEntity


Calls the Person agent service SavePersonEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Person?$select=name,department,category/id
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

## Request Body: newEntity 

The PersonEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer | Primary key |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| Mrmrs | String | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | String | Title |
| UpdatedDate | String | Last updated date  in UTC. |
| CreatedDate | String | Registered date  in UTC. |
| BirthDate | String | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | Array | A collection of the person's emails |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | Boolean | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | Array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | Array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | Array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | Array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | Array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | Array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | String | Alphanumeric user field |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | Boolean | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | Boolean | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | Array | The urls related to this person. |
| FormalName | String | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | String | Postal address, used in Japanese versions only |
| Post2 | String | Postal address, used in Japanese versions only |
| Post1 | String | Postal address, used in Japanese versions only |
| Kanalname | String | Kana last name, used in Japanese versions only |
| Kanafname | String | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | String | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | Integer | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| DbiLastSyncronized | String | Last external syncronization. |
| SentInfo | Integer | Has information on username/password been sent (ejournal) |
| ShowContactTickets | Integer | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | Array |  |
| InternetPhones | Array |  |
| Source | Integer | How did we get this person? For future integration needs |
| ActiveErpLinks | Integer | How many active ERP links are there for this person? |
| ShipmentTypes | Array | The person's available and selected shipment types. |
| Consents | Array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
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
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 283,
  "Firstname": "Florian",
  "MiddleName": "Graham, Homenick and Wolf",
  "Lastname": "Dickens",
  "Mrmrs": "quidem",
  "Title": "voluptatem",
  "UpdatedDate": "2021-05-12T16:55:29.8130172+02:00",
  "CreatedDate": "2000-11-12T16:55:29.8130172+01:00",
  "BirthDate": "2014-09-11T16:55:29.8130172+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "neque",
      "StrippedValue": "inventore",
      "Description": "Vision-oriented full-range Graphic Interface"
    },
    {
      "Value": "neque",
      "StrippedValue": "inventore",
      "Description": "Vision-oriented full-range Graphic Interface"
    }
  ],
  "Description": "Up-sized optimizing pricing structure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "animi",
      "StrippedValue": "architecto",
      "Description": "Multi-layered hybrid time-frame"
    },
    {
      "Value": "animi",
      "StrippedValue": "architecto",
      "Description": "Multi-layered hybrid time-frame"
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "laudantium",
      "Description": "Up-sized tertiary middleware"
    },
    {
      "Value": "sit",
      "StrippedValue": "laudantium",
      "Description": "Up-sized tertiary middleware"
    }
  ],
  "MobilePhones": [
    {
      "Value": "velit",
      "StrippedValue": "porro",
      "Description": "Proactive human-resource parallelism"
    },
    {
      "Value": "velit",
      "StrippedValue": "porro",
      "Description": "Proactive human-resource parallelism"
    }
  ],
  "OfficePhones": [
    {
      "Value": "sit",
      "StrippedValue": "nihil",
      "Description": "Multi-lateral modular help-desk"
    },
    {
      "Value": "sit",
      "StrippedValue": "nihil",
      "Description": "Multi-lateral modular help-desk"
    }
  ],
  "OtherPhones": [
    {
      "Value": "facere",
      "StrippedValue": "maiores",
      "Description": "Up-sized upward-trending encoding"
    },
    {
      "Value": "facere",
      "StrippedValue": "maiores",
      "Description": "Up-sized upward-trending encoding"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 986,
      "Name": "Schroeder-Gutmann",
      "ToolTip": "Laborum et sint nobis iusto debitis magnam quod.",
      "Deleted": true,
      "Rank": 64,
      "Type": "tempora",
      "ColorBlock": 599,
      "IconHint": "nemo",
      "Selected": false,
      "LastChanged": "2009-06-13T16:55:29.8160919+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "reiciendis",
      "StyleHint": "quas",
      "Hidden": false,
      "FullName": "Gavin Kovacek"
    }
  ],
  "PersonNumber": "627213",
  "FullName": "Kylie Gusikowski",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "nesciunt",
      "Description": "Configurable scalable strategy"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "nesciunt",
      "Description": "Configurable scalable strategy"
    }
  ],
  "FormalName": "O'Kon Inc and Sons",
  "Address": null,
  "Post3": "enim",
  "Post2": "eligendi",
  "Post1": "velit",
  "Kanalname": "voluptates",
  "Kanafname": "tempore",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "recusandae",
  "ActiveInterests": 818,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 976,
  "DbiKey": "impedit",
  "DbiLastModified": "1999-09-02T16:55:29.8171002+02:00",
  "DbiLastSyncronized": "2014-09-18T16:55:29.8171002+02:00",
  "SentInfo": 196,
  "ShowContactTickets": 282,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptatibus",
      "StrippedValue": "quod",
      "Description": "Operative heuristic model"
    },
    {
      "Value": "voluptatibus",
      "StrippedValue": "quod",
      "Description": "Operative heuristic model"
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "quia",
      "Description": "Function-based next generation algorithm"
    },
    {
      "Value": "ut",
      "StrippedValue": "quia",
      "Description": "Function-based next generation algorithm"
    }
  ],
  "Source": 831,
  "ActiveErpLinks": 861,
  "ShipmentTypes": [
    {
      "Id": 236,
      "Name": "Medhurst-Monahan",
      "ToolTip": "Maiores voluptas at aut laudantium.",
      "Deleted": true,
      "Rank": 705,
      "Type": "dicta",
      "ColorBlock": 522,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2018-05-12T16:55:29.818089+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deleniti",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Herman Watsica"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 423,
      "Comment": "tenetur",
      "Registered": "2000-10-11T16:55:29.818089+02:00",
      "RegisteredAssociateId": 80,
      "Updated": "2002-12-27T16:55:29.818089+01:00",
      "UpdatedAssociateId": 888,
      "LegalBaseId": 735,
      "LegalBaseKey": "quia",
      "LegalBaseName": "Haag, Dooley and Watsica",
      "ConsentPurposeId": 415,
      "ConsentPurposeKey": "tempora",
      "ConsentPurposeName": "Gislason Group",
      "ConsentSourceId": 562,
      "ConsentSourceKey": "minus",
      "ConsentSourceName": "Cronin, Bartell and Kuhlman"
    }
  ],
  "BounceEmails": [
    "aleen_hills@okunevagrimes.co.uk",
    "cordia_langosh@zieme.co.uk"
  ],
  "ActiveStatusMonitorId": 191,
  "UserDefinedFields": {
    "SuperOffice:1": "Kaylee Quinn Kilback III",
    "SuperOffice:2": "Mrs. Jamel Stark DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "minima"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 630,
  "Firstname": "Westley",
  "MiddleName": "Jacobs-Rempel",
  "Lastname": "Rutherford",
  "Mrmrs": "explicabo",
  "Title": "beatae",
  "UpdatedDate": "2017-01-05T16:55:29.826996+01:00",
  "CreatedDate": "2010-03-10T16:55:29.826996+01:00",
  "BirthDate": "2019-10-11T16:55:29.826996+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "consectetur",
      "StrippedValue": "omnis",
      "Description": "Organized well-modulated access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 512
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "omnis",
      "Description": "Organized well-modulated access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 512
        }
      }
    }
  ],
  "Description": "Vision-oriented empowering database",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ut",
      "StrippedValue": "quo",
      "Description": "Extended well-modulated architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 400
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "quo",
      "Description": "Extended well-modulated architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 400
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "illum",
      "StrippedValue": "nemo",
      "Description": "Object-based homogeneous projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 494
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "nemo",
      "Description": "Object-based homogeneous projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 494
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "similique",
      "Description": "Optional multi-tasking function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 187
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "similique",
      "Description": "Optional multi-tasking function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 187
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "consequuntur",
      "StrippedValue": "molestiae",
      "Description": "Synergistic user-facing emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "molestiae",
      "Description": "Synergistic user-facing emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "fugiat",
      "StrippedValue": "cumque",
      "Description": "Open-source asynchronous process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 859
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "cumque",
      "Description": "Open-source asynchronous process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 859
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
      "Id": 611,
      "Name": "D'Amore, Kshlerin and Flatley",
      "ToolTip": "Nisi et minus illo enim sit similique libero.",
      "Deleted": false,
      "Rank": 518,
      "Type": "iste",
      "ColorBlock": 639,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2020-03-24T16:55:29.8310921+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "consequuntur",
      "Hidden": false,
      "FullName": "Mrs. Bell Alfredo Nader IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 271
        }
      }
    }
  ],
  "PersonNumber": "417611",
  "FullName": "Isabella Ratke",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "accusamus",
      "StrippedValue": "laborum",
      "Description": "Cross-platform attitude-oriented ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 405
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "laborum",
      "Description": "Cross-platform attitude-oriented ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 405
        }
      }
    }
  ],
  "FormalName": "Huel, Bechtelar and Morissette",
  "Address": null,
  "Post3": "atque",
  "Post2": "unde",
  "Post1": "autem",
  "Kanalname": "commodi",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quos",
  "ActiveInterests": 668,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 82,
  "DbiKey": "quaerat",
  "DbiLastModified": "2006-02-23T16:55:29.8341156+01:00",
  "DbiLastSyncronized": "1999-10-27T16:55:29.8341156+02:00",
  "SentInfo": 981,
  "ShowContactTickets": 710,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "libero",
      "StrippedValue": "unde",
      "Description": "Assimilated human-resource function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "unde",
      "Description": "Assimilated human-resource function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "sequi",
      "Description": "Customizable scalable circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 33
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "sequi",
      "Description": "Customizable scalable circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 33
        }
      }
    }
  ],
  "Source": 305,
  "ActiveErpLinks": 435,
  "ShipmentTypes": [
    {
      "Id": 740,
      "Name": "Abernathy, Harber and Mohr",
      "ToolTip": "Quo porro modi velit laborum consequuntur qui inventore.",
      "Deleted": true,
      "Rank": 960,
      "Type": "rerum",
      "ColorBlock": 655,
      "IconHint": "dignissimos",
      "Selected": false,
      "LastChanged": "2002-01-08T16:55:29.8341156+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "similique",
      "Hidden": true,
      "FullName": "Karlie Ziemann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 173
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 504,
      "Comment": "mollitia",
      "Registered": "2005-07-13T16:55:29.835094+02:00",
      "RegisteredAssociateId": 24,
      "Updated": "2005-07-29T16:55:29.835094+02:00",
      "UpdatedAssociateId": 135,
      "LegalBaseId": 760,
      "LegalBaseKey": "sint",
      "LegalBaseName": "McClure-Witting",
      "ConsentPurposeId": 608,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Weimann-Cartwright",
      "ConsentSourceId": 893,
      "ConsentSourceKey": "nesciunt",
      "ConsentSourceName": "Larson-Schuppe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 32
        }
      }
    }
  ],
  "BounceEmails": [
    "rosendo@schustergaylord.com",
    "annalise@oreilly.biz"
  ],
  "ActiveStatusMonitorId": 813,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "iusto",
    "ExtraFields2": "soluta"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "ea"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 239
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```