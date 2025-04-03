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
  "PersonId": 422,
  "Firstname": "Ephraim",
  "MiddleName": "Robel, Rempel and Marvin",
  "Lastname": "Funk",
  "Mrmrs": "excepturi",
  "Title": "blanditiis",
  "UpdatedDate": "2000-10-24T14:28:26.961443+02:00",
  "CreatedDate": "2006-06-17T14:28:26.961443+02:00",
  "BirthDate": "2003-01-17T14:28:26.961443+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sunt",
      "StrippedValue": "sed",
      "Description": "Polarised transitional initiative"
    },
    {
      "Value": "sunt",
      "StrippedValue": "sed",
      "Description": "Polarised transitional initiative"
    }
  ],
  "Description": "Cross-platform foreground time-frame",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "excepturi",
      "StrippedValue": "maxime",
      "Description": "Fundamental reciprocal matrices"
    },
    {
      "Value": "excepturi",
      "StrippedValue": "maxime",
      "Description": "Fundamental reciprocal matrices"
    }
  ],
  "Faxes": [
    {
      "Value": "cupiditate",
      "StrippedValue": "consequatur",
      "Description": "Cross-platform heuristic standardization"
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "consequatur",
      "Description": "Cross-platform heuristic standardization"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quae",
      "StrippedValue": "in",
      "Description": "Front-line 24 hour model"
    },
    {
      "Value": "quae",
      "StrippedValue": "in",
      "Description": "Front-line 24 hour model"
    }
  ],
  "OfficePhones": [
    {
      "Value": "mollitia",
      "StrippedValue": "ipsam",
      "Description": "Cross-group web-enabled instruction set"
    },
    {
      "Value": "mollitia",
      "StrippedValue": "ipsam",
      "Description": "Cross-group web-enabled instruction set"
    }
  ],
  "OtherPhones": [
    {
      "Value": "quas",
      "StrippedValue": "molestiae",
      "Description": "Re-engineered object-oriented complexity"
    },
    {
      "Value": "quas",
      "StrippedValue": "molestiae",
      "Description": "Re-engineered object-oriented complexity"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 368,
      "Name": "Bernhard, Spinka and Windler",
      "ToolTip": "Similique harum nulla ex.",
      "Deleted": true,
      "Rank": 515,
      "Type": "temporibus",
      "ColorBlock": 750,
      "IconHint": "id",
      "Selected": false,
      "LastChanged": "2012-01-20T14:28:26.961443+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "alias",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Mr. Brooks Fredrick Glover PhD"
    }
  ],
  "PersonNumber": "983825",
  "FullName": "Jed Gutkowski",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "soluta",
      "StrippedValue": "nobis",
      "Description": "User-friendly transitional help-desk"
    },
    {
      "Value": "soluta",
      "StrippedValue": "nobis",
      "Description": "User-friendly transitional help-desk"
    }
  ],
  "FormalName": "O'Keefe-Koepp",
  "Address": null,
  "Post3": "et",
  "Post2": "et",
  "Post1": "dolore",
  "Kanalname": "cupiditate",
  "Kanafname": "libero",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptates",
  "ActiveInterests": 256,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 569,
  "DbiKey": "harum",
  "DbiLastModified": "2008-06-08T14:28:26.961443+02:00",
  "DbiLastSyncronized": "2020-11-14T14:28:26.961443+01:00",
  "SentInfo": 301,
  "ShowContactTickets": 890,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "architecto",
      "StrippedValue": "inventore",
      "Description": "Balanced mission-critical hub"
    },
    {
      "Value": "architecto",
      "StrippedValue": "inventore",
      "Description": "Balanced mission-critical hub"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptate",
      "StrippedValue": "quia",
      "Description": "Digitized client-driven initiative"
    },
    {
      "Value": "voluptate",
      "StrippedValue": "quia",
      "Description": "Digitized client-driven initiative"
    }
  ],
  "Source": 389,
  "ActiveErpLinks": 693,
  "ShipmentTypes": [
    {
      "Id": 203,
      "Name": "Morissette LLC",
      "ToolTip": "Vitae dolorum.",
      "Deleted": false,
      "Rank": 596,
      "Type": "voluptas",
      "ColorBlock": 271,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2009-12-19T14:28:26.961443+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "voluptate",
      "Hidden": false,
      "FullName": "Joaquin Heidenreich"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 65,
      "Comment": "vel",
      "Registered": "2018-03-31T14:28:26.961443+02:00",
      "RegisteredAssociateId": 35,
      "Updated": "2014-01-19T14:28:26.961443+01:00",
      "UpdatedAssociateId": 723,
      "LegalBaseId": 806,
      "LegalBaseKey": "unde",
      "LegalBaseName": "Gislason Group",
      "ConsentPurposeId": 37,
      "ConsentPurposeKey": "natus",
      "ConsentPurposeName": "Powlowski, Collins and Goyette",
      "ConsentSourceId": 384,
      "ConsentSourceKey": "qui",
      "ConsentSourceName": "Brekke LLC"
    }
  ],
  "BounceEmails": [
    "nigel@aufderhar.ca",
    "logan_langworth@zulauflesch.com"
  ],
  "ActiveStatusMonitorId": 415,
  "CreatedByFormId": 334,
  "UserDefinedFields": {
    "SuperOffice:1": "Kelsi Johns",
    "SuperOffice:2": "Glen Breitenberg"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquam",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "beatae",
    "CustomFields2": "aliquam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 639,
  "Firstname": "Beaulah",
  "MiddleName": "Toy-Weissnat",
  "Lastname": "Lindgren",
  "Mrmrs": "rem",
  "Title": "sapiente",
  "UpdatedDate": "2025-02-21T14:28:26.9770674+01:00",
  "CreatedDate": "2009-10-15T14:28:26.9770674+02:00",
  "BirthDate": "2017-09-11T14:28:26.9770674+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "animi",
      "StrippedValue": "rerum",
      "Description": "Reactive real-time budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 575
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "rerum",
      "Description": "Reactive real-time budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 575
        }
      }
    }
  ],
  "Description": "Configurable object-oriented synergy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "laborum",
      "StrippedValue": "vero",
      "Description": "Innovative optimizing secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 889
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "vero",
      "Description": "Innovative optimizing secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 889
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "autem",
      "Description": "Multi-channelled bandwidth-monitored moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 279
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "autem",
      "Description": "Multi-channelled bandwidth-monitored moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 279
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "excepturi",
      "StrippedValue": "atque",
      "Description": "Object-based stable functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "atque",
      "Description": "Object-based stable functionalities",
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
  "OfficePhones": [
    {
      "Value": "repudiandae",
      "StrippedValue": "nostrum",
      "Description": "Polarised leading edge help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "nostrum",
      "Description": "Polarised leading edge help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 455
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "similique",
      "Description": "Synergized full-range application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "similique",
      "Description": "Synergized full-range application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 969
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
      "Id": 908,
      "Name": "Vandervort LLC",
      "ToolTip": "Tempora temporibus ut porro a temporibus autem.",
      "Deleted": false,
      "Rank": 346,
      "Type": "voluptatem",
      "ColorBlock": 541,
      "IconHint": "velit",
      "Selected": false,
      "LastChanged": "2010-01-29T14:28:26.9770674+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "corrupti",
      "Hidden": true,
      "FullName": "Krystel Stamm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 325
        }
      }
    }
  ],
  "PersonNumber": "186663",
  "FullName": "Salvatore Metz",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "labore",
      "Description": "Business-focused tertiary firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "labore",
      "Description": "Business-focused tertiary firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    }
  ],
  "FormalName": "O'Kon Inc and Sons",
  "Address": null,
  "Post3": "consectetur",
  "Post2": "in",
  "Post1": "accusamus",
  "Kanalname": "sint",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "tempora",
  "ActiveInterests": 116,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 386,
  "DbiKey": "voluptates",
  "DbiLastModified": "2022-05-04T14:28:26.9770674+02:00",
  "DbiLastSyncronized": "2020-04-28T14:28:26.9770674+02:00",
  "SentInfo": 583,
  "ShowContactTickets": 738,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "mollitia",
      "StrippedValue": "voluptas",
      "Description": "Robust homogeneous artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "voluptas",
      "Description": "Robust homogeneous artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 604
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "magnam",
      "Description": "Assimilated 3rd generation firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "magnam",
      "Description": "Assimilated 3rd generation firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 436
        }
      }
    }
  ],
  "Source": 791,
  "ActiveErpLinks": 395,
  "ShipmentTypes": [
    {
      "Id": 62,
      "Name": "Conn, Daugherty and Considine",
      "ToolTip": "Nam dicta repudiandae officiis sint libero similique molestias.",
      "Deleted": false,
      "Rank": 582,
      "Type": "eum",
      "ColorBlock": 517,
      "IconHint": "qui",
      "Selected": false,
      "LastChanged": "2021-01-26T14:28:26.9770674+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "impedit",
      "Hidden": false,
      "FullName": "Charlie Medhurst",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 700
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 282,
      "Comment": "aut",
      "Registered": "2005-08-10T14:28:26.9770674+02:00",
      "RegisteredAssociateId": 874,
      "Updated": "2019-08-16T14:28:26.9770674+02:00",
      "UpdatedAssociateId": 619,
      "LegalBaseId": 419,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Kohler-Gulgowski",
      "ConsentPurposeId": 122,
      "ConsentPurposeKey": "veritatis",
      "ConsentPurposeName": "Stoltenberg Group",
      "ConsentSourceId": 432,
      "ConsentSourceKey": "dolorum",
      "ConsentSourceName": "Morar-Kautzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 493
        }
      }
    }
  ],
  "BounceEmails": [
    "amara_herman@koelpin.info",
    "walton@gottliebcorkery.co.uk"
  ],
  "ActiveStatusMonitorId": 499,
  "CreatedByFormId": 135,
  "UserDefinedFields": {
    "SuperOffice:1": "Sonny Armstrong",
    "SuperOffice:2": "Kaylin Gaylord"
  },
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 345
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```