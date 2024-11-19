---
uid: help-no-edit-legal-base
title: Rediger juridisk grunnlag
description: I denne veiledningen lærer du om GDPR-funksjonene i SuperOffice Marketing som hjelper deg med å sørge for at markedsføringstiltakene dine er GDPR-kompatible.
keywords: personvern, samtykke, hjemmel
author: SuperOffice RnD
date: 10.08.2024
version: 10.3.10
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Rediger personverninnstillinger for en person

> [!NOTE]
> Denne funksjonen krever funksjonelle rettigheter. Uten de riktige funksjonelle rettighetene kan du bare angi **E-markedsføring** til på eller av.

Som firma samler du inn, lagrer og håndterer folks personopplysninger. I henhold til GDPR må du nå ha en lovlig grunn til hvorfor du vil lagre denne informasjonen.

SuperOffice CRM har en funksjon som heter Samtykkehåndtering, den er utviklet for å hjelpe deg med å dokumentere når, hvordan og hvorfor du vil registrere visse personopplysninger i CRM-løsningen.

Hver gang en person registreres i SuperOffice CRM-databasen din, registreres også samtykket vedkommende ga til lagring av disse opplysningene. På denne måten kan du administrere og spore nøyaktig hvilket samtykke du har mottatt fra hvilken person, til enhver tid.

[!include[Need concent](includes/why-consent.md)]

## Definisjoner

* **Samtykke**: Du må få tillatelse fra en person før du kan lagre og behandle vedkommendes data.

* **Formål**: Hvorfor du lagrer og behandler en persons data. Eksempler: **Salg og kundeservice** og **E-markedsføring**. For hvert enkelt formål må du dokumentere følgende:

  * **Hjemmel**: Juridisk grunnlag for lagring og behandling av en persons data.
  * **Kilde**: Hvordan og hvor du innhentet personens samtykke.

## Tilgjengelige formål

* **Salg og kundeservice**: Dette formålet *må* ha et rettslig grunnlag og en rettskilde, fordi du må ha en persons samtykke for å lovlig behandle og lagre personopplysninger i SuperOffice.

* **E-markedsføring**: Du trenger tillatelse fra en person for å kunne sende e-markedsføringsmateriale til dem. Dette formålet kan du også angi ved å bruke **E-markedsføring**-knappen på fanen **Interesser**.

* Ytterligere formål kan legges til i Innstillinger og vedlikehold.

## Slik redigerer du personverninnstillingene for en person

> [!TIP]
> Hvis du vil redigere disse innstillingene for flere personer, bruker du [Masseredigering][2].

1. Gå til personen i skjermbildet Person.
    Nederst på personkortet kan du se om det er angitt et rettslig grunnlag for formålet **Salg og service**.

2. Klikk på **Rettslig grunnlag** nederst på personkortet.

    ![Nederst på Personkortet kan du åpne en persons personvernside ved å klikke på Hjemmel: Knappen Legitim interesse -screenshot][img1]

3. I dialogboksen **Personvern** dobbeltklikker du på et formål der kolonnene **Hjemmel** og **Kilde** er tomme.

    ![Personvernsiden viser deg alle samtykkene du har registrert for en person -screenshot][img2]

4. I dialogboksen **Rediger hjemmel** i listen **Hjemmel** velger du den aktuelle hjemmelen. Eksempel: Hvis personen har signert en serviceavtale, kan du velge **Inngått avtale**.

5. I listen **Kilde** velger du hvordan samtykket ble gitt av personen.

6. Du kan legge til en kommentar i feltet **Kommentar** hvis for eksempel samtykkekilden er ukjent.

7. Klikk på **Lagre**.

8. Gjenta trinn 3–7 hvis du vil redigere flere formål.

9. Klikk på **Lukk** når du er ferdig.

## Aktuelt innhold

* [Lær mer om GDPR, personvern- og samtykkehåndtering i SuperOffice][1]

<!-- Referenced links -->
[1]: ../../../../en/security/privacy/index.md
[2]: ../../../learn/basics/bulk-update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/security/legal-basisi.png
[img2]: ../../../../media/loc/en/security/legal-bases-registered-consent.png
