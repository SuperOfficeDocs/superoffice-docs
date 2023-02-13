---
title: PUT Contact/{id}
uid: v1ContactEntity_PutContactEntity
---

# PUT Contact/{id}

```http
PUT /api/v1/Contact/{id}
```

Updates the existing ContactEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The ContactEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Contact/{id}?$select=name,department,category/id
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

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

ContactEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity updated. |
| 412 | Update stopped because ContactEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 436,
  "Name": "Witting, Kuhic and Hoppe",
  "Department": "",
  "OrgNr": "1221361",
  "Number1": "947705",
  "Number2": "685611",
  "UpdatedDate": "2002-03-10T11:22:44.4913885+01:00",
  "CreatedDate": "2012-08-27T11:22:44.4913885+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "fuga",
      "Description": "De-engineered multimedia moratorium"
    },
    {
      "Value": "qui",
      "StrippedValue": "fuga",
      "Description": "De-engineered multimedia moratorium"
    }
  ],
  "Interests": [
    {
      "Id": 563,
      "Name": "Balistreri-Corwin",
      "ToolTip": "Corporis quae.",
      "Deleted": false,
      "Rank": 533,
      "Type": "consequatur",
      "ColorBlock": 881,
      "IconHint": "modi",
      "Selected": false,
      "LastChanged": "1996-11-28T11:22:44.4913885+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequuntur",
      "StyleHint": "quibusdam",
      "Hidden": true,
      "FullName": "Katarina Dedrick Bernhard MD"
    }
  ],
  "Urls": [
    {
      "Value": "enim",
      "StrippedValue": "sint",
      "Description": "Business-focused system-worthy initiative"
    },
    {
      "Value": "enim",
      "StrippedValue": "sint",
      "Description": "Business-focused system-worthy initiative"
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "adipisci",
      "Description": "Advanced transitional hardware"
    },
    {
      "Value": "et",
      "StrippedValue": "adipisci",
      "Description": "Advanced transitional hardware"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "debitis",
      "Description": "Re-contextualized dedicated neural-net"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "debitis",
      "Description": "Re-contextualized dedicated neural-net"
    }
  ],
  "Description": "Cross-platform didactic moratorium",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "doloremque",
      "PersonId": 336,
      "Mrmrs": "harum",
      "Firstname": "Hailie",
      "Lastname": "Ratke",
      "MiddleName": "Strosin, Emard and Flatley",
      "Title": "iste",
      "Description": "Sharable intermediate installation",
      "Email": "clement@dickinsonkuhn.ca",
      "FullName": "Miss Lilly Amir Veum",
      "DirectPhone": "(818)027-2541",
      "FormalName": "Effertz, Murazik and Ondricka",
      "CountryId": 330,
      "ContactId": 850,
      "ContactName": "Prosacco, Kerluke and Jerde",
      "Retired": 432,
      "Rank": 595,
      "ActiveInterests": 239,
      "ContactDepartment": "",
      "ContactCountryId": 176,
      "ContactOrgNr": "1573282",
      "FaxPhone": "(003)875-2632 x7675",
      "MobilePhone": "1-143-150-9623 x093",
      "ContactPhone": "(145)155-9731",
      "AssociateName": "Rosenbaum, Kub and Kulas",
      "AssociateId": 842,
      "UsePersonAddress": true,
      "ContactFax": "consequatur",
      "Kanafname": "accusantium",
      "Kanalname": "quia",
      "Post1": "assumenda",
      "Post2": "et",
      "Post3": "maiores",
      "EmailName": "fritz@brown.info",
      "ContactFullName": "Jarred Rodriguez",
      "ActiveErpLinks": 694,
      "TicketPriorityId": 616,
      "SupportLanguageId": 879,
      "SupportAssociateId": 1002,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "dignissimos",
  "Xstop": false,
  "ActiveInterests": 507,
  "GroupId": 937,
  "ActiveStatusMonitorId": 458,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 97,
  "DbiAgentId": 846,
  "DbiLastSyncronized": "1996-11-01T11:22:44.5070076+01:00",
  "DbiKey": "dolores",
  "DbiLastModified": "2007-10-23T11:22:44.5070076+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 387,
  "ActiveErpLinks": 114,
  "BounceEmails": [
    "destinee@pfeffer.name",
    "gerson_kerluke@jast.us"
  ],
  "Domains": [
    "harum",
    "quod"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "823733588",
    "SuperOffice:2": "Velda Johnston"
  },
  "ExtraFields": {
    "ExtraFields1": "architecto",
    "ExtraFields2": "molestiae"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "quia"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity updated.
Content-Type: application/json; charset=utf-8

{
  "ContactId": 287,
  "Name": "O'Conner, Breitenberg and Wintheiser",
  "Department": "",
  "OrgNr": "851315",
  "Number1": "1095432",
  "Number2": "297184",
  "UpdatedDate": "2021-03-14T11:22:44.5070076+01:00",
  "CreatedDate": "2022-09-08T11:22:44.5070076+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "officia",
      "Description": "Cross-platform leading edge implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 323
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "officia",
      "Description": "Cross-platform leading edge implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 323
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 305,
      "Name": "Pollich, Mosciski and Fritsch",
      "ToolTip": "Cumque et culpa qui dolor occaecati.",
      "Deleted": true,
      "Rank": 651,
      "Type": "neque",
      "ColorBlock": 73,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "1998-08-31T11:22:44.5070076+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vero",
      "StyleHint": "mollitia",
      "Hidden": false,
      "FullName": "Bud Schultz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "recusandae",
      "StrippedValue": "quo",
      "Description": "Object-based local open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "quo",
      "Description": "Object-based local open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 588
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "consequatur",
      "Description": "Multi-tiered leading edge knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "consequatur",
      "Description": "Multi-tiered leading edge knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 513
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eum",
      "StrippedValue": "omnis",
      "Description": "Automated responsive projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 431
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "omnis",
      "Description": "Automated responsive projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 431
        }
      }
    }
  ],
  "Description": "Robust next generation methodology",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "officia",
      "PersonId": 988,
      "Mrmrs": "in",
      "Firstname": "Karlie",
      "Lastname": "Kulas",
      "MiddleName": "Considine LLC",
      "Title": "dicta",
      "Description": "Diverse disintermediate encryption",
      "Email": "roscoe.bartoletti@hickle.co.uk",
      "FullName": "Demetris Bailey",
      "DirectPhone": "1-225-129-0869 x75313",
      "FormalName": "Greenholt LLC",
      "CountryId": 196,
      "ContactId": 920,
      "ContactName": "Schamberger Inc and Sons",
      "Retired": 335,
      "Rank": 731,
      "ActiveInterests": 707,
      "ContactDepartment": "",
      "ContactCountryId": 87,
      "ContactOrgNr": "1137915",
      "FaxPhone": "642-861-1848",
      "MobilePhone": "1-669-128-6444 x567",
      "ContactPhone": "1-212-928-4558",
      "AssociateName": "Turner LLC",
      "AssociateId": 768,
      "UsePersonAddress": false,
      "ContactFax": "a",
      "Kanafname": "quam",
      "Kanalname": "aliquam",
      "Post1": "voluptate",
      "Post2": "perferendis",
      "Post3": "quo",
      "EmailName": "porter@harber.co.uk",
      "ContactFullName": "Ms. Kane Eleazar Frami II",
      "ActiveErpLinks": 5,
      "TicketPriorityId": 255,
      "SupportLanguageId": 429,
      "SupportAssociateId": 867,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 14
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "in",
  "Xstop": false,
  "ActiveInterests": 891,
  "GroupId": 900,
  "ActiveStatusMonitorId": 376,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 262,
  "DbiAgentId": 960,
  "DbiLastSyncronized": "2002-07-26T11:22:44.5070076+02:00",
  "DbiKey": "nobis",
  "DbiLastModified": "2021-07-20T11:22:44.5070076+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 439,
  "ActiveErpLinks": 172,
  "BounceEmails": [
    "heaven@wizaspencer.biz",
    "mallie.walker@runolfsson.co.uk"
  ],
  "Domains": [
    "voluptatem",
    "error"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Ervin Botsford"
  },
  "ExtraFields": {
    "ExtraFields1": "nulla",
    "ExtraFields2": "in"
  },
  "CustomFields": {
    "CustomFields1": "labore",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 631
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```