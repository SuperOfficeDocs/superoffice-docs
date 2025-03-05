---
uid: help-da-edit-email-signature
title: Rediger signaturer
description: Rediger e-mail-signatur eller sagssignatur
keywords: e-mail, signatur, sagssignatur
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Rediger signaturer

Standardskabelonerne indeholder skabelonvariabler, der erstattes med data fra SuperOffice, så dine signaturer altid opdateres med de korrekte oplysninger.

* **E-mail-signatur:** Skabelonen indeholder variabler for dit navn, firma, adresse, telefonnumre, e-mailadresse, websted osv. [fra dit personkort][3].

* **Sagsignatur:** Skabelonen indeholder variabler for dit navn, firma, e-mailadresse osv. specifikt til [svarskabeloner][2].

> [!NOTE]
> Du kan ikke blande disse to sæt skabelonvariabler. Derudover kan personlige signaturer ikke tilsidesættes af administratorer.

## Trin

1. Klik på knappen **Personlige indstillinger** (<i class="ph ph-user-circle" aria-hidden="true"></i>) i toplinjen.

1. Vælg **Rediger personlig signatur**.

1. Vælg i dialogen enten fanen **E-mail-signatur** eller fanen **Anmodningssignatur**.

1. Redigere teksten og tilføj yderligere indhold.

    ![Rediger personlig signatur -screenshot][img1]

    * Klik på **[v]** i værktøjslinjen for at tilføje variabler, eller gå til de ovenfor linkede referencer for den komplette liste over tilgængelige skabelonvariabler.

    * Tilføj billeder og links ved hjælp af knapperne i værktøjslinjen. Du kan også trække og slippe links og billeder. Vælg **Indsæt link** for at tilføje links til relevante ressourcer eller sociale medier.

1. Klik på **Gem**, når du er færdig.

1. Valgfrit: Test signaturen ved at sende en e-mail til dig selv (for e-mail-signaturer) eller ved at oprette en ny sag (for anmodningssignaturer). Kontroller, at alle oplysninger vises korrekt, og at linkene fungerer, og billederne vises som de skal.

## Eksempel

Dette er et eksempel på en signatur, der kan bruges af alle i virksomheden.

**Mal:**

```text
Venlig hilsen
{auth}
{atit}
{onam}
Adresse: {opad}, {ozip} {ocit}
Telefon: {audp}
Mobiltelefon: {aupc}
{auem}
````

**Resultat:**

```text
Med venlig hilsen
John Hansen
Salgschef
SuperShop
Adresse: Højgade 12, 2234, Springfelt
Telefon: 22334455
Mobiltelefon: 99887766
jh@supershop.com
supershop.com
```

## Relateret indhold

* [Skift standard e-mailklient i SuperOffice][1]

<!-- Referenced links -->
[1]: ../../email/learn/change-default-mail-client.md
[2]: ../../request/reply-templates/learn/template-variables.md
[3]: ../../document/templates/variables/for-selected-contact.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/learn/getstarted-preferences-email-signature.png
