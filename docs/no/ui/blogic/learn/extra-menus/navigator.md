---
uid: help-no-ui-extra-menu-navigator
title: Legg til navigatorgruppe og ekstrameny
description: Legg til navigatorgruppe og ekstrameny
author: SuperOffice RnD
date: 06.29.2022
keywords: navigator-gruppen
topic: howto
audience: settings
audience_tooltip: Settings and maintenance

language: no
---

# Legg til navigatorgruppe og ekstrameny

[!include[Legacy](../includes/legacy-extra-menus.md)]

For å illustrere denne funksjonaliteten legger vi til en ny navigatorgruppe i navigatoren til venstre i SuperOffice. I den nye navigatorgruppen skal vi legge til en ekstrameny. I eksemplet vårt skal vi legge til navigatorgruppen "Nettsteder" med noen nyttige nettsteder.

1. Velg <i class="ph ph-list" aria-label="Main menu"></i> **Systeminnstillinger** > **Systemdesign** > **Ekstramenyer**.

2. Hold musepekeren over **Navigator**-mappen og klikk på **+**.

3. Skriv inn "Nettsteder" i feltet**Ledetekst** (maksimalt 14 tegn).

4. Valgfritt: Klikk på knappen **Velg** til høyre for feltet **URL til ikon** for å velge et ikon for navigatorgruppen. Du kan velge et bilde som allerede ligger i databasen, eller laste opp et nytt bilde. Bildet bør ha en størrelse på 36 x 36 piksler, slik at det vises riktig i navigatoren. Du velger bildet og endrer størrelsen i samme dialogboks.

5. Klikk på **Posisjon** for å velge hvor den nye navigatorgruppen skal plasseres (0 = topp).

6. Klikk på **OK**. Den nye navigatorgruppen vises til venstre. Navigatorgruppen er tom, så vi må legge til et nettsted. I vårt tilfelle legger vi til Google.

7. Hold musepekeren over navigatorgruppen du nettopp har opprettet, og klikk på **+**. Skjermbildet **Egenskaper for meny** vises.

8. Skriv inn "Google" i feltet **Ledetekst** (maksimalt 20 tegn).

9. Merk av for **Bruk URL** og skriv inn `http://www.google.com` i **URL**-feltet.

10. IKKE merk av for **Legg til ID** eller **Legg til &lt;usec&gt;**, ellers legges verdier til bak URLen du definerte.

11. IKKE merk av for **Gå tilbake til samme skjermbilde**. Hvis du merker av her, virker ikke eksterne URLer. Se [Egenskaper for meny][1].

12. I feltet **Mål** skriver du inn "_blank", slik at nettstedet åpnes i en ny fane i nettleseren.

13. Klikk på **OK**.

14. Klikk på navigatorgruppen og den nye ekstramenyen, og kontroller at nettstedet åpnes riktig.

<!-- Referenced links -->
[1]: properties.md
