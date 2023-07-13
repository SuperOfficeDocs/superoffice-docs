---
uid: help-sv-request-create
author: Hanne Gunnarsson
title: Skapa ett ärende
description: Skapa ett ärende
so.date: 02.20.2023
keywords: ärende
so.topic: howto
so.audience: person
so.audience.tooltip: SuperOffice Service
language: sv
---

# Skapa ett ärende

Ett ärende kan komma in i systemet via ett e-postmeddelande från kunden, eller så kan du registrera det manuellt via skärmen **Nytt ärende**. Det kan bli aktuellt om en kund kontaktar dig via telefon.

## Arbetsflöde

1. Välj **Nytt** > **Ärende**.

1. I fältet **Titel** ger du ärendet ett beskrivande namn.

1. Lägg till en kontakt i fältet **Sök efter kontakt**.
   Vill du inte lägga till en kontakt? Du kan skapa ett ärende utan att lägga till en kontakt och lägga till denna information senare, om du har bråttom.

1. När du skapar ett nytt ärende har fältet **Till** följande användningsområden:

    * Som standard blir de kontakter som anges här även kontakter för det nya ärendet.
    * Om du anger fler än en kontakt är den första kontakten huvudkontakt för ärendet. Du kan klicka på och dra kontakterna för att ändra ordningsföljden.

    Börja skriva namn (eller telefonnummer) för kontakten i fältet **Kontakt** (sök efter kontakt). I listan med sökresultat användare du upp- och nedpilarna på tangentbordet för att välja en kontakt och trycker sedan på **ENTER**. Eller använd din muspekare för att välja kontakten.

    Alternativt kan du ange en e-postadress för att lägga till en mottagare utan att registrera personen i systemet. I så fall läggs personen inte till som kontakt för ärendet.
    </details>

    > [!NOTE]
    > Du kan lämna det här fältet tomt om du inte vill skicka meddelandet till någon.

1. Tillval: Klicka på knappen **Kopia/Hemlig kopia** längst till höger om du vill lägga till kontakter som ska få en kopia eller en hemlig kopia.

1. Gå till panelen **Egenskaper** på höger sida av skärmen och ange information för att på rätt sätt tilldela och prioritera ärendet.

   * I listrutan **Status** väljer du något av följande alternativ:
     * **Aktivt**: Välj detta om ärendet är under arbete.
     * **Avslutat**: Välj detta om ärendet är slutfört.
     * **Uppskjutet**: För att skjuta upp behandlingen av ärendet, välj detta alternativ för att specificera ett datum och en tid i fältet **Angivet** eller en förinställd tid nedan. På detta datum och denna tid återställs ärendet till **Aktivt**.

   * Välj ett av följande alternativ i fältet **Ägare**:
     * För att tilldela ärendet till en viss person väljer du önskat namn. Välj ditt eget namn för att tilldela ärendet till dig själv.
     * **(Tilldelas automatiskt)**: Om du väljer detta alternativ tilldelas ärendet enligt gällande tilldelningsregler.
     * **(Otilldelat)**: Du kan även välja att inte tilldela någon ärendet. Då blir medlemmarna i den aktuella kategorin ansvariga för att ta hand om ärendet.

   * Klicka i fältet **Kategori**, välj önskad kategori i den lista som visas.

   * I listrutan **Prioritet** kan du välja mellan **Låg**, **Medel** och **Hög** eller också kan du ange att systemet ska sätta prioriteten automatiskt. Det kan göras till exempel baserat på [eskaleringsnivåerna][3] som har angetts för olika kontakter och företag.

   * I listrutan **Åtkomstnivå för ärende** kan du välja bland följande alternativ:
     * **Externt**: Välj detta om kontakten ska ha tillgång till ärendet via SuperOffice Customer Centre.
     * **Internt**: Välj detta om kontakten inte ska ha tillgång till ärendet. Ärendet visas i SuperOffice Customer Centre, men kontakten kan inte visa ärendedetaljerna eller meddelandena.

   * I listrutan **Taggar** [väljer du relevanta taggar][4] för ärendet.

1. I fliken **Meddelande** skriver du det [meddelande](#message) som du vill lägga till i ärendet.

1. Klicka på **Skicka** för att skicka och spara ärendet.

## <a id="message" />Meddelanden

> [!NOTE]
> För att skicka meddelandet till någon, lägg till mottagare i fältet **Till** under flikarna. För att göra meddelandet tillgängligt för kontakten via SuperOffice Customer Centre, ange åtkomstnivån (för meddelandet) till **Externt**.

Här skriver du det meddelande som du vill lägga till i ärendet. Detta fungerar på samma sätt som när du skriver in text i ett ordbehandlingsprogram. Du kan också lägga till bilagor, [svarsmallar][2] och vanliga frågor i meddelandet.

Längst ned på skärmen visas dessutom följande alternativ:

* ![ikon][img1] – Klicka här för att visa eller dölja verktygsfältet i meddelanderedigeraren
* ![ikon][img2] – Klicka här om du vill visa alternativen för bilagor. Här kan du lägga till relevanta dokument som bilagor i ärendet.
  * Klicka på **Ladda upp filer (eller dra dem hit)** och bläddra och lägg till en fil från en disk eller server.
  * Dra och släpp en fil från Windows Utforskaren till bilagefältet.
  * Klicka på **Välj ett CRM-dokument** och välj ett dokument i SuperOffice CRM.
* **Klistra in**: Klicka på listknappen ![ikon][img3] och välj det som du vill infoga i meddelandet. Du kan lägga till en svarsmall, en FAQ-post, ett tidigare meddelande eller en bilaga. Tillval: Du kan också [lägga till svarsmallar på andra språk][7]. Välj ett språk i språklistan. Om det finns tillgängligt infogas texten på det valda språket. Annars används standardspråket.
* **Internt/Externt**: Här kan du välja **Externt** om kontakten ska ha åtkomst till meddelandet via SuperOffice Customer Centre, eller **Internt** om kontakten inte ska ha åtkomst till meddelandet.
* **Förbrukad tid**: Här kan du registrera hur lång tid som har använts på hantering av meddelandet. Klockan startar automatiskt när du skapar ärendet. Du kan stanna klockan genom att klicka på stoppknappen ![ikon][img4] och även starta om klockan genom att klicka på startknappen ![ikon][img5]. Klicka på ![ikon][img6] (**Välj tidsperiod**) för att registrera den förbrukade tiden.

> [!NOTE]
> Standardärendesignaturen läggs till i meddelandet. Du kan redigera signaturen direkt i meddelandet eller redigera din [standardsignatur för e-post][1].

## <a id="details" />Detaljer

Fliken **Information** innehåller ytterligare information om ärendet. Här hittar du information som när ärendet skapades, när det senast ändrades, stängdes eller besvarades, när det lästes av ägaren eller kontakten och extrafält. Den här informationen uppdateras automatiskt under ärendets livslängd, men det finns några fält som kan redigeras när ärendet skapas:

* **Relation**: Här kan du välja att koppla ärendet till ett annat ärende, om det nya ärendet är kopplat till ett annat befintligt ärende.
* **Åtkomstnivå**: Detta är ett annat sätt att ange åtkomstnivå för ärendet. Detta kan också göras på panelen **Egenskaper**. Om du ändrar åtkomstnivån här, ändras den automatiskt även på panelen **Egenskaper**.
* **Försäljning**: Här kan du koppla ärendet till ett befintligt ärende genom att söka efter det ärende du vill hitta eller välja det från listan.
* **Projekt**: Här kan du koppla ärendet till ett befintligt projekt genom att söka efter det projekt du vill hitta eller välja det från listan.

## Autospara

När du arbetar med ett ärende och plötsligt får ett annat som är mer brådskande måste du lämna ärendet du håller på med för att lösa det som är mer akut.

Funktionen autospara sparar automatiskt ändringarna tills du klickar på **Skicka** eller avbryter ändringarna i ditt ärende.
Autosparad information placeras i din webbläsares lokala lagringsutrymme, så dina data klarar sig även vid en webbläsarkrasch, omstart, utloggning och inloggning.

Funktionen autospara aktiveras som standard när du visar och redigerar ärenden och svara/svara alla.

### Begränsningar

* Data som sparats automatiskt överförs inte från en dator till en annan. Det innebär att du inte kan börja svara på ett ärende på jobbet och sedan fortsätta hemma.
* Data som sparats automatiskt delas inte mellan två olika webbläsare.
* Funktionen autospara är en användbar funktion, men den bör inte ersätta ett korrekt sätt att spara ditt arbete.

## Specifikation

På denna flik finns alla extrafält för ärenden. Detta varierar mellan olika företag.

## Vad vill du göra nu?

* [Redigera meddelande][5]
* [Hantera ärenden][8]
* [Redigera e-postsignatur][1]
* [Eskaleringsnivåer][3]
* [Använda taggar i ärenden][4]
* [Lägga till svarsmallar i meddelanden][2]
* [Skapa svarsmall][9]
* [Skapa ny språkversion av svarsmall][7]

<!-- Referenced links -->
[1]: ../../../learn/getting-started/edit-email-signature.md
[2]: reply.md#reply-templ
[3]: ../priority/escalation-levels.md
[4]: ../tags.md
[5]: edit-message.md
[7]: ../../reply-templates/learn/new-language.md
[8]: ../index.md
[9]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/format-font.png
[img2]: ../../../../../common/icons/attachments-theme.png
[img3]: ../../../../../common/icons/copy-paste-icon.png
[img4]: ../../../../../common/icons/stop.png
[img5]: ../../../../../common/icons/play.png
[img6]: ../../../../../common/icons/timespan.png
