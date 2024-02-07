---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 50,
  "Name": "Mayer LLC",
  "Department": "synthesize collaborative interfaces",
  "OrgNr": "963820",
  "Number1": "957245",
  "Number2": "1027107",
  "UpdatedDate": "2011-04-08T16:55:29.4133356+02:00",
  "CreatedDate": "2006-02-04T16:55:29.4133356+01:00",
  "Emails": [
    {
      "Value": "maxime",
      "StrippedValue": "enim",
      "Description": "Object-based methodical array"
    },
    {
      "Value": "maxime",
      "StrippedValue": "enim",
      "Description": "Object-based methodical array"
    }
  ],
  "Interests": [
    {
      "Id": 643,
      "Name": "Rolfson, Pollich and Wisozk",
      "ToolTip": "Inventore beatae corrupti.",
      "Deleted": false,
      "Rank": 264,
      "Type": "maiores",
      "ColorBlock": 650,
      "IconHint": "qui",
      "Selected": false,
      "LastChanged": "2016-09-03T16:55:29.4133356+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "alias",
      "Hidden": false,
      "FullName": "Mrs. Sofia Maggio II"
    }
  ],
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "quis",
      "Description": "Fully-configurable heuristic firmware"
    },
    {
      "Value": "ut",
      "StrippedValue": "quis",
      "Description": "Fully-configurable heuristic firmware"
    }
  ],
  "Phones": [
    {
      "Value": "libero",
      "StrippedValue": "eum",
      "Description": "Monitored upward-trending archive"
    },
    {
      "Value": "libero",
      "StrippedValue": "eum",
      "Description": "Monitored upward-trending archive"
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "vero",
      "Description": "Progressive foreground open architecture"
    },
    {
      "Value": "est",
      "StrippedValue": "vero",
      "Description": "Progressive foreground open architecture"
    }
  ],
  "Description": "Compatible user-facing matrix",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 624,
      "Mrmrs": "perspiciatis",
      "Firstname": "Anne",
      "Lastname": "Crooks",
      "MiddleName": "Moen Inc and Sons",
      "Title": "in",
      "Description": "Polarised system-worthy challenge",
      "Email": "hoyt@welch.us",
      "FullName": "Gennaro Klein",
      "DirectPhone": "115.962.2195 x85304",
      "FormalName": "Raynor-Cummerata",
      "CountryId": 463,
      "ContactId": 30,
      "ContactName": "Trantow, Cummerata and Turner",
      "Retired": 83,
      "Rank": 61,
      "ActiveInterests": 753,
      "ContactDepartment": "expedite front-end channels",
      "ContactCountryId": 876,
      "ContactOrgNr": "1303383",
      "FaxPhone": "1-503-441-9779",
      "MobilePhone": "251-416-0159 x4965",
      "ContactPhone": "(296)289-1916 x5709",
      "AssociateName": "Schroeder-Hauck",
      "AssociateId": 687,
      "UsePersonAddress": true,
      "ContactFax": "itaque",
      "Kanafname": "in",
      "Kanalname": "ut",
      "Post1": "nisi",
      "Post2": "vel",
      "Post3": "voluptas",
      "EmailName": "domenico.torp@cassinfahey.ca",
      "ContactFullName": "Johnnie Reichert",
      "ActiveErpLinks": 902,
      "TicketPriorityId": 834,
      "SupportLanguageId": 655,
      "SupportAssociateId": 510,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "totam",
  "Xstop": true,
  "ActiveInterests": 805,
  "GroupId": 899,
  "ActiveStatusMonitorId": 766,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 894,
  "DbiAgentId": 837,
  "DbiLastSyncronized": "2021-11-24T16:55:29.4173367+01:00",
  "DbiKey": "rerum",
  "DbiLastModified": "2005-02-22T16:55:29.4173367+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 912,
  "ActiveErpLinks": 4,
  "BounceEmails": [
    "angus_okon@donnellybogisich.info",
    "emilia@jenkins.us"
  ],
  "Domains": [
    "consequatur",
    "laborum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Jacky Uriah Strosin IV",
    "SuperOffice:2": "Helen Alysa Kunze V"
  },
  "ExtraFields": {
    "ExtraFields1": "at",
    "ExtraFields2": "reprehenderit"
  },
  "CustomFields": {
    "CustomFields1": "hic",
    "CustomFields2": "nisi"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 624,
  "Name": "Jacobi LLC",
  "Department": "",
  "OrgNr": "1022705",
  "Number1": "381747",
  "Number2": "531375",
  "UpdatedDate": "2008-10-16T16:55:29.4253343+02:00",
  "CreatedDate": "2011-08-06T16:55:29.4253343+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "est",
      "Description": "Assimilated bi-directional access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "est",
      "Description": "Assimilated bi-directional access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 685
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 244,
      "Name": "Carroll Group",
      "ToolTip": "Modi et qui et.",
      "Deleted": true,
      "Rank": 510,
      "Type": "a",
      "ColorBlock": 902,
      "IconHint": "temporibus",
      "Selected": false,
      "LastChanged": "2010-10-16T16:55:29.4263411+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "possimus",
      "StyleHint": "dolorem",
      "Hidden": true,
      "FullName": "Mr. Susana Gabe Leffler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 898
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "corporis",
      "Description": "Fundamental grid-enabled matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 966
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "corporis",
      "Description": "Fundamental grid-enabled matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 966
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nulla",
      "StrippedValue": "repellat",
      "Description": "Open-architected content-based budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 201
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "repellat",
      "Description": "Open-architected content-based budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 201
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "reiciendis",
      "StrippedValue": "est",
      "Description": "Synergized eco-centric ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 997
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "est",
      "Description": "Synergized eco-centric ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 997
        }
      }
    }
  ],
  "Description": "Programmable eco-centric knowledge user",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eos",
      "PersonId": 2,
      "Mrmrs": "nam",
      "Firstname": "Gordon",
      "Lastname": "Purdy",
      "MiddleName": "Glover Group",
      "Title": "doloremque",
      "Description": "Virtual content-based groupware",
      "Email": "dayna.deckow@kerlukegaylord.info",
      "FullName": "Dimitri Jacobs",
      "DirectPhone": "802-256-9716",
      "FormalName": "Prohaska, Shanahan and Stanton",
      "CountryId": 869,
      "ContactId": 137,
      "ContactName": "Adams, Schamberger and Von",
      "Retired": 247,
      "Rank": 526,
      "ActiveInterests": 843,
      "ContactDepartment": "",
      "ContactCountryId": 207,
      "ContactOrgNr": "472170",
      "FaxPhone": "894.866.9431 x3340",
      "MobilePhone": "272.778.2925",
      "ContactPhone": "1-539-558-5980 x6716",
      "AssociateName": "Jakubowski, Steuber and Waelchi",
      "AssociateId": 432,
      "UsePersonAddress": false,
      "ContactFax": "voluptatem",
      "Kanafname": "autem",
      "Kanalname": "eveniet",
      "Post1": "repellat",
      "Post2": "molestiae",
      "Post3": "animi",
      "EmailName": "nicholaus@gulgowskioconner.co.uk",
      "ContactFullName": "Meagan Jacobi",
      "ActiveErpLinks": 615,
      "TicketPriorityId": 103,
      "SupportLanguageId": 532,
      "SupportAssociateId": 355,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 558
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatem",
  "Xstop": true,
  "ActiveInterests": 547,
  "GroupId": 24,
  "ActiveStatusMonitorId": 61,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 501,
  "DbiAgentId": 573,
  "DbiLastSyncronized": "2011-07-29T16:55:29.4293352+02:00",
  "DbiKey": "molestiae",
  "DbiLastModified": "2014-10-17T16:55:29.4293352+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 561,
  "ActiveErpLinks": 498,
  "BounceEmails": [
    "matteo@hillsgleichner.com",
    "malvina_feeney@prosacco.ca"
  ],
  "Domains": [
    "hic",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "786761553"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "non"
  },
  "CustomFields": {
    "CustomFields1": "voluptas",
    "CustomFields2": "saepe"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 637
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```