---
uid: help-sv-ui-extra-menu-navigator
title: Lägga till navigatorgrupp och extrameny
description: Lägga till navigatorgrupp och extrameny
author: SuperOffice RnD
date: 06.29.2022
keywords: navigatorgrupp
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Lägga till navigatorgrupp och extrameny

[!include[Legacy](../includes/legacy-extra-menus.md)]

Som ett exempel på denna funktionalitet ska vi lägga till en ny navigeringsgrupp i navigatorn till vänster i SuperOffice. Vi ska lägga till en extrameny i den nya navigeringsgruppen. I vårt exempel ska vi lägga till navigeringsgruppen "Webbplatser" med ett par användbara webbplatser i.

1. Välj <i class="ph ph-list" aria-label="Main menu"></i> > **Systeminställningar** > **Systemdesign** > **Extramenyer**.

2. Håll muspekaren över mappen **Navigator** och klicka på **+**.

3. Skriv "Webbplatser" i fältet **Namn** (max. 14 tecken).

4. Tillval: Klicka på knappen **Välj** till höger om fältet **URL till ikon** och välj en ikon för navigeringsgruppen. Du kan välja en bild som redan finns i databasen eller ladda upp en ny bild. Bilden måste ha en storlek på 36 x 36 pixlar för att visas korrekt i navigatorn. Du väljer bild och ändrar bildens storlek i samma dialogruta.

5. Klicka på **Placering** och välj var den nya navigeringsgruppen ska placeras (0 = överst).

6. Klicka på **OK**. Den nya navigatorgruppen visas till vänster. Navigatorgruppen är tom, så vi måste lägga till en webbplats. I det här fallet lägger vi till Google.

7. Håll muspekaren över den navigeringsgrupp du nyss har skapat och klicka på **+**. Skärmen **Egenskaper för meny** visas.

8. Skriv "Google" i fältet **Namn** (max. 20 tecken).

9. Markera **Använd URL** och ange `http://www.google.com` i **URL**-fältet.

10. Markera INTE **Lägg till ID** eller **Lägg till &lt;usec&gt;** – om du gör det läggs värden till i slutet av den URL du definierade.

11. Markera INTE **Tillbaka till samma skärmbild**. Om det alternativet markeras fungerar inte externa URL-adresser. Se [Egenskaper för meny][1].

12. I fältet **Mål** skriver du "_blank" så att webbplatsen öppnas i en ny flik i webbläsaren.

13. Klicka på **OK**.

14. Klicka på navigeringsgruppen och den nya extramenyn och kontrollera att webbplatsen öppnas korrekt.

<!-- Referenced links -->
[1]: properties.md
