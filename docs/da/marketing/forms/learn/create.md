---
uid: help-da-form-create
title: Opret en ny formular
description: Få mere at vide om, hvordan du kan oprette en webformular, i denne vejledning.
keywords: formular, webformular
author: SuperOffice RnD
date: 03.12.2024
version: 10
topic: howto
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Opret en ny formular

Webformularer gør det lettere at interagere med kunder og potentielle kunder via dit websted eller kundecenteret. Du har tre muligheder: opret et formular fra bunden, opret og brug en brugerdefineret formularskabelon eller vælg en gratis skabelon fra **Online Template Library** i SuperOffice Marketing.

Se denne video for at lære, hvordan du kan oprette en webformular eller følg trinnene nedenfor.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/18m6Dx1t9wI]

(videoens længde - 7:49)

## Opret ny (fra bunden)

1. Gå til fanen **Formularer**.
2. Hvis nødvendigt, klik på **Tilføj mappe** for at [oprette en mappe til formularen][8].
3. Klik på **Formular**-knappen under **Opret ny** på højre side af skærmen.
4. I dialogboksen **Rediger formular** skal du indtaste et beskrivende **Formularnavn**.
5. [Udfyld felterne](#fields) som beskrevet nedenfor. Husk at klikke **Anvend nu** regelmæssigt for at gemme dit arbejde. Formularen gemmes ikke automatisk.
6. Klik på **Gem**, når du er færdig.

![Set properties for new contact me form -screenshot][img15]

## Oprette en ny formular baseret på formularskabelon

1. Vælg fanen **Formularskabeloner**.
2. Klik på **Alle skabeloner**.
3. Klik på <i class="ph ph-list" aria-label="menuknappen"></i> ved siden af den skabelon, du vil bruge.
4. Vælg **Kopier til ny formular**. Skabelonen åbnes i dialogboksen **Rediger formular**.
5. [Aktivere og udgive formularen][2].

## <a id="multi-page"></a>Oprette formularer med flere sider

For at øge brugervenligheden og lette læsbarheden kan du overveje at opdele en formular med mange felter i flere sider. Brugere kan navigere gennem formularen ved hjælp af **Næste**- og **Forrige**-knapper, og en fremskridtslinje kan tilføjes for at angive de resterende felter.

1. Opret en formular som beskrevet ovenfor.
2. Vælg **Felter** fra venstremenuen (i dialogboksen).
3. Klik på knappen **Tilføj** (<i class="ph ph-plus" aria-hidden="true"></i>).
4. I vinduet **Tilføj element** vælger du **Vis elementer**.
5. Vælg **Sektion**, og klik på **Tilføj**. Vinduet lukkes, og der føjes en sektion til formularen. Du kan også se sektionen i formulareksemplet.
6. Klik på ![ikon][img3] øverst i sektionen, og træk det til den ønskede placering i formularen. Felterne over og under sektionen vil være på to separate sider i formularen.
7. Klik på **Brug nu**, når du er færdig.
8. Gentag trin 2-7 for at tilføje en anden sektion.

> [!TIP]
> Du kan føje en statuslinje til formularen, så brugeren kan se, hvor meget der er tilbage at udfylde. Gå til kategorien **Stil,** klik på afkrydsningsfeltet ud for **Statuslinjefarve**, og vælg en farve.

## <a id="fields"></a>Udfyldning af formularfelter

[!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

### Egenskaber

* **Mappe**: Vælg, hvor formularen skal placeres, eller [opret en ny mappe][8].

* **Beskrivelse**: Forklar formålet med denne formular. Denne tekst vises kun internt.

* **Sprog**: Vælg det sprog, der bruges i formularen.

* **Vedligeholdt af**: Valgfrit. Vælg en brugergruppe for at begrænse adgangen til denne formular. Kun medlemmer af den valgte brugergruppe kan behandle indsendelser fra denne formular og modtage underretninger om indsendelser.

* **Deaktiver formular automatisk**: Valgfrit. I nogle tilfælde bør formularen kun være aktiv indtil en bestemt dato, eller indtil et bestemt antal svar er modtaget. Personer, der prøver at tilgå en inaktiv formular, vil blive omdirigeret til siden for inaktiv formular. Du kan kombinere disse alternativer.

  * **Indtil**: Vælg en dato. Formularen deaktiveres på denne dato.
  * **Maks.**: Indtast antallet af svar. Formularen bliver deaktiveret, efter at det angivne antal svar er blevet modtaget.

* **Brug Google Analytics**: Vælg denne valgmulighed for at spore formularen og knytte den til [Google Analytics][1] (hvis denne er sat op til dit websted). I feltet under denne valgmulighed kan du angive Google Analytics-sporings-id'et for denne formular.

### Tilføj felter til formularen

I kategorien **Felter** kan du tilføje de felter, der skal medtages i formularen. Efterhånden som du tilføjer og redigerer felter, opdateres forhåndsvisningen automatisk.

1. Vælg **Felter** fra venstremenuen. Som standard føjes feltet **Person - navn** og knappen **OK** til den nye formular.

2. Klik på knappen **Tilføj** (<i class="ph ph-plus" aria-hidden="true"></i>).

3. Vælg en af de følgende feltkategorier i vinduet **Tilføj element**:

    * **SuperOffice-elementer**: Felter, der er knyttet til SuperOffice data, som f.eks. personnavn, land, e-mailadresse osv. Afhængig af felttypen kan værdier fra indsendte formularer enten erstatte eksisterende værdier (f. eks. land eller titel) eller føjes til det relevante SuperOffice-felt (f.eks. mobiltelefon).

    * **Formularelementer**: Felter til indtastning af tekst eller dato, felter til valg af værdier (lister, afkrydsningsfelter og alternativknapper) og filupload-felter.

    * **Visningselementer**: Sektioner, tekster og billeder. Brug sektioner til at [oprette formularer](#multi-page) med flere sider.

4. Vælg et felt på listen.

5. Klik på **Tilføj**. Vinduet lukkes, og feltet føjes til formularen og dens forhåndsvisning.

6. Klik på ![ikon][img3] øverst i feltet, og træk det til den ønskede placering i formularen.

7. Vælg feltet, og rediger feltnavne, hvis det er relevant. Det oprindelige feltnavn vises altid i øverste højre hjørne af feltet.

8. Du kan også redigere disse indstillinger (valgfrit):

    * I feltet **Pladsholder** skal du indtaste en kort hjælp til, hvad der skal indtastes i feltet.

    * Marker det **obligatoriske** afkrydsningsfelt, hvis dette felt skal udfyldes. Formularen kan ikke sendes, hvis obligatoriske felter ikke er udfyldt.

    * Klik på **Avancerede indstillinger** (<i class="ph ph-gear" aria-hidden="true"></i>) for at vise feltet **Identifikator**, hvor du kan tilføje et ID i feltet. Det bliver til et entydigt ID for dette felt og ændres ikke, feltnavnet/-etiketten eller sproget ændres. På den måde kan du sikre, at links til dette felt ikke brydes efter udgivelse af formularen.

    * Klik på afkrydsningsfeltet **Fuld bredde,** hvis det markerede felt skal have samme bredde som formularen.

9. Rediger eventuelle andre [indstillinger i feltet][4] efter behov.

10. Klik på **Brug nu**, når du er færdig.

11. Gentag trin 2-10 for at tilføje et andet felt. Du kan også klikke på **Dubler felt** (<i class="ph ph-copy" aria-hidden="true"></i>) for at oprette en kopi af et felt.

### Stil

Vælg **Stil** fra venstremenuen for at definere formens udseende. For eksempel, antal kolonner, placeringen af feltnavne, kanter, baggrund, skriftfarve/størrelse og formularstørrelse.

Forhåndsvisningen til højre opdateres automatisk, når du ændrer indstillinger. Hvis du ikke angiver formularens højde og bredde, tilpasses formularen automatisk efter skærmstørrelsen (stationær computer, tablet eller mobil).

> [!TIP]
> Du kan føje en statuslinje til formularen, så brugeren kan se, hvor meget der er tilbage at udfylde. Klik på afkrydsningsfeltet ud for **Statuslinjefarve**, og vælg en farve. Statuslinjen vises nederst i formularen. Se også [Oprette formularer med flere sider](#multi-page).

### Aktivere dobbelt tilsagn (valgfrit)

Dobbelt tilsagn (opt-in) er et ekstra trin i formularindsendelsesprocessen, der garanterer, at folk indsender den korrekte e-mailadresse.

Se denne video for at lære, hvordan du bruger dobbelt tilsagnsfunktionen (videolængde - 3:45), eller følg nedenstående fremgangsmåde.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/o7mkk3n7zuw]

**Trin:**

1. Klik på **Aktiver dobbelt tilsagn**.

2. I fanen **Meddelelse** kan du angive den tekst, der skal vises, efter at formularen er blevet indsendt.

3. I fanen **E-mail** skal du oprette den bekræftelses-e-mail, der sendes til personer, der indsender formularen.

    1. **Emne**: Indtast emnet for bekræftelses-e-mailen.

    2. **Afsenderadresse**: Indtast e-mailadressen, der skal vises i feltet **Fra** i bekræftelses-e-mailen.

    3. **Bekræftelsestekst**: Indtast e-mailens brødtekst.

    4. Vælg **Indsæt bekræftelseslink** (<i class="ph ph-arrow-square-out" aria-hidden="true"></i>) fra værktøjslinjen (klik <i class="ph ph-text-a-underline" aria-label="Show toolbar"></i> for at vise). Bekræftelseslinket indsættes i brødteksten. Hvis du vil redigere, klikker du på linket og vælger **Rediger link** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>).

4. Klik på **Brug nu**, når du er færdig.

Hvis dobbelt tilsagn er aktiveret for en formular, får alle indsendelser af denne formular status **Afventer bekræftelse**, indtil e-mailadressen er blevet bekræftet.

> [!NOTE]
> Husk at tilføje feltet **Person - e-mail** i kategorien **Felter**.

### Tak-side

Når en person har udfyldt og indsendt en formular, bør du takke vedkommende og oplyse om det næste, der skal ske. Det er altid rart at sige tak. Folk sætter virkelig pris på det.

Brug "Tak"-siden til at promovere andre produkter eller begivenheder og link til relevante dele af dit websted. Dette forbedrer brugeroplevelsen og fremmer kundeloyalitet.

Se denne video for at lære, hvordan du føjer en "Tak"-side til din webformular, eller følg nedenstående fremgangsmåde.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/xaVXR-Ltfuo]

(videolængde - 1:48)

Vælg et af følgende alternativer:

* **Omdiriger til eksternt websted**: Indtast linket til websiden med flere oplysninger.
* **Vis denne meddelelse**: Indtast den tekst, der skal vises.

### Side for inaktiv formular

Hvis en person åbner en formular, som er inaktiv, kan du enten omdirigere til en anden webside eller vise en meddelelse.

* **Omdiriger til eksternt websted**: Indtast linket til websiden.
* **Vis denne meddelelse**: Indtast den tekst, der skal vises.

### Handlinger

Her kan du [definere, hvad der sker, når nogen sender et svar på formularen][3].

* Giv besked om indsendelser ved at oprette sager
* Hvordan skal en formularindsendelse behandles?
* Hvad skal der ske, når formularen behandles?

## Relateret indhold

* [Udgiv formularer][2]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/ga-tutorial.md
[2]: publish.md
[3]: define-form-actions.md
[4]: field-options.md
[8]: ../../learn/create-folder.md

<!-- Referenced images -->
[img3]: ../../../../media/icons/marketing-and-forms/move-field.png
[img15]: ../../../../media/loc/en/marketing/contact-me-form-properties.png
