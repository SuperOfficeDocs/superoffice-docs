---
uid: help-sv-screen-designer-edit-layout
title: Redigera layout på huvudkort
description: I den här guiden förklarar vi hur du redigerar en layout.
keywords: skärmdesigner, layout, fält, fliklayout
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
topic: howto
language: sv
audience: settings
audience_tooltip: Settings and maintenance
---

# Redigera layout - Huvudkort

När du har [skapat en ny layout][4] är det dags att anpassa den utifrån behoven hos den/de tilldelade användargruppen/-grupperna. Om du anpassar en layout för säljteamet, bör du ha en tydlig plan för vad deras behov är när det gäller layout och formatering av flikarna, fälten, element och kolumner på huvudkortet. Vilken information ska visas först och vara enklast att hitta? Behöver de alla fält och flikar? Vad är den logiska ordningen för fälten?

Anpassa layouten för huvudkorten och arkiven så att de matchar organisationens informationsbehov. När du redigerar layouten på ett huvudkort kan du lägga till och ta bort fält eller ordna om ordningen så att den passar teamets behov. Först måste du veta vilken information som är viktigast för teamet.

Titta på den här videon och ta reda på hur du använder skärmdesignern för att konfigurera dina skärmar i SuperOffice CRM eller följ steg-för-steg-guiden nedan (videons längd – 6:41):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/EcL4TEXXvmU]

## Steg

<!-- markdownlint-disable MD029 -->
[!include[Go to screen designer](includes/goto-screen-designer.md)]
<!-- List starts in the include. Next line MUST be 3. -->
3. Klicka på **Huvudkort**.

4. Välj en layout i listan till vänster.

5. Klicka på **Redigera layout** under förhandsgranskningen.

6. I fönstret **Redigera kortlayout** kan du redigera layouten enligt beskrivningen nedan.

7. När du är färdig, klickar du på en av följande knappar:

    * **Spara utkast**: Klicka på den här knappen om layouten inte är klar ännu.
    * **Spara + publicera**: Klicka på den här knappen för att publicera layouten till de valda användargrupperna.
    * **Avbryt**: Klicka på den här knappen för att [ta bort alla ändringar](#undo-changes).
<!-- markdownlint-restore -->

## Redigera befintliga fält i layouten

1. Välj fliken som du vill redigera.

2. Redigera befintliga fält:

    * Flytta fält genom att klicka på ![ikon][img4] till vänster om en fältetikett och dra och släpp sedan fältet till en ny position. För att lägga till ett nytt fält, se [Fält](#fields).

    * Ta bort fält genom att hålla muspekaren över ett fält och klicka på ![ikon][img2]. Borttagna fält kan läggas till igen från avsnittet **Fält**. Obligatoriska fält kan inte tas bort, och knappen **Ta bort** visas därför inte för sådana fält. Se [Fält](#fields).

    * Redigera fältformatering (till exempel teckensnittsformat) och andra inställningar genom att klicka på fältet. Ikonen **Konfiguration** öppnas i den vänstra delen av fönstret. Se [Konfiguration](#settings).

3. [Ändra antalet kolumner i en flik](#columns) från avsnittet **Fliklayout**.

4. Spara beskrivningarna enligt beskrivningen ovan.

![Ta bort, lägg till och flytta de olika fälten i layouten -screenshot][img3]

## Lägg till nytt innehåll i en layout

1. Markera fliken som du vill redigera eller klicka på ![ikon][img5] **Lägg till** för att [lägga till en ny flik](#tabs).

2. Redigera layouten genom att välja något av följande alternativ:

    * **Fält**: Dra [fält](#fields) från listan till layouten. Fält kan placeras i kolumnerna och i sidhuvudet och sidfoten.

    * **Objekt**: Dra olika objekt som etiketter, avdelare, länkar och knappar till layouten.

    * **Konfiguration**: Klicka på ett fält eller ett objekt i layouten för att redigera relevanta inställningar. Vilka inställningar som är tillgängliga kan variera beroende på vilket objekt som har markerats. Se [Konfiguration](#settings).

    * **Fliklayout**: [Välj hur många kolumner som du vill visa i en flik](#columns).

3. Efter du har anpassat skärmlayouten, klickar du på någon av följande knappar:

    * **Spara utkast**: Klicka på den här knappen om layouten inte är klar ännu.
    * **Spara + publicera**: Klicka på den här knappen för att publicera layouten till de valda användargrupperna.
    * **Avbryt**: Klicka på den här knappen för att ta bort alla ändringar.

Rutor med streckade linjer i layouten visar var du kan placera ett fält:

![Rutor med fasta linjer -screenshot][img6]

Nedan hittar du mer detaljerade beskrivningar av de olika avsnitten och funktionerna.

## <a id="fields"></a>Fält

I avsnittet **Fält** hittar du alla tillgängliga datafält för den valda skärmlayouten. Använd filterfunktionen för att hitta specifika fält.

* Dra ett fält från listan till ett streckat område i den valda fliken.
* För att se till att ett fält alltid är synligt oavsett vilken flik som är markerad, placerar du fältet i sidhuvudet eller sidfoten.
* Du kan placera samma fält på flera ställen i skärmlayouten om det är relevant.
* Flytta fält genom att klicka på ![ikon][img4] till vänster om en fältetikett och dra och släpp sedan fältet till en ny position. För att flytta ett fält till en annan flik, drar du fältet till flikrubriken för att öppna fliken och placerar sedan fältet i den öppna fliken.
* Ta bort fält genom att hålla muspekaren över ett fält och klicka på ![ikon][img2]. Obligatoriska fält kan inte tas bort, och knappen **Ta bort** visas därför inte för sådana fält.

**Begränsningar:**

* Obligatoriska fält kan inte tas bort. Detta definieras i skärmen [Fält][3].
* Vissa flikar som **ERP** och **Anteckning** kan inte redigeras, eftersom de har specifika funktioner.

## Objekt

I avsnittet **Objekt** kan du lägga till olika icke-data-objekt såsom etiketter, avdelare, länkar och knappar.

## <a id="settings"></a>Inställningar

Gör fälten mer synliga genom att ändra fonten till fetstil och stor text. Gör plats för fler fält genom att använda en mindre font. Spara skärmyta genom att dölja etiketter.

Klicka på ett fält eller ett objekt i layouten för att redigera dess inställningar. Den tillgängliga inställningen kommer att variera beroende på typ av fält eller objekt.

## <a id="columns"></a>Fliklayout

Som standard har en flik 2 kolumner, men du kan använda allt från 1-4 kolumner beroende på dina behov. Användare med breda skärmar kan föredra fler kolumner för att visa och sortera mer data.

**Begränsningar:**

* Om du ändrar från 2-4 kolumner till 1 kolumn flyttas alla fält in i 1 kolumn.
* Om du använder 4 kolumner kommer det att påverka synligheten för vissa fält. Överväg eventuellt att dölja etiketterna för vissa fält (se [Konfiguration](#settings)).
* Vissa flikar som **ERP** och **Anteckning** har inte någon kolumnkonfiguration, eftersom de har specifika funktioner.
* Om en användare inte har en skärmstorlek som gör att alla kolumner ryms, staplas de ovanpå varandra.

## <a id="tabs"></a>Flikar

Lägg till fler flika för ytterligare fält, eller ta bort irrelevanta flikar.

**För att ta bort en flik:**

1. Markera fliken och klicka på **Uppgift** > **Ta bort**.
2. Klicka på **OK** i dialogrutan som visas.

**Så här lägger du till en ny flik:**

1. Klicka på ![ikon][img5] **Lägg till**. Avsnittet **Fliklayout** öppnas till vänster.
2. Under **Flikrubrik** byter du ut texten **Ny flik** mot det nya namnet på fliken.
3. Du kan också [lägga till fliknamnet på andra språk][2] genom att klicka på ![ikon][img1].
4. Välj antal kolumner som du vill använda i den nya fliken.

> [!TIP]
> Om du senare skulle vilja byta namn på fliken, markerar du fliken och väljer **Fliklayout**.

**Begränsningar:**

* Du kan inte byta namn på standardflikar.
* Du kan inte ta bort flik som innehåller obligatoriska fält. Obligatoriska fält måste först flyttas till en annan flik.
* Om bara en flik, återstår kan du inte ta bort den.

## <a id="undo-changes"></a>Ångra ändringar

Om du behöver återgå till en tidigare version av skärmen, kommer du åt följande alternativ från **Uppgift**-knappen:

* **Återställ till fabriksinställningar**: Det här alternativet tar bort alla ändringar och återställer skärmlayouten till den standardlayout som levereras av SuperOffice.
* **Ignorera utkast**: Tar bort alla ändringar och återställer till den publicerade versionen av skärmlayouten.

<!-- Referenced links -->
[2]: ../../../globalization-and-localization/learn/translate-fields.md
[3]: ../../../custom-objects/learn/udef.md
[4]: add-new-layout.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/az.png
[img2]: ../../../../../common/icons/delete-circle-red.png
[img4]: ../../../../media/icons/criteria-move.png
[img5]: ../../../../../common/icons/add-icon.png
[img3]: ../../../../media/loc/en/ui/edit-the-screen-layout-of-companies-and-contacts.png
[img6]: ../../../../media/loc/en/ui/screendesigner-field-place.png
