---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

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
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 478
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 13,
  "Name": "Jaskolski, Beier and Ward",
  "Department": "",
  "OrgNr": "1077611",
  "Number1": "1407630",
  "Number2": "1284901",
  "UpdatedDate": "2015-09-14T11:44:33.1035873+02:00",
  "CreatedDate": "2010-11-12T11:44:33.1035873+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "sit",
      "Description": "Cross-platform dynamic encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 994
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "sit",
      "Description": "Cross-platform dynamic encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 994
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 878,
      "Name": "Carter, Bayer and Wolf",
      "ToolTip": "Quisquam autem vero quas asperiores unde enim.",
      "Deleted": true,
      "Rank": 656,
      "Type": "a",
      "ColorBlock": 991,
      "IconHint": "reprehenderit",
      "Selected": false,
      "LastChanged": "2007-03-08T11:44:33.1192091+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eveniet",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Ms. Quentin Devon Beahan III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "molestias",
      "StrippedValue": "eum",
      "Description": "Progressive explicit database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "eum",
      "Description": "Progressive explicit database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aut",
      "StrippedValue": "magnam",
      "Description": "Re-engineered grid-enabled complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "magnam",
      "Description": "Re-engineered grid-enabled complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "in",
      "Description": "Down-sized assymetric application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "in",
      "Description": "Down-sized assymetric application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    }
  ],
  "Description": "Down-sized assymetric attitude",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eaque",
      "PersonId": 676,
      "Mrmrs": "autem",
      "Firstname": "Coralie",
      "Lastname": "O'Connell",
      "MiddleName": "McCullough Group",
      "Title": "odit",
      "Description": "Self-enabling dynamic throughput",
      "Email": "mauricio@jonesdoyle.name",
      "FullName": "Yoshiko River Witting Sr.",
      "DirectPhone": "908.466.7634 x490",
      "FormalName": "Von Group",
      "CountryId": 735,
      "ContactId": 405,
      "ContactName": "Torp Inc and Sons",
      "Retired": 421,
      "Rank": 879,
      "ActiveInterests": 760,
      "ContactDepartment": "",
      "ContactCountryId": 602,
      "ContactOrgNr": "1148519",
      "FaxPhone": "(226)795-4919 x63340",
      "MobilePhone": "1-427-152-6199",
      "ContactPhone": "310.612.7743 x251",
      "AssociateName": "Wintheiser Inc and Sons",
      "AssociateId": 333,
      "UsePersonAddress": false,
      "ContactFax": "molestiae",
      "Kanafname": "est",
      "Kanalname": "aut",
      "Post1": "rerum",
      "Post2": "et",
      "Post3": "aut",
      "EmailName": "imani@feeney.name",
      "ContactFullName": "Tevin Deckow MD",
      "ActiveErpLinks": 439,
      "TicketPriorityId": 145,
      "SupportLanguageId": 305,
      "SupportAssociateId": 975,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "perferendis",
  "Xstop": false,
  "ActiveInterests": 633,
  "GroupId": 980,
  "ActiveStatusMonitorId": 881,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 663,
  "DbiAgentId": 564,
  "DbiLastSyncronized": "2012-06-29T11:44:33.1192091+02:00",
  "DbiKey": "dolor",
  "DbiLastModified": "2002-02-22T11:44:33.1192091+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 131,
  "ActiveErpLinks": 131,
  "BounceEmails": [
    "kareem@cruickshank.us",
    "luther@morar.us"
  ],
  "Domains": [
    "enim",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jess Senger",
    "SuperOffice:2": "Rosamond Beatty"
  },
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "voluptatem"
  },
  "CustomFields": {
    "CustomFields1": "incidunt",
    "CustomFields2": "omnis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 594
    }
  }
}
```