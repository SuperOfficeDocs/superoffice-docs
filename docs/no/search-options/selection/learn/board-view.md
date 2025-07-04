---
uid: help-no-selection-board-view
title: Bruk tavlevisning i utvalg
description: Visualiser utvalg med tavlevisning med gruppering, filtre og dra-og-slipp-kort
keywords: tavlevisning, utvalgsvisning, utvalg, salgstavle, kanban, gruppér etter, verktøylinje for filter
author: Bergfrid Dias
date: 06.17.2025
version: 11.2
content_type: howto
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: no
---

# Bruk tavlevisning i utvalg <i class="ph ph-kanban" aria-hidden="true"></i>

Tavlevisning viser ditt [utvalg][2] i et kolonnebasert oppsett med kort. Du kan gruppere og filtrere utvalgsmedlemmene (postene som vises på tavlen), og bruke dra-og-slipp for å flytte kort mellom grupper.

Funksjonaliteten er lik på tvers av støttede posttyper: Du kan dra kort, åpne oppgavemenyer og justere tavleinnstillinger. Tilgjengelige grupperings- og filterfelter varierer avhengig av om du jobber med salg, prosjekter eller saker.

![Tavlevisning som viser salg gruppert etter fase -screenshot][img2]

Tavlevisning er foreløpig tilgjengelig for **utvalg av salg**, og støtte for **prosjekter** og **saker** er planlagt.

## Åpne tavlevisning

1. Gå til et utvalg.
1. Velg ikonet for **tavlevisning** øverst til høyre (<i class="ph ph-kanban" aria-label="Kanban board"></i>).

    ![Ikon for tavlevisning øverst til høyre i et utvalg][img1]

## Arbeid med kort

* Klikk på korttittelen for å åpne hele posten (for eksempel et salgskort).

* Hold musepekeren over et navn eller en bedrift for å forhåndsvise kontaktopplysninger.

    ![Forhåndsvisning ved hover som viser kontaktopplysninger på et kort -screenshot][img3]

* Dra kort mellom kolonner for å oppdatere grupperingsfeltet (som fase eller eier).
  * Hvis undergrupper er aktivert, kan du også dra kort mellom rader i hver kolonne.

* For å redigere et kort, pek på det og velg knappen **Rediger** (<i class="ph ph-pencil" aria-hidden="true"></i>). Dette åpner samme redigeringsdialog som brukes andre steder i SuperOffice CRM – uten å forlate tavlevisningen.

  ![Markør som peker på redigeringsknapp på et salg i tavlevisning -screenshot][img4]

* For flere alternativer, pek på kortet for å vise **Oppgave**-menyen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>), velg den og velg blant tilgjengelige handlinger.

  * **Salg:** Rediger, Opprett oppfølging, Marker som solgt/tapt, Slett
  * **Prosjekter:** Rediger, Opprett oppfølging, Opprett dokument, Marker som utført, Slett
  * **Saker:** Rediger, Lukk sak, Slett

  ![Åpen oppgavemeny for et salg i tavlevisning som viser tilgjengelige alternativer -screenshot][img5]

<!-- markdownlint-disable-next-line MD013 -->
## Tilpass tavleoppsett <i class="ph ph-gear-six" aria-hidden="true"></i> <i class="ph ph-sliders-horizontal" aria-hidden="true"></i>

### Grupper og undergrupper

Slik velger du hvilke kolonner som skal vises:

1. Velg ikonet for **innstillinger** (<i class="ph ph-gear-six" aria-hidden="true"></i>).

1. Velg **Gruppér etter**.

    ![Innstillingspanel for tavlevisning av salgsutvalg som viser grupperingsvalg -screenshot][img6]

1. Velg et felt for å definere kolonneoppsettet.

    ![Meny for gruppér etter som viser tilgjengelige salgsfelt som Fase og Eier -screenshot][img7]

1. Velg bakoverpilen (<i class="ph ph-caret-left" aria-hidden="true"></i>) for å gå tilbake til oversikten over innstillinger.

1. Velg eventuelt en verdi for **Undergruppér etter** for å organisere kort i egne rader innenfor hver kolonne.

1. Velg eventuelt **Lagre innstillinger kun for valgt utvalg** for å bruke endringene kun i denne tavlevisningen.

1. Velg **Ferdig** for å bruke innstillingene.

Eksempler på grupperingsfelt:

* **Salg:** Fase, Salgstype, Eier
* **Prosjekter:** Status, Ansvarlig, Type
* **Saker:** Status, Sakstype, Prioritet, Eier

### Sortér kort i kolonner

Bruk innstillingspanelet (<i class="ph ph-gear-six" aria-hidden="true"></i>) for å konfigurere **Sortér etter** og **Sorteringsrekkefølge**, for eksempel etter salgsdato.

### Angi filtre

1. Velg <i class="ph ph-sliders-horizontal" aria-label="Toggle filter toolbar"></i> for å vise verktøylinje for filter.

    ![Verktøylinje for filter i tavlevisning for salgsutvalg -screenshot][img9]

1. Slik velger du hvilke filtre som skal være tilgjengelige:

    1. Klikk <i class="ph ph-gear-six" aria-hidden="true"></i> for å åpne innstillingspanelet.
    1. Velg **Verktøylinje for filter** og aktiver filtre ved hjelp av avmerkingsboksene.
    1. Klikk bakoverpilen (<i class="ph ph-caret-left" aria-hidden="true"></i>) for å gå tilbake til oversikten over innstillinger og klikk deretter **Ferdig**.

    ![Filterinnstillinger som viser tilgjengelige salgsfelt som Fase og Eier -screenshot][img8]

1. I verktøylinjen, utvid et filter (for eksempel **Eier**) for å vise en liste med elementer.

    * Velg eller fjern elementer for å inkludere dem.
    * Velg **Tøm** nederst i en rullegardinmeny for å nullstille det filteret.
    * Velg **X** helt til høyre i verktøylinjen for å nullstille **alle** filtre samtidig.

    ![Verktøylinje for filter, salgstype utvidet -screenshot][img10]

### Oppsummer (kun salg)

Du kan vise summer for numeriske felt i tavlevisningen for salg.

1. Velg <i class="ph ph-gear-six" aria-hidden="true"></i> for å åpne innstillingspanelet.
2. Velg **Oppsummer etter**.
3. Velg et numerisk felt, som **Beløp** eller **Vektet beløp**.

Totalverdien vises **ved siden av hvert kolonnenavn**, og hjelper deg med å følge verdifordelingen på tvers av faser, eiere eller andre grupperingsfelt.

![Tavlevisning for salg som viser summerte verdier for beløp ved siden av hvert kolonnenavn -screenshot][img11]

## Bruksområder

Tavlevisning støtter ulike roller og arbeidsflyter. Her er eksempler for salgsrepresentanter og salgssjefer:

### Salgsrepresentanter

* **Visualiser åpne salg** og se hvor hver mulighet befinner seg i salgsprosessen.
* **Dra et kort til en annen kolonne** for å oppdatere salgsfasen.
* **Filtrer etter salgsdato** for å fokusere på det som haster.
* **Åpne oppgavemenyen** for å opprette en oppfølging, eller markere et salg som solgt eller tapt.
* **Rediger et kort raskt** for å oppdatere detaljer som ny kontaktperson.

### Salgssjefer

* **Visualiser hele salgsprosessen** og forstå fordelingen av salg mellom faser.
* **Oppsummer etter beløp** for å støtte prognoser.
* **Filtrer etter salgstype** for å fokusere på ny forretning eller bestemte kampanjetyper.
* **Gruppér etter eier** for å sjekke arbeidsmengde per selger og balansere ved hjelp av dra og slipp.
* **Bruk fase som gruppe og salgstype som undergruppe** for å få et strategisk overblikk etter kategori og fase.

Bruk gruppering kreativt for å organisere og handle effektivt på data.

## Feilsøking og tips

* **Nye salg mangler:** Klikk <i class="ph ph-arrow-clockwise" aria-label="Refresh icon"></i> for å laste tavlevisningen på nytt og hente siste data.

* **Verktøylinje for filter er ikke synlig:** Slå verktøylinjen for filter på eller av med <i class="ph ph-sliders-horizontal" aria-hidden="true"></i>-ikonet.

* **En kolonne er tom:** Du kan ha filtrert bort innholdet. Sjekk aktive filtre i verktøylinjen.

* **Finner ikke et filterfelt:** Åpne **Innstillinger** (<i class="ph ph-gear-six" aria-hidden="true"></i>) > **Verktøylinje for filter** og aktiver feltet du ønsker å bruke.

* **Trenger du å redigere selve utvalget (ikke et medlem)?** Klikk <i class="ph ph-subtract-square" aria-label="Selection icon"></i> for å gå tilbake til utvalgsvisning. Redigerings- og oppgaveknapper for utvalget er ikke tilgjengelige i tavlevisning.

* **Søk i tavlen etter navn:** Bruk feltet **Filtrer etter tittel** øverst for å begrense synlige kort etter navn.

* **Lagre oppsett per brukstilfelle:** Velg **Lagre innstillinger kun for valgt utvalg** hvis du vil bevare et spesifikt tavleoppsett, filtre eller gruppering for ett utvalg.

## Relatert innhold

* [Opprett et utvalg][1]
* [Opprett et salg / felt i salgskortet][12]
* [Konfigurer salgsfaser][13]

<!-- Refererte lenker -->
[1]: create.md
[2]: selections.md
[12]: ../../../sale/learn/create.md
[13]: ../../../sale/admin/sale-stage.md

<!-- Refererte bilder -->
[img1]: ../../../../media/loc/en/search-options/board-view-toggle.png
[img2]: ../../../../media/loc/en/search-options/board-view.png
[img3]: ../../../../media/loc/en/search-options/board-view-preview-contact-on-hover.png
[img4]: ../../../../media/loc/en/search-options/board-view-card-edit-icon.png
[img5]: ../../../../media/loc/en/search-options/board-view-card-task-menu.png
[img6]: ../../../../media/loc/en/search-options/board-view-settings.png
[img7]: ../../../../media/loc/en/search-options/board-view-settings-group-by.png
[img8]: ../../../../media/loc/en/search-options/board-view-settings-filter.png
[img9]: ../../../../media/loc/en/search-options/board-view-filter-toolbar.png
[img10]: ../../../../media/loc/en/search-options/board-view-filter-on-sale-type.png
[img11]: ../../../../media/loc/en/search-options/board-view-summarized-sale-amount-per-column.png
