---
title: Factory element
uid: ns_config_factory
description: NetServer configuration values are used to access class factory information. The ClassFactory is part of a NetServer extension mechanism to support plug-ins.
so.date: 12.17.2021
author: Bergfrid Dias
keywords: NetServer, web.config, Factory, CustomFactories, DynamicLoad
so.topic: reference
so.envir: onsite
---

# NetServer Factory element

These configuration values are used to access class factory information. The `ClassFactory` is part of a NetServer extension mechanism to support plug-ins. Add entries for each dynamic link library containing custom archive providers, document or sentry plugins, and so on.

```XML
<Factory>
  <CustomFactories>
    <add key="FullClassNameToOverride" value="DevNetCustomFactories.dll" />
  </CustomFactories>
  <DynamicLoad>
    <add key="MyArchiveProviders" value="DeNetArchiveProviders.dll" />
  </DynamicLoad>
</Factory>
```

| Name | Description |
|---|---|
| CustomFactories | Custom factories that are to replace the default factories. The name of the class to override is the key and the name of the assembly where the custom factory resides is the value. |
| DynamicLoad | This is the most common way to extend NetServer, and it is used to create custom Archive and MDO Providers, Sentry and Document plug-ins, and more. Contains a list of assemblies dynamically loaded at runtime. Keys will be ignored, values must specify assemblies. |
