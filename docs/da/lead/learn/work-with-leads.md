---
uid: help-da-work-with-leads
title: Arbejd med leads i SuperOffice
description: Lær at se, opdatere og følge op på leads i SuperOffice CRM.
keywords: lead
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Arbejd med leads i SuperOffice

Leads repræsenterer personer, der har vist interesse, men som endnu ikke er en del af en aktiv salgsproces. SuperOffice hjælper dig med at følge, hvor hver lead befinder sig i kvalificeringsprocessen, og give opfølgning på rette tidspunkt.

Denne side viser, hvordan du ser, opdaterer og bruger leadinformation i dit daglige arbejde.

## Se leadinformation på en person

> [!NOTE]
> Feltet **Leadstatus** vises kun, når firmaet tilhører en kategori i gruppen **Potentiel kunde** med **Aktivér leadstatus** valgt.

1. Åbn en person.

1. Kontrollér feltet **Kategori** for at se, om personen tilhører en potentiel kunde-kategori.

1. Hvis leadstatus er aktiveret for firmakategorien, vises feltet **Leadstatus** direkte under feltet **Kategori**.

1. Hold musen over statusværdien for at vise beskrivelsen.

    ![Leadstatus vist på Person-skærmbilledet, med et værktøjstip der beskriver den valgte status. -screenshot][img1]

## Opdatér leadstatus

1. Klik <i class="ph ph-pencil-simple" aria-label="Edit"></i> øverst til højre på personkortet.

1. Vælg rullemenuen **Leadstatus**.

1. Vælg den status, som bedst afspejler leadets nuværende trin.

    * **Kontakter:** Du forsøger at komme i kontakt med leadden.
    * **Kvalificeret:** Leadden har det rette match og interesse.
    * **Diskvalificeret:** Leadden er ikke relevant.
    * **Genoptag kontakt:** Følg op senere.

1. Klik **Gem** for at gemme dine ændringer.

## Vis leads på Kontakt-detaljefanen

1. Gå til et firma og åbn [**Kontakter**-detaljefanen][7].

1. Vælg <i class="ph ph-gear" aria-label="Settings (cogwheel)"></i> for at tilpasse kolonner.

1. Tilføj **Kategori**, **Kategorigruppe** og **Leadstatus**.

1. Du kan også [filtrere eller gruppere listen][8] for at fokusere på bestemte leadstadier.

    ![Tilføjelse af Kategori og Kategorigruppe som kolonner på Kontakter-detaljefanen. -screenshot][img2]

## Opret udvalg

Du kan bruge kategorier og leadstatus til at finde og segmentere personer og firmaer i SuperOffice CRM.

I **Find**-skærmbilledet kan du tilføje kriterier som:

* **Person** > **Leadstatus** – Er en af / Er ikke en af.
* **Firma** > **Kategorigruppe** – Er en af / Er ikke en af.
    Brug dette til at besvare spørgsmål som "Vis alle mine potentielle kunder" eller "Vis alle mine kunder" (i stedet for at tilføje mange kategorier individuelt).
* **Firma** > **Lead** eller **Person** > **Lead** baseret på [UTM-data][5] (kræver Marketing Premium).

![Filtrering af personer efter Leadstatus og Kategorigruppe i Find person-kriteriepanelet. -screenshot][img3]

Du kan gemme dine søgeresultater som et **udvalg**, som senere kan bruges til målrettede marketingaktiviteter eller rapporter.

![Visning af leadinformation i Find person-resultater, inkl. Kategori, Leadstatus og leadkilde. -screenshot][img4]

Dynamiske udvalg af firmaer eller personer kan også åbnes i [Tavlevisning][6] for at visualisere lead-fremskridt. Hver kolonne repræsenterer en leadstatus.

![Visning af leads efter status i tavlevisning, grupperet i trin som Åben, Kontakter, Diskvalificeret, Genoptag kontakt og Kvalificeret. -screenshot][img5]

## Tips og fejlfinding

* **Jeg kan ikke se feltet Leadstatus.**

    Leadstatus vises kun på personer og kun når firmaet tilhører gruppen **Potentiel kunde** med **Aktivér leadstatus** valgt.

* **Jeg kan ikke vælge Lead eller Marketingkvalificeret lead som kategori.**

    Disse kategorier findes kun i nye databaser. Bed administrator om at tilføje eller opdatere kategorierne.

* **Feltet Leadstatus forsvandt efter jeg ændrede firmakategori.**

    Leadstatus skjules, når firmaet flyttes ud af gruppen **Potentiel kunde**. Værdien bevares og kan findes via søgning, men kan ikke redigeres.

* **Forskellige personer i samme firma viser forskellige leadstatusser.**

    Leadstatus gemmes på personniveau.

* **En person får altid Leadstatus = Åben, når de flyttes til en potentiel kunde-kategori.**

    Dette er forventet. Nye leads starter altid med *Åben*.

* **Jeg kan ikke ændre kategorien på en person.**

    Personer arver kategorien fra deres firma. For at ændre den skal du opdatere kategorien på firmakortet.

## Relateret indhold

* [Oversigt over leadhåndtering][1]
* [Brug dashboards til at overvåge leads][4]
* [Masseopdater personoplysninger][9]

<!-- Referenced links -->
[1]: index.md
[4]: ../../dashboard/learn/show-leads.md
[5]: ../../marketing/utm/learn/index.md
[6]: ../../search-options/selection/learn/board-view.md
[7]: ../../learn/section-tabs/contacts-tab.md
[8]: ../../learn/section-tabs/filter.md
[9]: ../../learn/basics/bulk-update.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/contact-card-open-lead.png
[img2]: ../../../media/loc/en/lead/contact-section-tab-with-lead-info.png
[img3]: ../../../media/loc/en/lead/find-leads.png
[img4]: ../../../media/loc/en/lead/save-leads-as-selection.png
[img5]: ../../../media/loc/en/lead/filtered-lead-board.png
