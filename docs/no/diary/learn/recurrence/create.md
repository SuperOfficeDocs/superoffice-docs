---
uid: help-no-recurrence-set
title: Planlegge repeterende oppfølging
description: Planlegge repeterende oppfølging
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: dagbok, oppfølging, gjenta
so.topic: howto
language: no
---

# Planlegge repeterende oppfølging

Å sette opp gjentakelse betyr å planlegge startdatoen for oppfølgingsmøter i en serie.

[!include[Caution](../includes/caution-do-not-change-recurring-date.md)]

## Trinn

<!-- markdownlint-disable MD051 -->
### [Classic](#tab/fields-old)

1. [Åpne eller opprett en oppfølging][2].

2. Velg fanen **Detaljer** og klikk på ordet **Aldri** ved siden av feltet **Gjentas**.

    Hvis du oppdaterer en gjentakende oppfølging, klikk på den tidligere angitte mønsteret, for eksempel, **Månedlig (23.09.2023 - 23.09.2024)**.

3. Angi **hyppighet:** skal oppfølgingen gjentas daglig, ukentlig, månedlig, årlig eller med egendefinert mellomrom?

4. Deretter velger du ytterligere [detaljer for hyppighet][4]. Alternativene i dette feltet endrer seg avhengig av hva du velger under trinn 3.

    Hvis ingen av mønstrene passer for deg, kan du manuelt legge inn de datoene du trenger.
    Velg **Egendefinert**. Velg deretter en dato i kalenderen og klikk på pilen ![ikon][img2] for å legge den til i listen over valgte datoer. Gjenta for å legge til flere datoer. For å fjerne en dato, velg datoen i listen og klikk på **Slett**.

5. I feltet **Repeterende oppfølginger** velger du om oppfølgingen skal stoppe etter et bestemt antall ganger eller etter en bestemt dato.

6. Hvis du vil, kan du endre én eller flere datoer manuelt i listen over merkede datoer, for eksempel hvis det er en konflikt.

    * **For å flytte en dato,** merk datoen du vil flytte, og klikk på **Senere** hvis du vil flytte oppfølgingen én dag frem i tid, eller på **Tidligere** hvis du vil flytte oppfølgingen én dag tilbake i tid.

    * **For å legge til en dato,** klikk på **Legg til**-knappen under listen. Velg ønsket dato, og klikk på pilknappen ![ikon][img2] til høyre for kalenderen for å legge til datoen på listen. Bruk pilknappene på hver side av månedsnavnet i kalenderen for å vise andre måneder.

    * **For å slette en dato,** merk datoen du vil slette, og klikk på **Slett**-knappen under listen. Datoen blir da fjernet fra listen over datoer.

7. Når du har angitt datoer for oppfølgingen, klikker du på **OK** for å lagre datoene og lukke dialogboksen, eller på **Avbryt** hvis du vil lukke dialogboksen uten å lagre datoene.

    I dialogboksen viser teksten ved siden av feltet **Gjentas** hva slags gjentakelse du har angitt for oppfølgingen, for eksempel **Månedlig (23.09.2016 - 23.09.2017)**.

8. Klikk på **Lagre** i dialogboksen **Avtale** for å lagre de endringene som er gjort.

![Skjermbilde av gjentakende oppfølgingsdialog -screenshot][img6]

### [Ny (fra versjon 10.2.11 pilot)](#tab/fields-new)

1. [Åpne eller opprett en oppfølging][2].

1. Klikk gjentakelsesikonet ![ikon][img1] og velg en av de foreslåtte frekvensene. Hvis ingen av mønstrene passer for deg, velg **Egendefinert**.

    ![Oppfølgingsdialog, foreslått gjentakelse -screenshot][img8]

    Hvis du ikke ser ikonet, klikk **Vis mer**.

1. Oppdater startdatoen om nødvendig.

1. Velg en frekvens, for eksempel, gjenta hver 2. uke. Ytterligere alternativer vises hvis du velger *Uke(r)*, *Måned(er)*, eller *År*.

    ![Oppfølgingsdialog, gjentakelse -screenshot][img7]

1. Velg om oppfølgingen skal stoppe etter et bestemt antall ganger eller etter en bestemt dato.

1. Valgfritt, finjuster listen over valgte datoer, for eksempel, hvis det er en konflikt. Klikk på en dato, bruk deretter knappene under listen for å enten fjerne eller flytte den datoen.

1. Klikk **OK** for å lagre datoene og returnere til oppfølgingsdetaljene.

1. Klikk **Lagre** i **Oppfølgings**-dialogen for å lagre alle endringer.

***
<!-- markdownlint-restore -->

## Hva vil du lære mer om?

* [Redigere repeterende oppfølginger][1]
* [Stoppe repeterende oppfølginger][3]

<!-- Referenced links -->
[1]: ../edit-follow-up.md#repeat
[2]: ../create-follow-up.md
[3]: stop.md
[4]: index.md#frequency

<!-- Referenced images -->
[img1]: ../../../../../common/icons/refresh-icon.png
[img2]: ../../../../media/icons/arrow-right.png
[img6]: ../../../../media/loc/en/diary/recurrence-dialog.png
[img7]: ../../../../media/loc/en/diary/recurrence-selected-dates.png
[img8]: ../../../../media/loc/en/diary/suggested-pattern.png
