---
uid: help-sv-project-guide-tutorial
title: Projektguide-handledning
description: En genomgång av projektguider
keywords: projektguide, guide, arbetsflöde, projekt
author: Bergfrid Dias
date: 25.25.2025
version: 10.5.2
content_type: tutorial
license: salespremium, servicepremium, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/project/learn/project-guide/working-with
---

# Projektguide-handledning

Tänk på att dina projektguider kan vara konfigurerade på olika sätt i Inställningar och underhåll.

## Registrera ett nytt projekt och välj en projekttyp

Du registrerar ett nytt projekt och väljer projekttypen **Konferens**, som är kopplad till en projektguide. Projektguiden innehåller följande statusar, händelser och dokument.

| Status | Händelser | Dokument |
|---|---|---|
| Planerat | Planeringsmöte (Möte inne) | Konferensprogram (Anteckning) |
| Under arbete | Skapa lista över projektdeltagare (Händelse) | Konferens (Möte ute) |
| Avslutning | Utvärderingsmöte (Möte inne) | Utvärderingsrapport (Anteckning) |

## Statusen Planerat

1. Du har bokat in en mötestid och vill skapa händelsen **Planeringsmöte** i kalendern och bjuda in deltagare.

    1. I projektguiden klickar du på **Skapa** bredvid händelsen **Planeringsmöte**.
        Dialogrutan **Händelse** öppnas med **Möte inne** angivet som typ och projektets namn redan ifyllt.
    1. Fyll i informationen och [bjud in deltagare][1].
    1. Klicka på **Spara**.

1. På mötet bestämmer ni konferensprogrammet (agendan), och du vill skapa en anteckning med denna information.

    1. Klicka på **Skapa** bredvid **Konferensprogram**.
        Dialogrutan **Dokument** öppnas, där **Anteckning** redan har valts som dokumentmall och projektets namn är ifyllt.
    1. Fyll i övrig information i dialogrutan **Dokument**.
    1. Klicka på **Skapa** för att skapa och spara anteckningen.

1. När mötet har genomförts och konferensprogrammet är färdigt, markerar du detta i projektguiden och går vidare till nästa status.

    I projektguiden markerar du kryssrutan bredvid händelsen **Planeringsmöte**.

    > [!TIP]
    > Du kan också göra detta från aktivitetslistan i exempelvis **Kalender**- och **Företag**-fönstren.

    1. Dialogrutan **Projektguide – flytta projektet till nästa status** öppnas.
    1. Här får du frågan om du vill flytta projektet till nästa status, **Under arbete**.
    1. Klicka på **Ja** för att flytta projektet.

    > [!NOTE]
    > Den här dialogrutan öppnas eftersom det är definierat för projekttypen i Inställningar och underhåll.

## Statusen Under arbete

1. Alla händelser och dokument i **Planerat** är slutförda, och projektet har flyttats vidare via dialogrutan **Projektguide – flytta projektet till nästa status**. Händelserna och dokumenten för den nya statusen visas nu på detaljkortet **Projektguide**.

    > [!NOTE]
    > Dialogrutan visas endast om det är definierat för projekttypen. Om det inte är definierat, [flytta projektet till nästa status manuellt][2].

1. På planeringsmötet enas ni om att din kollega ska sätta upp en lista över konferensdeltagare. Du vill skapa en uppgift i deras kalender som en påminnelse.

    1. Klicka på **Skapa** bredvid händelsen **Skapa lista över projektdeltagare**.
        Dialogrutan **Överför uppgiften till en projektdeltagare** öppnas.

    1. I listan över projektdeltagare väljer du den person som ska ha ansvaret för uppgiften och klickar på **OK**.

    1. Fyll i den nödvändiga informationen och klicka på **Spara**. (På fliken **Detaljer** kan du se att din kollega redan är angiven som ägare.)

    1. Händelsen visas i din kollegas kalender, och när listan är klar markerar de händelsen som **Slutförd**.

        > [!NOTE]
        > Dialogrutan **Överför uppgiften till en projektdeltagare** öppnas eftersom det är definierat i Inställningar och underhåll.

1. Nu vill du skapa ett brev med en inbjudan.

    Klicka på **Skapa** bredvid dokumentet **Konferensinbjudan** och [skapa dokumentet][3].

1. Till slut hålls själva konferensen. Du skapar mötet **Konferens**.

    1. Klicka på **Skapa** bredvid händelsen **Konferens**.
        Dialogrutan **Händelse** öppnas med **Möte ute** angivet som typ och projektets namn ifyllt.
    2. Fyll i informationen och bjud in konferensdeltagarna.
    3. Klicka på **Spara**.

## Statusen Avslutning

1. När konferensen är genomförd och alla relevanta händelser och dokument i **Under arbete** är slutförda, flyttar du projektet till den sista statusen, **Avslutning**.

    * Klicka på **Ja** i dialogrutan **Projektguide – flytta projektet till nästa status**.
    * Eller, klicka på <i class="ph ph-pencil-simple" aria-label="Redigera"></i> i projektkortet, klicka på pilen bredvid fältet **Status**, välj **Avslutning** och klicka på **OK**.

1. Du vill hålla ett internt möte för att utvärdera konferensen.

    1. Klicka på **Skapa** bredvid händelsen **Utvärderingsmöte**, fyll i informationen och klicka på **Spara**.
    2. När mötet är genomfört, markerar du kryssrutan.

1. Slutligen vill du skapa en utvärderingsrapport som sammanfattar konferensen.

    Klicka på **Skapa** bredvid dokumentet **Utvärderingsrapport** för att skapa dokumentet.

När alla händelser och dokument för projektet är färdiga kan du ställa in projektet som **Slutfört**.

<!-- Referenced links -->
[1]: ../../diary/learn/invitation/add-attendee.md
[2]: project-guides.md#change-status
[3]: ../../document/learn/edit.md
