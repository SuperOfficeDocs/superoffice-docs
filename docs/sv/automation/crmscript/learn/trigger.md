---
uid: help-sv-automation-trigger
title: Triggrar
description: Triggrar
keywords: CRMScript, utlösare
author: SuperOffice RnD
date: 02.25.2025
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Triggrar

[!include[Requirement](../../../includes/req-dev-tools.md)]

Utlösare är skript som körs för specifika händelser i systemet, till exempel när en ny försäljning skapas eller ett ärende stängs. Utlösare kan reagera tyst på vad som händer, eller blockera åtgärden och visa en förklaring för användaren.

CRMScript kan göra din arbetsdag mer effektiv genom att automatisera olika uppgifter. Du kan definiera att en viss händelse i systemet ska utlösa en eller flera fördefinierade åtgärder. Inga skriptkunskaper behövs för att få detta att fungera.

**Exempel från SuperOffice**: När ett ärende avslutas måste ett meddelande om detta skickas till kunden via e-post. Vi kan skapa ett makro som innehåller en serie åtgärder för att skapa och skicka det här e-postmeddelandet. Detta makro körs automatiskt när ett ärende avslutas. Åtgärderna i makrot läser in det relevanta ärendet, hämtar rätt svarsmall och skickar ett e-postmeddelande till kunden med information om att ärendet har avslutats.

Det här är ett exempel på en mycket enkel utlösare. Du kan till exempel lägga till villkor i utlösarens åtgärder genom att ändra på standardinställningen **Alltid**.

## Skapa en utlösare

Vi ska nu skapa en serie åtgärder baserat på exemplet ovan.

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Klicka på <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** och gå till fliken **Utlösare**.
1. Klicka på knappen **Ny utlösare (makro)**. På skärmen **Välj utlösare** visas tillgängliga utlösare. Detta är händelser i systemet som kan användas för att utlösa åtgärder eller makron. I vårt exempel väljer vi **Ärende avslutat** så att makrot körs när ett ärende avslutas i SuperOffice.
1. Skriv "ärende" i sökfältet och välj utlösaren **Ärende avslutat**.
1. Ange en kort beskrivning av utlösaren i fältet **Beskrivning**.
1. Välj **Aktiverad**.
1. Välj **Ändra ett ärende** under **Välj åtgärdstyp** nedanför. Du kommer då till fliken **Ändra ett ärende**.
    Detta blir den första åtgärden i makrot. Det hämtar ärendet så att de olika värdena (ID, titel, kontaktnamn o.s.v.) kan användas i efterföljande åtgärder som vi skapar.
1. Tillval: Markera **Internt meddelande** och skriv t.ex.: "Ärende avslutat och bekräftelse skickad till kund."
1. Klicka på **Verkställ**.
1. Klicka på **Ny åtgärd** bredvid fliken **Ändra ett ärende**.
1. Välj **Läs in en svarsmall för koppling**. Vi ska nu hämta den svarsmall som ska användas.
1. Klicka på fältet **Svarsmall** och välj en befintlig svarsmall i den lista som visas, t.ex. "Ärende avslutat".
1. Klicka på **Verkställ**.
1. Klicka på **Ny åtgärd** och välj **Skicka ett e-postmeddelande eller SMS**. Vi ska nu anpassa det e-postmeddelande som skickas till kunden.
1. Markera **Ämne**.
1. Klicka på <i class="ph ph-gear" aria-label="Gear"></i> till höger och sedan på fältet **Välj parameter**.
1. Välj **Ändra ett ärende** > **Titel**. Ärendets titel hamnar i e-postmeddelandets ämnesrad.
1. Välj **Från** och välj **Ändra ett ärende** > **Ägare**.
1. Markera **Till** och välj **Ändra ett ärende** > **Kontakt: E-postadress**.
1. Markera **HTML-meddelande** och välj **Läs in en svarsmall för koppling** > **HTML-text**.
1. Klicka på **Verkställ**.

Du har nu skapat ett makro som skickar kunden ett e-postmeddelande med ämnet "Ärende avslutat" när ett ärende avslutas. Den här utlösaren aktiveras omedelbart om du markerar **Aktiverad** högst upp.
