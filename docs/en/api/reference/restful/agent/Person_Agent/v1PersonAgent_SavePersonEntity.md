---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 256,
  "Firstname": "Evangeline",
  "MiddleName": "McKenzie-Haley",
  "Lastname": "Wilkinson",
  "Mrmrs": "ratione",
  "Title": "mollitia",
  "UpdatedDate": "2005-04-05T23:03:56.3806237+02:00",
  "CreatedDate": "2016-09-26T23:03:56.3806237+02:00",
  "BirthDate": "1997-11-30T23:03:56.3806237+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "fugit",
      "StrippedValue": "perspiciatis",
      "Description": "Pre-emptive multi-state monitoring"
    },
    {
      "Value": "fugit",
      "StrippedValue": "perspiciatis",
      "Description": "Pre-emptive multi-state monitoring"
    }
  ],
  "Description": "Ergonomic logistical capacity",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Open-source methodical attitude"
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptas",
      "Description": "Open-source methodical attitude"
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "ex",
      "Description": "Horizontal 4th generation benchmark"
    },
    {
      "Value": "qui",
      "StrippedValue": "ex",
      "Description": "Horizontal 4th generation benchmark"
    }
  ],
  "MobilePhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "sed",
      "Description": "Diverse 3rd generation standardization"
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "sed",
      "Description": "Diverse 3rd generation standardization"
    }
  ],
  "OfficePhones": [
    {
      "Value": "labore",
      "StrippedValue": "eum",
      "Description": "Grass-roots grid-enabled policy"
    },
    {
      "Value": "labore",
      "StrippedValue": "eum",
      "Description": "Grass-roots grid-enabled policy"
    }
  ],
  "OtherPhones": [
    {
      "Value": "aut",
      "StrippedValue": "labore",
      "Description": "Right-sized content-based solution"
    },
    {
      "Value": "aut",
      "StrippedValue": "labore",
      "Description": "Right-sized content-based solution"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 197,
      "Name": "Ryan Group",
      "ToolTip": "Iure architecto doloremque quisquam voluptatum et sit.",
      "Deleted": false,
      "Rank": 794,
      "Type": "cupiditate",
      "ColorBlock": 664,
      "IconHint": "eligendi",
      "Selected": false,
      "LastChanged": "2023-07-29T23:03:56.3841257+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "placeat",
      "Hidden": false,
      "FullName": "Judd Jast"
    }
  ],
  "PersonNumber": "1054057",
  "FullName": "Edward Ledner",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "molestiae",
      "StrippedValue": "quisquam",
      "Description": "Seamless content-based interface"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "quisquam",
      "Description": "Seamless content-based interface"
    }
  ],
  "FormalName": "Wolf-Rau",
  "Address": null,
  "Post3": "qui",
  "Post2": "minima",
  "Post1": "omnis",
  "Kanalname": "id",
  "Kanafname": "rem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quia",
  "ActiveInterests": 51,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 443,
  "DbiKey": "alias",
  "DbiLastModified": "1997-04-26T23:03:56.3866236+02:00",
  "DbiLastSyncronized": "2014-12-22T23:03:56.3866236+01:00",
  "SentInfo": 533,
  "ShowContactTickets": 978,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quo",
      "StrippedValue": "error",
      "Description": "Business-focused coherent support"
    },
    {
      "Value": "quo",
      "StrippedValue": "error",
      "Description": "Business-focused coherent support"
    }
  ],
  "InternetPhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "natus",
      "Description": "Inverse regional protocol"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "natus",
      "Description": "Inverse regional protocol"
    }
  ],
  "Source": 28,
  "ActiveErpLinks": 32,
  "ShipmentTypes": [
    {
      "Id": 370,
      "Name": "Buckridge LLC",
      "ToolTip": "Architecto error optio porro occaecati.",
      "Deleted": false,
      "Rank": 268,
      "Type": "et",
      "ColorBlock": 97,
      "IconHint": "veniam",
      "Selected": false,
      "LastChanged": "2018-10-27T23:03:56.3871238+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "rem",
      "StyleHint": "voluptas",
      "Hidden": true,
      "FullName": "Rocio Reymundo Swaniawski PhD"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 940,
      "Comment": "ut",
      "Registered": "1998-10-02T23:03:56.3876241+02:00",
      "RegisteredAssociateId": 182,
      "Updated": "2002-06-27T23:03:56.3876241+02:00",
      "UpdatedAssociateId": 465,
      "LegalBaseId": 341,
      "LegalBaseKey": "consequatur",
      "LegalBaseName": "Sanford LLC",
      "ConsentPurposeId": 492,
      "ConsentPurposeKey": "nihil",
      "ConsentPurposeName": "Bartell-Runte",
      "ConsentSourceId": 453,
      "ConsentSourceKey": "sit",
      "ConsentSourceName": "Robel Inc and Sons"
    }
  ],
  "BounceEmails": [
    "annie.hagenes@king.info",
    "javier.bauch@daniel.com"
  ],
  "ActiveStatusMonitorId": 126,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Maribel Moore",
    "SuperOffice:2": "Kasandra Watsica"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "excepturi"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "vitae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 749,
  "Firstname": "Aleen",
  "MiddleName": "Shanahan-Schumm",
  "Lastname": "Nikolaus",
  "Mrmrs": "atque",
  "Title": "sit",
  "UpdatedDate": "2018-10-26T23:03:56.3966268+02:00",
  "CreatedDate": "2018-07-03T23:03:56.3966268+02:00",
  "BirthDate": "1998-12-16T23:03:56.3966268+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quas",
      "StrippedValue": "nam",
      "Description": "User-centric cohesive pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 766
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "nam",
      "Description": "User-centric cohesive pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 766
        }
      }
    }
  ],
  "Description": "Stand-alone 24/7 analyzer",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "quia",
      "Description": "Digitized holistic Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 965
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "quia",
      "Description": "Digitized holistic Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 965
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ad",
      "StrippedValue": "laudantium",
      "Description": "Upgradable global hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "laudantium",
      "Description": "Upgradable global hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "veritatis",
      "Description": "Adaptive discrete matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "veritatis",
      "Description": "Adaptive discrete matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "animi",
      "StrippedValue": "ullam",
      "Description": "Public-key real-time process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "ullam",
      "Description": "Public-key real-time process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "sapiente",
      "StrippedValue": "sit",
      "Description": "Virtual non-volatile support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
        }
      }
    },
    {
      "Value": "sapiente",
      "StrippedValue": "sit",
      "Description": "Virtual non-volatile support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 104
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
      "Id": 81,
      "Name": "Feest-Kemmer",
      "ToolTip": "Quia ad non.",
      "Deleted": false,
      "Rank": 424,
      "Type": "totam",
      "ColorBlock": 778,
      "IconHint": "quo",
      "Selected": false,
      "LastChanged": "2011-04-26T23:03:56.4001228+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "ipsa",
      "Hidden": false,
      "FullName": "Roosevelt Herman",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 841
        }
      }
    }
  ],
  "PersonNumber": "750100",
  "FullName": "Gilbert Hulda Buckridge DDS",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "odio",
      "StrippedValue": "vero",
      "Description": "Compatible mission-critical projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 851
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "vero",
      "Description": "Compatible mission-critical projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 851
        }
      }
    }
  ],
  "FormalName": "Rau, Wolf and Monahan",
  "Address": null,
  "Post3": "illum",
  "Post2": "deleniti",
  "Post1": "error",
  "Kanalname": "ipsa",
  "Kanafname": "explicabo",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 978,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 337,
  "DbiKey": "est",
  "DbiLastModified": "2002-11-10T23:03:56.4021237+01:00",
  "DbiLastSyncronized": "2004-01-31T23:03:56.4021237+01:00",
  "SentInfo": 675,
  "ShowContactTickets": 933,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "vero",
      "StrippedValue": "voluptas",
      "Description": "Integrated attitude-oriented internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "voluptas",
      "Description": "Integrated attitude-oriented internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 837
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "dolorem",
      "StrippedValue": "molestiae",
      "Description": "Expanded didactic attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "molestiae",
      "Description": "Expanded didactic attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 918
        }
      }
    }
  ],
  "Source": 641,
  "ActiveErpLinks": 491,
  "ShipmentTypes": [
    {
      "Id": 40,
      "Name": "Deckow-Hudson",
      "ToolTip": "Eos iusto voluptates doloribus repellat molestiae ad.",
      "Deleted": false,
      "Rank": 556,
      "Type": "sit",
      "ColorBlock": 200,
      "IconHint": "illum",
      "Selected": false,
      "LastChanged": "1999-08-18T23:03:56.4031237+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "mollitia",
      "StyleHint": "nulla",
      "Hidden": false,
      "FullName": "Mr. Deangelo Hector Schultz I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 386
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 448,
      "Comment": "eligendi",
      "Registered": "2014-12-21T23:03:56.4031237+01:00",
      "RegisteredAssociateId": 697,
      "Updated": "2003-09-29T23:03:56.4031237+02:00",
      "UpdatedAssociateId": 664,
      "LegalBaseId": 286,
      "LegalBaseKey": "minima",
      "LegalBaseName": "Schulist LLC",
      "ConsentPurposeId": 460,
      "ConsentPurposeKey": "expedita",
      "ConsentPurposeName": "Gottlieb-Metz",
      "ConsentSourceId": 422,
      "ConsentSourceKey": "non",
      "ConsentSourceName": "Fritsch Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    }
  ],
  "BounceEmails": [
    "davon.swift@herman.name",
    "bruce_kutch@gibsoncartwright.name"
  ],
  "ActiveStatusMonitorId": 888,
  "UserDefinedFields": {
    "SuperOffice:1": "Cassie Schultz III",
    "SuperOffice:2": "1827427508"
  },
  "ExtraFields": {
    "ExtraFields1": "minima",
    "ExtraFields2": "distinctio"
  },
  "CustomFields": {
    "CustomFields1": "soluta",
    "CustomFields2": "ea"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 494
    }
  }
}
```