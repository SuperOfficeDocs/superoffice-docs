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

[Resource Providers][1] are used to supply localized resource strings, and provide the means for third-parties to override existing, or supply new, resource strings in SuperOffice.

To see a list of all available resource strings, see the [Resource Strings][2] section.

Other topics of interest:

* [Culture helper][3]

## Localization

Localization is the process of translating an application's resources into localized versions for each culture that the application will support.

The localization features in NetServer make an application suit the styles of a region.

All classes that help perform localization formatting reside in the `SuperOffice.CRM.Globalization` namespace.

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
[4]: addressformatter.md
[5]: culturedataformatter.md
[6]: personnameformatter.md
[7]: phoneformatter.md
