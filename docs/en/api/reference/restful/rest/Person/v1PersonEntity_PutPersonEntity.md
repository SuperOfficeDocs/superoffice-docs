---
title: PUT Person/{id}
uid: v1PersonEntity_PutPersonEntity
---

# PUT Person/{id}

```http
PUT /api/v1/Person/{id}
```

Updates the existing PersonEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PersonEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Person/{id}?$select=name,department,category/id
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

## Request Body: entity 

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

PersonEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity updated. |
| 412 | Update stopped because PersonEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: PersonEntityWithLinks

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 589,
  "Firstname": "Shea",
  "MiddleName": "Wuckert, Wisoky and Robel",
  "Lastname": "Huels",
  "Mrmrs": "aperiam",
  "Title": "sit",
  "UpdatedDate": "2004-11-11T11:22:44.9287775+01:00",
  "CreatedDate": "2013-04-02T11:22:44.9287775+02:00",
  "BirthDate": "2019-02-22T11:22:44.9287775+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolor",
      "StrippedValue": "qui",
      "Description": "Synergistic eco-centric framework"
    },
    {
      "Value": "dolor",
      "StrippedValue": "qui",
      "Description": "Synergistic eco-centric framework"
    }
  ],
  "Description": "Assimilated value-added forecast",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "dolores",
      "Description": "Down-sized high-level attitude"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "dolores",
      "Description": "Down-sized high-level attitude"
    }
  ],
  "Faxes": [
    {
      "Value": "quos",
      "StrippedValue": "qui",
      "Description": "Quality-focused optimal access"
    },
    {
      "Value": "quos",
      "StrippedValue": "qui",
      "Description": "Quality-focused optimal access"
    }
  ],
  "MobilePhones": [
    {
      "Value": "eos",
      "StrippedValue": "et",
      "Description": "Enterprise-wide eco-centric application"
    },
    {
      "Value": "eos",
      "StrippedValue": "et",
      "Description": "Enterprise-wide eco-centric application"
    }
  ],
  "OfficePhones": [
    {
      "Value": "delectus",
      "StrippedValue": "similique",
      "Description": "Profit-focused incremental alliance"
    },
    {
      "Value": "delectus",
      "StrippedValue": "similique",
      "Description": "Profit-focused incremental alliance"
    }
  ],
  "OtherPhones": [
    {
      "Value": "in",
      "StrippedValue": "et",
      "Description": "Team-oriented holistic benchmark"
    },
    {
      "Value": "in",
      "StrippedValue": "et",
      "Description": "Team-oriented holistic benchmark"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 265,
      "Name": "Goyette, Altenwerth and Senger",
      "ToolTip": "Minima dolor assumenda distinctio voluptatem aliquam.",
      "Deleted": false,
      "Rank": 16,
      "Type": "vero",
      "ColorBlock": 790,
      "IconHint": "nobis",
      "Selected": false,
      "LastChanged": "2006-02-01T11:22:44.9443951+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "voluptates",
      "Hidden": true,
      "FullName": "Jameson Connelly"
    }
  ],
  "PersonNumber": "1257764",
  "FullName": "Dr. Felicity Lorine Pacocha",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptates",
      "StrippedValue": "dicta",
      "Description": "Cross-group contextually-based parallelism"
    },
    {
      "Value": "voluptates",
      "StrippedValue": "dicta",
      "Description": "Cross-group contextually-based parallelism"
    }
  ],
  "FormalName": "Berge Inc and Sons",
  "Address": null,
  "Post3": "nostrum",
  "Post2": "commodi",
  "Post1": "nostrum",
  "Kanalname": "repellat",
  "Kanafname": "libero",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quo",
  "ActiveInterests": 788,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 726,
  "DbiKey": "consectetur",
  "DbiLastModified": "2013-08-17T11:22:44.9443951+02:00",
  "DbiLastSyncronized": "2021-09-08T11:22:44.9443951+02:00",
  "SentInfo": 711,
  "ShowContactTickets": 597,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ducimus",
      "StrippedValue": "aut",
      "Description": "Assimilated optimizing algorithm"
    },
    {
      "Value": "ducimus",
      "StrippedValue": "aut",
      "Description": "Assimilated optimizing algorithm"
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Function-based national knowledge user"
    },
    {
      "Value": "et",
      "StrippedValue": "et",
      "Description": "Function-based national knowledge user"
    }
  ],
  "Source": 4,
  "ActiveErpLinks": 529,
  "ShipmentTypes": [
    {
      "Id": 12,
      "Name": "Labadie-Hauck",
      "ToolTip": "Recusandae deleniti.",
      "Deleted": false,
      "Rank": 408,
      "Type": "quo",
      "ColorBlock": 163,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "1996-09-08T11:22:44.9443951+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Gladys Gerlach"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 387,
      "Comment": "dolores",
      "Registered": "2016-02-05T11:22:44.9443951+01:00",
      "RegisteredAssociateId": 745,
      "Updated": "2010-09-02T11:22:44.9443951+02:00",
      "UpdatedAssociateId": 132,
      "LegalBaseId": 314,
      "LegalBaseKey": "quidem",
      "LegalBaseName": "Lueilwitz-Goodwin",
      "ConsentPurposeId": 626,
      "ConsentPurposeKey": "magnam",
      "ConsentPurposeName": "Weimann LLC",
      "ConsentSourceId": 522,
      "ConsentSourceKey": "aspernatur",
      "ConsentSourceName": "Rau Inc and Sons"
    }
  ],
  "BounceEmails": [
    "carley@ruecker.info",
    "vivienne_morar@champlin.name"
  ],
  "ActiveStatusMonitorId": 131,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Donnell Alyson Dibbert III",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "aperiam",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "facilis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 796,
  "Firstname": "Aric",
  "MiddleName": "Luettgen, Ernser and Casper",
  "Lastname": "Mayert",
  "Mrmrs": "iste",
  "Title": "modi",
  "UpdatedDate": "2013-02-01T11:22:44.9443951+01:00",
  "CreatedDate": "2001-09-18T11:22:44.9443951+02:00",
  "BirthDate": "2008-06-09T11:22:44.9443951+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "reiciendis",
      "StrippedValue": "sint",
      "Description": "Right-sized regional extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "sint",
      "Description": "Right-sized regional extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 975
        }
      }
    }
  ],
  "Description": "Synergized neutral contingency",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "eaque",
      "StrippedValue": "voluptatum",
      "Description": "Cloned 3rd generation contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 377
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "voluptatum",
      "Description": "Cloned 3rd generation contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 377
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quae",
      "StrippedValue": "cumque",
      "Description": "Exclusive intangible time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 782
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "cumque",
      "Description": "Exclusive intangible time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 782
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "recusandae",
      "StrippedValue": "cum",
      "Description": "Cloned cohesive open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 922
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "cum",
      "Description": "Cloned cohesive open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 922
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "est",
      "StrippedValue": "veritatis",
      "Description": "Ergonomic local implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "veritatis",
      "Description": "Ergonomic local implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 90
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "suscipit",
      "StrippedValue": "ducimus",
      "Description": "Extended zero defect alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "ducimus",
      "Description": "Extended zero defect alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
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
      "Id": 637,
      "Name": "Olson Inc and Sons",
      "ToolTip": "Deleniti voluptas voluptatem et et sunt enim.",
      "Deleted": false,
      "Rank": 274,
      "Type": "nihil",
      "ColorBlock": 935,
      "IconHint": "qui",
      "Selected": false,
      "LastChanged": "1996-11-23T11:22:44.9443951+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sapiente",
      "StyleHint": "veritatis",
      "Hidden": false,
      "FullName": "Prudence Thompson DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 878
        }
      }
    }
  ],
  "PersonNumber": "584333",
  "FullName": "Abigale Nicolas III",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "quidem",
      "StrippedValue": "possimus",
      "Description": "Expanded maximized hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "possimus",
      "Description": "Expanded maximized hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    }
  ],
  "FormalName": "Crist, Bosco and Crooks",
  "Address": null,
  "Post3": "repudiandae",
  "Post2": "quis",
  "Post1": "ab",
  "Kanalname": "maiores",
  "Kanafname": "ipsum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "culpa",
  "ActiveInterests": 377,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 536,
  "DbiKey": "cumque",
  "DbiLastModified": "2002-03-17T11:22:44.9600167+01:00",
  "DbiLastSyncronized": "1998-07-08T11:22:44.9600167+02:00",
  "SentInfo": 620,
  "ShowContactTickets": 18,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "qui",
      "StrippedValue": "explicabo",
      "Description": "Enhanced real-time functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 769
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "explicabo",
      "Description": "Enhanced real-time functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 769
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "consectetur",
      "StrippedValue": "quaerat",
      "Description": "Multi-tiered responsive initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    },
    {
      "Value": "consectetur",
      "StrippedValue": "quaerat",
      "Description": "Multi-tiered responsive initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 869
        }
      }
    }
  ],
  "Source": 812,
  "ActiveErpLinks": 439,
  "ShipmentTypes": [
    {
      "Id": 197,
      "Name": "D'Amore Inc and Sons",
      "ToolTip": "Eaque consequuntur voluptates.",
      "Deleted": false,
      "Rank": 309,
      "Type": "explicabo",
      "ColorBlock": 780,
      "IconHint": "quis",
      "Selected": false,
      "LastChanged": "2013-08-26T11:22:44.9600167+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "voluptatibus",
      "Hidden": false,
      "FullName": "Ms. Gordon Bosco I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 213
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 649,
      "Comment": "dolorem",
      "Registered": "2021-12-20T11:22:44.9600167+01:00",
      "RegisteredAssociateId": 535,
      "Updated": "2013-09-08T11:22:44.9600167+02:00",
      "UpdatedAssociateId": 445,
      "LegalBaseId": 46,
      "LegalBaseKey": "incidunt",
      "LegalBaseName": "Parker Group",
      "ConsentPurposeId": 3,
      "ConsentPurposeKey": "est",
      "ConsentPurposeName": "Stokes-Powlowski",
      "ConsentSourceId": 47,
      "ConsentSourceKey": "ab",
      "ConsentSourceName": "Moore LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 978
        }
      }
    }
  ],
  "BounceEmails": [
    "kamron@rosenbaum.name",
    "tianna_lubowitz@keebler.uk"
  ],
  "ActiveStatusMonitorId": 417,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Name Denesik DVM"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 474
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```