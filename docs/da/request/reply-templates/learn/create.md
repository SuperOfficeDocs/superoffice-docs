---
uid: help-da-reply-template-create
title: Oprettelse af svarskabeloner
description: "Få mere at vide om, hvordan du opretter en svarskabelon, i denne vejledning."
author: Bergfrid Dias
so.date: 03.16.2023
keywords: sag, svar, skabelon
so.topic: howto
so.audience: person
so.audience.tooltip: SuperOffice Service
language: da
---

# Opret svarskabelon

En svarskabelon er en færdig tekst, som kan indsættes i en meddelelse, som du skriver til en person. Brug af svarskabeloner sparer tid og giver dig mulighed for at sende personlige beskeder til dine personer.

Svarskabeloner kan også indeholde en vedhæftet fil, som derefter bliver tilføjet til meddelelsen. Før du sender svaret til personen, kan du redigere teksten og fjerne eller tilføje vedhæftede filer.

> [!NOTE]
> Du skal bruge *Vidensbase* som funktionel rettighed for at oprette svarskabeloner.

## Trin

1. Gå til ![ikonet][img1] **Hovedmenu** på toplinjen, og vælg **Vidensbase** &gt; **Svarskabeloner**.

1. Gå til den mappe, du vil placere svarskabelonen i. Hvis den endnu ikke findes, kan du [oprette en ny mappe][2].

    ![Sådan finder du svarskabeloner i SuperOffice -screenshot][img3]

1. Klik på knappen **Ny svarskabelon**.

1. Øverst på fanen **Egenskaber** i skærmbilledet **Egenskaber for svarskabelon** skal du indtaste følgende:

    * **Navn**: Et beskrivende navn på svarskabelonen.
    * **Beskrivelse**: En kort beskrivelse af, hvad svarskabelonen indeholder.
    * **Mappe**: Som standard navnet på den valgte mappe. Du kan vælge en anden mappe her.
    * **Adgang**: Her kan du vælge, hvem der skal have adgang til at læse og ændre den aktuelle svarskabelon.

1. Vælg fanen **(Sprog ikke angivet)**.

1. På fanen **Egenskaber** skal du angive følgende oplysninger:
    * **Sprog**: Vælg på denne liste, hvilket sprog svarskabelonen er på. Rullemenuen indeholder de sprog, der er registreret under ![ikonet][img2] &gt; **Kundesprog**.
    * **Standard**: Marker denne valgmulighed, hvis du ønsker, at dette sprog skal være standardsproget for svarskabelonen.
    * **Emne**: Her indtaster du sagens titel. Normalt indsættes denne i feltet **Overskrift**, når svarskabelonen bruges som e-mailmeddelelse.
    * **Meddelelseshovedfelt**: Her kan du tilføje foruddefineret indhold, der skal vises i meddelelsesheaderen, for eksempel i felterne **Til** og **Emne**, i en e-mailmeddelelse. Denne funktion bruges kun i særlige tilfælde.

1. På fanen **Almindelig tekst** skal du angive de følgende oplysninger:

    * **Inkluder almindelig tekst**: Når du opretter en HTML-version, er det altid en god idé at oprette en almindelig tekstversion til e-mailprogrammer, der ikke understøtter HTML. E-mailprogrammet vælger dermed automatisk det korrekte format. Hvis du ikke vælger denne indstilling, ignoreres teksten nedenunder. Den gemmes imidlertid, så du kan vælge at inkludere den senere.

    > [!NOTE]
    > Hvis du inkluderer både almindelig tekst og HTML-tekst, vælger e-mailprogrammet den "bedste" udgave, og det vil normalt være HTML. Husk, at meddelelser, der bliver sendt uden almindelig tekst, kun kan læses af e-mailprogrammer, der understøtter HTML.

    * I det store felt midt i skærmbilledet skriver du selve indholdet i svarskabelonen. Det er altid denne tekst, der bruges, når du [tilføjer svarskabeloner i meddelelser][4].
    * **Stavekontrol**: Starter en stavekontrol af meddelelsen på det sprog, der er angivet på listen **Sprog**.

1. På fanen **HTML-tekst** skal du angive følgende oplysninger:

    * **Inkluder HTML-tekst**: Vælg denne indstilling for at inkludere teksten nedenunder i en HTML-version af e-mailen. Dette bruges til kunder med e-mailprogrammer, der kan læse HTML (som for eksempel Outlook). Din meddelelse kommer ofte tydeligere frem, hvis du sender e-mailen som HTML, fordi du kan bruge billeder og farver i teksten.
    * I det store felt midt i skærmbilledet skriver du den HTML-formaterede tekst, du vil inkludere i meddelelsen til personen. Husk, at billeder, der knyttes forbindelse til her, skal ligge på en server, der er tilgængelig for modtagerne af e-mailen. Du kan for eksempel tilføje billeder, der er tidligere er uploadet til **Eksterne dokumenter**.

1. På fanen **SMS-tekst** kan du tilføje tekst, der er beregnet til at blive sendt via SMS. Her skal du angive følgende oplysninger:

    * **SMS-tekst**: I dette felt skal du indtaste selve svarskabelonteksten.
    * **Antal tegn**: Her kan du følge med i, hvor mange tegn du har indtastet.

1. På fanen **Vedhæft** kan du tilføje vedhæftede filer, der skal medtages i svarskabelonen:

    1. Klik på **Gennemse**.
    2. I dialogboksen skal du gennemse mulighederne, indtil du når frem til det ønskede dokument.
    3. Klik på **Tilføj** for at tilføje vedhæftningen.
    4. Gentag denne fremgangsmåde for at tilføje flere vedhæftede filer.

    > [!TIP]
    > Du kan slette en vedhæftet fil ved at klikke på **Slet** til højre for rækken.

1. Klik på **OK** for at gemme svarskabelonen. Fanen **(Uspecificeret sprog)** ændres til det valgte sprog. Klik på **Tilbage** for at gå tilbage til mappestrukturen for svarskabeloner. Den er nu klar til brug i [svar på henvendelser fra kunder][4].

## Opret brugerdefineret udseende til svar ved hjælp af kategorier

For at give hver afdeling i dit firma et brugerdefineret udseende for deres korrespondance, kan du oprette svarskabeloner med forskellige udseender. Hvert svarskabelon kan knyttes til en [kategori][1], der repræsenterer en afdeling. Alle udgående svar fra kategorierne (afdelingerne) flettes med det afdelingsspecifikke design.

Ud over svarskabelonens udseende/formatering skal den indeholde følgende skabelonvariabler, som kan flettes med svaret:

```text
[[IF:message.bodyHtml!=""]]
[[message.bodyHtml]]
\[\[ELSE\]\]
[[message.body]]
\[\[ENDIF\]\]
```

## <a id="faq" />Automatisk FAQ-svar

SuperOffice Service leveres med et sæt af svarskabeloner. Blandt disse svarskabeloner finder du "Eksempel på et automatisk FAQ-svar". Denne svarskabelon indeholder et eksempel på automatisering af svar til kunden på fanen **HTML-tekst**.

Ud fra kundens sag søger systemet efter tilsvarende ord (inklusive nøgleord) i FAQ-posterne i SuperOffice Service. Ud fra graden af sammenhæng mellem disse, medtages foreslåede FAQ'er, der kan hjælpe kunden, i svarskabelonen, der automatisk sendes til kunden for at bekræfte modtagelse af sagen.

Du kan vælge graden af sammenhæng mellem sagen fra kunden og FAQ-posterne i feltet **Minimumscore for søgeresultater i ofte stillede spørgsmål (i procent)** i ![ikonet][img2] **Systemindstillinger** &gt; **System** &gt; **Indstillinger**.

## Hvad vil du foretage dig nu?

* [Oprettelse af ny sprogversion af svarskabelon][5]
* [Redigering af svarskabeloner][6]
* [Kopiering af svarskabeloner][7]

<!-- Referenced links -->
[1]: ../../learn/category/index.md
[2]: manage-folders.md
[4]: ../../learn/howto/reply.md
[5]: new-language.md
[6]: edit.md
[7]: copy.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/main-menu.png
[img2]: ../../../../media/icons/main-menu-small.png
[img3]: media/create-a-new-reply-template.png
