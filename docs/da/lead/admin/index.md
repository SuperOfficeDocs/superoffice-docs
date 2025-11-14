---
uid: help-da-lead-admin
title: Konfigurer leadhåndtering
description: Lær hvordan du aktiverer, konfigurerer og udvider leadhåndtering i SuperOffice CRM.
keywords: leadhåndtering, leadopsætning, leadstatus, potentiel kunde, salgsproces
author: digitaldiina
date: 12.11.2025
version: 11.6
content_type: overview
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
index: true
language: da
---

# Konfigurer leadhåndtering

Leadhåndtering i SuperOffice CRM hjælper dig med at spore potentielle kunder fra første kontakt gennem kvalificering og ind i salgsprocessen. For at komme i gang skal administratorer konfigurere, hvilke firmakategorier der bruger **Leadstatus**, gennemgå de tilgængelige statusværdier og eventuelt udvide sporing med markedsføringsdata.

> [!NOTE]
> Standardkategorierne *Lead*, *Marketingkvalificeret lead*, *Mulighed* og *Tabt mulighed* er kun inkluderet i nye databaser.
> Eksisterende kunder skal tilføje eller opdatere kategorier manuelt for at aktivere leadstatus.

## Trin 1: Aktivér leadstatus på en firmakategori

Leadstatus kan kun bruges til kategorier, der tilhører gruppen **Potentiel kunde**. Sørg for, at mindst én kategori er sat op på denne måde, før du aktiverer leadhåndtering.

1. Gå til **Indstillinger og vedligeholdelse** > **Lister** > **Firma – Kategori**.
1. Opret en ny kategori eller redigér en eksisterende.
1. Indstil **Kategorigruppe** til *Potentiel kunde*.
1. Vælg **Aktivér leadstatus for denne kategori**.
1. Klik **OK** for at gemme ændringerne.

![Aktivering af leadstatus for en kategori i listen Firma – Kategori, med gruppen Potentiel kunde valgt. -screenshot][img1]

For detaljer, se [Firmakategori og kategorigruppe][1].

## Trin 2: Tilpas listen for leadstatus

Listen **Person – Leadstatus** definerer de kvalificeringstrin, der bruges i organisationen. Som standard inkluderer SuperOffice statusser som *Åben*, *Kontakter*, *Kvalificeret*, *Diskvalificeret* og *Genoptag kontakt*.

1. Gå til **Indstillinger og vedligeholdelse** > **Lister** > **Person – Leadstatus**.
1. Gennemgå de foruddefinerede elementer.
1. Tilføj, redigér eller fjern statusser for at matche din egen kvalificeringsproces.

For detaljerede trin, se [Administrér leadstatusser][2].

## Trin 3: (Valgfrit) Udvid med Marketing Premium

Hvis du bruger Marketing Premium, kan du drage fordel af yderligere sporings- og automatiseringsfunktioner i din leadproces:

* **UTM-sporing:** Indfang kilden til nye leads fra onlineformularer.
  Se [Spor formular-UTM-data][3].
* **Lead-nurturing-flow:** Fordel nye leads automatisk til brugere.
  Se [Fordel nye leads][4].

## Relateret indhold

* [Oversigt over leadhåndtering][5]
* [Firmakategori og kategorigruppe][1]
* [Administrér leadstatusser][2]

<!-- Referenced links -->
[1]: add-company-category.md
[2]: add-lead-status.md
[3]: ../learn/index.md
[5]: ../../marketing/utm/admin/set-up.md
[4]: ../../marketing/flows/learn/define-flow-actions.md#distribute

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/enable-lead-status.png
