---
uid: help-da-edit-email-signature
title: Rediger signaturer
description: Rediger e-mail-signatur eller Anmodningssignatur
keywords: e-mail, signatur, Anmodningssignatur
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
topic: howto
language: da
audience: person
audience_tooltip: SuperOffice CRM
---

# Rediger signaturer

Standardskabelonerne indeholder skabelonvariabler, der erstattes med data fra SuperOffice, så dine signaturer altid opdateres med de korrekte oplysninger.

* **E-mail-signatur:** Skabelonen indeholder variabler for dit navn, firma, adresse, telefonnumre, e-mailadresse, websted osv. [fra dit personkort][3].

* **Anmodningssignatur:** Skabelonen indeholder variabler for dit navn, firma, e-mailadresse osv. specifikt til [svarskabeloner][2].

> [!NOTE]
> Du kan ikke blande disse to sæt skabelonvariabler. Derudover kan personlige signaturer ikke tilsidesættes af administratorer.

## Trin

1. Klik på knappen **Personlige indstillinger** i på den øverste linje.

2. Vælg **Rediger personlig signatur**.

3. Vælg i dialogen enten fanen **E-mail-signatur** eller fanen **Anmodningssignatur**.

4. Klik på ![ikon][img2] for at åbne teksteditorens værktøjslinje. Her har du forskellige muligheder for at redigere tekst og tilføje yderligere indhold.

    ![Rediger personlig signatur -screenshot][img1]

    * Klik på ![ikon][img3] i værktøjslinjen for at tilføje variabler, eller gå til de ovenfor linkede referencer for den komplette liste over tilgængelige skabelonvariabler.

    * Tilføj billeder og links ved hjælp af knapperne i værktøjslinjen. Du kan også trække og slippe links og billeder. Vælg **Indsæt link** for at tilføje links til relevante ressourcer eller sociale medier.

5. Klik på **Gem**, når du er færdig.

6. Valgfrit: Test signaturen ved at sende en e-mail til dig selv (for e-mail-signaturer) eller ved at oprette en ny sag (for anmodningssignaturer). Kontroller, at alle oplysninger vises korrekt, og at linkene fungerer, og billederne vises som de skal.

## Eksempel

Dette er et eksempel på en signatur, der kan bruges af alle i virksomheden.

```text
Venlig hilsen
{auth}
{atit}
{onam}
Adresse: {opad}, {ozip} {ocit}
Telefon: {audp}
Mobiltelefon: {aupc}
{auem}

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

## Relaterede emner

* [Skift standard e-mailklient i SuperOffice][1]

<!-- Referenced links -->
[1]: ../../email/learn/change-default-mail-client.md
[2]: ../../request/reply-templates/learn/template-variables.md
[3]: ../../document/templates/variables/for-selected-contact.md

<!-- Referenced images -->
[img2]: ../../../../common/icons/editor-toolbar-icon.png
[img3]: ../../../media/icons/sign-editor-variables.png
[img1]: ../../../media/loc/en/learn/getstarted-preferences-email-signature.png
