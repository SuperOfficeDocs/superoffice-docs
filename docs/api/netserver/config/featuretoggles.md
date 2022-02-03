---
title: FeatureToggles element
uid: ns_config_featuretoggles
description: NetServer FeatureToggles element
so.date: 12.07.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, FeatureToggles, State, feature toggles
so.topic: reference
so.envir: onsite
---

# NetServer FeatureToggles element

Configuration values for feature toggles.

```XML
<FeatureToggles>
  <State>
    <add key="NewFeature" value="True" />
  </State>
</FeatureToggles>
```

| Name | Description |
|---|---|
| State | Contains key/value (feature name/true or false) pair elements that represent the features to toggle. |

* See the [NetServer Core reference][1] for details about handling this programmatically.
* See the *SuperOffice.FeatureToggles.dll* assembly for definitions. Toggles not mentioned there will be OFF.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.FeatureToggles>
