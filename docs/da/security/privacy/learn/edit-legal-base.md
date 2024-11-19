---
uid: help-da-edit-legal-base
title: Rediger retsgrundlag
description: I denne vejledning lærer du om GDPR-funktionerne i SuperOffice Markedsføring, der hjælper dig med at sikre, at din markedsføringsindsats er i overensstemmelse med GDPR.
keywords: personbeskyttelse, samtykke, retsgrundlag
author: SuperOffice RnD
date: 10.08.2024
version: 10.3.10
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Redigering af indstillinger om personbeskyttelse for en person

> [!NOTE]
> Denne funktion kræver funktionelle rettigheder. Hvis du ikke har de rette funktionsrettigheder, kan du kun angive **E-markedsføring** som enten til eller fra.

Som firma indsamler, gemmer og håndterer du folks personoplysninger. I henhold til GDPR skal du nu have en lovlig grund til, hvorfor du vil gemme denne information.

SuperOffice CRM har en funktion kaldet Samtykkehåndtering, der er designet til at hjælpe dig med at dokumentere, hvornår, hvordan og hvorfor du vil registrere bestemte personoplysninger i din CRM-løsning.

Hver gang en person registreres i din SuperOffice CRM-database, registreres også det samtykke, personen har givet til, at vedkommendes detaljer må gemmes. Dette gør det muligt for dig til enhver tid at administrere og spore nøjagtigt, hvilket samtykke du har modtaget fra hvilken person.

[!include[Need concent](includes/why-consent.md)]

## Definitioner

* **Samtykke**: Du skal have tilladelse fra den aktuelle person, før du kan lagre og administrere vedkommendes data.

* **Formål**: Grunden til, at du lagrer og behandler en persons data. Eksempler: **Salg og service** og **E-markedsføring**. For hvert enkelt formål skal du dokumentere følgende:

  * **Retsgrundlag**: Det juridiske grundlag for lagring og behandling af en persons data.
  * **Kilde**: Hvordan og hvor du har fået personens samtykke.

## Tilgængelige formål

* **Salg og kundeservice**: Dette formål *skal* have et retsgrundlag og en kilde, fordi du skal have personens samtykke, før du på lovlig vis kan behandle og gemme den pågældendes data i SuperOffice.

* **E-markedsføring**: Du skal have den pågældende persons tilladelse til at sende vedkommende elektronisk markedsføringsmateriale. Dette formål kan du også angive ved at bruge knappen **E-markedsføring** på fanen **Interesser**.

* Yderligere formål kan tilføjes i Indstillinger og vedligeholdelse.

## Sådan redigeres privacy-indstillingerne for en person

> [!TIP]
> Hvis du vil redigere disse indstillinger for flere personer, kan du bruge [Masseredigering][2].

1. Gå til personen i skærmbilledet Person.
    Nederst i personkortet kan du se, om der er angivet et retsgrundlag for formålet **Salg og service**.

2. Klik på **Retsgrundlag** nederst på personkortet.

    ![Nederst på personkortet kan du åbne en persons side for beskyttelse af personlige oplysninger ved at klikke på Retsgrundlag: Knappen Legitim interesse -screenshot][img1]

3. I dialogboksen **Privacy** skal du dobbeltklikke på et formål, hvor kolonnerne **Retsgrundlag** og **Kilde** er tomme.

    ![Siden Privacy viser dig alle de samtykker, du har registreret for en person -screenshot][img2]

4. I dialogboksen **Rediger retsgrundlag** skal du vælge listen **Retsgrundlag** og derefter vælge det gældende retsgrundlag. Eksempel: Hvis personen har underskrevet en serviceaftale, kan du vælge **Indgået aftale**.

5. På listen **Samtykkekilde** vælger du, hvordan samtykket blev givet af personen.

6. Du kan tilføje en kommentar i feltet **Kommentar**, hvis samtykkekilden for eksempel er ukendt.

7. Klik på **Gem**.

8. Gentag trin 3-7, hvis du vil redigere flere formål.

9. Klik på **Luk**, når du er færdig.

## Relateret indhold

* [Få mere at vide om GDPR, privacy og samtykkehåndtering i SuperOffice][1]

<!-- Referenced links -->
[1]: ../../../../en/security/privacy/index.md
[2]: ../../../learn/basics/bulk-update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/security/legal-basisi.png
[img2]: ../../../../media/loc/en/security/legal-bases-registered-consent.png
