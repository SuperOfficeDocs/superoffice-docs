---
uid: help-no-lead-admin
title: Konfigurer leadhåndtering
description: Lær hvordan du aktiverer, konfigurerer og utvider leadhåndtering i SuperOffice CRM.
keywords: leadhåndtering, leadoppsett, leadstatus, potensiell kunde, salgsprosess
author: digitaldiina
date: 01.13.2026
version: 11.8
content_type: concept
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Innstillinger og vedlikehold
index: true
language: no
---

# Konfigurer leadhåndtering

Leadhåndtering i SuperOffice CRM hjelper deg med å spore potensielle kunder fra første kontakt gjennom kvalifisering og videre inn i salgsprosessen. For å komme i gang må administratorer konfigurere hvilke firmakategorier som bruker **Leadstatus**, gå gjennom tilgjengelige statusverdier og eventuelt utvide sporing med markedsføringsdata.

> [!NOTE]
> Standardkategoriene *Lead*, *Markedsføringskvalifisert lead*, *Mulighet* og *Tapt mulighet* er kun inkludert i nye databaser.
> Eksisterende kunder må legge til eller oppdatere kategorier manuelt for å aktivere leadstatus.

## Trinn 1: Aktiver leadstatus på en firmakategori

Leadstatus kan bare brukes for kategorier som tilhører gruppen **Potensiell kunde**. Sørg for at minst én kategori er satt opp på denne måten før du aktiverer leadhåndtering.

1. Gå til **Innstillinger og vedlikehold** > **Lister** > **Firma – Kategori**.
1. Opprett en ny kategori eller rediger en eksisterende.
1. Angi **Kategorigruppe** til *Potensiell kunde*.
1. Velg **Aktiver leadstatus for denne kategorien**.
1. Klikk **OK** for å lagre endringene.

![Aktivering av leadstatus for en kategori i Firma – Kategori-listen, med valgt gruppe Potensiell kunde. -screenshot][img1]

For detaljer, se [Firmakategori og kategorigruppe][1].

## Trinn 2: Tilpass listen for leadstatus

Listen **Person – Leadstatus** definerer kvalifiseringsstadiene som brukes i organisasjonen. Som standard inkluderer SuperOffice statuser som *Åpen*, *Kontakter*, *Kvalifisert*, *Diskvalifisert* og *Varmes opp igjen*.

1. Gå til **Innstillinger og vedlikehold** > **Lister** > **Person – Leadstatus**.
1. Gå gjennom de forhåndsdefinerte elementene.
1. Legg til, rediger eller fjern statuser for å tilpasse din egen kvalifiseringsprosess.

For detaljerte trinn, se [Administrer leadstatuser][2].

## Trinn 3: (Valgfritt) Konfigurer kategoriautomatisering

Kategoriautomatisering reduserer manuelt arbeid ved å oppdatere firmakategorier automatisk når salgsstatus endres eller leadstatus oppdateres. For eksempel kan du automatisk flytte en lead til *Kunde* når et salg er merket som vunnet.

1. Gå til **Innstillinger og vedlikehold** > **Arbeidsflyt** > **Lead-kategorisering**.
1. Aktiver automatiseringsreglene du vil bruke.
1. For hver regel, spesifiser målkategorien og om brukerbekreftelse er nødvendig.

For detaljerte trinn, se [Automatiser lead-kategorisering][6].

## Trinn 4: (Valgfritt) Utvid med Marketing Premium

Hvis du bruker Marketing Premium, kan du dra nytte av ekstra sporings- og automatiseringsfunksjoner i leadprosessen:

* **UTM-sporing:** Fange kilden til nye leads fra nettskjemaer.
  Se [Spor skjema-UTM-data][5].
* **Lead-nurturing-flyt:** Fordel nye leads automatisk til brukere.
  Se [Fordel nye leads][4].

## Relatert innhold

* [Oversikt over leadhåndtering][3]
* [Firmakategori og kategorigruppe][1]
* [Administrer leadstatuser][2]
* [Automatiser lead-kategorisering][6]

<!-- Referenced links -->
[1]: add-company-category.md
[2]: add-lead-status.md
[3]: ../learn/index.md
[4]: ../../marketing/flows/learn/define-flow-actions.md#distribute
[5]: ../../marketing/utm/admin/set-up.md
[6]: category-automation.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/enable-lead-status.png
