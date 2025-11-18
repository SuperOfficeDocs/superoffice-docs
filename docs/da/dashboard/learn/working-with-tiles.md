---
uid: help-da-dashboard-tiles
title: Arbejde med ruder
description: Lær hvordan du tilføjer, tilpasser og administrerer ruder i dine SuperOffice dashboards.
keywords: tilføj rude, rediger rude, kopier rude, dupliker rude, fjern rude, tilpas rude, datasæt, dashboard, rude
author: digitaldiina
date: 11.21.2025
version: 11.6
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from:
  - /da/dashboard/learn/add-tile
  - /da/dashboard/learn/edit-tile
  - /da/dashboard/learn/remove-tile
---

# Arbejde med ruder

Lær hvordan du tilføjer, tilpasser og administrerer ruder i dine SuperOffice dashboards. Ruder er visuelle oversigter baseret på CRM-data – ideelle til at holde styr på sager, salg, aktiviteter eller markedsføringsresultater.

Du kan bruge foruddefinerede ruder eller oprette dine egne.

## Forudsætning: skift til layouttilstand

For at administrere ruder skal du først gå til layouttilstand:

1. Åbn det dashboard, du vil tilpasse.

1. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> i dashboardets sidehoved, og vælg **Rediger dashboardruder**.

    Dashboardet skifter til layouttilstand:
    * Sidepanelet **Rediger dashboardruder** vises til højre.
    * Hver rude viser et redigeringsikon (<i class="ph ph-pencil" aria-hidden="true"></i>).
    * Du kan tilføje, flytte, ændre størrelse på eller redigere ruder.

## <a id="add"></a>Tilføj en rude

1. I sidepanelet **Rediger dashboardruder** skal du vælge datatypen (f.eks. firma, salg eller sag) fra listen **Vis ruder for**.

    ![Sidepanel til redigering af dashboardruder -screenshot][img1]

1. Vælg en rude fra fanen **Bibliotek** (foruddefinerede ruder) eller **Udvalg** (ruder baseret på dine egne dynamiske udvalg).

    * Brug **søgefeltet** til hurtigt at finde ruder.
    * Hver rude har et ikon, der viser rudetypen – f.eks. diagram, liste eller stort tal.

1. Tilføj ruden til dashboardet:
    * **Træk og slip** ruden til en ledig plads.
    * Eller klik på <i class="ph ph-plus" aria-label="+"></i>, som vises, når du holder musen over rudens navn.

    Ruden tilpasser sig automatisk til den tilgængelige plads og justeres med layoutet.

1. Ændr størrelse på eller flyt ruderne efter behov.

1. Klik på **Udført** for at afslutte layouttilstanden.

### Opret en rude fra bunden

1. Vælg **Tom rude** for den datatype, du vil visualisere.
1. Tilføj ruden til dashboardet.
1. I dialogen **Rediger rude** skal du angive et beskrivende navn.
1. Gå til fanen **Datasæt**, og [definér kriterierne][4], som bestemmer hvilke data ruden skal vise.

    ![Dialog til redigering af rude, fanen Datasæt -screenshot][img2]

    Denne fane fungerer som [søgeskærmbilledet][5]. Brug den til at tilføje filtre som ejer, datointerval eller kategori.

1. Gå til fanen **Layout** for at konfigurere rudens udseende. Vælg [diagramtype][3], etiketter, sortering og andre formateringsmuligheder.

    ![Dialog til redigering af rude, fanen Layout -screenshot][img3]

1. Klik på **Gem**, og derefter på **Udført** for at afslutte layouttilstanden.

### <a id="selection-chart"></a>Om udvalg-baserede ruder

Når du tilføjer en rude fra fanen **Udvalg**, opretter du ikke en live-kobling til udvalget. I stedet kopieres det aktuelle datasæt og layout fra [diagrammet, der er defineret i udvalget][6]. Derefter fungerer ruden og udvalget uafhængigt af hinanden.

Fanen **Udvalg** viser kun:

* Dynamiske udvalg
* Udvalg, der matcher den type, du har valgt i **Vis ruder for**
* Udvalg, der har et gemt diagram under fanen **Diagram**

Hvis et udvalg mangler på listen, skal du kontrollere:

* Er det et statisk udvalg? Statisk udvalg understøttes ikke her.
* Matcher posttypen (firma, salg osv.) den valgte type?
* Er der defineret og gemt et diagram på fanen **Diagram**?

Efter du har tilføjet ruden:

* Ændringer i **kriterier** eller **diagram** i udvalget påvirker **ikke** ruden.
* Ændringer i **datasættet** eller **layoutet** i ruden påvirker **ikke** udvalget.
* **Ruden holdes ikke synkroniseret** med udvalget, men opdateres stadig dynamisk baseret på sit eget datasæt.

Hvis du vil have ruden til at afspejle ændringer i et udvalg, skal du enten opdatere ruden manuelt eller fjerne og tilføje den igen fra det opdaterede udvalg.

### Tilføj en webpanel-rude

Brug denne rude til at integrere en webside i dashboardet:

1. Sæt **Vis ruder for** til **Andet**.
1. Gå til fanen **Bibliotek**, og vælg **Webpanel**.
1. Indtast den URL, du vil vise.
1. Hvis URL'en bruger HTTP (ikke HTTPS), skal du aktivere **Tillad usikker adresse**.
1. Klik på **Gem**, og derefter på **Udført** for at afslutte layouttilstanden.

### Tilføj en HTML-rude

Brug denne rude til at vise formateret tekst i dashboardet. Det kan for eksempel være en velkomstbesked, forklaring eller intern note.

1. Sæt **Vis ruder for** til **Andet**.
1. Gå til fanen **Bibliotek**, og vælg **HTML**.
1. Klik på **Tilføj** for at vælge mindst ét sprog til indholdet.
1. Brug den indbyggede editor til at indtaste og formatere dit indhold.

    Du har adgang til de samme formateringsmuligheder som i Chat og Formularer. Tilføj indhold på flere sprog for at sikre, at ruden vises korrekt for alle brugere.

1. Klik på **Gem**, og derefter på **Udført** for at afslutte layouttilstanden.

## <a id="edit"></a>Rediger en rude

1. Når du er i layouttilstand, skal du klikke på **Rediger**-ikonet (<i class="ph ph-pencil" aria-hidden="true"></i>) på ruden.
1. I fanen **Datasæt** kan du justere kriterierne efter behov.
1. I fanen **Layout** vælger du diagramtype og visuelle indstillinger.
1. Opdater rudens navn, så det afspejler de nye data eller layoutændringer.
1. Klik på <i class="ph ph-translate" aria-label="Translate"></i> for at [tilføje en oversættelse][7] af rudens titel og etiketter.
1. Klik på **Gem**.

## <a id="copy"></a>Duplikér eller kopier en rude

Du kan genbruge en eksisterende rude ved enten at duplikere den i samme dashboard eller kopiere den til et andet dashboard. Du skal have **redigeringstilladelse til måldashboardet** for at kunne kopiere en rude til det.

1. Klik på <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> på ruden, og vælg duplikér- eller kopieringsindstillingen.

| Indstilling | Hvad den gør | Næste trin | Anvendelse |
|---|---|---|---|
| **Duplikér rude** | Opretter en kopi af ruden i det aktuelle dashboard. Navnet opdateres (f.eks. *Rudenavn2*). | Rediger typisk den duplikerede rude: ændr navnet, opdater datasæt eller layout. | Vis samme type data med et andet layout, eller vis lignende data med samme layout. |
| **Kopiér rude til dashboard** | Tilføjer ruden til et andet dashboard. Vælg et måldashboard fra listen. Hold musen over dashboardnavnet for at få vist en forhåndsvisning af dets nuværende ruder. | Åbn eventuelt måldashboardet. Rediger ruden der, hvis nødvendigt. | Genbrug en nyttig rude, du fandt i en kollegas dashboard. Tilføj den til et af dine egne dashboards. |

**Kopiér til dashboard** er også tilgængelig uden for layouttilstand (almindelig visning af dashboardet).

## <a id="move"></a>Flyt eller ændr størrelsen på ruder

Når du er i layouttilstand:

* **Træk ruden i overskriften** for at flytte den til en ny placering.
* **Ændr størrelsen på ruden** ved at trække i bunden, højre side eller nederste højre hjørne.

Ruderne tilpasses automatisk dashboardets gitterlayout.

Hvis du vil ændre antallet af kolonner, skal du afslutte layouttilstanden og redigere dashboarddetaljerne.

## <a id="remove"></a>Fjern en rude

Du kan fjerne ruder fra et dashboard, så længe du har redigeringstilladelse.

1. Når du er i layouttilstand, skal du klikke på <i class="ph ph-dots-three-vertical" aria-label="Tile task menu"></i> på ruden.
1. Vælg **Fjern rude**.
1. Bekræft sletningen.

> [!CAUTION]
> Brugerdefinerede ruder, som HTML, webpanel og ruder baseret på udvalg, slettes permanent, når de fjernes. Kun foruddefinerede ruder fra biblioteket kan sikkert tilføjes igen senere.

## <a id="export"></a>Eksportér ruder

### Download eller udskriv ruderapporten

Klik på <i class="ph ph-dots-three-vertical" aria-label="Task menu"></i> i rudens sidehoved for at få adgang til følgende indstillinger:

* **Download PDF-dokument** / **Download PNG-dokument**: Download ruden som PDF- eller PNG-fil. Eksportfilerne downloades til din browser (**Overførsler**-mappen).

    For andre formater (**SVG, CSV og XLS**) skal du vælge **Vis i fuld skærm** i menuen.

* **Udskriv**: Åbn ruden i udskriftsdialogboksen.

> [!TIP]
> Hvis du vil skjule bestemte data før eksport eller udskrivning, kan du klikke på dataetiketterne (forklaring) ved siden af eller under ruden for at skjule data.

### Eksportér ALLE rækker i et datasæt til Excel

1. Klik på et datapunkt i ruden for at se de underliggende data.

    Et nyt vindue åbnes med de relaterede poster.

1. Klik på <i class="ph ph-download-simple" aria-label="Download"></i> **Eksportér** under listen.

1. Klik på **Ja** for at bekræfte.

    Denne handling kan tage lidt tid. Du kan fortsætte med at arbejde i SuperOffice, mens du venter. Du får besked, når eksporten er fuldført.

## Tips

* **Skjul valutaetiketter:** Hvis du vil spare plads i ruder, der viser beløb, skal du vælge **Skjul** under **Valuta** i fanen Layout.

* **Sammenlign med mål:** I dashboards for salg kan du aktivere **Sammenlign med mål** i fanen Layout for at visualisere fremdrift mod salgsbudgettet. Denne mulighed afhænger af diagramtype og datasæt.

* **Brug korte talformater:** For ruder med store værdier kan du aktivere **Kort talformat** for at vise tal i millioner (f.eks. *1,2M*).

* **Store tal-ruder:** Brug disse til nøglemålinger som omsætning eller åbne sager. Hold rudens navn kort, så tallet fremhæves tydeligt.

* **Vis varighed i opfølgningsruder:** Når du bruger opfølgningsruder, kan du sætte **Måleenhed** til **Varighed** for at spore tidsforbrug mere effektivt.

## Fejlfinding

* **Jeg kan ikke se redigeringsikonet på ruden**
  * Er dashboardet i layouttilstand?

* **Jeg kan ikke finde den ønskede indstilling i Opgave-menuen**
  * Har du klikket på den korrekte Opgave-knap? (dashboard vs. rude)
  * Er dashboardet i layouttilstand?

* **Jeg har ikke adgang til fanen Layout eller felterne**
  * Du har muligvis ikke de nødvendige funktionelle rettigheder. Kontakt din administrator.

* **Et udvalg mangler i fanen Udvalg**
  * Se [Om ruder baseret på udvalg](#selection-chart)

* **Jeg kom til at fjerne en brugerdefineret rude**
  * Disse ruder kan ikke gendannes. For at undgå dette kan du kopiere dem til et privat dashboard (f.eks. "Arkiverede ruder") inden du sletter dem.

## Relateret indhold

* [Tilføj et nyt dashboard][1]
* [Brug dashboards til at administrere din salgspipeline][2]

<!-- Referenced links -->
[1]: create.md
[2]: show-sales-targets.md
[3]: index.md#charts
[4]: ../../search-options/learn/search-criteria.md
[5]: ../../search-options/learn/find-screen.md
[6]: ../../search-options/selection/learn/howto/display-as-charts.md
[7]: ../../localization/learn/translate-fields.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/dashboard/edit-dashboard-tiles-sidebar.png
[img2]: ../../../media/loc/en/dashboard/edit-tile-dataset.png
[img3]: ../../../media/loc/en/dashboard/edit-tile-layout.png
