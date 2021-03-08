---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com

# Mandatory fields.
title: variables_from_company_card       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Variables from the company card # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: reference           # article, howto, reference, concept, guide
# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Variables from the company card

| Variable | Description |
|----------|-------------|
| addr | Postal address line 1. If this is empty, street address line 1 |
| busi | Business |
| cate | Category |
| ccid | Company’s country code |
| cf01-10 | User-defined field 1-10 of the decimal number type |
| cicn | Country name in English |
| city | Postal town |
| cl01-60 | User-defined field 1-60 of the whole number type |
| cnt? | Country if different from the sender’s country |
| cntr | Country |
| cnty | County (for UK addresses) |
| code | Code |
| cont | Our contact |
| cozg | Line feed for internal post in Germany |
| cozi | Postcode including country prefix (e.g. N-0163 for a postcode in Norway). Prefix is not used for Germany |
| cozn | Line feed for Australian and UK treatment of counties and postcodes |
| cphi | Company's phone number, ID (hidden, unique ID) |
| cpho | Company’s phone number |
| cs01-49 | User-defined field 1-49 of the text type |
| cszc | Postal town, state/province and zipcode (for American, Canadian and Australian addresses, e.g. Bedford, MA 01730) |
| cuid | Company ID (hidden, unique ID) |
| cwwi | The company's primary web address, ID (hidden, unique ID) |
| cwww | The company's primary web address |
| czip | County and postcode (for UK addresses) |
| dept | Department |
| faxi | Fax number, ID (hidden, unique ID) |
| faxn | Fax number. The contact’s direct number, if available. Otherwise the company’s fax number |
| faxs | Fax number. The contact’s direct number, if available. Otherwise the company’s fax number. Without spaces |
| maii | The company's primary email address, ID (hidden, unique ID) |
| mail | The company’s primary email address |
| name | The company’s name |
| numb | Number |
| orgn | The company’s organisation number |
| padr | Postal address, line 1 |
| pad2 | Postal address, line 2 |
| pad3 | Postal address, line 3 |
| phoi | Phone number, ID (hidden, unique ID) |
| phon | Phone number. The contact’s direct number, if available. Otherwise the company’s phone number |
| sadr | Street address/office address, address line 1 |
| sams | First address line, including Mail Stop (for American addresses) |
| scit | Postal town for street address (for German addresses) |
| ssta | State/province for street address (for American, Canadian and Australian addresses) |
| stat | State/province (for American, Canadian and Australian addresses). (See also [cszc][1].) |
| szip | Postcode for street address (for German addresses) |
| zici | Postcode and postal town (e.g. 0572 OSLO) |
| zino | Postcode prefix |
| zipc | Postcode. (See also [cszc][1].) |
| zipp | Postcode for street address. |

<!-- Referenced links -->
[1]: https://community.superoffice.com/Documentation/Help/EN/CRM/8.0/WebHelpAdmin/Template_variables.htm?rhtocid=2_1#cszc