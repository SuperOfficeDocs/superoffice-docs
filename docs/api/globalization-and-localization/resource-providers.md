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

All existing resource string keys are defined in the `RC` class.

## Available providers

Below is a section from the *web.config* file.

```XML
<Globalization>
  <ResourceProviders>
  <!-- Resource providers decode [SR_XYZ_STRING] resource strings into localized resources.
    The FieldLabelProvider handles overrides set through SoAdmin -->
  <add name="FieldLabelProvider" rank="10" assemblyname="SuperOffice.DCF" objecttype="SuperOffice.Globalization.FieldLabelProvider" />
  <add name="ResourceDllProvider" rank="20" assemblyname="SuperOffice.DCF" objecttype="SuperOffice.Globalization.ResourceDllProvider" params="SuperOffice.Web.Globalization.ResourceStrings;SuperOffice.Web.Globalization" />
  <add name="CurrentValueProvider" rank="30" assemblyname="SuperOffice.CRMWeb" objecttype="SuperOffice.CRM.Web.Globalization.CurrentAsResourceProvider" />
  <add name="TemplateTagProvider" rank="40" assemblyname="SuperOffice.CRMWeb" objecttype="SuperOffice.CRM.Web.Globalization.TemplateTagAsResourceProvider" />
  <add name="PreferenceValueProvider" rank="50" assemblyname="SuperOffice.CRMWeb" objecttype="SuperOffice.CRM.Web.Globalization.UserPreferenceAsResourceProvider" />
  </ResourceProviders>
</Globalization>
```

As we can see in the config section there are 5 resource providers listed. The provider that will provide the resource string is `ResourceDllProvider`.

```XML
<add name="ResourceDllProvider" rank="20" assemblyname="SuperOffice.DCF" objecttype="SuperOffice.Globalization.ResourceDllProvider" params="SuperOffice.Web.Globalization.ResourceStrings;SuperOffice.Web.Globalization" />
```

This line will load the satellite assembly from the *SuperOffice.Web.Globalization.dll* depending on the language that you selected when you login to SuperOffice. For example, if you chose English as the language when you log into the system this statement will load the English resource satellite assembly to the *SuperOffice.Web.Globalization.dll* file in *bin\\en-us*.

The other resource providers that are listed in the above code section are

* FieldLabelProvider - The field label provider supports customization using the SOADMIN client.  Replacement text labels are stored in the database in the LocaleText table. This provider handles the label customization rules.
* CurrentValueProvider – This provider will provide us with current values of a given user. Current values mean the current contact of a given user, the month of a given user in the calendar, the current appointment of a given user and so on. For example the current company name is used in the menu as: -

  &lt;caption&gt;\[SR\_MENU\_SELECTION\_GOTO\_CONTACT\] \[current:contact\_name\]&lt;/caption&gt;

* TemplateTagProvider – The tags of the document templates of the Six Web application will be provided by this provider. The Template tags are defined for use in the document templates. They represent complex strings computed from the current values. For example, \[name\] is the name of the current company. \[cont\] is the name of the current company’s our-contact.
* Note that template tags may trigger several agent calls to compute the results.
* PreferenceValueProvider – This is the provider that will provide us with the preference values of a given user. For example Splitter positions will determine the size of the cards that appear in a give page of the application.

## Example use

ThroughoutSuperOffice CRM, string resources are used extensively wherever common text appears.

Below is an example from the *SoContactPanel.config* file.

The UI is declared in SuperOffice Markup Language (SOML) configuration files, where the UI elements are declared using XML. Resource strings are used a lot and appear obvious everywhere there is text inside square brackets. The example is even more recognizable by the binding attribute `binding="resources"`.

```XML
<view id="more" type="SoView" soprotocol="udef" current="contact" rendermode="display" ...>
    <caption binding="resources">[SR_MORE_CONTACT]</caption>
    <tooltip binding="resources">[SR_MORE_TOOLTIP]</tooltip>
...
```

We can see that in the `caption` tag it does not give us the actual caption instead it gives a string that is formatted in a specific way. So when the application encounters a string like this in its config file, the resource mechanism comes into play.

What the application will do when it encounters a string like this it will call the appropriate resource DLL to find the actual string that matches the string "SR\_MORE\_CONTACT" in the XML file. The application will find the correct XML file from the language that we select when we log into the system.

## Add your own resources

Now since SuperOffice has provided us with a `ResourceDllProvider`, we are able to add our own resources and be able to show them in a given page. There are 3 ways that we can do this:

* We can [write our own ResourceDllProvider][1] and add it to the config file so that it will read the resource files the way we want. If we are developing our own `ResourceDllProvider` we have to implement the `IResourceProvider` interface in order to maintain the common interface between other components of the system.

* The second method is we can use the SuperOffice `ResourceDllProvider` as it is and develop our own language resource satellite assemblies. To do this we need to specify the name of the new DLL as the parameter in the config file. For example if we want to add new strings to the French satellite assembly we can [develop our own Resx files][2] and then compile it to a satellite assembly. When we add our French satellite assembly next to the one already exists we should get the strings we added or modified.

* The third method is to use the `ResXmlFileProvider` to provide custom strings without compiling them into resource DLLs. XML files are easier to edit but tend to be larger than the compiled DLL files.

<!-- ## See also

* IResourceProvider
* ResourceDllProvider
* ResXmlFileProvider
* TemplateTagAsResourceProvider -->

<!-- Referenced links -->
[1]: create-resource-provider.md
[2]: create-resx-file.md
