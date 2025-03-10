---
uid: help-da-ui-extra-menu-navigator
title: Tilføj navigatorgruppe og ekstramenu
description: Tilføj navigatorgruppe og ekstramenu
author: SuperOffice RnD
date: 06.29.2022
keywords: navigatorgruppe
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføj navigatorgruppe og ekstramenu

[!include[Legacy](../includes/legacy-extra-menus.md)]

For at illustrere denne funktion vil vi tilføje en ny navigatorgruppe i navigatoren til venstre i SuperOffice. Vi vil tilføje en ekstramenu i den nye navigatorgruppe. I vores eksempel vil vi tilføje navigatorgruppe "Websteder" med nogle nyttige websteder.

1. Vælg <i class="ph ph-list" aria-label="Main menu"></i> **Systemindstillinger** > **Systemdesign** > **Ekstramenuer**.

2. Hold musemarkøren over mappen **Navigator**, og klik på **+**.

3. Indtast "Websteder" i feltet **Overskrift** (maks. 14 tegn).

4. Valgfrit: Klik på knappen **Vælg** til højre for feltet **URL til ikon** for at vælge et ikon til navigatorgruppen. Du kan vælge et billede, der allerede findes i databasen, eller du kan uploade et billede. Billedet skal have en størrelse på 36x36 pixel, så det vises korrekt i navigatoren. Du vælger billedet og ændrer størrelsen i den samme dialogboks.

5. Klik på **Position** for at vælge, hvor den nye navigatorgruppe skal placeres (0 = top).

6. Klik på **OK**. Den nye navigatorgruppe vises til venstre. Navigatorgruppen er tom, så vi skal tilføje websted. I dette tilfælde tilføjer vi Google.

7. Hold musemarkøren hen over den navigatorgruppe, du netop har oprettet, og klik på **+**. Skærmbilledet **Egenskaber for menu** vises.

8. Indtast "Google" i feltet **Overskrift** (maks. 20 tegn).

9. Vælg **Brug URL**, og indtast `http://www.google.com` i feltet **URL**.

10. Du må IKKE vælge **Tilføj id** eller **Tilføj &lt;usec&gt;**, da der så vil blive tilføjet værdier bag den URL, som du har defineret.

11. Du må IKKE markere **Tilbage til samme skærmbillede**. Hvis afkrydsningsfeltet er markeret, fungerer eksterne URL'er. Se [Menuegenskaber][1].

12. Indtast "_blank" I feltet **Destination**, så webstedet åbnes i en ny fane i browseren.

13. Klik på **OK**.

14. Klik på navigatorgruppen og den nye ekstramenu, og kontroller, at webstedet åbnes korrekt.

<!-- Referenced links -->
[1]: properties.md
