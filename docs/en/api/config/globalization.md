---
title: Globalization element
uid: ns_config_globalization
description: NetServer configuration used to access the Globalization section in the config file
so.date: 12.09.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Globalization, ApplicationCountryCode, AllwaysUseGsmPhoneStyle, UseApplicationCountryForPersons
so.topic: reference
so.envir: onsite
---

# NetServer Globalization element

This configuration is used to access the Globalization section (user origin) in the config file.

```XML
<Globalization>
  <add key="ApplicationCountryCode" value="GBR" />
  <add key="UseApplicationCountryForPersons" value="True" />
</Globalization>
```

| Name | Description | Default |
|---|---|---|
| AllwaysUseGsmPhoneStyle | Setting this property to true will return all phone numbers formatted for the display in a GSM Phone style. | false |
| ApplicationCountryCode | Use this country code for associates that are not persons (such as anonymous and system users). | GBR (England) |
| UseApplicationCountryForPersons | Use the application's country (`ApplicationCountry`) for all persons (such as employees and external users). This is for applications that are not localized. The current county in the principal will be forced to the ApplicationCountry value. | |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Globalization>
