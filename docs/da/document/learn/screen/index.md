---
uid: help-da-document-dialog
title: Dialogboksen Dokument
description: Dialogboksen Dokument
author: SuperOffice RnD
so.date: 06.29.2022
keywords: dokument
so.topic: concept
language: da
---

# Dialogboksen Dokument

Centralt i dokumentfunktionen findes dialogboksen **Dokument**, som du kan åbne på forskellige måder:

* Ved at vælge **Ny** > **Dokument**.
* Ved at åbne et [eksisterende dokument][1].

Dialogboksen består af en hoveddel med generelle oplysninger om dokumentet samt følgende faner med ekstra oplysninger:

* Detaljer
* Links
* Mere

## Hovedafsnit

Hoveddelen indeholder følgende grundlæggende oplysninger om dokumentet:

### Dokumentskabelon

Hvis du klikker på pilen ![ikon][img1] ved siden af typefeltet øverst i dialogboksen, åbnes en liste over de dokumentskabeloner, som du kan vælge mellem. [!include[SM](../../../learn/includes/are-defined-sm.md)]

> [!NOTE]
> Når du [opretter et dokument][5], åbnes skabelonen i det program, den blev oprettet i. Dette betyder for eksempel, at DOCX-filer bliver åbnet i Word.

### Firma

Her skriver du navnet på det firma, du skriver et dokument til. Du kan søge direkte fra dette felt.

### Kontaktperson

Hvis du klikker på pilen efter dette felt, åbnes en liste over de personer, som er registreret på firmaet.

### Projekt

Her skriver du eventuelt navnet på det projekt, som dokumentet er knyttet til. Du kan søge direkte fra dette felt.

### Salg

Indtast navnet på det salg (hvis der er et), som dokumentet er knyttet til. Du kan søge direkte fra dette felt.

### Skriv overskriften her

Indtast den tekst, der skal bruges som overskrift til dokumentet (den tekst, der vises under sektionsfaner og rapporter, hvor dokumentet er angivet).

### Sprog

Vælg et sprog for skabelonen. Dette alternativ er kun tilgængeligt, hvis den valgte skabelon indeholder oversatte versioner.

### Dato

I dette felt vises automatisk den aktuelle dato. Hvis du klikker på pilen ved siden af feltet **Dato**, vises en månedskalender, hvor du kan vælge den ønskede dato.

> [!NOTE]
> Du kan kun ændre datoen i forbindelse med oprettelse af dokumentet. I redigeringstilstand har du ikke adgang til dette felt.

### Vores ref

Her kan du indtaste din reference. Det, der skal sættes ind som standard for hver skabelon, defineres i Indstillinger og vedligeholdelse, men du kan dog også ændre indholdet i dette felt.

### Din ref

Her kan du indtaste en eventuel reference fra firmaets henvendelse.

### Synlig for

Klik i feltet **Synlig for** for at få vist en liste, hvor du kan vælge, om dokumentet skal være synligt for alle brugere, privat (kun synlig for den bruger, der er defineret som ejer) eller synlig for alle brugere i en af de brugergrupper, som ejeren tilhører.

> [!NOTE]
> Hvis du indstiller synlighed til Kun ejer, vises posten med kursiv på fanen **Aktiviteter** i sektionen.

### Tjekket ud til redigering

Hvis dokumentet er tjekket ud til redigering, vises et af følgende ikoner:

![ikon][img2] Dokumentet er i øjeblikket tjekket ud til redigering af dig.

![ikon][img3] Dokumentet er i øjeblikket tjekket ud til redigering af en anden bruger.

> [!TIP]
> Hold musemarkøren over et ikon for at vise oplysninger om den bruger, der har tjekket dokumentet ud.

### Afsluttet

Standardindstillingen er, at dokumentet er markeret som udført (![ikon][img4]), men du kan fjerne markeringen, hvis du vil (![ikon][img5]). I så fald vises dokumentet i detaljekortet **Aktiviteter** i skærmbilledet Dagbog, indtil det bliver markeret som udført.

> [!NOTE]
> Du kan ikke foretage ændringer af udførte dokumenter, før du har deaktiveret statussen **Udført**. [Ændring af status Udført for en aktivitet][7].

### Brugerdefinerede felter

[!include[3 udef](../../../learn/includes/more-udef.md)]

> [!NOTE]
> Brugergruppetilhørsforholdet defineres i skærmbilledet Brugere i Indstillinger og vedligeholdelse.

### Opgave

Når du klikker på denne knap, vises følgende indstillinger:

* **Slet**: Sletter den aktuelle post.
* **Hjælp**: Åbner hjælpen til den aktive dialogboks.
* **Kopier genvej**: Kopierer en [genvej til den aktive post][9].
* **Hent gemt version**: Vælg dette alternativ for at [afbryde en udtjekning][4]. Det kan være aktuelt, hvis du har tjekket dokumentet ud ved en fejl og ikke kan tjekke det igen.

Under disse valg kan du finde genveje til andre relevante opgaver, som kan udføres på den aktive post. I Indstillinger og vedligeholdelse kan du også definere egne opgaver og tilføje dem under knappen **Opgave**.

## Fanen Detaljer

Fanen **Detaljer** indeholder detaljerede oplysninger om dokumentet.

* **Beskrivelse:** Her kan du tilføje en beskrivelse af dokumentet. Dette kan være nyttigt i forbindelse med fritekstsøgning.

* **Dokument:** Klik på linket for at uploade dokumentet eller trække og slippe dokumentet fra Windows Stifinder til dialogboksen **Dokument**.

    Dette kan du læse mere om under [Oprettelse af nye dokumenter][5] og [Redigering af dokumenter][1].

**Udgiv:** Marker her, hvis du ønsker, at dokumentet skal vises for eksterne brugere i Audience (kræver separat licens).

## Fanen Links

Denne fane indeholder oplysninger om aktiviteter (dokumenter og opfølgninger) og salg, som er tilknyttet til det aktuelle dokument. Hvis der er registreret noget på denne fane, vises der en prik ved siden af **Links**.

Læs mere om, hvordan du [tilføjer links][2].

## Fanen Mere

Denne fane viser alle [brugerdefinerede felter][3], der er konfigureret i Indstillinger og vedligeholdelse.

## Fanen www

[!include[About the www tab](../../../learn/includes/www-tab.md)]

<!-- Referenced links -->
[1]: ../edit.md
[4]: ../lock.md
[5]: ../create.md
[7]: ../../../diary/learn/change-completed-status.md
[9]: ../../../onsite/win-client/learn/creating-shortcuts-to-entries-in-crm.md
[2]: ../../../diary/learn/linking-documents-to-follow-ups.md
[3]: ../../../custom-objects/learn/udef/index.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/dropdown-icon.png
[img2]: ../../../../media/icons/document-lock-editing.png
[img3]: ../../../../media/icons/document-lock-locked.png
[img4]: ../../../../media/icons/followup-completed-small.png
[img5]: ../../../../media/icons/followup-not-completed-small.png
