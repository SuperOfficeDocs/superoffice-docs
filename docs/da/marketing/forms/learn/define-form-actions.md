---
uid: help-da-form-actions
title: Definer formularhandlinger
description: Definer formularhandlinger
keywords: skjema, automatisering, formularhandling, formularindsendelse, tilmelding
author: SuperOffice RnD
date: 06.14.2024
version: 10.3.5
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Definer formularhandlinger

At behandle 200 tilmeldinger til begivenheden manuelt er tidskrævende og unødvendigt. Automatiserede formularhandlinger kan optimere denne proces.

Automatisering sparer tid, der ellers ville blive brugt på at håndtere svar. Når en person indsender formularen, udfører systemet handlingerne for dig!

![Definer formularhandlinger -screenshot][img17]

## Tilgængelige handlinger

### Giv besked om indsendelser ved at oprette sager

Vælg denne valgmulighed for at [oprette en sag][8] for hver formular, der indsendes. Indtast en titel, og vælg kategori og prioritet for sagen.

Indsendte formularer vil være tilgængelige under **Sager** og under fanen **Sag** på skærmbillederne Firma og Person i SuperOffice CRM.

### Hvordan skal en formularindsendelse behandles?

Her kan du definere, om de indsendte formularer skal behandles automatisk.

* **Behandl alle indsendelser automatisk. Opret ny person, hvis der ikke blev funden et match**: Alle formularindsendelser behandles automatisk. Der vil ikke være nogen meddelelser om indsendte formularer.

* **Manuelt, hvis indsenderen er ukendt. Automatisk, hvis indsenderen er kendt**: Hvis e-mailadressen, der indsendes i formularen matcher en e-mailadresse i SuperOffice, behandles den indsendte formular automatisk. Ellers skal den behandles manuelt. Du modtager en meddelelse.

* **Manuelt for alle indsendelser**: Du modtager en meddelelse for hver indsendt formular.

![ikon][img11] [Behandling af formularindsendelser][6].

### Hvad skal der ske, når formularen behandles?

Her kan du vælge handlinger, der skal udføres, når en formular behandles (automatisk eller manuelt):

* **Tilføj person til udvalg**: Hvis du har valgt automatisk behandling ovenfor, skal du tilføje et udvalg her til at spore personer, der tilføjes via denne formular. Det vil også gøre det nemmere at fjerne irrelevante personer (og firmaer).

* **Tilføj person til projekt**: Vælg et projekt. Personer, der indsender denne formular, føjes til dette projekt.

* **Tilføj interesser til person**: Vælg en interesse. Denne interesse vil blive føjet til personer, der indsender denne formular.

* **E-mail-svar**: Vælg et formularsvar, der skal sendes til personer, når deres formular behandles. [Sådan oprettes et formularsvar][7].

* **Opret sag**: Hvis du har tilføjet et sagsfelt i kategorien **Felter**, skal du også vælge en standardkategori og prioritet for de sager, der oprettes via denne formular. Indsendte formularer vil være tilgængelige under **Sager** i SuperOffice Service og under fanen **Sag** på skærmbillederne Firma og Person i SuperOffice CRM.

* **Udfør CRMScript**: Vælg et [CRMScript][9] eller en makro, der skal køres, når en formularindsendelse behandles.

* **Standardkategori** / **Standardvirksomhed**: Vælg en standardkategori og -virksomhed for alle personer eller firmaer, der føjes til SuperOffice baseret på sendte formularer. Med denne mulighed kan du gruppere formularafsendelser og nye kontakter/virksomheder til en bestemt kategori og/eller virksomhed.

    Hvis du f.eks. har en formular til kundeemner, skal du vælge kundeemner som din kategori. Du kan derefter nemt oprette valg baseret på denne kategori og/eller virksomhed.

> [!NOTE]
> Når du opdaterer et formular, skal du huske, at det kan blive brugt af flere kampagner og/eller automatiserede flows. Sørg for, at der ikke er nogen duplikerede eller modstridende handlinger.

## Relateret indhold

* [Udgiv formularer][2]

<!-- Referenced links -->
[2]: publish.md
[6]: process-submissions.md
[7]: ../../mailing/learn/create/tutorial-form-mailing.yml
[8]: ../../../request/learn/create.md
[9]: ../../../../en/automation/crmscript/howto/marketing/forms.md

<!-- Referenced images -->
[img11]: ../../../../media/loc/en/marketing/form-notification.png
[img17]: ../../../../media/loc/en/marketing/contact-me-form-actions.png
