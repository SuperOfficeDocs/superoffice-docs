---
title: pagebuilder_config_soarchivecontrollinkinfotypes
description: SoArchiveControlLinkInfoTypes.config
so.date: 04.17.2018
keywords: config
so.topic: concept
so.client: web
so.envir: onsite
---

# SoArchiveControlLinkInfoTypes

Web client data-grid controls are called archive controls, and archive control data sources are called archive providers. Each row has a `LinkHints` property that is used to construct actual hyperlinks that control what happens when a user clicks a row in the archive control.

The *SoArchiveLinkInfoTypes.config* file contains all definitions that resolve archive control click-actions to executable actions. It's where all custom archive control must add their own link-hint handlers, or `linkinfo` elements, as well.

All `linkinfo` elements are uniquely identified by a combination of their attributes `type` and `subtype`.

The following is the actual element in *SoArchiveLinkInfoTypes.config* that defines what happens when a user clicks on a person row: it issues an SoProtocol that updates the current person ID to the selected person.

```xml
<linkinfos>
  <linkinfo type="personarchive:person" subtype="click">
    <baseurl>javascript:PageUpdate('soprotocol:?person_id={person_id}','');</baseurl>
    <target></target>
  </linkinfo>
</linkinfos>
```

## SoArchiveLinkInfoTypes.merge

The following example demonstrates how to add a click-handler (linkinfo) that is linked to an archive control on the **customfeature** page.

```xml
<linkinfos>
  <linkinfo type="customfeature:person" subtype="click">
    <baseurl>javascript:PageUpdate('soprotocol:?person_id={person_id}','');</baseurl>
    <target></target>
  </linkinfo>
</linkinfos>
```

It does the same thing to have a uniform behavior throughout the client application. The only difference is the type value prefix, a linkhint-prefix, which is explained in detail in the [archive control row client][1] documentation.

<!-- Referenced links -->
[1]: ../usercontrols/archives/add-row-click-actions.md
