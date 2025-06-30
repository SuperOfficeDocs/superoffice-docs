---
uid: help-sv-ui-extra-menu-properties
title: Egenskaper för meny
description: Egenskaper för meny
author: SuperOffice RnD
date: 06.29.2022
keywords: Tjänst
content_type: howto
language: sv
---

# Egenskaper för meny

[!include[Legacy](../includes/legacy-extra-menus.md)]

Här kan du redigera egenskaperna för alternativ på extramenyer och webbpaneler.

* **Basprogram**: Välj ett basprogram om du vill att innehållet i fältet URL ska läggas till i ett visst basprogram. För att detta ska fungera måste texten i fältet URL börja med &action=...

* **URL**: Den webbadress som ska öppnas när användaren klickar på menyn.

* **Lägg till ID**: Lägger automatiskt till den aktuella postens ID i slutet av webbadressen.

* **Tillbaka till samma skärmbild**: Om du markerar den här rutan återgår användarna till skärmen där de ursprungligen klickade på knappen (eller liknande). Annars måste användarna återgå manuellt.

  * Exempel på när alternativet ska användas: Om du skapar en knapp (makro) på skärmen Ärende för att ändra ärendets kategori vill du också återgå till samma ärende när användaren har klickat på knappen.

  * Exempel på när alternativet INTE ska användas: Om du skapar en knapp (skript) som visar mycket information på skärmen ska alternativet inte markeras, eftersom du vill visa informationen på skärmen. Samma sak gäller för externa URL-adresser, eftersom du vill gå till webbplatsen när du klickar på knappen.

* **Lägg till &lt;usec&gt;**: &lt;usec&gt; är sessionsnyckeln för NetServer-sessionen. För att en webbpanel ska fungera med NetServer när autentisering används måste denna nyckel inkluderas.

* **Mål**: Målet för webbadressen. Du kan välja vilket fönster webbadressen ska öppnas i genom att ange fönsterinstansens namn i fältet **Mål**. Du kan skriva "_blank" om du alltid vill öppna ett nytt fönster/en ny flik, eller t.ex. "kund" för att öppna ett separat fönster för detta menyalternativ eller en grupp menyalternativ.

* **URL till ikon**: Om du vill ha en egen ikon för extramenyn kan du ange bildens URL här.

* **Placering**: Anger extramenyernas placering (0 = överst).
