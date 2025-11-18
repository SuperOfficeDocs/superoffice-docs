---
uid: help-no-work-with-leads
title: Arbeid med leads i SuperOffice
description: Lær hvordan du viser, oppdaterer og følger opp leads i SuperOffice CRM.
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
language: no
---

# Arbeid med leads i SuperOffice

Leads representerer personer som har vist interesse, men som ennå ikke er en del av en aktiv salgsprosess. SuperOffice hjelper deg med å spore hvor hver lead befinner seg i kvalifiseringsprosessen og følge opp med riktig aktivitet til riktig tid.

Denne siden viser hvordan du kan se, oppdatere og bruke leadinformasjon i det daglige arbeidet.

## Se leadinformasjon på en person

> [!NOTE]
> Feltet **Leadstatus** vises bare når firmaet tilhører en kategori i gruppen **Potensiell kunde** med **Aktiver leadstatus** valgt.

1. Åpne en person.

1. Sjekk feltet **Kategori** for å se om personen tilhører en kategori for potensielle kunder.

1. Hvis leadstatus er aktivert for firmakategorien, vises feltet **Leadstatus** rett under feltet **Kategori**.

1. Hold markøren over statusverdien for å vise beskrivelsen.

    ![Leadstatus vist på personskjermen, med et verktøytips som beskriver valgt status. -screenshot][img1]

## Oppdater leadstatus

1. Klikk <i class="ph ph-pencil-simple" aria-label="Edit"></i> øverst til høyre på personkortet.

1. Velg rullegardinlisten **Leadstatus**.

1. Velg statusen som best gjenspeiler hvor leadden befinner seg nå.

    * **Kontakter:** Du forsøker å komme i kontakt med leadden.
    * **Kvalifisert:** Leadden har riktig profil og interesse.
    * **Diskvalifisert:** Leadden er ikke relevant.
    * **Varmes opp igjen:** Følg opp senere.

1. Klikk **Lagre** for å lagre endringene.

## Vis leads i personfanen

1. Gå til et firma og åpne [**Personer**-detaljkortet][7].

1. Velg <i class="ph ph-gear" aria-label="Settings (cogwheel)"></i> for å tilpasse kolonner.

1. Legg til **Kategori**, **Kategorigruppe** og **Leadstatus**.

1. Eventuelt kan du [filtrere eller gruppere listen][8] for å fokusere på bestemte leadstadier.

    ![Legge til kolonnene Kategori og Kategorigruppe i personfanen. -screenshot][img2]

## Opprett utvalg

Du kan bruke kategorier og leadstatus for å finne og segmentere personer og firmaer i SuperOffice CRM.

I **Søk**-skjermen kan du legge til kriterier som:

* **Person** > **Leadstatus** – Er en av / Er ikke en av.
* **Firma** > **Kategorigruppe** – Er en av / Er ikke en av.
    Bruk dette for å svare på spørsmål som «List alle mine potensielle kunder» eller «List alle mine kunder» (i stedet for å legge inn flere enkelkategorier som kriterier).
* **Firma** > **Lead** eller **Person** > **Lead** basert på [UTM-data][5] (krever Marketing Premium).

![Filtrere personer etter Leadstatus og Kategorigruppe i Søk etter person-kriteriepanelet. -screenshot][img3]

Du kan lagre søkeresultatene dine som et **utvalg**, som senere kan brukes for målrettede markedsføringsaktiviteter eller rapporter.

![Vise leadinformasjon i Søk etter person-resultater, inkludert Kategori, Leadstatus og kilden til leadopprettelse. -screenshot][img4]

Dynamiske utvalg av firmaer eller personer kan også åpnes i [Tavlevisning][6] for å visualisere leadprogresjon. Hver kolonne representerer en leadstatus.

![Vise leads etter status i en tavlevisning, gruppert i stadier som Åpen, Kontakter, Diskvalifisert, Varmes opp igjen og Kvalifisert. -screenshot][img5]

## Tips og feilsøking

* **Jeg ser ikke feltet Leadstatus.**

    Leadstatus vises bare på personer. Det vises kun når firmaet tilhører en kategori i gruppen **Potensiell kunde** med **Aktiver leadstatus** valgt.

* **Jeg kan ikke velge Lead eller Markedsføringskvalifisert lead som kategori.**

    Disse kategoriene finnes kun i nye databaser. Be administrator om å legge dem til eller oppdatere eksisterende liste.

* **Feltet Leadstatus forsvant etter at jeg endret firmakategori.**

    Leadstatus skjules når firmaet flyttes til en kategori utenfor gruppen **Potensiell kunde**. Verdien beholdes i databasen og er søkbar, men kan ikke redigeres.

* **Forskjellige personer i samme firma viser ulike leadstatuser.**

    Leadstatus lagres på personnivå. En person kan være diskvalifisert mens en annen fortsatt er i et tidlig stadium.

* **En person får alltid Leadstatus = Åpen når den flyttes til en kategori for potensielle kunder.**

    Dette er forventet. Nye leads starter alltid med statusen *Åpen*.

* **Jeg kan ikke endre kategorien på en person.**

    Personer arver kategorien fra firmaet sitt. For å endre den, oppdater kategorien på firmakortet.

## Relatert innhold

* [Oversikt over leadhåndtering][1]
* [Bruk dashbord for å følge opp leads][4]
* [Masseoppdater personinformasjon][9]

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
