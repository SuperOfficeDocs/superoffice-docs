---
title: POST Agents/Contact/EnrichContactEntity
uid: v1ContactAgent_EnrichContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/EnrichContactEntity

```http
POST /api/v1/Agents/Contact/EnrichContactEntity
```

Enrich a contact with data from the AI Enrichment service.


This will update the contact with address, phone number, and email.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/EnrichContactEntity?$select=name,department,category/id
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

ContactEntity, EnrichId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| EnrichId | String |  |

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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/EnrichContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "EnrichId": "illo"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 406,
  "Name": "Rogahn-Gutmann",
  "Department": "",
  "OrgNr": "951016",
  "Number1": "647281",
  "Number2": "439369",
  "UpdatedDate": "2008-08-29T03:41:53.3244917+02:00",
  "CreatedDate": "2022-12-14T03:41:53.3244917+01:00",
  "Emails": [
    {
      "Value": "reiciendis",
      "StrippedValue": "magnam",
      "Description": "Multi-lateral stable support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "magnam",
      "Description": "Multi-lateral stable support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 287,
      "Name": "Hessel Group",
      "ToolTip": "Optio modi et eveniet nostrum provident soluta.",
      "Deleted": false,
      "Rank": 13,
      "Type": "aspernatur",
      "ColorBlock": 664,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2012-10-24T03:41:53.3244917+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "eligendi",
      "Hidden": true,
      "FullName": "Sandy Runolfsson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 343
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ullam",
      "StrippedValue": "dolores",
      "Description": "Ergonomic real-time project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 111
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "dolores",
      "Description": "Ergonomic real-time project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 111
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "provident",
      "StrippedValue": "molestiae",
      "Description": "Organized bottom-line extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 313
        }
      }
    },
    {
      "Value": "provident",
      "StrippedValue": "molestiae",
      "Description": "Organized bottom-line extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 313
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "labore",
      "StrippedValue": "qui",
      "Description": "Managed foreground task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "qui",
      "Description": "Managed foreground task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 614
        }
      }
    }
  ],
  "Description": "Multi-lateral background structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quo",
      "PersonId": 708,
      "Mrmrs": "quo",
      "Firstname": "Jude",
      "Lastname": "Steuber",
      "MiddleName": "Schoen-Lang",
      "Title": "voluptatum",
      "Description": "Upgradable full-range hub",
      "Email": "sadye@prohaskafadel.ca",
      "FullName": "Finn Murphy IV",
      "DirectPhone": "902.298.5631",
      "FormalName": "Reichert-Abbott",
      "CountryId": 103,
      "ContactId": 914,
      "ContactName": "Gorczany, Schuppe and Schowalter",
      "Retired": 643,
      "Rank": 995,
      "ActiveInterests": 158,
      "ContactDepartment": "",
      "ContactCountryId": 699,
      "ContactOrgNr": "983186",
      "FaxPhone": "1-996-419-2549 x0680",
      "MobilePhone": "1-971-274-3732 x8752",
      "ContactPhone": "889-345-8075",
      "AssociateName": "Feeney Inc and Sons",
      "AssociateId": 142,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "non",
      "Kanalname": "pariatur",
      "Post1": "natus",
      "Post2": "ratione",
      "Post3": "quaerat",
      "EmailName": "denis.konopelski@pfannerstill.us",
      "ContactFullName": "Macie Carter",
      "ActiveErpLinks": 94,
      "TicketPriorityId": 185,
      "SupportLanguageId": 291,
      "SupportAssociateId": 717,
      "CategoryName": "VIP Customer",
      "PersonNumber": "818162",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 6
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "numquam",
  "Xstop": false,
  "ActiveInterests": 424,
  "GroupId": 7,
  "ActiveStatusMonitorId": 748,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 549,
  "DbiAgentId": 216,
  "DbiLastSyncronized": "2015-01-14T03:41:53.3244917+01:00",
  "DbiKey": "doloribus",
  "DbiLastModified": "2003-08-18T03:41:53.3244917+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 370,
  "ActiveErpLinks": 121,
  "BounceEmails": [
    "genoveva@zulauflubowitz.name",
    "queen@ratke.name"
  ],
  "Domains": [
    "nemo",
    "molestiae"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Mckenna Williamson",
    "SuperOffice:2": "350158631"
  },
  "ExtraFields": {
    "ExtraFields1": "eius",
    "ExtraFields2": "occaecati"
  },
  "CustomFields": {
    "CustomFields1": "eveniet",
    "CustomFields2": "dicta"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 249
    }
  }
}
```