---
uid: help-nl-request-type-delete
title: Verzoektype verwijderen
description: Verzoektype verwijderen
keywords: verzoek, type, verzoektype, tabblad Verzoektypen
author: Bergfrid Dias
date: 03.14.2025
version: 10.5.2
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
redirect_from: /nl/request/learn/type/delete
index: true
---

# Verzoektype verwijderen

> [!NOTE]
> U kunt het huidige standaardtype (degene met een vinkje in het vak **Als standaard gebruiken**) niet verwijderen.

## Vereisten

* Als het type dat u wilt verwijderen als standaard wordt gebruikt, stel dan een ander verzoektype als standaard in. (Totdat u dat doet, is de **Verwijderen**-knop gedeactiveerd.)

* Werk eerst alle [e-mailfilters][1] en [postbussen][2] bij die dit verzoektype gebruiken. U kunt geen type verwijderen dat in gebruik is.

  * **Instellingen en onderhoud** > **Verzoeken** > **E-mail** > **Eigenschappen instellen**-tabblad
  * **Instellingen en onderhoud** > **Verzoeken** > **E-mail** > **Postbussen**-tabblad

## Stappen

1. Klik op **Verzoeken** in de navigator en selecteer het tabblad **Verzoektypen**.

1. Klik op het gewenste verzoektype.

1. Klik op **Verwijderen** onderaan het scherm.

1. Als er verzoeken van dit type zijn, kies dan een nieuw type uit de lijst **Verzoektype overdragen naar**.

1. Klik op **OK** om te bevestigen. Het verzoektype wordt verwijderd en alle verzoeken worden verplaatst naar het opgegeven alternatieve type.

<!-- Referenced links -->
[1]: ../../../email/service/learn/email-filters/create-email-filter.md
[2]: ../../../email/service/learn/create-mailbox.md
