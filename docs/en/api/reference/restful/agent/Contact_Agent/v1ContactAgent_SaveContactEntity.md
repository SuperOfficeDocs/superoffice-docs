---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 327,
  "Name": "Runte, Conroy and Kuphal",
  "Department": "",
  "OrgNr": "1544540",
  "Number1": "664977",
  "Number2": "711919",
  "UpdatedDate": "2011-06-12T13:28:22.2105528+02:00",
  "CreatedDate": "2016-07-21T13:28:22.2105528+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Implemented impactful forecast"
    },
    {
      "Value": "qui",
      "StrippedValue": "et",
      "Description": "Implemented impactful forecast"
    }
  ],
  "Interests": [
    {
      "Id": 989,
      "Name": "Gleason-Daniel",
      "ToolTip": "Nesciunt commodi.",
      "Deleted": true,
      "Rank": 366,
      "Type": "et",
      "ColorBlock": 960,
      "IconHint": "nobis",
      "Selected": true,
      "LastChanged": "2018-09-07T13:28:22.2105528+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "temporibus",
      "StyleHint": "tempora",
      "Hidden": true,
      "FullName": "Coty Kris"
    }
  ],
  "Urls": [
    {
      "Value": "voluptatem",
      "StrippedValue": "beatae",
      "Description": "Exclusive directional algorithm"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "beatae",
      "Description": "Exclusive directional algorithm"
    }
  ],
  "Phones": [
    {
      "Value": "a",
      "StrippedValue": "et",
      "Description": "Centralized local leverage"
    },
    {
      "Value": "a",
      "StrippedValue": "et",
      "Description": "Centralized local leverage"
    }
  ],
  "Faxes": [
    {
      "Value": "porro",
      "StrippedValue": "et",
      "Description": "Persevering global software"
    },
    {
      "Value": "porro",
      "StrippedValue": "et",
      "Description": "Persevering global software"
    }
  ],
  "Description": "Persistent multi-tasking algorithm",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "velit",
      "PersonId": 772,
      "Mrmrs": "aspernatur",
      "Firstname": "Mallory",
      "Lastname": "Mosciski",
      "MiddleName": "Lang-Lowe",
      "Title": "ut",
      "Description": "Right-sized even-keeled pricing structure",
      "Email": "marjorie@williamsondietrich.name",
      "FullName": "Prof. Kirsten Ivy Braun II",
      "DirectPhone": "227-984-3549",
      "FormalName": "Howe-Hoeger",
      "CountryId": 968,
      "ContactId": 812,
      "ContactName": "Emmerich, Quigley and Cremin",
      "Retired": 943,
      "Rank": 385,
      "ActiveInterests": 160,
      "ContactDepartment": "",
      "ContactCountryId": 936,
      "ContactOrgNr": "231071",
      "FaxPhone": "1-732-196-3250",
      "MobilePhone": "992.115.7527 x7192",
      "ContactPhone": "1-222-748-3277 x62542",
      "AssociateName": "Blick LLC",
      "AssociateId": 846,
      "UsePersonAddress": true,
      "ContactFax": "ut",
      "Kanafname": "necessitatibus",
      "Kanalname": "dolor",
      "Post1": "laborum",
      "Post2": "eos",
      "Post3": "veritatis",
      "EmailName": "brandy_flatley@bergnaum.ca",
      "ContactFullName": "Prof. Candido Bernhard MD",
      "ActiveErpLinks": 710,
      "TicketPriorityId": 799,
      "SupportLanguageId": 732,
      "SupportAssociateId": 870,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "ipsum",
  "Xstop": true,
  "ActiveInterests": 774,
  "GroupId": 515,
  "ActiveStatusMonitorId": 158,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 812,
  "DbiAgentId": 153,
  "DbiLastSyncronized": "1998-03-23T13:28:22.2105528+01:00",
  "DbiKey": "est",
  "DbiLastModified": "2021-03-25T13:28:22.2105528+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 318,
  "ActiveErpLinks": 132,
  "BounceEmails": [
    "gabriella.blanda@bechtelar.uk",
    "callie_wolf@crona.name"
  ],
  "Domains": [
    "eligendi",
    "quibusdam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Julio Lloyd Klocko",
    "SuperOffice:2": "1486745731"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "facere",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 209,
  "Name": "Lehner, Anderson and O'Conner",
  "Department": "productize revolutionary supply-chains",
  "OrgNr": "954189",
  "Number1": "557800",
  "Number2": "1322776",
  "UpdatedDate": "2013-08-21T13:28:22.2261744+02:00",
  "CreatedDate": "2001-11-14T13:28:22.2261744+01:00",
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "quis",
      "Description": "Reactive directional Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "quis",
      "Description": "Reactive directional Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 355
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 498,
      "Name": "Emard, Jast and Hackett",
      "ToolTip": "Error consectetur ut velit.",
      "Deleted": true,
      "Rank": 571,
      "Type": "suscipit",
      "ColorBlock": 465,
      "IconHint": "ab",
      "Selected": false,
      "LastChanged": "2017-10-25T13:28:22.2261744+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "beatae",
      "StyleHint": "hic",
      "Hidden": false,
      "FullName": "Rickie Mayer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 424
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "error",
      "StrippedValue": "itaque",
      "Description": "Focused directional methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 594
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "itaque",
      "Description": "Focused directional methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 594
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "velit",
      "StrippedValue": "hic",
      "Description": "Open-architected human-resource matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "hic",
      "Description": "Open-architected human-resource matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "pariatur",
      "StrippedValue": "fugiat",
      "Description": "Innovative client-server system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 737
        }
      }
    },
    {
      "Value": "pariatur",
      "StrippedValue": "fugiat",
      "Description": "Innovative client-server system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 737
        }
      }
    }
  ],
  "Description": "Robust local focus group",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "totam",
      "PersonId": 249,
      "Mrmrs": "dolorem",
      "Firstname": "Russel",
      "Lastname": "Stoltenberg",
      "MiddleName": "Schoen-Greenfelder",
      "Title": "nam",
      "Description": "Compatible logistical implementation",
      "Email": "jarred@pagac.com",
      "FullName": "Emilio Greenholt",
      "DirectPhone": "(515)137-9219 x1257",
      "FormalName": "Shields, Marks and Braun",
      "CountryId": 893,
      "ContactId": 764,
      "ContactName": "Lehner, Shanahan and Kozey",
      "Retired": 998,
      "Rank": 100,
      "ActiveInterests": 788,
      "ContactDepartment": "",
      "ContactCountryId": 454,
      "ContactOrgNr": "1444942",
      "FaxPhone": "1-094-928-0656 x2839",
      "MobilePhone": "016.367.7491",
      "ContactPhone": "659.697.1439",
      "AssociateName": "Sauer-Crooks",
      "AssociateId": 157,
      "UsePersonAddress": false,
      "ContactFax": "non",
      "Kanafname": "vel",
      "Kanalname": "enim",
      "Post1": "sit",
      "Post2": "assumenda",
      "Post3": "assumenda",
      "EmailName": "christine@dibbertcorwin.us",
      "ContactFullName": "Prof. Helene Tyrell Dickens",
      "ActiveErpLinks": 552,
      "TicketPriorityId": 171,
      "SupportLanguageId": 557,
      "SupportAssociateId": 386,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "deleniti",
  "Xstop": false,
  "ActiveInterests": 569,
  "GroupId": 617,
  "ActiveStatusMonitorId": 177,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 409,
  "DbiAgentId": 760,
  "DbiLastSyncronized": "2021-07-11T13:28:22.2261744+02:00",
  "DbiKey": "consectetur",
  "DbiLastModified": "2015-06-14T13:28:22.2261744+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 366,
  "ActiveErpLinks": 506,
  "BounceEmails": [
    "veronica.friesen@bogisichpowlowski.name",
    "merle.hessel@oreilly.com"
  ],
  "Domains": [
    "hic",
    "voluptas"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Otilia Anderson",
    "SuperOffice:2": "Tania Purdy"
  },
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 866
    }
  }
}
```