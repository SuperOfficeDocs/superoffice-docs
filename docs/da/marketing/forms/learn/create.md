---
uid: help-da-form-create
title: Opret en ny formular
description: "Få mere at vide om, hvordan du kan oprette en webformular, i denne vejledning."
author: SuperOffice RnD
so.date: 02.21.2023
keywords: formular, tilvalg
so.topic: howto
language: da
---

# Opret en ny formular

Webformularer gør det lettere at interagere med kunder og potentielle kunder via dit websted eller kundecenteret.

Du kan enten oprette din egen formular fra bunden, bruge en skabelon fra formularskabelonerne eller vælge en fra vores online skabelonbibliotek.

Se denne video for at lære, hvordan du opretter en webformular (videolængde - 7:49), eller følg nedenstående fremgangsmåde.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/18m6Dx1t9wI]

## Opret ny

1. Gå til fanen **Formularer**.
2. Klik eventuelt på **Tilføj mappe** for at [oprette en mappe til skabelonen eller formularen][8].
3. Vælg **Form** under **Opret ny** i højre side af skærmen. Skærmbilledet **Rediger formular** vises.
4. Angiv et beskrivende navn på skabelonen i feltet **Formularnavn**.
5. Udfyld felterne som beskrevet nedenfor.
6. Husk at klikke regelmæssigt på **Anvend nu** for at gemme dit arbejde. Formularen gemmes ikke automatisk.
7. Klik på **Gem**, når du er færdig.

## Vil du oprette en ny formular baseret på en formularskabelon?

1. Vælg fanen **Formularskabeloner**.
2. Klik på **Alle skabeloner**.
3. Klik på ![ikon][img1] menuknappen ved siden af den skabelon, du vil bruge.
4. Vælg **Kopier til ny formular**. Skabelonen åbnes i dialogboksen **Rediger formular** .
5. [Aktivere og udgive formularen][2].

## <a id="multi-page" />Oprette formularer med flere sider

Hvis du opretter en formular med mange felter, kan det være nyttigt at opdele formularen i flere sider. Dette vil gøre formularen mere brugervenlig og lettere at læse. Brugeren kan navigere ved hjælp af knapperne **Næste** og **Forrige**, og du kan også tilføje en statuslinje for at angive, hvor meget der er tilbage at udfylde.

1. Opret en formular som beskrevet ovenfor.
2. Gå til kategorien **Felter**.
3. Klik på knappen **Tilføj** (![ikon][img2]).
4. I vinduet **Tilføj element** vælger du **Vis elementer**.
5. Vælg **Sektion ,** og klik på **Tilføj**. Vinduet lukkes, og der føjes en sektion til formularen. Du kan også se sektionen i formulareksemplet.
6. Klik på ![ikon][img3] øverst i sektionen, og træk det til den ønskede placering i formularen. Felterne over og under sektionen vil være på to separate sider i formularen.
7. Klik på **Brug nu**, når du er færdig.
8. Gentag trin 2-7 for at tilføje en anden sektion.

> [!TIP]
> Du kan føje en statuslinje til formularen, så brugeren kan se, hvor meget der er tilbage at udfylde. Gå til kategorien **Stil,** klik på afkrydsningsfeltet ud for **Statuslinjefarve**, og vælg en farve.

## Udfyldning af formularfelter

Klik på overskrifterne for at få mere at vide om, hvordan du udfylder felterne i de forskellige kategorier:

### Egenskaber

Udfyld følgende oplysninger i kategorien **Egenskaber**:

* **Mappe**: Vælg, hvor formularen skal placeres, eller [opret en ny mappe][8].

* **Beskrivelse**: Forklar formålet med denne formular. Denne tekst vises kun internt.

* **Sprog**: Vælg det sprog, der bruges i formularen.

* **Vedligeholdt af**: Valgfrit. Vælg en brugergruppe for at begrænse adgangen til denne formular. Kun medlemmer af den valgte brugergruppe kan behandle indsendelser fra denne formular og modtage underretninger om indsendelser.

* **Deaktiver formular automatisk**: Valgfrit. I nogle tilfælde bør formularen kun være aktiv indtil en bestemt dato, eller indtil et bestemt antal svar er modtaget. Personer, der prøver at tilgå en inaktiv formular, vil blive omdirigeret til siden for inaktiv formular. Du kan kombinere disse alternativer.

  * **Indtil**: Vælg en dato. Formularen deaktiveres på denne dato.
  * **Maks.**: Indtast antallet af svar. Formularen bliver deaktiveret, efter at det angivne antal svar er blevet modtaget.

* **Brug Google Analytics**: Vælg denne valgmulighed for at spore formularen og knytte den til[Google Analytics][1] (hvis denne er sat op til dit websted). I feltet under denne valgmulighed kan du angive Google Analytics-sporings-id'et for denne formular.

### Tilføj felter til formularen

I kategorien **Felter** kan du tilføje de felter, der skal medtages i formularen. Efterhånden som du tilføjer og redigerer felter, opdateres forhåndsvisningen automatisk.

1. Gå til kategorien **Felter**. Som standard føjes feltet **Person - navn** og knappen **OK** til den nye formular.

2. Klik på knappen **Tilføj** ![ikon][img2].

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
    * Klik på **Avancerede indstillinger** ![ikon][img5] for at vise feltet **Identifikator**, hvor du kan tilføje et ID i feltet. Det bliver til et entydigt ID for dette felt og ændres ikke, feltnavnet/-etiketten eller sproget ændres. På den måde kan du sikre, at links til dette felt ikke brydes efter udgivelse af formularen.
    * Klik på afkrydsningsfeltet **Fuld bredde,** hvis det markerede felt skal have samme bredde som formularen.

9. Rediger eventuelle andre [indstillinger i feltet][4] efter behov.

10. Klik på **Brug nu**, når du er færdig.

11. Gentag trin 2-10 for at tilføje et andet felt. Du kan også klikke på **Dubler felt** ![ikon][img6] for at oprette en kopi af et felt.

### Stil

I kategorien **Stil** kan du definere formularens udseende. Du kan blandt andet angive antal kolonner, placeringen af feltnavne, kanter, baggrund, skriftfarve/størrelse og formularstørrelse.

Forhåndsvisningen til højre opdateres automatisk, når du ændrer indstillinger. Hvis du ikke angiver formularens højde og bredde, tilpasses formularen automatisk efter skærmstørrelsen (stationær computer, tablet eller mobil).

> [!TIP]
> Du kan føje en statuslinje til formularen, så brugeren kan se, hvor meget der er tilbage at udfylde. Klik på afkrydsningsfeltet ud for **Statuslinjefarve**, og vælg en farve. Statuslinjen vises nederst i formularen. Se også [Oprette formularer med flere sider](#multi-page).

### Sådan aktiveres dobbelt tilsagn

Dobbelt tilsagn er et ekstra trin i formularindsendelsesprocessen, hvor en person skal bekræfte deres e-mail-adresse for at fuldføre deres formularindsendelse. De modtager en e-mail med et link, som man skal klikke på for at bekræfte, at e-mailadressen er korrekt.

> [!NOTE]
> Linket er som standard gyldigt i 30 minutter.

Brug af dobbelt tilsagnsfunktion garanterer, at folk indsender den rigtige e-mail-adresse. Det betyder, at din mailingliste bliver mere pålidelig, hvilket vil hjælpe med at hæve åbningsraterne for dine forsendelser. Som en ekstra bonus behøver du ikke bruge tid på at rette stavefejl i e-mail-adresser eller slette e-mail-adresser, der ikke findes. Og det vil også hjælpe dig i din indsats for at forblive GDPR-kompatibel.

Se denne video for at lære, hvordan du bruger dobbelt tilsagnsfunktionen (videolængde - 3:45), eller følg nedenstående fremgangsmåde.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/o7mkk3n7zuw]

**Trin:**

1. Klik på **Aktiver dobbelt tilsagn**.
2. I fanen **Meddelelse** kan du angive den tekst, der skal vises, efter at formularen er blevet indsendt. Klik på **Vis/skjul værktøjslinje** ![ikon][img7] for at få vist formateringsindstillingerne for teksten.
3. I fanen **E-mail** skal du oprette den bekræftelses-e-mail, der sendes til personer, der indsender formularen.
    1. **Emne**: Indtast emnet for bekræftelses-e-mailen.
    2. **Afsenderadresse**: Indtast e-mailadressen, der skal vises i feltet **Fra** i bekræftelses-e-mailen.
    3. **Bekræftelsestekst**: Indtast e-mailens brødtekst. Klik på **Vis/skjul værktøjslinje** ![ikon][img7] for at få vist formateringsindstillingerne for teksten. Klik på **Åbn teksteditor i dialogboks** ![ikon][img8] for at redigere teksten i et større redigeringsprogram.
    4. Klik på **Vis/skjul værktøjslinje** ![ikon][img7], og klik derefter på **Indsæt bekræftelseslink** ![ikon][img9].. Bekræftelseslinket indsættes i brødteksten. Klik på linket for at bekræfte linket, og vælg **Rediger link** ![ikon][img10].
4. Klik på **Brug nu**, når du er færdig.

Hvis dobbelt tilsagn er aktiveret for en formular, får alle [indsendelser af denne formular][5] status **Afventer bekræftelse**, indtil e-mailadressen er blevet bekræftet.

> [!NOTE]
> Husk at tilføje feltet **Person - e-mail** i kategorien **Felter**.

### Tak-side

Når en person har udfyldt og indsendt en formular, bør du takke vedkommende og oplyse om det næste, der skal ske. Det er altid rart at sige tak. Folk sætter virkelig pris på det.

Ud over at sige tak, kan du bruge denne side til at informere dine besøgende om andre produkter eller begivenheder. Du skal blot tilføje din inspirerende kopi til siden og linke den til bestemte steder på dit websted. På denne måde kan kunden fortsætte med at udforske dit websted, efter at de har indsendt deres oplysninger.

Effekten vil være opløftende – en "Tak"-side vil både løfte deres kundeoplevelse og øge din kundeloyalitet.

Se denne video for at lære, hvordan du føjer en "Tak"-side til din webformular (videolængde - 1:48), eller følg nedenstående fremgangsmåde.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/xaVXR-Ltfuo]

Vælg et af følgende alternativer:

* **Omdiriger til eksternt websted**: Indtast linket til websiden med flere oplysninger.
* **Vis denne meddelelse**: Indtast den tekst, der skal vises.
  * Klik på **Vis/skjul værktøjslinje** ![ikon][img7] for at få vist formateringsindstillingerne for teksten.
  * Klik på **Åbn teksteditor i dialogboks** ![ikon][img8] for at redigere teksten i et større redigeringsprogram.

### Side for inaktiv formular

Hvis en person åbner en formular, som er inaktiv, kan du enten omdirigere til en anden webside eller vise en meddelelse.

* **Omdiriger til eksternt websted**: Indtast linket til websiden.
* **Vis denne meddelelse**: Indtast den tekst, der skal vises. Klik på **Vis/skjul værktøjslinje** ![ikon][img7] for at få vist formateringsindstillingerne for teksten. Klik på **Åbn teksteditor i dialogboks** ![ikon][img8] for at redigere teksten i et større redigeringsprogram.

### Handlinger

Her kan du definere, hvordan en indsendt formular skal behandles. Udfyld de følgende felter:

**Giv besked om indsendelser ved at oprette sager**: Vælg denne valgmulighed for at oprette en sag for hver formular, der indsendes. Indtast en titel, og vælg kategori og prioritet for sagen. Indsendte formularer vil være tilgængelige under **Sager** i SuperOffice Service og under fanen **Sag** på skærmbillederne Firma og Person i SuperOffice CRM.

**Hvordan skal en formularindsendelse behandles?** Her kan du definere, om de indsendte formularer skal behandles automatisk.

* **Behandl alle indsendelser automatisk. Opret ny person, hvis der ikke blev funden et match**: Alle formularindsendelser behandles automatisk. Der vil ikke være nogen meddelelser om indsendte formularer.
* **Manuelt, hvis indsenderen er ukendt. Automatisk, hvis indsenderen er kendt**: Hvis e-mailadressen, der indsendes i formularen matcher en e-mailadresse i SuperOffice, behandles den indsendte formular automatisk. Ellers skal den behandles manuelt. Du modtager en meddelelse (![ikon][img11]). Se [Behandling af formularindsendelser][6].
* **Manuelt for alle indsendelser**: Du modtager en meddelelse (![ikon][img11]) for hver indsendt formular. Se [Behandle formularindsendelser][6] for oplysninger om, hvordan formularindsendelser behandles.

**Hvad skal der ske, når formularen behandles?** Her kan du vælge handlinger, der skal udføres, når en formular behandles (automatisk eller manuelt):

* **Tilføj person til udvalg**: Hvis du har valgt automatisk behandling ovenfor, skal du tilføje et udvalg her til at spore personer, der tilføjes via denne formular. Det vil også gøre det nemmere at fjerne irrelevante personer (og firmaer).
* **Tilføj person til projekt**: Vælg et projekt. Personer, der indsender denne formular, føjes til dette projekt.
* **Tilføj interesser til person**: Vælg en interesse. Denne interesse vil blive føjet til personer, der indsender denne formular.
* **E-mail-svar**: Vælg et formularsvar, der skal sendes til personer, når deres formular behandles. [Sådan oprettes et formularsvar][7].
* **Opret sag**: Hvis du har tilføjet et sagsfelt i kategorien **Felter**, skal du også vælge en standardkategori og prioritet for de sager, der oprettes via denne formular. Indsendte formularer vil være tilgængelige under **Sager** i SuperOffice Service og under fanen **Sag** på skærmbillederne Firma og Person i SuperOffice CRM.
* **Udfør CRMScript**: Vælg et script eller en makro, der skal køres, når en formularindsendelse behandles. Se [CRMScript][9].
* **Standardkategori** / **Standardvirksomhed**: Vælg en standardkategori og -virksomhed for alle personer eller firmaer, der føjes til SuperOffice baseret på sendte formularer. Med denne mulighed kan du gruppere formularafsendelser og nye kontakter/virksomheder til en bestemt kategori og/eller virksomhed.
    Hvis du f.eks. har en formular til kundeemner, skal du vælge kundeemner som din kategori. Du kan derefter nemt oprette valg baseret på denne kategori og/eller virksomhed.

## Hvad vil du foretage dig nu?

* [Udgiv formularer][2]

<!-- Referenced links -->
[1]: ../../tracked-links/learn/ga-tutorial.md
[2]: publish.md
[4]: field-options.md
[5]: submissions/index.md
[6]: submissions/process.md
[7]: ../../mailing/learn/create/tutorial-form-mailing.yml
[8]: ../../learn/create-folder.md
[9]: ../../../automation/crmscript/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/btn-menu.png
[img2]: ../../../../media/icons/marketing-and-forms/add-field.png
[img3]: ../../../../media/icons/marketing-and-forms/move-field.png
[img5]: ../../../../../common/icons/cog-wheel.png
[img6]: ../../../../../common/icons/duplicate-icon.png
[img7]: ../../../../media/icons/marketing-and-forms/toolbar-show-hide.png
[img8]: ../../../../../common/icons/pop-out-icon.png
[img9]: ../../../../../common/icons/new-window-icon.png
[img10]: ../../../../../common/icons/edit-black.png
[img11]: ../../../../media/icons/marketing-and-forms/form-notification.png
