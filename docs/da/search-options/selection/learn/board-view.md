---
uid: help-da-selection-board-view
title: Brug tavlevisning i udvalg
description: Visualiser udvalg med tavlevisning med gruppering, filtre og træk-og-slip-kort
keywords: tavlevisning, udvalgsvisning, udvalg, salgstavle, kanban, gruppér efter, filter-værktøjslinje
author: Bergfrid Dias
date: 06.17.2025
version: 11.2
topic: howto
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: da
---

# Brug tavlevisning i udvalg <i class="ph ph-kanban" aria-hidden="true"></i>

Tavlevisning viser dit [udvalg][2] i et kolonnebaseret layout med kort. Du kan gruppere og filtrere udvalgsmedlemmerne (de poster, der vises på tavlen), og bruge træk-og-slip til at flytte kort mellem grupper.

Funktionaliteten er den samme på tværs af understøttede poster: Du kan trække kort, åbne opgavemenuer og justere tavleindstillinger. De tilgængelige grupperings- og filterfelter varierer afhængigt af, om du arbejder med salg, projekter eller sager.

![Tavlevisning, der viser salg grupperet efter fase -screenshot][img2]

Tavlevisning er i øjeblikket tilgængelig for **udvalg af salg**, og understøttelse af **projekter** og **sager** er planlagt.

## Åbn tavlevisning

1. Gå til et udvalg.
1. Vælg ikonet for **tavlevisning** øverst til højre (<i class="ph ph-kanban" aria-label="Kanban board"></i>).

    ![Tavlevisningsikon øverst til højre i et udvalg][img1]

## Arbejd med kort

* Klik på korttitlen for at åbne hele posten (f.eks. et salgskort).

* Hold musen over et navn eller en virksomhed for at få vist kontaktoplysninger.

    ![Visning af kontaktoplysninger på kort ved hover -screenshot][img3]

* Træk kort mellem kolonner for at opdatere grupperingsfeltet (f.eks. fase eller ejer).
  * Hvis undergrupper er aktiveret, kan du også trække kort mellem swimlanes.

* For at redigere et kort, peg på det og vælg knappen **Rediger** (<i class="ph ph-pencil" aria-hidden="true"></i>). Dette åbner den samme redigeringsdialog som andre steder i SuperOffice CRM – uden at forlade tavlevisningen.

  ![Markør peger på redigeringsknappen på et salgskort -screenshot][img4]

* For flere muligheder, peg på kortet for at vise **Opgave**-menuen <i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>, klik på den og vælg en handling.

  * **Salg:** Rediger, Opret opfølgning, Marker som solgt/tabt, Slet
  * **Projekter:** Rediger, Opret opfølgning, Opret dokument, Marker som fuldført, Slet
  * **Sager:** Rediger, Luk sag, Slet

  ![Åben opgavemenu på salg i tavlevisning med tilgængelige handlinger -screenshot][img5]

<!-- markdownlint-disable-next-line MD013 -->
## Tilpas tavlelayout <i class="ph ph-gear-six" aria-hidden="true"></i> <i class="ph ph-sliders-horizontal" aria-hidden="true"></i>

### Gruppér og undergrupper

Sådan vælger du hvilke kolonner der skal vises:

1. Vælg ikonet **indstillinger** (<i class="ph ph-gear-six" aria-hidden="true"></i>).

1. Vælg **Gruppér efter**.

    ![Tavleindstillinger for salgsudvalg, der viser grupperingsmuligheder -screenshot][img6]

1. Vælg et felt for at definere kolonneopstillingen.

    ![Menuen Gruppér efter med salgsfelter som Fase og Ejer -screenshot][img7]

1. Vælg tilbagepilen (<i class="ph ph-caret-left" aria-hidden="true"></i>) for at vende tilbage til oversigten over indstillinger.

1. Vælg eventuelt en **Undergruppér efter**-værdi for at tilføje swimlanes.

1. Vælg eventuelt **Gem kun kolonner for det aktuelle udvalg** for kun at anvende ændringerne i denne tavlevisning.

1. Vælg **Færdig** for at anvende dine indstillinger.

Eksempler på grupperingsfelter:

* **Salg:** Fase, Salgstype, Ejer
* **Projekter:** Status, Ansvarlig, Type
* **Sager:** Status, Sagstype, Prioritet, Ejer

### Sortér kort i kolonner

Brug indstillingspanelet (<i class="ph ph-gear-six" aria-hidden="true"></i>) til at konfigurere **Sortér efter** og **Sorteringsrækkefølge**, f.eks. efter salgsdato.

### Indstil filtre

1. Vælg <i class="ph ph-sliders-horizontal" aria-label="Toggle filter toolbar"></i> for at vise filter-værktøjslinjen.

    ![Filter-værktøjslinje i tavlevisning af salgsudvalg -screenshot][img9]

1. Sådan vælger du hvilke filtre der er tilgængelige:

    1. Klik på <i class="ph ph-gear-six" aria-hidden="true"></i> for at åbne indstillingerne.
    1. Vælg **Filter-værktøjslinje** og aktiver filtre via afkrydsningsfelterne.
    1. Klik på tilbagepilen (<i class="ph ph-caret-left" aria-hidden="true"></i>) for at vende tilbage og klik derefter på **Færdig**.

    ![Filterindstillinger med tilgængelige salgsfelter som Fase og Ejer -screenshot][img8]

1. Udvid et filter i værktøjslinjen (f.eks. **Ejer**) for at vise en liste med værdier.

    * Vælg eller fravælg værdier for at inkludere dem.
    * Vælg **Ryd** nederst i en rullemenu for at nulstille det filter.
    * Vælg **X** yderst til højre for at nulstille **alle** filtre.

    ![Filter-værktøjslinje, salgstype udvidet -screenshot][img10]

### Opsummer (kun salg)

Du kan vise summer for numeriske felter i tavlevisningen for salg.

1. Vælg <i class="ph ph-gear-six" aria-hidden="true"></i> for at åbne indstillingspanelet.
2. Vælg **Opsummer efter**.
3. Vælg et numerisk felt, f.eks. **Beløb** eller **Vægtet beløb**.

Totalværdien vises **ved siden af hvert kolonnenavn**, hvilket hjælper dig med at se værdifordelingen på tværs af faser, ejere eller andre grupperingsfelter.

![Tavlevisning for salg med summerede værdier ved kolonnenavne -screenshot][img11]

## Anvendelsesmuligheder

Tavlevisning understøtter forskellige roller og arbejdsgange. Her er eksempler for salgsrepræsentanter og salgsledere:

### Salgsrepræsentanter

* **Visualiser dine åbne salg** og følg med i, hvor hver mulighed er i pipelinen.
* **Træk et kort til en anden kolonne** for at opdatere salgsfasen.
* **Filtrer efter salgsdato** for at fokusere på det, der kræver opmærksomhed nu.
* **Åbn opgavemenuen** for at oprette en opfølgning eller markere som solgt/tabt.
* **Rediger et kort hurtigt** for at opdatere oplysninger som ny kontaktperson.

### Salgsledere

* **Visualiser hele pipelinen** og forstå fordelingen af salg mellem faser.
* **Opsummer efter beløb** for at støtte prognoser.
* **Filtrer efter salgstype** for at fokusere på nyt salg eller bestemte kampagnetyper.
* **Gruppér efter ejer** for at se belastning pr. sælger og juster via træk og slip.
* **Brug fase som gruppe og salgstype som undergruppe** for at få et strategisk overblik efter kategori og fase.

Brug gruppering og swimlanes kreativt for effektiv databehandling.

## Fejlfinding og tips

* **Nye salg mangler:** Klik på <i class="ph ph-arrow-clockwise" aria-label="Refresh icon"></i> for at opdatere tavlen og hente seneste data.

* **Filter-værktøjslinje ikke synlig:** Brug ikonet <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> til at vise eller skjule værktøjslinjen.

* **En kolonne er tom:** Dens indhold kan være filtreret fra. Kontrollér aktive filtre i værktøjslinjen.

* **Kan ikke finde et filterfelt:** Gå til **Indstillinger** (<i class="ph ph-gear-six" aria-hidden="true"></i>) > **Filter-værktøjslinje** og aktiver det ønskede felt.

* **Redigere selve udvalget (ikke et medlem)?** Klik på <i class="ph ph-subtract-square" aria-label="Selection icon"></i> for at vende tilbage til udvalgsvisning. Redigerings- og opgaveknapper er ikke tilgængelige i tavlevisning.

* **Søg på tavlen efter navn:** Brug feltet **Filtrer efter titel** øverst til at begrænse synlige kort.

* **Gem layout pr. anvendelse:** Vælg **Gem kun kolonner for det aktuelle udvalg** for at bevare en specifik opsætning for ét udvalg.

## Relateret indhold

* [Opret et udvalg][1]
* [Opret et salg / felter i salgskortet][12]
* [Konfigurér salgsfaser][13]

<!-- Refererede links -->
[1]: create.md
[2]: selections.md
[12]: ../../../sale/learn/create.md
[13]: ../../../sale/admin/sale-stage.md

<!-- Refererede billeder -->
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
