---
uid: help-no-selection-create
title: Opprett utvalg
description: Arbeide med dynamiske og statiske utvalg
keywords: opprett utvalg, nytt utvalg, lagre som utvalg, utvalg
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from:
  - /no/sale/saint/learn/using-status-monitors-in-dynamic-selections
  - /no/search-options/selection/learn/create/copy
  - /no/search-options/selection/learn/create/index
  - /no/search-options/selection/learn/create/tutorial
---

# Opprett utvalg

Du starter med et sett kriterier fra **Finn**-skjermbildet ved å bruke et vanlig søk eller legge til egne kriterier. Herfra kan du lagre resultatet som et dynamisk eller statisk utvalg. Forskjellen mellom de to er at den ene er et utvalg som fortsetter å oppdatere antall medlemmer (dynamisk) eller et utvalg som har medlemmene frosset med et øyeblikksbilde av dagens sett med medlemmer (statisk).

## Trinn

1. Klikk på **Ny** i toppraden, og velg **Utvalg**.

1. I Finn-skjermen klikker du på **Finn**-valget som er relevant for datatypen du vil bruke i utvalget. Du kan også klikke på **Vanlige søk** for å bruke forhåndsdefinerte søk.

1. [Legg til søkekriteriene][9] i fanen **Kriterier** .

1. Klikk på **Finn**. Fanen **Resultater** viser dataene som samsvarer med kriteriene dine.

1. Hvis du vil lagre resultatene i et merket område, klikker du **Lagre som utvalg**. Hvis ikke, endre søkekriteriene.

1. I dialogboksen **Lagre som utvalg** velger du type:

    * **Dynamisk utvalg:** Denne typen utvalg blir alltid oppdatert med medlemmer som samsvarer med utvalgskriteriene.
    * **Statisk utvalg:** Denne typen valg inneholder bare medlemmene du har lagt til manuelt.
    * **Legg til i eksisterende statisk utvalg:** Lagre resultatet i et eksisterende utvalg. Du kan manuelt legge til eller fjerne medlemmer fra utvalget senere.

1. Klikk på **Lagre**.

1. Skriv inn navnet på det nye utvalget der *Utvalgsnavn* vises. Dette feltet er obligatorisk.

1. I feltet **Utvalg er** kan du endre til en annen type valg om nødvendig.

1. **Velg detaljer:**

    * **Eier:** I feltet vises pålogget bruker automatisk.

        Når du har lagret et nytt utvalg, kan du endre eier ved å [redigere utvalget][6]. I praksis betyr det at du overfører det fra deg selv og til noen andre.

    * **Kategori:** Velg hvilken type utvalg du ønsker. Disse er definert i Innstillinger og vedlikehold.

    * **Synlig for:** Velg om utvalget skal være synlig for alle, privat (bare synlig for personen som er definert som eier) eller synlig for alle i brukergruppen som eieren tilhører.

1. Legg til en beskrivelse av utvalget i feltet **Beskrivelse**,hvis relevant.

1. Når du er ferdig med å definere kjernedataene for utvalget, klikker du på **Lagre**.

## <a id="copy"></a>Kopier et utvalg

Du kan raskt og enkelt lage en nøyaktig kopi av et utvalg ved å velge oppgaven **Kopier utvalget**.

Når du klikker på denne knappen, opprettes en kopi av utvalget med teksten (kopi) ved siden av utvalgsnavnet. Det vil si at hvis du kopierer utvalget *Mitt statiske utvalg*, vil kopien få navnet *Mitt statiske utvalg (kopi)*.

1. [!include[Start](includes/steps-start-task.md)]

1. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Oppgave-knappen"></i> og velg **Kopier utvalget**. Da opprettes en kopi av utvalget.

1. Gi det nye utvalget et nytt navn.

## Tips

* Hvis du forsøker å registrere et utvalg med samme navn som et eksisterende utvalg, får du opp [dialogboksen Duplikater][8]. Denne fungerer på samme måte som for firmaer.

* Klikk på <i class="ph ph-star" aria-label="Star icon"></i> for å legge utvalget til [favorittene dine][7].

* Klikk på <i class="ph ph-gear" aria-label="Gear"></i> til høyre for kolonneoverskriftene. Her kan du gruppere og filtrere poster, og legge til/fjerne kolonner. Disse innstillingene kan lagres for det aktive utvalget ved å velge **Lagre kolonner bare for gjeldende utvalg**.

* Merk av for **Utført** for å angi at valget er inaktivt. Hvis du vil at utvalget skal være aktivt, lar du avmerkingsboksen stå tom.

* Med **SAINT** aktivert (krever Sales-Premium eller Service-Premium) kan du bruke [statuser][14] som kriterier for å opprette dynamiske utvalg. Dette gir deg en oversikt over firmaer, personer eller prosjekter som oppfyller spesifikke statuskriterier. SAINT-kriteriene finnes under **Tellere (SAINT)** i [kriterielisten][9] på **Finn**-skjermen.

## Relatert innhold

* [Kombinere utvalg][3]
* [Oppdater et utvalg][6]
* [Utfør oppgaver ved å bruke utvalg][5]

<!-- Referenced links -->
[3]: combine.md
[7]: ../../../learn/basics/fav.md
[8]: ../../../learn/basics/duplicates.md
[5]: howto/index.md
[6]: update.md
[9]: ../../learn/search-criteria.md
[14]: ../../../saint/learn/index.md

<!-- Referenced images -->
