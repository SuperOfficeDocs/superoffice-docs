---
# Mandatory fields.
title: erp_auto_field_mapping       # (Required) Very important for SEO.
description: ERP Sync engine automatic field mapping # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: reference    # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# ERP Sync engine automatic field mapping

The ERP Sync engine will try to map ERP fields to CRM fields automatically if the CRM field naming is matched by the connector. Below is a list of CRM fields the engine will recognize and try to map automatically.

When fields are mapped, **sync direction is not set**, so no actual sync will occur before this is explicitly enabled. The field name matching is **case insensitive**. The actual mapping will occur when a connection is created or updated.

> [!CAUTION]
> If you rename fields in an existing connector to match the CRM field names, the old names that are missing will cause these field mappings to be marked as no longer available in ERP, and you will need to set sync direction again to re-enable syncing of these fields.

## Contact

| ERP field | CRM field |
|---|---|
| NAME         | Name                         |
| NUMBER1      | Code                         |
| NUMBER2      | Number                       |
| DEPARTMENT   | Department                   |
| PHONE        | Telephone                    |
| FAX          | Fax                          |
| EMAIL        | E-mail                       |
| URL          | Web site                     |
| POSTALAD1    | Postal addr., address line 1 |
| POSTALAD2    | Postal addr., address line 2 |
| POSTALAD3    | Postal addr., address line 3 |
| POSTALZIP    | Postal addr., zip code       |
| POSTALCITY   | Postal addr., city           |
| POSTALCOUNTY | Postal addr., county         |
| POSTALSTATE  | Postal addr., state          |
| STREETAD1    | Street addr., address line 1 |
| STREETAD2    | Street addr., address line 2 |
| STREETAD3    | Street addr., address line 3 |
| STREETZIP    | Street addr., zip code       |
| STREETCITY   | Street addr., city           |
| STREETCOUNTY | Street addr., county         |
| STREETSTATE  | Street addr., state          |
| COUNTRY      | Country                      |
| VATNO        | VAT No                       |

## Person

| ERP field | CRM field |
|---|---|
| FIRSTNAME      | First name                   |
| MIDDLENAME     | Middle name                  |
| LASTNAME       | Last name                    |
| TITLE          | Title                        |
| NUMBER         | Number                       |
| PHONE\_DIRECT  | Direct phone                 |
| PHONE\_PRIVATE | Private phone                |
| PHONE\_MOBILE  | Mobile phone                 |
| PHONE\_OTHER   | Other phone                  |
| EMAIL          | E-mail                       |
| POSITION       | Position                     |
| BIRTHDATE      | Birthdate                    |
| URL            | Web site                     |
| POSTALAD1      | Postal addr., address line 1 |
| POSTALAD2      | Postal addr., address line 2 |
| POSTALAD3      | Postal addr., address line 3 |
| POSTALZIP      | Postal addr., zip code       |
| POSTALCITY     | Postal addr., city           |
| POSTALSTATE    | Postal addr., state          |
| POSTALCOUNTY   | Postal addr., county         |
| POSTALCOUNTRY  | Country                      |

## Project

| ERP field | CRM field |
|---|---|
| NAME    | Project name |
| TEXT    | Description  |
| NUMBER  | Number       |
| URL     | Web site     |
| ENDDATE | End date     |
