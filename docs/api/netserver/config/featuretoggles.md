---
title: ns_config_featuretoggles
description: NetServer FeatureToggles element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer FeatureToggles element

Configuration values for Feature Toggles. See the *SuperOffice.FeatureToggles.dll* assembly for definitions. Toggles not mentioned here will be OFF.

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
