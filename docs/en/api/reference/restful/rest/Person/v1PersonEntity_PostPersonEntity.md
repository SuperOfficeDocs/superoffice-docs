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
| CreatedByFormId | Integer | The form id of the form that created the person |
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
| CreatedByFormId | int32 | The form id of the form that created the person |
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 843,
  "Firstname": "Daija",
  "MiddleName": "Kertzmann-Cole",
  "Lastname": "Koss",
  "Mrmrs": "vel",
  "Title": "provident",
  "UpdatedDate": "2024-04-21T13:13:31.7769514+02:00",
  "CreatedDate": "2010-05-01T13:13:31.7769514+02:00",
  "BirthDate": "2019-07-16T13:13:31.7769514+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptates",
      "StrippedValue": "quisquam",
      "Description": "Compatible neutral time-frame"
    },
    {
      "Value": "voluptates",
      "StrippedValue": "quisquam",
      "Description": "Compatible neutral time-frame"
    }
  ],
  "Description": "Upgradable optimizing flexibility",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quis",
      "StrippedValue": "optio",
      "Description": "Multi-layered 24/7 data-warehouse"
    },
    {
      "Value": "quis",
      "StrippedValue": "optio",
      "Description": "Multi-layered 24/7 data-warehouse"
    }
  ],
  "Faxes": [
    {
      "Value": "accusantium",
      "StrippedValue": "totam",
      "Description": "Public-key local challenge"
    },
    {
      "Value": "accusantium",
      "StrippedValue": "totam",
      "Description": "Public-key local challenge"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quam",
      "StrippedValue": "quod",
      "Description": "Multi-lateral human-resource service-desk"
    },
    {
      "Value": "quam",
      "StrippedValue": "quod",
      "Description": "Multi-lateral human-resource service-desk"
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "incidunt",
      "Description": "Intuitive dedicated success"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "incidunt",
      "Description": "Intuitive dedicated success"
    }
  ],
  "OtherPhones": [
    {
      "Value": "cumque",
      "StrippedValue": "est",
      "Description": "Balanced explicit system engine"
    },
    {
      "Value": "cumque",
      "StrippedValue": "est",
      "Description": "Balanced explicit system engine"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 194,
      "Name": "Stiedemann-Bode",
      "ToolTip": "Facilis dicta nemo culpa omnis consequatur ipsa.",
      "Deleted": false,
      "Rank": 623,
      "Type": "enim",
      "ColorBlock": 582,
      "IconHint": "voluptatum",
      "Selected": false,
      "LastChanged": "2004-06-07T13:13:31.7769514+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "harum",
      "Hidden": false,
      "FullName": "Fred Hickle"
    }
  ],
  "PersonNumber": "1010458",
  "FullName": "Kitty West",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "debitis",
      "StrippedValue": "nesciunt",
      "Description": "Realigned motivating knowledge base"
    },
    {
      "Value": "debitis",
      "StrippedValue": "nesciunt",
      "Description": "Realigned motivating knowledge base"
    }
  ],
  "FormalName": "Gislason LLC",
  "Address": null,
  "Post3": "maxime",
  "Post2": "quod",
  "Post1": "voluptatem",
  "Kanalname": "libero",
  "Kanafname": "aut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "saepe",
  "ActiveInterests": 218,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 32,
  "DbiKey": "velit",
  "DbiLastModified": "2023-09-30T13:13:31.7925901+02:00",
  "DbiLastSyncronized": "2015-08-17T13:13:31.7925901+02:00",
  "SentInfo": 834,
  "ShowContactTickets": 932,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "consequatur",
      "StrippedValue": "nisi",
      "Description": "Profit-focused full-range orchestration"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "nisi",
      "Description": "Profit-focused full-range orchestration"
    }
  ],
  "InternetPhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "neque",
      "Description": "Switchable background implementation"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "neque",
      "Description": "Switchable background implementation"
    }
  ],
  "Source": 85,
  "ActiveErpLinks": 769,
  "ShipmentTypes": [
    {
      "Id": 562,
      "Name": "Turner, Turner and Schinner",
      "ToolTip": "Enim voluptas accusamus ut labore rerum.",
      "Deleted": false,
      "Rank": 312,
      "Type": "tempora",
      "ColorBlock": 185,
      "IconHint": "molestiae",
      "Selected": false,
      "LastChanged": "2003-10-23T13:13:31.7925901+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "maiores",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Marcos Jakubowski"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 202,
      "Comment": "laborum",
      "Registered": "1999-06-26T13:13:31.7925901+02:00",
      "RegisteredAssociateId": 762,
      "Updated": "2018-09-14T13:13:31.7925901+02:00",
      "UpdatedAssociateId": 971,
      "LegalBaseId": 946,
      "LegalBaseKey": "fugiat",
      "LegalBaseName": "Schulist-Towne",
      "ConsentPurposeId": 729,
      "ConsentPurposeKey": "ipsa",
      "ConsentPurposeName": "Gaylord-Flatley",
      "ConsentSourceId": 764,
      "ConsentSourceKey": "facilis",
      "ConsentSourceName": "Hettinger-Stamm"
    }
  ],
  "BounceEmails": [
    "skylar_casper@gutkowskigislason.name",
    "antoinette.dach@cormier.com"
  ],
  "ActiveStatusMonitorId": 263,
  "CreatedByFormId": 30,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "746287682"
  },
  "ExtraFields": {
    "ExtraFields1": "distinctio",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "illum",
    "CustomFields2": "nihil"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 953,
  "Firstname": "Maeve",
  "MiddleName": "Lesch, Bechtelar and Monahan",
  "Lastname": "Mitchell",
  "Mrmrs": "sapiente",
  "Title": "quas",
  "UpdatedDate": "2015-09-05T13:13:31.7925901+02:00",
  "CreatedDate": "2011-08-10T13:13:31.7925901+02:00",
  "BirthDate": "2024-05-05T13:13:31.7925901+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "pariatur",
      "StrippedValue": "explicabo",
      "Description": "Organic systemic standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 77
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "explicabo",
      "Description": "Organic systemic standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 77
        }
      }
    }
  ],
  "Description": "Enterprise-wide directional application",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "non",
      "StrippedValue": "quia",
      "Description": "Open-source intangible circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "quia",
      "Description": "Open-source intangible circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Diverse radical local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "dolor",
      "Description": "Diverse radical local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 629
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "minima",
      "StrippedValue": "error",
      "Description": "Public-key mission-critical neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "error",
      "Description": "Public-key mission-critical neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 836
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ea",
      "StrippedValue": "alias",
      "Description": "Secured needs-based function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 426
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "alias",
      "Description": "Secured needs-based function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 426
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "velit",
      "StrippedValue": "consequatur",
      "Description": "Customizable content-based access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 457
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "consequatur",
      "Description": "Customizable content-based access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 457
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
      "Id": 574,
      "Name": "Fritsch-Grimes",
      "ToolTip": "Ut qui exercitationem.",
      "Deleted": false,
      "Rank": 665,
      "Type": "placeat",
      "ColorBlock": 534,
      "IconHint": "quas",
      "Selected": true,
      "LastChanged": "2015-07-30T13:13:31.7925901+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eveniet",
      "StyleHint": "iure",
      "Hidden": false,
      "FullName": "Annalise Kozey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 440
        }
      }
    }
  ],
  "PersonNumber": "580595",
  "FullName": "Manuela Bernier",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "dolorem",
      "StrippedValue": "provident",
      "Description": "Business-focused dedicated ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "provident",
      "Description": "Business-focused dedicated ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 714
        }
      }
    }
  ],
  "FormalName": "Fahey LLC",
  "Address": null,
  "Post3": "quis",
  "Post2": "exercitationem",
  "Post1": "rerum",
  "Kanalname": "id",
  "Kanafname": "distinctio",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "tenetur",
  "ActiveInterests": 536,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 511,
  "DbiKey": "eveniet",
  "DbiLastModified": "2021-12-27T13:13:31.808215+01:00",
  "DbiLastSyncronized": "2022-11-10T13:13:31.808215+01:00",
  "SentInfo": 200,
  "ShowContactTickets": 815,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "dolorem",
      "StrippedValue": "asperiores",
      "Description": "Reactive directional infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 929
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "asperiores",
      "Description": "Reactive directional infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 929
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Horizontal regional infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "aut",
      "Description": "Horizontal regional infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    }
  ],
  "Source": 871,
  "ActiveErpLinks": 195,
  "ShipmentTypes": [
    {
      "Id": 273,
      "Name": "Cremin-Sawayn",
      "ToolTip": "Consequatur ut et deleniti ex omnis aut.",
      "Deleted": false,
      "Rank": 323,
      "Type": "quisquam",
      "ColorBlock": 961,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2006-06-21T13:13:31.808215+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "expedita",
      "Hidden": false,
      "FullName": "Ms. Urban Hansen MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 479
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 676,
      "Comment": "id",
      "Registered": "2007-04-14T13:13:31.808215+02:00",
      "RegisteredAssociateId": 123,
      "Updated": "2011-12-20T13:13:31.808215+01:00",
      "UpdatedAssociateId": 932,
      "LegalBaseId": 892,
      "LegalBaseKey": "nostrum",
      "LegalBaseName": "Deckow, Mosciski and Haley",
      "ConsentPurposeId": 672,
      "ConsentPurposeKey": "maiores",
      "ConsentPurposeName": "Huel, Stokes and Swift",
      "ConsentSourceId": 661,
      "ConsentSourceKey": "quasi",
      "ConsentSourceName": "Sporer, Lueilwitz and Hodkiewicz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 664
        }
      }
    }
  ],
  "BounceEmails": [
    "salvador_walsh@grant.ca",
    "moshe.jast@roob.com"
  ],
  "ActiveStatusMonitorId": 199,
  "CreatedByFormId": 705,
  "UserDefinedFields": {
    "SuperOffice:1": "Ethelyn Schulist",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "accusamus",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "architecto",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 399
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```