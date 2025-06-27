---
uid: help-sv-automation-macro-create
title: Skapa ett makro – exempel från SuperOffice
description: Exempel på hur du skapar ett makro i SuperOffice.
keywords: skript, makro
author: SuperOffice RnD
date: 02.25.2025
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Skapa ett makro – exempel från SuperOffice

Många företag får ofta förfrågningar i samband med fakturering. Sådana ärenden bör gå rakt till redovisningsavdelningen. I stället för att redigera varje ärende och ändra dess kategori och ägare kan vi skapa ett makro som utför alla dessa åtgärder. Makrot kan tilldelas till knappen **Åtgärder** i fönstret Ärende. Fakturafrågor kan då delegeras till redovisningsavdelningen med ett enda klick.

> [!TIP]
> Om du vill automatisera processen fullständigt kan du skapa ett e-postfilter som söker efter ordet "faktura" i e-postens ämnesrad och sedan köra makrot för att tilldela ärendet till rätt avdelning.

Vi ska nu skapa ett makro baserat på exemplet ovan.

## Steg

1. [!include[Go to](../../../learn/includes/goto-sm.md)]

1. Välj <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** och fliken för **Makron och skript**. Gör något av följande:
    * Om du vill skapa ett nytt makro: Klicka på **Nytt makro**.
    * Om du vill ändra ett befintligt makro: Klicka på makronamnet.

1. På fliken **Information** skriver du "Skicka ärende till redovisningsavd." i fältet **Namn** och anger en beskrivning i fältet nedanför.

1. Markera alternativet **Ny meny** för att göra makrot tillgängligt från knappen **Uppgift** i fönstret Företag, Kontakt eller Ärende eller på fliken **Meddelande**.

1. Gå till fliken **Åtgärder** och välj **Välj åtgärdstyp** > **Ändra ett ärende**.

1. Markera **Kategori** och välj en kategori i listan (t.ex. *Redovisning*).

1. Markera **Ägare** och välj en användare.

    > [!TIP]
    > Du kan också välja **Tilldelas automatiskt** om du vill att ärendet ska distribueras enligt aktuella distributionsregler.

1. Markera **Internt meddelande** och skriv ett kort standardmeddelande till redovisningsavdelningen om varför de har fått ärendet.

1. Klicka på **OK** när du är färdig.

## Relaterat innehåll

* [Läs mer om avancerade makrofunktioner och utlösare][1]

<!-- Referenced links -->
[1]: trigger.md
