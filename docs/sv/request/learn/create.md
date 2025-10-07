---
uid: help-sv-request-create
title: Skapa ett ärende
description: Skapa ett ärende
keywords: skapa ärende, nytt ärende, ärende
author: Bergfrid Dias
date: 07.01.2025
version: 11.2
content_type: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: sv
redirect_from: /sv/request/learn/howto/create
---

# Skapa ett ärende

Ett ärende kan komma in i systemet via ett e-postmeddelande från kunden, eller så kan du registrera det manuellt via skärmen **Nytt ärende**. Detta kan bli aktuellt om en kund kontaktar dig via telefon.

## Arbetsflöde

1. Klicka på **Nytt** i toppraden och välj **Ärende**.

    Alternativt, om du är i detaljfanen **Ärenden** på en kontakt, klicka på **Lägg till** för att skapa ett ärende med kontakten förifylld.

1. I fältet **Titel** anger du ett beskrivande namn på ärendet.

1. Lägg till en kontakt i fältet **Sök efter kontakt** (om inte förifyllt). Börja skriva kontaktens namn (eller telefonnummer) och välj från resultatlistan.
    * Om du har bråttom kan du hoppa över detta steg och lägga till kontakten senare.

1. Använd panelen **Egenskaper** på höger sida för att tilldela och prioritera ärendet.

    * Välj **Ärendetyp**, **Status**, **Ägare**, **Kategori**, **Prioritet** och andra egenskaper.

    > [!NOTE]
    > Ärendetypen påverkar standardvärden och tillgängliga statusar och prioriteringar.

1. Gå till panelen **Meddelanden** för att skriva meddelandet för ärendet:

    * I fältet **Till**, lägg till mottagare genom att skriva in kontaktens namn eller e-post och välj från listan.
    * Tillval: Klicka på **Kopia/Hemlig kopia** om du vill lägga till fler mottagare som kopia eller hemlig kopia.
    * Skriv meddelandetext, bifoga filer eller infoga svarsmallar.

    > [!NOTE]
    > Standardsignaturen för ärenden läggs till automatiskt i meddelandet. Du kan redigera den direkt i meddelandet eller ändra din [e-postsignatur][11].

1. Gå till fliken **Detaljer** om du vill koppla ärendet till en befintlig försäljning eller ett projekt.

1. Klicka på **Skicka** för att spara och skicka ärendet.

![Egenskaper och meddelande för nytt ärende -screenshot][img1]

## <a id="fields"></a>Nyckelfält förklarade

<a id="message"></a><a id="details"></a>
Följande fält är tillgängliga i ärendeskärmen. Vissa fält fylls i automatiskt, medan andra kräver inmatning.

> [!NOTE]
> Fält och layout kan variera beroende på [Skärmdesigner][10] och andra UI-anpassningar.

<!-- markdownlint-disable-file MD051 -->
### [Fliken Meddelanden](#tab/messages)

Här skriver och hanterar du ärendets meddelande.

* Lägg till mottagare i fältet **Till**.
  * Mottagare läggs automatiskt till som kontakter för ärendet. Den första mottagaren blir huvudkontakt.
  * Du kan lägga till flera mottagare och ordna om dem genom att klicka och dra.
  * Om du vill inkludera en mottagare utan att registrera dem som kontakt kan du ange deras e-postadress. De får meddelandet men visas inte som en ärendekontakt.
  * Lämna fältet tomt om du inte vill skicka meddelandet.
* Klicka på **Kopia/Hemlig kopia** för att lägga till ytterligare mottagare som kopia eller hemlig kopia.
* Inkludera meddelandetext, bilagor, [svarsmallar][2] eller FAQ-poster.
* Använd **Intern/Extern** för att ange om kontakten kan se meddelandet i Kundcentret.
* Använd timern för att registrera tiden du lagt på att hantera ärendet.

Meddelanderedigeraren fungerar som en ordbehandlare och låter dig skriva, formatera och förbättra dina meddelanden. Nedan följer de viktigaste verktygen och deras funktioner:

| Ikon | Åtgärd | Beskrivning |
|:-:|---|---|
| <i class="ph ph-text-a-underline" aria-label="Visa/dölj verktygsfält"></i> | Verktygsfält | Visa eller dölj textformateringsalternativ. |
| <i class="ph ph-paperclip" aria-label="Bilagor"></i> | Bilagor | Lägg till filer eller CRM-dokument i meddelandet. |

#### Bilagor

Så här bifogar du filer eller CRM-dokument:

1. Klicka på <i class="ph ph-paperclip" aria-label="Bilagor"></i>. Ett fält för bilagor visas under fältet **Till**.
1. Lägg till bilagor med något av följande alternativ:
    * Klicka på **Ladda upp filer (eller dra hit)** för att välja en fil från din dator.
    * Dra och släpp filer direkt i fältet **Bilagor**.
    * Klicka på **Välj ett CRM-dokument** för att välja en fil lagrad i SuperOffice CRM.

#### Infoga

Så här lägger du till extra innehåll i ditt meddelande:

1. I **Egenskaper**-panelen, klicka på <i class="ph ph-article" aria-label="Infoga"></i>.
1. Välj vad du vill infoga:
    * **Svarsmall**: Infoga en förskriven textmall.
    * **FAQ-post**: Lägg till en artikel från kunskapsbasen.
1. Om svarsmallar finns på flera språk kan du välja språk.

#### Förbrukad tid

Klockan startar automatiskt när du skapar ärendet. Du kan stoppa klockan genom att klicka på <i class="ph ph-pause" aria-label="Pausa"></i> och starta den igen genom att klicka på <i class="ph ph-play" aria-label="Starta"></i>. För mer information om tidsregistrering, se [Registrera förbrukad tid][3].

### [Fliken Detaljer](#tab/details)

Fliken **Detaljer** innehåller ytterligare information om ärendet. Här hittar du uppgifter som när ärendet skapades, när det senast ändrades, stängdes eller besvarades, samt när det lästes av ägaren eller kontakten. Informationen uppdateras automatiskt under ärendets livscykel, men vissa fält kan redigeras när ärendet skapas:

* **Relation**: Koppla detta ärende till ett annat relaterat ärende.
* **Åtkomstnivå**: Ett alternativt sätt att justera synligheten för ärendet. Ändringar här återspeglas automatiskt i panelen **Egenskaper**.
* **Försäljning/Projekt**: Koppla ärendet till en befintlig försäljning eller ett projekt.
* **Extrafält**: Ytterligare [anpassade fält][16] baserade på företagets inställningar.

### [Panelen Egenskaper](#tab/properties)

Panelen **Egenskaper** gör det möjligt att kategorisera och tilldela ärendet.

* **Ärendetyp**: Bestämmer standardvärden och tillgängliga statusalternativ.
* **Status**: Ange status som **Aktivt** (pågående), **Avslutat** (färdigt) eller **Uppskjutet** med en angiven återaktiveringstid.
* **Ägare**: Tilldela ärendet till dig själv, en annan användare eller lämna det otilldelat.
  * **(Tilldelas automatiskt)**: Systemet tilldelar ärendet enligt tilldelningsreglerna.
  * **(Otilldelat)**: Kategorimedlemmarna delar på ansvaret för ärendet.
* **Kategori**: Välj rätt kategori för ärendet.
* **Prioritet**: Ange **Låg**, **Medel** eller **Hög**, eller låt systemet bestämma det (exempelvis baserat på [eskaleringsnivåer][9]).
* **Åtkomstnivå**: Ange **Externt** (synligt för kontakten) eller **Internt** (dolt för kontakten).
* **Taggar**: [Lägg till relevanta taggar][4] för att organisera och söka efter ärendet senare.

> [!TIP]
> Om panelen inte visar egenskaper som i föregående skärmbild, klicka på <i class="ph ph-list-bullets" aria-hidden="true"></i> för att växla vy.

***

## Autospara

När du arbetar med ett ärende och plötsligt får ett annat som är mer brådskande måste du lämna ärendet du håller på med för att lösa det som är mer akut.

Funktionen autospara sparar automatiskt ändringarna tills du klickar på **Skicka** eller avbryter ändringarna i ditt ärende.
Autosparad information placeras i din webbläsares lokala lagringsutrymme, så dina data klarar sig även vid en webbläsarkrasch, omstart, utloggning och inloggning.

Funktionen autospara aktiveras som standard när du visar och redigerar ärenden och svara/svara alla.

### Begränsningar

* Data som sparats automatiskt överförs inte från en dator till en annan. Det innebär att du inte kan börja svara på ett ärende på jobbet och sedan fortsätta hemma.
* Data som sparats automatiskt delas inte mellan två olika webbläsare.
* Funktionen autospara är en användbar funktion, men den bör inte ersätta ett korrekt sätt att spara ditt arbete.

## Relaterat innehåll

* [Redigera e-postsignatur][11]
* [Använda taggar i ärenden][4]
* [Mallvariabler för svarsmallar][18]
* [Skapa svarsmall][19]

<!-- Referenced links -->
[2]: reply.md#reply-templ
[3]: reply.md#time-spent
[4]: tags.md
[9]: ../admin/priority/escalation-levels.md
[10]: ../../customization/screen-designer/admin/index.md
[11]: ../../learn/getting-started/edit-email-signature.md
[16]: ../../custom-objects/admin/create-extra-field.md
[18]: ../../knowledge-base/learn/reply-templates/template-variables.md
[19]: ../../knowledge-base/learn/reply-templates/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/create-request.png
