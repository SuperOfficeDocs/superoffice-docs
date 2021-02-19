---
# Mandatory fields.
title: create_resource_provider       # (Required) Very important for SEO.
description: How to create a resource provider # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to create a resource provider

All [resource providers][1] must be compiled in .Net assemblies. SuperOffice provider a base class in the *SuperOffice.Plugins.dll* called `ResourceDllProviderBase`, which makes it easy to get started.

Implementations must decorate the class with the `ResourceProvider` attribute, which NetServer will use to discover and load at runtime. The first parameter must be a name that uniquely identifies your provider. The second parameter is a priority number that can force your provider to be called before others, and thus override already-existing stuff. This is not normally a recommended practice, however, the lowest priority value is used first. SuperOffice default priority values are `int.MaxValue` divided by 2. If another provider that includes the same resource names with a lower priority value, such as `int.MaxValue / 3`, it takes precedence and overrides default resources supplied by SuperOffice.

The constructor expects two parameters:

* the name of the executing assembly
* the name of the resx resource files that contains the language-specific text resources.

## Code example

```csharp
[ResourceProvider( "PartnerXResourceProvider", int.MaxValue )]
public class ResourceProvider : ResourceDllProviderBase
{
  public ResourceProvider()
    : base( System.Reflection.Assembly.GetExecutingAssembly(), ".Resources" )
  {
  }
}
```

## Dependencies

Assemblies must be declared in the application's configuration file. The key here is not special or mapped to anything else. It only needs to unique from other assemblies declared in the DynamicLoad section. The value must be the name of the resource assembly.

The value is optionally a full path, or when placed in the applications directory only needs to be the name of the assembly.

```XML
<SuperOffice>
  ...
  <Factory>
    <DynamicLoad>
    ...
      <!-- Add custom plugins etc here -->
      <add key="UniqueName" value="UniqueName.Resources.dll" />
    </DynamicLoad>
  </Factory>
  ...
</SuperOffice>
```

## Example .NET project

In the example below, the project uses the NuGet package `SuperOffice.NetServer.Core` to easily get a reference to the *SuperOffice.Plugins.dll*.

![Example .Net project][img1]

## Resource Codes

| Abbreviation | Country |
|---|---|
|cs|Czech (Czech Republic)|
|da|Danish|
|de|German|
|en-us| English - United States|
|es| Spanish|
|fi|Finnish|
|fr|French|
|it|Italian|
|ja|Japanese|
|nl|Dutch|
|no|Norwegian|
|pl|Polish|
|default (see image)|English - United Kingdom|
|ru|Russian|
|sv|Swedish|
|zh-cn|Chinese (S)|

## Do it yourself

If you have special requirements, implement the `IResourceProvider` interface, or override the base class implementation. The methods `CanInitialize()`, `Initialize()`, `GetSupportedLanguages()`, and `GetResource(string symbol)` are easy to understand and implement.

The idea behind `CanInitialize` is that some providers may need database access, and so they should not be initialized too early. By doing a quick check and returning true only when everything is ready, you can postpone the initialization to the correct moment.

<!-- Referenced links -->
[1]: resource-providers.md

<!-- Referenced images -->
[img1]: media/netserver-resource-provider.png
