---
title: ns_config_globalization
description: NetServer Globalization element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer Globalization element

This configuration is used to access the Globalization section in the config file.

```XML
<Globalization>
  <add key="ApplicationCountryCode" value="GBR" />
  <add key="UseApplicationCountryForPersons" value="True" />
</Globalization>
```

| Name | Description |
|---|---|
| ApplicationCountryCode | Use this country code for associates that are not persons (such as anonymous and system users).<br>Default: GBR (England) |
| UseApplicationCountryForPersons | Use the application's country (`ApplicationCountry`) for all persons (such as employees and external users). This is for applications that are not localized. The current county in the principal will be forced to the ApplicationCountry value. |
| AllwaysUseGsmPhoneStyle | Setting this property to true will return all phone numbers formatted for the display in a GSM Phone style.<br>Default: false |
