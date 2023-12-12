---
uid: help-da-recurrence-set
title: Planlæg gentagen opfølgning
description: Planlæg gentagen opfølgning
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: dagbog, opfølgning, gentag
so.topic: howto
language: da
---

# Planlæg gentagen opfølgning

At opsætte gentagelse betyder at planlægge *startdatoen* for opfølgningsmøder i en serie.

[!include[Caution](../includes/caution-do-not-change-recurring-date.md)]

## Trin

<!-- markdownlint-disable MD051 -->
### [Classic](#tab/fields-old)

1. [Åbn eller opret en opfølgning][2].

2. Vælg fanen **Detaljer** og klik på ordet **Aldrig** ved siden af feltet **Gentagelse** .

    Hvis du opdaterer en gentagende opfølgning, skal du klikke på det tidligere indstillede mønster, for eksempel, **Månedlig (23.09.2023 - 23.09.2024)**.

3. Angiv **frekvens:** skal opfølgningen gentages dagligt, ugentligt, månedligt, årligt eller med et brugerdefineret interval?

4. Vælg derefter yderligere [detaljer for frekvens][4]. De tilgængelige indstillinger her afhænger af, hvad du vælger under  trin 3.

    Hvis ingen af mønstrene passer for dig, kan du manuelt indtaste de datoer, du har brug for. Vælg **Brugerdefineret**. Vælg derefter en dato i kalenderen og klik på pilen ![ikon][img2] for at tilføje den til listen over valgte datoer. Gentag for at tilføje flere datoer. For at fjerne en dato, vælg datoen i listen og klik på **Slet**.

5. I feltet **Gentagne opfølgninger slutter** skal du vælge, om opfølgningen skal stoppe efter et bestemt antal gange eller efter en bestemt dato.

6. Du kan også ændre en eller flere datoer manuelt på listen over valgte datoer, f.eks. hvis der er en konflikt.

    * **For at flytte en dato**, vælg den dato, du vil flytte, og klik på **Senere** for at udsætte opfølgningen med en dag eller **Tidligere** for at rykke opfølgningen en dag frem.

    * **For at tilføje en dato**, klik på knappen **Tilføj** under listen. Vælg den ønskede dato, og klik på pileknappen ![ikon][img2] til højre for kalenderen for at tilføje datoen til listen. Brug pileknapperne på hver side af månedens navn i kalenderen til at få vist andre måneder.

    * **For at slette en dato**, vælg den dato, du vil slette, og klik på knappen **Slet** under listen. Datoen fjernes derefter fra listen over datoer.

7. Klik på **OK** for at gemme datoerne og lukke dialogen eller klik på **Annuller** for at lukke dialogboksen uden at gemme datoerne.

    I dialogboksen viser teksten ved siden af feltet **Gentagelse** hvilken form for gentagelse, du har specificeret til opfølgningen f.eks. **Månedlig (23.09.2016 - 23.09.2017)**.

8. Klik på **Gem** i dialogboksen **Aftale** for at gemme de ændringer, du har foretaget.

![Skærmbillede af gentagende opfølgningsdialog -screenshot][img6]

### [Ny (fra version 10.2.11 pilot)](#tab/fields-new)

1. [Åbn eller opret en opfølgning][2].

1. Klik på gentagelsesikonet ![ikon][img1] og vælg en af de foreslåede frekvenser. Hvis ingen af mønstrene passer for dig, vælg **Tilpasset**.

    ![Opfølgningsdialog, foreslået tilbagevendende -screenshot][img8]

    Hvis du ikke ser ikonet, klik **Vis mere**.

1. Opdater startdatoen om nødvendigt.

1. Vælg en frekvens, for eksempel, gentag hver 2. uge. Yderligere indstillinger vises, hvis du vælger *Uge(r)*, *Måned(er)*, eller *År*.

    ![Opfølgningsdialog, tilbagevendende -screenshot][img7]

1. Beslut, om opfølgningen skal stoppe efter et bestemt antal gange eller efter en bestemt dato.

1. Valgfrit, finjuster listen over valgte datoer, for eksempel, hvis der er en konflikt. Klik på en dato, brug derefter knapperne under listen til enten at fjerne eller flytte den dato.

1. Klik **OK** for at gemme datoerne og vende tilbage til opfølgningsdetaljerne.

1. Klik **Gem** i **Opfølgnings**-dialogen for at gemme alle ændringer.

***
<!-- markdownlint-restore -->

## Hvad ønsker du at få mere at vide om?

* [Redigering af gentagne opfølgninger][1]
* [Stop af gentagne opfølgninger][3]

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
