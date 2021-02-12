---
title: globalization_resource_providers   
description: Resource providers
author: {github-id}             # Your GitHub alias.
so.date: 05.08.2018
so.topic: concept
keywords:
---

# Resource providers

**Resource providers** are a single mechanism to ask for text and receive it in any supported culture. A text resource uses a unique key that accesses a language-specific value stored in a resources file, or satellite assembly.

SuperOffice supports approximately 15 languages and it's important to optimize text resources for labels, tooltips, and error messages in all of those languages.

To minimize duplication, mistakes, or inconsistencies all SuperOffice products leverage NetServer resource providers for providing text resources.

All existing resource string keys are defined in the [SuperOffice NetServer Core documentation][1].

## Example resource use

Throughout the SuperOffice CRM.web application, string resources are used extensively wherever common text appears.

Below is an example from the *SoContactPanel.config* file.

The CRM.web application UI is declared in SuperOffice Markup Language (SOML) configuration files, where the UI elements are declared using XML. Resource strings are used a lot and appear obvious everywhere there is text inside square brackets. The example is even more recognizable by the binding attribute `binding="resources"`.

```XML
<view id="more" type="SoView" soprotocol="udef" current="contact" rendermode="display" ...>
    <caption binding="resources">[SR_MORE_CONTACT]</caption>
    <tooltip binding="resources">[SR_MORE_TOOLTIP]</tooltip>
...
```

## How to create a resource provider

All resource providers must be compiled in .Net assemblies. SuperOffice provider a base class in the *SuperOffice.Plugins.dll* called `ResourceDllProviderBase`, which makes it easy to get started.

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
[1]: https://community.superoffice.com/documentation/SDK/SO.NetServer.Data.Access/html/T_SuperOffice_Globalization_RC.htm

<!-- Referenced images -->
[img1]: media/netserver-resource-provider.png
