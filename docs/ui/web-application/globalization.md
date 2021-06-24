---
title: globalization
description: Globalization 
author: {github-id}
so.date: 06.24.2016
keywords:
so.topic: concept
so.envir: onsite
so.client: web
---

# Globalization

In this section, we will discuss how the CRM.web application handles globalization issues. The problem with globalization is when displaying the same page in different languages without a lot of extra work.

## The mechanism behind providing the resources for a page

The resource strings for the different languages will be provided through the language assemblies that are built for each language the application supports. The pages in CRM.web are all constructed through XML files that are converted to HTML pages at runtime. For example, if we take the below bit of code from a config file for a panel

```XML
<view id="more" type="SoView" soprotocol="udef" current="contact">
  <caption>[SR_MORE_CONTACT]</caption>
```

We can see that the caption tag does not give us the actual caption instead it gives a string that is formatted in a specific way. So when the application encounters a string like this in its config file the resource mechanism comes into play. What the application will do when it encounters a string like this it will call the appropriate resource DLL to find the actual string that matches the string "SR_MORE_CONTACT" in the XML file. The application will find the correct XML file from the language that we select when we log into the system.

The mechanism behind providing these resources to a page is the [resource providers][1].

## UI culture vs. culture in .Net

UI culture means purely the language that we see on the application while the .net culture means the format of the numbers and dates. The UI culture is provided by the satellite assemblies that are dedicated to a particular language. The .net culture comes from the .net framework.

In the CRM.web application, both the UI culture and the .net culture will be set. The culture will be set to the language that we select when we log into the system. For example, if we selected Spanish as our language when we log in, the language in the application will be provided from the Spanish *.resx* files that are compiled into the Spanish language satellite assembly.

In the .Net culture, which is the number and date formatting, will take effect based on the language chosen. The culture of the thread will be set to the language that has been chosen. The date and number formatting will be taken care of by the .Net framework. The date will be written with Spanish month names (25 December 2007), and numbers will be formatted according to Spanish style (1.234,56).

## Important namespaces in globalization

The following namespaces help us in working with different aspects of globalization:

* [SuperOffice.Globalization][2] - the different providers that give us the data within a page in the application
* [SuperOffice.CRM.Globalization][3] - helper classes for formatting different types of data to localized standards

<!-- Referenced links -->
[1]: ../../../data-access//docs/netserver/globalization-and-localization/language/resource-providers.md
[2]: ../../../data-access//docs/netserver/globalization-and-localization/superoffice-globalization.md
[3]: ../../../data-access//docs/netserver/globalization-and-localization/superoffice-crm-globalization.md

<!-- Referenced images -->
