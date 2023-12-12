---
uid: help-sv-project-guide-working-with
title: Arbeta med projektguide
description: Arbeta med projektguide
author: SuperOffice RnD
so.date: 07.04.2022
keywords: projekt, guide
so.topic: howto
language: sv
---

# Arbeta med projektguider

Om en projektguide är definierad för en projekttyp som du har angett för ett projekt händer följande:

* Den första statusen i projektguiden är vald i fältet **Status** på huvudkortet **Projekt**.

* Händelser och/eller dokument för statusen finns angivna på detaljkortet **Projektguide**.

## Steg

1. Klicka på knappen **Skapa** framför namnet på händelsen/dokumentet.

   ![Detaljkortet Projektguide med översikt över Planerad status -screenshot][img1]

1. I dialogrutan som öppnas [skapar du händelsen][2] eller [dokumentet][3] som vanligt. Många av fälten är redan ifyllda, men du kan ändra informationen eller lägga till mer information.

    Du kan delegera händelsen till andra medarbetare genom att ange dem som ägare av händelsen. Om detta är definierat i Inställningar och underhåll öppnas dialogrutan **Överför uppgiften till en projektdeltagare** där du kan välja en medarbetare som ägare av händelsen.

1. När du slutför händelsen markerar du **Slutfört** i den aktuella dialogrutan eller i checkrutan framför händelsenamnet på detaljkortet **Projektguide**. Dokument är som standard markerade som slutförda.

    > [!TIP]
    > För att skapa flera händelser av samma typ kan du högerklicka på händelsen och välja **Skapa en till**.
    >
    > ![Skapa en till -screenshot][img2]

1. När alla händelser och dokument i en projektstatus är slutförda, går du till nästa status.

    > [!NOTE]
    > Om du vill kan du gå till nästa status utan att skapa eller slutföra alla händelser/dokument i en status.

1. Upprepa stegen ovan för alla händelser/dokument i varje status i projektguiden.

## <a id="move-to-next-status" />Gå till nästa status

Du kan flytta projektet till nästa status på två olika sätt:

* Så här flyttar du projektet till nästa status automatiskt:

    I Inställningar och underhåll kan du ange att projektguiden ska föreslå att flytta projektet till nästa status när den sista händelsen i en status markeras som slutförd. Då öppnas dialogrutan **Projektguide – flytta projektet till nästa status**.

    Klicka på **Ja** för att flytta projektet till nästa status, eller klicka på **Nej** för att fortsätta jobba med projektet i samma status.

* Så här flyttar du projektet till nästa status manuellt:

    Högerklicka på knappen för nästa status på detaljkortet **Projektguide** och välj **Gå till den här statusen**.

    Eller gör följande på huvudkortet **Projekt**:

    1. Klicka på **Redigera** på huvudkortet för **Projekt**.
    1. Klicka på pilen bredvid fältet **Status**.
    1. Välj önskad status i listan som visas. [!include[SM](../../../learn/includes/are-defined-sm.md)]
    1. Klicka på **Spara**.

## Exempel

Tänk på att dina projektguider kan konfigureras på andra sätt i Inställningar och underhåll.

### Registrera ett nytt projekt och välj projekttyp

Du registrerar ett nytt projekt och väljer projekttypen **Konferens**, som är kopplad till en projektguide. Projektguiden kan till exempel ha följande statusar, händelser och dokument:

| Status | Uppföljningar | Dokument |
|---|---|---|
| Planerat | Planeringsmöte (Möte inne) | Konferensprogram (Anteckning) |
| Under arbete | Skapa lista över projektdeltagare (Händelse) | Konferensen (Möte ute) |
| Avslutas | Utvärderingsmöte (Möte inne) |
| Utvärderingsrapport (Anteckning) |

### Statusen Planerat

1. Du har bokat in en mötestidpunkt och vill skapa händelsen **Planeringsmöte** i kalendern och bjuda in deltagare.

    1. I projektguiden klickar du på knappen **Skapa** bredvid händelsen **Planeringsmöte**.
        Dialogrutan **Händelse** öppnas med **Möte inne** angivet som typ och namnet på projektet redan ifyllt.
    1. Fyll i information och [bjud in deltagare][2].
    1. Klicka på **Spara**.

1. På mötet bestämmer ni konferensprogrammet (agendan) och du vill skapa en anteckning som innehåller denna information.

    1. Klicka på knappen **Skapa** bredvid **Konferensprogram**.
        Dialogrutan **Dokument** öppnas, där **Anteckning** redan har valts som dokumentmall och namnet på projektet redan är ifyllt.
    1. Fyll i övrig information i fälten i dialogrutan **Dokument**.
    1. Klicka på knappen **Skapa** för att skapa och spara anteckningen.

1. När mötet är genomfört och konferensprogrammet är färdigt, anger du detta i projektguiden och går vidare till nästa projektstatus.

    I projektguiden markerar du kryssrutan bredvid händelsen **Planeringsmöte**.

    > [!TIP]
    > Du kan också göra det från aktivitetslistan i till exempel Kalender och Företag.

    1. Dialogrutan **Projektguide – flytta projektet till nästa status** öppnas.
    1. I den här dialogrutan får du frågan om du vill flytta projektet till nästa status, som är **Under arbete**.
    1. Klicka på **Ja** för att flytta projektet till nästa status.

    > [!NOTE]
    > Dialogrutan **Projektguide – flytta projektet till nästa status** öppnas eftersom det är definierat för projekttypen i Inställningar och underhåll.

### Statusen Under arbete

1. Alla händelser och dokument i statusen **Planerat** slutförs, och du har flyttat projektet med hjälp av dialogrutan **Projektguide – flytta projektet till nästa status**. Den här dialogrutan visas när du ställer in den sista händelsen på slutförd. Händelserna och dokumenten för den senaste statusen visas nu på detaljkortet **Projektguide**.

    > [!NOTE]
    > Dialogrutan **Projektguide – flytta projektet till nästa status** visas bara om detta är definierat för projekttypen. Om detta inte är definierat, [flytta projektet till nästa status](#move-to-next-status).

1. På planeringsmötet enades ni om att din kollega ska sätta upp listan över deltagarna på konferensen. Du vill skapa en uppgift i deras kalender som en påminnelse.

    1. Klicka på **Skapa** bredvid händelsen **Skapa lista över projektdeltagare**.
        Dialogrutan **Överför uppgiften till en projektdeltagare** visas.

    1. På listan över projektdeltagare väljer du den person som ska ha ansvaret för händelsen och klickar på **OK**.

    1. Fyll i den information som behövs och klicka på **Spara**. (På fliken **Detaljer** kan du se att din kollega redan är angiven som ägare av uppgiften.)

    1. Händelsen visas i din kollegas kalender, och när kollegan har konfigurerat listan, ställer han/hon in händelsen som **Slutfört**.

        > [!NOTE]
        > Dialogrutan **Överför uppgiften till en projektdeltagare** öppnas eftersom detta har definierats i Inställningar och underhåll.

1. Nu vill du skapa ett brev med en inbjudan.

    Klicka på **Skapa** bredvid dokumentet **Konferensinbjudan** och [skapa dokumentet][3].

1. Till slut ska själva konferensen hållas. Du skapar mötet **Konferens**.

    1. Klicka på **Skapa** bredvid händelsen **Konferens**.
        Dialogrutan **Händelse** öppnas med **Möte ute** angivet som typ och namnet på projektet redan ifyllt.
    2. Fyll i information och bjud in konferensdeltagarna som vanligt.
    3. Klicka på **Spara**.

### Statusen Avslutning

1. När konferensen och alla relevanta händelser och dokument i statusen **Under arbete** är slutförda, går du till sista statusen i projektguiden, vilken är **Avslutning**.

    * Klicka på **Ja** i dialogrutan **Projektguide – flytta projektet till nästa status**.
        eller
    * Klicka på **Redigera** på huvudkortet **Projekt**, klicka på pilen till höger om fältet **Status** och välj **Avslutning** i listan och klicka på **OK**.

1. Du vill hålla ett internt möte för att följa upp konferensen.

    1. Klicka på **Skapa** bredvid händelseen **Utvärderingsmöte**, fyll i den information som behövs och klicka på **Spara**.
    2. När möten är slutförd, markerar du i kryssrutan.

1. Sedan vill du skapa en utvärderingsrapport som sammanfattar utvärderingsmötet och konferensen.

    Klicka på **Skapa** bredvid dokumentet **Utvärderingsrapport** för att skapa dokumentet.

När alla önskade händelser och dokument för projektet är färdiga kan du ställa in projektet på slutfört.

## Relaterade ämnen

* [Dialogrutan Dokument][1]
* [Dialogrutan för händelser][2]
* [Lägg till och redigera projektguider i Inställningar och underhåll][4]

<!-- Referenced links -->
[1]: ../../../diary/learn/invitation/add-participant.md
[2]: ../../../diary/learn/create-follow-up.md
[3]: ../../../document/learn/edit.md
[4]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/project/project-guide-create.png
[img2]: ../../../../media/loc/en/project/project-guide-right-click.png
