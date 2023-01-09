---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 611
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 880,
  "Name": "Hirthe Group",
  "Department": "",
  "OrgNr": "1701511",
  "Number1": "834463",
  "Number2": "1043495",
  "UpdatedDate": "2011-02-13T17:37:17.2622417+01:00",
  "CreatedDate": "2001-03-14T17:37:17.2622417+01:00",
  "Emails": [
    {
      "Value": "omnis",
      "StrippedValue": "accusantium",
      "Description": "Multi-channelled object-oriented architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 706
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "accusantium",
      "Description": "Multi-channelled object-oriented architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 706
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 155,
      "Name": "Paucek LLC",
      "ToolTip": "Eius laboriosam minus.",
      "Deleted": true,
      "Rank": 511,
      "Type": "vel",
      "ColorBlock": 364,
      "IconHint": "eius",
      "Selected": true,
      "LastChanged": "2016-06-24T17:37:17.2622417+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Maria Bins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 695
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "placeat",
      "Description": "User-centric intangible framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 912
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "placeat",
      "Description": "User-centric intangible framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 912
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quo",
      "StrippedValue": "autem",
      "Description": "Sharable actuating toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 352
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "autem",
      "Description": "Sharable actuating toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 352
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "recusandae",
      "Description": "Persevering context-sensitive collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "recusandae",
      "Description": "Persevering context-sensitive collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    }
  ],
  "Description": "Streamlined neutral model",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolores",
      "PersonId": 948,
      "Mrmrs": "voluptatem",
      "Firstname": "Keven",
      "Lastname": "Schamberger",
      "MiddleName": "Bode Group",
      "Title": "excepturi",
      "Description": "Stand-alone contextually-based ability",
      "Email": "pascale.ziemann@krajcik.ca",
      "FullName": "Jacynthe Donavon Hand I",
      "DirectPhone": "943-152-2111 x27417",
      "FormalName": "Baumbach LLC",
      "CountryId": 727,
      "ContactId": 303,
      "ContactName": "Rempel, Wilkinson and Sawayn",
      "Retired": 740,
      "Rank": 790,
      "ActiveInterests": 71,
      "ContactDepartment": "",
      "ContactCountryId": 288,
      "ContactOrgNr": "1345433",
      "FaxPhone": "776.666.1718 x465",
      "MobilePhone": "1-456-939-5277",
      "ContactPhone": "694-141-3541 x382",
      "AssociateName": "Prohaska-Mueller",
      "AssociateId": 788,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "qui",
      "Kanalname": "sequi",
      "Post1": "id",
      "Post2": "perspiciatis",
      "Post3": "harum",
      "EmailName": "kennith@shanahanbrekke.uk",
      "ContactFullName": "Jovany Schmitt",
      "ActiveErpLinks": 295,
      "TicketPriorityId": 199,
      "SupportLanguageId": 749,
      "SupportAssociateId": 871,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 271
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "velit",
  "Xstop": false,
  "ActiveInterests": 66,
  "GroupId": 234,
  "ActiveStatusMonitorId": 514,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 194,
  "DbiAgentId": 71,
  "DbiLastSyncronized": "2000-07-07T17:37:17.266241+02:00",
  "DbiKey": "maiores",
  "DbiLastModified": "1999-11-24T17:37:17.266241+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 697,
  "ActiveErpLinks": 742,
  "BounceEmails": [
    "arnaldo@gottliebwitting.com",
    "karli_crona@grady.ca"
  ],
  "Domains": [
    "beatae",
    "molestias"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Harmon Windler"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsa",
    "ExtraFields2": "a"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 69
    }
  }
}
```