---
uid: help-no-lead-admin
title: Konfigurer leadhåndtering
description: Lær hvordan du aktiverer, konfigurerer og utvider leadhåndtering i SuperOffice CRM.
keywords: leadhåndtering, leadoppsett, leadstatus, potensiell kunde, salgsprosess
author: digitaldiina
date: 12.11.2025
version: 11.6
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

## Trinn 3: (Valgfritt) Utvid med Marketing Premium

Hvis du bruker Marketing Premium, kan du dra nytte av ekstra sporings- og automatiseringsfunksjoner i leadprosessen:

* **UTM-sporing:** Fange kilden til nye leads fra nettskjemaer.
  Se [Spor skjema-UTM-data][3].
* **Lead-nurturing-flyt:** Fordel nye leads automatisk til brukere.
  Se [Fordel nye leads][4].

## Relatert innhold

* [Oversikt over leadhåndtering][5]
* [Firmakategori og kategorigruppe][1]
* [Administrer leadstatuser][2]

<!-- Referenced links -->
[1]: add-company-category.md
[2]: add-lead-status.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/enable-lead-status.png
[3]: ../learn/index.md
[5]: ../../marketing/utm/admin/set-up.md
[4]: ../../marketing/flows/learn/define-flow-actions.md#distribute
