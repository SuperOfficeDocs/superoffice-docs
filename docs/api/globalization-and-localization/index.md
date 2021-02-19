---
title: globalization_and_localization      
description: Globalization and Localization
author: {github-id}             # Your GitHub alias.
so.date: 05.08.2018
keywords:
---

# SuperOffice Globalization

SuperOffice has great support for globalization by providing a culture-neutral and language-neutral user interface that supports localized labels and regional data throughout the application, as well as exposing an API to augment string resources throughout the platform.

## Globalization

SuperOffice supports localized interfaces and regional data for users in more than fifteen cultures and is written in such a way that is easily extended to support other cultures or regions not included by default.

All strings are stored in a *.resx* file so that they can be called by calling the name assigned to it. The advantage is that since we have a resx files for each language we can run SuperOffice in any language we prefer without any modification to the code.

[Resource Providers][1] are used to supply localized resource strings, and provide the means for third-parties to override existing, or supply new, resource strings in SuperOffice.

The problem with globalization is when displaying the same page in different languages without a lot of extra work.

* The mechanism behind providing the resources for a page

To see a list of all available resource strings, see the [Resource Strings][2] section.

### UI Culture vs. Culture in .Net

UI culture means purely the language that we see on the application while the .net culture means the format of the numbers and dates. The UI culture is provided by the satellite assemblies that are dedicated to a particular language. The .Net culture comes from the .Net framework.

In SuperOffice, both the UI culture and the .Net culture will be set. The culture will be set to the language that we select when we log into the system.

For example, if we selected Spanish as our language when we log in, the language in the application will be provided from the Spanish .resx files that is compiled into the Spanish language satellite assembly. In the .Net culture which is the number and date formatting will take effect based on the language chosen. The culture of the thread will be set to the language that has been chosen. The date and number formatting will be taken care of by the .Net framework, meaning the date will be written with Spanish month names (25 December 2007), and numbers will be formatted according to Spanish style (1.234,56).

Other topics of interest:

* [Culture helper][3]

## Localization

Localization is the process of translating an application's resources into localized versions for each culture that the application will support.

The localization features in NetServer make an application suit the styles of a region.

All classes that help perform localization formatting reside in the [SuperOffice.CRM.Globalization][8] namespace.

The main classes are:

* [AddressFormatter][4]
* [CultureDataFormatter][5]
* [PersonNameFormatter][6]
* [PhoneFormatter][7]

These contain all the functions you need to localize your application. See the [Resource Providers][2] documentation to learn more about how to include more culture-specific resources for SuperOffice.

<!-- Referenced links -->
[1]: resource-providers.md
[2]: https://community.superoffice.com/documentation/SDK/SO.NetServer.Data.Access/html/T_SuperOffice_Globalization_RC.htm
[3]: culturesettinghelper.md
[4]: address/addressformatter.md
[5]: culturedataformatter.md
[6]: personnameformatter.md
[7]: phoneformatter.md
[8]: superoffice-crm-globalization.md
